﻿using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
    public class StokHareket : IEntity
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string Hareket { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string BarkotTuru { get; set; }
        public string Barkod { get; set; }
        public string Birimi { get; set; }
        public decimal Miktar { get; set; }
        public int Kdv { get; set; }
        public decimal BirimFiyati { get; set; }
        public decimal IndirimOrani { get; set; }
        public decimal IndirimTutarı { get; set; }
        public decimal ToplamTutar { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public string SeriNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }

    }
}
