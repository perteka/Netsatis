﻿using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Depo
{
    public partial class FrmDepoHareket : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        private string _depoKodu;
        public FrmDepoHareket(string depoKodu,string depoAdi)
        {
            InitializeComponent();
            _depoKodu = depoKodu;
            lblBaslik.Text = depoKodu + " - " + depoAdi + " Hareketleri ";
        }

        private void FrmDepoHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            gridcontHareket.DataSource = stokHareketDal.GetAll(context,c=>c.DepoKodu == _depoKodu);
            gridcontDepoStok.DataSource = stokHareketDal.DepoStokListele(context,_depoKodu);
            gridcontIstatistik.DataSource = stokHareketDal.DepoIstatistikListele(context,_depoKodu);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridHareket.OptionsView.ShowAutoFilterRow = true;
            }

        }
    }
}