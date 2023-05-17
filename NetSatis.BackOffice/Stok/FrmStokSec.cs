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

namespace NetSatis.BackOffice.Stok
{
    public partial class FrmStokSec : DevExpress.XtraEditors.XtraForm
    {
        StokDAL stokDAL = new StokDAL();
        NetSatisContext context = new NetSatisContext();
        public List<Entities.Tables.Stok> secilen = new List<Entities.Tables.Stok>();
        public bool secildi = false;
        public FrmStokSec(bool cokluSecim = false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lnlUyari.Visible = true;
                gridStoklar.OptionsSelection.MultiSelect = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStokSec_Load(object sender, EventArgs e)
        {
            gridcontStoklar.DataSource = stokDAL.GetAllJoin(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if(gridStoklar.GetSelectedRows().Length!=0)
            {
                foreach (var row in gridStoklar.GetSelectedRows())
                {
                    string stokkodu = gridStoklar.GetRowCellValue(row, colStokKodu).ToString();
                    secilen.Add(context.Stoklar.SingleOrDefault(c => c.StokKodu == stokkodu));
                }
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen Bir Ürün Bulunamadı. ");
            }
        }
            
    }
}