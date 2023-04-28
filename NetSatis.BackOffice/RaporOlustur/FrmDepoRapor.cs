using DevExpress.XtraEditors;
using NetSatis.BackOffice.Depo;
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
    public partial class FrmDepoRapor : DevExpress.XtraEditors.XtraForm
    {
        public FrmDepoRapor()
        {
            InitializeComponent();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            FrmDepo form = (FrmDepo)Application.OpenForms["FrmDepo"];
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) //Pencerede kayıt düğmesine basıldıysa
            {
                form.gridDepolar.ExportToXls(save.FileName + ".xls");
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            FrmDepo form = (FrmDepo)Application.OpenForms["FrmDepo"];
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) //Pencerede kayıt düğmesine basıldıysa
            {
                form.gridDepolar.ExportToDocx(save.FileName + ".docx");
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            FrmDepo form = (FrmDepo)Application.OpenForms["FrmDepo"];
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) //Pencerede kayıt düğmesine basıldıysa
            {
                form.gridDepolar.ExportToPdf(save.FileName + ".pdf");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}