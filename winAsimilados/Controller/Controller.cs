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
using D = soprclscomp;
using System.Diagnostics;
using V = winAsimilados.Views;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraSplashScreen;

namespace winAsimilados.Controller
{
    class Controller
    {
        public bool AccedeEmpresa(string Empresa)
        {
            try
            {
                N.Conexion.PerformConnection().Open();
                N.Conexion.PerformConnection().ChangeDatabase(Empresa);
                return true;
            }catch (Exception e)
            {
                MessageBox.Show(e.Message + "\nError en controlador:AccedeEmpresa()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                N.Conexion.PerformConnection().Close();
                return false;
            }
        }
        public bool Login(Object _P)
        {
            try
            {
                E.User User = (E.User)_P;
                N.Conexion.PerformConnectionSoprade().Open();
                SqlCommand queryLogin = N.Conexion.PerformConnectionSoprade().CreateCommand();
                D.clsSeguridad seguridad = new D.clsSeguridad();
                SqlDataReader readerLogin;
                string passEncrip = seguridad.EncryptString(User.pass);

                //MessageBox.Show("\nPASS: " + passEncrip + "\nUsua: " + User.usuario.ToUpper());

                queryLogin.CommandText = @"select usuaIDUsua, usuaPasswd from segUsuarios where usuaIDUsua = @usuario and usuaPasswd = @pass";
                queryLogin.Parameters.AddWithValue("@usuario", User.usuario.ToUpper());
                queryLogin.Parameters.AddWithValue("@pass", passEncrip.ToString());
                readerLogin = queryLogin.ExecuteReader();
                

                if (readerLogin.Read())
                {
                    //MessageBox.Show("Entra", "");
                    //Form1 frm = new Form1();
                    //frm.Show();
                    readerLogin.Close();
                    N.Conexion.PerformConnectionSoprade().Close();
                    return true;
                }
                else
                {
                    //MessageBox.Show("no entra", "");
                    readerLogin.Close();
                    N.Conexion.PerformConnectionSoprade().Close();
                    return false;
                }


                           
            }catch (Exception e)
            {
                MessageBox.Show(e.Message + "Error login()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                N.Conexion.PerformConnectionSoprade().Close();
                return false;
            }
        }

        public void AgregaEmpleado(Object _P)
        {
            try
            {
                E.Empleado empleado = (E.Empleado)_P;
                int numEmplAnt =0, numEmplNue = 0;
                SqlCommand queryNumEmpl = N.Conexion.PerformConnection().CreateCommand();
                queryNumEmpl.CommandText = @"select max (cast(NUM_EMPLEADO as int)) from EMPLEADOS";
                SqlDataReader readerNumEmpl;
                readerNumEmpl = queryNumEmpl.ExecuteReader();

                if (readerNumEmpl.Read())
                {
                    numEmplAnt = Convert.ToInt32(readerNumEmpl.GetInt32(0));
                    numEmplNue = numEmplAnt + 1;
                }
                readerNumEmpl.Close();
                //MessageBox.Show(numEmplAnt + "\n" + numEmplNue);

                SqlCommand queryBuscaEmpl = N.Conexion.PerformConnection().CreateCommand();
                queryBuscaEmpl.CommandText = @"select * from Empleados where RFC = @rfc";
                SqlDataReader ReaderEmpl;
                queryBuscaEmpl.Parameters.AddWithValue("@rfc", empleado.RFC);
                ReaderEmpl = queryBuscaEmpl.ExecuteReader();

                SqlCommand queryInsertaEmpl = N.Conexion.PerformConnection().CreateCommand();
                queryInsertaEmpl.CommandText = @"INSERT INTO [dbo].[EMPLEADOS]
                ([NUM_EMPLEADO]
                ,[NOMBRE]
                ,[RFC]
                ,[CURP]
                ,[TIPO_REGIMEN]
                ,[DEPARTAMENTO]
                ,[FECHA_INICIO_LABORAL]
                ,[PUESTO]
                ,[TIPO_CONTRATO]
                ,[TIPO_JORNADA]
                ,[PERIODICIDAD_PAGO]
                ,[SINDICALIZADO])
                VALUES
                ('" + numEmplNue + "','" + empleado.Nombre + "','" + empleado.RFC + "','" + empleado.CURP + "','" + "09'," + "'ASIMILADOS'," + "'01/01/1900'," + "'ASIMILADOS',"
                + "'99'," + "'00','" + empleado.Periodicidad + "'," + "'No'" + ")";
                
                if (ReaderEmpl.Read())
                {
                    MessageBox.Show("El empleado:" + empleado.Nombre + "\nYa se encuentra registrado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReaderEmpl.Close();
                }
                else
                {
                    //MessageBox.Show("No existe");
                    ReaderEmpl.Close();
                    if (queryInsertaEmpl.ExecuteNonQuery().Equals(1))
                    {
                        MessageBox.Show("¡Empleado agregado satisfactoriamente!", "Agregar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\nError Controlador: AgregaEmpleado()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void AgregarEmpleadoMasivo(List<E.Empleado> list, Object _P, SplashScreenManager splashManager)
        {
            try
            {
                StreamWriter writer = null;
                StringBuilder builder = null;
                string url = @"C:\AsimiladosLogs\";
                if (!Directory.Exists(url))
                {
                    Directory.CreateDirectory(url);
                }
                string NombreArchivo = Convert.ToString(DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-"
                + DateTime.Now.Year.ToString() + ", " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString()
                + "-" + DateTime.Now.Second.ToString());
                string path = Path.Combine(url, NombreArchivo + ".INARI");
                int numEmplAnt = 0, numEmplNue = 0, contErrores = 0, contExito = 0, cont = 0, contErrRFC = 0, contErrCURP = 0, validaCURP = 0, ValidaRFC = 0, ValidaExiste = 0, TotalErrores = 0;
                E.Empleado empleado = (E.Empleado)_P;

                builder = new StringBuilder();
                builder.AppendLine();
                builder.Append("********************************   Erroes Encontrados  ******************************************" + "\r\n");
                builder.AppendLine();

                foreach (var empl in list)
                {
                    builder.Append("Nombre del empleado:" + empl.Nombre + "\r\n");
                    builder.AppendLine();

                    cont++;
                    SqlCommand queryNumEmpl = N.Conexion.PerformConnection().CreateCommand();
                    queryNumEmpl.CommandText = @"select max (cast(NUM_EMPLEADO as int)) from EMPLEADOS";
                    SqlDataReader readerNumEmpl;
                    readerNumEmpl = queryNumEmpl.ExecuteReader();

                    if (readerNumEmpl.Read())
                    {
                        numEmplAnt = Convert.ToInt32(readerNumEmpl.GetInt32(0));
                        numEmplNue = numEmplAnt + 1;
                    }
                    readerNumEmpl.Close();
                    //MessageBox.Show(numEmplAnt + "\n" + numEmplNue);

                    SqlCommand queryBuscaEmpl = N.Conexion.PerformConnection().CreateCommand();
                    queryBuscaEmpl.CommandText = @"select * from Empleados where RFC = @rfc";
                    SqlDataReader ReaderEmpl;
                    queryBuscaEmpl.Parameters.AddWithValue("@rfc", empl.RFC);
                    ReaderEmpl = queryBuscaEmpl.ExecuteReader();

                    SqlCommand queryInsertaEmpl = N.Conexion.PerformConnection().CreateCommand();
                    queryInsertaEmpl.CommandText = @"INSERT INTO [dbo].[EMPLEADOS]
                    ([NUM_EMPLEADO]
                    ,[NOMBRE]
                    ,[RFC]
                    ,[CURP]
                    ,[TIPO_REGIMEN]
                    ,[DEPARTAMENTO]
                    ,[FECHA_INICIO_LABORAL]
                    ,[PUESTO]
                    ,[TIPO_CONTRATO]
                    ,[TIPO_JORNADA]
                    ,[PERIODICIDAD_PAGO]
                    ,[SINDICALIZADO])
                    VALUES
                    ('" + numEmplNue + "','" + empl.Nombre + "','" + empl.RFC + "','" + empl.CURP + "','" + "09'," + "'ASIMILADOS'," + "'01/01/1900'," + "'ASIMILADOS',"
                        + "'99'," + "'00','" + empl.Periodicidad + "'," + "'No'" + ")";

                    if (!empl.RFC.Length.Equals(13))
                    {
                        contErrRFC++;
                        string MensajeRFC = "RFC no cumple con el formato correcto, favor de verificar.";
                        //contErrores++;
                        ValidaRFC = 0;
                        builder.Append(MensajeRFC);
                        builder.AppendLine();
                    }
                    else
                    {
                        ValidaRFC = 1;
                    }

                    if (!empl.CURP.Length.Equals(18))
                    {
                        contErrCURP++;
                        string MensajeCURP = "CURP no cumple con el formato correcto, favor de verificar";
                        //contErrores++;
                        validaCURP = 0;
                        builder.Append(MensajeCURP);
                        builder.AppendLine();
                    }
                    else
                    {
                        validaCURP = 1;
                    }

                    if (ReaderEmpl.Read())
                    {
                        contErrores++;                    
                        string MensajeExiste = "El empleado ya fue registrado anteriormete.";
                        //MessageBox.Show("El empleado:" + empleado.Nombre + "\nYa se encuentra registrado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReaderEmpl.Close();
                        ValidaExiste = 0;
                        builder.Append(MensajeExiste);
                        builder.AppendLine();
                    }
                    else
                    {
                        ReaderEmpl.Close();
                        ValidaExiste = 1;
                    }

                    builder.Append("*************************************************************************************************");
                    builder.AppendLine();
                    //MessageBox.Show("No existe");

                    if (validaCURP == 1 && ValidaRFC == 1 && ValidaExiste == 1)
                    {
                        if (queryInsertaEmpl.ExecuteNonQuery().Equals(1))
                        {
                            contExito++;
                            //MessageBox.Show("¡Empleado agregado satisfactoriamente!", "Agregar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                        }
                    }
                        
                    if (cont == list.Count())
                    {
                        if (contErrores > 0)
                        {
                            //Aqui se genera el log
                            TotalErrores = contErrores + contErrRFC + contErrCURP;
                            builder.AppendLine();
                            builder.Append("********************************       Fin Erroes      ******************************************" + "\r\n");
                            splashManager.CloseWaitForm();
                            MessageBox.Show("Proceso terminado con " + TotalErrores + " errores y " + contExito + " con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            writer = new StreamWriter(path, true);
                            writer.Write(builder);
                            writer.Close();
                            FileStream file = new FileStream(path, FileMode.Open);
                        }
                        else
                        {
                            splashManager.CloseWaitForm();
                            MessageBox.Show("¡Carga masiva terminada con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }
            catch (Exception e)
            {
                splashManager.CloseWaitForm();
                MessageBox.Show(e.Message + "\nError Controlador: AgregaEmpleadoMasivo()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListaEmpleados (string bd, GridControl grid)
        {
            try
            {
                N.Conexion.PerformConnection().Close();
                N.Conexion.PerformConnection().Open();
                N.Conexion.PerformConnection().ChangeDatabase(bd);

                SqlCommand queryListaEmpleados = N.Conexion.PerformConnection().CreateCommand();
                queryListaEmpleados.CommandText = @"SELECT
                                                    [NUM_EMPLEADO] as [# EMPLEADO]
                                                  ,[NOMBRE] 
                                                  ,[RFC]   
                                                  ,[CURP]
                                                  ,[PERIODICIDAD_PAGO] as [PERIODICIDAD PAGO]
                                              FROM [EMPLEADOS]";
                
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = queryListaEmpleados;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                grid.DataSource = dataSet.Tables[0];
                //string message = N.Conexion.PerformConnection().Database;
                //MessageBox.Show(message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\nError Controller: ListaEmpleados()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListadoEmpresas(GridControl grid)
        {
            try
            {
                N.Conexion.PerformConnection().Close();
                N.Conexion.PerformConnection().Open();
                SqlCommand queryListado = N.Conexion.PerformConnection().CreateCommand();
                queryListado.CommandText = @"SELECT Numero_Empresa as 'Numero Empresa', Nombre_Empresa as 'EMPRESA',RFC_Empresa AS 'R.F.C.'
                                            ,STATUS,TablaEmpresa AS 'Base de Datos'
                                            from Listado_Empresas where status='1'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = queryListado;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                grid.DataSource = dataSet.Tables[0];
                N.Conexion.PerformConnection().Close();

            }catch (Exception e)
            {
                MessageBox.Show(e.Message + "\nError Controlador: ListadoEmpresas()","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Buscar(GridControl grid, string fechaIni, string fechaFIn)
        {
            try
            {
               // N.Conexion.PerformConnection().Open();
                //N.Conexion.PerformConnection().ChangeDatabase("Nomina_Empresa17");
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
             //   N.Conexion.PerformConnection().Close();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n Controller: Buscar()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                N.Conexion.PerformConnection().Close();
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
                              //  N.Conexion.PerformConnection().Open();
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
                               // N.Conexion.PerformConnection().Close();
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