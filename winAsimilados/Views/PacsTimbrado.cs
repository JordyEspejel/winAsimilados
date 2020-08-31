using DevExpress.XtraEditors;
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

namespace winAsimilados.Views
{
    public partial class PacsTimbrado : Form
    {
        string pacTimbrado, ambiente;
        string pacConfig, ambienteConfig;
        SplashScreenManager splash;
        private void PacsTimbrado_Load(object sender, EventArgs e)
        {
            pacConfig = Properties.Settings.Default.PAC.ToString();
            ambienteConfig = Properties.Settings.Default.Ambiente.ToString();

            if (pacConfig.Equals("NT"))
            {
                chNtLink.Checked = true;
            }else if (pacConfig.Equals("SL"))   
            {
                chEditSolucion.Checked = true;
            }

            lookUpPAC.EditValue = ambienteConfig;

            splash.CloseWaitForm();
        }

        private void chNtLink_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chNtLink.Checked.Equals(true))
                {
                    chEditSolucion.Checked = false;
                    pacTimbrado = "NT";
                    if (chNtLink.Checked.Equals(true) && ambiente.Equals("Produccion"))
                    {
                        txtPACActivo.Text = "NT-LINK / Producción";
                    }
                    else if (chNtLink.Checked.Equals(true) && ambiente.Equals("Pruebas"))
                    {
                        txtPACActivo.Text = "NT-LINK / Pruebas";
                    }
                    if (chEditSolucion.Checked.Equals(true) && ambiente.Equals("Pruebas"))
                    {
                        txtPACActivo.Text = "Solucion Factible / Pruebas";
                    }
                    else if (chEditSolucion.Checked.Equals(true) && ambiente.Equals("Produccion"))
                    {
                        txtPACActivo.Text = "Solucion Factible / Producción";
                    }
                }
            }
            catch (Exception chLINK)
            {

            }
        }

        private void chEditSolucion_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chEditSolucion.Checked.Equals(true))
                {
                    chNtLink.Checked = false;
                    pacTimbrado = "SL";

                    if (chNtLink.Checked.Equals(true) && ambiente.Equals("Produccion"))
                    {
                        txtPACActivo.Text = "NT-LINK / Producción";
                    }
                    else if (chNtLink.Checked.Equals(true) && ambiente.Equals("Pruebas"))
                    {
                        txtPACActivo.Text = "NT-LINK / Pruebas";
                    }
                    if (chEditSolucion.Checked.Equals(true) && ambiente.Equals("Pruebas"))
                    {
                        txtPACActivo.Text = "Solucion Factible / Pruebas";
                    }
                    else if (chEditSolucion.Checked.Equals(true) && ambiente.Equals("Produccion"))
                    {
                        txtPACActivo.Text = "Solucion Factible / Producción";
                    }
                }
            }
            catch (Exception SL)
            {

            }
        }

        private void lookUpPAC_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ambiente = lookUpPAC.EditValue.ToString();
                if (chNtLink.Checked.Equals(true) && ambiente.Equals("Produccion"))
                {
                    txtPACActivo.Text = "NT-LINK / Producción";
                }
                else if (chNtLink.Checked.Equals(true) && ambiente.Equals("Pruebas"))
                {
                    txtPACActivo.Text = "NT-LINK / Pruebas";
                }
                if (chEditSolucion.Checked.Equals(true) && ambiente.Equals("Pruebas"))
                {
                    txtPACActivo.Text = "Solucion Factible / Pruebas";
                }
                else if (chEditSolucion.Checked.Equals(true) && ambiente.Equals("Produccion"))
                {
                    txtPACActivo.Text = "Solucion Factible / Producción";
                }
            }
            catch (Exception PAC)
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var resultado = XtraMessageBox.Show("¿Desea guardar la configuración de timbrado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado.Equals(DialogResult.Yes))
            {
                Properties.Settings.Default["PAC"] = pacTimbrado;
                Properties.Settings.Default["Ambiente"] = ambiente;
                Properties.Settings.Default.Save();

                XtraMessageBox.Show("Configuración Guardada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public PacsTimbrado(SplashScreenManager splashScreenManager)
        {
            splash = splashScreenManager;
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
        }
    }
}
