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
            try
            {
                InitializeComponent();
                bd = BD;
                sqlDataSource1.Connection.ConnectionString = "Data Source=192.168.16.248\\COMPAC;Initial Catalog=" + bd + ";User ID=sa;Password=Supervisor;";
                sqlDataSource1.Fill();

            }catch(Exception detalle)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(detalle.Message);
            }

        }

    }
}
