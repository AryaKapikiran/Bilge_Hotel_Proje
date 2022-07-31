using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Oda:BaseEntity
    {
       
        public int OdaID { get; set; }

        public OdaDurumu OdaDurumu { get; set; }

        public OdaTipiName OdaTipiName { get; set; } //odanın tipini belirtir, kral dairesi vs 

        public decimal Fiyat { get; set; }

        public List<Rezervasyon> Rezervasyonlar { get; set; }


        
    }
}
