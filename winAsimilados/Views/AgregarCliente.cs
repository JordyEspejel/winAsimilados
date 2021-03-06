﻿using DevExpress.XtraCharts.Designer.Native;
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
using System.Windows;
using System.Windows.Forms;
using C = winAsimilados.Controller;
using E = winAsimilados.Entities;

namespace winAsimilados.Views
{
    public partial class AgregarCliente : Form
    {
        C.Controller controlador = new C.Controller();
        E.ClienteAsimilado cliente = new E.ClienteAsimilado();
        SplashScreenManager splash;
        string ID;
        string newID;
        int numID;
        public AgregarCliente(SplashScreenManager splashScreenManager)
        {
            try 
            {
                splash = splashScreenManager;
                InitializeComponent();


                // This line of code is generated by Data Source Configuration Wizard
                // Fill a SqlDataSource
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
                // This line of code is generated by Data Source Configuration Wizard
                // Fill a SqlDataSource
                sqlDataSource1.Fill();
            }catch (Exception e)
            {
                if (splash.IsSplashFormVisible.Equals(true))
                {
                    splash.CloseWaitForm();
                }
                XtraMessageBox.Show(e.Message);
            }
            }


        private void GetNextID()
        {
            ID = controlador.GetIDCliente();

            for (int i = 0; i < ID.Length; i++)
            {
                if (Char.IsDigit(ID[i]))
                {
                    newID += ID[i];
                }
            }
            if (newID.Length > 0)
            {
                numID = int.Parse(newID);
            }

            if (numID.ToString().Length.Equals(3))
            {
                numID++;
                newID = "E00" + numID.ToString();
            }

            //txtID.Text = newID;
            txtIDClte.Text = newID;
            cliente.ID = newID;
            newID = "";
        }
        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            GetNextID();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
            if (chComi.Checked.Equals(false))
            {
                spinEditComi.Text = "100";
            }
            if (chBoxEmpFactura.Checked.Equals(false))
            {
                spinEditEmpFact.Text = "100";
            }
            if (splash.IsSplashFormVisible.Equals(true))
            {
                splash.CloseWaitForm();
            }
        }

        private void ReiniciaFormulario()
        {
            GetNextID();
            txtNombre.Text = "";
            txtComisionista.Text = "";
            lookUpEjecutivo.EditValue = null;
            txtProveedor.Text = "";
            lookUpPeriodo.EditValue = null;
            txtObservaciones.Text = "";
            lookUpFacIva.EditValue = null;
            lookUpRetIva.EditValue = null;
            spinEditPerISN.Text = "0";
            spinEditPerServ.Text = "0";
            spinEditRetIVA.Text = "0";
            spinEditComi.Text = "0";
            spinEditComi2.Text = "0";
            spinEditComi3.Text = "0";
            txtComi2.Text = "";
            txtComi3.Text = "";
            lookUpEmpCFDI.EditValue = null;
            lookUpEmprFact.EditValue = null;
            lookUpEmprFact2.EditValue = null;
            lookUpEmprFact3.EditValue = null;
            lookUpEmprFact4 .EditValue = null;
            lookUpMetodoPago.EditValue = null;
            lookUpFormaPago.EditValue = null;
            cliente = null;
        }

        private void lookUpRetIva_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpRetIva.Text != "Seleccione")
            {
                if (lookUpRetIva.EditValue.ToString().Equals("N"))
                {
                    spinEditRetIVA.ReadOnly = true;
                    spinEditRetIVA.Text = "0";
                }
                else
                {
                    spinEditRetIVA.ReadOnly = false;
                }
            }

        }

        private void chBoxEmpFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxEmpFactura.Checked.Equals(true))
            {
                spinEditEmpFact.Text = "0";
                layoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem26.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem27.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                lookUpEmprFact2.EditValue = null;
                lookUpEmprFact3.EditValue = null;
                lookUpEmprFact4.EditValue = null;
                layoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem26.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem27.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
                    cliente.CLIENTE = txtNombre.Text;
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
                    int porcentaje = 0;
                    porcentaje = Convert.ToInt32(spinEditEmpFact.EditValue.ToString()) + Convert.ToInt32(spinEditEmpFact2.EditValue.ToString()) + Convert.ToInt32(spinEditEmpFact3.EditValue.ToString()) + Convert.ToInt32(spinEditEmpFact4.EditValue.ToString());

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
                cliente.ESTATUS = "Activo";


                if (chComi.Checked.Equals(true))
                {
                    if (txtComi2.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Campo Comisionista 2 Requerido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        cliente.COMISIONISTA2 = txtComi2.Text;
                        cliente.PORCENTAJE_COMISIONISTA2 = Convert.ToDecimal(spinEditComi2.EditValue.ToString());
                        cliente.PORCENTAJE_COMISIONISTA2 = cliente.PORCENTAJE_COMISIONISTA2 / 100;
                    }

                    if (txtComi3.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Campo Comisionista 3 Requerido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        cliente.COMISIONISTA3 = txtComi3.Text;
                        cliente.PORCENTAJE_COMISIONISTA3 = Convert.ToDecimal(spinEditComi3.EditValue.ToString());
                        cliente.PORCENTAJE_COMISIONISTA3 = cliente.PORCENTAJE_COMISIONISTA3 / 100;
                    }
                    int porcentaje = 0;
                    porcentaje = Convert.ToInt32(spinEditComi.EditValue.ToString()) + Convert.ToInt32(spinEditComi2.EditValue.ToString()) + Convert.ToInt32(spinEditComi3.EditValue.ToString());

                    if (porcentaje > 100)
                    {
                        XtraMessageBox.Show("Los porcentajes Asignados a los comisionistas exceden el 100% favor de validar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    cliente.COMISIONISTA2 = "";
                    cliente.COMISIONISTA3 = "";
                    cliente.PORCENTAJE_COMISIONISTA2 = 0;
                    cliente.PORCENTAJE_COMISIONISTA3 = 0;
                }

                if (cliente.ID != null && cliente.CLIENTE != null && cliente.COMISIONISTA != null && cliente.FACTURACION_CON_IVA_SIN_IVA != null && cliente.RETENCION != null && cliente.PERIODO_DE_PAGO != null && cliente.EJECUTIVO_RESPONSABLE != null && cliente.EMPRESA_PAGADORA_EMITE_CFDI != null && cliente.PROVEEDOR != null && cliente.EMPRESA_QUE_FACTUR_A_CLIENTE != null && cliente.EMPRESA_QUE_FACTURA_A_CLIENTE1 != null && cliente.EMPRESA_QUE_FACTURA_A_CLIENTE2 != null && cliente.EMPRESA_QUE_FACTURA_A_CLIENTE3 != null && cliente.Metodo_Pago != null && cliente.Observaciones != null && cliente.Forma_Pago != null)
                {
                    //XtraMessageBox.Show("Entra");
                    if (controlador.InsertaCliente(cliente).Equals(true))
                    {
                        XtraMessageBox.Show("¡Cliente agregado con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ReiniciaFormulario();
                    }
                    else
                    {
                        XtraMessageBox.Show("!Error al intentar registrar cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void chComi_CheckedChanged(object sender, EventArgs e)
        {
            if (chComi.Checked.Equals(true))
            {
                spinEditComi.Text = "0";
                layoutControlComi2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlSpinComi2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlComi3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlSpinComi3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                layoutControlComi2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlSpinComi2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlComi3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlSpinComi3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }
    }
}
