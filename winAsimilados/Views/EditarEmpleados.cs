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
    public partial class EditarEmpleados : Form
    {
        public EditarEmpleados()
        {
            InitializeComponent();
            C.Controller Controlador = new C.Controller();

            string bd = C.Conexion.PerformConnection().Database;
            Controlador.ListaEmpleados(bd,GridControlEmpl);
            GridControlEmpl.Visible = true;
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
                MessageBox.Show("p");
            }
        }
    }
}
