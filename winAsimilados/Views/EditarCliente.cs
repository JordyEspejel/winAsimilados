﻿using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.XtraEditors;
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
using E = winAsimilados.Entities;

namespace winAsimilados.Views
{
    public partial class EditarCliente : Form
    {
        SplashScreenManager splash;
        C.Controller controlador = new C.Controller();
        E.ClienteAsimilado cliente = new E.ClienteAsimilado();
        public EditarCliente(SplashScreenManager splashScreenManager)
        {
            splash = splashScreenManager;
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard   
            //// Fill a SqlDataSource
            //sqlDataSource1.Fill();
            //// This line of code is generated by Data Source Configuration Wizard
            //// Fill a SqlDataSource
            //sqlDataSource1.Fill();
            //// This line of code is generated by Data Source Configuration Wizard
            //// Fill a SqlDataSource
            //sqlDataSource1.Fill();
            //// This line of code is generated by Data Source Configuration Wizard
            //// Fill a SqlDataSource
            //sqlDataSource1.Fill();
            //// This line of code is generated by Data Source Configuration Wizard
            //// Fill a SqlDataSource
            //sqlDataSource1.Fill();
            //// This line of code is generated by Data Source Configuration Wizard
            //// Fill a SqlDataSource
            //sqlDataSource1.Fill();
            //// This line of code is generated by Data Source Configuration Wizard
            //// Fill a SqlDataSource
            //sqlDataSource1.Fill();
            //// This line of code is generated by Data Source Configuration Wizard
            //// Fill a SqlDataSource
            //sqlDataSource1.Fill();
            //// This line of code is generated by Data Source Configuration Wizard
            //// Fill a SqlDataSource
            //sqlDataSource1.Fill();
            //// This line of code is generated by Data Source Configuration Wizard
            //// Fill a SqlDataSource
            sqlDataSource1.Fill();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            layoutControlbtnEdita.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlBajaClte.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlbtnReactiva.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            if (splash.IsSplashFormVisible.Equals(true))
            {
                splash.CloseWaitForm();
            }
        }

        private void lookUpClte_EditValueChanged(object sender, EventArgs e)
        {
            layoutControlbtnEdita.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            if (lookUpClte.Text != "Seleccione")
            {
                try
                {
                    cliente = controlador.GetInfoCliente(lookUpClte.EditValue.ToString());
                    this.LlenarCampos();
                }catch (Exception ex)
                {

                }
            }
        }
        private void LlenarCampos()
        {
            txtIDClte.Text = cliente.ID;
            lookUpEstatus.EditValue = cliente.ESTATUS;
            txtNombre.Text = cliente.CLIENTE;
            txtComisionista.Text = cliente.COMISIONISTA;
            txtProveedor.Text = cliente.PROVEEDOR;
            txtObservaciones.Text = cliente.Observaciones;
            lookUpEjecutivo.EditValue = cliente.EJECUTIVO_RESPONSABLE;
            lookUpPeriodo.EditValue = cliente.PERIODO_DE_PAGO;
            lookUpFacIva.EditValue = cliente.FACTURACION_CON_IVA_SIN_IVA;
            lookUpRetIva.EditValue = cliente.RETENCION;
            spinEditPerISN.EditValue = cliente.PORCENTAJE_ISN * 100;
            spinEditPerServ.EditValue = cliente.PORCENTAJE_COMISION * 100;
            spinEditRetIVA.EditValue = cliente.PORCENTAJE_RETENCION * 100;
            lookUpEmpCFDI.EditValue = cliente.EMPRESA_PAGADORA_EMITE_CFDI;
            lookUpEmprFact.EditValue = cliente.EMPRESA_QUE_FACTUR_A_CLIENTE;
            spinEditEmpFact.EditValue = cliente.PORCENTAJE_FACTURA * 100;
            txtComi2.Text = cliente.COMISIONISTA2;
            txtComi3.Text = cliente.COMISIONISTA3;
            spinEditComi.EditValue = cliente.PORCENTAJE_COMISIONISTA * 100;
            spinEditComi2.EditValue = cliente.PORCENTAJE_COMISIONISTA2 * 100;
            spinEditComi3.EditValue = cliente.PORCENTAJE_COMISIONISTA3 * 100;
            txtCorreo.Text = cliente.correoCliente;
            if (cliente.EMPRESA_QUE_FACTURA_A_CLIENTE1 != "")
            {
                chBoxEmpFactura.Checked = true;
            }
            else
            {
                chBoxEmpFactura.Checked = false;
            }

            if (cliente.COMISIONISTA2 != "")
            {
                chComi.Checked = true;
            }
            else
            {
                chComi.Checked = false;
            }

            lookUpMetodoPago.EditValue = cliente.Metodo_Pago;
            lookUpFormaPago.EditValue = cliente.Forma_Pago;

        }

        private void chBoxEmpFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxEmpFactura.Checked.Equals(true))
            {
                layoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem30.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem31.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                if (cliente.EMPRESA_QUE_FACTURA_A_CLIENTE1 != "")
                {
                    lookUpEmprFact2.EditValue = cliente.EMPRESA_QUE_FACTURA_A_CLIENTE1;
                    spinEditEmpFact2.EditValue = cliente.PORCENTAJE_FACTURA2 * 100;
                }
                else
                {
                    lookUpEmprFact2.EditValue = null;
                }
                if (cliente.EMPRESA_QUE_FACTURA_A_CLIENTE2 != "")
                {
                    lookUpEmprFact3.EditValue = cliente.EMPRESA_QUE_FACTURA_A_CLIENTE2;
                    spinEditEmpFact3.EditValue = cliente.PORCENTAJE_FACTURA3 * 100;
                }
                else
                {
                    lookUpEmprFact3.EditValue = null;
                }
                if (cliente.EMPRESA_QUE_FACTURA_A_CLIENTE3 != "")
                {
                    lookUpEmprFact4.EditValue = cliente.EMPRESA_QUE_FACTURA_A_CLIENTE3;
                    spinEditEmpFact4.EditValue = cliente.PORCENTAJE_FACTURA4 * 100;
                }
                else
                {
                    lookUpEmprFact4.EditValue = null;
                }
            }
            else
            {
                layoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem30.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem31.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lookUpEmprFact2.EditValue = null;
                lookUpEmprFact3.EditValue = null;
                lookUpEmprFact4.EditValue = null;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            layoutControlbtnEdita.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            if (lookUpEstatus.EditValue.ToString().Equals("Activo"))
            {
                layoutControlBajaClte.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                layoutControlbtnReactiva.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }

            //txtIDClte.ReadOnly = false;
            txtNombre.ReadOnly = false;
            txtComisionista.ReadOnly = false;
            txtProveedor.ReadOnly = false;
            txtObservaciones.ReadOnly = false;
            lookUpEjecutivo.ReadOnly = false;
            lookUpPeriodo.ReadOnly = false;
            lookUpFacIva.ReadOnly = false;
            lookUpRetIva.ReadOnly = false;
            spinEditPerISN.ReadOnly = false;
            spinEditPerServ.ReadOnly = false;
            spinEditRetIVA.ReadOnly = false;
            lookUpEmpCFDI.ReadOnly = false;
            lookUpEmprFact.ReadOnly = false;
            lookUpEmprFact2.ReadOnly = false;
            lookUpEmprFact3.ReadOnly = false;
            lookUpEmprFact4.ReadOnly = false;
            chBoxEmpFactura.ReadOnly = false;
            chComi.ReadOnly = false;
            spinEditComi.ReadOnly = false;
            txtComi2.ReadOnly = false;
            txtComi3.ReadOnly = false;
            spinEditComi3.ReadOnly = false;
            spinEditComi2.ReadOnly = false;
            spinEditEmpFact.ReadOnly = false;
            spinEditEmpFact2.ReadOnly = false;
            spinEditEmpFact3.ReadOnly = false;
            spinEditEmpFact4.ReadOnly = false;
            txtCorreo.ReadOnly = false;
            lookUpMetodoPago.ReadOnly = false;
            lookUpFormaPago.ReadOnly = false;
        }
        private void DeshabilitarCampos()
        {
            txtIDClte.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtComisionista.ReadOnly = true;
            txtProveedor.ReadOnly = true;
            txtObservaciones.ReadOnly = true;
            lookUpEjecutivo.ReadOnly = true;
            lookUpPeriodo.ReadOnly = true;
            lookUpFacIva.ReadOnly = true;
            lookUpRetIva.ReadOnly = true;
            spinEditPerISN.ReadOnly = true;
            spinEditPerServ.ReadOnly = true;
            spinEditRetIVA.ReadOnly = true;
            lookUpEmpCFDI.ReadOnly = true;
            lookUpEmprFact.ReadOnly = true;
            lookUpEmprFact2.ReadOnly = true;
            lookUpEmprFact3.ReadOnly = true;
            lookUpEmprFact4.ReadOnly = true;
            chBoxEmpFactura.ReadOnly = true;
            chComi.ReadOnly = true;
            spinEditComi.ReadOnly = true;
            txtComi2.ReadOnly = true;
            txtComi3.ReadOnly = true;
            spinEditComi3.ReadOnly = true;
            spinEditComi2.ReadOnly = true;
            spinEditEmpFact.ReadOnly = true;
            spinEditEmpFact2.ReadOnly = true;
            spinEditEmpFact3.ReadOnly = true;
            spinEditEmpFact4.ReadOnly = true;
            txtCorreo.ReadOnly = true;


            lookUpMetodoPago.ReadOnly = true;
            lookUpFormaPago.ReadOnly = true;
            layoutControlbtnEdita.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlBajaClte.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlbtnReactiva.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DeshabilitarCampos();
            this.LlenarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCorreo.Text.Equals(""))
                {
                    XtraMessageBox.Show("Campo Correo Electronico Requerido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    cliente.correoCliente = txtCorreo.Text;
                }
                if (txtNombre.Text.Equals(""))
                {
                    XtraMessageBox.Show("Campo Nombre Requerido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cliente.CLIENTE = txtNombre.EditValue.ToString();
                }

                if (txtComisionista.Text.Equals(""))
                {
                    XtraMessageBox.Show("Campo Comisionista Requerido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cliente.COMISIONISTA = txtComisionista.EditValue.ToString();
                    cliente.PORCENTAJE_COMISIONISTA = Convert.ToDecimal(spinEditComi.EditValue.ToString());
                    cliente.PORCENTAJE_COMISIONISTA = cliente.PORCENTAJE_COMISIONISTA / 100;
                }

                if (lookUpEjecutivo.Text.Equals("Seleccione"))
                {
                    XtraMessageBox.Show("Por Favor, Seleccione Ejecutivo Responsable.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cliente.EJECUTIVO_RESPONSABLE = lookUpEjecutivo.EditValue.ToString();
                }

                if (txtProveedor.Text.Equals(""))
                {
                    XtraMessageBox.Show("Campo Proveedor Requerido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cliente.PROVEEDOR = txtProveedor.EditValue.ToString();
                }

                if (lookUpPeriodo.Text.Equals("Seleccione"))
                {
                    XtraMessageBox.Show("Por Favor, Seleccione Periodo de Pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cliente.PERIODO_DE_PAGO = lookUpPeriodo.EditValue.ToString();
                }

                cliente.Observaciones = txtObservaciones.Text;

                if (lookUpFacIva.Text.Equals("Seleccione"))
                {
                    XtraMessageBox.Show("Por Favor, Seleccione si la factura incluye IVA.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cliente.FACTURACION_CON_IVA_SIN_IVA = lookUpFacIva.EditValue.ToString();
                }

                if (lookUpRetIva.Text.Equals("Seleccione"))
                {
                    XtraMessageBox.Show("Por Favor, Seleccione aplica retención de IVA.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cliente.RETENCION = lookUpRetIva.EditValue.ToString();
                }

                cliente.PORCENTAJE_ISN = Convert.ToDecimal(spinEditPerISN.EditValue.ToString());
                cliente.PORCENTAJE_ISN = cliente.PORCENTAJE_ISN / 100;
                cliente.PORCENTAJE_COMISION = Convert.ToDecimal(spinEditPerServ.EditValue.ToString());
                cliente.PORCENTAJE_COMISION = cliente.PORCENTAJE_COMISION / 100;

                if (lookUpRetIva.Text != "Seleccione")
                {
                    if (lookUpRetIva.EditValue.ToString().Equals("S"))
                    {
                        cliente.PORCENTAJE_RETENCION = Convert.ToDecimal(spinEditRetIVA.EditValue.ToString());
                        cliente.PORCENTAJE_RETENCION = cliente.PORCENTAJE_RETENCION / 100;
                    }
                    else
                    {
                        cliente.PORCENTAJE_RETENCION = Convert.ToDecimal(spinEditRetIVA.EditValue.ToString());
                        cliente.PORCENTAJE_RETENCION = cliente.PORCENTAJE_RETENCION / 100;
                    }
                }


                if (lookUpEmpCFDI.Text.Equals("Seleccione"))
                {
                    XtraMessageBox.Show("Por Favor, Seleccione Empresa que emite CFDI.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cliente.EMPRESA_PAGADORA_EMITE_CFDI = lookUpEmpCFDI.EditValue.ToString();
                }

                if (lookUpEmprFact.Text.Equals("Seleccione"))
                {
                    XtraMessageBox.Show("Por Favor, Seleccione Empresa que realiza la factura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cliente.EMPRESA_QUE_FACTUR_A_CLIENTE = lookUpEmprFact.EditValue.ToString();
                    cliente.PORCENTAJE_FACTURA = Convert.ToDecimal(spinEditEmpFact.EditValue.ToString());
                    cliente.PORCENTAJE_FACTURA = cliente.PORCENTAJE_FACTURA / 100;
                }

                if (chBoxEmpFactura.Checked.Equals(true))
                {
                    if (lookUpEmprFact2.Text.Equals("Seleccione"))
                    {
                        XtraMessageBox.Show("Por Favor, Seleccione Empresas  que realizan la factura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cliente.EMPRESA_QUE_FACTURA_A_CLIENTE1 = lookUpEmprFact2.EditValue.ToString();
                        cliente.PORCENTAJE_FACTURA2 = Convert.ToDecimal(spinEditEmpFact2.EditValue.ToString());
                        cliente.PORCENTAJE_FACTURA2 = cliente.PORCENTAJE_FACTURA2 / 100;

                        if (lookUpEmprFact3.Text.Equals("Seleccione"))
                        {
                            cliente.EMPRESA_QUE_FACTURA_A_CLIENTE2 = "";
                            cliente.PORCENTAJE_FACTURA3 = 0;
                        }
                        else
                        {
                            cliente.EMPRESA_QUE_FACTURA_A_CLIENTE2 = lookUpEmprFact3.EditValue.ToString();
                            cliente.PORCENTAJE_FACTURA3 = Convert.ToDecimal(spinEditEmpFact3.EditValue.ToString());
                            cliente.PORCENTAJE_FACTURA3 = cliente.PORCENTAJE_FACTURA3 / 100;
                        }
                        if (lookUpEmprFact4.Text.Equals("Seleccione"))
                        {
                            //XtraMessageBox.Show("Por Favor, Seleccione Empresa (4) que realiza la factura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cliente.EMPRESA_QUE_FACTURA_A_CLIENTE3 = "";
                            cliente.PORCENTAJE_FACTURA4 = 0;
                        }
                        else
                        {
                            cliente.EMPRESA_QUE_FACTURA_A_CLIENTE3 = lookUpEmprFact4.EditValue.ToString();
                            cliente.PORCENTAJE_FACTURA4 = Convert.ToDecimal(spinEditEmpFact4.EditValue.ToString());
                            cliente.PORCENTAJE_FACTURA4 = cliente.PORCENTAJE_FACTURA4 / 100;
                        }
                    }
                    //int porcentaje = Convert.ToInt32(spinEditEmpFact.EditValue.ToString()) + Convert.ToInt32(spinEditEmpFact2.EditValue.ToString()) + Convert.ToInt32(spinEditEmpFact3.EditValue.ToString()) + Convert.ToInt32(spinEditEmpFact4.EditValue.ToString()); 

                    var porcentaje = cliente.PORCENTAJE_FACTURA + cliente.PORCENTAJE_FACTURA2 + cliente.PORCENTAJE_FACTURA3 + cliente.PORCENTAJE_FACTURA4;

                    if (porcentaje > 100)
                    {
                        XtraMessageBox.Show("Los porcentajes Asignados a las empresas que facturan, exceden el 100% favor de validar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    cliente.EMPRESA_QUE_FACTURA_A_CLIENTE1 = "";
                    cliente.PORCENTAJE_FACTURA2 = 0;
                    cliente.EMPRESA_QUE_FACTURA_A_CLIENTE2 = "";
                    cliente.PORCENTAJE_FACTURA3 = 0;
                    cliente.EMPRESA_QUE_FACTURA_A_CLIENTE3 = "";
                    cliente.PORCENTAJE_FACTURA4 = 0;

                }

                if (lookUpMetodoPago.Text.Equals("Seleccione"))
                {
                    XtraMessageBox.Show("Por Favor, Seleccione Metodo de pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cliente.Metodo_Pago = lookUpMetodoPago.EditValue.ToString();
                }

                if (lookUpFormaPago.Text.Equals("Seleccione"))
                {
                    XtraMessageBox.Show("Por Favor, Seleccione Forma de pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cliente.Forma_Pago = lookUpFormaPago.EditValue.ToString();
                }

                cliente.TOTAL = cliente.PORCENTAJE_COMISION + cliente.PORCENTAJE_ISN;
                //cliente.ESTATUS = "Activo";

                if (cliente.ID != null && cliente.CLIENTE != null && cliente.COMISIONISTA != null && cliente.FACTURACION_CON_IVA_SIN_IVA != null && cliente.RETENCION != null && cliente.PERIODO_DE_PAGO != null && cliente.EJECUTIVO_RESPONSABLE != null && cliente.EMPRESA_PAGADORA_EMITE_CFDI != null && cliente.PROVEEDOR != null && cliente.EMPRESA_QUE_FACTUR_A_CLIENTE != null && cliente.EMPRESA_QUE_FACTURA_A_CLIENTE1 != null && cliente.EMPRESA_QUE_FACTURA_A_CLIENTE2 != null && cliente.EMPRESA_QUE_FACTURA_A_CLIENTE3 != null && cliente.Metodo_Pago != null && cliente.Observaciones != null && cliente.Forma_Pago != null)
                {
                    //XtraMessageBox.Show("Entra");
                    if (controlador.UpdateCliente(cliente).Equals(true))
                    {
                        XtraMessageBox.Show("¡Información actualizada con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sqlDataSource1.Fill();
                        lookUpClte.EditValue = cliente.ID;
                        this.DeshabilitarCampos();
                    }
                    else
                    {
                        XtraMessageBox.Show("!Error al intentar actualizar informacion de cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Error en formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception btn)
            {
                XtraMessageBox.Show(btn.Message + "\nError formulario btnAgregar()", "Error", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void btnBajaClte_Click(object sender, EventArgs e)
        {
            var respuesta = XtraMessageBox.Show("¿Desea dar debaja al cliente:\n" + txtNombre.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta.Equals(DialogResult.Yes))
            {
                if (controlador.BajaCliente(cliente).Equals(true))
                {
                    XtraMessageBox.Show("¡Cliente dado de baja con éxito!", "Mensaje", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    cliente = controlador.GetInfoCliente(lookUpClte.EditValue.ToString());
                    this.LlenarCampos();
                    this.DeshabilitarCampos();
                }
            }
        }

        private void btnReactiva_Click(object sender, EventArgs e)
        {
            var respuesta = XtraMessageBox.Show("¿Desea reactivar cliente:\n" + txtNombre.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta.Equals(DialogResult.Yes))
            {
                if (controlador.ReactivaCliente(cliente).Equals(true))
                {
                    XtraMessageBox.Show("¡Cliente reactivado con éxito!", "Mensaje", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    cliente = controlador.GetInfoCliente(lookUpClte.EditValue.ToString());
                    this.LlenarCampos();
                    this.DeshabilitarCampos();
                }
            }
        }

        private void chComi_CheckedChanged(object sender, EventArgs e)
        {
            if (chComi.Checked.Equals(true))
            {
                layoutControlComi2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlComi3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlSpinComi3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                layoutControlComi2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlComi3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlSpinComi3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }
    }
}
