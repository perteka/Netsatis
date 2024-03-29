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

namespace NetSatis.BackOffice.İndirim
{
    public partial class FrmIndirim : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        IndirimDAL indirimDal = new IndirimDAL();
        public FrmIndirim()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            NetSatisContext context = new NetSatisContext();
            gridcontIndirim.DataSource = indirimDal.IndirimListele(context);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmIndirimIslem form = new FrmIndirimIslem();
            form.ShowDialog();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context = new NetSatisContext();
                var secilen = gridIndirim.GetFocusedRowCellValue(colStokKodu).ToString();
                indirimDal.Delete(context, c => c.StokKodu == secilen);
                indirimDal.Save(context);
                Listele();
            }
        }

        private void btnDurum_Click(object sender, EventArgs e)
        {
            var secilenStokKodu = gridIndirim.GetFocusedRowCellValue(colStokKodu).ToString();
            var secilen = indirimDal.GetByFilter(context, c => c.StokKodu == secilenStokKodu);
            if (Convert.ToBoolean(gridIndirim.GetFocusedRowCellValue(colDurumu)))
            {
               
                secilen.Durumu = false;              
                btnDurum.Text = "Pasif Yap";
                gridIndirim.SetFocusedRowCellValue(colDurumu, false);
                btnDurum.ImageIndex = 8;
                indirimDal.Save(context);
            }
            else
            {
                
                secilen.Durumu = true;
                btnDurum.Text = "Aktif Yap";
                gridIndirim.SetFocusedRowCellValue(colDurumu, true);
                btnDurum.ImageIndex = 7;
                indirimDal.Save(context);
            }
        }

        private void gridIndirim_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (Convert.ToBoolean(gridIndirim.GetFocusedRowCellValue(colDurumu)))
            {
                btnDurum.Text = "Pasif Yap";
                btnDurum.ImageIndex = 8;
            }
            else
            {
                btnDurum.Text = "Aktif Yap";
                btnDurum.ImageIndex = 7;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridIndirim.OptionsView.ShowAutoFilterRow = true
                ? gridIndirim.OptionsView.ShowAutoFilterRow == false
                : gridIndirim.OptionsView.ShowAutoFilterRow == true;
        }
    }
}