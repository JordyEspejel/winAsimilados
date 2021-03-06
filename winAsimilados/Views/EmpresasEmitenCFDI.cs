﻿using DevExpress.XtraEditors;
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
    public partial class EmpresasEmitenCFDI : Form
    {
        C.Controller controlador = new C.Controller();
        E.EmpresaCFDI empresaCFDI = new E.EmpresaCFDI();
        SplashScreenManager splash;
        string ID;
        string newID;
        int numID;
        string IDE;
        string razon;
        string Estatus;
        public EmpresasEmitenCFDI(SplashScreenManager splashScreen)
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
            splash = splashScreen;
        }

        private void GetEmpresaID()
        {
            ID = controlador.GetIDEmpresaCFDI();
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

            if (numID.ToString().Length.Equals(1))
            {
                numID++;
                newID = "C0" + numID.ToString();
            }
            else if (numID.ToString().Length.Equals(2))
            {
                numID++;
                newID = "C" + numID.ToString();
            }
            else if (numID.ToString().Length.Equals(3))
            {
                numID++;
                newID = "C" + numID.ToString();
            }

            //txtID.Text = newID;
            txtID.Text = newID;
            //cliente.ID = newID;
            newID = "";
        }

        public void LlenaTabla()
        {
            controlador.ListaEmpresasCFDI(gridControlEmpr);
            gridControlEmpr.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            empresaCFDI.IDEmpresa = txtID.Text;
            if (txtRazon.Text.Equals(""))
            {
                XtraMessageBox.Show("Por favor, ingrese Razon Social", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                empresaCFDI.razonSocial = txtRazon.Text;
            }
            if (controlador.InsertaEmpresaCFDI(empresaCFDI).Equals(true))
            {
                XtraMessageBox.Show("¡Empresa Agregada Con Éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LlenaTabla();
                this.GetEmpresaID();
                txtRazon.Text = "";
            }
            else
            {
                XtraMessageBox.Show("Error al dar de alta Empresa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarInfo_Click(object sender, EventArgs e)
        {
            layoutControlbtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlbtnBaja.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlbtnAlta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            colDescripcion.OptionsColumn.AllowEdit = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            layoutControlbtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlbtnBaja.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlbtnAlta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            colDescripcion.OptionsColumn.AllowEdit = false;
            this.LlenaTabla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var respuesta = XtraMessageBox.Show("¿Desea guardar los cambios realizados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta.Equals(DialogResult.Yes))
            {
                var listaEmpresa = new List<E.EmpresaCFDI>();
                for (int i = 0; i < gridViewEmpr.RowCount; i++)
                {
                    IDE = gridViewEmpr.GetRowCellValue(i, gridViewEmpr.Columns[0]).ToString();
                    razon = gridViewEmpr.GetRowCellValue(i, gridViewEmpr.Columns[1]).ToString();
                    //Estatus = gridViewEmpr.GetRowCellValue(i, gridViewEmpr.Columns[2]).ToString();
                    listaEmpresa.Add(new E.EmpresaCFDI
                    {
                        IDEmpresa = IDE,
                        razonSocial = razon,
                    });
                }

                if (controlador.ModificaEmpresaCFDI(listaEmpresa).Equals(true))
                {
                    XtraMessageBox.Show("!Información actualizada¡", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    layoutControlbtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlbtnBaja.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlbtnAlta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    colDescripcion.OptionsColumn.AllowEdit = false;
                    this.LlenaTabla();
                }

            }
        }

        private void EmpresasEmitenCFDI_Load(object sender, EventArgs e)
        {
            splash.CloseWaitForm();
            this.GetEmpresaID();
            this.LlenaTabla();
        }

        private void btnAltaEmpr_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewEmpr.RowCount; i++)
            {
                if (gridViewEmpr.IsRowSelected(i))
                {
                    IDE = gridViewEmpr.GetRowCellValue(i, gridViewEmpr.Columns[0]).ToString();

                    razon = gridViewEmpr.GetRowCellValue(i, gridViewEmpr.Columns[1]).ToString();
                    Estatus = gridViewEmpr.GetRowCellValue(i, gridViewEmpr.Columns[2]).ToString();
                }
            }
            if (Estatus.Equals("I"))
            {
                if (controlador.AltaEmpresaCFDI(IDE).Equals(true))
                {

                    XtraMessageBox.Show("!La Empresa: " + razon + " fue dada de alta con éxito¡", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    layoutControlbtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlbtnBaja.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlbtnAlta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    colDescripcion.OptionsColumn.AllowEdit = false;
                    this.LlenaTabla();
                }
                else
                {
                    XtraMessageBox.Show("!Error al dar de alta la empresa:" + razon + " ¡", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    layoutControlbtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlbtnBaja.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlbtnAlta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    colDescripcion.OptionsColumn.AllowEdit = false;
                    this.LlenaTabla();
                }
            }
            else
            {
                XtraMessageBox.Show("!La Empresa: " + razon + " Ya fue dada de alta anteriormente¡", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                layoutControlbtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlbtnBaja.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlbtnAlta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                colDescripcion.OptionsColumn.AllowEdit = false;
                this.LlenaTabla();
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewEmpr.RowCount; i++)
            {
                if (gridViewEmpr.IsRowSelected(i))
                {
                    IDE = gridViewEmpr.GetRowCellValue(i, gridViewEmpr.Columns[0]).ToString();
                    razon = gridViewEmpr.GetRowCellValue(i, gridViewEmpr.Columns[1]).ToString();
                    Estatus = gridViewEmpr.GetRowCellValue(i, gridViewEmpr.Columns[2]).ToString();
                }
            }
            if (Estatus.Equals("A"))
            {
                if (controlador.BajaEmpresaCFDI(IDE).Equals(true))
                {

                    XtraMessageBox.Show("!La Empresa: " + razon + " fue dada de baja con éxito¡", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    layoutControlbtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlbtnBaja.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlbtnAlta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    colDescripcion.OptionsColumn.AllowEdit = false;
                    this.LlenaTabla();
                }
                else
                {
                    XtraMessageBox.Show("!Error al dar de baja la empresa:" + razon + " ¡", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    layoutControlbtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlbtnBaja.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlbtnAlta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    colDescripcion.OptionsColumn.AllowEdit = false;
                    this.LlenaTabla();
                }
            }
            else
            {
                XtraMessageBox.Show("!La Empresa: " + razon + " Ya fue dada de baja anteriormente¡", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                layoutControlbtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlbtnBaja.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlbtnAlta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                colDescripcion.OptionsColumn.AllowEdit = false;
                this.LlenaTabla();
            }
        }
    }
}
