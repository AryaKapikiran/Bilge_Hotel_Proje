using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Rezervasyon:BaseEntity
    {
        BilgeHotelContext db = new BilgeHotelContext();
        public Rezervasyon()
        {
            RezervasyonTarihi = DateTime.Now;
            GunSayisi = 1;
            
        }
        public int RezervasyonID { get; set; }

        public DateTime KonaklamaBaslangic { get; set; }

        public DateTime KonaklamaBitis  { get; set; }

        private int _gunSayisi;

        public int GunSayisi {
            get
            {
                _gunSayisi = KonaklamaBitis.Day - KonaklamaBaslangic.Day;

                return _gunSayisi;

            }

            set { _gunSayisi = value; }
        }

        public DateTime RezervasyonTarihi { get; set; } //rezervasyonun olusturuldugu gün olan tarih

        

       

        public int OdaID { get; set; }

        

        public int TatilPaketiID { get; set; }

        public Musteri Musteri { get; set; }

        public Oda Oda { get; set; }

        public TatilPaketi TatilPaketi { get; set; }

       

        public int MusteriID { get; set; }
       

        private decimal _toplamFiyat;

        public decimal ToplamFiyat 
        {
            get
            {
                Oda secilioda = db.Odalar.FirstOrDefault(x=>x.OdaID==OdaID);
                TatilPaketi seciliPaket = db.TatilPaketleri.FirstOrDefault(x=>x.TatilPaketiID==TatilPaketiID);
                 
                _toplamFiyat = (secilioda.Fiyat + seciliPaket.Fiyat) * GunSayisi;

                return _toplamFiyat;

            }

           set { _toplamFiyat = value; }
            
        
        }

        
        
    }
}
