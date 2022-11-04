﻿using NetSatis.Entities.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

    }
}
