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

        private void Form1_Load(object sender, EventArgs e)
        {
            NetSatisContext context = new NetSatisContext();
            CariDAL cariDAL = new CariDAL();
            Cari entity = new Cari
            {
                CariKodu = "123456789",
                CariAdi = "Ali Han Pertek",
                YetkiliKisi = "Ali Han",
                FaturaUnvani="Pertek"
            };
            cariDAL.AddOrUpdate(context, entity);
            cariDAL.Save(context);
        }

    }
}
