using DevExpress.XtraEditors;
using NetSatis.BackOffice.Tanım;
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

namespace NetSatis.BackOffice.Personel
{

    public partial class FrmPersonelIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Personel _entity;
        private PersonelDAL personelDal = new PersonelDAL();
        private NetSatisContext context = new NetSatisContext();
        public bool saved = false;
        public FrmPersonelIslem(Entities.Tables.Personel entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleCalisiyor.DataBindings.Add("EditValue", _entity, "Calisiyor", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelKodu.DataBindings.Add("Text", _entity, "PersonelKodu", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelAdi.DataBindings.Add("Text", _entity, "PersonelAdi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            btnUnvani.DataBindings.Add("Text", _entity, "Unvani", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtTCKimlikNo.DataBindings.Add("Text", _entity, "TCKimlikNo", false,
                DataSourceUpdateMode.OnPropertyChanged);
            cmbIseGirisTarihi.DataBindings.Add("EditValue", _entity, "IseGirisTarihi", true,
                DataSourceUpdateMode.OnPropertyChanged, null, "F");
            cmbIstenCikisTarihi.DataBindings.Add("EditValue", _entity, "IstenCikisTarihi", true,
                DataSourceUpdateMode.OnPropertyChanged, null, "F");
            txtVergiDairesi.DataBindings.Add("Text", _entity, "VergiDairesi", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _entity, "VergiNo", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefon.DataBindings.Add("Text", _entity, "CepTelefonu", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtSabitTelefon.DataBindings.Add("Text", _entity, "Telefon", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtFax.DataBindings.Add("Text", _entity, "Fax", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add("Text", _entity, "EMail", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtWeb.DataBindings.Add("Text", _entity, "Web", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtil.DataBindings.Add("Text", _entity, "Il", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtilce.DataBindings.Add("Text", _entity, "Ilce", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _entity, "Semt", false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _entity, "Adres", false,
                DataSourceUpdateMode.OnPropertyChanged);
            calcMaasi.DataBindings.Add("EditValue", _entity, "AylikMaasi", true,
                DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
            calcPrimOrani.DataBindings.Add("EditValue", _entity, "PrimOrani", true,
                DataSourceUpdateMode.OnPropertyChanged, 0, "'%'0");

        }


        private void FrmPersoneIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (personelDal.AddOrUpdate(context, _entity))
            {
                saved = true;
                personelDal.Save(context);
                this.Close();
            }
        }

        private void cmbUnvani_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.PersonelUnvan);
            form.ShowDialog();
            if (form.secildi)
            {
                btnUnvani.Text = form._entity.Tanimi;
            }
        }

        
    }
}