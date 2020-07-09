using DevExpress.XtraEditors;
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
using E = winAsimilados.Entities;
using V = winAsimilados.Views;

namespace winAsimilados.Views
{
    public partial class ListaEmpresas : Form
    {
        string bd = C.Conexion.PerformConnection().Database;
        C.Controller Controlador = new C.Controller();
        E.Empresa empresa = new E.Empresa();
        bool salida;
        public bool btnAgregaEmpresa, btnAgregaUsuario, btnEditaUsuario;
        //int IDEmpresa;
        //string NombreEmpresa;
        //string RFC;
        //int Status;
        //string TablaBD;
        public ListaEmpresas()
        {
            InitializeComponent();
            Controlador.ListadoEmpresas(GridEmpresas);
            GridEmpresas.Visible = true;
            salida = true;
            btnAgregaEmpresa = false;
            btnAgregaUsuario = false;
            btnEditaUsuario = false;
    }

        private void ListaEmpresas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salida == true)
            {
                if (btnAgregaEmpresa != true){
                    DialogResult result = XtraMessageBox.Show("¿Desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.Dispose();
                        Application.Exit();
                    }
                    else if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }

            }
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < GridViewEmpresas.RowCount; i++)
                {
                    if (GridViewEmpresas.IsRowSelected(i))
                    {
                        empresa.ID = Convert.ToInt32(GridViewEmpresas.GetRowCellValue(i, GridViewEmpresas.Columns[0]));
                        empresa.empresa = Convert.ToString(GridViewEmpresas.GetRowCellValue(i, GridViewEmpresas.Columns[1]));
                        empresa.RFC = Convert.ToString(GridViewEmpresas.GetRowCellValue(i, GridViewEmpresas.Columns[2]));
                        empresa.Status = Convert.ToInt32(GridViewEmpresas.GetRowCellValue(i, GridViewEmpresas.Columns[3]));
                        empresa.BD = Convert.ToString(GridViewEmpresas.GetRowCellValue(i, GridViewEmpresas.Columns[4]));
                        //XtraMessageBox.Show(empresa.ID.ToString() + "\n" + empresa.empresa + "\n" + empresa.RFC + "\n" + empresa.Status + "\n" + empresa.BD, "");
                    }
                }
                if (Controlador.AccedeEmpresa(empresa.BD).Equals(true)){

                    C.Conexion.PerformConnection().ChangeDatabase(empresa.BD);
                    //string message = C.Conexion.PerformConnection().Database;
                    //XtraMessageBox.Show(message);
                    //C.Conexion.PerformConnection().Close();
                    this.Dispose();
                    V.AsimiladosPrincipal principal = new V.AsimiladosPrincipal();
                    principal.lblEmpresa.Caption = empresa.empresa;
                    principal.lblRFC.Caption = empresa.RFC;
                    //principal.Text = "WinAsimilados - " + empresa.empresa + " - " + empresa.RFC;
                    
                    principal.ShowDialog();
                    salida = false;
                    
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\nError componente ListaEmpresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridEmpresas_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            btnAgregaEmpresa = true;
            this.Dispose();
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormCaption("Cargando Modulo Empresa...");
            AgregarEmpresa agregarEmpresa = new AgregarEmpresa(true, splashScreenManager1);
            agregarEmpresa.StartPosition = FormStartPosition.CenterScreen;
            agregarEmpresa.Show();
        }

        private void GridEmpresas_DoubleClick(object sender, EventArgs e)
        {

        }

        private void ListaEmpresas_Load(object sender, EventArgs e)
        {
            if (Controlador.GetAdminUsuario(Properties.Settings.Default.Usuario.ToString().ToUpper(), bd, true).Equals(true))
            {
                layoutControlOpciones.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                layoutControlOpciones.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            }

        }

        private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAgregaEmpresa = true;
            btnAgregaUsuario = true;
            this.Dispose();
            AgregarUsuario agregarUsuario = new AgregarUsuario(true);
            agregarUsuario.StartPosition = FormStartPosition.CenterScreen;
            agregarUsuario.Show();
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAgregaEmpresa = true;
            btnEditaUsuario = true;
            this.Dispose();
            EditarUsuario editarUsuario = new EditarUsuario(true);
            editarUsuario.StartPosition = FormStartPosition.CenterScreen;
            editarUsuario.Show();
        }
    }
}
