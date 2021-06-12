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
        #region variables
        string caratula = "";
        string pathLogo = "";
        string IDEmpresaPago = "";
        #endregion

        #region objetos
        C.Controller ctr = new C.Controller();
        #endregion
        public repCaratulaFactura(string caratulaPago)
        {
            InitializeComponent();
            caratula = caratulaPago;
            IDEmpresaPago = ctr.GetIDEmpresaPagoByCaratula(caratula);
            pathLogo = ctr.GetLogoEmpresa(IDEmpresaPago);
            string Empresa = Properties.Settings.Default["EmpresaNominaID"].ToString();
            //sqlDataSource1.Connection.ConnectionString = @"Data Source=192.168.16.252\inari;Initial Catalog=" + bd + ";User ID=sa;Password=20201N4r1SQL;";
            sqlDataSource1.Queries[0].Parameters[0].Value = Empresa;
            sqlDataSource1.Fill();
            xrPictureBox1.ImageUrl = pathLogo;
        }

    }
}
