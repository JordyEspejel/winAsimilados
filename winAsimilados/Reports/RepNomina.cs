using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace winAsimilados.Reports
{
    public partial class RepNomina : DevExpress.XtraReports.UI.XtraReport
    {
        public RepNomina()
        {
            InitializeComponent();
            xrLabel1.Text = "Reporte Nóminas al: " + DateTime.Now.ToString();
        }

    }
}
