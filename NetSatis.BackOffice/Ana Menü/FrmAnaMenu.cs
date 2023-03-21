using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetSatis.Entities.Tables;
using NetSatis.BackOffice.Stok;
using NetSatis.BackOffice.Cari;

namespace NetSatis.BackOffice
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
     
        public Form1()
        {
            InitializeComponent();
            using (var context = new NetSatisContext()) 
            {
                context.Database.CreateIfNotExists();
            }
        }

        //private void Form1_Load(object sender, EventArgs e) 
        //{
        //    NetSatisContext context = new NetSatisContext();
        //    CariDAL cariDAL = new CariDAL();
        //    Cari entity = new Cari
        //    {
        //        CariKodu = "123456789",
        //        CariAdi = "Ali Han Pertek",
        //        YetkiliKisi = "Ali Han",
        //        FaturaUnvani = "Pertek"
        //    };
        //    cariDAL.AddOrUpdate(context, entity);
        //    cariDAL.Save(context);
        //}

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStok form = new FrmStok();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCari form = new FrmCari();
            form.MdiParent = this;
            form.Show();
        }
    }
}
