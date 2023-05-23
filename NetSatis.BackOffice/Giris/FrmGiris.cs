using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
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
    public partial class FrmGiris : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        public FrmGiris()
        {
            InitializeComponent();
            txtSifre.UseSystemPasswordChar = true;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            // Kullanıcıyı veritabanında ara
            var kullanici = context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi && k.Sifre == sifre);

            if (kullanici != null)
            {
              /*  MessageBox.Show("Giriş Başarılı!");*/
                // Ana uygulamayı açmak için gerekli kodu buraya ekleyin
                this.Hide();

                Form1 form = new Form1();


                form.Closed += (s, args) => this.Close(); // Ana form kapatıldığında giriş formunu da kapat
                form.Show();
            }
            else
            {
                MessageBox.Show("Yanlış Şifre Girdiniz.");
            }
        }

        private void btnKayitOlustur_Click(object sender, EventArgs e)
        {
            FrmYeniKayit yeniKayitForm = new FrmYeniKayit();
            yeniKayitForm.ShowDialog();
        }
    }
}