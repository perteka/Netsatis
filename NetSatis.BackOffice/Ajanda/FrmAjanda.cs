using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Ajanda
{
    public partial class FrmAjanda : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        public FrmAjanda()
        {
            InitializeComponent();
            
            context.EFAppointments.Load();
            context.EFResources.Load();
            
            schedulerControl1.DataStorage.Appointments.DataSource = context.EFAppointments.Local.ToBindingList();
            schedulerControl1.DataStorage.Resources.DataSource = context.EFResources.Local.ToBindingList();
        }

        private void FrmAjanda_Load(object sender, EventArgs e)
        {

        }

        private void FrmAjanda_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.SaveChanges();
        }

        
    }
}