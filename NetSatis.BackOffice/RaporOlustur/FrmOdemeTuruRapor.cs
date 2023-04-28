using DevExpress.XtraEditors;
using NetSatis.BackOffice.ÖdemeTürü;
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
    public partial class FrmOdemeTuruRapor : DevExpress.XtraEditors.XtraForm
    {
        public FrmOdemeTuruRapor()
        {
            InitializeComponent();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            FrmOdemeTuru form = (FrmOdemeTuru)Application.OpenForms["FrmOdemeTuru"];
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) //Pencerede kayıt düğmesine basıldıysa
            {
                form.gridOdemeTuru.ExportToXls(save.FileName + ".xls");
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            FrmOdemeTuru form = (FrmOdemeTuru)Application.OpenForms["FrmOdemeTuru"];
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) //Pencerede kayıt düğmesine basıldıysa
            {
                form.gridOdemeTuru.ExportToDocx(save.FileName + ".docx");
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            FrmOdemeTuru form = (FrmOdemeTuru)Application.OpenForms["FrmOdemeTuru"];
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) //Pencerede kayıt düğmesine basıldıysa
            {
                form.gridOdemeTuru.ExportToPdf(save.FileName + ".pdf");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}