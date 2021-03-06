﻿using DevExpress.XtraEditors;
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
using D = soprclscomp;
using E = winAsimilados.Entities;
using V = winAsimilados.Views;

namespace winAsimilados.Views
{
    public partial class AgregarUsuario : Form
    {
        C.Controller controlador = new C.Controller();
        E.User usuario = new E.User();
        D.clsSeguridad seguridad = new D.clsSeguridad();
        string bd = C.Conexion.PerformConnection().Database;
        bool listadoEmpresas;
        public AgregarUsuario(bool listado)
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSourceUsuarios.Fill();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSourceUsuarios.Fill();
            listadoEmpresas = listado;

            if (listadoEmpresas.Equals(true))
            {
                C.Conexion.PerformConnection().Open();
            }
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            lookUpEstUsua.EditValue = "A";
            txtFecReg.EditValue = System.DateTime.Today;
        }

        private void chPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chPass.Checked.Equals(true))
            {
                txtPass.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.Properties.UseSystemPasswordChar = true;
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario.nombre = txtNombre.Text;
                usuario.usuario = txtUsuario.Text.ToUpper();
                string passEncrip = seguridad.EncryptString(txtPass.Text);
                usuario.pass = passEncrip;
                usuario.tipoUsiario = lookUpTipoUsua.EditValue.ToString();
                usuario.estatusUsuario = lookUpEstUsua.EditValue.ToString();
                usuario.fecReg = Convert.ToDateTime(txtFecReg.EditValue.ToString());

                if (usuario.nombre.Equals(""))
                {
                    XtraMessageBox.Show("Campo Nombre Requerido", "Validación"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (usuario.usuario.Equals(""))
                {
                    XtraMessageBox.Show("Campo Usuario Requerido", "Validación"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (usuario.pass.Equals("CfchmzNXqa8="))
                {
                    XtraMessageBox.Show("Campo Contraseña Requerida", "Validación"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (usuario.tipoUsiario.Equals("Null"))
                {
                    XtraMessageBox.Show("Campo Tipo Usuario Requerido", "Validación"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (usuario.nombre != "" && usuario.usuario != "" && usuario.pass != "CfchmzNXqa8="
                    && usuario.tipoUsiario != "NULL")
                {
                    //XtraMessageBox.Show("Pasa validacion");
                    if(controlador.AgregaUsuario(usuario , bd).Equals(true))
                    {
                        txtNombre.Text = "";
                        txtPass.Text = "";
                        txtUsuario.Text = "";
                        lookUpTipoUsua.Text = "";
                        InitializeComponent();
                    }
                }

            }
            catch (Exception reg)
            {
                XtraMessageBox.Show(reg.Message + "\nBtnRegistrar()"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (listadoEmpresas.Equals(true))
            {
                V.ListaEmpresas listaEmpresas = new V.ListaEmpresas();
                listaEmpresas.Show();
            }
            else
            {
                this.Dispose();
            }
        }
    }
}
