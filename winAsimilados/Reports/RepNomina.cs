using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;

namespace winAsimilados.Reports
{
    public partial class RepNomina : DevExpress.XtraReports.UI.XtraReport
    {
        #region variables
        int numMes;
        string nombreMes;
        #endregion
        public RepNomina(string mes, string año)
        {
            InitializeComponent();
            if (mes != "0")
            {
                numMes = Convert.ToInt32(mes);
                nombreMes = GetNombreMes(numMes);
                xrLabel1.Text = "Reporte Nóminas " + nombreMes + " de " + año;
                sqlDataSource1.Queries[0].Parameters[0].Value = mes;
                sqlDataSource1.Queries[0].Parameters[1].Value = año;
            }
            else
            {
                xrLabel1.Text = "Reporte Nóminas del " + año;
                sqlDataSource1.Queries[0].Parameters[0].Value = mes;
                sqlDataSource1.Queries[0].Parameters[1].Value = año;
            }
        }
        public string GetNombreMes(int mes)
        {
            string nombreMes = "";
            DateTimeFormatInfo formatoFecha = CultureInfo.CurrentCulture.DateTimeFormat;
            nombreMes = formatoFecha.GetMonthName(mes);
            return nombreMes;

        }
    }
}
