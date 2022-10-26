using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Context
{
    public class NetSatisContext : DbContext
    {
        
        public DbSet<Cari> Cariler { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Fis> Fisler { get; set; }
        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<KasaHareket> KasaHareketleri { get; set; }
        public DbSet<OdemeTuru> OdemeTurleri { get; set; }
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<StokHareket> StokHareketleri { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }

    }
}
