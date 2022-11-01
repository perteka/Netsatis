using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Mapping
{
    class StokHareketMap:EntityTypeConfiguration<StokHareket>
    {
        public StokHareketMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(30);
            this.Property(p => p.Hareket).HasMaxLength(30);
            this.Property(p => p.StokKodu).HasMaxLength(30);
            this.Property(p => p.StokAdi).HasMaxLength(30);
            this.Property(p => p.BarkotTuru).HasMaxLength(30);
            this.Property(p => p.Barkod).HasMaxLength(30);
            this.Property(p => p.Birimi).HasMaxLength(30);
            this.Property(p => p.Miktar).HasPrecision(5, 2);
            this.Property(p => p.Kdv);
            this.Property(p => p.BirimFiyati).HasPrecision(12, 2);
            this.Property(p => p.IndirimOrani).HasPrecision(5 ,2);
            this.Property(p => p.IndirimTutarı).HasPrecision(12, 2);
            this.Property(p => p.ToplamTutar).HasPrecision(12, 2);
            this.Property(p => p.DepoKodu).HasMaxLength(30);
            this.Property(p => p.DepoAdi).HasMaxLength(30);
            this.Property(p => p.SeriNo).HasMaxLength(30);
            //this.Property(p => p.Tarih).HasMaxLength(30);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("StokHareketleri");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.Hareket).HasColumnName("Hareket");
            this.Property(p => p.StokKodu).HasColumnName("StokKodu");
            this.Property(p => p.StokAdi).HasColumnName("StokAdi");
            this.Property(p => p.BarkotTuru).HasColumnName("BarkotTuru");
            this.Property(p => p.Barkod).HasColumnName("Barkod");
            this.Property(p => p.Birimi).HasColumnName("Birimi");
            this.Property(p => p.Miktar).HasColumnName("Miktar");
            this.Property(p => p.Kdv).HasColumnName("Kdv");
            this.Property(p => p.BirimFiyati).HasColumnName("BirimFiyati");
            this.Property(p => p.IndirimOrani).HasColumnName("IndirimOrani");
            this.Property(p => p.IndirimTutarı).HasColumnName("IndirimTutarı");
            this.Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            this.Property(p => p.DepoAdi).HasColumnName("DepoAdi");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
