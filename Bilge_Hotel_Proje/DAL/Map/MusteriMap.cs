using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map
{
    public class MusteriMap: EntityTypeConfiguration<Musteri>
    {
        public MusteriMap()
        {
            ToTable("dbo.Musteriler");
            Property(x => x.MusteriID).IsRequired();
            Property(x => x.Ad).HasMaxLength(50).IsRequired();
            Property(x => x.Soyad).HasMaxLength(50).IsRequired();
            Property(x => x.TCKN).HasMaxLength(11).IsRequired();
            Property(x => x.Email).HasMaxLength(50).IsRequired();
            Property(x => x.TelNo).IsOptional().HasMaxLength(20);
            Property(x => x.Password).HasMaxLength(50).IsRequired();

        }
    }
}
