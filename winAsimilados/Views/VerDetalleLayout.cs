﻿using DevExpress.Xpo.Helpers;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using C = winAsimilados.Controller;
using E = winAsimilados.Entities;

namespace winAsimilados.Views
{
    public partial class VerDetalleLayout : Form
    {
        C.Controller controlador = new C.Controller();
        E.ClienteAsimilado ClienteAsimilado = new E.ClienteAsimilado();
        E.Caratula caratula = new E.Caratula();
        string nombreLayout, cliente, nombreCaratula;
        SplashScreenManager splash;
        public VerDetalleLayout(string layout, string IDCliente, string caratula, SplashScreenManager splashScreen)
        {
            splash = splashScreen;
            nombreLayout = layout;
            cliente = IDCliente;
            nombreCaratula = caratula;
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill(); //lookUpEmpresa
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill(); //lookUpCliente
        }

        private void VerDetalleLayout_Load(object sender, EventArgs e)
        {
            caratula = controlador.GetDatosCaratula(nombreCaratula);
            ClienteAsimilado = controlador.GetInfoCliente(cliente);
            controlador.DetalleLayoyt(gridControlViewLayout, nombreLayout);
            this.PutDataGral();
            this.PutDataCaratula();
            this.PutDataLayout();
            if (splash.IsSplashFormVisible.Equals(true))
            {
                splash.CloseWaitForm();
            }
        }

        private void PutDataCaratula()
        {
            lookUpEmpresa.EditValue = caratula.IDEmpresa;
            lookUpCliente.EditValue = caratula.IDCliente;
            dateTimePickerFecAp.Value = caratula.FechaAplicacion;
            dateTimePickerFecIniPeri.Value = caratula.FechaIniPeriodo;
            dateTimePickerFecFinPeri.Value = caratula.FechaFinPeriodo;
            txtSalario.Text = caratula.AsimiSalarios.ToString();
            txtProAguinaldo.Text = caratula.ProvAguinaldo.ToString();
            txtProVac.Text = caratula.ProviVacaciones.ToString();
            txtProPVac.Text = caratula.ProviPrimVacacional.ToString();
            txtSubTotal.Text = caratula.SubTotalIAS.ToString();
            layoutControlItemServCaratula.Text = layoutControlItemServCaratula.Text + " " + Convert.ToString(ClienteAsimilado.PORCENTAJE_COMISION * 100) + "%";
            txtServicio.Text = caratula.ComisionServicio.ToString();
            if (ClienteAsimilado.PORCENTAJE_ISN <= 0)
            {
                layoutControlItemISNCaratula.Text = layoutControlItemISNCaratula.Text + " " + Convert.ToString(ClienteAsimilado.PORCENTAJE_ISN * 100) + "% (No Aplica)";
            }
            else
            {
                layoutControlItemISNCaratula.Text = layoutControlItemISNCaratula.Text + " " + Convert.ToString(ClienteAsimilado.PORCENTAJE_ISN * 100) + "%";
            }

            txtISNCaratula.Text = caratula.ImpNomi.ToString();
            txtTotalCaratula.Text = caratula.Total.ToString();
            txtIVA.Text = caratula.IVA.ToString();
            if (ClienteAsimilado.RETENCION.Equals("N"))
            {
                layoutControlItemRetIVACaratula.Text = layoutControlItemRetIVACaratula.Text + " (No Aplica)";
            }
            txtRetencionIVA.Text = caratula.RetencionIVA.ToString();
            txtFactura.Text = caratula.TotalFactura.ToString();
            txtAjuste.Text = caratula.Ajuste.ToString();
            txtDeposito.Text = caratula.TotalDeposito.ToString();
            txtBancoCaratula.Text = caratula.Banco;
            txtCuenta.Text = caratula.NumCuenta;
            txtCLABE.Text = caratula.CLABE;
            lookUpClveFact.Text = caratula.ClaveFacturacion;
            txtTipoPago.Text = caratula.TipoPago;
            txtFormaPago.Text = caratula.FormaPago;
            textBoxObsCaratula.Text = caratula.Observaciones;
        }

        private void PutDataLayout()
        {
            txtTotalEmpl.Text = caratula.TotalEmpleados.ToString();
            txtSalarioLayout.Text = caratula.AsimiSalarios.ToString();
            layoutControlItemServLayout.Text = layoutControlItemServLayout.Text + " " + Convert.ToString(ClienteAsimilado.PORCENTAJE_COMISION * 100) + "%";
            txtServLayout.Text = caratula.ComisionServicio.ToString();
            if (ClienteAsimilado.PORCENTAJE_ISN <= 0)
            {
                layoutControlItemISNLayout.Text = layoutControlItemISNLayout.Text + " " + Convert.ToString(ClienteAsimilado.PORCENTAJE_ISN * 100) + "% (No Aplica)";
            }
            else
            {
                layoutControlItemISNLayout.Text = layoutControlItemISNLayout.Text + " " + Convert.ToString(ClienteAsimilado.PORCENTAJE_ISN * 100) + "%";
            }

            txtISNLayout.Text = caratula.ImpNomi.ToString();
            txtTotalLayout.Text = caratula.Total.ToString();
            txtIVALayout.Text = caratula.IVA.ToString();
            if (ClienteAsimilado.RETENCION.Equals("N"))
            {
                layoutControlItemRetIVALayout.Text = layoutControlItemRetIVALayout.Text + " (No Aplica)";
            }
            txtRetIVALayout.Text = caratula.RetencionIVA.ToString();
            txtTotalLayout.Text = caratula.TotalFactura.ToString();
        }

        private void PutDataGral()
        {
            if (caratula.Estatus.Equals("Generado"))
            {
                txtEstatusGral.Text = "Generado (Sin Pagar)";
            }
            else
            {
                txtEstatusGral.Text = caratula.Estatus;
            }
            txtFechaCreacion.Text = caratula.FechaCreacion.ToString();
            txtUsuaCreacion.Text = caratula.usuario;
            string fechaMod = caratula.FechaModificacion.ToString("dd/MM/yyyy");
            if (fechaMod.Equals("01/01/1900"))
            {
                txtFechaMod.Text = "Sin Modificar";
            }
            else
            {
                txtFechaMod.Text = caratula.FechaModificacion.ToString();
            }
            txtUsuaMod.Text = caratula.UsuarioModificacion;
            string fechaPago = caratula.FechaValidaPago.ToString("dd/MM/yyyy");
            if (fechaPago.Equals("01/01/1900"))
            {
                txtFechaValPago.Text = "No Pagado";
            }
            else
            {
                txtFechaValPago.Text = caratula.FechaValidaPago.ToString();
            }
            TxtUsuaPago.Text = caratula.UsuarioPago;
            txtEmpresaGral.Text = caratula.Empresa;
            txtClienteGral.Text = caratula.Cliente;
            txtNomCaratulaGral.Text = caratula.caratula;
            txtNombreLayoutGral.Text = caratula.Layout;
            txtPagoAsimGral.Text = caratula.AsimiSalarios.ToString();

            layoutControlItem39.Text = layoutControlItem39.Text + " " + Convert.ToString(ClienteAsimilado.PORCENTAJE_COMISION * 100) + "%";
            txtServGral.Text = caratula.ComisionServicio.ToString();
            if (ClienteAsimilado.PORCENTAJE_ISN <= 0)
            {
                layoutControlItem40.Text = layoutControlItem40.Text + " " + Convert.ToString(ClienteAsimilado.PORCENTAJE_ISN * 100) + "% (No Aplica)";
            }
            else
            {
                layoutControlItem40.Text = layoutControlItem40.Text + " " + Convert.ToString(ClienteAsimilado.PORCENTAJE_ISN * 100) + "%";
            }
            txtISNGral.Text = caratula.ImpNomi.ToString();
            txtIVAGral.Text = caratula.IVA.ToString();

            if (ClienteAsimilado.RETENCION.Equals("N"))
            {
                layoutControlItem47.Text = layoutControlItem47.Text + " (No Aplica)";
            }
            txtRetIVAGral.Text = caratula.RetencionIVA.ToString();
            txtTotalGral.Text = caratula.TotalFactura.ToString();
            txtBancoGral.Text = caratula.Banco;
            txtCuentaGral.Text = caratula.NumCuenta;
            txtCLABEGral.Text = caratula.CLABE;
        }
        private void VerDetalleLayout_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}