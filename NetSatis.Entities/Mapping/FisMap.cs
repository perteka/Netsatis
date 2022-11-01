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
    public class FisMap : EntityTypeConfiguration<Fis>
    {
        public FisMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(30);
            this.Property(p => p.FisTuru).HasMaxLength(30);
            this.Property(p => p.CariTuru).HasMaxLength(30);
            this.Property(p => p.Carikodu).HasMaxLength(30);
            this.Property(p => p.CariAdi).HasMaxLength(30);
            this.Property(p => p.BelgeNo).HasMaxLength(30);
            //this.Property(p => p.Tarih).has(30);
            this.Property(p => p.PlasiyerKodu).HasMaxLength(30);
            this.Property(p => p.PlasiyerAdi).HasMaxLength(30);
            this.Property(p => p.IskontoOrani).HasPrecision(12, 2);
            this.Property(p => p.IskontoTutar).HasPrecision(5, 2);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Fisler");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.FisTuru).HasColumnName("FisTuru");
            this.Property(p => p.CariTuru).HasColumnName("CariTuru");
            this.Property(p => p.Carikodu).HasColumnName("Carikodu");
            this.Property(p => p.CariAdi).HasColumnName("CariAdi");
            this.Property(p => p.BelgeNo).HasColumnName("BelgeNo");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.PlasiyerKodu).HasColumnName("PlasiyerKodu");
            this.Property(p => p.PlasiyerAdi).HasColumnName("PlasiyerAdi");
            this.Property(p => p.IskontoOrani).HasColumnName("IskontoOrani");
            this.Property(p => p.IskontoTutar).HasColumnName("IskontoTutar");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
