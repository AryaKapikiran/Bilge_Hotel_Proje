namespace DAL.Migrations
{
    using DAL.Entity;
  
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Context.BilgeHotelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DAL.Context.BilgeHotelContext context)
        {
           
            //Calisanlar
            List<Calisan> calisanlar = new List<Calisan>()
            {
                new Calisan{ FirstName="Selahattin", LastName="Alkomut", Email="s.alkomut@bilgeotel.com", Gorev= "İnsan Kaynakları yöneticisi",Password="1234"/*Maas=8500,*/,Ucret=12000 },
                 new Calisan{FirstName="Levent", LastName="Sişarpsoy", Email="l.sisarpsoy@bilgeotel.com", Gorev="Satış/Otel yöneticisi",Password="1234"/*Maas=7500,*/,Ucret=34000},
                  new Calisan{ FirstName="Mehmet", LastName="Temiz", Email="m.temiz@bilgeotel.com", Gorev="Temizlik Görevlisi",Password="1234",Ucret=200,SaatSayisi=15,VardiyaZamani=Enums.VardiyaZamani.Ogle},
                  new Calisan{ FirstName="Sevim", LastName="Parlak", Email="s.parlak@bilgeotel.com", Gorev="Temizlik Görevlisi",Password="1234",Ucret=200,SaatSayisi=10,VardiyaZamani=Enums.VardiyaZamani.Sabah},
                  new Calisan {FirstName="Seyfettin",LastName="Karadibag",Ucret=20000, Email="s.karadibag@bilgeotel.com", Password="1234",Gorev="IT sorumlusu"},
                  new Calisan {FirstName="Gülay",LastName="Aydınlık",Ucret=8000, Email="g.aydinlik@bilgeotel.com", Password="1234",Gorev="Resepsiyon sorumlusu"},
                  new Calisan {FirstName="Ayşe",LastName="Kayıt",Ucret=500,SaatSayisi=10, Email="a.kayit@bilgeotel.com", Password="1234",Gorev="Resepsiyon görevlisi"}





            };
            if (!context.Calisanlar.Any())
            {
                foreach (var calisan in calisanlar)
                {
                    context.Calisanlar.Add(calisan);
                    context.SaveChanges();
                }
            }

            //Musteri

            List<Musteri> musteriler = new List<Musteri>()
            {
                new Musteri{Ad="Ayşe", Soyad="Tatilsoy", Email="a.tatilsoy@bilge.com", Password="1234",TCKN="12345678912",TelNo="055544332", },
                 new Musteri{Ad="Ali", Soyad="Gezisoy", Email="a.gezisoy@bilge.com", Password="1234",TCKN="12345678442",TelNo="055544331", },
                  new Musteri{Ad="Pinar", Soyad="Akar", Email="p.akar@bilge.com", Password="1234",TCKN="12345688912",TelNo="055544330", },
            };

            if (!context.Musteriler.Any())
            {
                foreach (var musteri in musteriler)
                {
                    context.Musteriler.Add(musteri);
                    context.SaveChanges();
                }
            }

            //Tatil Paketi

            List<TatilPaketi> tatilPaketleri = new List<TatilPaketi>()
            {
                new TatilPaketi{TatilPaketiName="Her sey dahil", Fiyat=2500},
                new TatilPaketi{TatilPaketiName="Tam Pansiyon", Fiyat=500}
            };

            if (!context.TatilPaketleri.Any())
            {
                foreach (var tatilpaketi in tatilPaketleri)
                {
                    context.TatilPaketleri.Add(tatilpaketi);
                    context.SaveChanges();
                }
            }

            //Oda Tipi
            List<Oda> odalar = new List<Oda>()
           {
               new Oda{OdaTipiName= Enums.OdaTipiName.TekKisilik,  Fiyat=200,OdaDurumu=Enums.OdaDurumu.Musait,OdaOzelligi="Birinci Kat,Tek Yatak, Balkonsuz,minibar , klima, tv, saç kurutma makinesi, kablosuz internet"},
               new Oda{OdaTipiName= Enums.OdaTipiName.TekKisilik,  Fiyat=200,OdaDurumu=Enums.OdaDurumu.Musait,OdaOzelligi="İkinci Kat,Tek Yatak, Balkonsuz,minibar , klima, tv, saç kurutma makinesi, kablosuz internet"},
               new Oda{OdaTipiName= Enums.OdaTipiName.CiftKisilik, Fiyat=300,OdaDurumu=Enums.OdaDurumu.Musait,OdaOzelligi="İkinci Kat,İki Ayrı Tek Yatak,Balkonsuz,minibar , klima, tv, saç kurutma makinesi, kablosuz internet"},
               new Oda{OdaTipiName= Enums.OdaTipiName.CiftKisilik, Fiyat=300,OdaDurumu=Enums.OdaDurumu.Musait,OdaOzelligi="İkinci Kat,İki Ayrı Tek Yatak,Balkonsuz,minibar , klima, tv, saç kurutma makinesi, kablosuz internet"},
               new Oda{OdaTipiName= Enums.OdaTipiName.CiftKisilik, Fiyat=300,OdaDurumu=Enums.OdaDurumu.Musait,OdaOzelligi="Üçüncü Kat,Duble Yatak,Balkonlu,minibar , klima, tv, saç kurutma makinesi, kablosuz internet"},
               new Oda{OdaTipiName= Enums.OdaTipiName.CiftKisilik, Fiyat=300,OdaDurumu=Enums.OdaDurumu.Musait,OdaOzelligi="Dördüncü Kat,Duble Yatak,Balkonlu,minibar , klima, tv, saç kurutma makinesi, kablosuz internet"},
               new Oda{OdaTipiName= Enums.OdaTipiName.UcKisilik,   Fiyat=400,OdaDurumu=Enums.OdaDurumu.Musait,OdaOzelligi="Birinci Kat,Üç ayrı yatak Balkonsuz,minibar , klima, tv, saç kurutma makinesi, kablosuz internet"},
                new Oda{OdaTipiName= Enums.OdaTipiName.UcKisilik,   Fiyat=400,OdaDurumu=Enums.OdaDurumu.Musait,OdaOzelligi="Üçüncü Kat,Bir Duble bir tekli yatak Balkonlu,minibar , klima, tv, saç kurutma makinesi, kablosuz internet"},
               new Oda{OdaTipiName= Enums.OdaTipiName.UcKisilik,   Fiyat=400,OdaDurumu=Enums.OdaDurumu.Musait,OdaOzelligi="Birinci Kat,Üç ayrı yatak Balkonsuz,minibar , klima, tv, saç kurutma makinesi, kablosuz internet"},
               new Oda{OdaTipiName= Enums.OdaTipiName.DortKisilik, Fiyat=500,OdaDurumu=Enums.OdaDurumu.Musait,OdaOzelligi="Dördüncü Kat,Bir adet duble yatak ve iki ayrı yatak, Balkonlu,minibar , klima, tv, saç kurutma makinesi, kablosuz internet"},
               new Oda{OdaTipiName= Enums.OdaTipiName.KralDairesi, Fiyat=100,OdaDurumu=Enums.OdaDurumu.Musait,OdaOzelligi="Dördüncü Kat,2 ayrı oda ve bir salon,Jakuzi,Balkonlu,minibar , klima, tv, saç kurutma makinesi, kablosuz internet"}
                                                                             
           };

            if (!context.Odalar.Any())
            {
                foreach (var oda in odalar)
                {
                    context.Odalar.Add(oda);
                    context.SaveChanges();
                }
            }

            //Rezervasyonlar 

            DateTime t1 = new DateTime(2022, 08, 01);
            DateTime t2 = new DateTime(2022, 08, 08);
            


            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>()
            {
                new Rezervasyon{KonaklamaBaslangic=t1,KonaklamaBitis=t2,TatilPaketiID=1,MusteriID=1,OdaID=1},
                new Rezervasyon{KonaklamaBaslangic=t1,KonaklamaBitis=t2,TatilPaketiID=1,MusteriID=2,OdaID=2},
            };

            if (!context.Rezervasyonlar.Any())
            {
                foreach (var rez in rezervasyonlar)
                {
                    context.Rezervasyonlar.Add(rez);
                    context.SaveChanges();
                }
            }

        }
    }
}
