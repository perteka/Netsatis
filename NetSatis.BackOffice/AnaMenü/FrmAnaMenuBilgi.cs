using DevExpress.XtraEditors;
using NetSatis.BackOffice.Ajanda;
using NetSatis.BackOffice.Cari;
using NetSatis.BackOffice.Depo;
using NetSatis.BackOffice.DövizKurları;
using NetSatis.BackOffice.FiyatDegistir;
using NetSatis.BackOffice.İndirim;
using NetSatis.BackOffice.Kasa;
using NetSatis.BackOffice.ÖdemeTürü;
using NetSatis.BackOffice.Personel;
using NetSatis.BackOffice.Stok;
using NetSatis.BackOffice.YapaySinirAğıMaaşTahmin;
using NetSatis.Backup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Ana_Menü
{
    public partial class FrmAnaMenuBilgi : DevExpress.XtraEditors.XtraForm
    {
        public FrmAnaMenuBilgi()
        {
            InitializeComponent();
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileItem6_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmStok form = new FrmStok();
            form.ShowDialog();
        }

        private void tileItem7_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmCari form = new FrmCari();
            form.ShowDialog();
        }

        private void tileItem16_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem9_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmPersonel form = new FrmPersonel();
            form.ShowDialog();
        }

        private void tileItem8_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmIndirim form = new FrmIndirim();
            form.Show();
        }

        private void tileItem18_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem10_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmDepo form = new FrmDepo();
            form.ShowDialog();
        }

        private void tileItem11_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmKasa form = new FrmKasa();
            form.ShowDialog();
        }

        private void tileItem12_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmOdemeTuru form = new FrmOdemeTuru();
            form.ShowDialog();
        }

        private void tileItem17_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem15_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem14_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmTopluFiyat form = new FrmTopluFiyat();
            form.Show();
        }

        private void tileItem13_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmBackup form = new FrmBackup();
            form.ShowDialog();
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmDovizKurlari form = new FrmDovizKurlari();
            form.ShowDialog();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem19_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem20_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmAjanda form = new FrmAjanda();
            form.ShowDialog();
        }

        private void tileItem21_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem22_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem23_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem24_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem25_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem25_ItemClick_1(object sender, TileItemEventArgs e)
        {
            yapaysinirağı form = new yapaysinirağı();
            form.ShowDialog();
        }
    }
}