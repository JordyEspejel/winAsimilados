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
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using E = winAsimilados.Entities;
using C = winAsimilados.Controller;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;

namespace winAsimilados.Views
{
    public partial class AsimiladosPrincipal : Form
    {
        bool salida = true;
        public AsimiladosPrincipal()
        {
            InitializeComponent();
        }

        private void AsimiladosPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            if (salida == true)
            {
                DialogResult result = XtraMessageBox.Show("¿Desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                //if (XtraMessageBox.Show("¿Desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                //{
                //    Application.Exit();
                //}
            }
            //else
            //{
            //    e.Cancel = true;                    
            //}
        }   
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (XtraMessageBox.Show("¿Desea cambiar de empresa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            var frm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (frm != null) 
            {
                frm.BringToFront();
                form.Location = new Point(144, 60);

                if(frm.WindowState == FormWindowState.Minimized)
                {
                    frm.WindowState = FormWindowState.Normal;
                    frm.Size = PanelPrincipal.Size;
                    frm.Location = new Point(144, 60);
                }
            }
            else
            {
                form.Show();
                form.Size = PanelPrincipal.Size;
                form.Location = new Point(144, 60);
            }
 
        }

        private void barLargeButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (XtraMessageBox.Show("¿Desea cambiar de empresa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
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

        private void BtnEditaEmpleados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditarEmpleados editarEmpleados = new EditarEmpleados();
            var frm = Application.OpenForms.OfType<EditarEmpleados>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(144, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    editarEmpleados.Size = PanelPrincipal.Size;
                    editarEmpleados.Location = new Point(144, 60);
                }
            }
            else
            {
                editarEmpleados.Show();
                editarEmpleados.Size = PanelPrincipal.Size;
                editarEmpleados.Location = new Point (144, 60);
            }
        }

        private void barLargeButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AgregarEmpleado agregarEmpleado = new AgregarEmpleado();
            var frm = Application.OpenForms.OfType<AgregarEmpleado>().FirstOrDefault();
            if( frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(144, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    frm.WindowState = FormWindowState.Normal;
                    //frm.Size = PanelPrincipal.Size;
                    //frm.Location = new Point(144, 60);
                }
            }
            else
            {
                
                agregarEmpleado.Show();
                agregarEmpleado.Location = new Point(144, 60);
                //agregarEmpleado.Size = PanelPrincipal.Size;
                //agregarEmpleado.Location = new Point(144, 60);
            }
        }

        private void BtnAgregaEmplMasiv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            splashScreenManager1.ShowWaitForm();

            E.Empleado empl = new E.Empleado();
            C.Controller Controlador = new C.Controller();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; //le indicamos el tipo de filtro en este caso que busque
                                                                             //solo los archivos excel

            dialog.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana

            dialog.FileName = string.Empty;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {


                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                Excel.Range range;
                int rCnt;
                int rw = 0;
                int cl = 0;
                int cont = 0;
                string Archivo = dialog.FileName;
                var misValue = Type.Missing;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(@Archivo, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                range = xlWorkSheet.UsedRange;
                rw = range.Rows.Count;
                cl = range.Columns.Count;
                //ProgressBarControl progressBarControl1 = new ProgressBarControl();
                //progressBarControl1.Properties.Step = 1;
                //progressBarControl1.Properties.PercentView = true;
                //progressBarControl1.Properties.Minimum = 0;
                //form.Controls.Add(progressBarControl1);
                //progressBarControl1.Dock = DockStyle.Fill;
                //form.Show();
                //form.BringToFront();
                //progressBarControl1.Properties.Maximum = rw;
                //progressBarControl1.Update();

                var Empleado = new List<E.Empleado>();
                E.Empleado[] empleado = null;
                for (rCnt = 2; rCnt <= rw; rCnt++)
                {
                    cont++;
                    //progressBarControl1.PerformStep();
                    //progressBarControl1.Update();
                    string nombre = (range.Cells[rCnt, "A"] as Excel.Range).Value2.ToString();
                    string rfc = (range.Cells[rCnt, "B"] as Excel.Range).Value2.ToString();
                    string curp = (range.Cells[rCnt, "C"] as Excel.Range).Value2.ToString();
                    string peri = (range.Cells[rCnt, "D"] as Excel.Range).Value2.ToString();


                    empl.Nombre = nombre;
                    empl.CURP = curp;
                    empl.RFC = rfc;
                    empl.Periodicidad = peri;
                    Empleado.Add(new E.Empleado
                    {

                        Nombre = nombre,
                        CURP = curp,
                        RFC = rfc,
                        Periodicidad = peri

                     });
                    empleado = Empleado.ToArray();

                }

                Controlador.AgregarEmpleadoMasivo(Empleado, empl, splashScreenManager1);
                xlWorkBook.Close(true, "Formato_Masivo_Empleados.xlsx", null);
                xlApp.Quit();
                //progressPanel2.Hide();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
            }
            else
            {
                splashScreenManager1.CloseWaitForm();
            }
        }

        private void btnGenerarExcelEmpl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //progressPanel2.Show();
            splashScreenManager1.ShowWaitForm();
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;

            xlApp = new Excel.Application();
            xlWorkBook = default(Excel.Workbook);
            xlWorkSheet = default(Excel.Worksheet);
            xlApp.Visible = true;

            xlWorkBook = xlApp.Workbooks.Add();
            xlWorkSheet = xlWorkBook.Worksheets[1];
            xlWorkSheet.Visible = Excel.XlSheetVisibility.xlSheetVisible;

            xlWorkSheet.Activate();

            xlWorkBook.PrintPreview();

            //progressPanel2.Hide();
            splashScreenManager1.CloseWaitForm();
        }

        private void BtnAgreEmpreUnit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AgregarEmpresa agregarEmpresa = new AgregarEmpresa(false);
            var frm = Application.OpenForms.OfType<AgregarEmpresa>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(144, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(144, 60);
                }
            }
            else
            {
               
                agregarEmpresa.Show();
                agregarEmpresa.Location = new Point(144, 60);
                //agregarEmpresa.Size = PanelPrincipal.Size;
                //agregarEmpresa.Location = new Point(144, 60);
            }
        }

        private void BtnNomiAsim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NominaAsimilados nominaAsimilados = new NominaAsimilados(lblEmpresa.Caption, lblRFC.Caption);
            var frm = Application.OpenForms.OfType<NominaAsimilados>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(144, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(144, 60);
                }
            }
            else
            {
                nominaAsimilados.Show();
                nominaAsimilados.Location = new Point(144, 60);
                nominaAsimilados.BringToFront();
            }
        }
    }
}
