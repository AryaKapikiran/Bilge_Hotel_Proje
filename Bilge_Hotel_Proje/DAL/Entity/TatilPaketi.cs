using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class TatilPaketi:BaseEntity
    {
        public int TatilPaketiID { get; set; }

        public string TatilPaketiName { get; set; }

        public decimal Fiyat { get; set; }

        public List<Rezervasyon> Rezervasyonlar { get; set; }

        
    }
}
