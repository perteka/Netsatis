using DevExpress.XtraEditors;
using NetSatis.BackOffice.Stok;
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
    public partial class FrmStokRapor : DevExpress.XtraEditors.XtraForm
    {
        public FrmStokRapor()
        {
            InitializeComponent();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            FrmStok form = (FrmStok)Application.OpenForms["FrmStok"];
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) //Pencerede kayıt düğmesine basıldıysa
            {
                form.gridView1.ExportToXls(save.FileName + ".xls");
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            FrmStok form = (FrmStok)Application.OpenForms["FrmStok"];
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) //Pencerede kayıt düğmesine basıldıysa
            {
                form.gridView1.ExportToDocx(save.FileName + ".docx");
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            FrmStok form = (FrmStok)Application.OpenForms["FrmStok"];
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