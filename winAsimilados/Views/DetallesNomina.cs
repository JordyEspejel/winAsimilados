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
using M = winAsimilados.Models;

namespace winAsimilados.Views
{
    public partial class DetallesNomina : Form
    {
        #region variables
        int idResumenNómina;
        SplashScreenManager SplashScreen;
        #endregion
        #region objetos
        M.ResumenNomina ResumenNomina = new M.ResumenNomina();
        C.Controller controlador = new C.Controller();
        #endregion
        public DetallesNomina(int IDResumen, SplashScreenManager splash)
        {
            idResumenNómina = IDResumen;
            SplashScreen = splash;
            InitializeComponent();
        }
        private M.ResumenNomina CargaDatos(int ID)
        {
            try
            {
                M.ResumenNomina datosResumenNomi = new M.ResumenNomina();
                datosResumenNomi = controlador.ObtieneInfoResumen(ID);
                return datosResumenNomi;
            }catch (Exception carga)
            {
                MessageBox.Show("¡Error al cargar la información de nómina!\n" + carga.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void LlenaFormulario()
        {
            try
            {
                ResumenNomina = this.CargaDatos(idResumenNómina);
                sqlDataSource1.Queries[0].Parameters[0].Value = ResumenNomina.ResumenNominaID;
                sqlDataSource1.Fill();
                txtEstatusGral.Text = ResumenNomina.ResumenNominaEstatus;
                txtFechaCreacion.Text = Convert.ToDateTime(ResumenNomina.ResumenNominaFechaCreacion).ToString("dd/MM/yyyy");
                txtUsuaCreacion.Text = ResumenNomina.ResumenNominaUsuarioCreacion;
                txtFechaPago.Text = Convert.ToDateTime(ResumenNomina.ResumenNominaFechaPago).ToString("dd/MM/yyyy");
                txtUsuaCierre.Text = ResumenNomina.ResumenNominaUsuarioCierrePeriodo;
                string fechaCierre  = Convert.ToDateTime(ResumenNomina.ResumenNominaUsuarioFechaCierre).ToString("dd/MM/yyyy");
                if (fechaCierre.Equals("01/01/1900"))
                {
                    txtFechaCierre.Text = "";
                }
                else
                {
                    txtFechaCierre.Text = fechaCierre;
                }
                txtEmpresaGral.Text = ResumenNomina.ResumenNominaEmpresaNombre;
                txtRFC.Text = ResumenNomina.ResumenNominaRFCEmpresa;
                txtPeriodo.Text = ResumenNomina.ResumenNominaPeriodo;
                txtFecPeriIni.Text = Convert.ToDateTime(ResumenNomina.ResumenNominaFechaInicioPeri).ToString("dd/MM/yyyy");
                txtFecPeriFin.Text = Convert.ToDateTime(ResumenNomina.ResumenNominaFechaFinPeri).ToString("dd/MM/yyyy");
                txtIngBruto.Text = ResumenNomina.ResumenNominaTotalIngresosBruto.ToString();
                txtISR.Text = ResumenNomina.ResumenNominaTotalISR.ToString();
                txtIngNeto.Text = ResumenNomina.ResumenNominaTotalIngresos.ToString();
                txtTotalEmpleados.Text = ResumenNomina.ResumenNominaTotalEmpleados.ToString();
            }
            catch (Exception)
            {
                if (SplashScreen.IsSplashFormVisible.Equals(true))
                {
                    SplashScreen.CloseWaitForm();
                }
                throw;
            }
        }

        private void DetallesNomina_Load(object sender, EventArgs e)
        {
            this.LlenaFormulario(); 
            if (SplashScreen.IsSplashFormVisible.Equals(true))
            {
                SplashScreen.CloseWaitForm();
            }
        }
    }
}
