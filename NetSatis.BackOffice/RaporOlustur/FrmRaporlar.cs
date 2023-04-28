using DevExpress.XtraEditors;
using NetSatis.BackOffice.Personel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSatis.BackOffice.RaporOlustur
{
    public partial class FrmRaporlar : DevExpress.XtraEditors.XtraForm
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            FrmPersonel form = (FrmPersonel)Application.OpenForms["FrmPersonel"];
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) //Pencerede kayıt düğmesine basıldıysa
            {
                form.gridPersonel.ExportToXls(save.FileName + ".xls");
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            FrmPersonel form = (FrmPersonel)Application.OpenForms["FrmPersonel"];
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) //Pencerede kayıt düğmesine basıldıysa
            {
                form.gridPersonel.ExportToDocx(save.FileName + ".docx");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            FrmPersonel form = (FrmPersonel)Application.OpenForms["FrmPersonel"];
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) //Pencerede kayıt düğmesine basıldıysa
            {
                form.gridPersonel.ExportToPdf(save.FileName + ".pdf");
            }
        }
    }
}