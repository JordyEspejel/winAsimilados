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

namespace winAsimilados.Views
{
    public partial class EditarEmpleados : Form
    {

        string nombre, CURP, RFC, peri;
        int IDEmpl = 0;
        C.Controller Controlador = new C.Controller();
        public EditarEmpleados()
        {
            InitializeComponent();
            string bd = C.Conexion.PerformConnection().Database;
            Controlador.ListaEmpleados(bd,GridControlEmpl);
            GridControlEmpl.Visible = true;
        }

        private void GridViewEmpl_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void EditarEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void EditarEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void GridControlEmpl_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.EndEdit)
            {
                DialogResult result = MessageBox.Show("¿Desea modificar la información  del empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    splashScreenManager1.ShowWaitForm();
                    var Empleado = new E.Empleado();
                    //E.Empleado[] empl = null;

                    for (int i =0; i < GridViewEmpl.RowCount; i++)
                    {   
                        if (GridViewEmpl.IsRowSelected(i))
                        {
                            //MessageBox.Show(GridViewEmpl.GetRowCellValue(i, GridViewEmpl.Columns[0]).ToString());
                            //splashScreenManager1.CloseWaitForm();
                            IDEmpl = Convert.ToInt32(GridViewEmpl.GetRowCellValue(i, GridViewEmpl.Columns[0]));
                            nombre = GridViewEmpl.GetRowCellValue(i, GridViewEmpl.Columns[2]).ToString();
                            RFC = GridViewEmpl.GetRowCellValue(i, GridViewEmpl.Columns[3]).ToString();
                            CURP = GridViewEmpl.GetRowCellValue(i, GridViewEmpl.Columns[4]).ToString();
                            peri = GridViewEmpl.GetRowCellValue(i, GridViewEmpl.Columns[5]).ToString();

                            // MessageBox.Show(nombre + RFC + CURP + peri);
                            Empleado.IDEmpleado = IDEmpl;
                            Empleado.Nombre = nombre;
                            Empleado.RFC = RFC;
                            Empleado.CURP = CURP;
                            Empleado.Periodicidad = peri;
                        }
                    }

                    Controlador.EditarEmpleado(Empleado, splashScreenManager1);

                }
                else
                {
                    splashScreenManager1.CloseWaitForm();
                }
            }
        }
    }
}
