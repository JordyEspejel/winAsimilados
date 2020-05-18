using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = winAsimilados.Controller;
using E = winAsimilados.Entities;
using V = winAsimilados.Views;
using System.Windows.Forms;
using System.Windows.Controls;
using System.IO;
using DevExpress.XtraEditors;

namespace winAsimilados.Views
{
    public partial class GenPDF12 : Form
    {
        string fechaIni;
        string fechaFinal;
        string uuid;
        string rutaXML;
        string fecPago;
        string nomEmpl;
        string RFC;
        string pathPDF = @"C:\XML\";
        string PDF;
        C.Controller Controlador = new C.Controller();
        public GenPDF12()
        {
            InitializeComponent();
        }

        private void GenPDF12_Load(object sender, EventArgs e)
        {
            fechaIni = FecIni.Value.ToString("yyyy/MM/dd");
            fechaFinal = FecFinal.Value.ToString("yyyy/MM/dd");
            Controlador.Buscar12(gridControl1, fechaIni, fechaFinal);
            gridControl1.Visible = true;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            fechaIni = FecIni.Value.ToString("yyyy/MM/dd");
            fechaFinal = FecFinal.Value.ToString("yyyy/MM/dd");
            Controlador.Buscar12(gridControl1, fechaIni, fechaFinal);
            gridControl1.Visible = true;
        }

        [Obsolete]
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var UUID = new List<E.UUID>();
                E.UUID[] uid = null;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.IsRowSelected(i))
                    {
                        uuid = gridView1.GetRowCellValue(i, gridView1.Columns[1]).ToString();
                        UUID.Add(new E.UUID
                        {
                            UIID = uuid
                        });
                        uid = UUID.ToArray();
                    }

                }
                Controlador.Generar12(UUID, splashScreenManager1);
            }
            catch (Exception btn)
            {
                XtraMessageBox.Show(btn.Message + "Error modulo GenPDF1.2: \nBtnAceptar", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }
    }
}
    