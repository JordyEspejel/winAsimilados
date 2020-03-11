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
        C.Controller Controlador = new C.Controller();
        E.Empresa empresa = new E.Empresa();
        bool salida;
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
        }

        private void ListaEmpresas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salida == true)
            {
                DialogResult result = MessageBox.Show("¿Desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        //MessageBox.Show(empresa.ID.ToString() + "\n" + empresa.empresa + "\n" + empresa.RFC + "\n" + empresa.Status + "\n" + empresa.BD, "");
                    }
                }
                if (Controlador.AccedeEmpresa(empresa.BD).Equals(true)){

                    C.Conexion.PerformConnection().ChangeDatabase(empresa.BD);
                    //string message = C.Conexion.PerformConnection().Database;
                    //MessageBox.Show(message);
                    //C.Conexion.PerformConnection().Close();
                    this.Dispose();
                    V.AsimiladosPrincipal principal = new V.AsimiladosPrincipal();
                    principal.lblEmpresa.Text = empresa.empresa;
                    principal.lblRFC.Text = empresa.RFC;
                    principal.ShowDialog();
                    salida = false;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError componente ListaEmpresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
