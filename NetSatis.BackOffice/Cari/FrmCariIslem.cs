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

namespace NetSatis.BackOffice.Cari
{
    public partial class FrmCariIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Cari _entity;
        private CariDAL cariDal = new CariDAL();
        private NetSatisContext context = new NetSatisContext();
        public bool saved=false;
        public FrmCariIslem(Entities.Tables.Cari entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu");
            txtCariKodu.DataBindings.Add("Text", _entity, "CariKodu");
            txtCariAdi.DataBindings.Add("Text", _entity, "CariAdi");
            cmbCariTuru.DataBindings.Add("Text", _entity, "CariTuru");
            txtYetkiliKisi.DataBindings.Add("Text", _entity, "YetkiliKisi");
            txtFaturaUnvani.DataBindings.Add("Text", _entity, "FaturaUnvani");
            txtVergiDairesi.DataBindings.Add("Text", _entity, "VergiDairesi");
            txtVergiNo.DataBindings.Add("Text", _entity, "VergiNo");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            txtCepTelefon.DataBindings.Add("Text", _entity, "CepTelefonu");
            txtSabitTelefon.DataBindings.Add("Text", _entity, "Telefon");
            txtFax.DataBindings.Add("Text", _entity, "Fax");
            txtEmail.DataBindings.Add("Text", _entity, "EMail");
            txtWeb.DataBindings.Add("Text", _entity, "Web");
            txtil.DataBindings.Add("Text", _entity, "Il");
            txtilce.DataBindings.Add("Text", _entity, "Ilce");
            txtSemt.DataBindings.Add("Text", _entity, "Semt");
            txtAdress.DataBindings.Add("Text", _entity, "Adres");
            btnCariGrubu.DataBindings.Add("Text", _entity, "CariGrubu");
            btnCariAltGrubu.DataBindings.Add("Text", _entity, "CariAltGrubu");
            btnOzelKod1.DataBindings.Add("Text", _entity, "OzelKod1");
            btnOzelKod2.DataBindings.Add("Text", _entity, "OzelKod2");
            btnOzelKod3.DataBindings.Add("Text", _entity, "OzelKod3");
            btnOzelKod4.DataBindings.Add("Text", _entity, "OzelKod4");
            cmbAlisOzelFiyati.DataBindings.Add("Text", _entity, "AlisOzelFiyati");
            cmbSatisOzelFiyati.DataBindings.Add("Text", _entity, "SatisOzelFiyati");


            calciskontoOrani.DataBindings.Add("Text", _entity, "IskontoOrani");
            calciskontoOrani.DataBindings[0].FormattingEnabled = true;
            calciskontoOrani.DataBindings[0].FormatString = "'%'0";
            calciskontoOrani.DataBindings[0].DataSourceNullValue = "0";



            calcRiskLimiti.DataBindings.Add("Text", _entity, "RiskLimiti");
            calcRiskLimiti.DataBindings[0].FormattingEnabled = true;
            calcRiskLimiti.DataBindings[0].FormatString = "C2";
            calcRiskLimiti.DataBindings[0].DataSourceNullValue = "0";
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl19_Click(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cariDal.AddOrUpdate(context, _entity))
            {
                cariDal.Save(context);
                saved = true;
                this.Close();
            }
        }

        private void FrmCariIslem_Load(object sender, EventArgs e)
        {

        }
    }
}