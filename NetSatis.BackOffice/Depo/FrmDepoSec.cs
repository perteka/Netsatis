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

namespace NetSatis.BackOffice.Depo
{
    public partial class FrmDepoSec : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        DepoDAL depoDal = new DepoDAL();
        public Entities.Tables.Depo entity = new Entities.Tables.Depo();
        private string _stokKodu; 
        public FrmDepoSec(string stokKodu)
        {
            InitializeComponent();
            _stokKodu = stokKodu;
        }

        private void FrmDepoSec_Load(object sender, EventArgs e)
        {
            gridcontDepolar.DataSource = depoDal.DepoBazindaStokListele(context, _stokKodu);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            string depokodu = gridDepolar.GetFocusedRowCellValue(colDepoKodu).ToString();
            entity = context.Depolar.SingleOrDefault(c => c.DepoKodu == depokodu);
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}