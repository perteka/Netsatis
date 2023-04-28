using DevExpress.XtraEditors;
using NetSatis.BackOffice.Cari;
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
    public partial class FrmCariRapor : DevExpress.XtraEditors.XtraForm
    {
        public FrmCariRapor()
        {
            InitializeComponent();
        }

        private void FrmCariRapor_Load(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            FrmCari form = (FrmCari)Application.OpenForms["FrmCari"];
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) //Pencerede kayıt düğmesine basıldıysa
            {
                form.gridView1.ExportToXls(save.FileName + ".xls");
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            FrmCari form = (FrmCari)Application.OpenForms["FrmCari"];
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) //Pencerede kayıt düğmesine basıldıysa
            {
                form.gridView1.ExportToDocx(save.FileName + ".docx");
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            FrmCari form = (FrmCari)Application.OpenForms["FrmCari"];
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) //Pencerede kayıt düğmesine basıldıysa
            {
                form.gridView1.ExportToPdf(save.FileName + ".pdf");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}