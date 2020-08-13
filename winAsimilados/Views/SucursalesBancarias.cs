using DevExpress.XtraEditors;
using DevExpress.XtraReports.Design;
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
    public partial class SucursalesBancarias : Form
    {
        string cve, desc, rsocial;
        C.Controller controlador = new C.Controller();
        E.Banco banco = new E.Banco();
        SplashScreenManager splash;
        bool seleccion = false;
        public SucursalesBancarias(SplashScreenManager splashScreenManager)
        {
            splash = splashScreenManager;
            InitializeComponent();
        }

        private void LlenaTabla()
        {
            controlador.ListaBancos(gridControlSucursales);
            gridControlSucursales.Visible = true;
        }
        private void SucursalesBancarias_Load(object sender, EventArgs e)
        {
            this.LlenaTabla();
            if (splash.IsSplashFormVisible.Equals(true))
            {
                splash.CloseWaitForm();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCVE.Text.Equals(""))
            {
                XtraMessageBox.Show("El campo Clave Banco no puede estar vacio.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                banco.cveBanco = txtCVE.Text;
            }

            if (txtDesc.Text.Equals(""))
            {
                XtraMessageBox.Show("El campo descripción no puede estar vacio.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                banco.nombre = txtDesc.Text;
            }

            if (txtRazon.Text.Equals(""))
            {
                XtraMessageBox.Show("El campo razón social no puede estar vacio.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                banco.razonSocial = txtRazon.Text;
            }

            if (banco.cveBanco != null && banco.nombre != null && banco.razonSocial != null)
            {
                if (controlador.InsertaBanco(banco).Equals(true))
                {
                    this.LlenaTabla();
                }
                else
                {
                    XtraMessageBox.Show("!Banco agregado con éxito¡", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewSucursales.RowCount; i++)
            {
                if (gridViewSucursales.IsRowSelected(i))
                {
                    cve = gridViewSucursales.GetRowCellValue(i, gridViewSucursales.Columns[0]).ToString();
                    desc = gridViewSucursales.GetRowCellValue(i, gridViewSucursales.Columns[1]).ToString();
                    rsocial = gridViewSucursales.GetRowCellValue(i, gridViewSucursales.Columns[2]).ToString();
                    seleccion = true;
                }
                if (seleccion.Equals(false))
                {
                    XtraMessageBox.Show("Por favor, seleccione una celda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var respuesta2 = XtraMessageBox.Show("¿Desea eliminar el banco " + desc + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta2.Equals(DialogResult.Yes))
                    {
                        //XtraMessageBox.Show("Entra borrar");
                        if (controlador.EliminaBanco(cve).Equals(true))
                        {
                            this.LlenaTabla();
                        }
                        else
                        {
                            XtraMessageBox.Show("¡Error al intentar eliminar banco ligado al cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            layoutControlBtnAgregar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlbtnEliminar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlBtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

            gridViewSucursales.OptionsBehavior.Editable = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            layoutControlBtnAgregar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlbtnEliminar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlBtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            gridViewSucursales.OptionsBehavior.Editable = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var respuesta = XtraMessageBox.Show("¿Desea guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta.Equals(DialogResult.Yes))
            {
                splash.ShowWaitForm();
                var listaBancos = new List<E.Banco>();
                for (int i = 0; i <gridViewSucursales.RowCount; i++)
                {
                    cve = gridViewSucursales.GetRowCellValue(i, gridViewSucursales.Columns[0]).ToString();
                    desc = gridViewSucursales.GetRowCellValue(i, gridViewSucursales.Columns[1]).ToString();
                    rsocial = gridViewSucursales.GetRowCellValue(i, gridViewSucursales.Columns[2]).ToString();

                    listaBancos.Add(new E.Banco
                    {
                        cveBanco = cve,
                        nombre = desc,
                        razonSocial = rsocial
                    });
                }

                if (controlador.modificaListaBancos(listaBancos,splash).Equals(true))
                {
                    splash.CloseWaitForm();
                    XtraMessageBox.Show("!Información actualizada¡", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    layoutControlBtnAgregar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlbtnEliminar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlBtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                    gridViewSucursales.OptionsBehavior.Editable = false;

                    this.LlenaTabla();
                }
                else
                {
                    XtraMessageBox.Show("!Error al intentar actualizar información¡", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        layoutControlBtnAgregar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlbtnEliminar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlBtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                    gridViewSucursales.OptionsBehavior.Editable = false;
                }
            }
        }
    }
}
