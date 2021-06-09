using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M = winAsimilados.Models;
using C = winAsimilados.Controller;
using DevExpress.XtraEditors;
using System.IO;

namespace winAsimilados.Views
{
    public partial class CargarArchivoNomina : Form
    {
        #region variables
        string Archivo;
        string NombreArchivo;
        string nominaID;
        string usuarioSistema = Properties.Settings.Default.Usuario.ToString();
        string mensaje;
        string nombreArchivoOriginal;
        #endregion

        #region objetos
        M.ResumenNomina resumenNomina = new M.ResumenNomina();
        M.Archivos archivo = new M.Archivos();
        C.Controller controlador = new C.Controller();
        #endregion
        public CargarArchivoNomina(string resumenNominaID)
        {
            InitializeComponent();
            nominaID = resumenNominaID;
        }

        private void buttonEditArchivo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //openFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            //openFileDialog1.FilterIndex = 1;
            //openFileDialog1.RestoreDirectory = true;

            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    Archivo = openFileDialog1.FileName;
            //    nombreArchivoOriginal = openFileDialog1.SafeFileName;
            //    buttonEditArchivo.Text = Archivo;
            //}
            xtraOpenFileDialog1.Title = "Selecciona Archivo a Cargar";
            xtraOpenFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            xtraOpenFileDialog1.FileName = "";
            xtraOpenFileDialog1.FilterIndex = 1;
            xtraOpenFileDialog1.RestoreDirectory = true;

            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Archivo = xtraOpenFileDialog1.FileName;
                nombreArchivoOriginal = xtraOpenFileDialog1.SafeFileName;
                buttonEditArchivo.Text = Archivo;
            }
        }

        private void CargarArchivoNomina_Load(object sender, EventArgs e)
        {
            resumenNomina = controlador.GetResumenNomina(nominaID);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreArchivo.Text.Equals(""))
                {
                     mensaje = "Por favor, ingrese nombre del archivo.";
                    XtraMessageBox.Show(mensaje, "Cargar Archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    NombreArchivo = txtNombreArchivo.Text;
                }
                if (buttonEditArchivo.Text.Equals(""))
                {
                     mensaje = "Por favor, cargue un archivo.";
                    XtraMessageBox.Show(mensaje, "Cargar Archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                byte[] file = null;
                //Stream stream = openFileDialog1.OpenFile();
                Stream stream = OpenFile(Archivo);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);
                    file = memoryStream.ToArray();
                }

                using (Models.AsimiladosEntitiesArchivos ar = new Models.AsimiladosEntitiesArchivos())
                {
                    Models.Archivos archivos = new Models.Archivos();
                    archivos.archivoPath = nombreArchivoOriginal;
                    archivos.archivoNombre = NombreArchivo;
                    archivos.archivoCargado = file;
                    archivos.archivoFechaCarga = DateTime.Now;
                    archivos.archivoUsuarioCarga = usuarioSistema;
                    archivos.archivoIDCliente = resumenNomina.ResumenNominaIDCliente;
                    archivos.archivoCliente = resumenNomina.ResumenNominaCliente;
                    archivos.archivoIDEmpresa = resumenNomina.ResumenNominaIDEmpresaPago;
                    archivos.archivoPeriodo = resumenNomina.ResumenNominaPeriodo;
                    archivos.archivoNominaEmpresaID = resumenNomina.ResumenNominaNominaEmpresaID;
                    archivos.archivoEmpresa = resumenNomina.ResumenNominaEmpresaPago;
                    string path = @"C:\";
                    string folder = path + @"AsimiladosDescargas\" + archivos.archivoCliente + "\\" + archivos.archivoEmpresa + "\\" + archivos.archivoPeriodo + "\\";
                    string fullFilePath = folder + archivos.archivoPath;
                    archivos.archivosURL = fullFilePath;
                    ar.Archivos.Add(archivos);
                    ar.SaveChanges();
                }
                //archivo.archivoPath = nombreArchivoOriginal;
                //archivo.archivoNombre = NombreArchivo;
                //archivo.archivoCargado = file;
                //archivo.archivoUsuarioCarga = usuarioSistema;
                //archivo.archivoIDCliente = resumenNomina.ResumenNominaIDCliente;
                //archivo.archivoCliente = resumenNomina.ResumenNominaCliente;
                //archivo.archivoIDEmpresa = resumenNomina.ResumenNominaIDEmpresaPago;
                //archivo.archivoPeriodo = resumenNomina.ResumenNominaPeriodo;
                //archivo.archivoNominaEmpresaID = resumenNomina.ResumenNominaNominaEmpresaID;
                //archivo.archivoEmpresa = resumenNomina.ResumenNominaEmpresaPago;
                //controlador.CargaArchivoBD(archivo);

                mensaje = string.Concat("¡Archivo Cargado con Éxito!");
                XtraMessageBox.Show(mensaje, "Carga de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombreArchivo.Text = "";
                buttonEditArchivo.Text = "";
                xtraOpenFileDialog1.Reset();



            }
            catch(Exception btnCargar)
            {
                 mensaje = string.Concat("Hubo un error al intentar cargar el archivo en la BD:", "\n", btnCargar.Message);
                XtraMessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Stream OpenFile(string fileName)
        {
            FileStream stream = null;
            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            }
            finally
            {
                //...  
            }
            return stream;
        }
    }
}
