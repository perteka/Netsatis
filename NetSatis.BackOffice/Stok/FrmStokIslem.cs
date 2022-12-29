using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;


namespace NetSatis.BackOffice.Stok
{
    public partial class FrmStokIslem : Form
    {
        private Entities.Tables.Stok _entity;
        private StokDAL stokDal = new StokDAL();
        private NetSatisContext context = new NetSatisContext();
        public FrmStokIslem(Entities.Tables.Stok entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu");
            txtStokKodu.DataBindings.Add("text", _entity, "StokKodu");
            txtAciklama.DataBindings.Add("text", _entity, "Aciklama");
            txtBarkod.DataBindings.Add("text", _entity, "Barkod");
            txtGarantiSuresi.DataBindings.Add("text", _entity, "GarantiSuresi");
            txtStokAdi.DataBindings.Add("text", _entity, "StokAdi");
            txtUreticiKodu.DataBindings.Add("text", _entity, "UreticiKodu");

            calcAlisFiyati1.DataBindings.Add("text", _entity, "AlisFiyati1");
            calcAlisFiyati1.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyati1.DataBindings[0].FormatString = "C2";

            calcAlisFiyati2.DataBindings.Add("text", _entity, "AlisFiyati2");
            calcAlisFiyati2.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyati2.DataBindings[0].FormatString = "C2";

            calcAlisFiyati3.DataBindings.Add("text", _entity, "AlisFiyati3");
            calcAlisFiyati3.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyati3.DataBindings[0].FormatString = "C2";

            calcAlisKdv.DataBindings.Add("text", _entity, "AlisKdv");
            calcAlisKdv.DataBindings[0].FormattingEnabled = true;
            calcAlisKdv.DataBindings[0].FormatString = "'%'0";
            calcAlisKdv.DataBindings[0].DataSourceNullValue = "0";

            calcSatisKdv.DataBindings.Add("text", _entity, "SatisKdv");
            calcSatisKdv.DataBindings[0].FormattingEnabled = true;
            calcSatisKdv.DataBindings[0].FormatString = "'%'0";

            calcMaxStokMiktari.DataBindings.Add("text", _entity, "MaxStokMiktari");
            calcMaxStokMiktari.DataBindings[0].FormattingEnabled = true;
            calcMaxStokMiktari.DataBindings[0].FormatString = "N3";

            calcMinStokMiktari.DataBindings.Add("text", _entity, "MinStokMiktari");
            calcMinStokMiktari.DataBindings[0].FormattingEnabled = true;
            calcMinStokMiktari.DataBindings[0].FormatString = "N3";


            calcSatisFiyati1.DataBindings.Add("text", _entity, "SatisFiyati1");
            calcSatisFiyati1.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyati1.DataBindings[0].FormatString = "C2";

            calcSatisFiyati2.DataBindings.Add("text", _entity, "SatisFiyati2");
            calcSatisFiyati2.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyati2.DataBindings[0].FormatString = "C2";

            calcSatisFiyati3.DataBindings.Add("text", _entity, "SatisFiyati3");
            calcSatisFiyati3.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyati3.DataBindings[0].FormatString = "C2";

            btnStokGrubu.DataBindings.Add("text", _entity, "StokGrubu");
            btnStokAltGrubu.DataBindings.Add("text", _entity, "StokAltGrubu");
            btnBirimi.DataBindings.Add("text", _entity, "Birimi");
            btnMarka.DataBindings.Add("text", _entity, "Marka");
            btnModel.DataBindings.Add("text", _entity, "Modeli");
            btnOzelKod1.DataBindings.Add("text", _entity, "OzelKod1");
            btnOzelKod2.DataBindings.Add("text", _entity, "OzelKod2");
            btnOzelKod3.DataBindings.Add("text", _entity, "OzelKod3");
            btnOzelKod4.DataBindings.Add("text", _entity, "OzelKod4");
            cmbBarkodTuru.DataBindings.Add("text", _entity, "BarkodTuru");

        }

        private void FrmStokIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            stokDal.AddOrUpdate(context, _entity);
            stokDal.Save(context);
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
