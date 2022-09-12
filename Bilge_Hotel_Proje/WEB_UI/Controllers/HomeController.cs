using BLL.Concrete;
using DAL.Context;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_UI.Models;

namespace WEB_UI.Controllers
{
    public class HomeController : Controller
    {
        BilgeHotelContext db = new BilgeHotelContext();
        MusteriConcrete musteriConcrete = new MusteriConcrete();
        OdaConcrete odaConcrete = new OdaConcrete();
        
        public ActionResult Index()
        {
            TempData["Odalar"] = db.Odalar.ToList();
            TempData["TatilPaketleri"] = db.TatilPaketleri.ToList();
            
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(KullaniciVM kullaniciVM)
        {
            if (ModelState.IsValid)
            {
                Musteri musteri = new Musteri();
                musteri.Ad = kullaniciVM.Ad;
                musteri.Soyad = kullaniciVM.Soyad;
                musteri.TCKN = kullaniciVM.TCKN;
                musteri.TelNo = kullaniciVM.TelNo;
                musteri.Email = kullaniciVM.Email;
                musteri.Password = kullaniciVM.Password;
                var result = musteriConcrete.Create(musteri);
                TempData["info"] = result;


                return RedirectToAction("Login");

            }
            else
            {
                return View(kullaniciVM);
            }

        }
       public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                bool result = db.Musteriler.Any(x => x.Email == loginVM.Email && x.Password == loginVM.Password);

                if (result)
                {
                    Musteri musteri = db.Musteriler.Where(x => x.Email == loginVM.Email && x.Password == loginVM.Password).FirstOrDefault();

                    Session["rez"] = musteri;
                    return RedirectToAction("Index");
                }

                else
                {
                    TempData["error"] = "Kullanıcı bilgileri hatalı! (Kullanıcı degilseniz rezervasyon işlemi yapamazsınız! )";

                    return View(loginVM);
                }
            }

            else
            {
                return View(loginVM);
            }
        }

        public ActionResult AddToCard(int odaId, int tatilid)//50000
        {
            try
            {
                Rezervasyon rezervasyon = new Rezervasyon();
                TatilPaketi tatilPaketi = db.TatilPaketleri.Find(tatilid);
                Oda oda = db.Odalar.Find(odaId);


                Card c = null;

                if (Session["scart"] == null)
                {
                    c = new Card();
                }
                else
                {
                    c = Session["scart"] as Card;
                }

                //Cart c = Session["scart"] == null ? new Cart() : Session["scart"] as Cart;
                if(oda.OdaDurumu==DAL.Enums.OdaDurumu.Musait)
                {
                    CardItem ci = new CardItem();
                    ci.RezervasyonID = rezervasyon.RezervasyonID;
                    ci.OdaID = rezervasyon.OdaID;
                    ci.TatilPaketiID = rezervasyon.TatilPaketiID;
                    ci.TatilPaketiFiyati = tatilPaketi.Fiyat;
                    ci.OdaFiyati = oda.Fiyat;
                    ci.KonaklamaBaslangic = rezervasyon.KonaklamaBaslangic;
                    ci.KonaklamaBitis = rezervasyon.KonaklamaBitis;
                    ci.RezervasyonTarihi = rezervasyon.RezervasyonTarihi;
                    ci.GunSayisi = rezervasyon.GunSayisi;
                    ci.ToplamFiyat = rezervasyon.ToplamFiyat;

                    c.AddRez(ci);
                    db.SaveChanges();
                    Session["scart"] = c;

                    return RedirectToAction("RezervasyonCard");
                }
                else
                {
                    TempData["odadurumu"] = $"{odaId} seçtiğiniz oda musait degil!";
                    return View();
                }
                
            }
            catch (System.Exception)
            {
                TempData["error"] = $"{tatilid} karşılık gelen bir şey bulunamadı!";
                return View();

            }

        }

        public ActionResult RezervasyonCard()
        {
            if (Session["scart"] != null)
            {
                return View();
            }
            else
            {
                TempData["error"] = "sepetinizde ürün bulunmamaktadır!";
                return RedirectToAction("Index");
            }

        }

        public ActionResult CompleteCart()
        {
            Card card = Session["scart"] as Card;
            foreach (var item in card.myCard)
            {
                Oda oda = db.Odalar.Find(item.OdaID);
                oda.OdaDurumu = DAL.Enums.OdaDurumu.Dolu;
                odaConcrete.Update(oda);
                db.SaveChanges();


            }
            //ViewBag.OrderNumber = "";
            Session.Remove("scart");
            return View();
        }





    }
   
}