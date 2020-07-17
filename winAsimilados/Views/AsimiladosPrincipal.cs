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
using System.IO;
using DevExpress.Persistent.Base;

namespace winAsimilados.Views
{
    public partial class AsimiladosPrincipal : Form
    {
        C.Controller controller = new C.Controller();
        bool salida = true;
        string numEmpl;
        string nombre;
        string rfc;
        string curp;
        string peri;
        string cuenta;
        string clabe;
        string cve;
        string banco;
        string empresa;
        string idEmpr;
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
                form.Location = new Point(270, 60);

                if(frm.WindowState == FormWindowState.Minimized)
                {
                    frm.WindowState = FormWindowState.Normal;
                    frm.Size = PanelPrincipal.Size;
                    frm.Location = new Point(270, 60);
                }
            }
            else
            {
                form.Size = PanelPrincipal.Size;
                form.Location = new Point(270, 60);
                form.Show();
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
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    editarEmpleados.Size = PanelPrincipal.Size;
                    editarEmpleados.Location = new Point(270, 60);
                }
            }
            else
            {
                editarEmpleados.Size = PanelPrincipal.Size;
                editarEmpleados.Location = new Point(270, 60);
                editarEmpleados.Show();
            }
        }

        private void barLargeButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AgregarEmpleado agregarEmpleado = new AgregarEmpleado();
            var frm = Application.OpenForms.OfType<AgregarEmpleado>().FirstOrDefault();
            if( frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    frm.WindowState = FormWindowState.Normal;
                    //frm.Size = PanelPrincipal.Size;
                    //frm.Location = new Point(270, 60);
                }
            }
            else
            {
                
                agregarEmpleado.Show();
                agregarEmpleado.Location = new Point(270, 60);
                //agregarEmpleado.Size = PanelPrincipal.Size;
                //agregarEmpleado.Location = new Point(270, 60);
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

            //xlWorkBook.PrintPreview();

            xlWorkBook.Close();

            //progressPanel2.Hide();
            splashScreenManager1.CloseWaitForm();
        }

        private void BtnAgreEmpreUnit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AgregarEmpresa agregarEmpresa = new AgregarEmpresa(false, splashScreenManager1);
            var frm = Application.OpenForms.OfType<AgregarEmpresa>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(270, 60);
                }
            }
            else
            {
                agregarEmpresa.Location = new Point(270, 60);
                agregarEmpresa.Show();
                //agregarEmpresa.Size = PanelPrincipal.Size;
                //agregarEmpresa.Location = new Point(270, 60);
            }
        }

        private void BtnNomiAsim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NominaAsimilados nominaAsimilados = new NominaAsimilados(lblEmpresa.Caption, lblRFC.Caption, splashScreenManager1);
            var frm = Application.OpenForms.OfType<NominaAsimilados>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    frm.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(270, 60);
                }
            }
            else
            {
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption("Cargando Modulo Nómina...");
                nominaAsimilados.Location = new Point(270, 60);
                nominaAsimilados.Size = PanelPrincipal.Size;
                nominaAsimilados.Show();
                nominaAsimilados.BringToFront();
            }
        }

        private void BtnEdiarEmpresa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditarEmpresa editarEmpresa = new EditarEmpresa(lblRFC.Caption, splashScreenManager1);
            var frm = Application.OpenForms.OfType<EditarEmpresa>().FirstOrDefault();
            if (frm != null)
            {
                frm.Location = new Point(270, 60);
                frm.BringToFront();

                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(270, 60);
                }
            }
            else
            {
                editarEmpresa.Location = new Point(270, 60);
                editarEmpresa.Show();
                editarEmpresa.BringToFront();

            }
        }

        private void AsimiladosPrincipal_Load(object sender, EventArgs e)
        {
            string bd = C.Conexion.PerformConnection().Database;
            LblUsuario.Caption = Properties.Settings.Default.Usuario.ToString().ToUpper();

            if (controller.GetAdminUsuario(Properties.Settings.Default.Usuario.ToString().ToUpper(),bd,false).Equals(true))
            {
                //accordionBitacora.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                //accordionControlElement8.Visible = true;
                accordionControlElement7.Visible = true;
            }
        }

        private void BtnCancelarCFDI_Click(object sender, EventArgs e)
        {
            CancelarCFDI cancelarCFDI = new CancelarCFDI(lblRFC.Caption, lblEmpresa.Caption);
            var frm = Application.OpenForms.OfType<CancelarCFDI>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    frm.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(270, 60);
                }
            }
            else
            {
                cancelarCFDI.Location = new Point(270, 60);
                cancelarCFDI.Size = PanelPrincipal.Size;
                cancelarCFDI.Show();
                cancelarCFDI.BringToFront();
            }
        }

        private void BtnGenPDF12_Click(object sender, EventArgs e)
        {
            GenPDF12 genPDF12 = new GenPDF12();
            var frm = Application.OpenForms.OfType<GenPDF12>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    frm.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(270, 60);
                }
            }
            else
            {
                genPDF12.Location = new Point(270, 60);
                genPDF12.Size = PanelPrincipal.Size;
                genPDF12.Show();
                genPDF12.BringToFront();
            }
        }

        private void BtnHistorico_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(splashScreenManager1);
            var frm = Application.OpenForms.OfType<Bitacora>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    frm.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(270, 60);
                }
            }
            else
            {
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption("Cargando Modulo Bitacora...");
                bitacora.Location = new Point(270, 60);
                bitacora.Size = PanelPrincipal.Size;
                bitacora.Show();
                bitacora.BringToFront();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accordionAgregaEmplUni_Click(object sender, EventArgs e)
        {
            AgregarEmpleado agregarEmpleado = new AgregarEmpleado();
            var frm = Application.OpenForms.OfType<AgregarEmpleado>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    frm.WindowState = FormWindowState.Normal;
                    //frm.Size = PanelPrincipal.Size;
                    //frm.Location = new Point(270, 60);
                }
            }
            else
            {
                agregarEmpleado.Location = new Point(270, 60);
                agregarEmpleado.Show();

                //agregarEmpleado.Size = PanelPrincipal.Size;
                //agregarEmpleado.Location = new Point(270, 60);
            }
        }

        private void accordionAgregaEmplMasiv_Click(object sender, EventArgs e)
        {
            E.Empleado empl = new E.Empleado();
            C.Controller Controlador = new C.Controller();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; //le indicamos el tipo de filtro en este caso que busque
                                                                             //solo los archivos excel

            dialog.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana

            dialog.FileName = string.Empty;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (splashScreenManager1.IsSplashFormVisible.Equals(false))
                    {
                        splashScreenManager1.ShowWaitForm();
                    }

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

                    var Empleado = new List<E.Empleado>();
                    E.Empleado[] empleado = null;
                    for (rCnt = 2; rCnt <= rw; rCnt++)
                    {
                        cont++;
                        try
                        {
                            numEmpl = (range.Cells[rCnt, "A"] as Excel.Range).Value2.ToString();
                        }
                        catch (Exception Empl)
                        {
                            numEmpl = "";
                        }
                        try
                        {
                            nombre = (range.Cells[rCnt, "B"] as Excel.Range).Value2.ToString();
                        }catch(Exception Nombre)
                        {
                            nombre = "";
                        }
                        try
                        {
                            rfc = (range.Cells[rCnt, "C"] as Excel.Range).Value2.ToString();
                        }catch(Exception RFC)
                        {
                            rfc = "";
                        }
                        try
                        {
                            curp = (range.Cells[rCnt, "D"] as Excel.Range).Value2.ToString();
                        }catch (Exception CURP)
                        {
                            curp = "";
                        }
                        try
                        {
                            peri = (range.Cells[rCnt, "E"] as Excel.Range).Value2.ToString();
                            peri = peri.ToUpper();
                        }
                        catch (Exception PERI)
                        {
                            peri = "";
                        }
                        try
                        {
                            cuenta = (range.Cells[rCnt, "F"] as Excel.Range).Value2.ToString();
                        }catch (Exception CUENTA)
                        {
                            cuenta = "";
                        }
                        try
                        {
                            clabe = (range.Cells[rCnt, "G"] as Excel.Range).Value2.ToString();
                        }catch (Exception CLABE)
                        {
                            clabe = "";
                        }
                        try
                        {
                            cve = (range.Cells[rCnt, "H"] as Excel.Range).Value2.ToString();
                        }catch (Exception CVE)
                        {
                            cve = "";
                        }
                        try
                        {
                            banco = (range.Cells[rCnt, "I"] as Excel.Range).Value2.ToString();
                        }catch (Exception BANCO)
                        {
                            banco = "";
                        }
                        try
                        {
                            empresa = (range.Cells[rCnt, "J"] as Excel.Range).Value2.ToString();
                        }catch (Exception EMPRESA)
                        {
                            empresa = "";
                        }
                        try
                        {
                            idEmpr = (range.Cells[rCnt, "K"] as Excel.Range).Value2.ToString();
                        }catch(Exception IDEMPR)
                        {
                            idEmpr = "";
                        }


                        if (peri.Equals("SEMANAL"))
                        {
                            peri = "02";
                        }
                        else if (peri.Equals("QUINCENAL"))
                        {
                            peri = "04";
                        }
                        else if (peri.Equals("MENSUAL"))
                        {
                            peri = "04";
                        }
                        else
                        {
                            peri = "99";
                        }
                        empl.NumEmpl = numEmpl;
                        empl.Nombre = nombre;
                        empl.CURP = curp;
                        empl.RFC = rfc;
                        empl.Periodicidad = peri;
                        empl.cuenta = cuenta;
                        empl.clabe_bancaria = clabe;
                        empl.banco = banco;
                        empl.cve_banco = cve;
                        empl.empresa = empresa;
                        empl.idEmpresa = idEmpr;

                        Empleado.Add(new E.Empleado
                        {
                            NumEmpl = numEmpl,
                            Nombre = nombre,
                            CURP = curp,
                            RFC = rfc,
                            Periodicidad = peri,
                            cuenta = cuenta,
                            clabe_bancaria = clabe,
                            banco = banco,
                            cve_banco = cve,
                            empresa = empresa,
                            idEmpresa = idEmpr

                        });
                        empleado = Empleado.ToArray();

                    }
                    string nombreArchivo = xlWorkBook.Name;
                    nombreArchivo = Path.GetFileNameWithoutExtension(nombreArchivo);
                    //xlWorkBook.Close(true, "Formato_Masivo_Importe_Empleados", null);
                    xlWorkBook.Close(true, nombreArchivo, null);
                    xlApp.Quit();
                    //progressPanel2.Hide();

                    Marshal.ReleaseComObject(xlWorkSheet);
                    Marshal.ReleaseComObject(xlWorkBook);
                    Marshal.ReleaseComObject(xlApp);
                    Controlador.AgregarEmpleadoMasivo(Empleado, empl, splashScreenManager1);

                }
                catch (Exception leerExcel)
                {
                    if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                    {
                        splashScreenManager1.CloseWaitForm();
                    }

                    XtraMessageBox.Show(leerExcel.Message + "\nCarga masiva empleados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
 
            }
            else
            {
                if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                {
                    splashScreenManager1.CloseWaitForm();
                }
            }
        }

        private void acoordionEditaEmpleado_Click(object sender, EventArgs e)
        {
            EditarEmpleados editarEmpleados = new EditarEmpleados();
            var frm = Application.OpenForms.OfType<EditarEmpleados>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    editarEmpleados.Size = PanelPrincipal.Size;
                    editarEmpleados.Location = new Point(270, 60);
                }
            }
            else
            {
                editarEmpleados.Size = PanelPrincipal.Size;
                editarEmpleados.Location = new Point(270, 60);
                editarEmpleados.Show();
            }
        }

        private void accordionAgregarEmpresaUnitario_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormCaption("Cargando Modulo Empresa...");
            AgregarEmpresa agregarEmpresa = new AgregarEmpresa(false, splashScreenManager1);
            var frm = Application.OpenForms.OfType<AgregarEmpresa>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(270, 60);
                }
            }
            else
            {
                agregarEmpresa.Location = new Point(270, 60);
                agregarEmpresa.Show();
                //agregarEmpresa.Size = PanelPrincipal.Size;
                //agregarEmpresa.Location = new Point(270, 60);
            }
        }

        private void accordionEditaEmpresa_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormCaption("Cargando Modulo Editar Empresa...");
            EditarEmpresa editarEmpresa = new EditarEmpresa(lblRFC.Caption, splashScreenManager1);
            var frm = Application.OpenForms.OfType<EditarEmpresa>().FirstOrDefault();
            if (frm != null)
            {
                frm.Location = new Point(270, 60);
                frm.BringToFront();

                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(270, 60);
                }
            }
            else
            {
                editarEmpresa.Location = new Point(270, 60);
                editarEmpresa.Show();
                editarEmpresa.BringToFront();

            }
        }

        private void accordionNomiAsim_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormCaption("Cargando Modulo Nómina...");
            NominaAsimilados nominaAsimilados = new NominaAsimilados(lblEmpresa.Caption, lblRFC.Caption, splashScreenManager1);

            var frm = Application.OpenForms.OfType<NominaAsimilados>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    frm.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(270, 60);
                }
            }
            else
            {
                nominaAsimilados.Location = new Point(270, 60);
                nominaAsimilados.Size = PanelPrincipal.Size;
                nominaAsimilados.ShowDialog();
                nominaAsimilados.BringToFront();
            }
        }

        private void accordionGenPDF_XML_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            var frm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                form.Location = new Point(270, 60);

                if (frm.WindowState == FormWindowState.Minimized)
                {
                    frm.WindowState = FormWindowState.Normal;
                    frm.Size = PanelPrincipal.Size;
                    frm.Location = new Point(270, 60);
                }
            }
            else
            {
                form.Size = PanelPrincipal.Size;
                form.Location = new Point(270, 60);
                form.Show();
            }
        }

        private void accordionGenPDF1_2_Click(object sender, EventArgs e)
        {
            GenPDF12 genPDF12 = new GenPDF12();
            var frm = Application.OpenForms.OfType<GenPDF12>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    frm.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(270, 60);
                }
            }
            else
            {
                genPDF12.Location = new Point(270, 60);
                genPDF12.Size = PanelPrincipal.Size;
                genPDF12.Show();
                genPDF12.BringToFront();
            }
        }

        private void accordionCambiarEmpresa_Click(object sender, EventArgs e)
        {

            if (XtraMessageBox.Show("¿Desea cambiar de empresa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
                ListaEmpresas listaEmpresas = new ListaEmpresas();
                listaEmpresas.Show();
                salida = false;
            }
            //else
            //{
            //    salida = true;
            //}
        }

        private void accordionBitacora_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormCaption("Cargando Modulo Bitacora...");
            Bitacora bitacora = new Bitacora(splashScreenManager1);
            var frm = Application.OpenForms.OfType<Bitacora>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    frm.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(270, 60);
                }
            }
            else
            {
                bitacora.Location = new Point(270, 60);
                bitacora.Size = PanelPrincipal.Size;
                bitacora.Show();
                bitacora.BringToFront();
            }
        }

        private void accordionCancelarCFDI_Click(object sender, EventArgs e)
        {
            CancelarCFDI cancelarCFDI = new CancelarCFDI(lblRFC.Caption, lblEmpresa.Caption);
            var frm = Application.OpenForms.OfType<CancelarCFDI>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    frm.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(270, 60);
                }
            }
            else
            {
                cancelarCFDI.Location = new Point(270, 60);
                cancelarCFDI.Size = PanelPrincipal.Size;
                cancelarCFDI.Show();
                cancelarCFDI.BringToFront();
            }
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            AgregarUsuario  agregarUsuario = new AgregarUsuario(false);
            var frm = Application.OpenForms.OfType<AgregarUsuario>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    frm.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(270, 60);
                }
            }
            else
            {
                agregarUsuario.Location = new Point(270, 60);
                //agregarUsuario.Size = PanelPrincipal.Size;
                agregarUsuario.Show();
                agregarUsuario.BringToFront();
            }
        }

        private void accordionControlEditaUsuario_Click(object sender, EventArgs e)
        {
            EditarUsuario editarUsuario = new EditarUsuario(false);
            var frm = Application.OpenForms.OfType<EditarUsuario>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    frm.Size = PanelPrincipal.Size;
                    frm.BringToFront();
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(270, 60);
                }
            }
            else
            {
                editarUsuario.Location = new Point(270, 60);
                //agregarUsuario.Size = PanelPrincipal.Size;
                editarUsuario.Show();
                editarUsuario.BringToFront();
            }
        }

        private void accordionControlTablasCalc_Click(object sender, EventArgs e)
        {
            TablasCalculo tablasCalculo = new TablasCalculo();
            var frm = Application.OpenForms.OfType<TablasCalculo>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    frm.Size = PanelPrincipal.Size;
                    frm.BringToFront();
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(270, 60);
                }
            }
            else
            {
                tablasCalculo.Location = new Point(270, 60);
                //agregarUsuario.Size = PanelPrincipal.Size;
                tablasCalculo.Show();
                tablasCalculo.BringToFront();
            }
        }

        private void accordionControlElemenAddClteUnit_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormCaption("Cargando modulo Alta Cliente...");
            AgregarCliente agregarCliente = new AgregarCliente(splashScreenManager1);
            var frm = Application.OpenForms.OfType<AgregarCliente>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.Location = new Point(270, 60);
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    //XtraMessageBox.Show("S")
                    frm.WindowState = FormWindowState.Normal;
                    frm.Size = PanelPrincipal.Size;
                    frm.BringToFront();
                    //agregarEmpresa.Size = PanelPrincipal.Size;
                    //agregarEmpresa.Location = new Point(270, 60);
                }
            }
            else
            {
                agregarCliente.Location = new Point(270, 60);
                //agregarUsuario.Size = PanelPrincipal.Size;
                agregarCliente.Show();
                agregarCliente.BringToFront();
            }
        }
    }
}
