using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C = winAsimilados.Controller;
using E = winAsimilados.Entities;

namespace winAsimilados.Views
{
    public partial class EditarEmpresa : Form
    {
        SplashScreenManager splash;
        E.Parametros parametros = new E.Parametros();
        C.Controller controlador = new C.Controller();
        E.Empresa Empresa = new E.Empresa();
        string RFCEmpr;
        bool Asimilados = true, FileDialog = false;
        bool ValRegPat = false;
        string bd = C.Conexion.PerformConnection().Database;
        string nombreEmpresa, RFC;
        string calle, municipio, colonia, regimen, recursos, nomina, numInt, numExt, RegPat, puesto;
        string Estado, CodPost;
        string RutaCer, RutaKey, Pass;
        string cuenta;
        string ArchivoCer, ArchivoKey;
        string NombreArchivoCer, NombreArchivoKey;
        string usuarioSistema = Properties.Settings.Default.Usuario.ToString();

        private void TxtEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            TxtEmpresa.Text = TxtEmpresa.Text.ToUpper();
            nombreEmpresa = TxtEmpresa.Text;
        }

        private void TxtRegPat_EditValueChanged(object sender, EventArgs e)
        {
            TxtRegPat.Text = TxtRegPat.Text.ToUpper();
            RegPat = TxtRegPat.Text;
        }

        private void TxtCalle_EditValueChanged(object sender, EventArgs e)
        {
            TxtCalle.Text = TxtCalle.Text.ToUpper();
            calle = TxtCalle.Text;
        }

        private void TxtRFC_EditValueChanged(object sender, EventArgs e)
        {
            TxtRFC.Text = TxtRFC.Text.ToUpper();
            RFC = TxtRFC.Text;
        }

        private void LookUpRegFis_EditValueChanged(object sender, EventArgs e)
        {
            regimen = LookUpRegFis.EditValue.ToString();
        }

        private void LookUpRecu_EditValueChanged(object sender, EventArgs e)
        {
            recursos = LookUpRecu.EditValue.ToString();
        }

        private void LookUpPuesto_EditValueChanged(object sender, EventArgs e)
        {
            puesto = LookUpPuesto.EditValue.ToString();
        }

        private void LookUpNomi_EditValueChanged(object sender, EventArgs e)
        {
            nomina = LookUpNomi.EditValue.ToString();
        }

        private void TxtCer_EditValueChanged(object sender, EventArgs e)
        {
            RutaCer = TxtCer.EditValue.ToString();
        }

        private void TxtKey_EditValueChanged(object sender, EventArgs e)
        {
            RutaKey = TxtKey.EditValue.ToString();
        }

        private void TxtPassKey_EditValueChanged(object sender, EventArgs e)
        {
            Pass = TxtPassKey.EditValue.ToString();
        }

        private void TxtAsunto_EditValueChanged(object sender, EventArgs e)
        {
            parametros.ASUNTO_CERTIFICADO = TxtAsunto.EditValue.ToString();
        }

        private void TxtSerie_EditValueChanged(object sender, EventArgs e)
        {
            parametros.NUMERO_CERTIFICADO = TxtSerie.EditValue.ToString();
        }

        private void TxtFecIniVig_EditValueChanged(object sender, EventArgs e)
        {
            parametros.FECHA_INICIO_CERTIFICADO = Convert.ToDateTime(TxtFecIniVig.Text);
        }

        private void TxtFevFinVig_EditValueChanged(object sender, EventArgs e)
        {
            parametros.FECHA_VENCIMIENTO_CERTIFICADO = Convert.ToDateTime(TxtFevFinVig.Text);
        }

        private void TxtCuenta_EditValueChanged(object sender, EventArgs e)
        {
            cuenta = TxtCuenta.Text;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DesactivarCampos();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string newDB = bd;
            nombreEmpresa = TxtEmpresa.Text.ToUpper();
            RFC = TxtRFC.Text.ToUpper();
            numInt = TxtNumInt.Text;
            numExt = TxtNumExt.Text;
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string folder = path + @"Certificados\" + nombreEmpresa.Trim() + @"\";
            string fullFilePathCer = folder + NombreArchivoCer;
            string fullFilePathKey = folder + NombreArchivoKey;
            #region ValidacionCampos

            if (TxtCorreo.Text.Equals(""))
            {
                XtraMessageBox.Show("El campo Correo no puede estar vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                parametros.correo_cliente = TxtCorreo.Text;
            }
            if (nombreEmpresa == "")
            {
                XtraMessageBox.Show("El campo Nombre no puede estar vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Empresa.empresa = nombreEmpresa;
                parametros.NombreEmpresa = nombreEmpresa;
            }

            if (RFC == "")
            {
                XtraMessageBox.Show("El campo RFC no puede estar vacio.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Empresa.RFC = RFC;
                parametros.RFC = RFC;
            }
            if (Asimilados == true)
            {
                ValRegPat = true;
                RegPat = "";
                parametros.RegistroPatronal = RegPat;
            }
            else
            {
                ValRegPat = true;
                if (TxtRegPat.Text == "" || TxtRegPat == null)
                {
                    XtraMessageBox.Show("El campo Registro Patronal no puede estar vacío.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    parametros.RegistroPatronal = RegPat;
                }
            }
            if (LookUpRegFis.Text == "Seleccione")
            {
                XtraMessageBox.Show("Campo Regimen Fiscal vacío, por favor seleccione una opción.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                parametros.REGIMEN = regimen;
            }
            if (LookUpRecu.Text == "Seleccione")
            {
                XtraMessageBox.Show("Campo Origen Recursos vacío, por favor seleccione una opción", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                parametros.ORIGEN_RECURSOS = recursos;
            }
            if (LookUpPuesto.Text == "Seleccione")
            {
                XtraMessageBox.Show("Campo Riesgo Puesto vacío, por favor seleccione una opción", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                parametros.RIESGO_PUESTO = puesto;
            }
            if (LookUpNomi.Text == "Seleccione")
            {
                XtraMessageBox.Show("Campo Tipo Nómina vacío, por favor seleccione una opción", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                parametros.TIPO_NOMINA = nomina;
            }
            if (TxtCalle.Text == "" || TxtCalle.Text == null)
            {
                XtraMessageBox.Show("El campo Calle no puede estar vacío.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                parametros.Calle = calle;
            }
            if (numInt == "" || numInt == null)
            {
                numInt = "S/N";
                parametros.NUM_INT = numInt;
            }
            else
            {
                parametros.NUM_INT = numInt;
            }
            if (numExt == "" || numExt == null)
            {
                numExt = "S/N";
                parametros.NUM_EXT = numExt;
            }
            else
            {
                parametros.NUM_EXT = numExt;
            }
            if (LookUpEst.Text == "Seleccione")
            {
                XtraMessageBox.Show("Campo Estado vacio, por favor seleccione una opcion.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                parametros.ESTADO = Estado;
            }
            if (LookUpMuni.Text == "Seleccione")
            {
                XtraMessageBox.Show("Campo Municipio vacío, por facor seleccione una opción.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                parametros.MUNICIPIO = municipio;
            }
            if (TxtCP.Text == "" || TxtCP.Text == null)
            {
                XtraMessageBox.Show("El campo Código Postal no puede estar vacío.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                parametros.CODIGO_POSTAL = CodPost;
            }
            if (LookUpCol.Text == "Seleccione")
            {
                XtraMessageBox.Show("Campo Colonia vacío, por favor seleccione una opción.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                parametros.COLONIA = colonia;
            }
            if (TxtCer.Text == "" || TxtCer.Text == null)
            {
                XtraMessageBox.Show("Por favor ingrese el archivo CER", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //parametros.ARCHIVO_CER = RutaCer;
                parametros.ARCHIVO_CER = fullFilePathCer;
            }
            if (TxtKey.Text == "" || TxtKey == null)
            {
                XtraMessageBox.Show("Por favor ingrese el archivo KEY", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //parametros.ARCHIVO_KEY = RutaKey;
                parametros.ARCHIVO_KEY = fullFilePathKey;
            }
            if (TxtPassKey.Text == "" || TxtPassKey.Text == null)
            {
                XtraMessageBox.Show("Por favor ingrese la contraseña del archivo Key", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                parametros.CLAVE_CERTIFICADO = TxtPassKey.Text;
            }
            if (cuenta.Equals(""))
            {
                XtraMessageBox.Show("Campo Cuenta Bancaría no puede estar vacio.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cuenta.Length < 10)
            {
                XtraMessageBox.Show("Campo Cuenta Bancaría debe tener al menos 10 dígitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cuenta.Length > 10)
            {
                XtraMessageBox.Show("Campo Cuenta Bancaría debe tener máximo 10 dígitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                parametros.cuentaOrigen = cuenta;
            }
            #endregion
            if (Empresa.empresa != null && Empresa.RFC != null && parametros.RegistroPatronal != null && parametros.REGIMEN != null && parametros.ORIGEN_RECURSOS != null
            && parametros.RIESGO_PUESTO != null && parametros.TIPO_NOMINA != null && parametros.Calle != null && parametros.ESTADO != null && parametros.MUNICIPIO != null
            && parametros.CODIGO_POSTAL != null && parametros.COLONIA != null && parametros.ARCHIVO_CER != null && parametros.ARCHIVO_KEY != null
            && parametros.CLAVE_CERTIFICADO != null && ValRegPat.Equals(true) && parametros.cuentaOrigen != null)
            {
                DialogResult result = XtraMessageBox.Show("¿Desea actualizar la información?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result.Equals(DialogResult.Yes))
                {
                    if(controlador.EditaEmpresa(parametros, RFCEmpr, bd).Equals(true))
                    {
                        this.UpdateCerKey();
                        DesactivarCampos();
                        //string mensaje = "¡Información Actualizada con Éxito!";
                        //XtraMessageBox.Show(mensaje, "Editar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string mensaje = "¡Error al Actualizar Información!";
                        XtraMessageBox.Show(mensaje, "Editar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DesactivarCampos();
                    }
                }
                else
                {
                    DesactivarCampos();
                }
            }
            else
            {
                XtraMessageBox.Show("Error al validar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TxtCer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (FileDialog.Equals(true))
            {
                //XtraMessageBox.Show("Prueba");
                xtraOpenFileDialog1.Title = "Selecciona Archivo CER";
                xtraOpenFileDialog1.Filter = "Archivos Certificado de Seguridad (*.cer;*)|*.cer";
                xtraOpenFileDialog1.FileName = "";
                if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    RutaCer = xtraOpenFileDialog1.FileName;
                    //XtraMessageBox.Show(RutaCer);
                    TxtCer.Text = RutaCer;
                    X509Certificate2 certificate = new X509Certificate2(RutaCer);
                    if (certificate != null)
                    {
                        TxtSerie.Text = Encoding.Default.GetString(certificate.GetSerialNumber());
                        TxtFecIniVig.Text = certificate.GetEffectiveDateString();
                        TxtFevFinVig.Text = certificate.GetExpirationDateString();
                        TxtAsunto.Text = certificate.SubjectName.Name;

                        parametros.NUMERO_CERTIFICADO = TxtSerie.Text;
                        parametros.FECHA_INICIO_CERTIFICADO = Convert.ToDateTime(TxtFecIniVig.Text);
                        parametros.FECHA_VENCIMIENTO_CERTIFICADO = Convert.ToDateTime(TxtFevFinVig.Text);
                        parametros.ASUNTO_CERTIFICADO = TxtAsunto.Text;
                        ArchivoCer = xtraOpenFileDialog1.FileName;
                        NombreArchivoCer = xtraOpenFileDialog1.SafeFileName;
                    }
                }
            }
        }
        private void UpdateCerKey()
        {
            try
            {
                byte[] fileCer = null;
                byte[] fileKey = null;

                Stream streamCer = OpenFile(ArchivoCer);
                using (MemoryStream memoryStreamCer = new MemoryStream())
                {
                    streamCer.CopyTo(memoryStreamCer);
                    fileCer = memoryStreamCer.ToArray();
                }
                Stream streamKey = OpenFile(ArchivoKey);
                using (MemoryStream memoryStreamKey = new MemoryStream())
                {
                    streamKey.CopyTo(memoryStreamKey);
                    fileKey = memoryStreamKey.ToArray();
                }
                int IDCerKey = controlador.GetCerKeyID(RFCEmpr);
                using (Models.AsimiladosEntitiesCertificados cr = new Models.AsimiladosEntitiesCertificados())
                {
                    var certificado = cr.CertificadosDigitales.FirstOrDefault(b => b.cerID ==IDCerKey);

                    if (certificado != null)
                    {
                        string path = AppDomain.CurrentDomain.BaseDirectory;
                        string folder = path + @"Certificados\" + @"\" + nombreEmpresa + @"\";
                        string fullFilePathCer = folder + NombreArchivoCer;
                        string fullFilePathKey = folder + NombreArchivoKey;

                        if (File.Exists(certificado.cerPath))
                        {
                            File.Delete(certificado.cerPath);
                        }
                        if (File.Exists(certificado.cerKeyPath))
                        {
                            File.Delete(certificado.cerKeyPath);
                        }
                        certificado.cerNombre = NombreArchivoCer;
                        certificado.cerNum = parametros.NUMERO_CERTIFICADO;
                        certificado.cerFechaVencimiento = Convert.ToDateTime(parametros.FECHA_VENCIMIENTO_CERTIFICADO);
                        certificado.cerAsunto = parametros.ASUNTO_CERTIFICADO;
                        certificado.cerPath = fullFilePathCer;
                        certificado.cerArchivo = fileCer;
                        certificado.cerKeyNombre = NombreArchivoKey;
                        certificado.cerKeyArchivo = fileKey;
                        certificado.cerKeyPath = fullFilePathKey;
                        certificado.cerNombreEmpresa = parametros.NombreEmpresa;
                        certificado.cerRFCEmpresa = parametros.RFC;
                        certificado.cerNominaEmpresaID = controlador.GetIDEmpresa(parametros.RFC);
                        certificado.cerFechaCarga = DateTime.Now;
                        certificado.cerUsuarioCarga = usuarioSistema;
                        cr.SaveChanges();
                        controlador.GenerarCerKey(certificado.cerRFCEmpresa);
                    }
                    else
                    {
                        Models.CertificadosDigitales cer = new Models.CertificadosDigitales();
                        string path = AppDomain.CurrentDomain.BaseDirectory;
                        string folder = path + @"Certificados\" + nombreEmpresa.Trim() + @"\";
                        string fullFilePathCer = folder + NombreArchivoCer;
                        string fullFilePathKey = folder + NombreArchivoKey;
                        parametros.ARCHIVO_CER = fullFilePathCer;
                        parametros.ARCHIVO_KEY = fullFilePathKey;
                        cer.cerNombre = NombreArchivoCer;
                        cer.cerNum = parametros.NUMERO_CERTIFICADO;
                        cer.cerFechaVencimiento = Convert.ToDateTime(parametros.FECHA_VENCIMIENTO_CERTIFICADO);
                        cer.cerAsunto = parametros.ASUNTO_CERTIFICADO;
                        cer.cerPath = fullFilePathCer;
                        cer.cerArchivo = fileCer;
                        cer.cerKeyNombre = NombreArchivoKey;
                        cer.cerKeyArchivo = fileKey;
                        cer.cerKeyPath = fullFilePathKey;
                        cer.cerNombreEmpresa = parametros.NombreEmpresa;
                        cer.cerRFCEmpresa = parametros.RFC;
                        cer.cerNominaEmpresaID = controlador.GetIDEmpresa(parametros.RFC);
                        cer.cerFechaCarga = DateTime.Now;
                        cer.cerUsuarioCarga = usuarioSistema;

                        cr.CertificadosDigitales.Add(cer);
                        cr.SaveChanges();
                        controlador.GenerarCerKey(parametros.RFC);
                    }
                }
            }
            catch (Exception ec)
            {
                throw;
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
        private void TxtKey_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (FileDialog.Equals(true))
            {
                //XtraMessageBox.Show("Prueba");
                xtraOpenFileDialog2.Title = "Selecciona Archivo KEY";
                xtraOpenFileDialog2.Filter = "Archivos KEY (*.key;*)|*.key";
                if (xtraOpenFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    RutaKey = xtraOpenFileDialog2.FileName;
                    //XtraMessageBox.Show(RutaKey);
                    TxtKey.Text = RutaKey;
                    ArchivoKey = xtraOpenFileDialog2.FileName;
                    NombreArchivoKey = xtraOpenFileDialog2.SafeFileName;
                }
            }
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DialogResult  result = XtraMessageBox.Show("¿Desea editar la configuración de la empresa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result.Equals(DialogResult.Yes))
            {
                ActivarCampos();
            }
        }

        private void LookUpCol_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                colonia = LookUpCol.EditValue.ToString();
            }
            catch (Exception ex)
            {

            }

        }

        private void TxtCP_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var CP = new List<E.Colonia>();
                CodPost = (sender as TextEdit).EditValue.ToString();

                CP = controlador.Colonias(bd, CodPost, CP);

                LookUpCol.Properties.DataSource = CP;
                LookUpCol.Properties.KeyMember = "Nombre";
                LookUpCol.Properties.DisplayMember = "Nombre";
            }
            catch(Exception exe)
            {

            }
        }

        private void LookUpMuni_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                municipio = LookUpMuni.EditValue.ToString();
            }
            catch (Exception ex)
            {

            }
        }


        public EditarEmpresa(string RFC, SplashScreenManager splashScreenManager)
        {
            RFCEmpr = RFC;
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
        }

        private void EditarEmpresa_Load(object sender, EventArgs e)
        {
            try
            {
                splash.SetWaitFormCaption("Cargando información Empresa..");
                layoutControlGroup8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                parametros = controlador.GetParametros(RFCEmpr);
                //XtraMessageBox.Show(parametros.REGIMEN);
                TxtEmpresa.Text = parametros.NombreEmpresa;
                TxtRFC.Text = parametros.RFC;
                TxtRegPat.Text = parametros.RegistroPatronal;
                if (parametros.RegistroPatronal.Equals(null) || parametros.RegistroPatronal.Equals(""))
                {
                    ChAsimilados.Checked = true;
                    Asimilados = true;
                    layoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                }
                else
                {
                    Asimilados = false;
                    layoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }
                LookUpRegFis.Text = parametros.DescripcionRegimen;
                LookUpRegFis.ReadOnly = true;
                if (parametros.ORIGEN_RECURSOS.Equals(null) || parametros.ORIGEN_RECURSOS.Equals(""))
                {
                    recursos = controlador.GetTipoRecu(RFCEmpr);
                    if (recursos.Equals("") || recursos.Equals(null))
                    {
                        LookUpRecu.Text = "NO APLICA";
                    }
                    else
                    {
                        LookUpRecu.Text = recursos;
                    }
                }else
                    {
                        recursos = controlador.GetTipoRecu(RFCEmpr);
                        LookUpRecu.Text = recursos;
                    }
                //LookUpRecu.Text = parametros.ORIGEN_RECURSOS;
                LookUpRecu.ReadOnly = true;
                LookUpPuesto.Text = parametros.DescripcionPuesto;
                LookUpPuesto.ReadOnly = true;
                LookUpNomi.Text = parametros.DescripcionNomina;
                LookUpNomi.ReadOnly = true;
                TxtCalle.Text = parametros.Calle;
                TxtNumInt.Text = parametros.NUM_INT;
                TxtNumExt.Text = parametros.NUM_EXT;
                LookUpEst.Text = parametros.ESTADO;
                LookUpEst.ReadOnly = true;
                LookUpMuni.Text = parametros.MUNICIPIO;
                LookUpMuni.ReadOnly = true;
                TxtCP.Text = parametros.CODIGO_POSTAL;
                TxtCP.ReadOnly = true;
                LookUpCol.Text = parametros.COLONIA;
                LookUpCol.ReadOnly = true;
                TxtCer.Text = parametros.ARCHIVO_CER;
                TxtKey.Text = parametros.ARCHIVO_KEY;
                TxtPassKey.Text = parametros.CLAVE_CERTIFICADO;
                TxtAsunto.Text = parametros.ASUNTO_CERTIFICADO;
                TxtSerie.Text = parametros.NUMERO_CERTIFICADO;
                TxtFecIniVig.Text = parametros.FECHA_INICIO_CERTIFICADO.ToString("dd/MM/yyyy");
                TxtFevFinVig.Text = parametros.FECHA_VENCIMIENTO_CERTIFICADO.ToString("dd/MM/yyyy");
                TxtCuenta.Text = parametros.cuentaOrigen;
                TxtCuenta.ReadOnly = true;
                TxtCorreo.Text = parametros.correo_cliente;                
                splash.CloseWaitForm();
            }
            catch (Exception ex)
            {
                if (splash.IsSplashFormVisible.Equals(true))
                {
                    splash.CloseWaitForm();
                }
                XtraMessageBox.Show(ex.Message + "Error Componente EditarEmpresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActivarCampos()
        {
            FileDialog = true;
            ChMostrar.Enabled = true;
            ChAsimilados.Enabled = true;
            TxtEmpresa.ReadOnly = false;
            TxtRFC.ReadOnly = false;
            if (Asimilados.Equals(false))
            {
                TxtRegPat.ReadOnly = false;
            }
            else
            {
                TxtRegPat.ReadOnly = true;
            }
            LookUpRegFis.ReadOnly = false;
            LookUpRecu.ReadOnly = false;
            LookUpPuesto.ReadOnly = false;
            LookUpNomi.ReadOnly = false;
            TxtCalle.ReadOnly = false;
            TxtNumInt.ReadOnly = false;
            TxtNumExt.ReadOnly = false;
            LookUpEst.ReadOnly = false;
            LookUpMuni.ReadOnly = false;
            TxtCP.ReadOnly = false;
            LookUpCol.ReadOnly = false;
            TxtPassKey.ReadOnly = false;
            TxtCuenta.ReadOnly = false;
            layoutControlGroup8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            TxtCorreo.ReadOnly = false;
        }

        private void DesactivarCampos()
        {
            FileDialog = false;
            ChMostrar.Enabled= false;
            ChAsimilados.Enabled = false;
            parametros = controlador.GetParametros(RFCEmpr);
            TxtEmpresa.Text = parametros.NombreEmpresa;
            TxtRFC.Text = parametros.RFC;
            TxtRegPat.Text = parametros.RegistroPatronal;

            if (Asimilados.Equals(true))
            {
                TxtRegPat.ReadOnly = true;
            }
            else
            {
                TxtRegPat.ReadOnly = true;
            }
            LookUpRegFis.Text = parametros.DescripcionRegimen;
            LookUpRecu.Text = parametros.DescripcionRecursos;
            LookUpPuesto.Text = parametros.DescripcionPuesto;
            LookUpNomi.Text = parametros.DescripcionNomina;
            TxtCalle.Text = parametros.Calle;
            TxtNumInt.Text = parametros.NUM_INT;
            TxtNumExt.Text = parametros.NUM_EXT;
            LookUpEst.Text = parametros.ESTADO;
            LookUpMuni.Text = parametros.MUNICIPIO;
            TxtCP.Text = parametros.CODIGO_POSTAL;
            LookUpCol.Text = parametros.COLONIA;
            TxtCer.Text = parametros.ARCHIVO_CER;
            TxtKey.Text = parametros.ARCHIVO_KEY;
            TxtPassKey.Text = parametros.CLAVE_CERTIFICADO;
            TxtAsunto.Text = parametros.ASUNTO_CERTIFICADO;
            TxtSerie.Text = parametros.NUMERO_CERTIFICADO;
            TxtFecIniVig.Text = parametros.FECHA_INICIO_CERTIFICADO.ToString("dd/MM/yyyy");
            TxtFevFinVig.Text = parametros.FECHA_VENCIMIENTO_CERTIFICADO.ToString("dd/MM/yyyy");
            TxtEmpresa.ReadOnly = true;
            TxtRFC.ReadOnly = true;
            LookUpRegFis.ReadOnly = true;
            LookUpRecu.ReadOnly = true;
            LookUpPuesto.ReadOnly = true;
            LookUpNomi.ReadOnly = true;
            TxtCalle.ReadOnly = true;
            TxtNumInt.ReadOnly = true;
            TxtNumExt.ReadOnly = true;
            LookUpEst.ReadOnly = true;
            LookUpMuni.ReadOnly = true;
            TxtCP.ReadOnly = true;
            LookUpCol.ReadOnly = true;
            TxtPassKey.ReadOnly = true;
            TxtCuenta.ReadOnly = true;
            layoutControlGroup8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            TxtCorreo.ReadOnly = true;
        }
        private void ChMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChMostrar.Checked.Equals(true))
            {
                TxtPassKey.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassKey.Properties.UseSystemPasswordChar = true;
            }
        }

        private void LookUpEst_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var municipios = new List<E.Municipio>();
                //E.Municipio[] Muni = null;
                //XtraMessageBox.Show("LookUpEdit EditValue = " + (sender as LookUpEdit).EditValue + "\nBD:" + bd);
                Estado = LookUpEst.EditValue.ToString();
                municipios = controlador.Municipios(bd, Estado, municipios);

                LookUpMuni.Properties.DataSource = municipios;
                LookUpMuni.Properties.KeyMember = "Nombre";
                LookUpMuni.Properties.DisplayMember = "Nombre";
            }
            catch (Exception exc)
            {
                //XtraMessageBox.Show(exc.Message);
            }
        }
    }
}
