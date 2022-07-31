using DAL.Entity;
using DAL.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class BilgeHotelContext:DbContext
    {
        public BilgeHotelContext()
        {
            Database.Connection.ConnectionString = "Server=LAPTOP-OTAOT39G;Database=BilgeHotelDB;Trusted_Connection=True;";

        }

        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
 
        public DbSet<Oda> Odalar { get; set; }

        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }
        public DbSet<TatilPaketi> TatilPaketleri { get; set; }
        public DbSet<Vardiya> Vardiyalar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CalisanMap());
            modelBuilder.Configurations.Add(new MusteriMap());
           
            modelBuilder.Configurations.Add(new OdaMap());
            modelBuilder.Configurations.Add(new RezervasyonMap());
            modelBuilder.Configurations.Add(new TatilPaketiMap());
            modelBuilder.Configurations.Add(new VardiyaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
