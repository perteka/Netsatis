using DevExpress.XtraEditors;
using NetSatis.Entities.Tables.OtherTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void FrmDovizKurlari_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            /*xml formatındaki veriyi okumak için*/
            /*xml formatındaki veriyi okumak için xelement oluşturuyorum*/
            XElement kurlar = XElement.Load("https://www.tcmb.gov.tr/kurlar/today.xml");

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