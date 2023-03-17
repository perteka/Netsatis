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
    public partial class FrmStokHareket : DevExpress.XtraEditors.XtraForm
    {
        StokDAL stokDal = new StokDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        NetSatisContext context = new NetSatisContext();
        private string _stokKodu;
        public FrmStokHareket(string stokKodu, string stokadi)
        {
            InitializeComponent();
            _stokKodu = stokKodu;
            lblBaslik.Text = _stokKodu + " - " + stokadi + "Hareketleri";
        }

        private void Guncelle()
        {
            gridcontStokHareket.DataSource = stokHareketDal.GetAll(context, c => c.StokKodu == _stokKodu);
            gridcontGenelStok.DataSource = stokDal.GetGenelStok(context, _stokKodu);
            gridcontDepoStok.DataSource = stokDal.GetDepoStok(context, _stokKodu);

        }
        private void FrmStokHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridStokHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridStokHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }
    }
}