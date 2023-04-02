using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetSatis.BackOffice.Tanım;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;


namespace NetSatis.BackOffice.Stok
{
    public partial class FrmStokIslem : Form
    {
        private Entities.Tables.Stok _entity;
        private StokDAL stokDal = new StokDAL();
        private NetSatisContext context = new NetSatisContext();
        public bool saved = false;
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
            if(stokDal.AddOrUpdate(context, _entity))
            { 
            stokDal.Save(context);
            this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBirimi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.StokBirimi);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnBirimi.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnBirimi.Text = null;
                    break;

            }
        }

        private void btnStokGrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.StokGrubu);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnStokGrubu.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnStokGrubu.Text = null;
                    break;

            }
        }

        private void btnMarka_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.StokMarka);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnMarka.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnMarka.Text = null;
                    break;

            }
        }

        private void btnOzelKod1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.StokOzelKod1);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnOzelKod1.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnOzelKod1.Text = null;
                    break;

            }
        }

        private void btnOzelKod3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.StokOzelKod3);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnOzelKod3.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnOzelKod3.Text = null;
                    break;

            }
        }

        private void btnStokAltGrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.StokAltGrubu);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnStokAltGrubu.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnStokAltGrubu.Text = null;
                    break;

            }
        }

        private void btnModel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.StokModel);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnModel.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnModel.Text = null;
                    break;

            }
        }

        private void btnOzelKod2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.StokOzelKod2);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnOzelKod2.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnOzelKod2.Text = null;
                    break;

            }
        }

        private void btnOzelKod4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.StokOzelKod4);
                    form.ShowDialog();
                    if (form.secildi)
                    {
                        btnOzelKod4.Text = form._entity.Tanimi;
                    }
                    break;
                case 1:
                    btnOzelKod4.Text = null;
                    break;

            }
        }
    }
}
