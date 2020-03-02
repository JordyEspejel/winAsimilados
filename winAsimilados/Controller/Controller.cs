using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = winAsimilados.Controller;
using E = winAsimilados.Entities;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.xml;
using iTextSharp.text.pdf;
using System.Xml.Xsl;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Serialization;
using System.Diagnostics;
namespace winAsimilados.Controller
{
    class Controller
    {

        public void Buscar(GridControl grid, string fechaIni, string fechaFIn)
        {
            try
            {
                N.Conexion.PerformConnection().Open();
                SqlCommand queryBuscar = N.Conexion.PerformConnection().CreateCommand();
                queryBuscar.CommandText = @"SELECT Nom_Generales.FechaPago as 'Fecha Pago',Nom_Generales.UUID,Doc_Encabezados.Total AS 'IMPORTE PAGADO',Doc_Encabezados.Receptor_Rfc as 'R.F.C TRABAJADOR'
                ,Doc_Encabezados.Receptor_Nombre as 'NOMBRE DEL TRABAJADOR',ADC.FECHA_INICIAL,ADC.FECHA_FINAL,Nom_Generales.NumDiasPagados AS 'DIAS PAGADOS',
				ADC.ESTATUS_SAT as 'ESTATUS SAT'
                FROM  Nom_Generales 
                INNER JOIN Doc_Encabezados ON Doc_Encabezados.UUID = Nom_Generales.UUID 
                INNER JOIN ADC ON Nom_Generales.UUID = ADC.UUID 
                WHERE ADC.FECHA_INICIAL >= @fechIni AND ADC.FECHA_FINAL <= @fechFinal ORDER BY	 Nom_Generales.FechaPago ASC";
                queryBuscar.Parameters.AddWithValue("@fechIni", fechaIni);
                queryBuscar.Parameters.AddWithValue("@fechFinal", fechaFIn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = queryBuscar;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                grid.DataSource = dataSet.Tables[0];
                N.Conexion.PerformConnection().Close();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n Controller: Buscar()", "Error");
            }            
        }

        private static string GetStringOfFile(string pathFile)
        {
            string contenido = File.ReadAllText(pathFile);
            return contenido;
        }
        public bool BuscarRecursos()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "/";
            string pathHTMLPlantilla = path + "Formato_Factura_33_a.html";
            string pathWKHTMLTOPDF = path + "wkhtmltopdf\\wkhtmltopdf.exe";

            if (!File.Exists(pathHTMLPlantilla) || !File.Exists(pathWKHTMLTOPDF))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AgregarRecursos()
        {
            string pathDestino = AppDomain.CurrentDomain.BaseDirectory + "/";
            string pathHTMLPlantilla = pathDestino + "Formato_Factura_33_a.html";
            string pathWKHTMLTOPDF = pathDestino + "wkhtmltopdf\\wkhtmltopdf.exe"; 
            string pathOrigen = @"C:/DocAsimilados/";
            string plantillaNombre = "Formato_Factura_33_a.html";
            string archivo = null;

            string origenPlantilla = Path.Combine(pathOrigen, plantillaNombre);
            string destinoPlantilla = Path.Combine(pathDestino, plantillaNombre);
            string origenPDF = Path.Combine(pathOrigen, "wkhtmltopdf/");
            string destinoPDF = null;

            if (BuscarRecursos().Equals(false))
            {
                if (!File.Exists(pathHTMLPlantilla))
                {
                    try
                    {
                        File.Copy(origenPlantilla, destinoPlantilla, true);
                    }catch (Exception e)
                    {
                        MessageBox.Show(e.Message + "\nHubo un error al intentar generar los archivos necesarios para crear PDF, por favor pongase en contacto con el administrador de sistema.", "Error");
                    }
                }

                if (!File.Exists(pathWKHTMLTOPDF))
                {
                    try
                    {
                        if (!Directory.Exists(origenPDF))
                        {
                            MessageBox.Show("La carpeta de origen de archivos PDF no existe.\nPor favor, notifique al administrador de sistema.","Error");
                        }
                        else
                        {
                            if (!Directory.Exists(pathDestino + "wkhtmltopdf"))
                            {
                                Directory.CreateDirectory(pathDestino + "wkhtmltopdf");
                            }
                            else
                            {
                                string[] files = Directory.GetFiles(origenPDF);
                                foreach (string f in files)
                                {
                                    archivo = Path.GetFileName(f);
                                    destinoPDF = Path.Combine(pathDestino + "wkhtmltopdf", archivo);
                                    File.Copy(f, destinoPDF, true);
                                }
                            }
                        }
                    }catch(Exception e)
                    {
                        MessageBox.Show(e.Message + "\nHubo un error al intentar generar los archivos necesarios para crear PDF, por favor pongase en contacto con el administrador de sistema.", "Error");

                    }
                }

            }
            else
            {

            }
        }


        [Obsolete]
        public void LeerXML(string pathXML, string pathF)
        {
            try
            {
                Comprobante oComprobante;
                
                ///*oComprobante*/.Nomina12.Receptor.Departamento
                XmlSerializer oSerializer = new XmlSerializer(typeof(Comprobante));

                using (StreamReader reader = new StreamReader(pathXML + ".xml"))
                {
                    //aqui deserializamos
                    oComprobante = (Comprobante)oSerializer.Deserialize(reader);

                    //complementos
                    foreach (var oComplemento in oComprobante.Complemento)
                    {
                        foreach (var oComplementoInterior in oComplemento.Any)
                        {
                            if (oComplementoInterior.Name.Contains("TimbreFiscalDigital"))
                            {

                                XmlSerializer oSerializerComplemento = new XmlSerializer(typeof(TimbreFiscalDigital));
                                using (var readerComplemento = new StringReader(oComplementoInterior.OuterXml))
                                {
                                    oComprobante.TimbreFiscalDigital =
                                        (TimbreFiscalDigital)oSerializerComplemento.Deserialize(readerComplemento);
                                }

                            }
                            if (oComplementoInterior.Name.Contains("Nomina"))
                            {
                                XmlSerializer oSerializerComplemento = new XmlSerializer(typeof(Nomina));
                                using (var readerComplemento = new StringReader(oComplementoInterior.OuterXml))
                                {
                                    oComprobante.Nomina12 =
                                         (Nomina)oSerializerComplemento.Deserialize(readerComplemento);

                                }

                                //XmlSerializer oSerializerComplemento2 = new XmlSerializer(typeof(NominaDeduccionesDeduccion));
                                //using (var readerComplemento1 = new StringReader(oComplementoInterior.OuterXml))
                                //{

                                //    oComprobante.Deduccion =
                                //        (NominaDeduccionesDeduccion)oSerializerComplemento2 .Deserialize(readerComplemento1);
                                //}


                            }
                        }
                    }
                }

                string path = AppDomain.CurrentDomain.BaseDirectory + "/";
                //string path = @"C:\Users\aespejel\source\repos\winAsimilados\winAsimilados\Resources\";
                string pathHTMLTemp = path + "miHtml.html"; //temporal
                string pathHTMLPlantilla = path + "Formato_Factura_33_a.html";
                string sHtml = GetStringOfFile(pathHTMLPlantilla);
                string resultHtml = "";

                resultHtml = RazorEngine.Razor.Parse(sHtml, oComprobante);

                //MessageBox.Show(resultHtml);

                System.IO.File.WriteAllText(pathHTMLTemp, resultHtml);

                //string pathWKHTMLTOPDF = @"C:\Users\aespejel\Downloads\Facturacion3.3-tutorial-pdf\XMLToClassSAT\wkhtmltopdf\wkhtmltopdf.exe";
                string pathWKHTMLTOPDF = path + "wkhtmltopdf\\wkhtmltopdf.exe";
                ProcessStartInfo oProcessStartInfo = new ProcessStartInfo();
                oProcessStartInfo.UseShellExecute = false;
                oProcessStartInfo.FileName = pathWKHTMLTOPDF;
                oProcessStartInfo.Arguments = "miHtml.html mipdf.pdf";
                //oProcessStartInfo.Arguments = pathF + ".html "+ pathF +".pdf";

                using (Process oProcess = Process.Start(oProcessStartInfo))
                {
                    oProcess.WaitForExit();
                }
              
                //eliminamos el archivo temporal
                System.IO.File.Delete(pathHTMLTemp);
                File.Move(path + "mipdf.pdf", pathF + ".pdf");
                System.IO.File.Delete(path + "mipdf.pdf");


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\nControlador: LeerXML()", "Error");
            }

        }

        [Obsolete]
        public bool Generar(List<E.UUID> list)
        {
            if (BuscarRecursos().Equals(true)){
                try
                {
                    string XML = null;
                    string RFC = null;
                    string dia = null;
                    string mes = null;
                    string year = null;
                    string fechaPago = null;
                    string nombreTrabajador = null;
                    string UUID = null;
                    int cont = 0;
                    if (list.Count() == 0)
                    {
                        MessageBox.Show("Por favor, seleccione una celda", "Error");
                        return false;
                    }
                    else
                    {
                        //MessageBox.Show(list.Count().ToString());
                        foreach (var uuid in list)
                        {
                            cont++;
                            //MessageBox.Show(uuid.UIID,"Información");
                            try
                            {
                                N.Conexion.PerformConnection().Open();
                                SqlCommand QueryUUID = N.Conexion.PerformConnection().CreateCommand();
                                SqlDataReader readerUUID;
                                QueryUUID.CommandText = @"Select top 1 XML_ADJUNTO, RFC, FechaPago, Receptor_Nombre, ADC.UUID from ADC
                                inner join Nom_Generales on Nom_Generales.UUID = ADC.UUID
                                inner join Doc_Encabezados on Doc_Encabezados.UUID = ADC.UUID
                                where ADC.UUID= @uuid";
                                QueryUUID.Parameters.AddWithValue("@uuid", uuid.UIID);

                                readerUUID = QueryUUID.ExecuteReader();
                                while (readerUUID.Read())
                                {
                                    XML = readerUUID.GetString(0).ToString();
                                    RFC = readerUUID.GetString(1).ToString();
                                    fechaPago = readerUUID.GetDateTime(2).ToString("dd-MM-yyy");
                                    nombreTrabajador = readerUUID.GetString(3).ToString();
                                    UUID = readerUUID.GetString(4).ToString();
                                }
                                readerUUID.Close();
                                N.Conexion.PerformConnection().Close();
                                //MessageBox.Show(XML);
                                dia = DateTime.Now.Day.ToString();
                                mes = DateTime.Now.Month.ToString();
                                year = DateTime.Now.Year.ToString();
                                string ruta = @"C:/XML/" + fechaPago + "/";
                                if (!Directory.Exists(ruta))
                                {
                                    Directory.CreateDirectory(ruta);
                                }
                                string name = fechaPago.ToString() + "_" + RFC + "_" + nombreTrabajador + "_" + UUID;
                                string nombre = fechaPago.ToString() + "_" + RFC + "_" + nombreTrabajador + "_" + UUID;
                                string rutafila = Path.Combine(ruta, nombre);
                                if (File.Exists(rutafila + ".xml"))
                                {
                                    MessageBox.Show("Los archivos de " + nombreTrabajador + ":\n(UUID: " + UUID + ")" + "\nYa fueron creados con anterioridad.", "Aviso");

                                }
                                else
                                {
                                    FileStream fs = new FileStream(path: ruta + nombre + ".xml", mode: FileMode.Create);
                                    byte[] info = new UTF8Encoding(true).GetBytes(XML);
                                    fs.Write(info, 0, info.Length);
                                    fs.Close();

                                    LeerXML(rutafila, rutafila);
                                }

                                if (cont == list.Count())
                                {
                                    MessageBox.Show("¡Proceso Terminado!", "Mensaje");
                                }

                            }
                            catch (Exception e)
                            {
                                N.Conexion.PerformConnection().Close();
                                MessageBox.Show(e.Message + "\nControlador: Generar(Foreach{})", "Error");
                            }
                        }
                        return true;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + "\nError Controller: Generar()", "Error");
                    
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Faltan archivos necesarios para generar PDF, Por favor pongase en contacto con el administrador de sistema.", "Error");
                AgregarRecursos();
                return false;
            }
 
        }
    }
}
