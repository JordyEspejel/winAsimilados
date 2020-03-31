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
using V = winAsimilados.Views;

namespace winAsimilados
{
    public partial class Form1 : Form
    {
        string fechaIni;
        string fechaFinal;
        string uuid;

        C.Controller Controlador = new C.Controller();
        E.UUID uUID = new E.UUID();
        E.Empresa empresa = new E.Empresa();

        
        public Form1()
        {
            InitializeComponent();
            if (Controlador.BuscarRecursos().Equals(false)){

                Controlador.AgregarRecursos();

            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            fechaIni = fechaInicio.Value.ToString("dd/MM/yyyy");
            fechaFinal = fechaFin.Value.ToString("dd/MM/yyyy");
            Controlador.Buscar(gridControl1, fechaIni, fechaFinal);
            gridControl1.Visible = true;
            //MessageBox.Show(fechaIni, "Fecha");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //string message = C.Conexion.PerformConnection().Database;
            //MessageBox.Show(message);
            //MessageBox.Show("Funciona", "XML & PDF");
            var UUID = new List<E.UUID>();
            E.UUID[] uid = null;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
               if (gridView1.IsRowSelected(i))
                {
                    //MessageBox.Show(gridView1.GetRowCellValue(i, gridView1.Columns[1]).ToString());
                    uuid = gridView1.GetRowCellValue(i, gridView1.Columns[1]).ToString();

                    UUID.Add(new E.UUID
                    {
                        UIID = uuid
                    });
                    uid = UUID.ToArray();
                }

                //uUID.UIID = uuid;


            }
            //Controlador.AgregarRecursos();
            Controlador.Generar(UUID, splashScreenManager1);
            //Controlador.LeerXML();
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
