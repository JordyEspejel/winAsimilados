using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using C = winAsimilados.Controller;

namespace winAsimilados.Reports
{
    public partial class repCaratulaFactura : DevExpress.XtraReports.UI.XtraReport
    {
        string bd = "";
        public repCaratulaFactura(string BD)
        {
            InitializeComponent();
            bd = BD;
            sqlDataSource1.Connection.ConnectionString = "Data Source=192.168.16.248\\COMPAC;Initial Catalog=" + bd + ";User ID=sa;Password=Supervisor;";
            sqlDataSource1.Fill();

        }

    }
}
