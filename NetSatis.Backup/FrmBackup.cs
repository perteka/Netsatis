using NetSatis.Entities.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetSatis.Backup
{
    public partial class FrmBackup : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        public FrmBackup()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string sqlCumle =
              $"USE NetSatis;BACKUP DATABASE NetSatis TO DISK='{txtYedekKonum.Text + "\\NetSatisYedek.nsy"}'";
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCumle);
            MessageBox.Show("Yedekleme işlemi tamamlandı.");
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {

        }

        private void txtYedekKonum_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog form = new FolderBrowserDialog();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtYedekKonum.Text = form.SelectedPath;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "NetSatış Yedekleme Dosyası (*.nsy)|*.nsy";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string sqlCumle =
                    $"USE master; ALTER DATABASE NetSatis SET SINGLE_USER WITH ROLLBACK IMMEDIATE; ALTER DATABASE NetSatis SET READ_WRITE; RESTORE DATABASE NetSatis FROM DISK='{dialog.FileName}' WITH REPLACE; ALTER DATABASE NetSatis SET MULTI_USER;";

                string baglantiStringi = "Data Source=DESKTOP-CQHA9P0\\SQLEXPRESS;Initial Catalog=NetSatis;Integrated Security=True;";

                using (SqlConnection baglanti = new SqlConnection(baglantiStringi))
                {
                    try
                    {
                        baglanti.Open();

                        using (SqlCommand komut = new SqlCommand(sqlCumle, baglanti))
                        {
                            komut.ExecuteNonQuery();
                        }

                        MessageBox.Show("Geri yükleme işlemi başarıyla tamamlandı.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Geri yükleme işlemi sırasında bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }



    }
}
