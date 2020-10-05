using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using C = winAsimilados.Controller;
namespace winAsimilados.Reports
{
    public partial class repDetalleFactura : DevExpress.XtraReports.UI.XtraReport
    {
        string bd = ""; 
        public repDetalleFactura(string BD)
        {
            InitializeComponent();
            bd = BD;
            sqlDataSource1.Connection.ConnectionString = @"Data Source=192.168.16.20\inari;Initial Catalog=" + bd + ";User ID=sa;Password=20201N4r1SQL;";
            sqlDataSource1.Fill();
        }

    }
}
