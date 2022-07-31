using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map
{
    public class CalisanMap:EntityTypeConfiguration<Calisan>
    {
        public CalisanMap()
        {
            ToTable("dbo.Calisanlar");
            Property(x=>x.CalisanID).IsRequired();
            Property(x => x.FirstName).HasMaxLength(50).IsRequired();
            Property(x => x.LastName).HasMaxLength(50).IsRequired();
            Property(x => x.Email).HasMaxLength(50).IsRequired();
            Property(x => x.Password).HasMaxLength(50).IsRequired();
            Property(x => x.SaatSayisi).IsOptional();
            Property(x => x.VardiyaZamani).IsOptional();
           
            //Property(x => x.Gorev.ToString()).IsRequired();
            Property(x => x.Ucret).IsOptional();
           


        }
    }
}
