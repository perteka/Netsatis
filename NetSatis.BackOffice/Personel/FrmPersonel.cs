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

namespace NetSatis.BackOffice.Personel
{
    public partial class FrmPersonel : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        PersonelDAL personelDal = new PersonelDAL();
        private string _secilen = null;
        public FrmPersonel()
        {
            InitializeComponent();
        }
        private void Listele()
        {
            gridcontPersonel.DataSource = personelDal.PersonelListele(context);
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            _secilen = gridPersonel.GetFocusedRowCellValue(colPersonelKodu).ToString();
            if (MessageBox.Show("Seçili olan kaydı silmek istediğinize emin misiniz?", "Uyarı",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                personelDal.Delete(context, c => c.PersonelKodu ==_secilen);
                personelDal.Save(context);
                Listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmPersonelIslem form = new FrmPersonelIslem(new Entities.Tables.Personel());
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            _secilen = gridPersonel.GetFocusedRowCellValue(colPersonelKodu).ToString();
            FrmPersonelIslem form = new FrmPersonelIslem(personelDal.GetByFilter(context, c => c.PersonelKodu == _secilen));
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            FrmRaporlar form = new FrmRaporlar();
            form.Show();
        }
    }
}