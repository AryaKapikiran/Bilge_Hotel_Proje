using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public  class Vardiya:BaseEntity
    {
        //todo: 3 tip vardiya sistemine gecilecek
        public int VardiyaID { get; set; }

        public DateTime Baslangic { get; set; }

        public DateTime Bitis { get; set; }

        //Bir vardiyanın birden fazla calısanı olur

        public List<Calisan> Calisanlar { get; set; }
    }
}
