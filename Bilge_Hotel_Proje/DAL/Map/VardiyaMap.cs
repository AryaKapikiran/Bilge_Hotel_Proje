using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map
{
    public class VardiyaMap: EntityTypeConfiguration<Vardiya>
    {
        public VardiyaMap()
        {
            ToTable("dbo.Vardiyalar");
            Property(x => x.VardiyaID).IsRequired();
            Property(x => x.Baslangic).IsRequired();
            Property(x => x.Bitis).IsRequired();
            
        }
    }
}
