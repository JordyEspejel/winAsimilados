using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V = winAsimilados.Views;

namespace winAsimilados.Views
{
    public partial class AsimiladosPrincipal : Form
    {
        bool salida;

        public AsimiladosPrincipal()
        {
            InitializeComponent();
            salida = true;
        }

        private void AsimiladosPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
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
                   
                //Application.Exit();
                //if (MessageBox.Show("¿Desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                //{
                //    Application.Exit();
                //}
            }
            //else
            //{
            //    e.Cancel = true;                    
            //}
        }   
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void cambiarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {

             if (MessageBox.Show("¿Desea cambiar de empresa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();           
                ListaEmpresas listaEmpresas = new ListaEmpresas();
                listaEmpresas.ShowDialog();
                salida = false;
            }
            //else
            //{
            //    salida = true;
            //}

           
        }
    }
}
