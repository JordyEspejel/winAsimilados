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
using N = winAsimilados.Controller;
using V = winAsimilados.Views;

namespace winAsimilados.Views
{
    public partial class Login : Form
    {
       
        C.Controller Controlador = new C.Controller();
        E.User User = new E.User();
        bool salida;

        public Login()
        {
            InitializeComponent();
            salida = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            User.usuario = txtUsua.Text;
            User.pass = txtPass.Text;
            if (User.usuario == "")
            {
                XtraMessageBox.Show("Campo Usuario vacio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (User.pass == "")
            {
                XtraMessageBox.Show("Campo Contraseña vacio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //XtraMessageBox.Show("entra login()", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Controlador.Login(User).Equals(true))
                {
                    this.Hide();
                    salida = false;
                    //Form1 frm = new Form1();
                    //frm.Show();
                    //V.AsimiladosPrincipal Prin = new V.AsimiladosPrincipal();
                    //Prin.Show();
                    Properties.Settings.Default["Usuario"] = txtUsua.Text;
                    Properties.Settings.Default.Save();
                    V.ListaEmpresas listaEmpresas = new V.ListaEmpresas();               
                    listaEmpresas.ShowDialog();
                    //this.Dispose();

                }
                else
                {
                    XtraMessageBox.Show("Usuario y/o Contraseña incorrectos!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salida == true)
            {
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
                else
                {
                    this.Dispose();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsua.Text = Properties.Settings.Default.Usuario.ToString();
        }
    }
}
