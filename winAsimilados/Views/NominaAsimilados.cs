﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C = winAsimilados.Controller;

namespace winAsimilados.Views
{
    public partial class NominaAsimilados : Form
    {
        public NominaAsimilados()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            string bd = C.Conexion.PerformConnection().Database;
            sqlDataSource1.Connection.ConnectionString = "Data Source=server-contpaq\\compac17;Initial Catalog="+ bd + ";User ID=sa;Password=Supervisor2020.;";
            sqlDataSource1.Fill();
        }

        private void NominaAsimilados_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}