﻿using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraVerticalGrid;
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
        //string nomEmpl = null;
        //string nombre, CURP, RFC, peri;
        //int IDEmpl = 0;
        string nombre, CURP, RFC, peri, cuenta, clabe, cve, banco, empresa, idEmpr, numEmpl, correoClte;
        C.Controller Controlador = new C.Controller();
        E.Empleado empleado = new E.Empleado();
        string bd = C.Conexion.PerformConnection().Database.ToString();
        SplashScreenManager splash;

        private void lookUpBanco_EditValueChanged(object sender, EventArgs e)
        {
            TxtCVE.Text = lookUpBanco.EditValue.ToString();
        }

        public EditarEmpleados(SplashScreenManager screenManager)
        {
            splash = screenManager;
            InitializeComponent();

            //// This line of code is generated by Data Source Configuration Wizard
            //// Fill a SqlDataSource

            ////sqlDataSourceEmpl.Connection.ConnectionString = "Data Source=192.168.4.182\\COMPAC;Initial Catalog=" + bd + ";User ID=sa;Password=Supervisor2020.;";
            ////sqlDataSourceEmpl.Fill();
            //// This line of code is generated by Data Source Configuration Wizard
            //// Fill a SqlDataSource
            //sqlDataSource1.Fill();
            //// This line of code is generated by Data Source Configuration Wizard
            //// Fill a SqlDataSource
            //sqlDataTipoPeri.Fill();
            //// This line of code is generated by Data Source Configuration Wizard
            //// Fill a SqlDataSource
            sqlDataTipoPeri.Fill();
            //// This line of code is generated by Data Source Configuration Wizard
            //// Fill a SqlDataSource
            //sqlDataTipoPeri.Fill();
            //// This line of code is generated by Data Source Configuration Wizard
            //// Fill a SqlDataSource
            //sqlDataTipoPeri.Fill();
        }


        private void EditarEmpleados_Load(object sender, EventArgs e)
        {
            //// This line of code is generated by Data Source Configuration Wizard
            //// Fill a SqlDataSource
            //sqlDataTipoPeri.Fill();
            sqlDataSource1.Connection.ConnectionString = "Data Source=192.168.16.248\\COMPAC;Initial Catalog=" + bd + ";User ID=sa;Password=Supervisor;";
            sqlDataSource1.Fill();      
            if (splash.IsSplashFormVisible.Equals(true))
            {
                splash.CloseWaitForm();
            }
        }

        private void EditarEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void EditarEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void lookUpEmpl_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                empleado = Controlador.BuscaEmpleado(lookUpEmpl.EditValue.ToString());
                this.LlenarCampos();
                layoutControlbtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }catch (Exception Empl)
            {

            }
        }

        private void LlenarCampos()
        {
            layoutControlbtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            TxtNombreEmpl.Text = empleado.Nombre;
            TxtNumEmpl.Text = empleado.NumEmpl;
            TxtRFC.Text = empleado.RFC;
            TxtCURP.Text = empleado.CURP;
            lookUpEditPeriPago.EditValue = empleado.Periodicidad;
            spinEditDesc.EditValue = empleado.descuento;
            lookUpTipoPago.EditValue = empleado.tipoPago;
            lookUpEmpresa.EditValue = empleado.idEmpresa;
            lookUpBanco.EditValue = empleado.cve_banco;
            TxtCVE.Text = empleado.cve_banco;
            TxtCuenta.Text = empleado.cuenta;
            TxtCLABE.Text = empleado.clabe_bancaria;
            txtCorreoClte.Text = empleado.Correo;
        }

        #region funcionTabla

        //private void GridControlEmpl_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        //{
        //    if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.EndEdit)
        //    {
        //        for (int i = 0; i < GridViewEmpl.RowCount; i++)
        //        {
        //            if (GridViewEmpl.IsRowSelected(i))
        //            {
        //                nomEmpl = GridViewEmpl.GetRowCellValue(i, GridViewEmpl.Columns[2]).ToString();
        //            }

        //        }
        //        DialogResult result = XtraMessageBox.Show("¿Desea modificar la información  del empleado " + nomEmpl + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (result == DialogResult.Yes)
        //        {
        //            splashScreenManager1.ShowWaitForm();
        //            var Empleado = new E.Empleado();
        //            //E.Empleado[] empl = null;

        //            for (int i =0; i < GridViewEmpl.RowCount; i++)
        //            {   
        //                if (GridViewEmpl.IsRowSelected(i))
        //                {
        //                    //XtraMessageBox.Show(GridViewEmpl.GetRowCellValue(i, GridViewEmpl.Columns[0]).ToString());
        //                    //splashScreenManager1.CloseWaitForm();
        //                    IDEmpl = Convert.ToInt32(GridViewEmpl.GetRowCellValue(i, GridViewEmpl.Columns[0]));
        //                    nombre = GridViewEmpl.GetRowCellValue(i, GridViewEmpl.Columns[2]).ToString();
        //                    RFC = GridViewEmpl.GetRowCellValue(i, GridViewEmpl.Columns[3]).ToString();
        //                    CURP = GridViewEmpl.GetRowCellValue(i, GridViewEmpl.Columns[4]).ToString();
        //                    peri = GridViewEmpl.GetRowCellValue(i, GridViewEmpl.Columns[5]).ToString();

        //                    // XtraMessageBox.Show(nombre + RFC + CURP + peri);
        //                    Empleado.IDEmpleado = IDEmpl;
        //                    Empleado.Nombre = nombre;
        //                    Empleado.RFC = RFC;
        //                    Empleado.CURP = CURP;
        //                    Empleado.Periodicidad = peri;
        //                }
        //            }

        //            Controlador.EditarEmpleado(Empleado, splashScreenManager1);

        //        }
        //        else
        //        {
        //         //   splashScreenManager1.CloseWaitForm();
        //        }
        //    }
        //}
        #endregion

        private void HabilitarCampos()
        {
            TxtNombreEmpl.ReadOnly = false;
            TxtNumEmpl.ReadOnly = false;
            TxtRFC.ReadOnly = false;
            TxtCURP.ReadOnly = false;
            lookUpEditPeriPago.ReadOnly = false;
            spinEditDesc.ReadOnly = false;
            lookUpTipoPago.ReadOnly = false;
            lookUpEmpresa.ReadOnly = false;
            lookUpBanco.ReadOnly = false;
            TxtCVE.ReadOnly = false;
            TxtCuenta.ReadOnly = false;
            TxtCLABE.ReadOnly = false;
            txtCorreoClte.ReadOnly = false;
            layoutControlbtnAceptar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlbtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void DeshabilitarCampos()
        {
            TxtNombreEmpl.ReadOnly = true;
            TxtNumEmpl.ReadOnly = true;
            TxtRFC.ReadOnly = true;
            TxtCURP.ReadOnly = true;
            lookUpEditPeriPago.ReadOnly = true;
            spinEditDesc.ReadOnly = true;
            lookUpTipoPago.ReadOnly = true;
            lookUpEmpresa.ReadOnly = true;
            lookUpBanco.ReadOnly = true;
            TxtCVE.ReadOnly = true;
            TxtCuenta.ReadOnly = true;
            TxtCLABE.ReadOnly = true;
            txtCorreoClte.ReadOnly = true;
            layoutControlbtnAceptar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlbtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.HabilitarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DeshabilitarCampos();
            this.LlenarCampos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            nombre = TxtNombreEmpl.Text.ToUpper();
            RFC = TxtRFC.Text.ToUpper();
            CURP = TxtCURP.Text.ToUpper();
            cuenta = TxtCuenta.Text;
            clabe = TxtCLABE.Text;
            banco = lookUpBanco.Text;
            cve = TxtCVE.Text;
            empresa = lookUpEmpresa.Text;
            idEmpr = lookUpEmpresa.EditValue.ToString();
            numEmpl = TxtNumEmpl.Text;
            peri = lookUpEditPeriPago.EditValue.ToString();
            correoClte = txtCorreoClte.Text;
            empleado.Correo = correoClte;
            empleado.descuento = Convert.ToDecimal(spinEditDesc.EditValue.ToString());
            //empleado.descuento = empleado.descuento / 100;
            if (nombre == "")
            {
                XtraMessageBox.Show("El campo Nombre no puede estar vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                empleado.Nombre = nombre;
            }

            if (numEmpl.Equals(""))
            {
                XtraMessageBox.Show("El campo # Empleado no puede estar vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                empleado.NumEmpl = numEmpl;
            }

            if (RFC == "")
            {
                XtraMessageBox.Show("El campo RFC no puede estar vacio.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!RFC.Length.Equals(13))
                {
                    XtraMessageBox.Show("RFC no cumple con el formato correcto, favor de verificar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    empleado.RFC = RFC.ToUpper();
                }
            }

            if (CURP == "")
            {
                XtraMessageBox.Show("El campo CURP no puede estar vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!CURP.Length.Equals(18))
                {
                    XtraMessageBox.Show("CURP no cumple con el formato correcto, favor de verificar,", "Mesnaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    empleado.CURP = CURP.ToUpper();
                }
            }

            if (peri == null)
            {
                XtraMessageBox.Show("Seleccione tipo de periodicidad.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                empleado.Periodicidad = peri;
            }

            if (cuenta.Equals(""))
            {
                XtraMessageBox.Show("El campo cuenta no puede estar vacio.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cuenta.Length < 10)
            {
                XtraMessageBox.Show("Cuenta no cumple con el formato correcto, debe contener al menos 10 digitos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cuenta.Length > 10)
            {
                XtraMessageBox.Show("Cuenta no cumple con el formato correcto, debe contener máximo 10 dígitos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                empleado.cuenta = cuenta;
            }

            if (clabe.Equals(""))
            {
                XtraMessageBox.Show("El campo CLABE no puede estar vacio.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (clabe.Length < 18)
            {
                XtraMessageBox.Show("CLABE no cumple con el formato correcto, debe contener al menos 18 dígitos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (clabe.Length > 18)
            {
                XtraMessageBox.Show("CLABE no cumple con el formato correcto, debe contener máximo 18 dígitos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                empleado.clabe_bancaria = clabe;
            }

            if (banco.Equals(""))
            {
                XtraMessageBox.Show("El campo bancoEmpleado no puede estar vacio.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                empleado.banco = banco;
            }

            if (cve.Equals(""))
            {
                XtraMessageBox.Show("El campo CVE no puede estar vacio.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                empleado.cve_banco = cve;
            }

            if (empresa.Equals(""))
            {
                XtraMessageBox.Show("El campo Empresa no puede estar vacio.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                empleado.empresa = empresa;
                empleado.idEmpresa = idEmpr;
            }

            if (lookUpTipoPago.Text.Equals("Seleccione"))
            {
                XtraMessageBox.Show("Por favor, Seleccione Tipo Pago.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                empleado.tipoPago = lookUpTipoPago.EditValue.ToString();
            }


            if (empleado.RFC != null && empleado.Nombre != null && empleado.CURP != null && empleado.Periodicidad != null && empleado.cuenta != null && empleado.clabe_bancaria != null && empleado.banco != null && empleado.cve_banco != null && empleado.empresa != null && empleado.idEmpresa != null && empleado.NumEmpl != null)
            {
                //XtraMessageBox.Show("Nombre:" + nombre + "\nRFC:" + RFC + "\nCURP:" + CURP + "\nPeriodicidad:" + peri, "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (XtraMessageBox.Show("¿Desea Editar la información?:\n" + empleado.Nombre.ToString()/* + "\n\nRFC:" + empleado.RFC.ToString() + "\n\nCURP:" + empleado.CURP.ToString() + "\n\nPeriodicidad pago:" + lookUpEdit2.Text +*/ + "\n\nFavor de verificar los datos.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    //Controlador.AgregaEmpleado(empleado);
                    Controlador.EditarEmpleado(empleado);
                    sqlDataSource1.Fill();
                    lookUpEmpl.EditValue = empleado.RFC;
                    this.DeshabilitarCampos();
                }
            }
        }
    }
}
