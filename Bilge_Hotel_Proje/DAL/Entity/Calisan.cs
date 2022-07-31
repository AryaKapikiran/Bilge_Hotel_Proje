using DAL.Context;
using DAL.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{

    public class Calisan : BaseEntity
    {
        BilgeHotelContext db = new BilgeHotelContext();

        public int CalisanID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? VardiyaID { get; set; }

        public int SaatSayisi { get; set; }



        public string Gorev { get; set; }



        public decimal Ucret { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }


        private decimal _maas;
        public decimal Maas
        {
            get

            {
                if (Gorev.Contains("yönetici"))
                {
                    _maas = Ucret;

                }
               else if (Gorev.Contains("yonetici"))
                {
                    _maas = Ucret;
                }
                else if (Gorev.Contains("sorumlusu"))
                {
                    _maas = Ucret;
                }

                else
                {
                    _maas = Ucret * SaatSayisi;
                }
                return _maas;

            }
            set { _maas = value; }
        }

        //1 calisanın 1 vardiyası olur

        public Vardiya Vardiya { get; set; }


    }





   


}

 

