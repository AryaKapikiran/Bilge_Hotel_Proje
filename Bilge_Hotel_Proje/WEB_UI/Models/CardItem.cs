
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_UI.Models
{
    public class CardItem
    {
        public CardItem()
        {
            RezervasyonTarihi = DateTime.Now;
            GunSayisi = 1;
        }

        

        public int RezervasyonID { get; set; }
        public int OdaID { get; set; }

        

        public int TatilPaketiID { get; set; }

        

        public decimal OdaFiyati { get; set; }

        public decimal TatilPaketiFiyati { get; set; }

        public DateTime KonaklamaBaslangic { get; set; }

        public DateTime KonaklamaBitis { get; set; }

        private int _gunSayisi;

        public int GunSayisi
        {
            get
            {
                _gunSayisi = KonaklamaBitis.Day - KonaklamaBaslangic.Day;

                return _gunSayisi;

            }

            set { _gunSayisi = value; }
        }

        public DateTime RezervasyonTarihi { get; set; } //rezervasyonun olusturuldugu gün olan tarih

        private decimal _toplamFiyat;

        public decimal ToplamFiyat
        {
            get
            {
                

                _toplamFiyat = (OdaFiyati + TatilPaketiFiyati) * GunSayisi;

                return _toplamFiyat;

            }

            set { _toplamFiyat = value; }


        }




    }
}