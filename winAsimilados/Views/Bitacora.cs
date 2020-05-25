﻿using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using System;
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
    public partial class Bitacora : Form
    {
        C.Controller controlador = new C.Controller();
        string user = Properties.Settings.Default.Usuario.ToString().ToUpper();
        int month = DateTime.Now.Month, year = DateTime.Now.Year;
        SplashScreenManager splash;
        public Bitacora(SplashScreenManager splashScreenManager)
        {
            splash = splashScreenManager;
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSourceMes.Fill();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSourceAnio.Fill();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSourceSopradeUsers.Fill();
        }

        private void lookUpEditYear_EditValueChanged(object sender, EventArgs e)
        {
            CargaTabla();
        }

        private void lookUpEditMonth_EditValueChanged(object sender, EventArgs e)
        {
            CargaTabla();
        }

        private void lookUpEditUser_EditValueChanged(object sender, EventArgs e)
        {
            CargaTabla();
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            splash.SetWaitFormCaption("Cargando Información...");
            lookUpEditMonth.EditValue = month;
            lookUpEditYear.EditValue = year;
            lookUpEditUser.EditValue = user;
            //lookUpEditUser.EditValue = controlador.GetNombreUsuario(Properties.Settings.Default.Usuario.ToString().ToUpper());
            CargaTabla();
            if (splash.IsSplashFormVisible.Equals(true))
            {
                splash.CloseWaitForm();
            }

        }

        private void CargaTabla()
        {
            try
            {
                user = lookUpEditUser.EditValue.ToString();
                month = Convert.ToInt32(lookUpEditMonth.EditValue.ToString());
                year = Convert.ToInt32(lookUpEditYear.EditValue.ToString());
                controlador.GetBitacora(gridControl1, user, month.ToString(), year.ToString(), splash);
                gridControl1.Visible = true;
            }
            catch
            {

            }
        }
    }
}
