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
    public partial class AgregarEmpresa : Form
    {
        C.Controller Controlador = new C.Controller();
        E.Empresa Empresa = new E.Empresa();
        string bd = C.Conexion.PerformConnection().Database;
        string nombreEmpresa, RFC;
        public AgregarEmpresa()
        {
            InitializeComponent();

        }

        private void BtnAgregarEmpresa_Click(object sender, EventArgs e)
        {
            string newDB = bd;
            nombreEmpresa = TxtNomEmpresa.Text.ToUpper();
            RFC = TxtRFCEmpresa.Text.ToUpper();

            if (nombreEmpresa == "")
            {
                MessageBox.Show("El campo Nombre no puede estar vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Empresa.empresa = nombreEmpresa;
            }
            
            if (RFC == "")
            {
                MessageBox.Show("El campo RFC no puede estar vacio.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Empresa.RFC = RFC;
            }

            if (Empresa.empresa != null && Empresa.RFC != null)
            {
                if (RFC.Length < 12 || RFC.Length > 13)
                {
                    MessageBox.Show("RFC no cumple con el formato correcto, favor de verificar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    splashScreenManager1.ShowWaitForm();
                    if (MessageBox.Show("¿Desea Agregar la empresa?:\n" + Empresa.empresa.ToString() + "\n\nRFC:" + Empresa.RFC.ToString() + "\n\nFavor de verificar los datos.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Controlador.CreaBDEmpresa(bd, Empresa, splashScreenManager1);

                    }
                }
            }
        }

        private void AgregarEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
