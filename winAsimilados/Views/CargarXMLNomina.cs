using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using C = winAsimilados.Controller;
using E = winAsimilados.Entities;
using M = winAsimilados.Models;

namespace winAsimilados.Views
{
    public partial class CargarXMLNomina : Form
    {
        #region variables
        string emisor, rfcEmisor, receptor, rfcReceptor, sello, selloSAT, UUID, XML, folio, numEmpl, periPago,fecPago, fecIni, fecFin, IDClient, cliente, IDEmpresa, empresa, periodo, fecPagoRuta;
        string[] arraySello, listaXML;
        string usuarioSistema = Properties.Settings.Default.Usuario.ToString();
        decimal subTotal, descuento, total;
        string EmpresaID = Properties.Settings.Default["EmpresaNominaID"].ToString();
        string ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(ip => ip.AddressFamily.ToString().ToUpper().Equals("INTERNETWORK")).FirstOrDefault().ToString();
        string pathArchivoXML = null;
        string pathXml = @"C:\XML\";
        #endregion

        #region objetos
        XmlDocument doc = new XmlDocument();
        List<E.FolioXML> listaFolioXML = new List<E.FolioXML>();
        List<M.Nomina> ListaNomina = new List< M.Nomina>();
        List<E.BitacoraXML> listaBitacora = new List<E.BitacoraXML>();
        C.Controller controlador = new C.Controller();
        #endregion
        public CargarXMLNomina()
        {
            InitializeComponent();
            sqlDataSource1.Fill();
        }

        private void btnCargarXML_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                xtraOpenFileDialog1.Title = "Selecciona Archivo a Cargar";
                xtraOpenFileDialog1.Filter = "Archivos XML(*.xml) | *.xml";
                xtraOpenFileDialog1.FileName = "";
                xtraOpenFileDialog1.FilterIndex = 1;
                xtraOpenFileDialog1.DefaultExt = "xml";
                xtraOpenFileDialog1.RestoreDirectory = true;

                if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (!String.Equals(Path.GetExtension(xtraOpenFileDialog1.FileName),
                    ".xml",
                    StringComparison.OrdinalIgnoreCase))
                    {
                        string mensaje = string.Concat("El tipo de archivo seleccionado no es soportado por el sistema. Debe seleccionar un archivo XML. Tipo de archivo invalido.");
                        XtraMessageBox.Show(mensaje, "Cargar XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        btnCargarXML.Text = xtraOpenFileDialog1.FileName;
                        listaXML = xtraOpenFileDialog1.FileNames;
                    }
                }
            }
            catch (Exception btnCargarXML)
            {
                string mensaje = "Error al intentar cargar XML" + "\n" + btnCargarXML.Message;
                XtraMessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarInfoXML_Click(object sender, EventArgs e)
        {
            try
            {
                if (lookUpEmpresa.Text.Equals("") || lookUpCliente.Text.Equals("") || btnCargarInfoXML.Text.Equals(""))
                {
                    string mensaje = "Por favor, complete los campos.";
                    XtraMessageBox.Show(mensaje, "Cargar XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    IDEmpresa = lookUpEmpresa.EditValue.ToString();
                    empresa = lookUpEmpresa.Text;
                    IDClient = lookUpCliente.EditValue.ToString();
                    cliente = lookUpCliente.Text;
                    listaBitacora.Clear();
                    listaFolioXML.Clear();
                    ListaNomina.Clear();
                }

                foreach (var xml in listaXML)
                {
                    doc.Load(xml.ToString());
                    XML = doc.InnerXml;
                    foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                    {
                        if (node.LocalName.Equals("Emisor"))
                        {
                            emisor = node.Attributes[@"Nombre"].Value;
                            rfcEmisor = node.Attributes[@"Rfc"].Value;
                        }
                        else if (node.LocalName.Equals("Receptor"))
                        {
                            receptor = node.Attributes[@"Nombre"].Value;
                            rfcReceptor = node.Attributes[@"Rfc"].Value;
                        }else if (node.LocalName.Equals("Complemento"))
                        {
                            foreach (XmlAttribute attribcompFec in node.FirstChild.Attributes)
                            {
                                if (attribcompFec.LocalName.Equals("FechaPago"))
                                {
                                    fecPago = attribcompFec.Value;
                                }else if (attribcompFec.LocalName.Equals("FechaInicialPago"))
                                {
                                    fecIni = attribcompFec.Value;
                                }else if (attribcompFec.LocalName.Equals("FechaFinalPago"))
                                {
                                    fecFin = attribcompFec.Value;
                                }                             
                            }
                            foreach (XmlNode nodeComp in node.ChildNodes)
                            {
                                if (nodeComp.LocalName.Equals("Nomina"))
                                {
                                    foreach (XmlNode nodeNomina in nodeComp.ChildNodes)
                                    {
                                        if (nodeNomina.LocalName.Equals("Receptor"))
                                        {
                                            numEmpl = nodeNomina.Attributes["NumEmpleado"].Value;
                                            periPago = nodeNomina.Attributes["PeriodicidadPago"].Value;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    foreach (XmlAttribute attributeTimbre in doc.DocumentElement.LastChild.LastChild.Attributes)
                    {
                        if (attributeTimbre.LocalName.Equals("UUID"))
                        {
                            UUID = attributeTimbre.Value;
                        }else if (attributeTimbre.LocalName.Equals("SelloCFD"))
                        {
                            selloSAT = attributeTimbre.Value;
                        }                        
                    }
                    foreach (XmlAttribute attribute in doc.DocumentElement.Attributes)
                    {
                        if (attribute.LocalName.Equals("Folio"))
                        {
                            folio = attribute.Value;
                        }
                        if (attribute.LocalName.Equals("Sello"))
                        {
                            sello = attribute.Value;
                        }
                        else if (attribute.LocalName.Equals("SubTotal"))
                        {
                            subTotal = Convert.ToDecimal(attribute.Value);
                        }
                        else if (attribute.LocalName.Equals("Descuento"))
                        {
                            descuento = Convert.ToDecimal(attribute.Value);
                        }
                        else if (attribute.LocalName.Equals("Total"))
                        {
                            total = Convert.ToDecimal(attribute.Value);
                        }
                    }
                    int numFolio = Convert.ToInt32(folio);
                    if (numFolio < 10)
                    {
                        folio = string.Concat("FDP-000", folio);
                    }
                    else if (numFolio > 10)
                    {
                        folio = string.Concat("FDP-00", folio);
                    }else if (numFolio > 99)
                    {
                        folio = string.Concat("FDP-0", folio);
                    }else if (numFolio > 999)
                    {
                        folio = string.Concat("FDP-", folio);
                    }
                    string fecha = DateTime.Now.ToString("dd/MM/yyyy");
                    DateTime fechaSistema = DateTime.Parse(fecha.Trim());
                    DateTime fechaApliPeri = DateTime.Parse(fecPago.Trim());
                    DateTime fechaInPer = DateTime.Parse(fecIni.Trim());
                    DateTime fechaFiPer = DateTime.Parse(fecFin.Trim());
                    CultureInfo cul = CultureInfo.CurrentCulture;
                    int numSemana = cul.Calendar.GetWeekOfYear(fechaSistema, CalendarWeekRule.FirstDay,
                     DayOfWeek.Monday);
                    string anio = cul.Calendar.GetYear(fechaInPer).ToString();
                    string mes = cul.Calendar.GetMonth(fechaInPer).ToString();
                    int dia = cul.Calendar.GetDayOfMonth(fechaFiPer);
                    int contPeriodo = controlador.ObtieneContPeriodoNominaXML(EmpresaID, mes, IDClient, IDEmpresa);
                    contPeriodo++;
                    if (Convert.ToInt32(mes) < 10)
                    {
                        if (contPeriodo < 10)
                        {
                            periodo = Convert.ToString(anio + "0" + mes + "00" + contPeriodo.ToString());
                        }
                        else
                        {
                            periodo = Convert.ToString(anio + "0" + mes + "0" + contPeriodo.ToString());
                        }

                    }
                    else
                    {
                        if (contPeriodo < 10)
                        {
                            periodo = Convert.ToString(anio + "0" + mes + "00" + contPeriodo.ToString());
                        }
                        else
                        {
                            periodo = Convert.ToString(anio + "0" + mes + "0" + contPeriodo.ToString());
                        }
                    }
                    fecPagoRuta = Convert.ToDateTime(fecPago).ToString("dd-MM-yyyy");
                    pathArchivoXML = Path.Combine(pathXml + fecPago + @"\");
                    //if (destino.Equals("Cliente"))
                    //{
                    //    pathArchivoXML = Path.Combine(pathXml + fecPago + hora + "_Recibos" + @"\");
                    //    pathCorreo = pathArchivoXML;
                    //}
                    //else if (destino.Equals("Empleado"))
                    //{
                    pathArchivoXML = Path.Combine(pathXml + receptor.Replace(" ", string.Empty) + "_" + fecPago + @"\");
                    //}

                    if (!Directory.Exists(pathArchivoXML))
                    {
                        Directory.CreateDirectory(pathArchivoXML);
                    }

                     string nombreArchivo = fecPago + "_" + rfcReceptor + "_" + receptor;

                    pathArchivoXML = Path.Combine(pathArchivoXML + nombreArchivo + ".xml");
                    listaFolioXML.Add(new E.FolioXML
                    {
                        Folio = folio,
                        UUID = UUID,
                        XML = XML,
                        RutaXML = pathArchivoXML,
                        Empleado = receptor,
                        Importe = total,
                        StatusSAT = "Timbrado",
                        FecPago = Convert.ToDateTime(fecPago),
                        FecIni = Convert.ToDateTime(fecIni),
                        FecFin = Convert.ToDateTime(fecFin),
                        Empresa = emisor,
                        RFC = rfcReceptor,                        
                        nominaEmpresaID = EmpresaID
                    });
                    ListaNomina.Add(new M.Nomina
                    {
                        nominanumEmpl = Convert.ToInt32(numEmpl),
                        nominanombreEmpleado = receptor,
                        nominaRFCEmpleado = rfcReceptor,
                        nominaPeriodidicadPago = periPago,
                        nominaIngresos = subTotal,
                        nominaIngresosBruto = total,
                        nominaISR = descuento,
                        nominaFechaPago = Convert.ToDateTime(fecPago),
                        nominaFechaIniPeri = Convert.ToDateTime(fecIni),
                        nominaFechaFinPero = Convert.ToDateTime(fecFin),
                        nominaEstatus = "Timbrado",
                        nominaEstatusSAT = "Timbrado",
                        nominaPeriodo = periodo,
                        nominaEmpresa = emisor,
                        nominaRFCEmpresa = rfcEmisor,
                        nominaEmpresaNominaID = EmpresaID,
                        nominaUsuario = usuarioSistema,
                        nominaUsuarioCierrePeriodo = usuarioSistema,
                        ResumenNominaID = "Nomina_" + empresa + "_" + IDClient + "_" + IDEmpresa+ "_" + periodo,
                        nominaUUID = UUID,
                        nominaFolio = folio,
                        nominaIDCliente = IDClient,
                        nominaCliente = cliente,
                        nominaIDEmp = IDEmpresa,
                        nominaEmpresaPago = empresa
                    });
                    listaBitacora.Add(new E.BitacoraXML
                    {
                        Folio = folio,
                        UUID = UUID,
                        StatusSAT = "Timbrado",
                        FecPago = Convert.ToDateTime(fecPago),
                        FecIni = Convert.ToDateTime(fecIni),
                        FecFin = Convert.ToDateTime(fecFin),
                        Empresa = empresa,
                        Movimiento = "Carga XML",
                        IPMovimiento = ip,
                        Usuario = usuarioSistema,
                        Origen = "Cargar XML",
                        nominaEmpresaID = EmpresaID
                    });
                }
                //controlador.CargarXML(listaBitacora, ListaNomina, listaFolioXML);
                controlador.InsertaFolioLecturaXML(listaFolioXML);
                controlador.InsertaNominaXML(ListaNomina);
                controlador.InsertaBitacoraXML(listaBitacora);
                string mensajeExito = "¡Lectura de archivos y carga de información con éxito!";
                XtraMessageBox.Show(mensajeExito, "Lectura XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception btnInfo)
            {
                string mensaje = "Error al intentar leer XML" + "\n" + btnInfo.Message;
                XtraMessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
