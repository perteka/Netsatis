using DevExpress.XtraEditors;
using NetSatis.BackOffice.RaporOlustur;
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

namespace NetSatis.BackOffice.Cari
{
    public partial class FrmCari : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        CariDAL cariDal = new CariDAL();
        string secilen = null;
        public FrmCari()
        {
            InitializeComponent();
        }

        private void cariBindingSource_CurrentChanged(object sender, EventArgs e)
        {

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

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        public void GetAll()
        {
            gridControl1.DataSource = cariDal.GetCariler(context);
        }

        private void FrmCari_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
                cariDal.Delete(context, c => c.CariKodu == secilen);
                cariDal.Save(context);
                GetAll();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmCariIslem form = new FrmCariIslem(new Entities.Tables.Cari());
            form.ShowDialog();
            if (form.saved == true)
            {
                GetAll();
            }

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            FrmCariIslem form = new FrmCariIslem(cariDal.GetByFilter(context, c => c.CariKodu == secilen));
            form.ShowDialog();
            if (form.saved == true)
            {
                GetAll();
            }
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            Entities.Tables.Cari cariEntity = new Entities.Tables.Cari();
            cariEntity = cariDal.GetByFilter(context, c => c.CariKodu == secilen);
            cariEntity.Id = -1;
            cariEntity.CariKodu = null;
            FrmCariIslem form = new FrmCariIslem(cariEntity);
            form.ShowDialog();
            if (form.saved == true)
            {
                GetAll();
            }
        }


        private void btnRapor_Click(object sender, EventArgs e)
        {
            FrmCariRapor form = new FrmCariRapor();
            form.Show();
        }
    }
}