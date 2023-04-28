using DevExpress.XtraEditors;
using NetSatis.BackOffice.RaporOlustur;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSatis.BackOffice.ÖdemeTürü
{
    public partial class FrmOdemeTuru : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        OdemeTuruDAL odemeTuruDal = new OdemeTuruDAL();
        public FrmOdemeTuru()
        {
            InitializeComponent();
        }

        private void FrmOdemeTuru_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            gridcontOdemeTuru.DataSource = odemeTuruDal.OdemeTuruListele(context);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;

        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnFiltreleIptal_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridOdemeTuru.GetFocusedRowCellValue(colOdemeKodu).ToString();
                odemeTuruDal.Delete(context, c => c.OdemeTuruKodu == secilen);
                odemeTuruDal.Save(context);
                Listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmOdemeTuruIslem form = new FrmOdemeTuruIslem(new OdemeTuru());
            form.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridOdemeTuru.GetFocusedRowCellValue(colOdemeKodu).ToString();
            FrmOdemeTuruIslem form = new FrmOdemeTuruIslem(odemeTuruDal.GetByFilter(context, c => c.OdemeTuruKodu == secilen));
            form.ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            FrmOdemeTuruRapor form = new FrmOdemeTuruRapor();
            form.Show();
        }
    }
}