using DevExpress.XtraEditors;
using NetSatis.Entities.Tables.OtherTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NetSatis.BackOffice.DövizKurları
{
    public partial class FrmDovizKurlari : DevExpress.XtraEditors.XtraForm
    {
        public FrmDovizKurlari()
        {
            InitializeComponent();
            FileInfo info = new FileInfo(Application.StartupPath + "\\kurlar.xml");
            lnlUyari.Text = "Son Güncelleme Tarihi : " + info.LastWriteTime.ToString();
        }

        private void FrmDovizKurlari_Load(object sender, EventArgs e)
        {
            Guncelle(false);
        }

        private void Guncelle(bool İndir=true)
        {
            if(İndir)
            {
                /*using (System.Net.WebClient kurİndir = new System.Net.WebClient())
                {
                    kurİndir.DownloadFile("https://www.tcmb.gov.tr/kurlar/today.xml", Application.StartupPath + "\\kurlar.xml");
                }
                lnlUyari.Text = "Son Güncelleme Tarihi : " + DateTime.Now.ToString();*/
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    // İnternet bağlantısı var, XML dosyasını indir ve işle
                    using (System.Net.WebClient kurİndir = new System.Net.WebClient())
                    {
                        kurİndir.DownloadFile("https://www.tcmb.gov.tr/kurlar/today.xml", Application.StartupPath + "\\kurlar.xml");
                    }
                    lnlUyari.Text = "Son Güncelleme Tarihi : " + DateTime.Now.ToString();
                }
                else
                {
                    // İnternet bağlantısı yok, kullanıcıya mesaj göster
                    MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz.");
                }
                
            }

            /*xml formatındaki veriyi okumak için*/
            /*xml formatındaki veriyi okumak için xelement oluşturuyorum*/
            XElement kurlar = XElement.Load(Application.StartupPath + "\\kurlar.xml");

            /*Xelementi direk listeliyemiyoruz çünkü içinde birçok veri var.Listeyebilmem için parçalara ayırmam lazım */
            /*Entity mizi liste tipinde çağırıp kurlarıdaki bilgiiyi liste tipindeki döviz kurlarına akatarıcam*/
            List<DövizKurlari> listKurlar = new List<DövizKurlari>();

            /*ing bilgisayarlarda ondalık . olarak gelir onun için*/
            string ondalikKarakter = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.ToString();

            /*foreach ile kurları dolaşacağım ve bu kurlardaki her bir elemanı  oluşturduğum listeye atacağım istediğim kısımlarını*/
            /*kurların elementslerini dolaş bunlar item*/
            /*XDR boş çünkü*/
            foreach (var itemElement in kurlar.Elements().Where(c=>c.Attribute("CurrencyCode").Value!="XDR").ToList()) 
            {
                listKurlar.Add(new DövizKurlari
                    {
                        CurrencyCode = itemElement.Attribute("CurrencyCode").Value,/*satır bilgisi attribute*/
                        Isim = itemElement.Element("Isim").Value,/*satır içindeki bilgileri elemtle alırız*/
                        ForexBuying = itemElement.Element("ForexBuying").Value == "" ? 0 : Convert.ToDecimal(itemElement.Element("ForexBuying").Value.Replace(".", ondalikKarakter)),/*nokta gelsin virgüle çevirdik*/
                        ForexSelling = itemElement.Element("ForexSelling").Value == "" ? 0 : Convert.ToDecimal(itemElement.Element("ForexSelling").Value.Replace(".", ondalikKarakter)),
                        BanknoteBuying = itemElement.Element("BanknoteBuying").Value=="" ? 0 : Convert.ToDecimal(itemElement.Element("BanknoteBuying").Value.Replace(".", ondalikKarakter)),
                        BanknoteSelling = itemElement.Element("BanknoteSelling").Value == "" ? 0 : Convert.ToDecimal(itemElement.Element("BanknoteSelling").Value.Replace(".", ondalikKarakter))
                    });/*Bunu Artık gridview e atabilirim*/
            }
            
            gridControl1.DataSource = listKurlar;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}