using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Giris
{
    public partial class FrmYeniKayit : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        public FrmYeniKayit()
        {
            InitializeComponent();
            txtSifre.UseSystemPasswordChar = true;
            txtSifreTekrar.UseSystemPasswordChar = true;
        }

        private void btnKayitOlustur_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string email = txtEMail.Text;
            string sifretekrar = txtSifreTekrar.Text;

            Kullanici yeniKullanici = new Kullanici
            {
                KullaniciAdi = kullaniciAdi,
                Sifre = sifre,
                Ad = ad,
                Soyad = soyad,
                EMail = email,
                SifreTekrar = sifretekrar
            };
            if (sifre == sifretekrar)
            {
                context.Kullanicilar.Add(yeniKullanici);
                context.SaveChanges();

                MessageBox.Show("Yeni Kullanıcı Kaydı Oluşturuldu!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Girdiğiniz Şifreler Aynı Değil.Yeniden Şifre Oluşturunuz.");
            }
        }
    }
}