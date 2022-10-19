﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
    public class Fis
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string FisTuru { get; set; }
        public string CariTuru { get; set; }
        public string Carikodu { get; set; }
        public string CariAdi { get; set; }
        public string BelgeNo { get; set; }
        public DateTime Tarih { get; set; }
        public string PlasiyerKodu { get; set; }
        public string PlasiyerAdi { get; set; }
        public decimal IskontoOrani { get; set; }
        public decimal IskontoTutar { get; set; }
        public string Aciklama { get; set; }

    }
}
