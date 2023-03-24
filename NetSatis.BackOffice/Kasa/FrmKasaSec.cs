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

namespace NetSatis.BackOffice.Kasa
{
    public partial class FrmKasaSec : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        NetSatisContext context = new NetSatisContext();
        public Entities.Tables.Kasa entity = new Entities.Tables.Kasa();

        public FrmKasaSec()
        {
            InitializeComponent();
        }

        private void FrmKasaSec_Load(object sender, EventArgs e)
        {
            gridcontSecim.DataSource = kasaDal.KasaListele(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {

            string kasakodu = gridSecim.GetFocusedRowCellValue(colKasaKodu).ToString();
            entity = context.Kasalar.SingleOrDefault(c => c.KasaKodu == kasakodu);
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}