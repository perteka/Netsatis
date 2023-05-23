using DevExpress.XtraEditors;
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

namespace NetSatis.BackOffice.Kasa
{
    public partial class FrmKasa : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        NetSatisContext context = new NetSatisContext();
        private string secilen = null;

        public FrmKasa()
        {
            InitializeComponent();
        }

        public void Guncelle()
        {
            gridcontKasalar.DataSource = kasaDal.KasaListele(context);
        }
        private void FrmKasa_Load(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnFiltreleIptal_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmKasaIslem form = new FrmKasaIslem(new Entities.Tables.Kasa());
            form.ShowDialog();
            if (form.Kaydedildi == true)
            {
                Guncelle();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = layoutView1.GetFocusedRowCellValue(colKasaKodu).ToString();
            FrmKasaIslem form = new FrmKasaIslem(kasaDal.GetByFilter(context, c => c.KasaKodu == secilen));
            form.ShowDialog();
            if (form.Kaydedildi == true)
            {
                Guncelle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = layoutView1.GetFocusedRowCellValue(colKasaKodu).ToString();
                kasaDal.Delete(context, c => c.KasaKodu == secilen);
                kasaDal.Save(context);
                Guncelle();
            }
        }
    }
}