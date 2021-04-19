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
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraExport.Xls;
using DevExpress.CodeParser;
using XSDToXML.Utils;
using System.Net;
using DevExpress.Utils.Extensions;
using DevExpress.XtraRichEdit.Layout.Engine;
using DevExpress.XtraCharts.Designer.Native;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraReports.Design;
using System.Security.RightsManagement;
using winAsimilados.ServicioPruebasTimbradoNTLINK;
using winAsimilados.ServcioTimbradoNTLINK;
using ServicioTimbradoClient = winAsimilados.ServcioTimbradoNTLINK.ServicioTimbradoClient;
using ServicioTimbtadoClientPruebas = winAsimilados.ServicioPruebasTimbradoNTLINK.ServicioTimbradoClient;
using System.Net.Mail;
using System.IO.Compression;
using Pechkin.Synchronized;
using Pechkin;
using System.Drawing.Printing;
using WkHtmlToPdf;
using M = winAsimilados.Models;

namespace winAsimilados.Controller
{
    class Controller
    {
        M.AsimiladosDataContext dtc = new M.AsimiladosDataContext();

        public M.ResumenNomina ObtieneInfoResumen(int IDResumen)
        {
            try
            {
                M.ResumenNomina resumen = new M.ResumenNomina();
                dtc.Connection.Open();
                SqlCommand queryGetResumen = (SqlCommand)dtc.Connection.CreateCommand();
                queryGetResumen.CommandText = @"SELECT [ID]
                ,[ResumenNominaID]
                ,[ResumenNominaTotalEmpleados]
                ,[ResumenNominaTotalIngresos]
                ,[ResumenNominaTotalIngresosBruto]
                ,[ResumenNominaTotalISR]
                ,[ResumenNominaFechaPago]
                ,[ResumenNominaFechaInicioPeri]
                ,[ResumenNominaFechaFinPeri]
                ,[ResumenNominaFechaCreacion]
                ,[ResumenNominaEstatus]
                ,[ResumenNominaEstatusSAT]
                ,[ResumenNominaPeriodo]
                ,[ResumenNominaEmpresaNombre]
                ,[ResumenNominaRFCEmpresa]
                ,[ResumenNominaUsuarioCreacion]
                ,[ResumenNominaUsuarioCierrePeriodo]
                ,ISNULL([ResumenNominaUsuarioFechaCierre], '') AS [ResumenNominaUsuarioFechaCierre]
                ,[ResumenNominaNominaEmpresaID]
                FROM [Asimilados].[dbo].[ResumenNomina]
                WHERE [ID] = @ID";
                queryGetResumen.Parameters.AddWithValue("@ID", IDResumen);
                SqlDataReader reader;
                reader = queryGetResumen.ExecuteReader();
                if (reader.Read())
                {
                    resumen.ID = reader.GetInt32(0);
                    resumen.ResumenNominaID = reader.GetString(1);
                    resumen.ResumenNominaTotalEmpleados = reader.GetInt32(2);
                    resumen.ResumenNominaTotalIngresos = reader.GetDecimal(3);
                    resumen.ResumenNominaTotalIngresosBruto = reader.GetDecimal(4);
                    resumen.ResumenNominaTotalISR = reader.GetDecimal(5);
                    resumen.ResumenNominaFechaPago = reader.GetDateTime(6);
                    resumen.ResumenNominaFechaInicioPeri = reader.GetDateTime(7);
                    resumen.ResumenNominaFechaFinPeri = reader.GetDateTime(8);
                    resumen.ResumenNominaFechaCreacion = reader.GetDateTime(9);
                    resumen.ResumenNominaEstatus = reader.GetString(10);
                    resumen.ResumenNominaEstatusSAT = reader.GetString(11);
                    resumen.ResumenNominaPeriodo = reader.GetString(12);
                    resumen.ResumenNominaEmpresaNombre = reader.GetString(13);
                    resumen.ResumenNominaRFCEmpresa = reader.GetString(14);
                    resumen.ResumenNominaUsuarioCreacion = reader.GetString(15);
                    resumen.ResumenNominaUsuarioCierrePeriodo = reader.IsDBNull(16) ?"" : reader.GetString(16);
                    resumen.ResumenNominaUsuarioFechaCierre = reader.GetDateTime(17);
                    resumen.ResumenNominaNominaEmpresaID = reader.GetString(18);
                }
                return resumen;
            }catch (Exception)
            {
                dtc.Connection.Close();
                throw;
            }
        }
        public void CerrarNomina(int idResumen, string resumenNominaID, string usuario)
        {
            try
            {
                dtc.Connection.Open();
                SqlCommand queryStatusResumen = (SqlCommand)dtc.Connection.CreateCommand();
                SqlCommand queryStatusNomina = (SqlCommand)dtc.Connection.CreateCommand();
                queryStatusResumen.CommandText = @"UPDATE ResumenNomina
                SET ResumenNominaEstatus = 'Cerrado'
                , ResumenNominaUsuarioCierrePeriodo = @usuario
                , ResumenNominaUsuarioFechaCierre = GETDATE()
                WHERE ID = @IDResumen";
                queryStatusResumen.Parameters.AddWithValue("@IDResumen", idResumen);
                queryStatusResumen.Parameters.AddWithValue("@usuario", usuario);
                queryStatusNomina.CommandText = @"update Nomina
                SET nominaEstatus = 'Cerrado'
                ,nominaUsuarioCierrePeriodo = @usuario
                ,nominaFechaCierrePeriodo = GETDATE()
                WHERE ResumenNominaID = @resumenNominaID";
                queryStatusNomina.Parameters.AddWithValue("@resumenNominaID", resumenNominaID);
                queryStatusNomina.Parameters.AddWithValue("@usuario", usuario);
                queryStatusResumen.ExecuteNonQuery();
                queryStatusNomina.ExecuteNonQuery();
                dtc.Connection.Close();
            }
            catch (Exception)
            { 
                dtc.Connection.Close();
                throw;
            }
        }
        public void InsertaResumenNomina(M.ResumenNomina resumenNomina)
        {
            try
            {
                dtc.Connection.Open();
                SqlCommand queryInsertaResumen = (SqlCommand)dtc.Connection.CreateCommand();
                queryInsertaResumen.CommandText = @"INSERT INTO [dbo].[ResumenNomina]
               ([ResumenNominaID]
               ,[ResumenNominaTotalEmpleados]
               ,[ResumenNominaTotalIngresos]
               ,[ResumenNominaTotalIngresosBruto]
               ,[ResumenNominaTotalISR]
               ,[ResumenNominaFechaPago]
               ,[ResumenNominaFechaInicioPeri]
               ,[ResumenNominaFechaFinPeri]
               ,[ResumenNominaFechaCreacion]
               ,[ResumenNominaEstatus]
               ,[ResumenNominaEstatusSAT]
               ,[ResumenNominaPeriodo]
               ,[ResumenNominaEmpresaNombre]
               ,[ResumenNominaRFCEmpresa]
               ,[ResumenNominaUsuarioCreacion]
               --,[ResumenNominaUsuarioCierrePeriodo]
               --,[ResumenNominaUsuarioFechaCierre]
               ,[ResumenNominaNominaEmpresaID])
                VALUES('" + resumenNomina.ResumenNominaID + "'" +
                "," + resumenNomina.ResumenNominaTotalEmpleados + "" +
                "," + resumenNomina.ResumenNominaTotalIngresos + "" +
                "," + resumenNomina.ResumenNominaTotalIngresosBruto + "" +
                "," + resumenNomina.ResumenNominaTotalISR + "" +
                ",'" + Convert.ToDateTime(resumenNomina.ResumenNominaFechaPago).ToString("dd/MM/yyyy") + "'" +
                ",'" + Convert.ToDateTime(resumenNomina.ResumenNominaFechaInicioPeri).ToString("dd/MM/yyyy") + "'" +
                ",'" + Convert.ToDateTime(resumenNomina.ResumenNominaFechaFinPeri).ToString("dd/MM/yyyy") + "'" +
                ", GETDATE()" +
                ",'" + resumenNomina.ResumenNominaEstatus + "'" +
                ",'" + resumenNomina.ResumenNominaEstatusSAT + "'" +
                ",'" + resumenNomina.ResumenNominaPeriodo + "'" +
                ",'" + resumenNomina.ResumenNominaEmpresaNombre + "'" +
                ",'" + resumenNomina.ResumenNominaRFCEmpresa + "'" +
                ",'" + resumenNomina.ResumenNominaUsuarioCreacion + "'" +
                ",'" + resumenNomina.ResumenNominaNominaEmpresaID + "')";
                queryInsertaResumen.ExecuteNonQuery();
                dtc.Connection.Close();
            }catch (Exception)
            {
                dtc.Connection.Close();
                throw;
            }
        }
        public void InsertaNominaMasiva(List<M.Nomina> listaNominas)
        {
            try
            {
                dtc.Connection.Open();
                SqlCommand queryInsertaNomina = (SqlCommand)dtc.Connection.CreateCommand();
                foreach (var item in listaNominas)
                {
                    queryInsertaNomina.CommandText = @"INSERT INTO [dbo].[Nomina]
                    ([nominanumEmpl]
                    ,[nominanombreEmpleado]
                    ,[nominaRFCEmpleado]
                    ,[nominaPeriodidicadPago]
                    ,[nominaIngresos]
                    ,[nominaIngresosBruto]
                    ,[nominaISR]
                    ,[nominaFechaPago]
                    ,[nominaFechaIniPeri]
                    ,[nominaFechaFinPero]
                    ,[nominaFechaCreacion]
                    ,[nominaEstatus]
                    ,[nominaEstatusSAT]
                    ,[nominaPeriodo]
                    ,[nominaEmpresa]
                    ,[nominaRFCEmpresa]
                    --,[nominaIDEmp]
                    ,[nominaDescripciponError]
                    ,[nominaEmpresaNominaID]
                    ,[nominaUsuario]
                    ,[ResumenNominaID])
                VALUES
                      (" + item.nominanumEmpl + "" +
                      ",'" + item.nominanombreEmpleado + "'" +
                      ",'" + item.nominaRFCEmpleado + "'" +
                      ",'" + item.nominaPeriodidicadPago + "'" +
                      "," + item.nominaIngresos +  "" +
                      "," + item.nominaIngresosBruto + "" +
                      "," + item.nominaISR + "" +
                      ",'" + Convert.ToDateTime(item.nominaFechaPago).ToString("dd/MM/yyyy") + "'" +
                      ",'" + Convert.ToDateTime(item.nominaFechaIniPeri).ToString("dd/MM/yyyy") + "'" +
                      ",'" + Convert.ToDateTime(item.nominaFechaFinPero).ToString("dd/MM/yyyy") + "'" +
                      ",GETDATE()" +
                      ",'" + item.nominaEstatus + "'" +
                      ",'" + item.nominaEstatusSAT + "'" +
                      ",'" + item.nominaPeriodo + "'" +
                      ",'" + item.nominaEmpresa + "'" +
                      ",'" + item.nominaRFCEmpresa + "'" +
                      ",'" + item.nominaDescripciponError + "'" +
                      ",'" + item.nominaEmpresaNominaID + "'" +
                      ",'" + item.nominaUsuario + "'" +
                      ",'" + item.ResumenNominaID + "')";

                    queryInsertaNomina.ExecuteNonQuery();
                }
                dtc.Connection.Close();
            }
            catch(Exception)
            {
                dtc.Connection.Close();
                throw;
            }
        }
        public int ObtieneContPeriodoNomina(string nominaEmpresaID, string mes, SplashScreenManager splash)
        {
            try
            {
                int cont = 0;
                dtc.Connection.Open();
                SqlCommand queryGetCont = (SqlCommand)dtc.Connection.CreateCommand();
                queryGetCont.CommandText = @"SELECT
                COUNT(ResumenNominaID)
                from ResumenNomina
                WHERE ResumenNominaNominaEmpresaID = @Empresa
                AND MONTH(ResumenNominaFechaInicioPeri) = @Mes";
                queryGetCont.Parameters.AddWithValue("@Empresa", nominaEmpresaID);
                queryGetCont.Parameters.AddWithValue("@Mes", mes);
                SqlDataReader ReaderCont;
                ReaderCont = queryGetCont.ExecuteReader();
                if (ReaderCont.Read())
                {
                    cont = ReaderCont.GetInt32(0);
                }
                ReaderCont.Close();
                dtc.Connection.Close();
                return cont;
            }catch (Exception nomiCont)
            {
                if (splash.IsSplashFormVisible.Equals(true))
                {
                    splash.CloseWaitForm();
                }
                XtraMessageBox.Show("Error Controlador: ObtieneContPeriodoNomina:\n" + nomiCont.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtc.Connection.Close();
                return -1;
            }
        }
        public string EnviaFacturaCorreo(string correo, List<string> archivos, string destino)
        {
            try
            {
                string resultado;
                MailMessage email = new MailMessage();
                //email.To.Add(new MailAddress("jordyespejel7@gmail.com"));
                email.To.Add(new MailAddress(correo));
                email.From = new MailAddress("rbo.asimilado@gmail.com");
                email.Subject = "Recibos de nómina asimilados.";
                email.Body = "Correo enviado desde AppAsimilados, favor de no responder.";
                email.IsBodyHtml = false;
                email.Priority = MailPriority.Normal;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                //smtp.Host = "inari.mx";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("rbo.asimilado@gmail.com", "4S1m1l4d02020");

                if (destino.Equals("Empleado"))
                {
                    if (archivos != null)
                    {
                        foreach (var item in archivos)
                        {
                            if (System.IO.File.Exists(item))
                            {
                                email.Attachments.Add(new Attachment(item));
                            }
                        }
                    }
                } else if (destino.Equals("Cliente"))
                {
                    if (archivos != null)
                    {
                        foreach (var item in archivos)
                        {
                            string cadena = item;
                            string[] arrayCadena;
                            arrayCadena = cadena.Split(Convert.ToChar("\\"));
                            string path = Path.Combine(arrayCadena[0] + "\\", arrayCadena[1] + "\\");
                            string fecha = arrayCadena[2];
                            string nombreArchvo = Path.Combine(fecha + "_Nomina Asimilados.zip");
                            ZipFile.CreateFromDirectory(item, path + nombreArchvo);
                            email.Attachments.Add(new Attachment(path + nombreArchvo));
                        }
                    }
                }
                smtp.Send(email);
                email.Dispose();
                //XtraMessageBox.Show("Correo enviado satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resultado = "true";
                return resultado;
            }
            catch (Exception e)
            {
                string resultado;
                resultado = e.Message;
                return resultado;
                //XtraMessageBox.Show(e.Message + "\n Controller: EnviaFacturaCorreo()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ActualizaStatusFolio(int ID, string mensaje)
        {
            try
            {
                SqlCommand updateEstatus = N.Conexion.PerformConnection().CreateCommand();
                updateEstatus.CommandText = @"UPDATE [LayoutHistorico] SET [estatus] = '" + mensaje + "'" +
                    "WHERE [ID] = " + ID + "";

                updateEstatus.ExecuteNonQuery();
            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: ActualizaStatusFolio()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool EliminaClaveSAT(int ID)
        {
            try
            {
                SqlCommand eliminaClave = N.Conexion.PerformConnection().CreateCommand();
                eliminaClave.CommandText = @"DELETE FROM [dbo].[ClavesServCliente] WHERE
                 [ID] = " + ID + "";

                if (eliminaClave.ExecuteNonQuery().Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: EliminaClaveSAT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool InsertaClaveSAT(E.ClaveProdServClte clave)
        {
            try
            {
                SqlCommand insertaClave = N.Conexion.PerformConnection().CreateCommand();
                insertaClave.CommandText = @"INSERT INTO [dbo].[ClavesServCliente]
                    ([IDClte]
                    ,[Cliente]
                    ,[ClaveServProd]
                    ,[Concepto])
                    VALUES
                    ('" + clave.IDClte + "'" +
                    ",'" + clave.Cliente + "'" +
                    ",'" + clave.clave + "'" +
                    ",'" + clave.descripcion + "')";

                SqlCommand validaInsert = N.Conexion.PerformConnection().CreateCommand();
                validaInsert.CommandText = @"SELECT [ID]
                  ,[IDClte]
                  ,[Cliente]
                  ,[ClaveServProd]
                  ,[Concepto]
              FROM [dbo].[ClavesServCliente]
              where [IDClte] = @IDclte AND [ClaveServProd] = @clave";
                validaInsert.Parameters.AddWithValue("@IDclte", clave.IDClte);
                validaInsert.Parameters.AddWithValue("@clave", clave.clave);

                SqlDataReader readerClave;
                readerClave = validaInsert.ExecuteReader();

                if (readerClave.Read())
                {
                    readerClave.Close();
                    XtraMessageBox.Show("La clave " + clave.clave + " ya fue asignada al cliente " + clave.Cliente + "", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    readerClave.Close();
                    if (insertaClave.ExecuteNonQuery().Equals(1))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }


            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: InsertaClaveSAT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool ModificaBancoEmpresa(List<E.BancoEmpresa> lista)
        {
            try
            {
                int cont = 0;
                foreach (var item in lista)
                {
                    SqlCommand updateBanco = N.Conexion.PerformConnection().CreateCommand();
                    updateBanco.CommandText = @"UPDATE [dbo].[CatalogoBancosEmpresaPagaAsimilados]
                    SET [Cuenta] = '" + item.Cuenta + "'" +
                    ", [CLABE] = '" + item.CLABE + "'" +
                    "WHERE [ID] = " + item.ID + "";

                    if (updateBanco.ExecuteNonQuery().Equals(1))
                    {
                        cont++;
                    }
                }

                if (cont.Equals(lista.Count()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: ModificaBancoEmpresa()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool modificaListaBancos(List<E.Banco> lista, SplashScreenManager splash)
        {
            try
            {
                int cont = 0;
                foreach (var item in lista)
                {
                    SqlCommand updateBanco = N.Conexion.PerformConnection().CreateCommand();
                    updateBanco.CommandText = @"UPDATE [dbo].[Bancos]
                    SET [c_Banco] = '" + item.cveBanco + "'" +
                    ", [Descripcion] = '" + item.nombre + "'" +
                    ", [Nombre o razón social] = '" + item.razonSocial + "'" +
                    "WHERE [c_Banco] = " + item.cveBanco + "";

                    if (updateBanco.ExecuteNonQuery().Equals(1))
                    {
                        cont++;
                    }
                }

                if (cont.Equals(lista.Count()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                splash.CloseWaitForm();
                XtraMessageBox.Show(e.Message + "\n Controller: ModificaBanco()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool EliminaBanco(string cve)
        {
            try
            {
                SqlCommand eliminaBanco = N.Conexion.PerformConnection().CreateCommand();
                eliminaBanco.CommandText = @"DELETE FROM  [dbo].[Bancos] WHERE
                 [c_Banco] = " + cve + "";

                if (eliminaBanco.ExecuteNonQuery().Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: EliminaBanco ()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool EliminaBancoEmpresa(string ID)
        {
            try
            {
                SqlCommand eliminaBanco = N.Conexion.PerformConnection().CreateCommand();
                eliminaBanco.CommandText = @"DELETE FROM  [dbo].[CatalogoBancosEmpresaPagaAsimilados] WHERE
                 [ID] = " + ID + "";

                if (eliminaBanco.ExecuteNonQuery().Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: EliminaBancoEmpresa ()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool InsertaBanco(E.Banco banco)
        {
            try
            {
                SqlCommand insertaBanco = N.Conexion.PerformConnection().CreateCommand();
                insertaBanco.CommandText = @"INSERT INTO  [dbo].[Bancos]
                   ([c_Banco]
                   ,[Descripcion]
                   ,[Nombre o razón social])
             VALUES
                   ('" + banco.cveBanco + "'" +
                   ", '" + banco.nombre + "'" +
                   ", '" + banco.razonSocial + "')";

                SqlCommand validaInsert = N.Conexion.PerformConnection().CreateCommand();
                validaInsert.CommandText = @"SELECT  [c_Banco]
                      ,[Descripcion]
                      ,[Nombre o razón social]
                      ,[id]
                  FROM [dbo].[Bancos]
                  WHERE [c_Banco] = @cve";
                validaInsert.Parameters.AddWithValue("@cve", banco.cveBanco);

                SqlDataReader ReaderBanco;
                ReaderBanco = validaInsert.ExecuteReader();

                if (ReaderBanco.Read())
                {
                    ReaderBanco.Close();
                    XtraMessageBox.Show("El banco ya fue dado de alta previamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    ReaderBanco.Close();
                    if (insertaBanco.ExecuteNonQuery().Equals(1))
                    {
                        XtraMessageBox.Show("!Banco agregado con éxito¡", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: InsertaBanco()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }
        public bool InsertaBancoEmpresa(E.BancoEmpresa banco)
        {
            try
            {
                SqlCommand insertaBanco = N.Conexion.PerformConnection().CreateCommand();
                insertaBanco.CommandText = @"INSERT INTO  [dbo].[CatalogoBancosEmpresaPagaAsimilados]
                       ([IDEmpresa]
                       ,[RazonSocial]
                       ,[Banco]
                       ,[Cuenta]
                       ,[CLABE])
                 VALUES
                       ('" + banco.IDEmpresa + "'" +
                       ",'" + banco.RazonSocial + "'" +
                       ",'" + banco.Banco + "'" +
                       ",'" + banco.Cuenta + "'" +
                       ",'" + banco.CLABE + "')";
                SqlCommand validaInsert = N.Conexion.PerformConnection().CreateCommand();
                validaInsert.CommandText = @"SELECT  [ID]
                      ,[IDEmpresa]
                      ,[RazonSocial]
                      ,[Banco]
                      ,[Cuenta]
                      ,[CLABE]
                  FROM [dbo].[CatalogoBancosEmpresaPagaAsimilados]
                  where [IDEmpresa] = @IDEmpresa 
                  AND [Banco] = @Banco";
                validaInsert.Parameters.AddWithValue("@IDEmpresa", banco.IDEmpresa);
                validaInsert.Parameters.AddWithValue("@Banco", banco.Banco);

                SqlDataReader ReaderBanco;
                ReaderBanco = validaInsert.ExecuteReader();

                if (ReaderBanco.Read())
                {
                    ReaderBanco.Close();
                    XtraMessageBox.Show("El banco ya fue dado de alta previamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    ReaderBanco.Close();
                    if (insertaBanco.ExecuteNonQuery().Equals(1))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: InsertaBancoEmpresa()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool ReactivaCliente(E.ClienteAsimilado cliente)
        {
            try
            {
                SqlCommand updateEstatus = N.Conexion.PerformConnection().CreateCommand();
                updateEstatus.CommandText = @"UPDATE [dbo].[ClientesAsimilados]
                   SET [ESTATUS] = 'Activo' 
                WHERE [ID] = '" + cliente.ID + "'";

                if (updateEstatus.ExecuteNonQuery().Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: ReactivaCliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool BajaCliente(E.ClienteAsimilado cliente)
        {
            try
            {
                SqlCommand updateEstatus = N.Conexion.PerformConnection().CreateCommand();
                updateEstatus.CommandText = @"UPDATE [dbo].[ClientesAsimilados]
                   SET [ESTATUS] = 'Inactivo'
                  ,[FECHA_BAJA] =  GETDATE()
                WHERE [ID] = '" + cliente.ID + "'";

                if (updateEstatus.ExecuteNonQuery().Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: BajaCliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool UpdateCliente(E.ClienteAsimilado cliente)
        {
            try
            {
                SqlCommand updateCliente = N.Conexion.PerformConnection().CreateCommand();
                updateCliente.CommandText = @"UPDATE [dbo].[ClientesAsimilados]
                   SET [COMISIONISTA] = '" + cliente.COMISIONISTA + "'" +
                   ",[CLIENTE] = '" + cliente.CLIENTE + "'" +
                   ",[PORCENTAJE_ISN] = " + cliente.PORCENTAJE_ISN + "" +
                   ",[PORCENTAJE_COMISION] = " + cliente.PORCENTAJE_COMISION + "" +
                   ",[TOTAL] = " + cliente.TOTAL + "" +
                   ",[FACTURACION_CON_IVA_SIN_IVA] = '" + cliente.FACTURACION_CON_IVA_SIN_IVA + "'" +
                   ",[RETENCION] = '" + cliente.RETENCION + "'" +
                   ",[PORCENTAJE_RETENCION] = " + cliente.PORCENTAJE_RETENCION + "" +
                   ",[PERIODO_DE_PAGO] = '" + cliente.PERIODO_DE_PAGO + "'" +
                   ",[EJECUTIVO_RESPONSABLE] = '" + cliente.EJECUTIVO_RESPONSABLE + "'" +
                   ",[EMPRESA_PAGADORA_EMITE_CFDI] = '" + cliente.EMPRESA_PAGADORA_EMITE_CFDI + "'" +
                   ",[PROVEEDOR] = '" + cliente.PROVEEDOR + "'" +
                   ",[EMPRESA_QUE_FACTURA_A_CLIENTE] = '" + cliente.EMPRESA_QUE_FACTUR_A_CLIENTE + "'" +
                   ",[EMPRESA_QUE_FACTURA_A_CLIENTE1] = '" + cliente.EMPRESA_QUE_FACTURA_A_CLIENTE1 + "'" +
                   ",[EMPRESA_QUE_FACTURA_A_CLIENTE2] = '" + cliente.EMPRESA_QUE_FACTURA_A_CLIENTE2 + "'" +
                   ",[EMPRESA_QUE_FACTURA_A_CLIENTE3] = '" + cliente.EMPRESA_QUE_FACTURA_A_CLIENTE3 + "'" +
                   ",[Metodo_Pago] = '" + cliente.Metodo_Pago + "'" +
                    ",[Observaciones] = '" + cliente.Observaciones + "'" +
                    ",[Forma_Pago] = '" + cliente.Forma_Pago + "'" +
                    ",[PORCENTAJE_COMISIONISTA] = " + cliente.PORCENTAJE_COMISIONISTA + "" +
                    ",[COMISIONISTA2] = '" + cliente.COMISIONISTA2 + "'" +
                    ",[PORCENTAJE_COMISIONISTA2] = " + cliente.PORCENTAJE_COMISIONISTA2 + "" +
                    ",[COMISIONISTA3] = '" + cliente.COMISIONISTA3 + "'" +
                    ",[PORCENTAJE_COMISIONISTA3] = " + cliente.PORCENTAJE_COMISIONISTA3 + "" +
                    ",[PORCENTAJE_FACTURA] = " + cliente.PORCENTAJE_FACTURA + "" +
                    ",[PORCENTAJE_FACTURA2] = " + cliente.PORCENTAJE_FACTURA2 + "" +
                    ",[PORCENTAJE_FACTURA3] = " + cliente.PORCENTAJE_FACTURA3 + "" +
                    ",[PORCENTAJE_FACTURA4] = " + cliente.PORCENTAJE_FACTURA4 + "" +
                    ",[Correo] = '" + cliente.correoCliente + "'" +
                    "WHERE [ID] = '" + cliente.ID + "'";

                if (updateCliente.ExecuteNonQuery().Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: updateClte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool InsertaCliente(E.ClienteAsimilado cliente)
        {
            try
            {
                SqlCommand insertaCliente = N.Conexion.PerformConnection().CreateCommand();
                insertaCliente.CommandText = @"INSERT INTO [dbo].[ClientesAsimilados]
                   ([ID]
                   ,[CLIENTE]
                   ,[FECHA_ALTA _PRIMER PAGO]
                   ,[COMISIONISTA]
                   ,[PORCENTAJE_ISN]
                   ,[PORCENTAJE_COMISION]
                   ,[TOTAL]
                   ,[FACTURACION_CON IVA _SIN IVA]
                   ,[RETENCION]
                   ,[PORCENTAJE_RETENCION]
                   ,[PERIODO_DE_PAGO]
                   ,[ESTATUS]
                   ,[EJECUTIVO_RESPONSABLE]
                   ,[EMPRESA_PAGADORA_EMITE CFDI]
                   ,[PROVEEDOR]
                   ,[EMPRESA_QUE_FACTUR_A _CLIENTE]
                   ,[EMPRESA_QUE_FACTURA_A_CLIENTE1]
                   ,[EMPRESA_QUE_FACTURA_A_CLIENTE2]
                   ,[EMPRESA_QUE_FACTURA_A_CLIENTE3]
                   ,[Metodo_Pago]
                   ,[Observaciones]
                   ,[Forma_Pago]
                  ,[PORCENTAJE_COMISIONISTA]
                  ,[COMISIONISTA2]
                  ,[PORCENTAJE_COMISIONISTA2]
                  ,[COMISIONISTA3]
                  ,[PORCENTAJE_COMISIONIST3]
                  ,[PORCENTAJE_FACTURA]
                  ,[PORCENTAJE_FACTURA2]
                  ,[PORCENTAJE_FACTURA3]
                  ,[PORCENTAJE_FACTURA4]
                  ,[Correo])
             VALUES
                   ('" + cliente.ID + "'" +
                   ",'" + cliente.CLIENTE + "'" +
                   ", GETDATE()" +
                   ",'" + cliente.COMISIONISTA + "'" +
                   "," + cliente.PORCENTAJE_ISN + "" +
                   "," + cliente.PORCENTAJE_COMISION + "" +
                   "," + cliente.TOTAL + "" +
                   ",'" + cliente.FACTURACION_CON_IVA_SIN_IVA + "'" +
                   ",'" + cliente.RETENCION + "'" +
                   "," + cliente.PORCENTAJE_RETENCION + "" +
                   ",'" + cliente.PERIODO_DE_PAGO + "'" +
                   ",'" + cliente.ESTATUS + "'" +
                   ",'" + cliente.EJECUTIVO_RESPONSABLE + "'" +
                   ",'" + cliente.EMPRESA_PAGADORA_EMITE_CFDI + "'" +
                   ",'" + cliente.PROVEEDOR + "'" +
                   ",'" + cliente.EMPRESA_QUE_FACTUR_A_CLIENTE + "'" +
                   ",'" + cliente.EMPRESA_QUE_FACTURA_A_CLIENTE1 + "'" +
                   ",'" + cliente.EMPRESA_QUE_FACTURA_A_CLIENTE2 + "'" +
                   ",'" + cliente.EMPRESA_QUE_FACTURA_A_CLIENTE3 + "'" +
                   ",'" + cliente.Metodo_Pago + "'" +
                   ",'" + cliente.Observaciones + "'" +
                   ",'" + cliente.Forma_Pago + "'" +
                   "," + cliente.PORCENTAJE_COMISIONISTA + "" +
                    ",'" + cliente.COMISIONISTA2 + "'" +
                    "," + cliente.PORCENTAJE_COMISIONISTA2 + "" +
                    ",'" + cliente.COMISIONISTA3 + "'" +
                    "," + cliente.PORCENTAJE_COMISIONISTA3 + "" +
                    "," + cliente.PORCENTAJE_FACTURA + "" +
                    "," + cliente.PORCENTAJE_FACTURA2 + "" +
                    "," + cliente.PORCENTAJE_FACTURA3 + "" +
                    "," + cliente.PORCENTAJE_FACTURA4 + "" +
                    ",'" + cliente.correoCliente + "')";

                if (insertaCliente.ExecuteNonQuery().Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: InsertaCliente()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool AltaEmpresaCFDI(string ID)
        {
            try
            {
                SqlCommand updateEstatus = N.Conexion.PerformConnection().CreateCommand();
                updateEstatus.CommandText = @"UPDATE [dbo].[EmpresaCatalogoCFDI]
                SET [Estatus] = 'A' WHERE [NumEmpresa] = '" + ID + "'";

                if (updateEstatus.ExecuteNonQuery().Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: AltaEmpresaCFDI()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool AltaEmpresaPago(int ID)
        {
            try
            {
                SqlCommand updateEstatus = N.Conexion.PerformConnection().CreateCommand();
                updateEstatus.CommandText = @"UPDATE [dbo].[EmpresaPagaAsimilados]
                SET [Estatus] = 'A' WHERE [ID] = '" + ID + "'";

                if (updateEstatus.ExecuteNonQuery().Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: AltaEmpresaPago()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool BajaEmpresaCFDI(string ID)
        {
            try
            {
                SqlCommand updateEstatus = N.Conexion.PerformConnection().CreateCommand();
                updateEstatus.CommandText = @"UPDATE [dbo].[EmpresaCatalogoCFDI]
                SET [Estatus] = 'I' WHERE [NumEmpresa] = '" + ID + "'";

                if (updateEstatus.ExecuteNonQuery().Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: BajaEmpresaCFDI()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool BajaEmpresaPago(int ID)
        {
            try
            {
                SqlCommand updateEstatus = N.Conexion.PerformConnection().CreateCommand();
                updateEstatus.CommandText = @"UPDATE [dbo].[EmpresaPagaAsimilados]
                SET [Estatus] = 'I' WHERE [ID] = '" + ID + "'";

                if (updateEstatus.ExecuteNonQuery().Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: BajaEmpresaPago()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool ModificaEmpresaCFDI(List <E.EmpresaCFDI> lista)
        {
            try
            {
                int cont = 0;
                foreach (var item in lista)
                {
                    SqlCommand updateEmpresa = N.Conexion.PerformConnection().CreateCommand();
                    updateEmpresa.CommandText = @"UPDATE [dbo].[EmpresaCatalogoCFDI]
                   SET [NumEmpresa] = '" + item.IDEmpresa + "'" +
                   ",[Descripcion] = '" + item.razonSocial + "'" +
                   "WHERE [NumEmpresa] = '" + item.IDEmpresa + "'";

                    if (updateEmpresa.ExecuteNonQuery().Equals(1))
                    {
                        cont++;
                    }
                }

                if (cont.Equals(lista.Count()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: ModificaEmpresaCFDI()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool ModificaEmpresaPago(List<E.EmpresaPago> lista)
        {
            try
            {
                int cont = 0;
                foreach (var item in lista)
                {
                    SqlCommand updateEmpresa = N.Conexion.PerformConnection().CreateCommand();
                    updateEmpresa.CommandText = @"UPDATE [dbo].[EmpresaPagaAsimilados]
                   SET [IDEmpresa] = '" + item.IDEmpresa + "'" +
                   ",[RFC] = '" + item.RFC + "'" +
                   ",[RazonSocial] = '" + item.RazonSocial + "'" +
                   ",[Estatus] = '" + item.Estatus + "'" +
                   "WHERE [ID] = '" + item.ID + "'";

                    if (updateEmpresa.ExecuteNonQuery().Equals(1))
                    {
                        cont++;
                    }
                }

                if (cont.Equals(lista.Count()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: ModificaEmpresaPago()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool InsertaEmpresaCFDI(E.EmpresaCFDI empresaCFDI)
        {
            try
            {
                SqlCommand insertaEmpresa = N.Conexion.PerformConnection().CreateCommand();
                insertaEmpresa.CommandText = @"INSERT INTO [dbo].[EmpresaCatalogoCFDI]
                ([NumEmpresa]
                ,[Descripcion]
                ,[Estatus])
                 VALUES
                ('" + empresaCFDI.IDEmpresa + "'" +
                ",'" + empresaCFDI.razonSocial + "'" +
                ",'A')";


                if (insertaEmpresa.ExecuteNonQuery().Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: InsertaEmpresaCFDI()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool InsertaEmpresaPago(E.EmpresaPago empresa)
        {
            try
            {
                SqlCommand insertaEmpresa = N.Conexion.PerformConnection().CreateCommand();
                insertaEmpresa.CommandText = @"INSERT INTO [dbo].[EmpresaPagaAsimilados]
                       ([IDEmpresa]
                       ,[RFC]
                       ,[RazonSocial]
                       ,[Estatus])
                 VALUES
                       ('" + empresa.IDEmpresa + "'" +
                       ",'" + empresa.RFC + "'" +
                       ",'" + empresa.RazonSocial + "'" +
                       ",'A')";


                if (insertaEmpresa.ExecuteNonQuery().Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: InsertaEmpresaPago()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void AgregaClienteMasivo(List<E.ClienteAsimilado> lista, SplashScreenManager splashManager)
        {
            try
            {
                foreach (var item in lista)
                {
                    if (item.CLIENTE != "" && item.ID != "")
                    {
                        SqlCommand insertaCliente = N.Conexion.PerformConnection().CreateCommand();
                        insertaCliente.CommandText = @"INSERT INTO [dbo].[ClientesAsimilados]
                   ([ID]
                   ,[CLIENTE]
                   ,[FECHA_ALTA _PRIMER PAGO]
                   ,[COMISIONISTA]
                   ,[PORCENTAJE_ISN]
                   ,[PORCENTAJE_COMISION]
                   ,[TOTAL]
                   ,[FACTURACION_CON IVA _SIN IVA]
                   ,[RETENCION]
                   ,[PORCENTAJE_RETENCION]
                   ,[PERIODO_DE_PAGO]
                   ,[ESTATUS]
                   ,[EJECUTIVO_RESPONSABLE]
                   ,[EMPRESA_PAGADORA_EMITE CFDI]
                   ,[PROVEEDOR]
                   ,[EMPRESA_QUE_FACTUR_A _CLIENTE]
                   ,[EMPRESA_QUE_FACTURA_A_CLIENTE1]
                   ,[EMPRESA_QUE_FACTURA_A_CLIENTE2]
                   ,[EMPRESA_QUE_FACTURA_A_CLIENTE3]
                   ,[Metodo_Pago]
                   ,[Observaciones]
                   ,[Forma_Pago]
                  ,[PORCENTAJE_COMISIONISTA]
                  ,[COMISIONISTA2]
                  ,[PORCENTAJE_COMISIONISTA2]
                  ,[COMISIONISTA3]
                  ,[PORCENTAJE_COMISIONIST3]
                  ,[PORCENTAJE_FACTURA]
                  ,[PORCENTAJE_FACTURA2]
                  ,[PORCENTAJE_FACTURA3]
                  ,[PORCENTAJE_FACTURA4]
                  ,[Correo])
             VALUES
                   ('" + item.ID + "'" +
                           ",'" + item.CLIENTE + "'" +
                           ", GETDATE()" +
                           ",'" + item.COMISIONISTA + "'" +
                           "," + item.PORCENTAJE_ISN + "" +
                           "," + item.PORCENTAJE_COMISION + "" +
                           "," + item.TOTAL + "" +
                           ",'" + item.FACTURACION_CON_IVA_SIN_IVA + "'" +
                           ",'" + item.RETENCION + "'" +
                           "," + item.PORCENTAJE_RETENCION + "" +
                           ",'" + item.PERIODO_DE_PAGO + "'" +
                           ",'" + item.ESTATUS + "'" +
                           ",'" + item.EJECUTIVO_RESPONSABLE + "'" +
                           ",'" + item.EMPRESA_PAGADORA_EMITE_CFDI + "'" +
                           ",'" + item.PROVEEDOR + "'" +
                           ",'" + item.EMPRESA_QUE_FACTUR_A_CLIENTE + "'" +
                           ",'" + item.EMPRESA_QUE_FACTURA_A_CLIENTE1 + "'" +
                           ",'" + item.EMPRESA_QUE_FACTURA_A_CLIENTE2 + "'" +
                           ",'" + item.EMPRESA_QUE_FACTURA_A_CLIENTE3 + "'" +
                           ",'" + item.Metodo_Pago + "'" +
                           ",'" + item.Observaciones + "'" +
                           ",'" + item.Forma_Pago + "'" +
                           "," + item.PORCENTAJE_COMISIONISTA + "" +
                            ",'" + item.COMISIONISTA2 + "'" +
                            "," + item.PORCENTAJE_COMISIONISTA2 + "" +
                            ",'" + item.COMISIONISTA3 + "'" +
                            "," + item.PORCENTAJE_COMISIONISTA3 + "" +
                            "," + item.PORCENTAJE_FACTURA + "" +
                            "," + item.PORCENTAJE_FACTURA2 + "" +
                            "," + item.PORCENTAJE_FACTURA3 + "" +
                            "," + item.PORCENTAJE_FACTURA4 + "" +
                            ",'" + item.correoCliente + "')";
                        insertaCliente.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                if (splashManager.IsSplashFormVisible.Equals(true))
                {
                    splashManager.CloseWaitForm();
                }
                XtraMessageBox.Show(e.Message + "\nError Controlador: AgregaEmpleadoMasivo()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public string GetIDEmpresaCFDI()
        {
            try
            {
                string ID = "";
                SqlCommand getID = N.Conexion.PerformConnection().CreateCommand();
                getID.CommandText = @"SELECT TOP (1) [NumEmpresa]
                ,[Descripcion]
                FROM [dbo].[EmpresaCatalogoCFDI]
                ORDER BY NumEmpresa DESC";

                SqlDataReader readerID;
                readerID = getID.ExecuteReader();

                if (readerID.Read())
                {
                    ID = readerID.GetString(0);
                }
                readerID.Close();
                return ID;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: GetIDEmpresaCFDI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public string GetIDEmpresaPago()
        {
            try
            {
                string ID = "";
                SqlCommand getID = N.Conexion.PerformConnection().CreateCommand();
                getID.CommandText = @"SELECT TOP (1) [IDEmpresa]
                  FROM [dbo].[EmpresaPagaAsimilados]
                  ORDER BY IDEmpresa desc";

                SqlDataReader readerID;
                readerID = getID.ExecuteReader();

                if (readerID.Read())
                {
                    ID = readerID.GetString(0);
                }
                readerID.Close();
                return ID;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: GetIDEmpresaPago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public string GetIDCliente()
        {
            try
            {
                string ID = "";
                SqlCommand getID = N.Conexion.PerformConnection().CreateCommand();
                getID.CommandText = @"SELECT TOP (1) [ID]
                  FROM [dbo].[ClientesAsimilados]
                  ORDER BY ID DESC";

                SqlDataReader readerID;
                readerID = getID.ExecuteReader();

                if (readerID.Read())
                {
                    ID = readerID.GetString(0);
                }
                readerID.Close();
                return ID;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: GetIDCliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void GetBitacora(GridControl grid, string User, string Month, string Year, SplashScreenManager splashScreenManager)
        {
            try
            {
                SqlCommand queryBuscar = N.Conexion.PerformConnection().CreateCommand();
                queryBuscar.CommandText = @"SELECT
                 [Folio]
                ,[UUID]
                ,[StatusSAT]
                ,[FecPago]
                ,[FecIni]
                ,[FecFin]
                ,[Empresa]
                ,[Movimiento]
                ,[FecMov]
                ,[IPMov]
                ,[Usuario]
                ,ISNULL([Origen], '') AS [Origen]
                FROM [dbo].[BitacoraXML]
                WHERE Usuario = @User
                AND MONTH(FecPago) = @Month
                AND YEAR(FecPago) = @Year";
                queryBuscar.Parameters.AddWithValue("@User", User);
                queryBuscar.Parameters.AddWithValue("@Month", Month);
                queryBuscar.Parameters.AddWithValue("@Year", Year);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = queryBuscar;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                grid.DataSource = dataSet.Tables[0];
            }
            catch (Exception e)
            {
                splashScreenManager.CloseWaitForm();
                XtraMessageBox.Show(e.Message + "\n Controller: Buscar12()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ActualizaFolio(string uuid, string status)
        {
            try
            {
                SqlCommand queryUpdate = N.Conexion.PerformConnection().CreateCommand();
                queryUpdate.CommandText = @"UPDATE FolioXML set StatusSAT = '" + status + "' where UUID ='" + uuid + "'";
                queryUpdate.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "Error Controlador: ActualizaFolio()", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string GetNombreUsuario(string usuario)
        {
            try
            {
                string nombre = null;

                N.Conexion.PerformConnectionSoprade().Open();
                SqlCommand queryUser = N.Conexion.PerformConnectionSoprade().CreateCommand();
                queryUser.CommandText = @"select usuaNombre from segUsuarios where usuaIDUsua = @user";
                queryUser.Parameters.AddWithValue("@user", usuario);
                SqlDataReader readerUser;
                readerUser = queryUser.ExecuteReader();

                if (readerUser.Read())
                {
                    nombre = readerUser.GetString(0);
                }
                readerUser.Close();
                N.Conexion.PerformConnectionSoprade().Close();

                return nombre;
            }
            catch (Exception e)
            {
                N.Conexion.PerformConnectionSoprade().Close();
                XtraMessageBox.Show(e.Message + "\nError Controlador: GetNombreUsuario()",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public string GetStatusUsuario(string usuario, string pass)
        {
            try
            {
                string tipoUsua = null;
                N.Conexion.PerformConnection().Open();
                SqlCommand queryTipoUsua = N.Conexion.PerformConnection().CreateCommand();
                D.clsSeguridad seguridad = new D.clsSeguridad();
                string passEncrip = seguridad.EncryptString(pass);
                queryTipoUsua.CommandText = @"select
                usuarioStatus
                from UsuariosSistema
                where usuarioID = @usuario
                and usuarioPass = @pass";
                queryTipoUsua.Parameters.AddWithValue("@usuario", usuario);
                queryTipoUsua.Parameters.AddWithValue("@pass", passEncrip);

                SqlDataReader readerTipo;
                readerTipo = queryTipoUsua.ExecuteReader();

                if (readerTipo.Read())
                {
                    tipoUsua = readerTipo.GetString(0);
                }
                N.Conexion.PerformConnection().Close();
                return tipoUsua;

            } catch (Exception e)
            {
                N.Conexion.PerformConnection().Close();

                XtraMessageBox.Show(e.Message + "\nErro Controlador:GetStatusUsuario()"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public bool GetAdminUsuario(string usuario, string BD, bool listado)
        {
            try
            {
                bool Admin = false;
                string TipoUsua = null;
                N.Conexion.PerformConnection().Close();
                N.Conexion.PerformConnection().Open();
                SqlCommand queryUser = N.Conexion.PerformConnection().CreateCommand();
                //N.Conexion.PerformConnectionSoprade().Open();
                //SqlCommand queryUser = N.Conexion.PerformConnectionSoprade().CreateCommand();
                //queryUser.CommandText = @"select usuaTipUsu from segUsuarios where usuaIDUsua = @user";
                queryUser.CommandText = "select usuarioTipo from UsuariosSistema where usuarioID = @user";
                queryUser.Parameters.AddWithValue("@user", usuario);
                SqlDataReader readerUser;
                readerUser = queryUser.ExecuteReader();

                if (readerUser.Read())
                {
                    TipoUsua = readerUser.GetString(0);
                }
                readerUser.Close();

                if (TipoUsua.Equals("A"))
                {
                    Admin = true;
                }
                else
                {
                    Admin = false;
                }
                //N.Conexion.PerformConnectionSoprade().Close();
                if (listado.Equals(true))
                {
                    N.Conexion.PerformConnection().Close();
                }
                else
                {
                    N.Conexion.PerformConnection().ChangeDatabase(BD);
                }

                return Admin;
            } catch (Exception e)
            {
                N.Conexion.PerformConnectionSoprade().Close();
                XtraMessageBox.Show(e.Message + "\nError Controlador: GetAdminUser()",
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void CancelarCFDI(List<E.CancelarUUID> list, SplashScreenManager splashScreenManager, string rfc, string PAC, string ambiente)
        {
            try
            {
                StreamWriter writerLog = null;
                StringBuilder builder = null;
                string url = @"C:\AsimiladosLogs\";
                if (!Directory.Exists(url))
                {
                    Directory.CreateDirectory(url);
                }
                string NombreArchivo = "Cancelacion_" + Convert.ToString(DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-"
                + DateTime.Now.Year.ToString() + ", " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString()
                + "-" + DateTime.Now.Second.ToString());
                string path = Path.Combine(url, NombreArchivo + ".txt");
                int error = 0, exito = 0;
                builder = new StringBuilder();
                builder.AppendLine();
                builder.Append("********************************   Erroes Encontrados  ******************************************" + "\r\n");
                builder.AppendLine();
                E.BitacoraXML bitacora = new E.BitacoraXML();
                // produccion = false ---> para pruebas
                bool produccion = false;
                string prod_endpoint = "TimbradoEndpoint_PRODUCCION";
                string test_endpoint = "TimbradoEndpoint_TESTING";
                string[] uuid = null;
                int cont = 0;
                string pathCer = ArchivoCER(rfc);
                string pathKey = ArchivoKEY(rfc);
                string pass = PassKey(rfc);
                ServicioTimbradoProduccion.TimbradoPortTypeClient portTypeClient = null;


                if (list.Count() == 0)
                {
                    XtraMessageBox.Show("Por favor, seleccione una celda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //splashScreenManager.ShowWaitForm();
                    try
                    {
                        foreach (var item in list)
                        {
                            if (splashScreenManager.IsSplashFormVisible.Equals(false))
                            {
                                splashScreenManager.ShowWaitForm();
                            }
                            splashScreenManager.SetWaitFormCaption("Cancelando CFDI:\n " + item.UUID);
                            cont++;
                            bitacora.Folio = item.Folio;
                            bitacora.UUID = item.UUID;
                            bitacora.FecPago = item.FecPago;
                            bitacora.FecIni = item.FecInicio;
                            bitacora.FecFin = item.FecFinal;
                            bitacora.Movimiento = "Cancelación";
                            bitacora.FecMovimiento = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"));
                            bitacora.IPMovimiento = item.IPMovimiento;
                            bitacora.Usuario = item.Usuario;
                            bitacora.Empresa = item.Empresa;
                            bitacora.Origen = "CancelarCFDI";
                            bitacora.nominaEmpresaID = Properties.Settings.Default["EmpresaNominaID"].ToString();
                            //C:\DocAsimilados\00001000000413522787.cer
                            //C:\DocAsimilados\CSD_QUERETARO_PTP131002FA0_20190214_113034.key
                            uuid = (new string[] { item.UUID });

                            byte[] bCer = File.ReadAllBytes(pathCer);
                            byte[] bKey = File.ReadAllBytes(pathKey);
                            /* servicio de prueba 
                            * ServicioTimbradoProduccion.CFDICancelacion respuesta = portTypeClient.timbrar("testing@solucionfactible.com", "timbrado.SF.16672", bxml, false);                        */
                            //splashScreenManager1.SetWaitFormCaption(respuesta.mensaje);
                            #region cancelacionNTLINK

                            if (PAC.Equals("NT") && ambiente.Equals("Produccion"))
                            {
                                ServicioTimbradoClient clientProduccion = new ServcioTimbradoNTLINK.ServicioTimbradoClient();
                                //client.Open();
                                clientProduccion.Open();
                                //string xmlLINK = @"https://verificacfdi.facturaelectronica.sat.gob.mx/default.aspx?&amp;id=" + item.UUID + "&amp;re=" + rfc + "&amp;rr=" + item.RFCEmpl + "&amp;tt=" + Math.Round(item.total, 2) + "&amp;fe=" + item.selloCFD;

                                string xmlLINK = @"https://verificacfdi.facturaelectronica.sat.gob.mx/default.aspx?&id=" + item.UUID + "&re=" + rfc + "&rr=" + item.RFCEmpl + "&tt=" + Math.Round(item.total, 2) + "&fe=" + item.selloCFD;

                                string UUIDCFDI = item.UUID;
                                string rfcEmpl = item.RFCEmpl;

                                E.Parametros parametros = GetParametros(rfc);

                                var cancelacion = clientProduccion.CancelaCfdi(parametros.usuarioNtlink, "Inari2020.", UUIDCFDI, rfc, xmlLINK, rfcEmpl);

                                string resultado = cancelacion.ToString();

                                if (resultado.Equals("Error al cancelar el comprobante: ") || resultado.Equals("203 - UUID No corresponde el RFC del emisor y de quien solicita la cancelación."))
                                {
                                    clientProduccion.Close();
                                    error++;
                                    builder.Append("UUID:" + item.UUID + "\r\n");
                                    builder.AppendLine();
                                    builder.Append(resultado);
                                    builder.AppendLine();
                                    builder.AppendLine();
                                }
                                else
                                {
                                    exito++;
                                    var estatusUUID = clientProduccion.ObtenerStatusUuid(parametros.usuarioNtlink, "Inari2020.", item.UUID);
                                    bitacora.StatusSAT = estatusUUID.Status.ToString();
                                    //LogCancelacion(item.UIID, estatusUUID.AcuseCancelacion);
                                    ActualizaFolio(bitacora.UUID, estatusUUID.Status.ToString());
                                    InsertaBitacora(bitacora, splashScreenManager);
                                    LogCancelacion(UUIDCFDI, estatusUUID.AcuseEnvio);
                                    clientProduccion.Close();
                                }
                            }


                            //client.Close();
                            #endregion
                            #region Cancelación Solución
                            //Pruebas
                            if (PAC.Equals("SL"))
                            {
                                ServicioTimbradoProduccion.CFDICancelacion respuesta;
                                if (ambiente.Equals("Pruebas"))
                                {
                                    portTypeClient = (produccion)
    ? new ServicioTimbradoProduccion.TimbradoPortTypeClient(test_endpoint)
    : portTypeClient = new ServicioTimbradoProduccion.TimbradoPortTypeClient(test_endpoint);
                                    respuesta = portTypeClient.cancelar("testing@solucionfactible.com", "timbrado.SF.16672", uuid, bCer, bKey, pass);
                                }
                                else
                                {
                                    produccion = true;
                                    portTypeClient = (produccion)
    ? new ServicioTimbradoProduccion.TimbradoPortTypeClient(prod_endpoint)
    : portTypeClient = new ServicioTimbradoProduccion.TimbradoPortTypeClient(prod_endpoint);
                                    respuesta = portTypeClient.cancelar("facturacion@inteligencialaboral.com", "DFddf.gr6u45Tef", uuid, bCer, bKey, pass);
                                }
                                ServicioTimbradoProduccion.CFDIResultadoCancelacion[] resultados = respuesta.resultados;
                                if (respuesta.status.Equals(200))
                                {
                                    if (resultados[0].status.Equals(200))
                                    {
                                        splashScreenManager.CloseWaitForm();
                                        if (resultados[0].statusUUID.Equals("202"))
                                        {
                                            if (splashScreenManager.IsSplashFormVisible.Equals(true))
                                            {
                                                splashScreenManager.CloseWaitForm();
                                            }
                                            XtraMessageBox.Show(resultados[0].mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else if (resultados[0].statusUUID.Equals("211"))
                                        {
                                            bitacora.StatusSAT = "En Proceso de Cancelación";
                                            ActualizaFolio(bitacora.UUID, "En proceso de Cancelación");
                                            InsertaBitacora(bitacora, splashScreenManager);
                                            if (splashScreenManager.IsSplashFormVisible.Equals(true))
                                            {
                                                splashScreenManager.CloseWaitForm();
                                            }
                                            XtraMessageBox.Show(resultados[0].mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else if (resultados[0].statusUUID.Equals("201"))
                                        {
                                            bitacora.StatusSAT = "Cancelado";
                                            ActualizaFolio(resultados[0].uuid, "Cancelado");
                                            InsertaBitacora(bitacora, splashScreenManager);
                                            LogCancelacion(resultados[0].uuid, resultados[0].mensaje);
                                            if (splashScreenManager.IsSplashFormVisible.Equals(true))
                                            {
                                                splashScreenManager.CloseWaitForm();
                                            }
                                            XtraMessageBox.Show("¡Folio: " + resultados[0].uuid + " Cancelado con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            if (splashScreenManager.IsSplashFormVisible.Equals(true))
                                            {
                                                splashScreenManager.CloseWaitForm();
                                            }
                                            XtraMessageBox.Show(resultados[0].mensaje, "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        if (splashScreenManager.IsSplashFormVisible.Equals(true))
                                        {
                                            splashScreenManager.CloseWaitForm();
                                        }
                                        XtraMessageBox.Show(resultados[0].mensaje, "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    if (splashScreenManager.IsSplashFormVisible.Equals(true))
                                    {
                                        splashScreenManager.CloseWaitForm();
                                    }
                                    //XtraMessageBox.Show(resultados[0].mensaje);
                                    XtraMessageBox.Show(respuesta.mensaje, "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            #endregion
                            if (cont.Equals(list.Count()))
                            {
                                if (splashScreenManager.IsSplashFormVisible.Equals(true))
                                {
                                    splashScreenManager.CloseWaitForm();
                                }
                                //XtraMessageBox.Show("Proceso terminado");
                                //return;
                                if (error > 0)
                                {
                                    try
                                    {
                                        builder.AppendLine();
                                        builder.Append("********************************       Fin Erroes      ******************************************" + "\r\n");
                                        writerLog = new StreamWriter(path, true);
                                        writerLog.Write(builder);
                                        writerLog.Close();

                                        if (splashScreenManager.IsSplashFormVisible.Equals(true))
                                        {
                                            splashScreenManager.CloseWaitForm();
                                        }

                                        XtraMessageBox.Show("¡Cencelación generada con " + error + " errores registrados y "
                                            + exito + " registros con éxito! \n(Presione aceptar para ver errores)", "Mensaje"
                                            , MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        Process proceso = new Process();
                                        proceso.StartInfo.FileName = path;
                                        proceso.Start();
                                        return;
                                    }
                                    catch (Exception feach)
                                    {
                                        if (splashScreenManager.IsSplashFormVisible.Equals(true))
                                        {
                                            splashScreenManager.CloseWaitForm();
                                        }

                                        XtraMessageBox.Show(feach.Message + "\nError controlador: foreach GenxmlMasiv(Generalog)",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    if (splashScreenManager.IsSplashFormVisible.Equals(true))
                                    {
                                        splashScreenManager.CloseWaitForm();
                                    }
                                    XtraMessageBox.Show("¡UUID cancelados con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }


                    }
                    catch (Exception cancelacion)
                    {
                        if (splashScreenManager.IsSplashFormVisible.Equals(true))
                        {
                            splashScreenManager.CloseWaitForm();
                        }
                        XtraMessageBox.Show(cancelacion.Message + "\nCatch Cancelacion", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nCatch Canelarcfdi()", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void LogCancelacion(string UUID, string mensaje)
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
                string NombreArchivo = "Cancelación" + "_" + UUID + "_" + Convert.ToString(DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-"
                + DateTime.Now.Year.ToString() + ", " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString()
                + "-" + DateTime.Now.Second.ToString());
                string path = Path.Combine(url, NombreArchivo + ".txt");

                builder = new StringBuilder();
                builder.AppendLine();
                builder.Append("********************************   Información de Cancelación  ******************************************" + "\r\n");
                builder.AppendLine();
                builder.Append("Folio:" + UUID + "\r\n");
                builder.AppendLine();
                builder.Append(mensaje);
                builder.AppendLine();
                builder.AppendLine();
                builder.Append("********************************       Fin Información         ******************************************" + "\r\n");
                writer = new StreamWriter(path, true);
                writer.Write(builder);
                writer.Close();
                Process proceso = new Process();
                proceso.StartInfo.FileName = path;
                proceso.Start();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: LogTimradoUnitario()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void LogValidaTimbradoUnitario(E.Empleado empleado, string mensaje)
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
                string NombreArchivo = "Validar_Timbrado" + "_" + empleado.Nombre + "_" + Convert.ToString(DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-"
                + DateTime.Now.Year.ToString() + ", " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString()
                + "-" + DateTime.Now.Second.ToString());
                string path = Path.Combine(url, NombreArchivo + ".txt");

                builder = new StringBuilder();
                builder.AppendLine();
                builder.Append("********************************   Erroes Encontrados  ******************************************" + "\r\n");
                builder.AppendLine();
                builder.Append("Nombre del empleado:" + empleado.Nombre + "\r\n");
                builder.AppendLine();
                builder.Append(mensaje);
                builder.AppendLine();
                builder.AppendLine();
                builder.Append("********************************       Fin Erroes      ******************************************" + "\r\n");
                writer = new StreamWriter(path, true);
                writer.Write(builder);
                writer.Close();
                Process proceso = new Process();
                proceso.StartInfo.FileName = path;
                proceso.Start();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: LogTimradoUnitario()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void ValXmlMasivo2(List<E.Empleado> Lista, SplashScreenManager splashScreenManager1, string empresa, string rfc, string ip/*, DateTime FecIniPeriMasiv, DateTime FecFinPeriMasiv, DateTime FecPagoMasiv*/)
        {
            E.Empleado nomiEmpl = new E.Empleado();
            E.Parametros parametros = new E.Parametros();
            string periodicidad = null;
            string pathXml = @"C:\XML\";
            string pathArchivoXML = null;
            string nombreArchivo = null;
            string pathArchivoXMLF = null;
            string folio = null;
            string bd = N.Conexion.PerformConnection().Database;
            int cont = -1, exito = 0, error = 0;
            bool genPDF = false;
            StreamWriter writerLog = null;
            StringBuilder builder = null;
            string url = @"C:\AsimiladosLogs\";
            if (!Directory.Exists(url))
            {
                Directory.CreateDirectory(url);
            }
            string NombreArchivo = "Validar_Timbrado_Masivo_" + Convert.ToString(DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-"
            + DateTime.Now.Year.ToString() + ", " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString()
            + "-" + DateTime.Now.Second.ToString());
            string path = Path.Combine(url, NombreArchivo + ".txt");

            builder = new StringBuilder();
            builder.AppendLine();
            builder.Append("********************************   Erroes Encontrados  ******************************************" + "\r\n");
            builder.AppendLine();


            foreach (var item in Lista)
            {
                cont++;
                //if (cont < Lista.Count())
                //{

                //}

                try
                {
                    if (splashScreenManager1.IsSplashFormVisible.Equals(false))
                    {
                        splashScreenManager1.ShowWaitForm();
                    }
                    nomiEmpl = BuscaEmpleado(item.RFC);
                    nomiEmpl.IngresosBrutos = item.IngresosBrutos;
                    nomiEmpl.ISR = item.ISR;
                    nomiEmpl.IngresosNetos = item.IngresosNetos;
                    splashScreenManager1.SetWaitFormCaption("Validando nomina de: \n" + nomiEmpl.Nombre);

                    parametros = GetParametros(rfc);


                    periodicidad = nomiEmpl.Periodicidad;

                    string fecPago = Convert.ToDateTime(item.fechaAplicacion).ToString("dd-MM-yyyy");
                    pathArchivoXML = Path.Combine(pathXml + fecPago + @"\");

                    if (!Directory.Exists(pathArchivoXML))
                    {
                        Directory.CreateDirectory(pathArchivoXML);
                    }

                    nombreArchivo = fecPago + "_" + nomiEmpl.RFC + "_" + nomiEmpl.Nombre;

                    pathArchivoXML = Path.Combine(pathArchivoXML + nombreArchivo + ".xml");

                    // produccion = false ---> para pruebas
                    bool produccion = false;
                    string prod_endpoint = "TimbradoEndpoint_PRODUCCION";
                    string test_endpoint = "TimbradoEndpoint_TESTING";

                    string pathPrincipalExe = AppDomain.CurrentDomain.BaseDirectory + "/";
                    //string pathCer = @"C:\DocAsimilados\CSD01_AAA010101AAA.cer";
                    //string pathKey = @"C:\DocAsimilados\CSD01_AAA010101AAA.key";
                    //string pass = "12345678a";

                    //string pathCer = @"C:\DocAsimilados\00001000000413522787.cer";
                    //string pathKey = @"C:\DocAsimilados\CSD_QUERETARO_PTP131002FA0_20190214_113034.key";
                    //string pass = "ptpinari";
                    string pathCer = ArchivoCER(rfc);
                    string pathKey = ArchivoKEY(rfc);
                    string pass = PassKey(rfc);

                    string Inicio, Final, Serie, NumCer;

                    SelloDigital.leerCER(pathCer, out Inicio, out Final, out Serie, out NumCer);

                    folio = GetFolio();

                    if (folio.Equals(null) || folio.Equals(""))
                    {
                        splashScreenManager1.CloseWaitForm();
                        XtraMessageBox.Show("¡Folio no encontrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (folio.Equals("0"))
                        {
                            folio = "0001";
                        }
                    }
                    #region comprobanteNomina
                    Comprobante comprobante = new Comprobante();
                    comprobante.Folio = folio;
                    comprobante.Fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    //comprobante.Sello = "faltante";
                    comprobante.FormaPago = "99";
                    comprobante.NoCertificado = NumCer;
                    comprobante.SubTotal = nomiEmpl.IngresosBrutos;
                    comprobante.Descuento = nomiEmpl.ISR;
                    comprobante.Total = nomiEmpl.IngresosNetos; //ingresos netos
                    comprobante.Moneda = "MXN";
                    comprobante.TipoDeComprobante = "N";
                    comprobante.MetodoPago = "PUE";
                    comprobante.LugarExpedicion = parametros.CODIGO_POSTAL;
                    comprobante.TipoCambio = 1;

                    ComprobanteEmisor comprobanteEmisor = new ComprobanteEmisor();
                    comprobanteEmisor.Rfc = rfc;
                    comprobanteEmisor.Nombre = empresa;
                    comprobanteEmisor.RegimenFiscal = "601";

                    ComprobanteReceptor comprobanteReceptor = new ComprobanteReceptor();
                    comprobanteReceptor.Nombre = nomiEmpl.Nombre;
                    comprobanteReceptor.Rfc = nomiEmpl.RFC;
                    comprobanteReceptor.UsoCFDI = "P01";


                    comprobante.Emisor = comprobanteEmisor;
                    comprobante.Receptor = comprobanteReceptor;

                    List<ComprobanteConcepto> listaConceptos = new List<ComprobanteConcepto>();
                    ComprobanteConcepto comprobanteConcepto = new ComprobanteConcepto();
                    comprobanteConcepto.Importe = nomiEmpl.IngresosBrutos;
                    comprobanteConcepto.ValorUnitario = nomiEmpl.IngresosBrutos;
                    comprobanteConcepto.Descuento = nomiEmpl.ISR;
                    comprobanteConcepto.ClaveProdServ = "84111505";
                    comprobanteConcepto.Cantidad = 1;
                    comprobanteConcepto.ClaveUnidad = "ACT";
                    comprobanteConcepto.Descripcion = "Pago de nómina";

                    listaConceptos.Add(comprobanteConcepto);

                    comprobante.Conceptos = listaConceptos.ToArray();
                    NominaReceptor nominaReceptor = new NominaReceptor();

                    Nomina nomina12 = new Nomina();
                    List<Nomina> nominas = new List<Nomina>();
                    nomina12.Version = "1.2";
                    nomina12.FechaPago = item.fechaAplicacion;
                    nomina12.FechaInicialPago = item.fecIniPeri;
                    nomina12.FechaFinalPago = item.fecFinPeri;
                    nomina12.TotalPercepcionesSpecified = true;
                    nomina12.TotalDeduccionesSpecified = true;
                    nomina12.TotalPercepciones = nomiEmpl.IngresosBrutos;
                    nomina12.TotalDeducciones = nomiEmpl.ISR;


                    if (periodicidad.Equals("Semanal") || periodicidad.Equals("02"))
                    {
                        nomina12.NumDiasPagados = 7;
                        nominaReceptor.PeriodicidadPago = "02";
                    }

                    if (periodicidad.Equals("Quincenal") || periodicidad.Equals("04"))
                    {
                        nomina12.NumDiasPagados = 14;
                        nominaReceptor.PeriodicidadPago = "04";
                    }

                    if (periodicidad.Equals("Mensual") || periodicidad.Equals("05"))
                    {
                        nomina12.NumDiasPagados = 30;
                        nominaReceptor.PeriodicidadPago = "05";
                    }

                    nominaReceptor.Curp = nomiEmpl.CURP;
                    nominaReceptor.TipoContrato = nomiEmpl.TipoContrato;
                    nominaReceptor.Sindicalizado = nomiEmpl.Sindicalizado;
                    nominaReceptor.NumEmpleado = nomiEmpl.NumEmpl;
                    nominaReceptor.Departamento = nomiEmpl.Departamento;
                    nominaReceptor.Puesto = nomiEmpl.Puesto;
                    string entFed = GetEntFed(bd, parametros.CODIGO_POSTAL);
                    nominaReceptor.TipoRegimen = nomiEmpl.TipoRegimen;
                    nominaReceptor.ClaveEntFed = entFed;
                    nominaReceptor.SalarioBaseCotApor = 0;

                    NominaDeducciones nominaDeducciones = new NominaDeducciones();
                    NominaDeduccionesDeduccion nominaDeduccionesDeduccion = new NominaDeduccionesDeduccion();
                    NominaPercepciones nominaPercepciones = new NominaPercepciones();
                    NominaPercepcionesPercepcion nominaPercepcionesPercepcion = new NominaPercepcionesPercepcion();

                    nominaPercepciones.TotalSueldos = nomiEmpl.IngresosBrutos;
                    nominaPercepciones.TotalExento = 0;
                    nominaPercepciones.TotalGravado = nomiEmpl.IngresosBrutos;
                    nominaPercepciones.TotalSueldosSpecified = true;
                    nominaPercepciones.TotalSueldos = nomiEmpl.IngresosBrutos;
                    nominaPercepcionesPercepcion.TipoPercepcion = "046";
                    nominaPercepcionesPercepcion.Clave = "046";
                    nominaPercepcionesPercepcion.Concepto = "INGRESO A ASIMILADOS A SALARIO";
                    nominaPercepcionesPercepcion.ImporteGravado = nomiEmpl.IngresosBrutos;
                    nominaPercepcionesPercepcion.ImporteExento = 0;

                    nominaDeducciones.TotalImpuestosRetenidosSpecified = true;
                    nominaDeducciones.TotalImpuestosRetenidos = nomiEmpl.ISR;

                    nominaDeduccionesDeduccion.TipoDeduccion = "002";
                    nominaDeduccionesDeduccion.Clave = "211";
                    nominaDeduccionesDeduccion.Concepto = "ISR";
                    nominaDeduccionesDeduccion.Importe = nomiEmpl.ISR;


                    nomina12.Receptor = nominaReceptor;
                    nomina12.Deducciones = nominaDeducciones;
                    nomina12.Percepciones = nominaPercepciones;
                    nomina12.Percepciones.Percepcion = nominaPercepcionesPercepcion.ToArray();
                    nominaDeducciones.Deduccion = nominaDeduccionesDeduccion.ToArray();


                    nominas.Add(nomina12);
                    //comprobante.Nomina12 = nomina12;
                    comprobante.Complemento = new ComprobanteComplemento[1];
                    comprobante.Complemento[0] = new ComprobanteComplemento();

                    splashScreenManager1.SetWaitFormCaption("Generando XML");

                    XmlDocument nom12 = new XmlDocument();
                    XmlSerializerNamespaces xmlNameSpaceNomi = new XmlSerializerNamespaces();
                    xmlNameSpaceNomi.Add("nomina12", "http://www.sat.gob.mx/nomina12");
                    using (XmlWriter writer = nom12.CreateNavigator().AppendChild())
                    {
                        new XmlSerializer(nomina12.GetType()).Serialize(writer, nomina12, xmlNameSpaceNomi);
                    }
                    comprobante.Complemento[0].Any = new System.Xml.XmlElement[1];
                    comprobante.Complemento[0].Any[0] = nom12.DocumentElement;

                    GenXML(comprobante, pathArchivoXML);

                    string cadenaOrig = "";
                    //string ruta = @"C:\DocAsimilados\xslt\cadenaoriginal_3_3.xslt";
                    string pathCadenaOriginalxslt = pathPrincipalExe + @"xslt\cadenaoriginal_3_3.xslt";
                    System.Xml.Xsl.XslCompiledTransform transformador = new System.Xml.Xsl.XslCompiledTransform(true);
                    transformador.Load(pathCadenaOriginalxslt);

                    using (StringWriter sw = new StringWriter())
                    using (XmlWriter xwo = XmlWriter.Create(sw, transformador.OutputSettings))
                    {

                        //transformador.Transform(pathXml, xwo);
                        transformador.Transform(pathArchivoXML, xwo);
                        cadenaOrig = sw.ToString();
                    }

                    SelloDigital selloDigital = new SelloDigital();
                    comprobante.Certificado = selloDigital.Certificado(pathCer);
                    comprobante.Sello = selloDigital.Sellar(cadenaOrig, pathKey, pass);
                    //Folio.XML = System.IO.File.ReadAllText(pathArchivoXML);
                    GenXML(comprobante, pathArchivoXML);

                    #endregion
                    try
                    {
                        ServicioTimbradoProduccion.TimbradoPortTypeClient portTypeClient = null;
                        portTypeClient = (produccion)
                            ? new ServicioTimbradoProduccion.TimbradoPortTypeClient(test_endpoint)
                            : portTypeClient = new ServicioTimbradoProduccion.TimbradoPortTypeClient(test_endpoint);

                        byte[] bxml = Encoding.UTF8.GetBytes(System.IO.File.ReadAllText(pathArchivoXML));
                        /* servicio de prueba 
                         * ServicioTimbradoProduccion.CFDICertificacion respuesta = portTypeClient.timbrar("testing@solucionfactible.com", "timbrado.SF.16672", bxml, false);
                         */

                        ServicioTimbradoProduccion.CFDICertificacion respuesta = portTypeClient.timbrar("testing@solucionfactible.com", "timbrado.SF.16672", bxml, false);
                        //ServicioTimbradoProduccion.CFDICertificacion respuesta = portTypeClient.timbrar("facturacion@inteligencialaboral.com", "DFddf.gr6u45Tef", bxml, false);
                        //splashScreenManager1.SetWaitFormCaption(respuesta.status.ToString());
                        //splashScreenManager1.SetWaitFormCaption(respuesta.mensaje);
                        ServicioTimbradoProduccion.CFDIResultadoCertificacion[] cFDIResultados = respuesta.resultados;
                        if (respuesta.status.Equals(200))
                        {
                            //XtraMessageBox.Show(cFDIResultados[0].uuid);
                            //XtraMessageBox.Show(cFDIResultados[0].certificadoSAT);
                            //XtraMessageBox.Show(cFDIResultados[0].mensaje);
                            if (cFDIResultados[0].status.Equals(200))
                            {
                                genPDF = false;
                                exito++;
                                System.IO.File.Delete(pathArchivoXML);
                            }
                            else
                            {
                                genPDF = false;
                                error++;
                                builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                                builder.AppendLine();
                                builder.Append(cFDIResultados[0].mensaje);
                                builder.AppendLine();
                                builder.AppendLine();
                                System.IO.File.Delete(pathArchivoXML);
                                if (cont + 1 < Lista.Count())
                                {
                                    builder.Append("*************************************************************************************************");
                                    builder.AppendLine();
                                }
                                //splashScreenManager1.CloseWaitForm();
                                //XtraMessageBox.Show(cFDIResultados[0].mensaje + "\nEmpleado #: " + nomiEmpl.NumEmpl + " (" + nomiEmpl.Nombre + ")"
                                //    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                            {
                                splashScreenManager1.CloseWaitForm();
                            }
                            XtraMessageBox.Show(cFDIResultados[0].mensaje);
                        }
                        //XtraMessageBox.Show(cFDIResultados.ToString());
                        //System.IO.File.WriteAllText(pathXml,);
                    }
                    catch (Exception timbrado)
                    {
                        if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                        {
                            splashScreenManager1.CloseWaitForm();
                        }
                        XtraMessageBox.Show(timbrado.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (genPDF.Equals(true))
                    {
                        splashScreenManager1.SetWaitFormCaption("Generando PDF..");

                        if (LeerXMLModAsim(pathArchivoXML, pathArchivoXMLF, splashScreenManager1).Equals(!true))
                        {
                            XtraMessageBox.Show("Hubo un error al generar archivo pdf", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //splashScreenManager1.CloseWaitForm();
                    //XtraMessageBox.Show("¡Nómina Generada con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception genxml)
                {
                    if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                    {
                        splashScreenManager1.CloseWaitForm();
                    }
                    XtraMessageBox.Show(genxml.Message + "Error controlaor: GenXMLMasiv()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cont + 1 == Lista.Count)
                {
                    //if (exito.Equals(Lista.Count()))
                    //{

                    //}

                    if (error > 0)
                    {
                        try
                        {
                            builder.AppendLine();
                            builder.Append("********************************       Fin Erroes      ******************************************" + "\r\n");
                            writerLog = new StreamWriter(path, true);
                            writerLog.Write(builder);
                            writerLog.Close();

                            splashScreenManager1.CloseWaitForm();

                            XtraMessageBox.Show("¡Validación finalizada con " + error + " errores registrados y "
                                + exito + " registros con éxito! \n(Presione aceptar para ver errores)", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Process proceso = new Process();
                            proceso.StartInfo.FileName = path;
                            proceso.Start();

                            return;
                        }
                        catch (Exception feach)
                        {
                            if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                            {
                                splashScreenManager1.CloseWaitForm();
                            }

                            XtraMessageBox.Show(feach.Message + "\nError controlador: foreach ValxmlMasiv()",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                        {
                            splashScreenManager1.CloseWaitForm();
                        }
                        XtraMessageBox.Show("¡Valdación generada con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        [Obsolete]
        public void ValXmlMasivo(List<E.Empleado> Lista, SplashScreenManager splashScreenManager1, string empresa, string rfc, string ip, DateTime FecIniPeriMasiv, DateTime FecFinPeriMasiv, DateTime FecPagoMasiv)
        {
            E.Empleado nomiEmpl = new E.Empleado();
            E.Parametros parametros = new E.Parametros();
            string periodicidad = null;
            string pathXml = @"C:\XML\";
            string pathArchivoXML = null;
            string nombreArchivo = null;
            string pathArchivoXMLF = null;
            string folio = null;
            string bd = N.Conexion.PerformConnection().Database;
            int cont = -1, exito = 0, error = 0;
            bool genPDF = false;
            StreamWriter writerLog = null;
            StringBuilder builder = null;
            string url = @"C:\AsimiladosLogs\";
            if (!Directory.Exists(url))
            {
                Directory.CreateDirectory(url);
            }
            string NombreArchivo = "Validar_Timbrado_Masivo_" + FecPagoMasiv.ToString("dd-mm-yyyy") + "_" + Convert.ToString(DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-"
            + DateTime.Now.Year.ToString() + ", " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString()
            + "-" + DateTime.Now.Second.ToString());
            string path = Path.Combine(url, NombreArchivo + ".txt");

            builder = new StringBuilder();
            builder.AppendLine();
            builder.Append("********************************   Erroes Encontrados  ******************************************" + "\r\n");
            builder.AppendLine();


            foreach (var item in Lista)
            {
                cont++;
                //if (cont < Lista.Count())
                //{

                //}

                try
                {
                    if (splashScreenManager1.IsSplashFormVisible.Equals(false))
                    {
                        splashScreenManager1.ShowWaitForm();
                    }
                    nomiEmpl = BuscaEmpleado(item.RFC);
                    nomiEmpl.IngresosBrutos = item.IngresosBrutos;
                    nomiEmpl.ISR = item.ISR;
                    nomiEmpl.IngresosNetos = item.IngresosNetos;
                    splashScreenManager1.SetWaitFormCaption("Validando nomina de: \n" + nomiEmpl.Nombre);

                    parametros = GetParametros(rfc);


                    periodicidad = nomiEmpl.Periodicidad;

                    string fecPago = Convert.ToDateTime(FecPagoMasiv).ToString("dd-MM-yyyy");
                    pathArchivoXML = Path.Combine(pathXml + fecPago + @"\");

                    if (!Directory.Exists(pathArchivoXML))
                    {
                        Directory.CreateDirectory(pathArchivoXML);
                    }

                    nombreArchivo = fecPago + "_" + nomiEmpl.RFC + "_" + nomiEmpl.Nombre;

                    pathArchivoXML = Path.Combine(pathArchivoXML + nombreArchivo + ".xml");

                    // produccion = false ---> para pruebas
                    bool produccion = false;
                    string prod_endpoint = "TimbradoEndpoint_PRODUCCION";
                    string test_endpoint = "TimbradoEndpoint_TESTING";

                    string pathPrincipalExe = AppDomain.CurrentDomain.BaseDirectory + "/";
                    //string pathCer = @"C:\DocAsimilados\CSD01_AAA010101AAA.cer";
                    //string pathKey = @"C:\DocAsimilados\CSD01_AAA010101AAA.key";
                    //string pass = "12345678a";

                    //string pathCer = @"C:\DocAsimilados\00001000000413522787.cer";
                    //string pathKey = @"C:\DocAsimilados\CSD_QUERETARO_PTP131002FA0_20190214_113034.key";
                    //string pass = "ptpinari";
                    string pathCer = ArchivoCER(rfc);
                    string pathKey = ArchivoKEY(rfc);
                    string pass = PassKey(rfc);

                    string Inicio, Final, Serie, NumCer;

                    SelloDigital.leerCER(pathCer, out Inicio, out Final, out Serie, out NumCer);

                    folio = GetFolio();

                    if (folio.Equals(null) || folio.Equals(""))
                    {
                        splashScreenManager1.CloseWaitForm();
                        XtraMessageBox.Show("¡Folio no encontrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (folio.Equals("0"))
                        {
                            folio = "0001";
                        }
                    }
                    #region comprobanteNomina
                    Comprobante comprobante = new Comprobante();
                    comprobante.Folio = folio;
                    comprobante.Fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    //comprobante.Sello = "faltante";
                    comprobante.FormaPago = "99";
                    comprobante.NoCertificado = NumCer;
                    comprobante.SubTotal = nomiEmpl.IngresosBrutos;
                    comprobante.Descuento = nomiEmpl.ISR;
                    comprobante.Total = nomiEmpl.IngresosNetos; //ingresos netos
                    comprobante.Moneda = "MXN";
                    comprobante.TipoDeComprobante = "N";
                    comprobante.MetodoPago = "PUE";
                    comprobante.LugarExpedicion = parametros.CODIGO_POSTAL;
                    comprobante.TipoCambio = 1;

                    ComprobanteEmisor comprobanteEmisor = new ComprobanteEmisor();
                    comprobanteEmisor.Rfc = rfc;
                    comprobanteEmisor.Nombre = empresa;
                    comprobanteEmisor.RegimenFiscal = "601";

                    ComprobanteReceptor comprobanteReceptor = new ComprobanteReceptor();
                    comprobanteReceptor.Nombre = nomiEmpl.Nombre;
                    comprobanteReceptor.Rfc = nomiEmpl.RFC;
                    comprobanteReceptor.UsoCFDI = "P01";


                    comprobante.Emisor = comprobanteEmisor;
                    comprobante.Receptor = comprobanteReceptor;

                    List<ComprobanteConcepto> listaConceptos = new List<ComprobanteConcepto>();
                    ComprobanteConcepto comprobanteConcepto = new ComprobanteConcepto();
                    comprobanteConcepto.Importe = nomiEmpl.IngresosBrutos;
                    comprobanteConcepto.ValorUnitario = nomiEmpl.IngresosBrutos;
                    comprobanteConcepto.Descuento = nomiEmpl.ISR;
                    comprobanteConcepto.ClaveProdServ = "84111505";
                    comprobanteConcepto.Cantidad = 1;
                    comprobanteConcepto.ClaveUnidad = "ACT";
                    comprobanteConcepto.Descripcion = "Pago de nómina";

                    listaConceptos.Add(comprobanteConcepto);

                    comprobante.Conceptos = listaConceptos.ToArray();
                    NominaReceptor nominaReceptor = new NominaReceptor();

                    Nomina nomina12 = new Nomina();
                    List<Nomina> nominas = new List<Nomina>();
                    nomina12.Version = "1.2";
                    nomina12.FechaPago = FecPagoMasiv;
                    nomina12.FechaInicialPago = FecIniPeriMasiv;
                    nomina12.FechaFinalPago = FecFinPeriMasiv;
                    nomina12.TotalPercepcionesSpecified = true;
                    nomina12.TotalDeduccionesSpecified = true;
                    nomina12.TotalPercepciones = nomiEmpl.IngresosBrutos;
                    nomina12.TotalDeducciones = nomiEmpl.ISR;


                    if (periodicidad.Equals("Semanal") || periodicidad.Equals("02"))
                    {
                        nomina12.NumDiasPagados = 7;
                        nominaReceptor.PeriodicidadPago = "02";
                    }

                    if (periodicidad.Equals("Quincenal") || periodicidad.Equals("04"))
                    {
                        nomina12.NumDiasPagados = 14;
                        nominaReceptor.PeriodicidadPago = "04";
                    }

                    if (periodicidad.Equals("Mensual") || periodicidad.Equals("05"))
                    {
                        nomina12.NumDiasPagados = 30;
                        nominaReceptor.PeriodicidadPago = "05";
                    }

                    nominaReceptor.Curp = nomiEmpl.CURP;
                    nominaReceptor.TipoContrato = nomiEmpl.TipoContrato;
                    nominaReceptor.Sindicalizado = nomiEmpl.Sindicalizado;
                    nominaReceptor.NumEmpleado = nomiEmpl.NumEmpl;
                    nominaReceptor.Departamento = nomiEmpl.Departamento;
                    nominaReceptor.Puesto = nomiEmpl.Puesto;
                    string entFed = GetEntFed(bd, parametros.CODIGO_POSTAL);
                    nominaReceptor.TipoRegimen = nomiEmpl.TipoRegimen;
                    nominaReceptor.ClaveEntFed = entFed;
                    nominaReceptor.SalarioBaseCotApor = 0;

                    NominaDeducciones nominaDeducciones = new NominaDeducciones();
                    NominaDeduccionesDeduccion nominaDeduccionesDeduccion = new NominaDeduccionesDeduccion();
                    NominaPercepciones nominaPercepciones = new NominaPercepciones();
                    NominaPercepcionesPercepcion nominaPercepcionesPercepcion = new NominaPercepcionesPercepcion();

                    nominaPercepciones.TotalSueldos = nomiEmpl.IngresosBrutos;
                    nominaPercepciones.TotalExento = 0;
                    nominaPercepciones.TotalGravado = nomiEmpl.IngresosBrutos;
                    nominaPercepciones.TotalSueldosSpecified = true;
                    nominaPercepciones.TotalSueldos = nomiEmpl.IngresosBrutos;
                    nominaPercepcionesPercepcion.TipoPercepcion = "046";
                    nominaPercepcionesPercepcion.Clave = "046";
                    nominaPercepcionesPercepcion.Concepto = "INGRESO A ASIMILADOS A SALARIO";
                    nominaPercepcionesPercepcion.ImporteGravado = nomiEmpl.IngresosBrutos;
                    nominaPercepcionesPercepcion.ImporteExento = 0;

                    nominaDeducciones.TotalImpuestosRetenidosSpecified = true;
                    nominaDeducciones.TotalImpuestosRetenidos = nomiEmpl.ISR;

                    nominaDeduccionesDeduccion.TipoDeduccion = "002";
                    nominaDeduccionesDeduccion.Clave = "211";
                    nominaDeduccionesDeduccion.Concepto = "ISR";
                    nominaDeduccionesDeduccion.Importe = nomiEmpl.ISR;


                    nomina12.Receptor = nominaReceptor;
                    nomina12.Deducciones = nominaDeducciones;
                    nomina12.Percepciones = nominaPercepciones;
                    nomina12.Percepciones.Percepcion = nominaPercepcionesPercepcion.ToArray();
                    nominaDeducciones.Deduccion = nominaDeduccionesDeduccion.ToArray();


                    nominas.Add(nomina12);
                    //comprobante.Nomina12 = nomina12;
                    comprobante.Complemento = new ComprobanteComplemento[1];
                    comprobante.Complemento[0] = new ComprobanteComplemento();

                    splashScreenManager1.SetWaitFormCaption("Generando XML");

                    XmlDocument nom12 = new XmlDocument();
                    XmlSerializerNamespaces xmlNameSpaceNomi = new XmlSerializerNamespaces();
                    xmlNameSpaceNomi.Add("nomina12", "http://www.sat.gob.mx/nomina12");
                    using (XmlWriter writer = nom12.CreateNavigator().AppendChild())
                    {
                        new XmlSerializer(nomina12.GetType()).Serialize(writer, nomina12, xmlNameSpaceNomi);
                    }
                    comprobante.Complemento[0].Any = new System.Xml.XmlElement[1];
                    comprobante.Complemento[0].Any[0] = nom12.DocumentElement;

                    GenXML(comprobante, pathArchivoXML);

                    string cadenaOrig = "";
                    //string ruta = @"C:\DocAsimilados\xslt\cadenaoriginal_3_3.xslt";
                    string pathCadenaOriginalxslt = pathPrincipalExe + @"xslt\cadenaoriginal_3_3.xslt";
                    System.Xml.Xsl.XslCompiledTransform transformador = new System.Xml.Xsl.XslCompiledTransform(true);
                    transformador.Load(pathCadenaOriginalxslt);

                    using (StringWriter sw = new StringWriter())
                    using (XmlWriter xwo = XmlWriter.Create(sw, transformador.OutputSettings))
                    {

                        //transformador.Transform(pathXml, xwo);
                        transformador.Transform(pathArchivoXML, xwo);
                        cadenaOrig = sw.ToString();
                    }

                    SelloDigital selloDigital = new SelloDigital();
                    comprobante.Certificado = selloDigital.Certificado(pathCer);
                    comprobante.Sello = selloDigital.Sellar(cadenaOrig, pathKey, pass);
                    //Folio.XML = System.IO.File.ReadAllText(pathArchivoXML);
                    GenXML(comprobante, pathArchivoXML);

                    #endregion
                    try
                    {
                        //ServicioTimbradoClient client = new ServicioTimbradoClient();                        
                        //client.Open();                        
                        //string xmlLINK = Convert.ToString(System.IO.File.ReadAllText(pathArchivoXML));
                        ////var empersas = client.ObtenerEmpresas("jordyespejel7@gmail.com", "Asimilados2020");
                        //var newXML = client.TimbraCfdiQr("jordyespejel7@gmail.com", "Asimilados2020", xmlLINK);
                        ////string newXML = client.TimbraCfdi("jordyespejel7@gmail.com", "Asimilados2020", xmlLINK);

                        //client.Close();

                        ServicioTimbradoProduccion.TimbradoPortTypeClient portTypeClient = null;
                        portTypeClient = (produccion)
                            ? new ServicioTimbradoProduccion.TimbradoPortTypeClient(prod_endpoint)
                            : portTypeClient = new ServicioTimbradoProduccion.TimbradoPortTypeClient(test_endpoint);

                        byte[] bxml = Encoding.UTF8.GetBytes(System.IO.File.ReadAllText(pathArchivoXML));

                        /* servicio de prueba 
                         * ServicioTimbradoProduccion.CFDICertificacion respuesta = portTypeClient.timbrar("testing@solucionfactible.com", "timbrado.SF.16672", bxml, false);
                         */

                        ServicioTimbradoProduccion.CFDICertificacion respuesta = portTypeClient.timbrar("testing@solucionfactible.com", "timbrado.SF.16672", bxml, false);
                        //ServicioTimbradoProduccion.CFDICertificacion respuesta = portTypeClient.timbrar("facturacion@inteligencialaboral.com", "DFddf.gr6u45Tef", bxml, false);                        //splashScreenManager1.SetWaitFormCaption(respuesta.status.ToString());
                        //splashScreenManager1.SetWaitFormCaption(respuesta.mensaje);
                        ServicioTimbradoProduccion.CFDIResultadoCertificacion[] cFDIResultados = respuesta.resultados;
                        if (respuesta.status.Equals(200))
                        {
                            //XtraMessageBox.Show(cFDIResultados[0].uuid);
                            //XtraMessageBox.Show(cFDIResultados[0].certificadoSAT);
                            //XtraMessageBox.Show(cFDIResultados[0].mensaje);
                            if (cFDIResultados[0].status.Equals(200))
                            {
                                genPDF = false;
                                exito++;
                                System.IO.File.Delete(pathArchivoXML);
                            }
                            else
                            {
                                genPDF = false;
                                error++;
                                builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                                builder.AppendLine();
                                builder.Append(cFDIResultados[0].mensaje);
                                builder.AppendLine();
                                builder.AppendLine();
                                System.IO.File.Delete(pathArchivoXML);
                                if (cont + 1 < Lista.Count())
                                {
                                    builder.Append("*************************************************************************************************");
                                    builder.AppendLine();
                                }
                                //splashScreenManager1.CloseWaitForm();
                                //XtraMessageBox.Show(cFDIResultados[0].mensaje + "\nEmpleado #: " + nomiEmpl.NumEmpl + " (" + nomiEmpl.Nombre + ")"
                                //    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                            {
                                splashScreenManager1.CloseWaitForm();
                            }
                            XtraMessageBox.Show(cFDIResultados[0].mensaje);
                        }
                        //XtraMessageBox.Show(cFDIResultados.ToString());
                        //System.IO.File.WriteAllText(pathXml,);
                    }
                    catch (Exception timbrado)
                    {
                        if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                        {
                            splashScreenManager1.CloseWaitForm();
                        }
                        XtraMessageBox.Show(timbrado.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (genPDF.Equals(true))
                    {
                        splashScreenManager1.SetWaitFormCaption("Generando PDF..");

                        if (LeerXMLModAsim(pathArchivoXML, pathArchivoXMLF, splashScreenManager1).Equals(!true))
                        {
                            XtraMessageBox.Show("Hubo un error al generar archivo pdf", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //splashScreenManager1.CloseWaitForm();
                    //XtraMessageBox.Show("¡Nómina Generada con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception genxml)
                {
                    if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                    {
                        splashScreenManager1.CloseWaitForm();
                    }
                    XtraMessageBox.Show(genxml.Message + "Error controlaor: GenXMLMasiv()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cont + 1 == Lista.Count)
                {
                    //if (exito.Equals(Lista.Count()))
                    //{

                    //}

                    if (error > 0)
                    {
                        try
                        {
                            builder.AppendLine();
                            builder.Append("********************************       Fin Erroes      ******************************************" + "\r\n");
                            writerLog = new StreamWriter(path, true);
                            writerLog.Write(builder);
                            writerLog.Close();

                            splashScreenManager1.CloseWaitForm();

                            XtraMessageBox.Show("¡Validación finalizada con " + error + " errores registrados y "
                                + exito + " registros con éxito! \n(Presione aceptar para ver errores)", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Process proceso = new Process();
                            proceso.StartInfo.FileName = path;
                            proceso.Start();

                            return;
                        }
                        catch (Exception feach)
                        {
                            if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                            {
                                splashScreenManager1.CloseWaitForm();
                            }

                            XtraMessageBox.Show(feach.Message + "\nError controlador: foreach ValxmlMasiv()",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                        {
                            splashScreenManager1.CloseWaitForm();
                        }
                        XtraMessageBox.Show("¡Nóminas generadas con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        [Obsolete]
        public void GenXmlMasivo2(List<E.Empleado> Lista, SplashScreenManager splashScreenManager1, string empresa, string rfc, string ip, string destino, bool enviaCorreo, string PAC, string ambiente/*, DateTime FecIniPeriMasiv, DateTime FecFinPeriMasiv, DateTime FecPagoMasi*/)
        {
            List<string> archivos = new List<string>();
            string fecPago = "";
            string resultCorreo;
            E.Empleado nomiEmpl = new E.Empleado();
            E.FolioXML Folio = new E.FolioXML();
            E.BitacoraXML Bitacora = new E.BitacoraXML();
            E.Parametros parametros = new E.Parametros();
            E.ClienteAsimilado clienteAsimilado = new E.ClienteAsimilado();
            string periodicidad = null;
            string pathXml = @"C:\XML\";
            string pathArchivoXML = null;
            string nombreArchivo = null;
            string pathArchivoXMLF = null;
            string folio = null;
            string bd = N.Conexion.PerformConnection().Database;
            int cont = -1, exito = 0, error = 0;
            bool genPDF = false;
            StreamWriter writerLog = null;
            StringBuilder builder = null;
            string estatusLayout = "";
            string url = @"C:\AsimiladosLogs\";
            if (!Directory.Exists(url))
            {
                Directory.CreateDirectory(url);
            }
            string NombreArchivo = "Timbrado_Masivo_" + Convert.ToString(DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-"
            + DateTime.Now.Year.ToString() + ", " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString()
            + "-" + DateTime.Now.Second.ToString());
            string path = Path.Combine(url, NombreArchivo + ".txt");

            builder = new StringBuilder();
            builder.AppendLine();
            builder.Append("********************************   Erroes Encontrados  ******************************************" + "\r\n");
            builder.AppendLine();

            //inicia foreach
            foreach (var item in Lista)
            {
                cont++;
                //if (cont < Lista.Count())
                //{

                //}

                try
                {
                    if (splashScreenManager1.IsSplashFormVisible.Equals(false))
                    {
                        splashScreenManager1.ShowWaitForm();
                    }
                    clienteAsimilado = GetInfoCliente(item.idEmpresa);
                    nomiEmpl = BuscaEmpleado(item.RFC);
                    nomiEmpl.IngresosBrutos = item.IngresosBrutos;
                    nomiEmpl.ISR = item.ISR;
                    nomiEmpl.IngresosNetos = item.IngresosNetos;
                    splashScreenManager1.SetWaitFormCaption("Generando nomina de: \n" + nomiEmpl.Nombre);

                    parametros = GetParametros(rfc);


                    periodicidad = nomiEmpl.Periodicidad;

                    Folio.Empleado = nomiEmpl.Nombre;
                    Folio.RFC = nomiEmpl.RFC;
                    Folio.Empresa = empresa;
                    Folio.FecIni = item.fecIniPeri;
                    Folio.FecFin = item.fecFinPeri;
                    Folio.FecPago = item.fechaAplicacion;
                    Folio.Importe = nomiEmpl.IngresosBrutos;
                    Folio.total = item.IngresosNetos;
                    Folio.nominaEmpresaID = Properties.Settings.Default["EmpresaNominaID"].ToString();
                    Bitacora.IPMovimiento = ip;
                    Bitacora.Empresa = empresa;
                    Bitacora.FecPago = item.fechaAplicacion;
                    //Folio.FecPago = Convert.ToDateTime(FecPagoUni.EditValue.ToString());
                    Bitacora.FecIni = item.fecIniPeri;
                    Bitacora.FecFin = item.fecFinPeri;
                    Bitacora.FecMovimiento = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"));
                    Bitacora.Movimiento = "Timbrado";
                    Bitacora.Origen = "Nomina";
                    Bitacora.nominaEmpresaID = Properties.Settings.Default["EmpresaNominaID"].ToString();

                    fecPago = Convert.ToDateTime(item.fechaAplicacion).ToString("dd-MM-yyyy");
                    pathArchivoXML = Path.Combine(pathXml + fecPago + @"\");

                    if (destino.Equals("Cliente"))
                    {
                        pathArchivoXML = Path.Combine(pathXml + clienteAsimilado.CLIENTE.Replace(" ", string.Empty) + "_" + fecPago + @"\");
                    } else if (destino.Equals("Empleado"))
                    {
                        pathArchivoXML = Path.Combine(pathXml + clienteAsimilado.CLIENTE.Replace(" ", string.Empty) + "_" + nomiEmpl.Nombre.Replace(" ", string.Empty) + "_" + fecPago + @"\");
                    }

                    if (!Directory.Exists(pathArchivoXML))
                    {
                        Directory.CreateDirectory(pathArchivoXML);
                    }

                    nombreArchivo = fecPago + "_" + nomiEmpl.RFC + "_" + nomiEmpl.Nombre;

                    pathArchivoXML = Path.Combine(pathArchivoXML + nombreArchivo + ".xml");

                    //produccion = false--->para pruebas
                    bool produccion = false;
                    if (PAC.Equals("SL") && ambiente.Equals("Pruebas"))
                    {
                        produccion = false;
                    }
                    else if (PAC.Equals("SL") && ambiente.Equals("Produccion"))
                    {
                        produccion = true;
                    }
                    string prod_endpoint = "TimbradoEndpoint_PRODUCCION";
                    string test_endpoint = "TimbradoEndpoint_TESTING";

                    string pathPrincipalExe = AppDomain.CurrentDomain.BaseDirectory + "/";
                    //string pathCer = @"C:\DocAsimilados\CSD01_AAA010101AAA.cer";
                    //string pathKey = @"C:\DocAsimilados\CSD01_AAA010101AAA.key";
                    //string pass = "12345678a";

                    //string pathCer = @"C:\DocAsimilados\00001000000413522787.cer";
                    //string pathKey = @"C:\DocAsimilados\CSD_QUERETARO_PTP131002FA0_20190214_113034.key";
                    //string pass = "ptpinari";
                    string pathCer = ArchivoCER(rfc);
                    string pathKey = ArchivoKEY(rfc);
                    string pass = PassKey(rfc);
                    //string estatusLayout = "";

                    string Inicio, Final, Serie, NumCer;

                    SelloDigital.leerCER(pathCer, out Inicio, out Final, out Serie, out NumCer);

                    folio = GetFolio();

                    if (folio.Equals(null) || folio.Equals(""))
                    {
                        splashScreenManager1.CloseWaitForm();
                        XtraMessageBox.Show("¡Folio no encontrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (folio.Equals("0"))
                        {
                            folio = "0001";
                        }
                        Bitacora.Folio = folio;
                        Folio.Folio = folio;
                    }
                    #region comprobanteNomina
                    Comprobante comprobante = new Comprobante();
                    comprobante.Folio = folio;
                    comprobante.Fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    //comprobante.Sello = "faltante";
                    comprobante.FormaPago = "99";
                    comprobante.NoCertificado = NumCer;
                    comprobante.SubTotal = nomiEmpl.IngresosBrutos;
                    comprobante.Descuento = nomiEmpl.ISR;
                    comprobante.Total = nomiEmpl.IngresosNetos; //ingresos netos
                    comprobante.Moneda = "MXN";
                    comprobante.TipoDeComprobante = "N";
                    comprobante.MetodoPago = "PUE";
                    comprobante.LugarExpedicion = parametros.CODIGO_POSTAL;
                    comprobante.TipoCambio = 1;

                    ComprobanteEmisor comprobanteEmisor = new ComprobanteEmisor();
                    comprobanteEmisor.Rfc = rfc;
                    comprobanteEmisor.Nombre = empresa;
                    comprobanteEmisor.RegimenFiscal = "601";

                    ComprobanteReceptor comprobanteReceptor = new ComprobanteReceptor();
                    comprobanteReceptor.Nombre = nomiEmpl.Nombre;
                    comprobanteReceptor.Rfc = nomiEmpl.RFC;
                    comprobanteReceptor.UsoCFDI = "P01";


                    comprobante.Emisor = comprobanteEmisor;
                    comprobante.Receptor = comprobanteReceptor;

                    List<ComprobanteConcepto> listaConceptos = new List<ComprobanteConcepto>();
                    ComprobanteConcepto comprobanteConcepto = new ComprobanteConcepto();
                    comprobanteConcepto.Importe = nomiEmpl.IngresosBrutos;
                    comprobanteConcepto.ValorUnitario = nomiEmpl.IngresosBrutos;
                    comprobanteConcepto.Descuento = nomiEmpl.ISR;
                    comprobanteConcepto.ClaveProdServ = "84111505";
                    comprobanteConcepto.Cantidad = 1;
                    comprobanteConcepto.ClaveUnidad = "ACT";
                    comprobanteConcepto.Descripcion = "Pago de nómina";

                    listaConceptos.Add(comprobanteConcepto);

                    comprobante.Conceptos = listaConceptos.ToArray();
                    NominaReceptor nominaReceptor = new NominaReceptor();

                    Nomina nomina12 = new Nomina();
                    List<Nomina> nominas = new List<Nomina>();
                    nomina12.Version = "1.2";
                    nomina12.FechaPago = item.fechaAplicacion;
                    nomina12.FechaInicialPago = item.fecIniPeri;
                    nomina12.FechaFinalPago = item.fecFinPeri;
                    nomina12.TotalPercepcionesSpecified = true;
                    nomina12.TotalDeduccionesSpecified = true;
                    nomina12.TotalPercepciones = nomiEmpl.IngresosBrutos;
                    nomina12.TotalDeducciones = nomiEmpl.ISR;


                    if (periodicidad.Equals("Semanal") || periodicidad.Equals("02"))
                    {
                        nomina12.NumDiasPagados = 7;
                        nominaReceptor.PeriodicidadPago = "02";
                    }

                    if (periodicidad.Equals("Quincenal") || periodicidad.Equals("04"))
                    {
                        nomina12.NumDiasPagados = 14;
                        nominaReceptor.PeriodicidadPago = "04";
                    }

                    if (periodicidad.Equals("Mensual") || periodicidad.Equals("05"))
                    {
                        nomina12.NumDiasPagados = 30;
                        nominaReceptor.PeriodicidadPago = "05";
                    }

                    nominaReceptor.Curp = nomiEmpl.CURP;
                    nominaReceptor.TipoContrato = nomiEmpl.TipoContrato;
                    nominaReceptor.Sindicalizado = nomiEmpl.Sindicalizado;
                    nominaReceptor.NumEmpleado = nomiEmpl.NumEmpl;
                    nominaReceptor.Departamento = nomiEmpl.Departamento;
                    nominaReceptor.Puesto = nomiEmpl.Puesto;
                    string entFed = GetEntFed(bd, parametros.CODIGO_POSTAL);
                    nominaReceptor.TipoRegimen = nomiEmpl.TipoRegimen;
                    nominaReceptor.ClaveEntFed = entFed;
                    nominaReceptor.SalarioBaseCotApor = 0;

                    NominaDeducciones nominaDeducciones = new NominaDeducciones();
                    NominaDeduccionesDeduccion nominaDeduccionesDeduccion = new NominaDeduccionesDeduccion();
                    NominaPercepciones nominaPercepciones = new NominaPercepciones();
                    NominaPercepcionesPercepcion nominaPercepcionesPercepcion = new NominaPercepcionesPercepcion();

                    nominaPercepciones.TotalSueldos = nomiEmpl.IngresosBrutos;
                    nominaPercepciones.TotalExento = 0;
                    nominaPercepciones.TotalGravado = nomiEmpl.IngresosBrutos;
                    nominaPercepciones.TotalSueldosSpecified = true;
                    nominaPercepciones.TotalSueldos = nomiEmpl.IngresosBrutos;
                    nominaPercepcionesPercepcion.TipoPercepcion = "046";
                    nominaPercepcionesPercepcion.Clave = "046";
                    nominaPercepcionesPercepcion.Concepto = "INGRESO A ASIMILADOS A SALARIO";
                    nominaPercepcionesPercepcion.ImporteGravado = nomiEmpl.IngresosBrutos;
                    nominaPercepcionesPercepcion.ImporteExento = 0;

                    nominaDeducciones.TotalImpuestosRetenidosSpecified = true;
                    nominaDeducciones.TotalImpuestosRetenidos = nomiEmpl.ISR;

                    nominaDeduccionesDeduccion.TipoDeduccion = "002";
                    nominaDeduccionesDeduccion.Clave = "211";
                    nominaDeduccionesDeduccion.Concepto = "ISR";
                    nominaDeduccionesDeduccion.Importe = nomiEmpl.ISR;


                    nomina12.Receptor = nominaReceptor;
                    nomina12.Deducciones = nominaDeducciones;
                    nomina12.Percepciones = nominaPercepciones;
                    nomina12.Percepciones.Percepcion = nominaPercepcionesPercepcion.ToArray();
                    nominaDeducciones.Deduccion = nominaDeduccionesDeduccion.ToArray();


                    nominas.Add(nomina12);
                    //comprobante.Nomina12 = nomina12;
                    comprobante.Complemento = new ComprobanteComplemento[1];
                    comprobante.Complemento[0] = new ComprobanteComplemento();

                    splashScreenManager1.SetWaitFormCaption("Generando XML");

                    XmlDocument nom12 = new XmlDocument();
                    XmlSerializerNamespaces xmlNameSpaceNomi = new XmlSerializerNamespaces();
                    xmlNameSpaceNomi.Add("nomina12", "http://www.sat.gob.mx/nomina12");
                    using (XmlWriter writer = nom12.CreateNavigator().AppendChild())
                    {
                        new XmlSerializer(nomina12.GetType()).Serialize(writer, nomina12, xmlNameSpaceNomi);
                    }
                    comprobante.Complemento[0].Any = new System.Xml.XmlElement[1];
                    comprobante.Complemento[0].Any[0] = nom12.DocumentElement;

                    GenXML(comprobante, pathArchivoXML);

                    string cadenaOrig = "";
                    //string ruta = @"C:\DocAsimilados\xslt\cadenaoriginal_3_3.xslt";
                    string pathCadenaOriginalxslt = pathPrincipalExe + @"xslt\cadenaoriginal_3_3.xslt";
                    System.Xml.Xsl.XslCompiledTransform transformador = new System.Xml.Xsl.XslCompiledTransform(true);
                    transformador.Load(pathCadenaOriginalxslt);

                    using (StringWriter sw = new StringWriter())
                    using (XmlWriter xwo = XmlWriter.Create(sw, transformador.OutputSettings))
                    {

                        //transformador.Transform(pathXml, xwo);
                        transformador.Transform(pathArchivoXML, xwo);
                        cadenaOrig = sw.ToString();
                    }

                    SelloDigital selloDigital = new SelloDigital();
                    comprobante.Certificado = selloDigital.Certificado(pathCer);
                    comprobante.Sello = selloDigital.Sellar(cadenaOrig, pathKey, pass);
                    //Folio.XML = System.IO.File.ReadAllText(pathArchivoXML);
                    GenXML(comprobante, pathArchivoXML);

                    #endregion
                    splashScreenManager1.SetWaitFormCaption("Timbrando Documento..");

                    try
                    {
                        #region TimbradoNTLINK
                        if (PAC.Equals("NT"))
                        {
                            if (ambiente.Equals("Produccion"))
                            {
                                ServicioTimbradoClient client = new ServicioTimbradoClient();
                                client.Open();
                                string xmlLINK = Convert.ToString(System.IO.File.ReadAllText(pathArchivoXML));
                                var newXML = client.TimbraCfdiQr("angel@inari.mx", "Inari2020.", xmlLINK);
                                client.Close();

                                if (newXML.Valido.Equals(true))
                                {
                                    genPDF = true;
                                    exito++;
                                    string cadena = newXML.CadenaTimbre;
                                    string[] arrayCadena;
                                    arrayCadena = cadena.Split(Convert.ToChar("|"));
                                    //XtraMessageBox.Show(arrayCadena[3]);
                                    string UUIDNT = arrayCadena[3];
                                    string sello = arrayCadena[6];
                                    arrayCadena = sello.Split(Convert.ToChar("/"));
                                    string ultDigSello = arrayCadena[6];
                                    int tamDig = ultDigSello.Length;
                                    ultDigSello = ultDigSello.Substring((tamDig - 8), 8);
                                    System.IO.File.Delete(pathArchivoXML);
                                    pathArchivoXML = Path.Combine(pathXml + fecPago + @"\");

                                    if (destino.Equals("Cliente"))
                                    {
                                        pathArchivoXML = Path.Combine(pathXml + clienteAsimilado.CLIENTE.Replace(" ", string.Empty) + "_" + fecPago + @"\");
                                    }
                                    else if (destino.Equals("Empleado"))
                                    {
                                        pathArchivoXML = Path.Combine(pathXml + clienteAsimilado.CLIENTE.Replace(" ", string.Empty) + "_" + nomiEmpl.Nombre.Replace(" ", string.Empty) + "_" + fecPago + @"\");
                                    }
                                    nombreArchivo = fecPago + "_" + nomiEmpl.RFC + "_" + nomiEmpl.Nombre;
                                    pathArchivoXML = Path.Combine(pathArchivoXML + nombreArchivo);
                                    pathArchivoXMLF = Path.Combine(pathArchivoXML + "_" + UUIDNT);
                                    pathArchivoXML = Path.Combine(pathArchivoXML + "_" + UUIDNT + ".xml");
                                    byte[] info = Encoding.ASCII.GetBytes(newXML.Cfdi);
                                    FileStream fs = new FileStream(path: pathArchivoXML, mode: FileMode.Create);
                                    fs.Write(info, 0, info.Length);
                                    fs.Close();

                                    Folio.UUID = UUIDNT;
                                    Folio.RutaXML = pathArchivoXML;
                                    Folio.XML = System.IO.File.ReadAllText(pathArchivoXML);
                                    Folio.StatusSAT = "Vigente";
                                    Folio.selloCFD = ultDigSello;
                                    Bitacora.UUID = UUIDNT;
                                    Bitacora.StatusSAT = "Vigente";
                                    Bitacora.Usuario = Properties.Settings.Default.Usuario.ToString();
                                    splashScreenManager1.SetWaitFormCaption("Guardando Movimiento..");

                                    string resultFolio = InsertaFolio(Folio, splashScreenManager1);
                                    if (resultFolio != "true")
                                    {
                                        error++;
                                        builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                                        builder.AppendLine();
                                        builder.Append("Error al intentar guardar información de timbrado\nUUID detimbre: " + UUIDNT);
                                        builder.AppendLine();
                                        builder.Append("Error: " + resultFolio);
                                        builder.AppendLine();
                                        //XtraMessageBox.Show("Hubo un Error al intentar guardar información de timbrado en la base de datos.\n");
                                    }
                                    splashScreenManager1.SetWaitFormCaption("Guardando Historico..");
                                    string resultBitacora = InsertaBitacora(Bitacora, splashScreenManager1);
                                    if (resultBitacora != "true")
                                    {
                                        error++;
                                        builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                                        builder.AppendLine();
                                        builder.Append("Error al intentar guardar información de timbrado en bitacora\nUUID de timbre: " + UUIDNT);
                                        builder.AppendLine();
                                        builder.Append("Error: " + resultBitacora);
                                        builder.AppendLine();
                                        //XtraMessageBox.Show("Hubo un Error al intentar guardar información de timbrado en bitacora de la base de datos.\n");
                                    }
                                    estatusLayout = "Timbrado";
                                    ActualizaStatusFolio(item.IDLayout, estatusLayout);
                                }
                                else
                                {
                                    genPDF = false;
                                    error++;
                                    builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                                    builder.AppendLine();
                                    builder.Append(newXML.DescripcionError);
                                    builder.AppendLine();
                                    builder.AppendLine();
                                    System.IO.File.Delete(pathArchivoXML);
                                    if (cont + 1 < Lista.Count())
                                    {
                                        builder.Append("*************************************************************************************************");
                                        builder.AppendLine();
                                    }
                                    //splashScreenManager1.CloseWaitForm();
                                    //XtraMessageBox.Show(cFDIResultados[0].mensaje + "\nEmpleado #: " + nomiEmpl.NumEmpl + " (" + nomiEmpl.Nombre + ")"
                                    //    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                System.IO.File.Delete(pathArchivoXML);
                                if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                                {
                                    splashScreenManager1.CloseWaitForm();
                                }
                                XtraMessageBox.Show("El timbrado de pruebas no esta disponible para NT-LINK", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                return;
                            }
                        }
                        // inicia codigo WS NTLINK
                        //SERVICIO PRUEBAS
                        //ServicioTimbtadoClientPruebas client = new ServicioTimbtadoClientPruebas();

                        //var empersas = client.ObtenerEmpresas("jordyespejel7@gmail.com", "Asimilados2020");
                        //var newXML = client.TimbraCfdiQr("jordyespejel7@gmail.com", "Asimilados2020", xmlLINK);

                        //string newXML = client.TimbraCfdi("jordyespejel7@gmail.com", "Asimilados2020", xmlLINK);


                        //fin codigo WS NTLINK
                        #endregion
                        #region TimbradoSolucion
                        if (PAC.Equals("SL"))
                        {
                            ServicioTimbradoProduccion.TimbradoPortTypeClient portTypeClient = null;

                            byte[] bxml = Encoding.UTF8.GetBytes(System.IO.File.ReadAllText(pathArchivoXML));
                            ServicioTimbradoProduccion.CFDICertificacion respuesta;
                            if (ambiente.Equals("Pruebas"))
                            {
                                portTypeClient = (produccion)
                                ? new ServicioTimbradoProduccion.TimbradoPortTypeClient(test_endpoint)
                                : portTypeClient = new ServicioTimbradoProduccion.TimbradoPortTypeClient(test_endpoint);
                                respuesta = portTypeClient.timbrar("testing@solucionfactible.com", "timbrado.SF.16672", bxml, false);
                            }
                            else
                            {
                                portTypeClient = (produccion)
                                ? new ServicioTimbradoProduccion.TimbradoPortTypeClient(prod_endpoint)
                                : portTypeClient = new ServicioTimbradoProduccion.TimbradoPortTypeClient(prod_endpoint);
                                respuesta = portTypeClient.timbrar("facturacion@inteligencialaboral.com", "DFddf.gr6u45Tef", bxml, false);
                            }
                            ServicioTimbradoProduccion.CFDIResultadoCertificacion[] cFDIResultados = respuesta.resultados;
                            if (respuesta.status.Equals(200))
                            {
                                //XtraMessageBox.Show(cFDIResultados[0].uuid);
                                //XtraMessageBox.Show(cFDIResultados[0].certificadoSAT);
                                //XtraMessageBox.Show(cFDIResultados[0].mensaje);
                                if (cFDIResultados[0].status.Equals(200))
                                {
                                    genPDF = true;
                                    exito++;
                                    System.IO.File.Delete(pathArchivoXML);
                                    pathArchivoXML = Path.Combine(pathXml + fecPago + @"\");

                                    if (destino.Equals("Cliente"))
                                    {
                                        pathArchivoXML = Path.Combine(pathXml + clienteAsimilado.CLIENTE.Replace(" ", string.Empty) + "_" + fecPago + @"\");
                                    }
                                    else if (destino.Equals("Empleado"))
                                    {
                                        pathArchivoXML = Path.Combine(pathXml + clienteAsimilado.CLIENTE.Replace(" ", string.Empty) + "_" + nomiEmpl.Nombre.Replace(" ", string.Empty) + "_" + fecPago + @"\");
                                    }
                                    nombreArchivo = fecPago + "_" + nomiEmpl.RFC + "_" + nomiEmpl.Nombre;
                                    pathArchivoXML = Path.Combine(pathArchivoXML + nombreArchivo);
                                    pathArchivoXMLF = Path.Combine(pathArchivoXML + "_" + cFDIResultados[0].uuid);
                                    pathArchivoXML = Path.Combine(pathArchivoXML + "_" + cFDIResultados[0].uuid + ".xml");
                                    byte[] info = cFDIResultados[0].cfdiTimbrado;
                                    FileStream fs = new FileStream(path: pathArchivoXML, mode: FileMode.Create);
                                    fs.Write(info, 0, info.Length);
                                    fs.Close();

                                    Folio.UUID = cFDIResultados[0].uuid;
                                    Folio.RutaXML = pathArchivoXML;
                                    Folio.XML = System.IO.File.ReadAllText(pathArchivoXML);
                                    Folio.StatusSAT = "Vigente";
                                    Bitacora.UUID = cFDIResultados[0].uuid;
                                    Bitacora.StatusSAT = "Vigente";
                                    Bitacora.Usuario = Properties.Settings.Default.Usuario.ToString();
                                    Bitacora.Origen = "Nomina";
                                    splashScreenManager1.SetWaitFormCaption("Guardando Movimiento..");
                                    string resultFolio = InsertaFolio(Folio, splashScreenManager1);
                                    if (resultFolio != "true")
                                    {
                                        error++;
                                        builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                                        builder.AppendLine();
                                        builder.Append("Error al intentar guardar información de timbrado\nUUID detimbre: " + cFDIResultados[0].uuid);
                                        builder.AppendLine();
                                        builder.Append("Error: " + resultFolio);
                                        builder.AppendLine();
                                        //XtraMessageBox.Show("Hubo un Error al intentar guardar información de timbrado en la base de datos.\n");
                                    }
                                    splashScreenManager1.SetWaitFormCaption("Guardando Historico..");
                                    string resultBitacora = InsertaBitacora(Bitacora, splashScreenManager1);
                                    if (resultBitacora != "true")
                                    {
                                        error++;
                                        builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                                        builder.AppendLine();
                                        builder.Append("Error al intentar guardar información de timbrado en bitacora\nUUID de timbre: " + cFDIResultados[0].uuid);
                                        builder.AppendLine();
                                        builder.Append("Error: " + resultBitacora);
                                        builder.AppendLine();
                                        //XtraMessageBox.Show("Hubo un Error al intentar guardar información de timbrado en bitacora de la base de datos.\n");
                                    }
                                    estatusLayout = "Timbrado";
                                    ActualizaStatusFolio(item.IDLayout, estatusLayout);
                                }
                                else
                                {
                                    genPDF = false;
                                    error++;
                                    builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                                    builder.AppendLine();
                                    builder.Append(cFDIResultados[0].mensaje);
                                    builder.AppendLine();
                                    builder.AppendLine();
                                    System.IO.File.Delete(pathArchivoXML);
                                    if (cont + 1 < Lista.Count())
                                    {
                                        builder.Append("*************************************************************************************************");
                                        builder.AppendLine();
                                    }
                                    //splashScreenManager1.CloseWaitForm();
                                    //XtraMessageBox.Show(cFDIResultados[0].mensaje + "\nEmpleado #: " + nomiEmpl.NumEmpl + " (" + nomiEmpl.Nombre + ")"
                                    //    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                estatusLayout = "Error al timbrar";
                                ActualizaStatusFolio(item.IDLayout, estatusLayout);
                                if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                                {
                                    splashScreenManager1.CloseWaitForm();
                                }
                                XtraMessageBox.Show(cFDIResultados[0].mensaje);
                                return;
                            }
                        }
                        #endregion
                        //XtraMessageBox.Show(cFDIResultados.ToString());
                        //System.IO.File.WriteAllText(pathXml,);
                    }
                    catch (Exception timbrado)
                    {
                        if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                        {
                            splashScreenManager1.CloseWaitForm();
                        }
                        XtraMessageBox.Show(timbrado.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (genPDF.Equals(true))
                    {
                        splashScreenManager1.SetWaitFormCaption("Generando PDF..");
                        if (destino.Equals("Empleado"))
                        {
                            archivos.Add(pathArchivoXML);
                        }

                        string resultPDF = LeerXMLModAsim(pathArchivoXML, pathArchivoXMLF, splashScreenManager1);
                        if (resultPDF.Equals("false"))
                        {
                            //XtraMessageBox.Show("Hubo un error al generar archivo pdf", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            error++;
                            builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                            builder.AppendLine();
                            builder.Append("Error al generar PDF: " + resultPDF);
                            builder.AppendLine();
                            builder.AppendLine();
                        }
                        else
                        {
                            if (destino.Equals("Empleado"))
                            {
                                archivos.Add(resultPDF);
                            }
                        }
                    }
                    if (enviaCorreo.Equals(true) && destino.Equals("Empleado"))
                    {
                        if (destino != "" && nomiEmpl.Correo != "")
                        {
                            splashScreenManager1.SetWaitFormCaption("Enviando Correo...");
                            if (destino.Equals("Empleado"))
                            {
                                resultCorreo = EnviaFacturaCorreo(nomiEmpl.Correo, archivos, destino);
                                archivos.Clear();

                                if (resultCorreo != "true")
                                {
                                    error++;
                                    builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                                    builder.AppendLine();
                                    builder.Append("Error al enviar correo:");
                                    builder.AppendLine();
                                    if (nomiEmpl.Correo.Equals(""))
                                    {
                                        builder.Append(resultCorreo);
                                        builder.AppendLine();
                                    }
                                    builder.AppendLine();
                                }
                            }
                        }
                        else
                        {
                            error++;
                            builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                            builder.AppendLine();
                            builder.Append("Error al enviar correo:");
                            builder.AppendLine();
                            if (nomiEmpl.Correo.Equals(""))
                            {
                                builder.Append("Empleado no tiene correo registrado.");
                                builder.AppendLine();
                            }
                            builder.AppendLine();
                        }
                    }
                    //splashScreenManager1.CloseWaitForm();
                    //XtraMessageBox.Show("¡Nómina Generada con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception genxml)
                {
                    if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                    {
                        splashScreenManager1.CloseWaitForm();
                    }
                    XtraMessageBox.Show(genxml.Message + "Error controlaor: GenXMLMasiv()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cont + 1 == Lista.Count)
                {
                    //if (exito.Equals(Lista.Count()))
                    //{

                    //}

                    if (error > 0)
                    {
                        try
                        {
                            builder.AppendLine();
                            builder.Append("********************************       Fin Erroes      ******************************************" + "\r\n");
                            writerLog = new StreamWriter(path, true);
                            writerLog.Write(builder);
                            writerLog.Close();

                            splashScreenManager1.CloseWaitForm();

                            XtraMessageBox.Show("¡Nomina generada con " + error + " errores registrados y "
                                + exito + " registros con éxito! \n(Presione aceptar para ver errores)", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Process proceso = new Process();
                            proceso.StartInfo.FileName = path;
                            proceso.Start();
                            return;
                        }
                        catch (Exception feach)
                        {
                            if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                            {
                                splashScreenManager1.CloseWaitForm();
                            }

                            XtraMessageBox.Show(feach.Message + "\nError controlador: foreach GenxmlMasiv(Generalog)",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                        {
                            splashScreenManager1.CloseWaitForm();
                        }
                        if (destino.Equals("Empleado"))
                        {
                            XtraMessageBox.Show("¡Nóminas generadas y correos enviados con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("¡Nóminas generadas con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            } //termina foreach
            if (enviaCorreo.Equals(true))
            {
                if (destino.Equals("Cliente"))
                {
                    splashScreenManager1.ShowWaitForm();
                    splashScreenManager1.SetWaitFormCaption("Enviando correo..");
                    archivos.Add(pathXml + clienteAsimilado.CLIENTE.Replace(" ", string.Empty) + "_" + fecPago);
                    resultCorreo = EnviaFacturaCorreo(clienteAsimilado.correoCliente, archivos, destino);

                    if (resultCorreo != "true")
                    {
                        builder.Append("Error al enviar correo al cliente:");
                        builder.AppendLine();
                        builder.Append(resultCorreo);
                        builder.AppendLine();
                        builder.Append("********************************       Fin Erroes      ******************************************" + "\r\n");
                        writerLog = new StreamWriter(path, true);
                        writerLog.Write(builder);
                        writerLog.Close();

                        if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                        {
                            splashScreenManager1.CloseWaitForm();
                        }

                        XtraMessageBox.Show("¡Error al enviar archivos al correo del cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Process proceso = new Process();
                        proceso.StartInfo.FileName = path;
                        proceso.Start();

                    }
                    else
                    {
                        if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                        {
                            splashScreenManager1.CloseWaitForm();
                            XtraMessageBox.Show("¡Correo enviado con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }


        [Obsolete]
        public void GenXmlMasivo(List<E.Empleado> Lista, SplashScreenManager splashScreenManager1, string empresa, string rfc, string ip, DateTime FecIniPeriMasiv, DateTime FecFinPeriMasiv, DateTime FecPagoMasiv, string destino, bool enviaCorreo, string correoCliente, string PAC, string ambiente)
        {
            E.Empleado nomiEmpl = new E.Empleado();
            E.FolioXML Folio = new E.FolioXML();
            E.BitacoraXML Bitacora = new E.BitacoraXML();
            E.Parametros parametros = new E.Parametros();
            List<string> archivos = new List<string>();
            string fecPago = "";
            string resultCorreo;
            string periodicidad = null;
            string pathXml = @"C:\XML\";
            string pathArchivoXML = null;
            string pathCorreo = null;
            string nombreArchivo = null;
            string pathArchivoXMLF = null;
            string folio = null;
            string estatusLayout = "";
            string bd = N.Conexion.PerformConnection().Database;
            int cont = -1, exito = 0, error = 0;
            bool genPDF = false;
            StreamWriter writerLog = null;
            StringBuilder builder = null;
            string url = @"C:\AsimiladosLogs\";
            if (!Directory.Exists(url))
            {
                Directory.CreateDirectory(url);
            }
            string NombreArchivo = "Timbrado_Masivo_" + FecPagoMasiv.ToString("dd-mm-yyyy") + "_" + Convert.ToString(DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-"
            + DateTime.Now.Year.ToString() + ", " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString()
            + "-" + DateTime.Now.Second.ToString());
            string path = Path.Combine(url, NombreArchivo + ".txt");
            string hora = Convert.ToString("," + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString()
            + "-" + DateTime.Now.Second.ToString());
            builder = new StringBuilder();
            builder.AppendLine();
            builder.Append("********************************   Erroes Encontrados  ******************************************" + "\r\n");
            builder.AppendLine();

            //inicia foreach
            foreach (var item in Lista)
            {
                cont++;
                //if (cont < Lista.Count())
                //{

                //}
                try
                {
                    if (splashScreenManager1.IsSplashFormVisible.Equals(false))
                    {
                        splashScreenManager1.ShowWaitForm();
                    }
                    nomiEmpl = BuscaEmpleado(item.RFC);
                    nomiEmpl.IngresosBrutos = item.IngresosBrutos;
                    nomiEmpl.ISR = item.ISR;
                    nomiEmpl.IngresosNetos = item.IngresosNetos;
                    splashScreenManager1.SetWaitFormCaption("Generando nomina de: \n" + nomiEmpl.Nombre);

                    parametros = GetParametros(rfc);


                    periodicidad = nomiEmpl.Periodicidad;

                    Folio.Empleado = nomiEmpl.Nombre;
                    Folio.RFC = nomiEmpl.RFC;
                    Folio.Empresa = empresa;
                    Folio.FecIni = FecIniPeriMasiv;
                    Folio.FecFin = FecFinPeriMasiv;
                    Folio.FecPago = FecPagoMasiv;
                    Folio.Importe = nomiEmpl.IngresosBrutos;
                    Folio.total = item.IngresosNetos;
                    Folio.nominaEmpresaID = Properties.Settings.Default["EmpresaNominaID"].ToString();
                    Bitacora.IPMovimiento = ip;
                    Bitacora.Empresa = empresa;
                    Bitacora.FecPago = FecPagoMasiv;
                    //Folio.FecPago = Convert.ToDateTime(FecPagoUni.EditValue.ToString());
                    Bitacora.FecIni = FecIniPeriMasiv;
                    Bitacora.FecFin = FecFinPeriMasiv;
                    Bitacora.FecMovimiento = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"));
                    Bitacora.Movimiento = "Timbrado";
                    Bitacora.Origen = "Timbrado Masivo";
                    Bitacora.nominaEmpresaID = Properties.Settings.Default["EmpresaNominaID"].ToString();

                    fecPago = Convert.ToDateTime(FecPagoMasiv).ToString("dd-MM-yyyy");
                    pathArchivoXML = Path.Combine(pathXml + fecPago + @"\");
                    if (destino.Equals("Cliente"))
                    {
                        pathArchivoXML = Path.Combine(pathXml + fecPago + hora + "_Recibos" + @"\");
                        pathCorreo = pathArchivoXML;
                    } else if (destino.Equals("Empleado"))
                    {
                        pathArchivoXML = Path.Combine(pathXml + item.Nombre.Replace(" ", string.Empty) + "_" + fecPago + @"\");
                    }

                    if (!Directory.Exists(pathArchivoXML))
                    {
                        Directory.CreateDirectory(pathArchivoXML);
                    }

                    nombreArchivo = fecPago + "_" + nomiEmpl.RFC + "_" + nomiEmpl.Nombre;

                    pathArchivoXML = Path.Combine(pathArchivoXML + nombreArchivo + ".xml");
                    bool produccion = false;
                    // produccion = false ---> para pruebas
                    if (PAC.Equals("SL") && ambiente.Equals("Pruebas"))
                    {
                        produccion = false;
                    } else if (PAC.Equals("SL") && ambiente.Equals("Produccion"))
                    {
                        produccion = true;
                    }

                    string prod_endpoint = "TimbradoEndpoint_PRODUCCION";
                    string test_endpoint = "TimbradoEndpoint_TESTING";

                    string pathPrincipalExe = AppDomain.CurrentDomain.BaseDirectory + "/";
                    //string pathCer = @"C:\DocAsimilados\CSD01_AAA010101AAA.cer";
                    //string pathKey = @"C:\DocAsimilados\CSD01_AAA010101AAA.key";
                    //string pass = "12345678a";

                    //string pathCer = @"C:\DocAsimilados\00001000000413522787.cer";
                    //string pathKey = @"C:\DocAsimilados\CSD_QUERETARO_PTP131002FA0_20190214_113034.key";
                    //string pass = "ptpinari";
                    string pathCer = ArchivoCER(rfc);
                    string pathKey = ArchivoKEY(rfc);
                    string pass = PassKey(rfc);

                    string Inicio, Final, Serie, NumCer;

                    SelloDigital.leerCER(pathCer, out Inicio, out Final, out Serie, out NumCer);

                    folio = GetFolio();

                    if (folio.Equals(null) || folio.Equals(""))
                    {
                        splashScreenManager1.CloseWaitForm();
                        XtraMessageBox.Show("¡Folio no encontrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (folio.Equals("0"))
                        {
                            folio = "0001";
                        }
                        Bitacora.Folio = folio;
                        Folio.Folio = folio;
                    }
                    #region comprobanteNomina
                    Comprobante comprobante = new Comprobante();
                    comprobante.Folio = folio;
                    comprobante.Fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    //comprobante.Sello = "faltante";
                    comprobante.FormaPago = "99";
                    comprobante.NoCertificado = NumCer;
                    comprobante.SubTotal = nomiEmpl.IngresosBrutos;
                    comprobante.Descuento = nomiEmpl.ISR;
                    comprobante.Total = nomiEmpl.IngresosNetos; //ingresos netos
                    comprobante.Moneda = "MXN";
                    comprobante.TipoDeComprobante = "N";
                    comprobante.MetodoPago = "PUE";
                    comprobante.LugarExpedicion = parametros.CODIGO_POSTAL;
                    comprobante.TipoCambio = 1;

                    ComprobanteEmisor comprobanteEmisor = new ComprobanteEmisor();
                    comprobanteEmisor.Rfc = rfc;
                    comprobanteEmisor.Nombre = empresa;
                    comprobanteEmisor.RegimenFiscal = "601";

                    ComprobanteReceptor comprobanteReceptor = new ComprobanteReceptor();
                    comprobanteReceptor.Nombre = nomiEmpl.Nombre;
                    comprobanteReceptor.Rfc = nomiEmpl.RFC;
                    comprobanteReceptor.UsoCFDI = "P01";


                    comprobante.Emisor = comprobanteEmisor;
                    comprobante.Receptor = comprobanteReceptor;

                    List<ComprobanteConcepto> listaConceptos = new List<ComprobanteConcepto>();
                    ComprobanteConcepto comprobanteConcepto = new ComprobanteConcepto();
                    comprobanteConcepto.Importe = nomiEmpl.IngresosBrutos;
                    comprobanteConcepto.ValorUnitario = nomiEmpl.IngresosBrutos;
                    comprobanteConcepto.Descuento = nomiEmpl.ISR;
                    comprobanteConcepto.ClaveProdServ = "84111505";
                    comprobanteConcepto.Cantidad = 1;
                    comprobanteConcepto.ClaveUnidad = "ACT";
                    comprobanteConcepto.Descripcion = "Pago de nómina";

                    listaConceptos.Add(comprobanteConcepto);

                    comprobante.Conceptos = listaConceptos.ToArray();
                    NominaReceptor nominaReceptor = new NominaReceptor();

                    Nomina nomina12 = new Nomina();
                    List<Nomina> nominas = new List<Nomina>();
                    nomina12.Version = "1.2";
                    nomina12.FechaPago = FecPagoMasiv;
                    nomina12.FechaInicialPago = FecIniPeriMasiv;
                    nomina12.FechaFinalPago = FecFinPeriMasiv;
                    nomina12.TotalPercepcionesSpecified = true;
                    nomina12.TotalDeduccionesSpecified = true;
                    nomina12.TotalPercepciones = nomiEmpl.IngresosBrutos;
                    nomina12.TotalDeducciones = nomiEmpl.ISR;


                    if (periodicidad.Equals("Semanal") || periodicidad.Equals("02"))
                    {
                        nomina12.NumDiasPagados = 7;
                        nominaReceptor.PeriodicidadPago = "02";
                    }

                    if (periodicidad.Equals("Quincenal") || periodicidad.Equals("04"))
                    {
                        nomina12.NumDiasPagados = 14;
                        nominaReceptor.PeriodicidadPago = "04";
                    }

                    if (periodicidad.Equals("Mensual") || periodicidad.Equals("05"))
                    {
                        nomina12.NumDiasPagados = 30;
                        nominaReceptor.PeriodicidadPago = "05";
                    }

                    nominaReceptor.Curp = nomiEmpl.CURP;
                    nominaReceptor.TipoContrato = nomiEmpl.TipoContrato;
                    nominaReceptor.Sindicalizado = nomiEmpl.Sindicalizado;
                    nominaReceptor.NumEmpleado = nomiEmpl.NumEmpl;
                    nominaReceptor.Departamento = nomiEmpl.Departamento;
                    nominaReceptor.Puesto = nomiEmpl.Puesto;
                    string entFed = GetEntFed(bd, parametros.CODIGO_POSTAL);
                    nominaReceptor.TipoRegimen = nomiEmpl.TipoRegimen;
                    nominaReceptor.ClaveEntFed = entFed;
                    nominaReceptor.SalarioBaseCotApor = 0;

                    NominaDeducciones nominaDeducciones = new NominaDeducciones();
                    NominaDeduccionesDeduccion nominaDeduccionesDeduccion = new NominaDeduccionesDeduccion();
                    NominaPercepciones nominaPercepciones = new NominaPercepciones();
                    NominaPercepcionesPercepcion nominaPercepcionesPercepcion = new NominaPercepcionesPercepcion();

                    nominaPercepciones.TotalSueldos = nomiEmpl.IngresosBrutos;
                    nominaPercepciones.TotalExento = 0;
                    nominaPercepciones.TotalGravado = nomiEmpl.IngresosBrutos;
                    nominaPercepciones.TotalSueldosSpecified = true;
                    nominaPercepciones.TotalSueldos = nomiEmpl.IngresosBrutos;
                    nominaPercepcionesPercepcion.TipoPercepcion = "046";
                    nominaPercepcionesPercepcion.Clave = "046";
                    nominaPercepcionesPercepcion.Concepto = "INGRESO A ASIMILADOS A SALARIO";
                    nominaPercepcionesPercepcion.ImporteGravado = nomiEmpl.IngresosBrutos;
                    nominaPercepcionesPercepcion.ImporteExento = 0;

                    nominaDeducciones.TotalImpuestosRetenidosSpecified = true;
                    nominaDeducciones.TotalImpuestosRetenidos = nomiEmpl.ISR;

                    nominaDeduccionesDeduccion.TipoDeduccion = "002";
                    nominaDeduccionesDeduccion.Clave = "211";
                    nominaDeduccionesDeduccion.Concepto = "ISR";
                    nominaDeduccionesDeduccion.Importe = nomiEmpl.ISR;


                    nomina12.Receptor = nominaReceptor;
                    nomina12.Deducciones = nominaDeducciones;
                    nomina12.Percepciones = nominaPercepciones;
                    nomina12.Percepciones.Percepcion = nominaPercepcionesPercepcion.ToArray();
                    nominaDeducciones.Deduccion = nominaDeduccionesDeduccion.ToArray();


                    nominas.Add(nomina12);
                    //comprobante.Nomina12 = nomina12;
                    comprobante.Complemento = new ComprobanteComplemento[1];
                    comprobante.Complemento[0] = new ComprobanteComplemento();

                    splashScreenManager1.SetWaitFormCaption("Generando XML");

                    XmlDocument nom12 = new XmlDocument();
                    XmlSerializerNamespaces xmlNameSpaceNomi = new XmlSerializerNamespaces();
                    xmlNameSpaceNomi.Add("nomina12", "http://www.sat.gob.mx/nomina12");
                    using (XmlWriter writer = nom12.CreateNavigator().AppendChild())
                    {
                        new XmlSerializer(nomina12.GetType()).Serialize(writer, nomina12, xmlNameSpaceNomi);
                    }
                    comprobante.Complemento[0].Any = new System.Xml.XmlElement[1];
                    comprobante.Complemento[0].Any[0] = nom12.DocumentElement;

                    GenXML(comprobante, pathArchivoXML);

                    string cadenaOrig = "";
                    //string ruta = @"C:\DocAsimilados\xslt\cadenaoriginal_3_3.xslt";
                    string pathCadenaOriginalxslt = pathPrincipalExe + @"xslt\cadenaoriginal_3_3.xslt";
                    System.Xml.Xsl.XslCompiledTransform transformador = new System.Xml.Xsl.XslCompiledTransform(true);
                    transformador.Load(pathCadenaOriginalxslt);

                    using (StringWriter sw = new StringWriter())
                    using (XmlWriter xwo = XmlWriter.Create(sw, transformador.OutputSettings))
                    {

                        //transformador.Transform(pathXml, xwo);
                        transformador.Transform(pathArchivoXML, xwo);
                        cadenaOrig = sw.ToString();
                    }

                    SelloDigital selloDigital = new SelloDigital();
                    comprobante.Certificado = selloDigital.Certificado(pathCer);
                    comprobante.Sello = selloDigital.Sellar(cadenaOrig, pathKey, pass);
                    //Folio.XML = System.IO.File.ReadAllText(pathArchivoXML);
                    GenXML(comprobante, pathArchivoXML);

                    #endregion
                    splashScreenManager1.SetWaitFormCaption("Timbrando Documento..");

                    try
                    {
                        #region TimbradoNTLINK
                        // inicia codigo WS NTLINK
                        //SERVICIO PRUEBAS
                        if (PAC.Equals("NT") && ambiente.Equals("Pruebas"))
                        {
                            System.IO.File.Delete(pathArchivoXML);
                            if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                            {
                                splashScreenManager1.CloseWaitForm();
                            }
                            XtraMessageBox.Show("El timbrado de pruebas no esta disponible para NT-LINK", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                            //ServicioTimbtadoClientPruebas client = new ServicioTimbtadoClientPruebas();
                            //client.Open();

                            //string xmlLINK = Convert.ToString(System.IO.File.ReadAllText(pathArchivoXML));
                            //var newXML = client.TimbraCfdiQr("jordyespejel7@gmail.com", "Asimilados2020", xmlLINK);
                            //client.Close();

                            //if (newXML.Valido.Equals(true))
                            //{
                            //    genPDF = true;
                            //    exito++;

                            //    string cadena = newXML.CadenaTimbre;
                            //    string[] arrayCadena;
                            //    arrayCadena = cadena.Split(Convert.ToChar("|"));
                            //    //XtraMessageBox.Show(arrayCadena[3]);
                            //    string UUIDNT = arrayCadena[3];
                            //    string ultDigSello = arrayCadena[6];
                            //    int tamDig = ultDigSello.Length;
                            //    ultDigSello = ultDigSello.Substring((tamDig - 8), 8);
                            //    System.IO.File.Delete(pathArchivoXML);
                            //    pathArchivoXML = Path.Combine(pathXml + fecPago + @"\");
                            //    if (destino.Equals("Cliente"))
                            //    {
                            //        pathArchivoXML = pathCorreo;
                            //    }
                            //    else if (destino.Equals("Empleado"))
                            //    {
                            //        pathArchivoXML = Path.Combine(pathXml + item.Nombre.Replace(" ", string.Empty) + "_" + fecPago + @"\");
                            //    }
                            //    nombreArchivo = fecPago + "_" + nomiEmpl.RFC + "_" + nomiEmpl.Nombre;
                            //    pathArchivoXML = Path.Combine(pathArchivoXML + nombreArchivo);
                            //    pathArchivoXMLF = Path.Combine(pathArchivoXML + "_" + UUIDNT);
                            //    pathArchivoXML = Path.Combine(pathArchivoXML + "_" + UUIDNT + ".xml");
                            //    byte[] info = Encoding.ASCII.GetBytes(newXML.Cfdi);
                            //    FileStream fs = new FileStream(path: pathArchivoXML, mode: FileMode.Create);
                            //    fs.Write(info, 0, info.Length);
                            //    fs.Close();

                            //    Folio.UUID = UUIDNT;
                            //    Folio.RutaXML = pathArchivoXML;
                            //    Folio.XML = System.IO.File.ReadAllText(pathArchivoXML);
                            //    Folio.StatusSAT = "Vigente";
                            //    Folio.selloCFD = ultDigSello;
                            //    Bitacora.UUID = UUIDNT;
                            //    Bitacora.StatusSAT = "Vigente";
                            //    Bitacora.Usuario = Properties.Settings.Default.Usuario.ToString();
                            //    splashScreenManager1.SetWaitFormCaption("Guardando Movimiento..");

                            //    string resultFolio = InsertaFolio(Folio, splashScreenManager1);
                            //    if (resultFolio != "true")
                            //    {
                            //        error++;
                            //        builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                            //        builder.AppendLine();
                            //        builder.Append("Error al intentar guardar información de timbrado\nUUID detimbre: " + UUIDNT);
                            //        builder.AppendLine();
                            //        builder.Append("Error: " + resultFolio);
                            //        builder.AppendLine();
                            //        //XtraMessageBox.Show("Hubo un Error al intentar guardar información de timbrado en la base de datos.\n");
                            //    }
                            //    splashScreenManager1.SetWaitFormCaption("Guardando Historico..");
                            //    string resultBitacora = InsertaBitacora(Bitacora, splashScreenManager1);
                            //    if (resultBitacora != "true")
                            //    {
                            //        error++;
                            //        builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                            //        builder.AppendLine();
                            //        builder.Append("Error al intentar guardar información de timbrado en bitacora\nUUID de timbre: " + UUIDNT);
                            //        builder.AppendLine();
                            //        builder.Append("Error: " + resultBitacora);
                            //        builder.AppendLine();
                            //        //XtraMessageBox.Show("Hubo un Error al intentar guardar información de timbrado en bitacora de la base de datos.\n");
                            //    }
                            //    estatusLayout = "Timbrado";
                            //    ActualizaStatusFolio(item.IDLayout, estatusLayout);
                            //}
                            //else
                            //{
                            //    genPDF = false;
                            //    error++;
                            //    builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                            //    builder.AppendLine();
                            //    builder.Append(newXML.DescripcionError);
                            //    builder.AppendLine();
                            //    builder.AppendLine();
                            //    System.IO.File.Delete(pathArchivoXML);
                            //    if (cont + 1 < Lista.Count())
                            //    {
                            //        builder.Append("*************************************************************************************************");
                            //        builder.AppendLine();
                            //    }
                            //    //splashScreenManager1.CloseWaitForm();
                            //    //XtraMessageBox.Show(cFDIResultados[0].mensaje + "\nEmpleado #: " + nomiEmpl.NumEmpl + " (" + nomiEmpl.Nombre + ")"
                            //    //    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //}
                        }
                        else if (PAC.Equals("NT") && ambiente.Equals("Produccion"))
                        {
                            ServicioTimbradoClient client = new ServicioTimbradoClient();
                            client.Open();

                            string xmlLINK = Convert.ToString(System.IO.File.ReadAllText(pathArchivoXML));
                            var newXML = client.TimbraCfdiQr("angel@inari.mx", "Inari2020.", xmlLINK);
                            client.Close();

                            if (newXML.Valido.Equals(true))
                            {
                                genPDF = true;
                                exito++;

                                string cadena = newXML.CadenaTimbre;
                                string[] arrayCadena;
                                arrayCadena = cadena.Split(Convert.ToChar("|"));
                                //XtraMessageBox.Show(arrayCadena[3]);
                                string UUIDNT = arrayCadena[3];
                                string ultDigSello = arrayCadena[6];
                                int tamDig = ultDigSello.Length;
                                ultDigSello = ultDigSello.Substring((tamDig - 8), 8);
                                System.IO.File.Delete(pathArchivoXML);
                                pathArchivoXML = Path.Combine(pathXml + fecPago + @"\");
                                if (destino.Equals("Cliente"))
                                {
                                    pathArchivoXML = pathCorreo;
                                }
                                else if (destino.Equals("Empleado"))
                                {
                                    pathArchivoXML = Path.Combine(pathXml + item.Nombre.Replace(" ", string.Empty) + "_" + fecPago + @"\");
                                }
                                nombreArchivo = fecPago + "_" + nomiEmpl.RFC + "_" + nomiEmpl.Nombre;
                                pathArchivoXML = Path.Combine(pathArchivoXML + nombreArchivo);
                                pathArchivoXMLF = Path.Combine(pathArchivoXML + "_" + UUIDNT);
                                pathArchivoXML = Path.Combine(pathArchivoXML + "_" + UUIDNT + ".xml");
                                byte[] info = Encoding.ASCII.GetBytes(newXML.Cfdi);
                                FileStream fs = new FileStream(path: pathArchivoXML, mode: FileMode.Create);
                                fs.Write(info, 0, info.Length);
                                fs.Close();

                                Folio.UUID = UUIDNT;
                                Folio.RutaXML = pathArchivoXML;
                                Folio.XML = System.IO.File.ReadAllText(pathArchivoXML);
                                Folio.StatusSAT = "Vigente";
                                Folio.selloCFD = ultDigSello;
                                //Folio.Folio = folio;
                                Bitacora.UUID = UUIDNT;
                                Bitacora.StatusSAT = "Vigente";
                                Bitacora.Usuario = Properties.Settings.Default.Usuario.ToString();
                                splashScreenManager1.SetWaitFormCaption("Guardando Movimiento..");

                                string resultFolio = InsertaFolio(Folio, splashScreenManager1);
                                if (resultFolio != "true")
                                {
                                    error++;
                                    builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                                    builder.AppendLine();
                                    builder.Append("Error al intentar guardar información de timbrado\nUUID detimbre: " + UUIDNT);
                                    builder.AppendLine();
                                    builder.Append("Error: " + resultFolio);
                                    builder.AppendLine();
                                    //XtraMessageBox.Show("Hubo un Error al intentar guardar información de timbrado en la base de datos.\n");
                                }
                                splashScreenManager1.SetWaitFormCaption("Guardando Historico..");
                                string resultBitacora = InsertaBitacora(Bitacora, splashScreenManager1);
                                if (resultBitacora != "true")
                                {
                                    error++;
                                    builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                                    builder.AppendLine();
                                    builder.Append("Error al intentar guardar información de timbrado en bitacora\nUUID de timbre: " + UUIDNT);
                                    builder.AppendLine();
                                    builder.Append("Error: " + resultBitacora);
                                    builder.AppendLine();
                                    //XtraMessageBox.Show("Hubo un Error al intentar guardar información de timbrado en bitacora de la base de datos.\n");
                                }
                                estatusLayout = "Timbrado";
                                ActualizaStatusFolio(item.IDLayout, estatusLayout);
                            }
                            else
                            {
                                genPDF = false;
                                error++;
                                builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                                builder.AppendLine();
                                builder.Append(newXML.DescripcionError);
                                builder.AppendLine();
                                builder.AppendLine();
                                System.IO.File.Delete(pathArchivoXML);
                                if (cont + 1 < Lista.Count())
                                {
                                    builder.Append("*************************************************************************************************");
                                    builder.AppendLine();
                                }
                                //splashScreenManager1.CloseWaitForm();
                                //XtraMessageBox.Show(cFDIResultados[0].mensaje + "\nEmpleado #: " + nomiEmpl.NumEmpl + " (" + nomiEmpl.Nombre + ")"
                                //    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        //fin codigo WS NTLINK
                        #endregion

                        #region TimbradoSolucion

                        if (PAC.Equals("SL"))
                        {
                            ServicioTimbradoProduccion.TimbradoPortTypeClient portTypeClient = null;


                            byte[] bxml = Encoding.UTF8.GetBytes(System.IO.File.ReadAllText(pathArchivoXML));
                            //servicio de prueba
                            ServicioTimbradoProduccion.CFDICertificacion respuesta;
                            if (ambiente.Equals("Pruebas"))
                            {
                                portTypeClient = (produccion)
                                ? new ServicioTimbradoProduccion.TimbradoPortTypeClient(test_endpoint)
                                : portTypeClient = new ServicioTimbradoProduccion.TimbradoPortTypeClient(test_endpoint);
                                respuesta = portTypeClient.timbrar("testing@solucionfactible.com", "timbrado.SF.16672", bxml, false);
                            }
                            else
                            {
                                portTypeClient = (produccion)
                                ? new ServicioTimbradoProduccion.TimbradoPortTypeClient(prod_endpoint)
                                : portTypeClient = new ServicioTimbradoProduccion.TimbradoPortTypeClient(prod_endpoint);
                                respuesta = portTypeClient.timbrar("facturacion@inteligencialaboral.com", "DFddf.gr6u45Tef", bxml, false);
                            }

                            //splashScreenManager1.SetWaitFormCaption(respuesta.status.ToString());
                            //splashScreenManager1.SetWaitFormCaption(respuesta.mensaje);
                            ServicioTimbradoProduccion.CFDIResultadoCertificacion[] cFDIResultados = respuesta.resultados;
                            if (respuesta.status.Equals(200))
                            {
                                //XtraMessageBox.Show(cFDIResultados[0].uuid);
                                //XtraMessageBox.Show(cFDIResultados[0].certificadoSAT);
                                //XtraMessageBox.Show(cFDIResultados[0].mensaje);
                                if (cFDIResultados[0].status.Equals(200))
                                {
                                    genPDF = true;
                                    exito++;
                                    System.IO.File.Delete(pathArchivoXML);
                                    pathArchivoXML = Path.Combine(pathXml + fecPago + @"\");
                                    if (destino.Equals("Cliente"))
                                    {
                                        pathArchivoXML = pathCorreo;
                                    }
                                    else if (destino.Equals("Empleado"))
                                    {
                                        pathArchivoXML = Path.Combine(pathXml + item.Nombre.Replace(" ", string.Empty) + "_" + fecPago + @"\");
                                    }
                                    nombreArchivo = fecPago + "_" + nomiEmpl.RFC + "_" + nomiEmpl.Nombre;
                                    pathArchivoXML = Path.Combine(pathArchivoXML + nombreArchivo);
                                    pathArchivoXMLF = Path.Combine(pathArchivoXML + "_" + cFDIResultados[0].uuid);
                                    pathArchivoXML = Path.Combine(pathArchivoXML + "_" + cFDIResultados[0].uuid + ".xml");
                                    byte[] info = cFDIResultados[0].cfdiTimbrado;
                                    FileStream fs = new FileStream(path: pathArchivoXML, mode: FileMode.Create);
                                    fs.Write(info, 0, info.Length);
                                    fs.Close();

                                    Folio.UUID = cFDIResultados[0].uuid;
                                    Folio.RutaXML = pathArchivoXML;
                                    Folio.XML = System.IO.File.ReadAllText(pathArchivoXML);
                                    Folio.StatusSAT = "Vigente";
                                    Bitacora.UUID = cFDIResultados[0].uuid;
                                    Bitacora.StatusSAT = "Vigente";
                                    Bitacora.Usuario = Properties.Settings.Default.Usuario.ToString();
                                    splashScreenManager1.SetWaitFormCaption("Guardando Movimiento..");
                                    string resultFolio = InsertaFolio(Folio, splashScreenManager1);
                                    if (resultFolio != "true")
                                    {
                                        error++;
                                        builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                                        builder.AppendLine();
                                        builder.Append("Error al intentar guardar información de timbrado\nUUID detimbre: " + cFDIResultados[0].uuid);
                                        builder.AppendLine();
                                        builder.Append("Error: " + resultFolio);
                                        builder.AppendLine();
                                        //XtraMessageBox.Show("Hubo un Error al intentar guardar información de timbrado en la base de datos.\n");
                                    }
                                    splashScreenManager1.SetWaitFormCaption("Guardando Historico..");
                                    string resultBitacora = InsertaBitacora(Bitacora, splashScreenManager1);
                                    if (resultBitacora != "true")
                                    {
                                        error++;
                                        builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                                        builder.AppendLine();
                                        builder.Append("Error al intentar guardar información de timbrado en bitacora\nUUID de timbre: " + cFDIResultados[0].uuid);
                                        builder.AppendLine();
                                        builder.Append("Error: " + resultBitacora);
                                        builder.AppendLine();
                                        //XtraMessageBox.Show("Hubo un Error al intentar guardar información de timbrado en bitacora de la base de datos.\n");
                                    }
                                    estatusLayout = "Timbrado";
                                    ActualizaStatusFolio(item.IDLayout, estatusLayout);
                                }
                                else
                                {
                                    genPDF = false;
                                    error++;
                                    builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                                    builder.AppendLine();
                                    builder.Append(cFDIResultados[0].mensaje);
                                    builder.AppendLine();
                                    builder.AppendLine();
                                    System.IO.File.Delete(pathArchivoXML);
                                    if (cont + 1 < Lista.Count())
                                    {
                                        builder.Append("*************************************************************************************************");
                                        builder.AppendLine();
                                    }
                                    //splashScreenManager1.CloseWaitForm();
                                    //XtraMessageBox.Show(cFDIResultados[0].mensaje + "\nEmpleado #: " + nomiEmpl.NumEmpl + " (" + nomiEmpl.Nombre + ")"
                                    //    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                estatusLayout = "Error al timbrar";
                                ActualizaStatusFolio(item.IDLayout, estatusLayout);
                                if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                                {
                                    splashScreenManager1.CloseWaitForm();
                                }
                                XtraMessageBox.Show(cFDIResultados[0].mensaje);
                                return;
                            }
                        }
                        #endregion
                        //XtraMessageBox.Show(cFDIResultados.ToString());
                        //System.IO.File.WriteAllText(pathXml,);
                    }
                    catch (Exception timbrado)
                    {
                        if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                        {
                            splashScreenManager1.CloseWaitForm();
                        }
                        XtraMessageBox.Show(timbrado.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (genPDF.Equals(true))
                    {
                        if (destino.Equals("Empleado"))
                        {
                            archivos.Add(pathArchivoXML);
                        }
                        splashScreenManager1.SetWaitFormCaption("Generando PDF..");
                        string nomPDF = Path.GetFileNameWithoutExtension(pathArchivoXML);
                        nomPDF = nomPDF + ".pdf";
                        string resultPDF = LeerXMLModAsim(pathArchivoXML, pathArchivoXMLF, splashScreenManager1);
                        string nomPDFResult = Path.GetFileNameWithoutExtension(resultPDF);
                        nomPDFResult = nomPDFResult + ".pdf";
                        if (nomPDFResult != nomPDF)
                        {
                            //XtraMessageBox.Show("Hubo un error al generar archivo pdf", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            error++;
                            builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                            builder.AppendLine();
                            builder.Append("Error al generar PDF: " + resultPDF);
                            builder.AppendLine();
                            builder.AppendLine();
                        }
                        else
                        {
                            if (destino.Equals("Empleado"))
                            {
                                archivos.Add(resultPDF);
                            }
                        }
                    }
                    if (enviaCorreo.Equals(true) && destino.Equals("Empleado"))
                    {
                        if (destino != "" && nomiEmpl.Correo != "")
                        {
                            splashScreenManager1.SetWaitFormCaption("Enviando Correo...");
                            if (destino.Equals("Empleado"))
                            {
                                resultCorreo = EnviaFacturaCorreo(nomiEmpl.Correo, archivos, destino);
                                archivos.Clear();

                                if (resultCorreo != "true")
                                {
                                    error++;
                                    builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                                    builder.AppendLine();
                                    builder.Append("Error al enviar correo:");
                                    builder.AppendLine();
                                    if (nomiEmpl.Correo.Equals(""))
                                    {
                                        builder.Append(resultCorreo);
                                        builder.AppendLine();
                                    }
                                    builder.AppendLine();
                                }
                            }
                        }
                        else
                        {
                            error++;
                            builder.Append("Nombre del empleado:" + nomiEmpl.Nombre + "\r\n");
                            builder.AppendLine();
                            builder.Append("Error al enviar correo:");
                            builder.AppendLine();
                            if (nomiEmpl.Correo.Equals(""))
                            {
                                builder.Append("Empleado no tiene correo registrado.");
                                builder.AppendLine();
                            }
                            builder.AppendLine();
                        }
                    }


                    //splashScreenManager1.CloseWaitForm();
                    //XtraMessageBox.Show("¡Nómina Generada con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception genxml)
                {
                    if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                    {
                        splashScreenManager1.CloseWaitForm();
                    }
                    XtraMessageBox.Show(genxml.Message + "Error controlaor: GenXMLMasiv()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cont + 1 == Lista.Count)
                {
                    //if (exito.Equals(Lista.Count()))
                    //{

                    //}

                    if (error > 0)
                    {
                        try
                        {
                            builder.AppendLine();
                            builder.Append("********************************       Fin Erroes      ******************************************" + "\r\n");
                            writerLog = new StreamWriter(path, true);
                            writerLog.Write(builder);
                            writerLog.Close();

                            if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                            {
                                splashScreenManager1.CloseWaitForm();
                            }

                            XtraMessageBox.Show("¡Nomina generada con " + error + " errores registrados y "
                                + exito + " registros con éxito! \n(Presione aceptar para ver errores)", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Process proceso = new Process();
                            proceso.StartInfo.FileName = path;
                            proceso.Start();

                            return;
                        }
                        catch (Exception feach)
                        {
                            if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                            {
                                splashScreenManager1.CloseWaitForm();
                            }

                            XtraMessageBox.Show(feach.Message + "\nError controlador: foreach GenxmlMasiv(Generalog)",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                        {
                            splashScreenManager1.CloseWaitForm();
                        }
                        if (destino.Equals("Empleado"))
                        {
                            XtraMessageBox.Show("¡Nóminas generadas y correos enviados con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("¡Nóminas generadas con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            } //termina foreach
            if (enviaCorreo.Equals(true))
            {
                if (destino.Equals("Cliente"))
                {
                    splashScreenManager1.ShowWaitForm();
                    splashScreenManager1.SetWaitFormCaption("Enviando correo..");
                    archivos.Add(pathCorreo);
                    resultCorreo = EnviaFacturaCorreo(correoCliente, archivos, destino);

                    if (resultCorreo != "true")
                    {
                        builder.Append("Error al enviar correo al cliente:");
                        builder.AppendLine();
                        builder.Append(resultCorreo);
                        builder.AppendLine();
                        builder.Append("********************************       Fin Erroes      ******************************************" + "\r\n");
                        writerLog = new StreamWriter(path, true);
                        writerLog.Write(builder);
                        writerLog.Close();

                        if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                        {
                            splashScreenManager1.CloseWaitForm();
                        }

                        XtraMessageBox.Show("¡Error al enviar archivos al correo del cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Process proceso = new Process();
                        proceso.StartInfo.FileName = path;
                        proceso.Start();

                    }
                    else
                    {
                        if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                        {
                            if (splashScreenManager1.IsSplashFormVisible.Equals(true))
                            {
                                splashScreenManager1.CloseWaitForm();
                            }
                            XtraMessageBox.Show("¡Correo enviado con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }


        }
        private void GenXML(Comprobante comprobante, string pathArchivoXML)
        {
            XmlSerializerNamespaces xmlNameSpace = new XmlSerializerNamespaces();
            xmlNameSpace.Add("cfdi", "http://www.sat.gob.mx/cfd/3");
            xmlNameSpace.Add("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital");
            xmlNameSpace.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            xmlNameSpace.Add("nomina12", "http://www.sat.gob.mx/nomina12");


            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Comprobante));

            string pathXmlWrit = @"";

            using (var sww = new Resources.StringWritterWithEncoding(Encoding.UTF8))
            {
                using (XmlWriter writter = XmlWriter.Create(sww))
                {
                    xmlSerializer.Serialize(writter, comprobante, xmlNameSpace);
                    pathXmlWrit = sww.ToString();
                }
            }
            System.IO.File.WriteAllText(pathArchivoXML, pathXmlWrit);
        }

        public string InsertaBitacora(Object _P, SplashScreenManager splash)
        {
            try
            {
                string resultado;
                E.BitacoraXML bitacora = (E.BitacoraXML)_P;
                SqlCommand queryInserta = N.Conexion.PerformConnection().CreateCommand();
                queryInserta.CommandText = @"INSERT INTO [dbo].[BitacoraXML]
                ([Folio]
                ,[UUID]
                ,[StatusSAT]
                ,[FecPago]
                ,[FecIni]
                ,[FecFin]
                ,[Empresa]
                ,[Movimiento]
                ,[FecMov]
                ,[IPMov]
                ,[Usuario]
                ,[Origen]
                ,[nominaEmpresaID])
                  VALUES
                ('" + bitacora.Folio + "'" +
                ",'" + bitacora.UUID + "'" +
                ",'" + bitacora.StatusSAT + "'" +
                ",'" + bitacora.FecPago.ToString("dd/MM/yyyy") + "'" +
                ",'" + bitacora.FecIni.ToString("dd/MM/yyyy") + "'" +
                ",'" + bitacora.FecFin.ToString("dd/MM/yyyy") + "'" +
                ",'" + bitacora.Empresa + "'" +
                ",'" + bitacora.Movimiento + "'" +
                ",'" + bitacora.FecMovimiento.ToString("dd/MM/yyyy") + "'" +
                ",'" + bitacora.IPMovimiento + "'" +
                ",'" + bitacora.Usuario.ToUpper() + "'" +
                ",'" + bitacora.Origen + "'" +
                ",'" + bitacora.nominaEmpresaID + "')";

                if (queryInserta.ExecuteNonQuery().Equals(1))
                {
                    resultado = "true";
                    return resultado;
                }
                else
                {
                    resultado = "Error";
                    return resultado;
                }

            } catch (Exception e)
            {
                string resultado;
                //if (splash.IsSplashFormVisible.Equals(true))
                //{
                //    splash.CloseWaitForm();
                //}
                //XtraMessageBox.Show(e.Message + "\nError Controlador: InsertaBitacora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultado = e.Message + "\nError Controlador: InsertaBitacora";
                return resultado;
            }
        }
        public string InsertaFolio(Object _P, SplashScreenManager splash)
        {
            try
            {
                string resultado;
                E.FolioXML folio = (E.FolioXML)_P;
                SqlCommand queryInserta = N.Conexion.PerformConnection().CreateCommand();
                queryInserta.CommandText = @"INSERT INTO [dbo].[FolioXML]
                ([Folio]
                ,[UUID]
                ,[XML]
                ,[RutaXML]
                ,[Empleado]
                ,[Importe]
                ,[StatusSAT]
                ,[FecPago]
                ,[FecIni]
                ,[FecFin]
                ,[Empresa]
                ,[RFC]
                ,[SelloCFD]
                ,[Total]
                ,[nominaEmpresaID])
                VALUES
                ('" + folio.Folio + "'" +
                ",'" + folio.UUID + "'" +
                ",'" + folio.XML + "'" +
                ",'" + folio.RutaXML + "'" +
                ",'" + folio.Empleado + "'" +
                "," + folio.Importe +
                ",'" + folio.StatusSAT + "'" +
                ",'" + folio.FecPago.ToString("dd/MM/yyyy") + "'" +
                ",'" + folio.FecIni.ToString("dd/MM/yyyy") + "'" +
                ",'" + folio.FecFin.ToString("dd/MM/yyyy") + "'" +
                ",'" + folio.Empresa + "'" +
                ",'" + folio.RFC + "'" +
                ",'" + folio.selloCFD + "'" +
                "," + folio.total + "" +
                ",'" + folio.nominaEmpresaID + "')";

                if (queryInserta.ExecuteNonQuery().Equals(1))
                {
                    resultado = "true";
                    return resultado;
                }
                else
                {
                    resultado = "Error";
                    return resultado;
                }


            }
            catch (Exception e)
            {
                string resultado;
                //if (splash.IsSplashFormVisible.Equals(true))
                //{
                //    splash.CloseWaitForm();
                //}
                //XtraMessageBox.Show(e.Message + "\nError Controlador: InsertaFolio()", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultado = e.Message + "\nError Controlador: InsertaFolio()";
                return resultado;
            }
        }
        public string GetFolio()
        {
            try
            {
                string folio = null;
                string NominaEmpresaID = Properties.Settings.Default["EmpresaNominaID"].ToString();
                SqlCommand QueryFolio = N.Conexion.PerformConnection().CreateCommand();
                QueryFolio.CommandText = @"SELECT
                ISNULL(RIGHT('00000' + CAST(Max([Folio]) + 1 AS varchar(5)) , 4),0) AS [Folio]
                FROM [FolioXML]
                WHERE [nominaEmpresaID] = @EmpresaID";
                QueryFolio.Parameters.AddWithValue("@EmpresaID", NominaEmpresaID);
                SqlDataReader readerFolio;
                readerFolio = QueryFolio.ExecuteReader();

                if (readerFolio.Read())
                {
                    folio = Convert.ToString(readerFolio.GetString(0));
                }
                readerFolio.Close();

                return folio;
            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: GetFolio()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public string GetEntFed(string bd, string CodPost)
        {
            try
            {
                string entidad = null, idEstado = null;
                N.Conexion.PerformConnection().Close();
                N.Conexion.PerformConnection().Open();

                SqlCommand queryEstado = N.Conexion.PerformConnection().CreateCommand();
                queryEstado.CommandText = @"select c_estado from Codigos_Postales where d_codigo = @CP";
                queryEstado.Parameters.AddWithValue("@CP", CodPost);

                SqlDataReader readerEstado;
                readerEstado = queryEstado.ExecuteReader();
                if (readerEstado.Read())
                {
                    idEstado = readerEstado.GetString(0);
                }
                readerEstado.Close();

                SqlCommand queryEntidad = N.Conexion.PerformConnection().CreateCommand();
                queryEntidad.CommandText = @"select c_Estado from Estados_Republica where id = @ID";
                queryEntidad.Parameters.AddWithValue("@ID", idEstado);

                SqlDataReader readerEntidad;
                readerEntidad = queryEntidad.ExecuteReader();
                if (readerEntidad.Read())
                {
                    entidad = readerEntidad.GetString(0);
                }
                readerEntidad.Close();

                N.Conexion.PerformConnection().ChangeDatabase(bd);
                return entidad;

            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: GetEntFed()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public string GetTipoRecu(string rfc)
        {
            try
            {
                string Recu = null;
                SqlCommand queryRecurso = N.Conexion.PerformConnection().CreateCommand();
                queryRecurso.CommandText = @"SELECT TOP (1) RE.Descripcion AS [Descripcion] FROM [PARAMETROS] as P INNER JOIN dbo.OrigenRecurso AS RE  ON RE.c_OrigenRecurso LIKE P.ORIGEN_RECURSOS  WHERE RFC = @RFC";
                queryRecurso.Parameters.AddWithValue("@RFC", rfc);

                SqlDataReader ReaderRecurso;
                ReaderRecurso = queryRecurso.ExecuteReader();

                if (ReaderRecurso.Read())
                {
                    Recu = ReaderRecurso.GetString(0);
                }
                else
                {
                    Recu = "";
                }
                ReaderRecurso.Close();

                return Recu;
            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError controlador: GetParametros()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public E.Parametros GetParametros(string RFC)
        {
            try
            {
                E.Parametros parametros = new E.Parametros();

                SqlCommand queryParametros = N.Conexion.PerformConnection().CreateCommand();
                queryParametros.CommandText = @"SELECT TOP (1) P.[ID]
                      ,[NOMBRE_EMPRESA]
                      ,[RFC]
                      ,ISNULL([REGISTRO_PATRONAL],'') AS [REGISTRO_PATRONAL]
                      ,ISNULL([REGISTRO_NSS], '') AS [REGISTRO_NSS]
                      ,ISNULL([REPRESENTANTE],'') AS [REPRESENTANTE]
                      ,[CALLE]
                      ,[NUM_EXT]
                      ,[NUM_INT]
                      ,[CODIGO_POSTAL]
                      ,[MUNICIPIO]
                      ,[LOCALIDAD]
                      ,[ESTADO]
                      ,[PAIS]
                      ,[REGIMEN]
                      ,[RIESGO_PUESTO]
                      ,[CLAVE_CERTIFICADO]
                      ,[NUMERO_CERTIFICADO]
                      ,[FECHA_VENCIMIENTO_CERTIFICADO]
                      ,[RUTA_Cti]
                      ,ISNULL([COD_CONCEPTO_Cti],'') AS [COD_CONCEPTO_Cti]
                      ,[FECHA_INICIO_CERTIFICADO]
                      ,ISNULL([ORIGEN_RECURSOS], '') AS [ORIGEN_RECURSOS]
                      ,[TIPO_NOMINA]
                      ,[ARCHIVO_CER]
                      ,[ARCHIVO_KEY]
                      ,[ASUNTO_CERTIFICADO]
                      ,[COLONIA]
                      ,[RUTA_ALMACEN_PDF]
					  ,Rf.Descripcion as [Descripcion Regimen]
					  --,RE.Descripcion AS [Descripción Recursos]
					  ,RP.Descripcion AS [Descripción Puesto]
					  ,TN.Descripcion AS [Descripción Nómina]
                      ,ISNULL([CUENTA_ORIGEN], 'No Definido') as [CUENTA_ORIGEN]
                      ,ISNULL([USUARIO_NTLINK], 'No Definido') as [USUARIO_NTLINK]
                      ,NOMINA_EMPRESA_ID
                  FROM [PARAMETROS] as P
				  INNER JOIN  dbo.RegimenFiscal as RF on RF.c_RegimenFiscal = P.REGIMEN
				  --INNER JOIN  dbo.OrigenRecurso AS RE  ON RE.c_OrigenRecurso = P.ORIGEN_RECURSOS
				  INNER JOIN  dbo.RiesgoPuesto AS RP ON RP.c_RiesgoPuesto = P.RIESGO_PUESTO
				  INNER JOIN dbo.TipoNomina AS TN ON TN.c_TipoNomina = P.TIPO_NOMINA
                  WHERE RFC = @RFC";
                queryParametros.Parameters.AddWithValue("@RFC", RFC);

                SqlDataReader readerParametros;
                readerParametros = queryParametros.ExecuteReader();

                if (readerParametros.Read())
                {
                    parametros.NombreEmpresa = readerParametros.GetString(1);
                    parametros.RFC = readerParametros.GetString(2);
                    parametros.RegistroPatronal = readerParametros.GetString(3);
                    parametros.NSS = readerParametros.GetString(4);
                    parametros.Representante = readerParametros.GetString(5);
                    parametros.Calle = readerParametros.GetString(6);
                    parametros.NUM_EXT = readerParametros.GetString(7);
                    parametros.NUM_INT = readerParametros.GetString(8);
                    parametros.CODIGO_POSTAL = readerParametros.GetString(9);
                    parametros.MUNICIPIO = readerParametros.GetString(10);
                    parametros.LOCALIDAD = readerParametros.GetString(11);
                    parametros.ESTADO = readerParametros.GetString(12);
                    parametros.PAIS = readerParametros.GetString(13);
                    parametros.REGIMEN = readerParametros.GetString(14);
                    parametros.RIESGO_PUESTO = readerParametros.GetString(15);
                    parametros.CLAVE_CERTIFICADO = readerParametros.GetString(16);
                    parametros.NUMERO_CERTIFICADO = readerParametros.GetString(17);
                    parametros.FECHA_VENCIMIENTO_CERTIFICADO = readerParametros.GetDateTime(18);
                    parametros.RUTA_Cti = readerParametros.GetString(19);
                    parametros.COD_CONCEPTO_Cti = readerParametros.GetString(20);
                    parametros.FECHA_INICIO_CERTIFICADO = readerParametros.GetDateTime(21);
                    parametros.ORIGEN_RECURSOS = readerParametros.GetString(22);
                    parametros.TIPO_NOMINA = readerParametros.GetString(23);
                    parametros.ARCHIVO_CER = readerParametros.GetString(24);
                    parametros.ARCHIVO_KEY = readerParametros.GetString(25);
                    parametros.ASUNTO_CERTIFICADO = readerParametros.GetString(26);
                    parametros.COLONIA = readerParametros.GetString(27);
                    parametros.RUTA_ALMACEN_PDF = readerParametros.GetString(28);
                    parametros.DescripcionRegimen = readerParametros.GetString(29);
                    //parametros.DescripcionRecursos = readerParametros.GetString(30);
                    parametros.DescripcionPuesto = readerParametros.GetString(30);
                    parametros.DescripcionNomina = readerParametros.GetString(31);
                    parametros.cuentaOrigen = readerParametros.GetString(32);
                    parametros.usuarioNtlink = readerParametros.GetString(33);
                    parametros.NOMINA_EMPRESA_ID = readerParametros.GetString(34);
                }
                readerParametros.Close();

                return parametros;
            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "Error controlador: GetParametros()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public E.ClienteAsimilado GetInfoCliente(string IDCliente)
        {
            try
            {
                E.ClienteAsimilado cliente = new E.ClienteAsimilado();

                SqlCommand queryCliente = N.Conexion.PerformConnection().CreateCommand();
                queryCliente.CommandText = @"SELECT [ID]
                  ,[CLIENTE]
                  ,[FECHA_ALTA_PRIMER_PAGO]
                  ,ISNULL([FECHA_BAJA], '') AS [FECHA_BAJA]
                  ,ISNULL([COMISIONISTA], 'No Definido') AS [COMISIONISTA]
                  ,[PORCENTAJE_ISN]
                  ,[PORCENTAJE_COMISION]
                  ,[TOTAL]
                  ,[FACTURACION_CON_IVA_SIN_IVA]
                  ,ISNULL([RETENCION], 'ND') as [RETENCION]
                  ,[PERIODO_DE_PAGO]
                  ,[ESTATUS]
                  ,[EJECUTIVO_RESPONSABLE]
                  ,[EMPRESA_PAGADORA_EMITE_CFDI]
                  ,[PROVEEDOR]
                  ,ISNULL([EMPRESA_QUE_FACTURA_A_CLIENTE], '') AS [EMPRESA_QUE_FACTUR_A _CLIENTE]
                  ,ISNULL([EMPRESA_QUE_FACTURA_A_CLIENTE1], '') AS [EMPRESA_QUE_FACTURA_A_CLIENTE1]
                  ,ISNULL([EMPRESA_QUE_FACTURA_A_CLIENTE2], '') AS [EMPRESA_QUE_FACTURA_A_CLIENTE2]
                  ,ISNULL([EMPRESA_QUE_FACTURA_A_CLIENTE3], '') AS [EMPRESA_QUE_FACTURA_A_CLIENTE3]
                  ,ISNULL([Metodo_Pago], 'No Definido') AS [Metodo_Pago]
                  ,ISNULL([Observaciones], '') AS [Observaciones]
                  ,ISNULL([Forma_Pago], 'No Definido') AS [Forma_Pago]
                  ,ISNULL([PORCENTAJE_RETENCION], 0) as [PORCENTAJE_RETENCION]
                ,ISNULL([PORCENTAJE_COMISIONISTA], 0) as[PORCENTAJE_COMISIONISTA]
                ,ISNULL([COMISIONISTA2], '') as[COMISIONISTA2]
                ,ISNULL([PORCENTAJE_COMISIONISTA2], 0) as[PORCENTAJE_COMISIONISTA2]
                ,ISNULL([COMISIONISTA3], '') as[COMISIONISTA3]
                ,ISNULL([PORCENTAJE_COMISIONISTA3], 0) as[PORCENTAJE_COMISIONISTA3]
                ,ISNULL([PORCENTAJE_FACTURA], 0) AS [PORCENTAJE_FACTURA]
                ,ISNULL([PORCENTAJE_FACTURA2], 0) AS [PORCENTAJE_FACTURA2]
                ,ISNULL([PORCENTAJE_FACTURA3], 0) AS [PORCENTAJE_FACTURA3]
                ,ISNULL([PORCENTAJE_FACTURA4], 0) AS [PORCENTAJE_FACTURA4]
                ,ISNULL([Correo], '') AS [Correo]
                  FROM [dbo].[ClientesAsimilados]  
                  WHERE [ID] = @ID";
                queryCliente.Parameters.AddWithValue("ID", IDCliente);
                SqlDataReader readerCliente;
                readerCliente = queryCliente.ExecuteReader();

                if (readerCliente.Read())
                {
                    cliente.ID = readerCliente.GetString(0);
                    cliente.CLIENTE = readerCliente.GetString(1);
                    cliente.FECHA_ALTA_PRIMER_PAGO = readerCliente.GetDateTime(2);
                    cliente.FECHA_BAJA = readerCliente.GetDateTime(3);
                    cliente.COMISIONISTA = readerCliente.GetString(4);
                    cliente.PORCENTAJE_ISN = Convert.ToDecimal(readerCliente.GetDecimal(5));
                    cliente.PORCENTAJE_COMISION = Convert.ToDecimal(readerCliente.GetDecimal(6));
                    cliente.TOTAL = Convert.ToDecimal(readerCliente.GetDecimal(7));
                    cliente.FACTURACION_CON_IVA_SIN_IVA = readerCliente.GetString(8);
                    cliente.RETENCION = readerCliente.GetString(9);
                    cliente.PERIODO_DE_PAGO = readerCliente.GetString(10);
                    cliente.ESTATUS = readerCliente.GetString(11);
                    cliente.EJECUTIVO_RESPONSABLE = readerCliente.GetString(12);
                    cliente.EMPRESA_PAGADORA_EMITE_CFDI = readerCliente.GetString(13);
                    cliente.PROVEEDOR = readerCliente.GetString(14);
                    cliente.EMPRESA_QUE_FACTUR_A_CLIENTE = readerCliente.GetString(15);
                    cliente.EMPRESA_QUE_FACTURA_A_CLIENTE1 = readerCliente.GetString(16);
                    cliente.EMPRESA_QUE_FACTURA_A_CLIENTE2 = readerCliente.GetString(17);
                    cliente.EMPRESA_QUE_FACTURA_A_CLIENTE3 = readerCliente.GetString(18);
                    cliente.Metodo_Pago = readerCliente.GetString(19);
                    cliente.Observaciones = readerCliente.GetString(20);
                    cliente.Forma_Pago = readerCliente.GetString(21);
                    cliente.PORCENTAJE_RETENCION = readerCliente.GetDecimal(22);
                    cliente.PORCENTAJE_COMISIONISTA = readerCliente.GetDecimal(23);
                    cliente.COMISIONISTA2 = readerCliente.GetString(24);
                    cliente.PORCENTAJE_COMISIONISTA2 = readerCliente.GetDecimal(25);
                    cliente.COMISIONISTA3 = readerCliente.GetString(26);
                    cliente.PORCENTAJE_COMISIONISTA3 = readerCliente.GetDecimal(27);
                    cliente.PORCENTAJE_FACTURA = readerCliente.GetDecimal(28);
                    cliente.PORCENTAJE_FACTURA2 = readerCliente.GetDecimal(29);
                    cliente.PORCENTAJE_FACTURA3 = readerCliente.GetDecimal(30);
                    cliente.PORCENTAJE_FACTURA4 = readerCliente.GetDecimal(31);
                    cliente.correoCliente = readerCliente.GetString(32);
                }
                readerCliente.Close();
                return cliente;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "Error controlador: GetInfoCLiente()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public E.Banco GetInfoBanco(string nombreBanco, string empresa)
        {
            try
            {
                E.Banco banco = new E.Banco();

                SqlCommand queryInfoBanco = N.Conexion.PerformConnection().CreateCommand();
                queryInfoBanco.CommandText = @"
                  SELECT
                  [Cuenta]
                 ,[CLABE]
                  FROM [dbo].[CatalogoBancosEmpresaPagaAsimilados]
                  WHERE [IDEmpresa] =  @ID AND [Banco] = @nombreBanco";
                queryInfoBanco.Parameters.AddWithValue("@ID", empresa);
                queryInfoBanco.Parameters.AddWithValue("@nombreBanco", nombreBanco);

                SqlDataReader readerInfo = queryInfoBanco.ExecuteReader();
                if (readerInfo.Read())
                {
                    banco.cuenta = readerInfo.GetString(0);
                    banco.clabe = readerInfo.GetString(1);
                }
                readerInfo.Close();

                return banco;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "Error controlador: GetInfoBanco()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public bool AgregaArchivoCer(string RFC, string cer)
        {
            try
            {
                bool result = false;
                SqlCommand queryAgregaKey = N.Conexion.PerformConnection().CreateCommand();
                queryAgregaKey.CommandText = @"update PARAMETROS set ARCHIVO_CER ='" + cer + "' where RFC ='" + RFC + "'";

                if (queryAgregaKey.ExecuteNonQuery().Equals(1))
                {
                    XtraMessageBox.Show("¡Información Actualizada Con Éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = true;
                }
                else
                {
                    XtraMessageBox.Show("¡Error Al  Actualizar La Información!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }

                return result;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: AgregarArchivoCer()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public string ArchivoCER(string RFC)
        {
            try
            {
                string pathCer = null;
                SqlCommand queryCer = N.Conexion.PerformConnection().CreateCommand();
                queryCer.CommandText = @"select ARCHIVO_CER from PARAMETROS where RFC =@RFC";
                queryCer.Parameters.AddWithValue("@RFC", RFC);

                SqlDataReader readerCer;
                readerCer = queryCer.ExecuteReader();

                if (readerCer.Read())
                {
                    pathCer = readerCer.GetString(0);
                }
                readerCer.Close();
                return pathCer;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "Error Controlador: ArchivoCER()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public bool AgregaArchivoKey(string RFC, string key, string pass)
        {
            try
            {
                bool result = false;
                SqlCommand queryAgregaKey = N.Conexion.PerformConnection().CreateCommand();
                queryAgregaKey.CommandText = @"update PARAMETROS set ARCHIVO_KEY ='" + key + "', CLAVE_CERTIFICADO = '" + pass + "' where RFC ='" + RFC + "'";

                if (queryAgregaKey.ExecuteNonQuery().Equals(1))
                {
                    XtraMessageBox.Show("¡Información Actualizada Con Éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = true;
                }
                else
                {
                    XtraMessageBox.Show("¡Error Al  Actualizar La Información!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }

                return result;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: AgregarArchivoKey()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public string ArchivoKEY(string RFC)
        {
            try
            {
                string pathKey = null;
                SqlCommand queryKey = N.Conexion.PerformConnection().CreateCommand();
                queryKey.CommandText = @"select ARCHIVO_KEY from PARAMETROS where RFC =@RFC";
                queryKey.Parameters.AddWithValue("@RFC", RFC);

                SqlDataReader readerKey;
                readerKey = queryKey.ExecuteReader();

                if (readerKey.Read())
                {
                    pathKey = readerKey.GetString(0);
                }
                readerKey.Close();
                return pathKey;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "Error Controlador: ArchivoKEY()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public string PassKey(string RFC)
        {
            try
            {
                string pass = null;
                SqlCommand queryPass = N.Conexion.PerformConnection().CreateCommand();
                queryPass.CommandText = @"select CLAVE_CERTIFICADO from PARAMETROS where RFC =@RFC";
                queryPass.Parameters.AddWithValue("@RFC", RFC);

                SqlDataReader readerPass;
                readerPass = queryPass.ExecuteReader();

                if (readerPass.Read())
                {
                    pass = readerPass.GetString(0);
                }
                readerPass.Close();
                return pass;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Error Controlador: PassKey()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public E.Calculo GeneraCalculo(decimal Ingresos, string Periodicidad, string BD)//, string TipoIngresos)
        {
            try
            {
                E.Calculo calculo = new E.Calculo();

                //if (TipoIngresos.Equals("Brutos"))
                //{
                //calculo.IngresosBrutos = Math.Round(Ingresos,2);
                calculo.IngresosBrutos = Math.Round(Ingresos, 2);
                if (Periodicidad.Equals("Semanal") || Periodicidad.Equals("02"))
                {
                    var ISR07 = new List<E.ISR7>();
                    E.ISR7[] isr07 = null;

                    var SUB07 = new List<E.SUB7>();
                    E.SUB7[] sub07 = null;

                    //N.Conexion.PerformConnectionSoprade().Open();
                    //SqlCommand queryTablaISR = N.Conexion.PerformConnectionSoprade().CreateCommand();
                    N.Conexion.PerformConnection().Close();
                    N.Conexion.PerformConnection().Open();
                    SqlCommand queryTablaISR = N.Conexion.PerformConnection().CreateCommand();
                    //queryTablaISR.CommandText = @"select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                    //from genTablasNumericasDet 
                    //where tnudIDTnum = 'ISR07'";  
                    queryTablaISR.CommandText = @"  select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                        from TablaCalculos 
                        where tnudIDTnum = 'ISR07'";

                    SqlDataReader readerTabla;
                    readerTabla = queryTablaISR.ExecuteReader();

                    while (readerTabla.Read())
                    {
                        ISR07.Add(new E.ISR7
                        {
                            LimiteInferior = readerTabla.GetDecimal(0),
                            LimiteSuperior = readerTabla.GetDecimal(1),
                            CuotaFija = readerTabla.GetDecimal(2),
                            Porcentaje = readerTabla.GetDecimal(3)
                        });
                        isr07 = ISR07.ToArray();
                    }
                    readerTabla.Close();

                    //SqlCommand queryTablaSub = N.Conexion.PerformConnectionSoprade().CreateCommand();
                    SqlCommand queryTablaSub = N.Conexion.PerformConnection().CreateCommand();
                    queryTablaSub.CommandText = @"select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                        from TablaCalculos 
                        where tnudIDTnum = 'SUB07'";

                    SqlDataReader readerTablaSub = queryTablaSub.ExecuteReader();
                    while (readerTablaSub.Read())
                    {
                        SUB07.Add(new E.SUB7
                        {
                            rango1 = readerTablaSub.GetDecimal(0),
                            rango2 = readerTablaSub.GetDecimal(1),
                            subsidio = readerTablaSub.GetDecimal(2)
                        });
                        sub07 = SUB07.ToArray();
                    }
                    readerTablaSub.Close();
                    N.Conexion.PerformConnection().ChangeDatabase(BD);

                    foreach (var valor in sub07)
                    {
                        if (Ingresos >= valor.rango1 && Ingresos <= valor.rango2)
                        {
                            calculo.Sub = Math.Round(valor.subsidio, 2);
                        }
                    }

                    foreach (var valor in isr07)
                    {
                        if (Ingresos >= valor.LimiteInferior && Ingresos <= valor.LimiteSuperior)
                        {
                            calculo.LimInferior = Math.Round(valor.LimiteInferior, 2);
                            //calculo.PerExLimInf = Math.Round(valor.Porcentaje,2);
                            calculo.PerExLimInf = valor.Porcentaje;
                            calculo.CF = Math.Round(valor.CuotaFija, 2);
                        }
                    }
                    calculo.ExLimInf = Math.Round(calculo.IngresosBrutos - calculo.LimInferior, 2);
                    calculo.ImpMarg = Math.Round(calculo.ExLimInf * calculo.PerExLimInf, 2);
                    calculo.ISR = Math.Round(calculo.CF + calculo.ImpMarg, 2);
                    calculo.IngresosNetos = Math.Round(calculo.IngresosBrutos - calculo.ISR + calculo.Sub, 2);
                }

                if (Periodicidad.Equals("Quincenal") || Periodicidad.Equals("04"))
                {
                    var ISR15 = new List<E.ISR15>();
                    E.ISR15[] isr15 = null;

                    var SUB15 = new List<E.SUB15>();
                    E.SUB15[] sub15 = null;

                    //N.Conexion.PerformConnectionSoprade().Open();
                    //SqlCommand queryTablaISR = N.Conexion.PerformConnectionSoprade().CreateCommand();
                    N.Conexion.PerformConnection().Close();
                    N.Conexion.PerformConnection().Open();
                    SqlCommand queryTablaISR = N.Conexion.PerformConnection().CreateCommand();
                    //queryTablaISR.CommandText = @"select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                    //from genTablasNumericasDet 
                    //where tnudIDTnum = 'ISR15'";  
                    queryTablaISR.CommandText = @"  select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                            from TablaCalculos 
                            where tnudIDTnum = 'ISR15'";

                    SqlDataReader readerTabla;
                    readerTabla = queryTablaISR.ExecuteReader();

                    while (readerTabla.Read())
                    {
                        ISR15.Add(new E.ISR15
                        {
                            LimiteInferior = readerTabla.GetDecimal(0),
                            LimiteSuperior = readerTabla.GetDecimal(1),
                            CuotaFija = readerTabla.GetDecimal(2),
                            Porcentaje = readerTabla.GetDecimal(3)
                        });
                        isr15 = ISR15.ToArray();
                    }
                    readerTabla.Close();

                    //SqlCommand queryTablaSub = N.Conexion.PerformConnectionSoprade().CreateCommand();
                    SqlCommand queryTablaSub = N.Conexion.PerformConnection().CreateCommand();
                    queryTablaSub.CommandText = @"select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                            from TablaCalculos 
                            where tnudIDTnum = 'SUB15'";

                    SqlDataReader readerTablaSub = queryTablaSub.ExecuteReader();
                    while (readerTablaSub.Read())
                    {
                        SUB15.Add(new E.SUB15
                        {
                            rango1 = readerTablaSub.GetDecimal(0),
                            rango2 = readerTablaSub.GetDecimal(1),
                            subsidio = readerTablaSub.GetDecimal(2)
                        });
                        sub15 = SUB15.ToArray();
                    }
                    readerTablaSub.Close();
                    //N.Conexion.PerformConnectionSoprade().Close();
                    N.Conexion.PerformConnection().ChangeDatabase(BD);

                    foreach (var valor in sub15)
                    {
                        if (Ingresos >= valor.rango1 && Ingresos <= valor.rango2)
                        {
                            calculo.Sub = Math.Round(valor.subsidio, 2);
                        }
                    }

                    foreach (var valor in isr15)
                    {
                        if (Ingresos >= valor.LimiteInferior && Ingresos <= valor.LimiteSuperior)
                        {
                            calculo.LimInferior = Math.Round(valor.LimiteInferior, 2);
                            //calculo.PerExLimInf = Math.Round(valor.Porcentaje,2);
                            calculo.PerExLimInf = valor.Porcentaje;
                            calculo.CF = Math.Round(valor.CuotaFija, 2);
                        }
                    }
                    calculo.ExLimInf = Math.Round(calculo.IngresosBrutos - calculo.LimInferior, 2);
                    calculo.ImpMarg = Math.Round(calculo.ExLimInf * calculo.PerExLimInf, 2);
                    calculo.ISR = Math.Round(calculo.CF + calculo.ImpMarg, 2);
                    calculo.IngresosNetos = Math.Round(calculo.IngresosBrutos - calculo.ISR + calculo.Sub, 2);
                }

                if (Periodicidad.Equals("Mensual") || Periodicidad.Equals("05"))
                {
                    var ISR30 = new List<E.ISR30>();
                    E.ISR30[] isr30 = null;

                    var SUB30 = new List<E.SUB30>();
                    E.SUB30[] sub30 = null;

                    //N.Conexion.PerformConnectionSoprade().Open();
                    //SqlCommand queryTablaISR = N.Conexion.PerformConnectionSoprade().CreateCommand();
                    N.Conexion.PerformConnection().Close();
                    N.Conexion.PerformConnection().Open();
                    SqlCommand queryTablaISR = N.Conexion.PerformConnection().CreateCommand();
                    //queryTablaISR.CommandText = @"select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                    //from genTablasNumericasDet 
                    //where tnudIDTnum = 'ISR15'";  
                    queryTablaISR.CommandText = @"  select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                                from TablaCalculos 
                                where tnudIDTnum = 'ISR30'";

                    SqlDataReader readerTabla;
                    readerTabla = queryTablaISR.ExecuteReader();

                    while (readerTabla.Read())
                    {
                        ISR30.Add(new E.ISR30
                        {
                            LimiteInferior = readerTabla.GetDecimal(0),
                            LimiteSuperior = readerTabla.GetDecimal(1),
                            CuotaFija = readerTabla.GetDecimal(2),
                            Porcentaje = readerTabla.GetDecimal(3)
                        });
                        isr30 = ISR30.ToArray();
                    }
                    readerTabla.Close();

                    //SqlCommand queryTablaSub = N.Conexion.PerformConnectionSoprade().CreateCommand();
                    SqlCommand queryTablaSub = N.Conexion.PerformConnection().CreateCommand();
                    queryTablaSub.CommandText = @"select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                                from TablaCalculos 
                                where tnudIDTnum = 'SUB30'";

                    SqlDataReader readerTablaSub = queryTablaSub.ExecuteReader();
                    while (readerTablaSub.Read())
                    {
                        SUB30.Add(new E.SUB30
                        {
                            rango1 = readerTablaSub.GetDecimal(0),
                            rango2 = readerTablaSub.GetDecimal(1),
                            subsidio = readerTablaSub.GetDecimal(2)
                        });
                        sub30 = SUB30.ToArray();
                    }
                    readerTablaSub.Close();
                    //N.Conexion.PerformConnectionSoprade().Close();
                    N.Conexion.PerformConnection().ChangeDatabase(BD);

                    foreach (var valor in sub30)
                    {
                        if (Ingresos >= valor.rango1 && Ingresos <= valor.rango2)
                        {
                            calculo.Sub = Math.Round(valor.subsidio, 2);
                        }
                    }

                    foreach (var valor in isr30)
                    {
                        if (Ingresos >= valor.LimiteInferior && Ingresos <= valor.LimiteSuperior)
                        {
                            calculo.LimInferior = Math.Round(valor.LimiteInferior, 2);
                            //calculo.PerExLimInf = Math.Round(valor.Porcentaje,2);
                            calculo.PerExLimInf = valor.Porcentaje;
                            calculo.CF = Math.Round(valor.CuotaFija, 2);
                        }
                    }
                    calculo.ExLimInf = Math.Round(calculo.IngresosBrutos - calculo.LimInferior, 2);
                    calculo.ImpMarg = Math.Round(calculo.ExLimInf * calculo.PerExLimInf, 2);
                    calculo.ISR = Math.Round(calculo.CF + calculo.ImpMarg, 2);
                    calculo.IngresosNetos = Math.Round(calculo.IngresosBrutos - calculo.ISR + calculo.Sub, 2);
                }
                //}
                return calculo;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: GeneraCalculo()", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return null;
            }
        }
        public E.Calculo GeneraCalculoInverso(decimal Ingresos, string Periodicidad, string BD)//, string TipoIngresos)
        {
            try
            {
                E.Calculo calculo = new E.Calculo();

                //if (TipoIngresos.Equals("Brutos"))
                //{
                calculo.IngresosNetos = Math.Round(Ingresos, 2);

                if (Periodicidad.Equals("Semanal") || Periodicidad.Equals("02"))
                {
                    var ISR07 = new List<E.ISR7>();
                    E.ISR7[] isr07 = null;

                    var SUB07 = new List<E.SUB7>();
                    E.SUB7[] sub07 = null;

                    //N.Conexion.PerformConnectionSoprade().Open();
                    //SqlCommand queryTablaISR = N.Conexion.PerformConnectionSoprade().CreateCommand();
                    N.Conexion.PerformConnection().Close();
                    N.Conexion.PerformConnection().Open();
                    SqlCommand queryTablaISR = N.Conexion.PerformConnection().CreateCommand();
                    //queryTablaISR.CommandText = @"select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                    //from genTablasNumericasDet 
                    //where tnudIDTnum = 'ISR07'";  
                    queryTablaISR.CommandText = @"  select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                        from TablaCalculos 
                        where tnudIDTnum = 'ISR07'";

                    SqlDataReader readerTabla;
                    readerTabla = queryTablaISR.ExecuteReader();

                    while (readerTabla.Read())
                    {
                        ISR07.Add(new E.ISR7
                        {
                            LimiteInferior = readerTabla.GetDecimal(0),
                            LimiteSuperior = readerTabla.GetDecimal(1),
                            CuotaFija = readerTabla.GetDecimal(2),
                            Porcentaje = readerTabla.GetDecimal(3)
                        });
                        isr07 = ISR07.ToArray();
                    }
                    readerTabla.Close();
                    SqlCommand queryTablaSub = N.Conexion.PerformConnection().CreateCommand();
                    queryTablaSub.CommandText = @"select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                        from TablaCalculos 
                        where tnudIDTnum = 'SUB07'";

                    SqlDataReader readerTablaSub = queryTablaSub.ExecuteReader();
                    while (readerTablaSub.Read())
                    {
                        SUB07.Add(new E.SUB7
                        {
                            rango1 = readerTablaSub.GetDecimal(0),
                            rango2 = readerTablaSub.GetDecimal(1),
                            subsidio = readerTablaSub.GetDecimal(2)
                        });
                        sub07 = SUB07.ToArray();
                    }
                    readerTablaSub.Close();
                    N.Conexion.PerformConnectionSoprade().Close();

                    foreach (var valor in sub07)
                    {
                        if (Ingresos >= valor.rango1 && Ingresos <= valor.rango2)
                        {
                            calculo.Sub = Math.Round(valor.subsidio, 2);
                        }
                    }

                    foreach (var valor in isr07)
                    {
                        if (Ingresos >= valor.LimiteInferior && Ingresos <= valor.LimiteSuperior)
                        {
                            calculo.LimInferior = Math.Round(valor.LimiteInferior, 2);
                            //calculo.PerExLimInf = Math.Round(valor.Porcentaje,2);
                            calculo.PerExLimInf = valor.Porcentaje;
                            calculo.CF = Math.Round(valor.CuotaFija, 2);
                        }
                    }
                    calculo.ExLimInf = Math.Round(calculo.IngresosNetos - calculo.LimInferior, 2);
                    calculo.ImpMarg = Math.Round(calculo.ExLimInf * calculo.PerExLimInf, 2);
                    calculo.ISR = Math.Round(calculo.CF + calculo.ImpMarg, 2);
                    calculo.IngresosBrutos = Math.Round(calculo.IngresosNetos + calculo.ISR + calculo.Sub, 2);
                }

                if (Periodicidad.Equals("Quincenal") || Periodicidad.Equals("04"))
                {
                    var ISR15 = new List<E.ISR15>();
                    E.ISR15[] isr15 = null;

                    var SUB15 = new List<E.SUB15>();
                    E.SUB15[] sub15 = null;

                    //N.Conexion.PerformConnectionSoprade().Open();
                    //SqlCommand queryTablaISR = N.Conexion.PerformConnectionSoprade().CreateCommand();
                    N.Conexion.PerformConnection().Close();
                    N.Conexion.PerformConnection().Open();
                    SqlCommand queryTablaISR = N.Conexion.PerformConnection().CreateCommand();
                    //queryTablaISR.CommandText = @"select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                    //from genTablasNumericasDet 
                    //where tnudIDTnum = 'ISR15'";  
                    queryTablaISR.CommandText = @"  select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                            from TablaCalculos 
                            where tnudIDTnum = 'ISR15'";

                    SqlDataReader readerTabla;
                    readerTabla = queryTablaISR.ExecuteReader();

                    while (readerTabla.Read())
                    {
                        ISR15.Add(new E.ISR15
                        {
                            LimiteInferior = readerTabla.GetDecimal(0),
                            LimiteSuperior = readerTabla.GetDecimal(1),
                            CuotaFija = readerTabla.GetDecimal(2),
                            Porcentaje = readerTabla.GetDecimal(3)
                        });
                        isr15 = ISR15.ToArray();
                    }
                    readerTabla.Close();
                    //SqlCommand queryTablaSub = N.Conexion.PerformConnectionSoprade().CreateCommand();
                    SqlCommand queryTablaSub = N.Conexion.PerformConnection().CreateCommand();
                    queryTablaSub.CommandText = @"select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                            from TablaCalculos 
                            where tnudIDTnum = 'SUB15'";


                    SqlDataReader readerTablaSub = queryTablaSub.ExecuteReader();
                    while (readerTablaSub.Read())
                    {
                        SUB15.Add(new E.SUB15
                        {
                            rango1 = readerTablaSub.GetDecimal(0),
                            rango2 = readerTablaSub.GetDecimal(1),
                            subsidio = readerTablaSub.GetDecimal(2)
                        });
                        sub15 = SUB15.ToArray();
                    }
                    readerTablaSub.Close();
                    N.Conexion.PerformConnectionSoprade().Close();

                    foreach (var valor in sub15)
                    {
                        if (Ingresos >= valor.rango1 && Ingresos <= valor.rango2)
                        {
                            calculo.Sub = Math.Round(valor.subsidio, 2);
                        }
                    }

                    foreach (var valor in isr15)
                    {
                        if (Ingresos >= valor.LimiteInferior && Ingresos <= valor.LimiteSuperior)
                        {
                            calculo.LimInferior = Math.Round(valor.LimiteInferior, 2);
                            //calculo.PerExLimInf = Math.Round(valor.Porcentaje,2);
                            calculo.PerExLimInf = valor.Porcentaje;
                            calculo.CF = Math.Round(valor.CuotaFija, 2);
                        }
                    }
                    calculo.ExLimInf = Math.Round(calculo.IngresosNetos - calculo.LimInferior, 2);
                    calculo.ImpMarg = Math.Round(calculo.ExLimInf * calculo.PerExLimInf, 2);
                    calculo.ISR = Math.Round(calculo.CF + calculo.ImpMarg, 2);
                    calculo.IngresosBrutos = Math.Round(calculo.IngresosNetos + calculo.ISR + calculo.Sub, 2);
                }

                if (Periodicidad.Equals("Mensual") || Periodicidad.Equals("05"))
                {
                    var ISR30 = new List<E.ISR30>();
                    E.ISR30[] isr30 = null;

                    var SUB30 = new List<E.SUB30>();
                    E.SUB30[] sub30 = null;

                    //N.Conexion.PerformConnectionSoprade().Open();
                    //SqlCommand queryTablaISR = N.Conexion.PerformConnectionSoprade().CreateCommand();
                    N.Conexion.PerformConnection().Close();
                    N.Conexion.PerformConnection().Open();
                    SqlCommand queryTablaISR = N.Conexion.PerformConnection().CreateCommand();
                    //queryTablaISR.CommandText = @"select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                    //from genTablasNumericasDet 
                    //where tnudIDTnum = 'ISR15'";  
                    queryTablaISR.CommandText = @"  select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                                from TablaCalculos 
                                where tnudIDTnum = 'ISR30'";

                    SqlDataReader readerTabla;
                    readerTabla = queryTablaISR.ExecuteReader();

                    while (readerTabla.Read())
                    {
                        ISR30.Add(new E.ISR30
                        {
                            LimiteInferior = readerTabla.GetDecimal(0),
                            LimiteSuperior = readerTabla.GetDecimal(1),
                            CuotaFija = readerTabla.GetDecimal(2),
                            Porcentaje = readerTabla.GetDecimal(3)
                        });
                        isr30 = ISR30.ToArray();
                    }
                    readerTabla.Close();
                    //SqlCommand queryTablaSub = N.Conexion.PerformConnectionSoprade().CreateCommand();
                    SqlCommand queryTablaSub = N.Conexion.PerformConnection().CreateCommand();
                    queryTablaSub.CommandText = @"select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                                from TablaCalculos 
                                where tnudIDTnum = 'SUB30'";


                    SqlDataReader readerTablaSub = queryTablaSub.ExecuteReader();
                    while (readerTablaSub.Read())
                    {
                        SUB30.Add(new E.SUB30
                        {
                            rango1 = readerTablaSub.GetDecimal(0),
                            rango2 = readerTablaSub.GetDecimal(1),
                            subsidio = readerTablaSub.GetDecimal(2)
                        });
                        sub30 = SUB30.ToArray();
                    }
                    readerTablaSub.Close();

                    //N.Conexion.PerformConnectionSoprade().Close();
                    N.Conexion.PerformConnection().ChangeDatabase(BD);

                    foreach (var valor in sub30)
                    {
                        if (Ingresos >= valor.rango1 && Ingresos <= valor.rango2)
                        {
                            calculo.Sub = Math.Round(valor.subsidio, 2);
                        }
                    }

                    foreach (var valor in isr30)
                    {
                        if (Ingresos >= valor.LimiteInferior && Ingresos <= valor.LimiteSuperior)
                        {
                            calculo.LimInferior = Math.Round(valor.LimiteInferior, 2);
                            //calculo.PerExLimInf = Math.Round(valor.Porcentaje,2);
                            calculo.PerExLimInf = valor.Porcentaje;
                            calculo.CF = Math.Round(valor.CuotaFija, 2);
                        }
                    }
                    calculo.ExLimInf = Math.Round(calculo.IngresosNetos - calculo.LimInferior, 2);
                    calculo.ImpMarg = Math.Round(calculo.ExLimInf * calculo.PerExLimInf, 2);
                    calculo.ISR = Math.Round(calculo.CF + calculo.ImpMarg, 2);
                    calculo.IngresosBrutos = Math.Round(calculo.IngresosNetos + calculo.ISR + calculo.Sub, 2);
                }
                //}

                return calculo;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: GeneraCalculo()", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return null;
            }
        }

        public E.Empleado BuscaEmpleado(string RFC)
        {
            try
            {
                string Empresa = Properties.Settings.Default["EmpresaNominaID"].ToString();
                E.Empleado empleado = new E.Empleado();                
                SqlCommand queryEmpleado = N.Conexion.PerformConnection().CreateCommand();
                queryEmpleado.CommandText = @"select NUM_EMPLEADO, RFC, CURP, [PERIODICIDAD_PAGO]
                , NOMBRE, TIPO_REGIMEN, TIPO_CONTRATO, SINDICALIZADO
                , DEPARTAMENTO, PUESTO
                ,ISNULL([CUENTA], 'No Definido') as [CUENTA]
                ,ISNULL([CLABE_BANCARIA], 'No Definido') as [CLABE_BANCARIA]
                ,ISNULL([CVE_BANCO], 'S/D') as [CVE_BANCO]
                ,ISNULL([BANCO], 'No Definido') as [BANCO]
                ,ISNULL([EMPRESA], 'No Definido')as [EMPRESA]
                ,ISNULL([ID_EMPRESA], 'No Definido') as [ID EMPRESA]
                ,ISNULL([TIPO_PAGO], 'No Definido') as [TIPO_PAGO]
                ,ISNULL([PORCENTAJE_DESCUENTO], 0) as [PORCENTAJE_DESCUENTO]
                ,ISNULL([MAIL],'') as [MAIL]
                from EMPLEADOS 
                inner join [dbo].[PeriodicidadPago] as Peri
                on EMPLEADOS.PERIODICIDAD_PAGO = Peri.c_PeriodicidadPago
                WHERE RFC = @RFC
                AND [nominaEmpresaID] = @Empresa";

                queryEmpleado.Parameters.AddWithValue("@RFC", RFC);
                queryEmpleado.Parameters.AddWithValue("@Empresa", Empresa);

                SqlDataReader readerEmpleado;
                readerEmpleado = queryEmpleado.ExecuteReader();

                if (readerEmpleado.Read())
                {
                    empleado.NumEmpl = readerEmpleado.GetString(0);
                    empleado.RFC = readerEmpleado.GetString(1);
                    empleado.CURP = readerEmpleado.GetString(2);
                    empleado.Periodicidad = readerEmpleado.GetString(3);
                    empleado.Nombre = readerEmpleado.GetString(4);
                    empleado.TipoRegimen = readerEmpleado.GetString(5);
                    empleado.TipoContrato = readerEmpleado.GetString(6);
                    empleado.Sindicalizado = readerEmpleado.GetString(7);
                    empleado.Departamento = readerEmpleado.GetString(8);
                    empleado.Puesto = readerEmpleado.GetString(9);
                    empleado.cuenta = readerEmpleado.GetString(10);
                    empleado.clabe_bancaria = readerEmpleado.GetString(11);
                    empleado.cve_banco = readerEmpleado.GetString(12);
                    empleado.banco = readerEmpleado.GetString(13);
                    empleado.empresa = readerEmpleado.GetString(14);
                    empleado.idEmpresa = readerEmpleado.GetString(15);
                    empleado.tipoPago = readerEmpleado.GetString(16);
                    empleado.descuento = readerEmpleado.GetDecimal(17);
                    empleado.Correo = readerEmpleado.GetString(18);
                }
                readerEmpleado.Close();

                //XtraMessageBox.Show(empleado.NumEmpl + "\n" + empleado.RFC + "\n" + empleado.CURP + "\n" + empleado.Periodicidad);

                return empleado;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: BuscaEmpleado()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<E.ISR30> GetISR30(string BD, List<E.ISR30> iSR30s)
        {
            try
            {
                N.Conexion.PerformConnection().Close();
                N.Conexion.PerformConnection().Open();
                SqlCommand queryTablaISR = N.Conexion.PerformConnection().CreateCommand();
                //queryTablaISR.CommandText = @"select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                //from genTablasNumericasDet 
                //where tnudIDTnum = 'ISR15'";  
                queryTablaISR.CommandText = @"  select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                                from TablaCalculos 
                                where tnudIDTnum = 'ISR30'";

                SqlDataReader readerTabla;
                readerTabla = queryTablaISR.ExecuteReader();

                while (readerTabla.Read())
                {
                    iSR30s.Add(new E.ISR30
                    {
                        LimiteInferior = readerTabla.GetDecimal(0),
                        LimiteSuperior = readerTabla.GetDecimal(1),
                        CuotaFija = readerTabla.GetDecimal(2),
                        Porcentaje = readerTabla.GetDecimal(3)
                    });
                }
                readerTabla.Close();
                N.Conexion.PerformConnection().ChangeDatabase(BD);

                return iSR30s;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: GetISR30()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<E.Colonia> Colonias(string BD, string CP, List<E.Colonia> colonias)
        {
            try
            {
                N.Conexion.PerformConnection().Close();
                N.Conexion.PerformConnection().Open();

                SqlCommand queryColonias = N.Conexion.PerformConnection().CreateCommand();
                queryColonias.CommandText = @"select d_codigo, d_asenta from Codigos_Postales where d_codigo = @Codigo";
                queryColonias.Parameters.AddWithValue("@Codigo", CP);

                SqlDataReader ReaderColonias;
                ReaderColonias = queryColonias.ExecuteReader();

                while (ReaderColonias.Read())
                {
                    colonias.Add(new E.Colonia {
                        ID = ReaderColonias.GetString(0),
                        Nombre = ReaderColonias.GetString(1)
                    });
                }
                ReaderColonias.Close();
                N.Conexion.PerformConnection().ChangeDatabase(BD);

                return colonias;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: Colonias()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<E.ClienteAsimilado> Clientes(string empresa, List<E.ClienteAsimilado> clientes)
        {
            try
            {
                N.Conexion.PerformConnection().Open();
                SqlCommand queryClientes = N.Conexion.PerformConnection().CreateCommand();
                queryClientes.CommandText = @"SELECT [ID]
                 ,[CLIENTE]
                  FROM [dbo].[ClientesAsimilados]
                  WHERE [EMPRESA_PAGADORA_EMITE_CFDI] = @Empresa";
                queryClientes.Parameters.AddWithValue("@Empresa", empresa);

                SqlDataReader readerClietnes;
                readerClietnes = queryClientes.ExecuteReader();

                while (readerClietnes.Read())
                {
                    clientes.Add(new E.ClienteAsimilado
                    {
                        ID = readerClietnes.GetString(0),
                        CLIENTE = readerClietnes.GetString(1)
                    });
                }
                readerClietnes.Close();
                return clientes;
            }
            catch(Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: Lista Clientes()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<E.Municipio> Municipios(string BD, string Estado, List<E.Municipio> municipios)
        {
            try
            {
                int ID = 0;
                E.Municipio[] Muni = null;
                //List ListPoblacion = null;
                N.Conexion.PerformConnection().Close();
                N.Conexion.PerformConnection().Open();

                SqlCommand QueryIdEstado = N.Conexion.PerformConnection().CreateCommand();
                QueryIdEstado.CommandText = @"select id from Estados_Republica where [Nombre del estado] = @Estado";
                QueryIdEstado.Parameters.AddWithValue("@Estado", Estado);

                SqlDataReader ReaderEstado;
                ReaderEstado = QueryIdEstado.ExecuteReader();

                if (ReaderEstado.Read())
                {
                    ID = ReaderEstado.GetInt32(0);
                    //XtraMessageBox.Show(ID.ToString());
                }
                ReaderEstado.Close();

                SqlCommand QueryMunicipios = N.Conexion.PerformConnection().CreateCommand();
                QueryMunicipios.CommandText = @"select id, nombre from Municipios where estado_id = @EstadoID";
                QueryMunicipios.Parameters.AddWithValue("@EstadoID", ID);
                SqlDataReader ReaderMunicipios;
                ReaderMunicipios = QueryMunicipios.ExecuteReader();

                while (ReaderMunicipios.Read())
                {
                    municipios.Add(new E.Municipio
                    {
                        ID = ReaderMunicipios.GetInt32(0),
                        Nombre = ReaderMunicipios.GetString(1)
                    });
                    Muni = municipios.ToArray();
                }
                ReaderMunicipios.Close();

                N.Conexion.PerformConnection().ChangeDatabase(BD);

                return municipios;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: Lista Poblacion()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<E.ListaBancos> Bancos(string empresa, List<E.ListaBancos> bancos)
        {
            try
            {
                SqlCommand queryBancos = N.Conexion.PerformConnection().CreateCommand();
                queryBancos.CommandText = @"SELECT
                [ID]
                ,[Banco]
                ,ISNULL([Cuenta], 'No Definido') As [Cuenta]
                ,ISNULL([CLABE], 'No Definido') AS [CLABE]
             FROM [dbo].[CatalogoBancosEmpresaPagaAsimilados]
                WHERE IDEmpresa = @ID";
                queryBancos.Parameters.AddWithValue("ID", empresa);

                SqlDataReader readerBanco = queryBancos.ExecuteReader();
                while (readerBanco.Read())
                {
                    bancos.Add(new E.ListaBancos
                    {
                        ID = readerBanco.GetInt32(0),
                        Nombre = readerBanco.GetString(1),
                        cuenta = readerBanco.GetString(2),
                        CLABE = readerBanco.GetString(3)
                    });
                }
                readerBanco.Close();
                return bancos;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: Lista Bancos()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<E.ListaClaveProdServ> ClavesClientes(string cliente, List<E.ListaClaveProdServ> listaClaves)
        {
            try
            {
                SqlCommand getLista = N.Conexion.PerformConnection().CreateCommand();
                getLista.CommandText = @"SELECT
                [ClaveServProd]
                --,[Concepto]
                 FROM [dbo].[ClavesServCliente]
                 WHERE [IDClte] = @cliente";
                getLista.Parameters.AddWithValue("@cliente", cliente);

                SqlDataReader readerLista;
                readerLista = getLista.ExecuteReader();

                while (readerLista.Read())
                {
                    listaClaves.Add(new E.ListaClaveProdServ
                    {
                        clave = readerLista.GetString(0),
                        //descripcion = readerLista.GetString(1)
                    });
                }
                readerLista.Close();
                return listaClaves;
            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: ListaClavesServ()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public E.ClaveProdServ GetClaveProdServ(string clave)
        {
            try
            {
                E.ClaveProdServ claveProd = new E.ClaveProdServ();
                SqlCommand getClave = N.Conexion.PerformConnection().CreateCommand();
                getClave.CommandText = @"SELECT [c_ClaveProdServ]
                  ,[Descripcion]
                  FROM [dbo].[ClaveProdServ]
                  WHERE [c_ClaveProdServ] = @clave";
                getClave.Parameters.AddWithValue("@clave", clave);

                SqlDataReader readerClave;
                readerClave = getClave.ExecuteReader();

                if (readerClave.Read())
                {
                    claveProd.clave = Convert.ToString(readerClave.GetDouble(0));
                    claveProd.descripcion = readerClave.GetString(1);
                }
                readerClave.Close();
                return claveProd;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: GetClaveProdServ()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public string CreaTablas2()
        {
            try
            {
                string path = @"C:\DocAsimilados\CreaTablasEmpresa.sql";
                StreamReader sr = new StreamReader(path);
                string query = sr.ReadToEnd();

                return query;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message);
                return null;
            }
        }
        public bool CreaTablas(string BD)
        {
            try
            {
                string path = @"C:\DocAsimilados\CreaTablasEmpresa.sql";
                string path2 = @"C:\DocAsimilados\resultado.txt";
                ProcessStartInfo cmd;
                cmd = new ProcessStartInfo("sqlcmd", "-S SERVER-CONTPAQ\\COMPAC17 -U sa -P Supervisor2020. -q use " + BD + @"-o C:\DocAsimilados\resultado.txt");
                cmd.UseShellExecute = false;
                cmd.CreateNoWindow = false;
                cmd.RedirectStandardOutput = true;

                Process process = new Process();
                process.StartInfo = cmd;
                process.Start();
                return true;
            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: CreaTablas()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool EditaEmpresa(Object _P, string RFC, string bd)
        {
            try
            {
                bool result = false;
                E.Parametros parametros = (E.Parametros)_P;
                N.Conexion.PerformConnection().Close();
                N.Conexion.PerformConnection().Open();
                SqlCommand queryLocalidad = N.Conexion.PerformConnection().CreateCommand();
                queryLocalidad.CommandText = @"Select clave from Municipios where nombre = @municipio";
                queryLocalidad.Parameters.AddWithValue("@municipio", parametros.MUNICIPIO);

                SqlDataReader readerLocalidad;
                readerLocalidad = queryLocalidad.ExecuteReader();
                if (readerLocalidad.Read())
                {
                    parametros.LOCALIDAD = readerLocalidad.GetString(0);
                }
                readerLocalidad.Close();

                SqlCommand queryPais = N.Conexion.PerformConnection().CreateCommand();
                queryPais.CommandText = @"select [c_Pais] from [Estados_Republica] where [Nombre del estado] = @estado";
                queryPais.Parameters.AddWithValue("estado", parametros.ESTADO);

                SqlDataReader readerPais;
                readerPais = queryPais.ExecuteReader();
                if (readerPais.Read())
                {
                    parametros.PAIS = readerPais.GetString(0);
                }
                readerPais.Close();

                N.Conexion.PerformConnection().ChangeDatabase(bd);

                SqlCommand queryActEmpr = N.Conexion.PerformConnection().CreateCommand();
                queryActEmpr.CommandText = @"UPDATE [dbo].[PARAMETROS]
                SET [NOMBRE_EMPRESA] = '" + parametros.NombreEmpresa +
                "',[RFC] = '" + parametros.RFC +
                "',[REGISTRO_PATRONAL] = '" + parametros.RegistroPatronal +
                "',[CALLE] = '" + parametros.Calle +
                "',[NUM_EXT] = '" + parametros.NUM_EXT +
                "',[NUM_INT] = '" + parametros.NUM_INT +
                "',[CODIGO_POSTAL] = '" + parametros.CODIGO_POSTAL +
                "',[MUNICIPIO] = '" + parametros.MUNICIPIO +
                "',[LOCALIDAD] = '" + parametros.LOCALIDAD +
                "',[ESTADO] = '" + parametros.ESTADO +
                "',[PAIS] = '" + parametros.PAIS +
                "',[REGIMEN] = '" + parametros.REGIMEN +
                "',[RIESGO_PUESTO] = '" + parametros.RIESGO_PUESTO +
                "',[CLAVE_CERTIFICADO] = '" + parametros.CLAVE_CERTIFICADO +
                "',[NUMERO_CERTIFICADO] = '" + parametros.NUMERO_CERTIFICADO +
                "',[FECHA_VENCIMIENTO_CERTIFICADO] = '" + parametros.FECHA_VENCIMIENTO_CERTIFICADO.ToString("dd/MM/yyyy") +
                "',[FECHA_INICIO_CERTIFICADO] = '" + parametros.FECHA_INICIO_CERTIFICADO.ToString("dd/MM/yyyy") +
                 "',[ORIGEN_RECURSOS] = '" + parametros.ORIGEN_RECURSOS +
                "',[TIPO_NOMINA] = '" + parametros.TIPO_NOMINA +
                "',[ARCHIVO_CER] = '" + parametros.ARCHIVO_CER +
                "',[ARCHIVO_KEY] = '" + parametros.ARCHIVO_KEY +
                "',[ASUNTO_CERTIFICADO] = '" + parametros.ASUNTO_CERTIFICADO +
                "',[COLONIA] = '" + parametros.COLONIA +
                "',[CUENTA_ORIGEN] = '" + parametros.cuentaOrigen + "' WHERE RFC ='" + RFC + "'";

                if (queryActEmpr.ExecuteNonQuery().Equals(1))
                {
                    N.Conexion.PerformConnection().Close();
                    N.Conexion.PerformConnection().Open();
                    SqlCommand queryListaEmpr = N.Conexion.PerformConnection().CreateCommand();
                    queryListaEmpr.CommandText = @"UPDATE [dbo].[Listado_Empresas]
                    SET Nombre_Empresa = '" + parametros.NombreEmpresa +
                    "', RFC_Empresa = '" + parametros.RFC + "'" +
                    "WHERE RFC_Empresa = '" + parametros.RFC + "'";

                    if (queryListaEmpr.ExecuteNonQuery().Equals(1))
                    {
                        result = true;
                        N.Conexion.PerformConnection().ChangeDatabase(bd);
                        XtraMessageBox.Show("¡Información de la Empresa Actualizada con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: EditaEmpresa()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void CreaBDEmpresa(string BD, Object _P, SplashScreenManager splashScreenManager, Object _A)
        {
            try
            {
                E.Empresa empresa = (E.Empresa)_P;
                E.Parametros parametros = (E.Parametros)_A;

                //splashScreenManager.WaitForSplashFormClose();
                string nameDB = "Nomina_Empresa", newNameDB = null, localidad = null, fechaIniCer = parametros.FECHA_INICIO_CERTIFICADO.ToString("dd/MM/yyyy"), fechaFincer = parametros.FECHA_VENCIMIENTO_CERTIFICADO.ToString("yyy-MM-dd");
                int num = 0, nextNum = 0;
                string ruta = @"C:/XML/";
                parametros.RUTA_ALMACEN_PDF = ruta;
                N.Conexion.PerformConnection().Close();
                N.Conexion.PerformConnection().Open();

                SqlCommand queryNumEmpresa = N.Conexion.PerformConnection().CreateCommand();
                queryNumEmpresa.CommandText = @"select  max(numero_empresa) from Listado_Empresas";
                SqlDataReader readerNumEmpresa;
                readerNumEmpresa = queryNumEmpresa.ExecuteReader();

                if (readerNumEmpresa.Read())
                {
                    num = readerNumEmpresa.GetInt32(0);
                    nextNum = num + 1;
                }
                readerNumEmpresa.Close();
                newNameDB = nameDB + nextNum.ToString();
                parametros.NOMINA_EMPRESA_ID = newNameDB;
                //XtraMessageBox.Show(newNameDB);

                SqlCommand queryInsertEmpr = N.Conexion.PerformConnection().CreateCommand();
                queryInsertEmpr.CommandText = @"INSERT INTO [dbo].[Listado_Empresas]
                ([Numero_Empresa]
                ,[Nombre_Empresa]
                ,[RFC_Empresa]
                ,[STATUS]
                ,[TablaEmpresa])
                VALUES
                (" + nextNum + ", '" + empresa.empresa + "', '" + empresa.RFC + "', 1, '" + newNameDB + "')";
                #region creaBD
                //SqlCommand queryCreaBD = N.Conexion.PerformConnection().CreateCommand();
                //queryCreaBD.CommandText = @"CREATE DATABASE " + newNameDB;
                #endregion

                #region creaTablas 
                //SqlCommand queryCreaTablas2 = N.Conexion.PerformConnection().CreateCommand();
                //queryCreaTablas2.CommandText = CreaTablas2();
                //SqlCommand queryCreaTablas = N.Conexion.PerformConnection().CreateCommand();
                #endregion
                SqlCommand queryLocalidad = N.Conexion.PerformConnection().CreateCommand();
                queryLocalidad.CommandText = @"Select clave from [dbo].[Municipios] where nombre = @municipio";
                queryLocalidad.Parameters.AddWithValue("@municipio", parametros.MUNICIPIO);

                SqlDataReader readerLocalidad;
                readerLocalidad = queryLocalidad.ExecuteReader();
                if (readerLocalidad.Read())
                {
                    parametros.LOCALIDAD = readerLocalidad.GetString(0);
                }
                readerLocalidad.Close();

                SqlCommand queryPais = N.Conexion.PerformConnection().CreateCommand();
                queryPais.CommandText = @"select [c_Pais] from [dbo].[Estados_Republica] where [Nombre del estado] = @estado";
                queryPais.Parameters.AddWithValue("estado", parametros.ESTADO);

                SqlDataReader readerPais;
                readerPais = queryPais.ExecuteReader();
                if (readerPais.Read())
                {
                    parametros.PAIS = readerPais.GetString(0);
                }
                readerPais.Close();

                //XtraMessageBox.Show(parametros.FECHA_VENCIMIENTO_CERTIFICADO.ToShortDateString() + "\n" + parametros.FECHA_INICIO_CERTIFICADO.ToShortDateString());
                SqlCommand queryParametros = N.Conexion.PerformConnection().CreateCommand();
                queryParametros.CommandText = @"INSERT INTO [dbo].[PARAMETROS]
                                               ([NOMBRE_EMPRESA]
                                               ,[RFC]
                                               ,[REGISTRO_PATRONAL]
                                               ,[CALLE]
                                               ,[NUM_EXT]
                                               ,[NUM_INT]
                                               ,[CODIGO_POSTAL]
                                               ,[MUNICIPIO]
                                               ,[LOCALIDAD]
                                               ,[ESTADO]
                                               ,[PAIS]
                                               ,[REGIMEN]
                                               ,[RIESGO_PUESTO]
                                               ,[CLAVE_CERTIFICADO]
                                               ,[NUMERO_CERTIFICADO]
                                               ,[FECHA_VENCIMIENTO_CERTIFICADO]
                                               ,[FECHA_INICIO_CERTIFICADO]
                                               ,[ORIGEN_RECURSOS]
                                               ,[TIPO_NOMINA]
                                               ,[ARCHIVO_CER]
                                               ,[ARCHIVO_KEY]
                                               ,[ASUNTO_CERTIFICADO]
                                               ,[COLONIA]
                                               ,[RUTA_ALMACEN_PDF]
                                                ,[CUENTA_ORIGEN]
                                                ,[USUARIO_NTLINK]
                                                ,[NOMINA_EMPRESA_ID])
                                         VALUES
                                               ('" + parametros.NombreEmpresa + "'," +
                                               "'" + parametros.RFC + "'," +
                                               "'" + parametros.RegistroPatronal + "'," +
                                               "'" + parametros.Calle + "'," +
                                               "'" + parametros.NUM_EXT + "'," +
                                               "'" + parametros.NUM_INT + "'," +
                                               "'" + parametros.CODIGO_POSTAL + "'," +
                                               "'" + parametros.MUNICIPIO + "'," +
                                               "'" + parametros.LOCALIDAD + "'," +
                                               "'" + parametros.ESTADO + "'," +
                                               "'" + parametros.PAIS + "'," +
                                               "'" + parametros.REGIMEN + "'," +
                                               "'" + parametros.RIESGO_PUESTO + "'," +
                                               "'" + parametros.CLAVE_CERTIFICADO + "'," +
                                               "'" + parametros.NUMERO_CERTIFICADO + "'," +
                                               "'" + fechaFincer + "'," +
                                               "'" + fechaIniCer + "'," +
                                               "'" + parametros.ORIGEN_RECURSOS + "'," +
                                               "'" + parametros.TIPO_NOMINA + "'," +
                                               "'" + parametros.ARCHIVO_CER + "'," +
                                               "'" + parametros.ARCHIVO_KEY + "'," +
                                               "'" + parametros.ASUNTO_CERTIFICADO + "'," +
                                               "'" + parametros.COLONIA + "'," +
                                               "'" + parametros.RUTA_ALMACEN_PDF + "'," +
                                               "'" + parametros.cuentaOrigen + "'," +
                                               "'" + parametros.usuarioNtlink + "'," +
                                               "'" + parametros.NOMINA_EMPRESA_ID + "')";

                if (queryInsertEmpr.ExecuteNonQuery().Equals(1))
                {
                    #region if creacion bd y tablas
                    //if (!queryCreaBD.ExecuteNonQuery().Equals(1))
                    //{
                    //    N.Conexion.PerformConnection().ChangeDatabase(newNameDB);
                    //    if (!queryCreaTablas2.ExecuteNonQuery().Equals(0))
                    //    {
                    //        //XtraMessageBox.Show("¡Empresa Agregada con Éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        //splashScreenManager.CloseWaitForm();
                    //        //XtraMessageBox.Show(queryParametros.CommandText.ToString());
                    //        if (queryParametros.ExecuteNonQuery().Equals(1))
                    //        {
                    //            splashScreenManager.CloseWaitForm();
                    //            XtraMessageBox.Show("¡Empresa Agregada con Éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        }
                    //    }
                    //}
                    #endregion
                    if (queryParametros.ExecuteNonQuery().Equals(1))
                    {
                        splashScreenManager.CloseWaitForm();
                        XtraMessageBox.Show("¡Empresa Agregada con Éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                //N.Conexion.PerformConnection().ChangeDatabase(BD);
                //splashScreenManager.CloseWaitForm();
                N.Conexion.PerformConnection().Close();
            }
            catch (Exception e)
            {
                if (splashScreenManager.IsSplashFormVisible.Equals(true))
                {
                    splashScreenManager.CloseWaitForm();
                }
                N.Conexion.PerformConnection().Close();
                XtraMessageBox.Show(e.Message + "\nError Controlador:CrearBDEmpresa()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public bool AccedeEmpresa(string Empresa)
        {
            try
            {
                N.Conexion.PerformConnection().Open();
                //N.Conexion.PerformConnection().ChangeDatabase(Empresa);
                N.Conexion.PerformConnection().Close();
                return true;
            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError en controlador:AccedeEmpresa()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                N.Conexion.PerformConnection().Close();
                return false;
            }
        }
        public bool AgregaUsuario(Object _P, string BD)
        {
            try
            {
                E.User user = (E.User)_P;
                N.Conexion.PerformConnection().Close();
                N.Conexion.PerformConnection().Open();
                SqlCommand queryInsertaUsuario = N.Conexion.PerformConnection().CreateCommand();
                queryInsertaUsuario.CommandText = @"INSERT INTO [dbo].[UsuariosSistema]
                ([usuarioNombre]
                ,[usuarioID]
                ,[usuarioPass]
                ,[usuarioFecReg]
                ,[usuarioStatus]
                ,[usuarioTipo])
                VALUES
                ('" + user.nombre + "'" +
                ",'" + user.usuario + "'" +
                ",'" + user.pass + "'" +
                ",'" + user.fecReg.ToString("dd/MM/yyyy") + "'" +
                ",'" + user.estatusUsuario + "'" +
                ",'" + user.tipoUsiario + "')";

                if (queryInsertaUsuario.ExecuteNonQuery().Equals(1))
                {
                    XtraMessageBox.Show("¡Usuario Creado con Éxito!", "Mensaje"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    N.Conexion.ChangeConnection(BD);
                    return true;
                }
                else
                {
                    return false;
                }
            } catch (Exception e)
            {
                N.Conexion.ChangeConnection(BD);
                XtraMessageBox.Show(e.Message + "\nError Controlador:AgregaUsuario()"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool EditaUsuario(Object _P, string BD)
        {
            try
            {
                E.User user = (E.User)_P;
                N.Conexion.PerformConnection().Close();
                N.Conexion.PerformConnection().Open();
                SqlCommand queryEditaUsuario = N.Conexion.PerformConnection().CreateCommand();
                queryEditaUsuario.CommandText = @"UPDATE [dbo].[UsuariosSistema]
                 SET [usuarioNombre] = '" + user.nombre + "'" +
                 ",[usuarioID] = '" + user.usuario + "'" +
                 ",[usuarioPass] = '" + user.pass + "'" +
                 ",[usuarioStatus] = '" + user.estatusUsuario + "'" +
                 ",[usuarioTipo] = '" + user.tipoUsiario + "'" +
                 ",[usuarioFecMod] = '" + user.fecMod.ToString("dd/MM/yyyy") + "'" +
                 "WHERE [ID] = " + user.ID;
                if (queryEditaUsuario.ExecuteNonQuery().Equals(1))
                {
                    N.Conexion.ChangeConnection(BD);
                    return true;
                }
                else
                {
                    N.Conexion.ChangeConnection(BD);
                    return false;
                }
            }
            catch (Exception e)
            {
                N.Conexion.ChangeConnection(BD);
                XtraMessageBox.Show(e.Message + "\nError Controlador:EditaUsuario()",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public E.User BuscaUsuario(string ID)
        {
            try
            {
                E.User user = new E.User();
                D.clsSeguridad seguridad = new D.clsSeguridad();
                SqlCommand queryBuscaUsuario = N.Conexion.PerformConnection().CreateCommand();
                queryBuscaUsuario.CommandText = @"SELECT [ID]
                ,[usuarioNombre]
                ,[usuarioID]
                ,[usuarioPass]
                ,[usuarioFecReg]
                ,[usuarioStatus]
                ,[usuarioTipo]
                ,isnull([usuarioFecMod], '1900-01-01') as [usuarioFecMod]
                FROM [dbo].[UsuariosSistema]
                WHERE [ID] = @ID";
                queryBuscaUsuario.Parameters.AddWithValue("@ID", ID);

                SqlDataReader readerUsuario;
                readerUsuario = queryBuscaUsuario.ExecuteReader();

                if (readerUsuario.Read())
                {
                    user.ID = readerUsuario.GetInt32(0);
                    user.nombre = readerUsuario.GetString(1);
                    user.usuario = readerUsuario.GetString(2);
                    user.pass = seguridad.DecryptString(readerUsuario.GetString(3));
                    user.fecReg = readerUsuario.GetDateTime(4);
                    user.estatusUsuario = readerUsuario.GetString(5);
                    user.tipoUsiario = readerUsuario.GetString(6);
                    user.fecMod = readerUsuario.GetDateTime(7);
                }
                readerUsuario.Close();

                return user;
            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador:BuscaUsuario", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public bool Login(Object _P)
        {
            try
            {
                E.User User = (E.User)_P;
                //N.Conexion.PerformConnectionSoprade().Open();
                //SqlCommand queryLogin = N.Conexion.PerformConnectionSoprade().CreateCommand();
                N.Conexion.PerformConnection().Open();
                SqlCommand queryLogin = N.Conexion.PerformConnection().CreateCommand();
                D.clsSeguridad seguridad = new D.clsSeguridad();
                SqlDataReader readerLogin;
                string passEncrip = seguridad.EncryptString(User.pass);

                //XtraMessageBox.Show("\nPASS: " + passEncrip + "\nUsua: " + User.usuario.ToUpper());

                //queryLogin.CommandText = @"select usuaIDUsua, usuaPasswd from segUsuarios where usuaIDUsua = @usuario and usuaPasswd = @pass";
                queryLogin.CommandText = @"select
                usuarioID
                ,usuarioPass
                from UsuariosSistema
                where usuarioID = @usuario
                and usuarioPass = @pass";
                queryLogin.Parameters.AddWithValue("@usuario", User.usuario.ToUpper());
                queryLogin.Parameters.AddWithValue("@pass", passEncrip.ToString());
                readerLogin = queryLogin.ExecuteReader();


                if (readerLogin.Read())
                {
                    //XtraMessageBox.Show("Entra", "");
                    //Form1 frm = new Form1();
                    //frm.Show();
                    readerLogin.Close();
                    N.Conexion.PerformConnection().Close();
                    //N.Conexion.PerformConnectionSoprade().Close();
                    return true;
                }
                else
                {
                    //XtraMessageBox.Show("no entra", "");
                    readerLogin.Close();
                    N.Conexion.PerformConnection().Close();
                    //N.Conexion.PerformConnectionSoprade().Close();
                    return false;
                }



            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "Error login()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //N.Conexion.PerformConnectionSoprade().Close();
                return false;
            }
        }

        public bool AgregaEmpleado(Object _P)
        {
            try
            {
                E.Empleado empleado = (E.Empleado)_P;
                int numEmplAnt = 0, numEmplNue = 0;
                SqlCommand queryNumEmpl = N.Conexion.PerformConnection().CreateCommand();
                queryNumEmpl.CommandText = @"select ISNULL(max (cast(NUM_EMPLEADO as int)), 0) from EMPLEADOS";
                SqlDataReader readerNumEmpl;
                readerNumEmpl = queryNumEmpl.ExecuteReader();

                if (readerNumEmpl.Read())
                {
                    numEmplAnt = Convert.ToInt32(readerNumEmpl.GetInt32(0));
                    numEmplNue = numEmplAnt + 1;
                }
                readerNumEmpl.Close();
                //XtraMessageBox.Show(numEmplAnt + "\n" + numEmplNue);

                SqlCommand queryBuscaEmpl = N.Conexion.PerformConnection().CreateCommand();
                queryBuscaEmpl.CommandText = @"select * from Empleados where RFC = @rfc";
                SqlDataReader ReaderEmpl;
                queryBuscaEmpl.Parameters.AddWithValue("@rfc", empleado.RFC);
                ReaderEmpl = queryBuscaEmpl.ExecuteReader();
                // con esta se agrega el empleado unitario
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
                ,[SINDICALIZADO]
                ,[CUENTA]
                ,[CLABE_BANCARIA]
                ,[BANCO]
                ,[CVE_BANCO]
                ,[EMPRESA]
                ,[ID_EMPRESA]
                ,[PORCENTAJE_DESCUENTO]
                ,[TIPO_PAGO]
                ,[MAIL]
                ,[nominaEmpresaID])
                VALUES
                ('" + empleado.NumEmpl + "','" + empleado.Nombre + "','" + empleado.RFC + "','" + empleado.CURP + "','" + "09'," + "'ASIMILADO'," + "'01/01/1900'," + "'ASIMILADO',"
                + "'99'," + "'00','" + empleado.Periodicidad + "'," + "'No'" +
                ",'" + empleado.cuenta + "'" +
                ",'" + empleado.clabe_bancaria + "'" +
                ",'" + empleado.banco + "'" +
                ",'" + empleado.cve_banco + "'" +
                ",'" + empleado.empresa + "'" +
                ",'" + empleado.idEmpresa + "'" +
                "," + empleado.descuento + "" +
                ",'" + empleado.tipoPago + "'" +
                ",'" + empleado.Correo + "'" +
                ",'" + empleado.nominaEmpresaID + "')";

                if (ReaderEmpl.Read())
                {
                    XtraMessageBox.Show("El empleado Con RFC: " + empleado.RFC + "Ya se encuentra registrado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReaderEmpl.Close();
                    return true;
                }
                else
                {
                    //XtraMessageBox.Show("No existe");
                    ReaderEmpl.Close();
                    if (queryInsertaEmpl.ExecuteNonQuery().Equals(1))
                    {
                        XtraMessageBox.Show("¡Empleado agregado satisfactoriamente!", "Agregar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: AgregaEmpleado()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public void EditarEmpleado(Object _P, string rfc/*, SplashScreenManager splashScreenManager*/)
        {
            try
            {
                E.Empleado empleado = (E.Empleado)_P;

                //query update
                SqlCommand queryUpdateEmpl = N.Conexion.PerformConnection().CreateCommand();
                queryUpdateEmpl.CommandText = @"UPDATE EMPLEADOS set NOMBRE = '" + empleado.Nombre + "'," + "RFC = '" + rfc + "',"
                + "CURP = '" + empleado.CURP + "', PERIODICIDAD_PAGO = '" + empleado.Periodicidad + "'" +
                ",CUENTA = '" + empleado.cuenta + "'" +
                ",CLABE_BANCARIA = '" + empleado.clabe_bancaria + "'" +
                ",CVE_BANCO = '" + empleado.cve_banco + "'" +
                ",BANCO = '" + empleado.banco + "'" +
                ",EMPRESA = '" + empleado.empresa + "'" +
                ",ID_EMPRESA = '" + empleado.idEmpresa + "'" +
                ",TIPO_PAGO = '" + empleado.tipoPago + "'" +
                ",PORCENTAJE_DESCUENTO = '" + empleado.descuento + "'" +
                ",MAIL = '" + empleado.Correo + "'" +
                ",  NUM_EMPLEADO = '" + empleado.NumEmpl + "'" +
                "where RFC = '" + empleado.RFC + "'"; //lo modifica por el ID del empleado
                if (queryUpdateEmpl.ExecuteNonQuery().Equals(1))
                {
                    //splashScreenManager.CloseWaitForm();
                    XtraMessageBox.Show("¡Información Actualizada Con Éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //splashScreenManager.CloseWaitForm();
                    XtraMessageBox.Show("¡Error Al  Actualizar La Información!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception e)
            {
                //splashScreenManager.CloseWaitForm();
                XtraMessageBox.Show(e.Message + "\nError Controlador: EditarEMpleado()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LogTimbradoUnitario(E.Empleado empleado, string mensaje)
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
                string NombreArchivo = "Timbrado" + "_" + empleado.Nombre + "_" + Convert.ToString(DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-"
                + DateTime.Now.Year.ToString() + ", " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString()
                + "-" + DateTime.Now.Second.ToString());
                string path = Path.Combine(url, NombreArchivo + ".txt");

                builder = new StringBuilder();
                builder.AppendLine();
                builder.Append("********************************   Erroes Encontrados  ******************************************" + "\r\n");
                builder.AppendLine();
                builder.Append("Nombre del empleado:" + empleado.Nombre + "\r\n");
                builder.AppendLine();
                builder.Append(mensaje);
                builder.AppendLine();
                builder.AppendLine();
                builder.Append("********************************       Fin Erroes      ******************************************" + "\r\n");
                writer = new StreamWriter(path, true);
                writer.Write(builder);
                writer.Close();
                Process proceso = new Process();
                proceso.StartInfo.FileName = path;
                proceso.Start();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: LogTimradoUnitario()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void GeneraLayoutBanorte(List<E.Layout> ListaLayout, string nombreLayout, SplashScreenManager splash /*,E.Parametros empresa*/)
        {
            try
            {
                if (splash.IsSplashFormVisible.Equals(true))
                {
                    splash.SetWaitFormCaption("Generando Layout Pago..");
                }

                SqlCommand updateErrorLayout = N.Conexion.PerformConnection().CreateCommand();
                int errorCuentaOrigen = 0, errorDestino = 0, cont = -1, exito = 0, errorImporte = 0, errorIDEmpresa = 0;
                int validaCuentaOrigen = 0, validaDestino = 0, validaImporte = 0, validaIDEmpresa = 0;
                string mensaje = "";
                StreamWriter writerLog = null;
                StringBuilder builderLog = null;
                StreamWriter writerLayout = null;
                StringBuilder builderLayout = null;
                bool sig = false, nombre = true;

                string urlLog = @"C:\AsimiladosLogs\";
                if (!Directory.Exists(urlLog))
                {
                    Directory.CreateDirectory(urlLog);
                }

                string urlLayout = @"C:\AsimiladosLayout\";
                if (!Directory.Exists(urlLayout))
                {
                    Directory.CreateDirectory(urlLayout);
                }

                string NombreArchivoLog = nombreLayout;

                //string NombreArchivoLog ="ErrorGenLayout_" + nombreLayout +"_" +Convert.ToString(DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-"
                //+ DateTime.Now.Year.ToString() + ", " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString()
                //+ "-" + DateTime.Now.Second.ToString());
                string pathLog = Path.Combine(urlLog, NombreArchivoLog + ".txt");

                string NombreArchivoLayout = nombreLayout;
                string pathLayout = Path.Combine(urlLayout, NombreArchivoLayout + ".txt");

                builderLog = new StringBuilder();
                //builderLog.AppendLine();
                builderLog.Append("********************************   Erroes Encontrados  ******************************************" + "\r\n");
                builderLayout = new StringBuilder();

                foreach (var item in ListaLayout)
                {
                    try
                    {
                        cont++;

                        nombre = true;
                        if (item.cuentaOrigen.Length > 10)
                        {
                            if (nombre.Equals(true))
                            {
                                builderLog.Append("Nombre del empleado:" + item.nombreEmpleado + "\r\n");
                                builderLog.AppendLine();
                                nombre = false;
                            }
                            errorCuentaOrigen++;
                            mensaje = "Cuenta Origen mayor a 10 digitos";
                            builderLog.Append(mensaje);
                            builderLog.AppendLine();
                            builderLog.AppendLine();
                            sig = true;
                            updateErrorLayout.CommandText = @"UPDATE LayoutHistorico SET estatus = 'ERROR', descripcionError = '" + mensaje + "' where Layout = '" + item.layout + "' and numEmpl = '" + item.numEmpl + "'";
                            updateErrorLayout.ExecuteNonQuery();
                        }
                        else if (item.cuentaOrigen.Length < 10)
                        {
                            if (nombre.Equals(true))
                            {
                                builderLog.Append("Nombre del empleado:" + item.nombreEmpleado + "\r\n");
                                builderLog.AppendLine();
                                nombre = false;
                            }
                            errorCuentaOrigen++;
                            mensaje = "Cuenta Origen menor a 10 digitos";
                            builderLog.Append(mensaje);
                            builderLog.AppendLine();
                            builderLog.AppendLine();
                            sig = true;
                            updateErrorLayout.CommandText = @"UPDATE LayoutHistorico SET estatus = 'ERROR', descripcionError = '" + mensaje + "' where Layout = '" + item.layout + "' and numEmpl = '" + item.numEmpl + "'";
                            updateErrorLayout.ExecuteNonQuery();
                        }
                        else
                        {
                            validaCuentaOrigen = 1;
                        }
                        if (item.cuentaClaveDestino.Length < 10)
                        {

                            if (nombre.Equals(true))
                            {
                                builderLog.Append("Nombre del empleado:" + item.nombreEmpleado + "\r\n");
                                builderLog.AppendLine();
                                nombre = false;
                            }
                            errorDestino++;
                            mensaje = "Cuenta/CLABE Destino menor a 10 digitos";
                            builderLog.Append(mensaje);
                            builderLog.AppendLine();
                            builderLog.AppendLine();
                            sig = true;
                            updateErrorLayout.CommandText = @"UPDATE LayoutHistorico SET estatus = 'ERROR', descripcionError = '" + mensaje + "' where Layout = '" + item.layout + "' and numEmpl = '" + item.numEmpl + "'";
                            updateErrorLayout.ExecuteNonQuery();
                        }
                        else if (item.cuentaClaveDestino.Length > 18)
                        {
                            if (nombre.Equals(true))
                            {
                                builderLog.Append("Nombre del empleado:" + item.nombreEmpleado + "\r\n");
                                builderLog.AppendLine();
                                nombre = false;
                            }
                            errorDestino++;
                            mensaje = "Cuenta/CLABE Destino mayor a 18 digitos";
                            builderLog.Append(mensaje);
                            builderLog.AppendLine();
                            builderLog.AppendLine();
                            sig = true;
                            updateErrorLayout.CommandText = @"UPDATE LayoutHistorico SET estatus = 'ERROR', descripcionError = '" + mensaje + "' where Layout = '" + item.layout + "' and numEmpl = '" + item.numEmpl + "'";
                            updateErrorLayout.ExecuteNonQuery();
                        }
                        else if (item.cuentaClaveDestino.Equals("No Definido") || item.cuentaClaveDestino.Equals("0"))
                        {
                            if (nombre.Equals(true))
                            {
                                builderLog.Append("Nombre del empleado:" + item.nombreEmpleado + "\r\n");
                                builderLog.AppendLine();
                                nombre = false;
                            }
                            errorDestino++;
                            mensaje = "Cuenta/CLABE NO Definida, verificar información empleado.";
                            builderLog.Append(mensaje);
                            builderLog.AppendLine();
                            builderLog.AppendLine();
                            sig = true;
                            updateErrorLayout.CommandText = @"UPDATE LayoutHistorico SET estatus = 'ERROR', descripcionError = '" + mensaje + "' where Layout = '" + item.layout + "' and numEmpl = '" + item.numEmpl + "'";
                            updateErrorLayout.ExecuteNonQuery();
                        }
                        else
                        {
                            validaDestino = 1;
                        }
                        if (item.importe.Equals(0))
                        {
                            if (nombre.Equals(true))
                            {
                                builderLog.Append("Nombre del empleado:" + item.nombreEmpleado + "\r\n");
                                builderLog.AppendLine();
                                nombre = false;
                            }
                            errorImporte++;
                            mensaje = "Importe debe ser MAYOR a 0.";
                            builderLog.Append(mensaje);
                            builderLog.AppendLine();
                            builderLog.AppendLine();
                            sig = true;
                            updateErrorLayout.CommandText = @"UPDATE LayoutHistorico SET estatus = 'ERROR', descripcionError = '" + mensaje + "' where Layout = '" + item.layout + "' and numEmpl = '" + item.numEmpl + "'";
                            updateErrorLayout.ExecuteNonQuery();
                        }
                        else
                        {
                            validaImporte = 1;
                        }
                        if (item.claveID.Equals("No Definido") || item.claveID.Equals("0"))
                        {
                            if (nombre.Equals(true))
                            {
                                builderLog.Append("Nombre del empleado:" + item.nombreEmpleado + "\r\n");
                                builderLog.AppendLine();
                                nombre = false;
                            }
                            errorIDEmpresa++;
                            mensaje = "Clave ID no Definida";
                            builderLog.Append(mensaje);
                            builderLog.AppendLine();
                            builderLog.AppendLine();
                            sig = true;
                            updateErrorLayout.CommandText = @"UPDATE LayoutHistorico SET estatus = 'ERROR', descripcionError = '" + mensaje + "' where Layout = '" + item.layout + "' and numEmpl = '" + item.numEmpl + "'";
                            updateErrorLayout.ExecuteNonQuery();
                        }
                        else
                        {
                            validaIDEmpresa = 1;
                        }
                        if (cont + 1 < ListaLayout.Count() && sig.Equals(true))
                        {
                            builderLog.Append("*************************************************************************************************");
                            builderLog.AppendLine();
                        }


                        if (validaDestino == 1 && validaCuentaOrigen == 1 && validaImporte == 1 && validaIDEmpresa == 1)
                        {
                            exito++;
                            validaDestino = 0;
                            validaCuentaOrigen = 0;
                            validaImporte = 0;
                            validaIDEmpresa = 0;
                        }

                        if (exito > 0/* && errorDestino == 0 && errorCuentaOrigen == 0 && errorImporte == 0 && errorIDEmpresa == 0*/)
                        {
                            builderLayout.Append(item.operacion + "\t" + item.claveID + "\t" + item.cuentaOrigen + "\t" + item.cuentaClaveDestino + "\t" + item.importe + "\t" + item.referencia + "\t" + item.descripcion + "\t" + item.RFCOrdenante + "\t" + item.IVA + "\t" + item.fechaAplicacion.ToString("ddMMyyyy") + "\t" + item.institucionPago + "\t" + item.claveTipoCambio);
                            builderLayout.AppendLine();
                        }

                        if (cont + 1 == ListaLayout.Count())
                        {
                            if (errorDestino > 0 || errorCuentaOrigen > 0 || errorIDEmpresa > 0 || errorImporte > 0)
                            {
                                int error = errorCuentaOrigen + errorDestino + errorImporte + errorIDEmpresa;
                                builderLog.AppendLine();
                                builderLog.Append("********************************       Fin Erroes      ******************************************" + "\r\n");

                                if (splash.IsSplashFormVisible.Equals(true))
                                {
                                    splash.CloseWaitForm();
                                }
                                XtraMessageBox.Show("¡Layout generado con " + error + " errores registrados y "
                                + exito + " registros con éxito! \n(Presione aceptar para ver errores)", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Information);

                                writerLog = new StreamWriter(pathLog, true);
                                writerLog.Write(builderLog);
                                writerLog.Close();

                                Process procesoLog = new Process();
                                procesoLog.StartInfo.FileName = pathLog;
                                procesoLog.Start();

                                if (exito > 0)
                                {
                                    writerLayout = new StreamWriter(pathLayout, true);
                                    writerLayout.Write(builderLayout);
                                    writerLayout.Close();

                                    Process procesoLayout = new Process();
                                    procesoLayout.StartInfo.FileName = pathLayout;
                                    procesoLayout.Start();
                                }
                            }

                            if (errorCuentaOrigen.Equals(0) && errorDestino.Equals(0) && exito > 0)
                            {
                                mensaje = "Sin Error";
                                updateErrorLayout.CommandText = @"UPDATE LayoutHistorico SET estatus = 'Generado', descripcionError = '" + mensaje + "' where Layout = '" + item.layout + "' and numEmpl = '" + item.numEmpl + "'";
                                updateErrorLayout.ExecuteNonQuery();
                                if (splash.IsSplashFormVisible.Equals(true))
                                {
                                    splash.CloseWaitForm();
                                }
                                XtraMessageBox.Show("¡Layout generado con éxito! \n(Presione aceptar para ver Layout)", "Mensaje"
                                , MessageBoxButtons.OK, MessageBoxIcon.Information);

                                writerLayout = new StreamWriter(pathLayout, true);
                                writerLayout.Write(builderLayout);
                                writerLayout.Close();

                                Process procesoLayout = new Process();
                                procesoLayout.StartInfo.FileName = pathLayout;
                                procesoLayout.Start();

                            }

                        }

                    }
                    catch (Exception lista)
                    {
                        if (splash.IsSplashFormVisible.Equals(true))
                        {
                            splash.CloseWaitForm();
                        }
                        XtraMessageBox.Show(lista.Message + "\nError Controlador: GeneraLayoutBanorte():Foreach():ListaLayout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception e)
            {
                if (splash.IsSplashFormVisible.Equals(true))
                {
                    splash.CloseWaitForm();
                }
                XtraMessageBox.Show(e.Message + "\nError Controlador:GeneraLayoutBanorte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void InsertaCaratula(E.Caratula caratula, SplashScreenManager splash)
        {
            try
            {
                SqlCommand queryInsertaCaratula = N.Conexion.PerformConnection().CreateCommand();
                queryInsertaCaratula.CommandText = @"INSERT INTO [dbo].[CaratulaPago]
               ([Caratula]
               ,[Layout]
               ,[IDCliente]
               ,[Cliente]
               ,[IDEmpresa]
               ,[Empresa]
               ,[FechaCreacion]
               ,[FechaAplicacion]
               ,[FechaIniPeriodo]
               ,[FechaFinPeriodo]
               ,[TotalEmpleados]
               ,[TotalPagoAsimilados]
               ,[usuario]
               ,[TipoPeri]
               ,[AsimiSalarios]
               ,[ProvAguinaldo]
               ,[ProviVacaciones]
               ,[ProviPrimVacacional]
               ,[SubTotalIAS]
               ,[ComisionServicio]
               ,[ImpNomi]
               ,[Total]
               ,[IVA]
               ,[RetencionIVA]
               ,[TotalFactura]
               ,[Ajuste]
               ,[TotalDeposito]
               ,[Banco]
               ,[NumCuenta]
               ,[CLABE]
               ,[ClaveFacturacion]
               ,[TipoPago]
               ,[FormaPago]
               ,[Observaciones]
               ,[RutaLogo]
               ,[Imagen]
      ,[PorcentajeISN]
      ,[PorcentajeComision]
      ,[PorcentajeRetencion]
      ,[descuentos]
,[nominaEmpresaID])
         VALUES
               ('" + caratula.caratula + "'" +
               ",'" + caratula.Layout + "'" +
               ",'" + caratula.IDCliente + "'" +
               ",'" + caratula.Cliente + "'" +
               ",'" + caratula.IDEmpresa + "'" +
               ",'" + caratula.Empresa + "'" +
               "," + "GETDATE()" + "" +
               ",'" + caratula.FechaAplicacion.ToString("dd/MM/yyyy") + "'" +
               ",'" + caratula.FechaIniPeriodo.ToString("dd/MM/yyyy") + "'" +
               ",'" + caratula.FechaFinPeriodo.ToString("dd/MM/yyyy") + "'" +
               "," + caratula.TotalEmpleados + "" +
               "," + caratula.TotalPagoAsimilados + "" +
               ",'" + caratula.usuario + "'" +
               ",'" + caratula.TipoPeri + "'" +
               "," + caratula.AsimiSalarios + "" +
               "," + caratula.ProvAguinaldo + "" +
               "," + caratula.ProviVacaciones + "" +
               "," + caratula.ProviPrimVacacional + "" +
               "," + caratula.SubTotalIAS + "" +
               "," + caratula.ComisionServicio + "" +
               "," + caratula.ImpNomi + "" +
               "," + caratula.Total + "" +
               "," + caratula.IVA + "" +
               "," + caratula.RetencionIVA + "" +
               "," + caratula.TotalFactura + "" +
               "," + caratula.Ajuste + "" +
               "," + caratula.TotalDeposito + "" +
               ",'" + caratula.Banco + "'" +
               ",'" + caratula.NumCuenta + "'" +
               ",'" + caratula.CLABE + "'" +
               ",'" + caratula.ClaveFacturacion + "'" +
               ",'" + caratula.TipoPago + "'" +
               ",'" + caratula.FormaPago + "'" +
               ",'" + caratula.Observaciones + "'" +
               ",'" + caratula.RutaLogo + "'" +
               ",'" + caratula.Imagen + "'" +
               "," + caratula.PorcentajeISN + "" +
               "," + caratula.PorcentajeComision + "" +
               "," + caratula.PorcentajeRetencion + "" +
               "," + caratula.descuentos + "" +
               ",'"+ caratula.nominaEmpresaID + "')";

                queryInsertaCaratula.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (splash.IsSplashFormVisible.Equals(true))
                {
                    splash.CloseWaitForm();
                }
                XtraMessageBox.Show(e.Message + "\nError Controlador: InsertaCaratula()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool ReabrirCaratula(string caratula, string usuario)
        {
            try
            {
                string Empresa = Properties.Settings.Default["EmpresaNominaID"].ToString();
                SqlCommand actualizaStatus = N.Conexion.PerformConnection().CreateCommand();
                actualizaStatus.CommandText = @"Update caratulapago
                set Estatus = 'Generado'
                , FechaReAperturaCaratula = GETDATE()
                , UsuarioReApertura = '" + usuario + "' " +
                "where Caratula = '" + caratula + "'" +
                " AND nominaEmpresaID = '" + Empresa + "'";

                if (actualizaStatus.ExecuteNonQuery().Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: ReabrirCaratula()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool ActualizaStatusCaratula(string caratula, string usuario)
        {
            try
            {
                string Empresa = Properties.Settings.Default["EmpresaNominaID"].ToString();
                SqlCommand actualizaStatus = N.Conexion.PerformConnection().CreateCommand();
                actualizaStatus.CommandText = @"Update caratulapago
                set Estatus = 'Pagado'
                , FechaValidaPago = GETDATE()
                , UsuarioPago = '" + usuario + "' " +
                "where Caratula = '" + caratula + "'" +
                "AND nominaEmpresaID = '" + Empresa + "'";

                if (actualizaStatus.ExecuteNonQuery().Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: ActualizaStatusCaratula()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void ActualizaStatusLayout(string caratula, string status)
        {
            try
            {
                string Empresa = Properties.Settings.Default["EmpresaNominaID"].ToString();
                SqlCommand updateLayout = N.Conexion.PerformConnection().CreateCommand();
                updateLayout.CommandText = @"UPDATE [dbo].[LayoutHistorico]
                        SET [estatus] = '" + status + "'" +
                        "where [Caratula] = '" + caratula + "'" +
                        "AND  [nominaEmpresaID] = '" + Empresa + "'";

                updateLayout.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: ActualizaCaratula()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public bool ActualizaCaratula(E.Caratula caratula, SplashScreenManager splash)
        {
            try
            {
                string Empresa = Properties.Settings.Default["EmpresaNominaID"].ToString();
                SqlCommand updateCaratula = N.Conexion.PerformConnection().CreateCommand();
                updateCaratula.CommandText = @"UPDATE [dbo].[CaratulaPago]
               SET 
                  [IDCliente] = '" + caratula.IDCliente + "'" +
                  ",[Cliente] = '" + caratula.Cliente + "'" +
                  ",[IDEmpresa] = '" + caratula.IDEmpresa + "'" +
                  ",[Empresa] = '" + caratula.Empresa + "'" +
                  ",[FechaAplicacion] = '" + caratula.FechaAplicacion.ToString("dd/MM/yyyy") + "'" +
                  ",[FechaIniPeriodo] = '" + caratula.FechaIniPeriodo.ToString("dd/MM/yyyy") + "'" +
                  ",[FechaFinPeriodo] = '" + caratula.FechaFinPeriodo.ToString("dd/MM/yyyy") + "'" +
                  ",[TotalEmpleados] = " + caratula.TotalEmpleados + "" +
                  ",[TotalPagoAsimilados] = " + caratula.TotalPagoAsimilados + "" +
                  ",[TipoPeri] = '" + caratula.TipoPeri + "'" +
                  ",[AsimiSalarios] = " + caratula.AsimiSalarios + "" +
                  ",[ProvAguinaldo] = " + caratula.ProvAguinaldo + "" +
                  ",[ProviVacaciones] = " + caratula.ProviVacaciones + "" +
                  ",[ProviPrimVacacional] = " + caratula.ProviPrimVacacional + "" +
                  ",[SubTotalIAS] = " + caratula.SubTotalIAS + "" +
                  ",[ComisionServicio] = " + caratula.ComisionServicio + "" +
                  ",[ImpNomi] = " + caratula.ImpNomi + "" +
                  ",[Total] =  " + caratula.Total + "" +
                  ",[IVA] = " + caratula.IVA + "" +
                  ",[RetencionIVA] = " + caratula.RetencionIVA + "" +
                  ",[TotalFactura] = " + caratula.TotalFactura + "" +
                  ",[Ajuste] = " + caratula.Ajuste + "" +
                  ",[TotalDeposito] = " + caratula.TotalDeposito + "" +
                  ",[Banco] = '" + caratula.Banco + "'" +
                  ",[NumCuenta] = '" + caratula.NumCuenta + "'" +
                  ",[CLABE] = '" + caratula.CLABE + "'" +
                  ",[ClaveFacturacion] = '" + caratula.ClaveFacturacion + "'" +
                  ",[TipoPago] = '" + caratula.TipoPago + "'" +
                  ",[FormaPago] = '" + caratula.FormaPago + "'" +
                  ",[Observaciones] = '" + caratula.Observaciones + "'" +
                  ",[FechaModificacion] = " + "GETDATE()" + "" +
                  ",[UsuarioModificacion] = '" + caratula.UsuarioModificacion + "'" +
                  "WHERE ID = '" + caratula.ID + "'" +
                  "AND nominaEmpresaID = '" + Empresa + "'";

                if (updateCaratula.ExecuteNonQuery().Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } catch (Exception e)
            {
                if (splash.IsSplashFormVisible.Equals(true))
                {
                    splash.CloseWaitForm();
                }
                XtraMessageBox.Show(e.Message + "\nError Controlador: ActualizaCaratula()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void InsertaLayout(List<E.Layout> listaLayout, SplashScreenManager splash/*, string BD*/)
        {
            try
            {
                StreamWriter writer = null;
                StringBuilder builder = null;
                string url = @"C:\AsimiladosLogs\";
                string nombreEmpleado = "";
                int error = 0;
                if (!Directory.Exists(url))
                {
                    Directory.CreateDirectory(url);
                }
                string NombreArchivo = "GenLayOut" + "_" + "GuardarMovimiento" + "_" + Convert.ToString(DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-"
                + DateTime.Now.Year.ToString() + ", " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString()
                + "-" + DateTime.Now.Second.ToString());
                string path = Path.Combine(url, NombreArchivo + ".txt");

                builder = new StringBuilder();
                builder.AppendLine();
                builder.Append("********************************   Erroes Encontrados  ******************************************" + "\r\n");
                builder.AppendLine();
                //N.Conexion.PerformConnection().Close();
                //N.Conexion.PerformConnection().Open();

                SqlCommand queryInsertaLayout = N.Conexion.PerformConnection().CreateCommand();

                foreach (var item in listaLayout)
                {
                    try
                    {
                        nombreEmpleado = item.nombreEmpleado;
                        if (splash.IsSplashFormVisible.Equals(false))
                        {
                            splash.ShowWaitForm();
                        }
                        splash.SetWaitFormCaption("Guardando Movimientos de\n" + item.nombreEmpleado + "..");
                        queryInsertaLayout.CommandText = @"INSERT INTO [dbo].[LayoutHistorico]
                       ([numEmpl]
                       ,[nombreEmpleado]
                       ,[RFCEmpleado]
                       ,[CURPEmpleado]
                       ,[PeriodicidadPago]
                       ,[ingresos]
                       ,[LimInferior]
                       ,[ExLimInf]
                       ,[PerExLimInf]
                       ,[ImpMarg]
                       ,[CF]
                       ,[ISR]
                       ,[ingresosNeto]
                       ,[operacion]
                       ,[claveID]
                       ,[cuentaOrigen]
                       ,[cuenta_ClaveDestino]
                       ,[importe]
                       ,[referencia]
                       ,[descripcion]
                       ,[RFCOrdenante]
                       ,[IVA]
                       ,[fechaAplicacion]
                       ,[fecIniPeri]
                       ,[fecFinPeri]
                       ,[InstruccionPago]
                       ,[claveTipoCambio]
                       ,[fechaCreacion]
                       --,[estatus]
                       ,[BancoEmpleado]
                       ,[sub]
                       ,[Caratula]
                       ,[IDEmpresaPago]
                       ,[IDPeriodo]
                       ,[IDCliente]
                       ,[Layout]
                       ,[tipoPago]
                       ,[otrosConceptos]
                       ,[depositoNeto]
                       ,[cuentaBancaria]
                       ,[CLABE]
                       ,[bancoEmpresaPago]
                        ,[descuentos]
                        ,[nominaEmpresaID])
                 VALUES
                       ('" + item.numEmpl + "'" +
                       ",'" + item.nombreEmpleado + "'" +
                       ",'" + item.RFCEmpleado + "'" +
                       ",'" + item.CURPEmpleado + "'" +
                       ",'" + item.periPago + "'" +
                       "," + item.ingresos + "" +
                       "," + item.LimInferior + "" +
                       "," + item.ExLimInf + "" +
                       "," + item.PerExLimInf + "" +
                       "," + item.ImpMarg + "" +
                       "," + item.CF + "" +
                       "," + item.ISR + "" +
                       "," + item.ingresosNet + "" +
                       ",'" + item.operacion + "'" +
                       ",'" + item.claveID + "'" +
                       ",'" + item.cuentaOrigen + "'" +
                       ",'" + item.cuentaClaveDestino + "'" +
                       "," + item.importe + "" +
                       ",'" + item.referencia + "'" +
                       ",'" + item.descripcion + "'" +
                       ",'" + item.RFCOrdenante + "'" +
                       "," + item.IVA + "" +
                       ",'" + item.fechaAplicacion.ToString("dd/MM/yyyy") + "'" +
                       ",'" + item.fecIniPeri.ToString("dd/MM/yyyy") + "'" +
                       ",'" + item.fecFinPeri.ToString("dd/MM/yyyy") + "'"
                       + ",'" + item.institucionPago + "'" +
                       ",'" + item.claveTipoCambio + "'" +
                       "," + "GETDATE()" + "" +
                       ",'" + item.bancoEmpleado + "'" +
                       "," + item.Sub + "" +
                      ",'" + item.caratula + "'" +
                      ",'" + item.IDEmpresa + "'" +
                      ",'" + item.periodo + "'" +
                      ",'" + item.IDCliente + "'" +
                      ",'" + item.layout + "'" +
                      ",'" + item.tipoPago + "'" +
                      "," + item.otrosConceptos + "" +
                      "," + item.depositoNeto + "" +
                      ",'" + item.cuentaBancaria + "'" +
                      ",'" + item.CLABE + "'" +
                      ",'" + item.bancoEmpresaPago + "'" +
                      "," + item.descuentos + "" +
                      ",'" + item.nominaEmpresaID + "')";
                        queryInsertaLayout.ExecuteNonQuery();

                    } catch (Exception lista)
                    {
                        error++;
                        if (error + 1 < listaLayout.Count())
                        {
                            builder.Append("*************************************************************************************************");
                            builder.AppendLine();
                        }

                        builder.Append("Nombre del empleado:" + nombreEmpleado + "\r\n");
                        builder.AppendLine();
                        builder.Append("Error al intentar guardar el movimiento del empleado:" + lista.Message);
                        builder.AppendLine();
                        //if (splash.IsSplashFormVisible.Equals(true))
                        //{
                        //    splash.CloseWaitForm();
                        //}
                        //XtraMessageBox.Show(lista.Message + "\nError Controlador: InsertaLayout(foreach())", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (error > 0)
                {
                    builder.AppendLine();
                    builder.Append("********************************       Fin Erroes      ******************************************" + "\r\n");
                    writer = new StreamWriter(path, true);
                    writer.Write(builder);
                    writer.Close();
                    Process proceso = new Process();
                    proceso.StartInfo.FileName = path;
                    proceso.Start();
                }
            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: InsertaLayout()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool ActualizaLayout(List<E.Layout> layout, SplashScreenManager splash)
        {
            try
            {
                SqlCommand updateLayout = N.Conexion.PerformConnection().CreateCommand();
                string Empresa = Properties.Settings.Default["EmpresaNominaID"].ToString();
                foreach (var item in layout)
                {
                    try
                    {
                        updateLayout.CommandText = @"UPDATE [dbo].[LayoutHistorico]
                        SET 
                            [PeriodicidadPago] = '" + item.periPago + "'" +
                            ",[ingresos] = " + item.ingresos + "" +
                            ",[LimInferior] = " + item.LimInferior + "" +
                            ",[ExLimInf] =  " + item.ExLimInf + "" +
                            ",[PerExLimInf] = " + item.PerExLimInf + "" +
                            ",[ImpMarg] = " + item.ImpMarg + "" +
                            ",[CF] = " + item.CF + "" +
                            ",[ISR] = " + item.ISR + "" +
                            ",[ingresosNeto] = " + item.ingresosNet + "" +
                            ",[importe] = " + item.importe + "" +
                            ",[IVA] = " + item.IVA + "" +
                            ",[fechaAplicacion] = '" + item.fechaAplicacion.ToString("dd/MM/yyyy") + "'" +
                            ",[fecIniPeri] = '" + item.fecIniPeri.ToString("dd/MM/yyyy") + "'" +
                            ",[fecFinPeri] = '" + item.fecFinPeri.ToString("dd/MM/yyyy") + "'" +
                            ",[IDEmpresaPago] = '" + item.IDEmpresa + "'" +
                            ",[bancoEmpresaPago] = '" + item.bancoEmpresaPago + "'" +
                            ",[IDPeriodo] = '" + item.periodo + "'" +
                            ",[IDCliente] = '" + item.IDCliente + "'" +
                            ",[tipoPago] = '" + item.tipoPago + "'" +
                            ",[otrosConceptos] = " + item.otrosConceptos + "" +
                            ",[depositoNeto] = " + item.depositoNeto + "" +
                            ",[cuentaBancaria] = '" + item.cuentaBancaria + "'" +
                            ",[CLABE] = '" + item.CLABE + "'" +
                            ",[descuentos] = " + item.descuentos + "" +
                            "WHERE [ID] = '" + item.ID + "'" +
                            "AND [nominaEmpresaID] = '" + Empresa + "'";

                        updateLayout.ExecuteNonQuery();

                    } catch (Exception lista)
                    {
                        XtraMessageBox.Show(lista.Message + "\nError Controlador: ActualizaLayout(foreach())", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                return true;

            } catch (Exception e)
            {
                if (splash.IsSplashFormVisible.Equals(true))
                {
                    splash.CloseWaitForm();
                }
                XtraMessageBox.Show(e.Message + "\nError Controlador: ActualizaLayout()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void InsertaDetalleLyout(E.DetalleLayout detalleLayout, SplashScreenManager splash)
        {
            try
            {
                SqlCommand insertaDetalle = N.Conexion.PerformConnection().CreateCommand();
                insertaDetalle.CommandText = @"INSERT INTO [dbo].[ResumenLayout]
               ([Layout]
               ,[Caratula]
               ,[SalarioAsimilado]
               ,[ImpuestoNomina]
               ,[ComisionServicio]
               ,[SubTotal]
               ,[IVA]
               ,[RetencionIVA]
               ,[Total]
               ,[Detalles]
,[nominaEmpresaID])
                VALUES
               ('" + detalleLayout.Layout + "'" +
               ",'" + detalleLayout.Caratula + "'" +
               "," + detalleLayout.SalarioAsimilado + "" +
               "," + detalleLayout.ImpuestoNomina + "" +
               "," + detalleLayout.ComisionServicio + "" +
               "," + detalleLayout.SubTotal + "" +
               "," + detalleLayout.IVA + "" +
               "," + detalleLayout.RetencionIVA + "" +
               "," + detalleLayout.Total + "" +
               ",'" + detalleLayout.Detalles + "'" +
               ",'" + detalleLayout.nominaEmpresaID + "')";

                insertaDetalle.ExecuteNonQuery();

            } catch (Exception e)
            {
                if (splash.IsSplashFormVisible.Equals(true))
                {
                    splash.CloseWaitForm();
                }
                XtraMessageBox.Show(e.Message + "\nError Controlador: InsertaLayout()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool ActualizaDetalleLayout(E.DetalleLayout detalle, SplashScreenManager splash)
        {
            try
            {
                string Empresa = Properties.Settings.Default["EmpresaNominaID"].ToString();
                SqlCommand updateDetalle = N.Conexion.PerformConnection().CreateCommand();
                updateDetalle.CommandText = @"UPDATE [dbo].[ResumenLayout]
                SET 
                    [SalarioAsimilado] = " + detalle.SalarioAsimilado + "" +
                    ",[ImpuestoNomina] = " + detalle.ImpuestoNomina + "" +
                    ",[ComisionServicio] = " + detalle.ComisionServicio + "" +
                    ",[SubTotal] = " + detalle.SubTotal + "" +
                    ",[IVA] = " + detalle.IVA + "" +
                    ",[RetencionIVA] = " + detalle.RetencionIVA + "" +
                    ",[Total] = " + detalle.Total + "" +
                    ",[Detalles] = '" + detalle.Detalles + "'" +
                    "WHERE [ID] = '" + detalle.ID + "'" +
                    "AND [nominaEmpresaID] = '" + Empresa + "'";

                if (updateDetalle.ExecuteNonQuery().Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                if (splash.IsSplashFormVisible.Equals(true))
                {
                    splash.CloseWaitForm();
                }
                XtraMessageBox.Show(e.Message + "\nError Controlador: ActualizaDetalleLayout()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public List<E.Layout> GetListaLayout(string caratula, List<E.Layout> layout, SplashScreenManager splashManager)
        {
            try
            {
                string Empresa = Properties.Settings.Default["EmpresaNominaID"].ToString();
                SqlCommand getLista = N.Conexion.PerformConnection().CreateCommand();
                getLista.CommandText = @"SELECT [ID]
                  ,[numEmpl]
                  ,[nombreEmpleado]
                  ,[RFCEmpleado]
                  ,[CURPEmpleado]
                  ,[PeriodicidadPago]
                  ,[ingresos]
                  ,[LimInferior]
                  ,[ExLimInf]
                  ,[PerExLimInf]
                  ,[ImpMarg]
                  ,[CF]
                  ,[ISR]
                  ,[ingresosNeto]
                  ,[operacion]
                  ,[claveID]
                  ,[cuentaOrigen]
                  ,[cuenta_ClaveDestino]
                  ,[importe]
                  ,[referencia]
                  ,[descripcion]
                  ,[RFCOrdenante]
                  ,[IVA]
                  ,[fechaAplicacion]
                  ,[fecIniPeri]
                  ,[fecFinPeri]
                  ,[InstruccionPago]
                  ,[claveTipoCambio]
                  ,[fechaCreacion]
                  ,[estatus]
                  ,[BancoEmpleado]
                  ,[sub]
                  ,[Caratula]
                  ,[IDEmpresaPago]
                  ,[bancoEmpresaPago]
                  ,[IDPeriodo]
                  ,[IDCliente]
                  ,[Layout]
                  ,[tipoPago]
                  ,[otrosConceptos]
                  ,[depositoNeto]
                  ,[cuentaBancaria]
                  ,[CLABE]
                  ,[descripcionError]
                FROM[LayoutHistorico]
                WHERE[Caratula] = @caratula
                AND [nominaEmpresaID] = @Empresa";
                getLista.Parameters.AddWithValue("@caratula", caratula);
                getLista.Parameters.AddWithValue("@Empresa", Empresa);

                SqlDataReader readerLista = getLista.ExecuteReader();
                while (readerLista.Read())
                {
                    layout.Add(new E.Layout
                    {
                        ID = Convert.ToString(readerLista.GetInt32(0)),
                        numEmpl = readerLista.GetInt32(1),
                        nombreEmpleado = readerLista.GetString(2),
                        RFCEmpleado = readerLista.GetString(3),
                        CURPEmpleado = readerLista.GetString(4),
                        periPago = readerLista.GetString(5),
                        ingresos = readerLista.GetDecimal(6),
                        LimInferior = readerLista.GetDecimal(7),
                        ExLimInf = readerLista.GetDecimal(8),
                        PerExLimInf = readerLista.GetDecimal(9),
                        ImpMarg = readerLista.GetDecimal(10),
                        CF = readerLista.GetDecimal(11),
                        ISR = readerLista.GetDecimal(12),
                        ingresosNet = readerLista.GetDecimal(13),
                        operacion = readerLista.GetString(14),
                        claveID = readerLista.GetString(15),
                        cuentaOrigen = readerLista.GetString(16),
                        cuentaClaveDestino = readerLista.GetString(17),
                        importe = readerLista.GetDecimal(18),
                        referencia = readerLista.GetString(19),
                        descripcion = readerLista.GetString(20),
                        RFCOrdenante = readerLista.GetString(21),
                        IVA = readerLista.GetDecimal(22),
                        fechaAplicacion = readerLista.GetDateTime(23),
                        fecIniPeri = readerLista.GetDateTime(24),
                        fecFinPeri = readerLista.GetDateTime(25),
                        institucionPago = readerLista.GetString(26),
                        claveTipoCambio = Convert.ToString(readerLista.GetInt32(27)),
                        fechaCreacion = readerLista.GetDateTime(28),
                        estatus = readerLista.GetString(29),
                        bancoEmpleado = readerLista.GetString(30),
                        Sub = readerLista.GetDecimal(31),
                        caratula = readerLista.GetString(32),
                        bancoEmpresaPago = readerLista.GetString(33),
                        IDEmpresa = readerLista.GetString(34),
                        periodo = readerLista.GetString(35),
                        IDCliente = readerLista.GetString(36),
                        layout = readerLista.GetString(37),
                        tipoPago = readerLista.GetString(38),
                        otrosConceptos = readerLista.GetDecimal(39),
                        depositoNeto = readerLista.GetDecimal(40),
                        cuentaBancaria = readerLista.GetString(41),
                        CLABE = readerLista.GetString(42),
                    });

                }
                readerLista.Close();
                return layout;
            }
            catch (Exception e)
            {
                if (splashManager.IsSplashFormVisible.Equals(true))
                {
                    splashManager.CloseWaitForm();
                }
                XtraMessageBox.Show(e.Message + "\nError Controlador: GetListaLayout()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public E.Caratula GetDatosCaratula(string nombreCaratula)
        {
            try
            {
                string Empresa = Properties.Settings.Default["EmpresaNominaID"].ToString();
                E.Caratula caratula = new E.Caratula();
                SqlCommand getDatos = N.Conexion.PerformConnection().CreateCommand();
                getDatos.CommandText = @"SELECT TOP (1000) [ID]
                  ,[Caratula]
                  ,[Layout]
                  ,[IDCliente]
                  ,[Cliente]
                  ,[IDEmpresa]
                  ,[Empresa]
                  ,[FechaCreacion]
                  ,[FechaAplicacion]
                  ,[FechaIniPeriodo]
                  ,[FechaFinPeriodo]
                  ,[TotalEmpleados]
                  ,[TotalPagoAsimilados]
                  ,[Estatus]
                  ,[usuario]
                  ,[TipoPeri]
                  ,[AsimiSalarios]
                  ,[ProvAguinaldo]
                  ,[ProviVacaciones]
                  ,[ProviPrimVacacional]
                  ,[SubTotalIAS]
                  ,[ComisionServicio]
                  ,[ImpNomi]
                  ,[Total]
                  ,[IVA]
                  ,[RetencionIVA]
                  ,[TotalFactura]
                  ,[Ajuste]
                  ,[TotalDeposito]
                  ,[Banco]
                  ,[NumCuenta]
                  ,[CLABE]
                  ,[ClaveFacturacion]
                  ,[TipoPago]
                  ,[FormaPago]
                  ,[Observaciones]
                  ,[RutaLogo]
                  ,[Imagen]
                  ,ISNULL([FechaValidaPago],'') AS [FechaValidaPago]
                  ,ISNULL([UsuarioPago], '') AS [UsuarioPago]
                  ,ISNULL([FechaModificacion], '') AS [FechaModificacion]
                  ,ISNULL([UsuarioModificacion], '') AS [UsuarioModificacion]
                  ,ISNULL([FechaReAperturaCaratula], '') AS [FechaReAperturaCaratula]
                  ,ISNULL([UsuarioReApertura], '') AS [UsuarioReApertura]
              FROM [CaratulaPago]
              WHERE [Caratula] = @caratula
              AND [nominaEmpresaID] = @Empresa";

                getDatos.Parameters.AddWithValue("@caratula", nombreCaratula);
                getDatos.Parameters.AddWithValue("@Empresa", Empresa);
                SqlDataReader readerData = getDatos.ExecuteReader();

                if (readerData.Read())
                {
                    caratula.ID = Convert.ToString(readerData.GetInt32(0));
                    caratula.caratula = readerData.GetString(1);
                    caratula.Layout = readerData.GetString(2);
                    caratula.IDCliente = readerData.GetString(3);
                    caratula.Cliente = readerData.GetString(4);
                    caratula.IDEmpresa = readerData.GetString(5);
                    caratula.Empresa = readerData.GetString(6);
                    caratula.FechaCreacion = readerData.GetDateTime(7);
                    caratula.FechaAplicacion = readerData.GetDateTime(8);
                    caratula.FechaIniPeriodo = readerData.GetDateTime(9);
                    caratula.FechaFinPeriodo = readerData.GetDateTime(10);
                    caratula.TotalEmpleados = readerData.GetInt32(11);
                    caratula.TotalPagoAsimilados = readerData.GetDecimal(12);
                    caratula.Estatus = readerData.GetString(13);
                    caratula.usuario = readerData.GetString(14);
                    caratula.TipoPeri = readerData.GetString(15);
                    caratula.AsimiSalarios = readerData.GetDecimal(16);
                    caratula.ProvAguinaldo = readerData.GetDecimal(17);
                    caratula.ProviVacaciones = readerData.GetDecimal(18);
                    caratula.ProviPrimVacacional = readerData.GetDecimal(19);
                    caratula.SubTotalIAS = readerData.GetDecimal(20);
                    caratula.ComisionServicio = readerData.GetDecimal(21);
                    caratula.ImpNomi = readerData.GetDecimal(22);
                    caratula.Total = readerData.GetDecimal(23);
                    caratula.IVA = readerData.GetDecimal(24);
                    caratula.RetencionIVA = readerData.GetDecimal(25);
                    caratula.TotalFactura = readerData.GetDecimal(26);
                    caratula.Ajuste = readerData.GetDecimal(27);
                    caratula.TotalDeposito = readerData.GetDecimal(28);
                    caratula.Banco = readerData.GetString(29);
                    caratula.NumCuenta = readerData.GetString(30);
                    caratula.CLABE = readerData.GetString(31);
                    caratula.ClaveFacturacion = readerData.GetString(32);
                    caratula.TipoPago = readerData.GetString(33);
                    caratula.FormaPago = readerData.GetString(34);
                    caratula.Observaciones = readerData.GetString(35);
                    caratula.RutaLogo = readerData.GetString(36);
                    caratula.Imagen = readerData.GetString(37);
                    caratula.FechaValidaPago = readerData.GetDateTime(38);
                    caratula.UsuarioPago = readerData.GetString(39);
                    caratula.FechaModificacion = readerData.GetDateTime(40);
                    caratula.UsuarioModificacion = readerData.GetString(41);
                    caratula.FechaReaperturaPeriodo = readerData.GetDateTime(42);
                    caratula.UsuarioReapertura = readerData.GetString(43);
                }
                readerData.Close();
                return caratula;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador:GetDatosCaratula", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public E.DetalleLayout GetDetalleLayout(string nombreLayout)
        {
            try
            {
                string Empresa = Properties.Settings.Default["EmpresaNominaID"].ToString();
                E.DetalleLayout detalle = new E.DetalleLayout();
                SqlCommand getDetalle = N.Conexion.PerformConnection().CreateCommand();
                getDetalle.CommandText = @"SELECT  [ID]
                ,[Layout]
                ,[Caratula]
                ,[SalarioAsimilado]
                ,[ImpuestoNomina]
                ,[ComisionServicio]
                ,[SubTotal]
                ,[IVA]
                ,[RetencionIVA]
                ,[Total]
                ,[Detalles]
            FROM [ResumenLayout] 
            WHERE [Layout] = '" + nombreLayout + "'" +
            " AND [nominaEmpresaID] = @Empresa";
                getDetalle.Parameters.AddWithValue("@Empresa", Empresa);

                SqlDataReader readerDetalle;
                readerDetalle = getDetalle.ExecuteReader();

                if (readerDetalle.Read())
                {
                    detalle.ID = Convert.ToString(readerDetalle.GetInt32(0));
                    detalle.Layout = readerDetalle.GetString(1);
                    detalle.Caratula = readerDetalle.GetString(2);
                    detalle.SalarioAsimilado = readerDetalle.GetDecimal(3);
                    detalle.ImpuestoNomina = readerDetalle.GetDecimal(4);
                    detalle.ComisionServicio = readerDetalle.GetDecimal(5);
                    detalle.SubTotal = readerDetalle.GetDecimal(6);
                    detalle.IVA = readerDetalle.GetDecimal(7);
                    detalle.RetencionIVA = readerDetalle.GetDecimal(8);
                    detalle.Total = readerDetalle.GetDecimal(9);
                    detalle.Detalles = readerDetalle.GetString(10);
                }
                readerDetalle.Close();
                return detalle;
            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador:GetDetalleLayout", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void ActualizaStatusLayout(List<E.Layout> lista, SplashScreenManager splashManager)
        {
            try
            {
                string Empresa = Properties.Settings.Default["EmpresaNominaID"].ToString();
                SqlCommand actualizaStatus = N.Conexion.PerformConnection().CreateCommand();
                foreach (var item in lista)
                {
                    actualizaStatus.CommandText = @"UPDATE
                    LayoutHistorico
                    SET [estatus] = 'Generado'
                    WHERE [Caratula] = '" + item.caratula + "'" +
                    "AND [ID] =" + item.ID + "" +
                    "AND [nominaEmpresaID] = '" + Empresa + "'";

                    actualizaStatus.ExecuteNonQuery();
                }
            } catch (Exception e)
            {
                if (splashManager.IsSplashFormVisible.Equals(true))
                {
                    splashManager.CloseWaitForm();
                }
                XtraMessageBox.Show(e.Message + "\nError Controlador: ActualizaEstatusLayout()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void AgregarEmpleadoMasivo(List<E.Empleado> list, Object _P, SplashScreenManager splashManager)
        {
            try
            {
                StreamWriter writer = null;
                StringBuilder builder = null;
                string url = @"C:\AsimiladosLogs\";
                bool nombre = true;
                if (!Directory.Exists(url))
                {
                    Directory.CreateDirectory(url);
                }
                string NombreArchivo = Convert.ToString(DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-"
                + DateTime.Now.Year.ToString() + ", " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString()
                + "-" + DateTime.Now.Second.ToString());
                string path = Path.Combine(url, NombreArchivo + ".INARI");
                int numEmplAnt = 0, numEmplNue = 0, contErroresExis = 0, contErrores = 0, contExito = 0, cont = 0, contErrRFC = 0, contErrCURP = 0, validaCURP = 0, ValidaRFC = 0, ValidaExiste = 0, TotalErrores = 0, contErrCuenta = 0, validaCuenta = 0, contErrCLABE = 0, validaCLABE = 0, contErrBanco = 0, validaBanco = 0, contErrCVE = 0, validaCVE = 0;
                E.Empleado empleado = (E.Empleado)_P;

                builder = new StringBuilder();
                builder.AppendLine();
                builder.Append("********************************   Erroes Encontrados  ******************************************" + "\r\n");
                builder.AppendLine();

                foreach (var empl in list)
                {
                    //if (nombre.Equals(true))
                    //{
                    //    builder.Append("Nombre del empleado:" + empl.Nombre + "\r\n");
                    //    builder.AppendLine();
                    //}
                    cont++;
                    splashManager.SetWaitFormCaption("Agregando Empleado " + cont + "/" + list.Count + "..");
                    if (empl.NumEmpl != "" && empl.Nombre != "" && empl.CURP != "" && empl.RFC != "" && empl.Periodicidad != "" && empl.cuenta != "" && empl.clabe_bancaria != "" && empl.banco != "" && empl.cve_banco != "" && empl.empresa != "" && empl.idEmpresa != "")
                    {
                        SqlCommand queryNumEmpl = N.Conexion.PerformConnection().CreateCommand();
                        queryNumEmpl.CommandText = @"select
                    isnull(max (cast(NUM_EMPLEADO as int)), 0)
                    from EMPLEADOS
                    ";
                        SqlDataReader readerNumEmpl;
                        readerNumEmpl = queryNumEmpl.ExecuteReader();

                        if (readerNumEmpl.Read())
                        {
                            numEmplAnt = Convert.ToInt32(readerNumEmpl.GetInt32(0));
                            numEmplNue = numEmplAnt + 1;
                        }
                        else
                        {

                        }
                        readerNumEmpl.Close();
                        //XtraMessageBox.Show(numEmplAnt + "\n" + numEmplNue);
                        string Empresa = Properties.Settings.Default["EmpresaNominaID"].ToString();
                        SqlCommand queryBuscaEmpl = N.Conexion.PerformConnection().CreateCommand();
                        queryBuscaEmpl.CommandText = @"select * from Empleados where RFC = @rfc
                        AND [nominaEmpresaID] = '" + Empresa + "'";
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
                    ,[SINDICALIZADO]
                    ,[CUENTA]
                    ,[CLABE_BANCARIA]
                    ,[BANCO]
                    ,[CVE_BANCO]
                    ,[EMPRESA]
                    ,[ID_EMPRESA]
                    ,[PORCENTAJE_DESCUENTO],
                    [TIPO_PAGO]
                    ,[nominaEmpresaID])
                    VALUES
                    ('" + empl.NumEmpl + "','" + empl.Nombre + "','" + empl.RFC + "','" + empl.CURP + "','" + "09'," + "'ASIMILADO'," + "'01/01/1900'," + "'ASIMILADO',"
                        + "'99'," + "'00','" + empl.Periodicidad + "'," + "'No'" +
                        ",'" + empl.cuenta + "'" +
                        ",'" + empl.clabe_bancaria + "'" +
                        ",'" + empl.banco + "'" +
                        ",'" + empl.cve_banco + "'" +
                        ",'" + empl.empresa + "'" +
                        ",'" + empl.idEmpresa + "'" +
                        "," + empl.descuento + "" +
                        ",'" + empl.tipoPago + "'" +
                        ",'" + empl.nominaEmpresaID + "')";


                        if (!empl.RFC.Length.Equals(13))
                        {
                            if (nombre.Equals(true))
                            {
                                builder.Append("Nombre del empleado:" + empl.Nombre + "\r\n");
                                builder.AppendLine();
                            }
                            //contErrores++;
                            contErrRFC++;
                            string MensajeRFC = "RFC no cumple con el formato correcto, favor de verificar.";
                            //contErrores++;
                            ValidaRFC = 0;
                            builder.Append(MensajeRFC);
                            builder.AppendLine();
                            nombre = false;
                        }
                        else
                        {
                            ValidaRFC = 1;
                        }

                        if (!empl.CURP.Length.Equals(18))
                        {
                            if (nombre.Equals(true))
                            {
                                builder.Append("Nombre del empleado:" + empl.Nombre + "\r\n");
                                builder.AppendLine();
                            }
                            //contErroresExis++;
                            contErrCURP++;
                            string MensajeCURP = "CURP no cumple con el formato correcto, favor de verificar";
                            //contErrores++;
                            validaCURP = 0;
                            builder.Append(MensajeCURP);
                            builder.AppendLine();
                            nombre = false;
                        }
                        else
                        {
                            validaCURP = 1;
                        }

                        if (empl.cuenta.Length < 10)
                        {
                            if (nombre.Equals(true))
                            {
                                builder.Append("Nombre del empleado:" + empl.Nombre + "\r\n");
                                builder.AppendLine();
                            }
                            contErrCuenta++;
                            validaCuenta = 0;
                            string mensajeCuenta = "Cuenta no cumple con el formato correcto, debe tener al menos 10 dígitos.";
                            builder.Append(mensajeCuenta);
                            builder.AppendLine();
                            nombre = false;
                        }
                        else if (empl.cuenta.Length > 10)
                        {
                            if (nombre.Equals(true))
                            {
                                builder.Append("Nombre del empleado:" + empl.Nombre + "\r\n");
                                builder.AppendLine();
                            }
                            contErrCuenta++;
                            validaCuenta = 0;
                            string mensajeCuenta = "Cuenta no cumple con el formato correcto, debe tener al máximo 10 dígitos.";
                            builder.Append(mensajeCuenta);
                            builder.AppendLine();
                            nombre = false;
                        }
                        else
                        {
                            validaCuenta++;
                        }

                        if (empl.clabe_bancaria.Length < 18)
                        {
                            if (nombre.Equals(true))
                            {
                                builder.Append("Nombre del empleado:" + empl.Nombre + "\r\n");
                                builder.AppendLine();
                            }
                            contErrCLABE++;
                            validaCLABE = 0;
                            string mensaje = "CLABE no cumple con el formato correcto, debe tener al menos 18 dígitos.";
                            builder.Append(mensaje);
                            builder.AppendLine();
                            nombre = false;
                        }
                        else if (empl.clabe_bancaria.Length > 18)
                        {
                            if (nombre.Equals(true))
                            {
                                builder.Append("Nombre del empleado:" + empl.Nombre + "\r\n");
                                builder.AppendLine();
                            }
                            contErrCLABE++;
                            validaCLABE = 0;
                            string mensaje = "CLABE no cumple con el formato correcto, debe tener al máximo 18 dígitos.";
                            builder.Append(mensaje);
                            builder.AppendLine();
                            nombre = false;
                        }
                        else
                        {
                            validaCLABE++;
                        }
                        if (empl.banco.Equals(null) || empl.banco.Equals("0"))
                        {
                            if (nombre.Equals(true))
                            {
                                builder.Append("Nombre del empleado:" + empl.Nombre + "\r\n");
                                builder.AppendLine();
                            }
                            contErrBanco++;
                            validaBanco = 0;
                            string mensaje = "Banco no definido.";
                            builder.Append(mensaje);
                            builder.AppendLine();
                            nombre = false;
                        }
                        else
                        {
                            validaBanco++;
                        }

                        if (empl.cve_banco.Equals(null) || empl.cve_banco.Equals("0"))
                        {
                            if (nombre.Equals(true))
                            {
                                builder.Append("Nombre del empleado:" + empl.Nombre + "\r\n");
                                builder.AppendLine();
                            }
                            contErrCVE++;
                            validaCVE = 0;
                            string mensaje = "CVE Banco no definido.";
                            builder.Append(mensaje);
                            builder.AppendLine();
                            nombre = false;
                        }
                        else
                        {
                            validaCVE++;
                        }

                        if (ReaderEmpl.Read())
                        {
                            if (nombre.Equals(true))
                            {
                                builder.Append("Nombre del empleado:" + empl.Nombre + "\r\n");
                                builder.AppendLine();
                            }
                            contErroresExis++;
                            string MensajeExiste = "El empleado ya fue registrado anteriormete.";
                            //XtraMessageBox.Show("El empleado:" + empleado.Nombre + "\nYa se encuentra registrado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReaderEmpl.Close();
                            ValidaExiste = 0;
                            builder.Append(MensajeExiste);
                            builder.AppendLine();
                            nombre = false;
                        }
                        else
                        {
                            ReaderEmpl.Close();
                            ValidaExiste = 1;
                        }


                        if (cont + 1 <= list.Count() && contErroresExis > 0 || contErrRFC > 0 || contErrCURP > 0 || contErrCuenta > 0 || contErrCLABE > 0 || contErrCVE > 0 || contErrBanco > 0)
                        {
                            builder.Append("*************************************************************************************************");
                            builder.AppendLine();
                        }
                        nombre = true;

                        //XtraMessageBox.Show("No existe");

                        if (validaCURP == 1 && ValidaRFC == 1 && ValidaExiste == 1 && validaBanco == 1 && validaCLABE == 1 && validaCVE == 1 && validaCuenta == 1)
                        {
                            if (queryInsertaEmpl.ExecuteNonQuery().Equals(1))
                            {
                                contExito++;
                                validaCURP = 0;
                                ValidaRFC = 0;
                                ValidaExiste = 0;
                                validaCuenta = 0;
                                validaBanco = 0;
                                validaCLABE = 0;
                                validaCVE = 0;
                                //XtraMessageBox.Show("¡Empleado agregado satisfactoriamente!", "Agregar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        if (cont == list.Count())
                        {
                        }
                    }
                } // fin foreach
                if (contErroresExis > 0 || contErrRFC > 0 || contErrCURP > 0 || contErrCuenta > 0 || contErrCLABE > 0 || contErrCVE > 0 || contErrBanco > 0)
                {
                    //Aqui se genera el log
                    TotalErrores = contErroresExis + contErrRFC + contErrCURP + contErrCuenta + contErrCLABE + contErrCVE + contErrBanco;
                    builder.AppendLine();
                    builder.Append("********************************       Fin Erroes      ******************************************" + "\r\n");
                    if (splashManager.IsSplashFormVisible.Equals(true))
                    {
                        splashManager.CloseWaitForm();
                    }

                    XtraMessageBox.Show("Proceso terminado con " + TotalErrores + " errores y " + contExito + " con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    writer = new StreamWriter(path, true);
                    writer.Write(builder);
                    writer.Close();
                    Process proceso = new Process();
                    proceso.StartInfo.FileName = path;
                    proceso.Start();
                }
                if (contErroresExis == 0 && contErrRFC == 0 && contErrCURP == 0 && contErrCuenta == 0 && contErrCLABE == 0 && contErrCVE == 0 && contErrBanco == 0 && contExito > 0)
                {
                    if (splashManager.IsSplashFormVisible.Equals(true))
                    {
                        splashManager.CloseWaitForm();
                    }

                    XtraMessageBox.Show("¡Carga masiva terminada con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                if (splashManager.IsSplashFormVisible.Equals(true))
                {
                    splashManager.CloseWaitForm();
                }
                XtraMessageBox.Show(e.Message + "\nError Controlador: AgregaEmpleadoMasivo()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public string InsertaBitacoraImportacionEmpledados(string emprOrigen, string emprDestino, int idemprOrigen, int idemprDestino,E.Empleado empleado, string usuario)
        {
            try
            {
                string resultado = "";
                string EmprNomiIDOri = "", EmprNomiIDDest = "";
                EmprNomiIDOri = "Nomina_Empresa" + idemprOrigen;
                EmprNomiIDDest = "Nomina_Empresa" + idemprDestino;
                SqlCommand insertaBitacora = N.Conexion.PerformConnection().CreateCommand();
                insertaBitacora.CommandText = @"INSERT INTO [dbo].[BitacoraImportacionEmpleados]
                    ([NumEmpleado]
                    ,[NomEmpleado]
                    ,[RFC]
                    ,[IDEmprOrigen]
                    ,[EmprOrigen]
                    ,[IDEmprDestino]
                    ,[EmprDestino]
                    ,[FecImp]
                    ,[Usuario])
                    VALUES
                    ('" + empleado.NumEmpl + "'" +
                ",'" + empleado.Nombre + "'" +
                ",'" + empleado.RFC + "'" +
                ",'" + EmprNomiIDOri + "'" +
                ",'" + emprOrigen + "'" +
                ",'" + EmprNomiIDDest + "'" +
                ",'" + emprDestino + "'" +
                ", GETDATE()" +
                ",'" + usuario + "')";

                if (insertaBitacora.ExecuteNonQuery().Equals(1))
                {
                    resultado = "true";
                }
                return resultado;
            }catch (Exception e)
            {
                string resultado = e.Message + "\nInserta biracora importación empleado.";
                return resultado;
            }
        }

        public string InsertaEmpleadoImportado(E.Empleado empleado)
        {
            try
            {
                string resultado ="";
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
                ,[SINDICALIZADO]
                ,[CUENTA]
                ,[CLABE_BANCARIA]
                ,[BANCO]
                ,[CVE_BANCO]
                ,[EMPRESA]
                ,[ID_EMPRESA]
                ,[PORCENTAJE_DESCUENTO]
                ,[TIPO_PAGO]
                ,[MAIL]
                ,[nominaEmpresaID])
                VALUES
                ('" + empleado.NumEmpl + "','" + empleado.Nombre + "','" + empleado.RFC + "','" + empleado.CURP + "','" + "09'," + "'ASIMILADO'," + "'01/01/1900'," + "'ASIMILADO',"
                + "'99'," + "'00','" + empleado.Periodicidad + "'," + "'No'" +
                ",'" + empleado.cuenta + "'" +
                ",'" + empleado.clabe_bancaria + "'" +
                ",'" + empleado.banco + "'" +
                ",'" + empleado.cve_banco + "'" +
                ",'" + empleado.empresa + "'" +
                ",'" + empleado.idEmpresa + "'" +
                "," + empleado.descuento + "" +
                ",'" + empleado.tipoPago + "'" +
                ",'" + empleado.Correo + "'" +
                ",'" + empleado.nominaEmpresaID + "')";

                if (queryInsertaEmpl.ExecuteNonQuery().Equals(1))
                {
                    resultado = "true";
                }

                return resultado;
            }catch (Exception e)
            {
                string resultado = e.Message + "\nInserta empleado importación.";
                return resultado;
            }
        }

        public void ImportaEmpleado(string emprOrigen, string emprDestino, List<E.Empleado> listaEmpl, string usuario, SplashScreenManager splash, string EmpresaNominaID)
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

                string NombreArchivo = "Importción Empleados" + "_" + Convert.ToString(DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-"
                + DateTime.Now.Year.ToString() + ", " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString()
                + "-" + DateTime.Now.Second.ToString());
                string path = Path.Combine(url, NombreArchivo + ".txt");


                builder = new StringBuilder();
                builder.AppendLine();
                builder.Append("********************************   Erroes Encontrados  ******************************************" + "\r\n");
                builder.AppendLine();

                int idEmprOri = 0, idEmprDest = 0, contError = 0, contExito = 0, contador = 0;
                string EmprNomiIDOri = "", EmprNomiIDDest = "";
                SqlCommand EmprOrigen = N.Conexion.PerformConnection().CreateCommand();
                SqlCommand EmprDestino = N.Conexion.PerformConnection().CreateCommand();
                EmprOrigen.CommandText = @"SELECT [Numero_Empresa]
                 FROM [dbo].[Listado_Empresas]
                 WHERE [Nombre_Empresa] = @empresa";
                EmprOrigen.Parameters.AddWithValue("@empresa", emprOrigen);
                EmprDestino.CommandText = @"SELECT [Numero_Empresa]
                 FROM [dbo].[Listado_Empresas]
                 WHERE [Nombre_Empresa] = @empresa";
                EmprDestino.Parameters.AddWithValue("@empresa", emprDestino);

                SqlDataReader readerOrigen;
                readerOrigen = EmprOrigen.ExecuteReader();

                if (readerOrigen.Read())
                {
                    idEmprOri = readerOrigen.GetInt32(0);
                    EmprNomiIDOri = "Nomina_Empresa" + idEmprOri.ToString();
                    readerOrigen.Close();
                }

                SqlDataReader readerDestino;
                readerDestino = EmprDestino.ExecuteReader();

                if (readerDestino.Read())
                {
                    idEmprDest = readerDestino.GetInt32(0);
                    EmprNomiIDDest = "Nomina_Empresa" + idEmprDest.ToString();
                    readerDestino.Close();
                }

                foreach (var empl in listaEmpl)
                {
                    contador++;
                    splash.SetWaitFormCaption("Importando empleado " + contador + "/" + listaEmpl.Count());
                    SqlCommand validaBitacora = N.Conexion.PerformConnection().CreateCommand();
                    validaBitacora.CommandText = @"SELECT [NumEmpleado]
                    ,[RFC]
                    ,[IDEmprOrigen]
                    ,[IDEmprDestino]
                    FROM [dbo].[BitacoraImportacionEmpleados]
                    WHERE[NumEmpleado] = @empleado
                    AND [RFC] = @RFC
                    AND [IDEmprOrigen] = @idOrigen
                    AND [IDEmprDestino] = @idDestino";
                    validaBitacora.Parameters.AddWithValue("@empleado", empl.NumEmpl);
                    validaBitacora.Parameters.AddWithValue("@RFC", empl.RFC);
                    validaBitacora.Parameters.AddWithValue("idOrigen", EmprNomiIDOri);
                    validaBitacora.Parameters.AddWithValue("idDestino", EmprNomiIDDest);

                    SqlDataReader readerBitacora = validaBitacora.ExecuteReader();

                    if (readerBitacora.Read())
                    {
                        contError++;
                        builder.Append("Nombre del empleado:" + empl.Nombre + "\r\n");
                        builder.AppendLine();
                        builder.Append("El emplado ya fue importado anteriormente.");
                        builder.AppendLine();
                        readerBitacora.Close();
                    }
                    else
                    {
                        readerBitacora.Close();
                        E.Empleado empleado = new E.Empleado();
                        empleado.NumEmpl = empl.NumEmpl;
                        empleado.Nombre = empl.Nombre;
                        empleado.RFC = empl.RFC;
                        empleado.CURP = empl.CURP;
                        empleado.Periodicidad = empl.Periodicidad;
                        empleado.cuenta = empl.cuenta;
                        empleado.clabe_bancaria = empl.clabe_bancaria;
                        empleado.banco = empl.banco;
                        empleado.empresa = empl.empresa;
                        empleado.idEmpresa = empl.idEmpresa;
                        empleado.descuento = empl.descuento;
                        empleado.tipoPago = empl.tipoPago;
                        empleado.Correo = empl.Correo;
                        empleado.nominaEmpresaID = EmpresaNominaID;

                        string reslutInsertButacora = InsertaBitacoraImportacionEmpledados(emprOrigen, emprDestino, idEmprOri, idEmprDest, empleado, usuario);
                        if (reslutInsertButacora != "true")
                        {
                            contError++;
                            builder.Append("Nombre del empleado:" + empl.Nombre + "\r\n");
                            builder.AppendLine();
                            builder.Append(reslutInsertButacora);
                            builder.AppendLine();
                        }
                        else
                        {
                            string resultInsertEmpl = InsertaEmpleadoImportado(empleado);
                            if (resultInsertEmpl != "true")
                            {
                                contError++;
                                builder.AppendLine();
                                builder.Append("Nombre del empleado:" + empl.Nombre + "\r\n");
                                builder.AppendLine();
                                builder.Append(resultInsertEmpl);
                                builder.AppendLine();
                            }
                            else
                            {
                                contExito++;
                            }
                        }
                    }
                }
                builder.AppendLine();
                builder.Append("********************************       Fin Erroes      ******************************************" + "\r\n");
                if (contError.Equals(0) && contExito >= 1)
                {
                    if (splash.IsSplashFormVisible.Equals(true))
                    {
                        splash.CloseWaitForm();
                    }
                    XtraMessageBox.Show("¡Importación de empleados generada con éxito!","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (contError >= 1 && contExito >= 0)
                {
                    if (splash.IsSplashFormVisible.Equals(true))
                    {
                        splash.CloseWaitForm();
                    }
                    XtraMessageBox.Show("¡Proceso terminado con " + contError + " error(es) & " + contExito + " registros con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    writer = new StreamWriter(path, true);
                    writer.Write(builder);
                    writer.Close();
                    Process proceso = new Process();
                    proceso.StartInfo.FileName = path;
                    proceso.Start();
                }
            }
            catch (Exception e)
            {
                if (splash.IsSplashFormVisible.Equals(true))
                {
                    splash.CloseWaitForm();
                }
                XtraMessageBox.Show(e.Message + "\nError Controlador: ImportaEmpleado()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void ListaEmpleadosImportación(GridControl grid, string BD, string IDClte)
        {
            try
            {
                SqlCommand queryLista = N.Conexion.PerformConnection().CreateCommand();
                queryLista.CommandText = @"SELECT [idempleado]
                      ,[NUM_EMPLEADO]
                      ,[NOMBRE]
                      ,[RFC]
                      ,ISNULL([MAIL], '') AS [MAIL]
                      ,[CURP]
                      ,[TIPO_REGIMEN]
                      ,ISNULL([NUMERO_SS], 0) AS [NUMERO_SS]
                      ,[DEPARTAMENTO]
                      ,ISNULL([CUENTA], '') AS [CUENTA]
                      ,ISNULL([CLABE_BANCARIA], '') AS [CLABE_BANCARIA]
                      ,ISNULL([CVE_BANCO],'') AS [CVE_BANCO]
                      ,ISNULL([BANCO], '') AS [BANCO]
                      ,[FECHA_INICIO_LABORAL]
                      ,[PUESTO]
                      ,[TIPO_CONTRATO]
                      ,[TIPO_JORNADA]
                      ,[PERIODICIDAD_PAGO]
                      ,ISNULL([SBC], 0) AS [SBC]
                      ,ISNULL([SDI], 0) AS [SDI]
                      ,[SINDICALIZADO]
                      ,ISNULL([REGISTRO_PATRONAL], '') AS [REGISTRO_PATRONAL]
                      ,ISNULL([RIESGO_PUESTO], 0) AS [RIESGO_PUESTO]
                      ,ISNULL([ID_EMPRESA], '') AS [ID_EMPRESA]
                      ,ISNULL([EMPRESA], '') AS [EMPRESA]
                      ,ISNULL([PORCENTAJE_DESCUENTO], 0) AS [PORCENTAJE_DESCUENTO]
                      ,ISNULL([TIPO_PAGO], '') AS [TIPO_PAGO]
                  FROM [dbo].[EMPLEADOS]" +
                  " WHERE ID_EMPRESA = @ID " +
                  "AND nominaEmpresaID = @EmpresaID";
                queryLista.Parameters.AddWithValue("@ID", IDClte);
                queryLista.Parameters.AddWithValue("@EmpresaID", BD);

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = queryLista;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                grid.DataSource = dataSet.Tables[0];
            }
            catch(Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: ListaEmpleadosMigracion()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListaCaratulas(GridControl grid/*, string estatus*/)
        {
            try
            {
                SqlCommand queryLista = N.Conexion.PerformConnection().CreateCommand();
                queryLista.CommandText = @"SELECT [ID]
                    ,[Caratula]
                    ,[Layout]
                    ,[IDCliente]
                    ,[Cliente]
                    ,[IDEmpresa]
                    ,[Empresa]
                    ,[FechaCreacion]
                    ,[FechaAplicacion]
                    ,[FechaIniPeriodo]
                    ,[FechaFinPeriodo]
                    ,[TotalEmpleados]
                    ,[TotalPagoAsimilados]
                    ,[Estatus]
                    ,[usuario]
                    ,[TipoPeri]
                    ,[AsimiSalarios]
                    ,[ProvAguinaldo]
                    ,[ProviVacaciones]
                    ,[ProviPrimVacacional]
                    ,[SubTotalIAS]
                    ,[ComisionServicio]
                    ,[ImpNomi]
                    ,[Total]
                    ,[IVA]
                    ,[RetencionIVA]
                    ,[TotalFactura]
                    ,[Ajuste]
                    ,[TotalDeposito]
                    ,[Banco]
                    ,[NumCuenta]
                    ,[CLABE]
                    ,[ClaveFacturacion]
                    ,[TipoPago]
                    ,[FormaPago]
                    ,[Observaciones]
                    ,[RutaLogo]
                    ,[Imagen]
                    ,[FechaValidaPago]
                    ,[UsuarioPago]
                    ,[FechaModificacion]
                    ,[UsuarioModificacion]
                FROM [CaratulaPago]
                --WHERE [Estatus] = 'Generado'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = queryLista;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                grid.DataSource = dataSet.Tables[0];
                #region ifregion
                //  if (estatus.Equals("G"))
                //  {
                //      SqlCommand queryLista = N.Conexion.PerformConnection().CreateCommand();
                //      queryLista.CommandText = @"SELECT [ID]
                //    ,[Caratula]
                //    ,[Layout]
                //    ,[IDCliente]
                //    ,[Cliente]
                //    ,[IDEmpresa]
                //    ,[Empresa]
                //    ,[FechaCreacion]
                //    ,[FechaAplicacion]
                //    ,[FechaIniPeriodo]
                //    ,[FechaFinPeriodo]
                //    ,[TotalEmpleados]
                //    ,[TotalPagoAsimilados]
                //    ,[Estatus]
                //    ,[usuario]
                //    ,[TipoPeri]
                //    ,[AsimiSalarios]
                //    ,[ProvAguinaldo]
                //    ,[ProviVacaciones]
                //    ,[ProviPrimVacacional]
                //    ,[SubTotalIAS]
                //    ,[ComisionServicio]
                //    ,[ImpNomi]
                //    ,[Total]
                //    ,[IVA]
                //    ,[RetencionIVA]
                //    ,[TotalFactura]
                //    ,[Ajuste]
                //    ,[TotalDeposito]
                //    ,[Banco]
                //    ,[NumCuenta]
                //    ,[CLABE]
                //    ,[ClaveFacturacion]
                //    ,[TipoPago]
                //    ,[FormaPago]
                //    ,[Observaciones]
                //    ,[RutaLogo]
                //    ,[Imagen]
                //    ,[FechaValidaPago]
                //    ,[UsuarioPago]
                //    ,[FechaModificacion]
                //    ,[UsuarioModificacion]
                //FROM [CaratulaPago]
                //WHERE [Estatus] = 'Generado'";
                //      SqlDataAdapter dataAdapter = new SqlDataAdapter();
                //      dataAdapter.SelectCommand = queryLista;
                //      DataSet dataSet = new DataSet();
                //      dataAdapter.Fill(dataSet);
                //      grid.DataSource = dataSet.Tables[0];
                //  }
                //  else if (estatus.Equals("P"))
                //  {
                //      SqlCommand queryLista = N.Conexion.PerformConnection().CreateCommand();
                //      queryLista.CommandText = @"SELECT [ID]
                //    ,[Caratula]
                //    ,[Layout]
                //    ,[IDCliente]
                //    ,[Cliente]
                //    ,[IDEmpresa]
                //    ,[Empresa]
                //    ,[FechaCreacion]
                //    ,[FechaAplicacion]
                //    ,[FechaIniPeriodo]
                //    ,[FechaFinPeriodo]
                //    ,[TotalEmpleados]
                //    ,[TotalPagoAsimilados]
                //    ,[Estatus]
                //    ,[usuario]
                //    ,[TipoPeri]
                //    ,[AsimiSalarios]
                //    ,[ProvAguinaldo]
                //    ,[ProviVacaciones]
                //    ,[ProviPrimVacacional]
                //    ,[SubTotalIAS]
                //    ,[ComisionServicio]
                //    ,[ImpNomi]
                //    ,[Total]
                //    ,[IVA]
                //    ,[RetencionIVA]
                //    ,[TotalFactura]
                //    ,[Ajuste]
                //    ,[TotalDeposito]
                //    ,[Banco]
                //    ,[NumCuenta]
                //    ,[CLABE]
                //    ,[ClaveFacturacion]
                //    ,[TipoPago]
                //    ,[FormaPago]
                //    ,[Observaciones]
                //    ,[RutaLogo]
                //    ,[Imagen]
                //    ,[FechaValidaPago]
                //    ,[UsuarioPago]
                //    ,[FechaModificacion]
                //    ,[UsuarioModificacion]
                //FROM [CaratulaPago]
                //WHERE [Estatus] = 'Pagado'";
                //      SqlDataAdapter dataAdapter = new SqlDataAdapter();
                //      dataAdapter.SelectCommand = queryLista;
                //      DataSet dataSet = new DataSet();
                //      dataAdapter.Fill(dataSet);
                //      grid.DataSource = dataSet.Tables[0];
                #endregion
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: ListaCaratula()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListaBancos(GridControl grid)
        {
            try
            {
                SqlCommand queryLista = N.Conexion.PerformConnection().CreateCommand();
                queryLista.CommandText = @"SELECT  [c_Banco]
                  ,[Descripcion]
                  ,[Nombre o razón social]
                  ,[id]
              FROM [dbo].[Bancos]";
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = queryLista;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                grid.DataSource = dataSet.Tables[0];
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: listaBancos()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void listaBancosEmpresa(GridControl grid, string ID)
        {
            try
            {
                SqlCommand queryLista = N.Conexion.PerformConnection().CreateCommand();
                queryLista.CommandText = @"SELECT 
                  [ID]
                 ,[IDEmpresa]
                  ,[RazonSocial]
                  ,[Banco]
                  ,[Cuenta]
                  ,[CLABE]
              FROM [dbo].[CatalogoBancosEmpresaPagaAsimilados]
              WHERE [IDEmpresa] = @ID";
                queryLista.Parameters.AddWithValue("@ID", ID);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = queryLista;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                grid.DataSource = dataSet.Tables[0];
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: listaBancosEmpresa()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListaClavesEmpresa(GridControl grid, string ID)
        {
            try
            {
                SqlCommand queryLista = N.Conexion.PerformConnection().CreateCommand();
                queryLista.CommandText = @"SELECT [ID]
                  ,[IDClte]
                  ,[Cliente]
                  ,[ClaveServProd]
                  ,[Concepto]
              FROM [dbo].[ClavesServCliente]
              WHERE [IDClte] = @ID";
                queryLista.Parameters.AddWithValue("@ID", ID);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = queryLista;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                grid.DataSource = dataSet.Tables[0];
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: ListaClavesEmpresa()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListaEmpleadosCaratula(GridControl grid, string seleccion)
        {
            try
            {
                string Empresa = Properties.Settings.Default["EmpresaNominaID"].ToString();
                if (seleccion.Equals("E00000"))
                {
                    SqlCommand queryListaEmpleados = N.Conexion.PerformConnection().CreateCommand();
                    queryListaEmpleados.CommandText = @"SELECT
                [idempleado]
                ,cast([NUM_EMPLEADO] as int) as [NUM_EMPLEADO]
                ,[NOMBRE] 
                ,[RFC]   
                ,[CURP]
                ,[PERIODICIDAD_PAGO] as [Periodicidad Pago]
                ,0.00 as [Ingresos]
                ,0.00 as [LimInferior]
                ,0.00 as [ExLimInf]
                ,0.00 as [PerExLimInf]
                ,0.00 as [ImpMarg]
                ,0.00 as [CF]
                ,0.00 as [ISR]
                ,0.00 as [Sub]
                ,0.00 as [ISR]
                ,0.00 as [Bruto]
                ,'Pago a Asimilados' as [Descripcion]
                ,0.00 as [Otro Concepto]
                from EMPLEADOS
WHERE [nominaEmpresaID] = @Empresa";
                    queryListaEmpleados.Parameters.AddWithValue("@Empresa", Empresa);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = queryListaEmpleados;
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    grid.DataSource = dataSet.Tables[0];
                }
                else
                {                    
                    SqlCommand queryListaEmpleados2 = N.Conexion.PerformConnection().CreateCommand();
                    queryListaEmpleados2.CommandText = @"SELECT
                    [idempleado]
                    ,cast([NUM_EMPLEADO] as int) as [NUM_EMPLEADO]
                    ,[NOMBRE] 
                    ,[RFC]   
                    ,[CURP]
                    ,[PERIODICIDAD_PAGO] as [Periodicidad Pago]
                    ,0.00 as [Ingresos]
                    ,0.00 as [LimInferior]
                    ,0.00 as [ExLimInf]
                    ,0.00 as [PerExLimInf]
                    ,0.00 as [ImpMarg]
                    ,0.00 as [CF]
                    ,0.00 as [ISR]
                    ,0.00 as [Sub]
                    ,0.00 as [ISR]
                    ,0.00 as [Bruto]
                    ,'Pago a Asimilados' as [Descripcion]
                    ,0.00 as [Otro Concepto]
                    from EMPLEADOS WHERE ID_EMPRESA = @IDE
AND [nominaEmpresaID] = @Empresa";
                    queryListaEmpleados2.Parameters.AddWithValue("@IDE", seleccion);
                    queryListaEmpleados2.Parameters.AddWithValue("@Empresa", Empresa);
                    SqlDataAdapter dataAdapter2 = new SqlDataAdapter();
                    dataAdapter2.SelectCommand = queryListaEmpleados2;
                    DataSet dataSet2 = new DataSet();
                    dataAdapter2.Fill(dataSet2);
                    grid.DataSource = dataSet2.Tables[0];
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: ListaEmplCaratula()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListaEmpleadosNomiMasiv(GridControl grid, string nominaEmpresaID)
        {
            try
            {
                SqlCommand queryListaEmpleados = N.Conexion.PerformConnection().CreateCommand();
                queryListaEmpleados.CommandText = @"SELECT
                [idempleado]
                ,cast([NUM_EMPLEADO] as int) as [NUM_EMPLEADO]
                ,[NOMBRE] 
                ,[RFC]   
                ,[CURP]
                ,[PERIODICIDAD_PAGO] as [Periodicidad Pago]
                ,0.00 as [Ingresos]
                ,0.00 as [ISR]
                ,0.00 as [Neto]
                ,'Pago a Asimilados' as [Descripcion]
                ,GETDATE() as [Fecha Aplicacion]
                ,GETDATE() as [Fecha Inicio Periodo]
                ,GETDATE() as [Fecha Fin Periodo]
                from EMPLEADOS 
                inner join [dbo].[PeriodicidadPago] as Peri 
                on EMPLEADOS.PERIODICIDAD_PAGO = Peri.c_PeriodicidadPago
                WHERE nominaEmpresaID = @Empresa";
                queryListaEmpleados.Parameters.AddWithValue("@Empresa", nominaEmpresaID);

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = queryListaEmpleados;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                grid.DataSource = dataSet.Tables[0];
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: ListaEmpleadoMasivo()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListaEmpleados(string bd, GridControl grid)
        {
            try
            {
                //N.Conexion.PerformConnection().Close();
                //N.Conexion.PerformConnection().Open();
                //N.Conexion.PerformConnection().ChangeDatabase(bd);

                SqlCommand queryListaEmpleados = N.Conexion.PerformConnection().CreateCommand();
                queryListaEmpleados.CommandText = @"SELECT
                                                   [idempleado]
                                                  ,cast([NUM_EMPLEADO] as int) as [NUM_EMPLEADO]
                                                  ,[NOMBRE] 
                                                  ,[RFC]   
                                                  ,[CURP]
                                                  ,[PERIODICIDAD_PAGO]
                                              FROM [EMPLEADOS]";

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = queryListaEmpleados;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                grid.DataSource = dataSet.Tables[0];
                //string message = N.Conexion.PerformConnection().Database;
                //XtraMessageBox.Show(message);
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controller: ListaEmpleados()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            } catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: ListadoEmpresas()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListadoLayoutGenerados(GridControl grid)
        {
            try
            {
                SqlCommand queryListado = N.Conexion.PerformConnection().CreateCommand();
                queryListado.CommandText = @"SELECT [numEmpl]
                  ,[nombreEmpleado]
                  ,[RFCEmpleado]
                  ,[CURPEmpleado]
                  ,[PeriodicidadPago]
                  ,[ingresos]
                  ,[LimInferior]
                  ,[ExLimInf]
                  ,[PerExLimInf]
                  ,[ImpMarg]
                  ,[CF]
                  ,[ISR]
                  ,[ingresosNeto]
                  ,[estatus]
                  ,[Caratula]
                  ,[Layout]
                  ,[fechaAplicacion]
                  ,[fecIniPeri]
                  ,[fecFinPeri]
                  ,[ID]
                  ,[IDCliente]
              FROM [LayoutHistorico]
              WHERE [estatus] = 'Pagado'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = queryListado;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                grid.DataSource = dataSet.Tables[0];
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: ListadoLayoutGenerado()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        public void ListaEmpresasCFDI(GridControl grid)
        {
            try
            {
                SqlCommand queryListado = N.Conexion.PerformConnection().CreateCommand();
                queryListado.CommandText = @"SELECT [NumEmpresa]
                ,[Descripcion]
                ,[Estatus]
                FROM [dbo].[EmpresaCatalogoCFDI]
                ORDER BY NumEmpresa ASC";
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = queryListado;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                grid.DataSource = dataSet.Tables[0];
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: ListaEmpresasCFDI()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListaEmpresasPago(GridControl grid)
        {
            try
            {
                SqlCommand queryListado = N.Conexion.PerformConnection().CreateCommand();
                queryListado.CommandText = @"SELECT [ID]
                  ,[IDEmpresa]
                  ,[RFC]
                  ,[RazonSocial]
                  ,[Estatus]
              FROM [dbo].[EmpresaPagaAsimilados]
              ORDER BY [IDEmpresa] ASC";
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = queryListado;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                grid.DataSource = dataSet.Tables[0];
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: ListaEmpresasPago()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DetalleLayoyt(GridControl grid, string layout)
        {
            try
            {
                SqlCommand detalle = N.Conexion.PerformConnection().CreateCommand();
                detalle.CommandText = @"SELECT [ID]
                  ,[numEmpl]
                  ,[nombreEmpleado]
                  ,[RFCEmpleado]
                  ,[CURPEmpleado]
                  ,[PeriodicidadPago]
                  ,[ingresos]
                  ,[LimInferior]
                  ,[ExLimInf]
                  ,[PerExLimInf]
                  ,[ImpMarg]
                  ,[CF]
                  ,[ISR]
                  ,[ingresosNeto]
                  ,[operacion]
                  ,[claveID]
                  ,[cuentaOrigen]
                  ,[cuenta_ClaveDestino]
                  ,[importe]
                  ,[referencia]
                  ,[descripcion]
                  ,[RFCOrdenante]
                  ,[IVA]
                  ,[fechaAplicacion]
                  ,[fecIniPeri]
                  ,[fecFinPeri]
                  ,[InstruccionPago]
                  ,[claveTipoCambio]
                  ,[fechaCreacion]
                  ,[estatus]
                  ,[BancoEmpleado]
                  ,[sub]
                  ,[Caratula]
                  ,[IDEmpresaPago]
                  ,[bancoEmpresaPago]
                  ,[IDPeriodo]
                  ,[IDCliente]
                  ,[Layout]
                  ,[tipoPago]
                  ,[otrosConceptos]
                  ,[depositoNeto]
                  ,[cuentaBancaria]
                  ,[CLABE]
                  ,[descripcionError]
              FROM [LayoutHistorico]
              WHERE [Layout] = @layout";
                detalle.Parameters.AddWithValue("@layout", layout);

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = detalle;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                grid.DataSource = dataSet.Tables[0];
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: DetalleLayoyt()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                XtraMessageBox.Show(e.Message + "\n Controller: Buscar()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //N.Conexion.PerformConnection().Close();
            }            
        }

        public void Buscar12(GridControl grid, string fechaIni, string fechaFin)
        {
            try
            {
                SqlCommand queryBuscar = N.Conexion.PerformConnection().CreateCommand();
                queryBuscar.CommandText = @"Select 
                RIGHT('00000' + CAST(Max([Folio]) AS varchar(5)) , 4) AS [Folio]
                ,[UUID]
				,ISNULL([SelloCFD], '') as [SelloCFD]
                ,[XML]
                ,[RutaXML] AS [Ruta XML]
                ,[Empleado]
                ,[RFC]
                ,[Importe]
                ,ISNULL([Total], 0) as [Total]
                ,[StatusSAT] AS [Status SAT]
                ,[FecPago] AS [Fecha Pago]
                ,[FecIni] AS [Fecha Inicio]
                ,[FecFin] AS [Fecha Final]
                ,[Empresa] from [FolioXML]
                where FecIni >= @fechIni and FecFin <= @fechFinal
                group by [Folio]
                ,UUID
				,[SelloCFD]
                ,[XML]
                ,[RutaXML] 
                ,[Empleado]
                ,[RFC]
                ,[Importe]
                ,[Total]
                ,[StatusSAT] 
                ,[FecPago] 
                ,[FecIni] 
                ,[FecFin] 
                ,[Empresa]";
                queryBuscar.Parameters.AddWithValue("@fechIni", fechaIni);
                queryBuscar.Parameters.AddWithValue("@fechFinal", fechaFin);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = queryBuscar;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                grid.DataSource = dataSet.Tables[0];
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\n Controller: Buscar12()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string pathCadenaxls = path + "xslt\\cadenaoriginal_3_3.xslt    ";

            if (!File.Exists(pathHTMLPlantilla) || !File.Exists(pathWKHTMLTOPDF) || !File.Exists(pathCadenaxls))
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
            string pathCadenaXlst = pathDestino + "xslt\\cadenaoriginal_3_3.xslt";
            string pathOrigen = @"C:/DocAsimilados/";
            string plantillaNombre = "Formato_Factura_33_a.html";
            string archivo = null;

            string origenPlantilla = Path.Combine(pathOrigen, plantillaNombre);
            string destinoPlantilla = Path.Combine(pathDestino, plantillaNombre);
            string origenPDF = Path.Combine(pathOrigen, "wkhtmltopdf/");
            string destinoPDF = null;

            string origenXslt = Path.Combine(pathOrigen, "xslt/");
            string origenCadenaXslt = Path.Combine(pathOrigen, "xslt/cadenaoriginal_3_3.xslt");
            string destinoCadenaXslt = Path.Combine(pathDestino, "xslt");

            if (BuscarRecursos().Equals(false))
            {
                if (!File.Exists(pathHTMLPlantilla))
                {
                    try
                    {
                        File.Copy(origenPlantilla, destinoPlantilla, true);
                    }catch (Exception e)
                    {
                        XtraMessageBox.Show(e.Message + "\nHubo un error al intentar generar los archivos necesarios para crear PDF, por favor pongase en contacto con el administrador de sistema.", "Error");
                    }
                }

                if (!File.Exists(pathCadenaXlst))
                {
                    try
                    {
                        if (!Directory.Exists(origenXslt))
                        {
                            XtraMessageBox.Show("La carpeta de origen de archivos XLM no existe.\nPor favor, notifique al administrador de sistema.", "Error");
                        }
                        else
                        {
                            if (!Directory.Exists(pathDestino + "xslt"))
                            {
                                Directory.CreateDirectory(pathDestino + "xslt");
                                //File.Copy(origenCadenaXslt, pathDestino + "xslt/cadenaoriginal_3_3.xslt", true);
                                string[] files = Directory.GetFiles(origenXslt);
                                foreach (string f in files)
                                {
                                    archivo = Path.GetFileName(f);
                                    destinoPDF = Path.Combine(pathDestino + "xslt", archivo);
                                    File.Copy(f, destinoPDF, true);
                                }
                            }
                            else
                            {
                                File.Copy(origenCadenaXslt, pathDestino + "xslt/cadenaoriginal_3_3.xslt", true);
                                string[] files = Directory.GetFiles(origenXslt);
                                foreach (string f in files)
                                {
                                    archivo = Path.GetFileName(f);
                                    destinoPDF = Path.Combine(pathDestino + "xslt", archivo);
                                    File.Copy(f, destinoPDF, true);
                                }
                            }
                        }
                    }catch(Exception e)
                    {
                        XtraMessageBox.Show(e.Message + "\nHubo un error al intentar generar los archivos necesarios para crear XML, por favor pongase en contacto con el administrador de sistema.", "Error");
                    }
                }

                if (!File.Exists(pathWKHTMLTOPDF))
                {
                    try
                    {
                        if (!Directory.Exists(origenPDF))
                        {
                            XtraMessageBox.Show("La carpeta de origen de archivos PDF no existe.\nPor favor, notifique al administrador de sistema.","Error");
                        }
                        else
                        {
                            if (!Directory.Exists(pathDestino + "wkhtmltopdf"))
                            {
                                Directory.CreateDirectory(pathDestino + "wkhtmltopdf");
                                string[] files = Directory.GetFiles(origenPDF);
                                foreach (string f in files)
                                {
                                    archivo = Path.GetFileName(f);
                                    destinoPDF = Path.Combine(pathDestino + "wkhtmltopdf", archivo);
                                    File.Copy(f, destinoPDF, true);
                                }
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
                        XtraMessageBox.Show(e.Message + "\nHubo un error al intentar generar los archivos necesarios para crear PDF, por favor pongase en contacto con el administrador de sistema.", "Error");

                    }
                }

            }
            else
            {

            }
        }



        [Obsolete]
        public string LeerXMLModAsim(string pathXML, string pathF, SplashScreenManager splashScreenManager)
        {
            try
            {            
                Comprobante oComprobante;

                ///*oComprobante*/.Nomina12.Receptor.Departamento
                XmlSerializer oSerializer = new XmlSerializer(typeof(Comprobante));

                using (StreamReader reader = new StreamReader(pathXML))
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

                //XtraMessageBox.Show(resultHtml);

                System.IO.File.WriteAllText(pathHTMLTemp, resultHtml);

                //string pathWKHTMLTOPDF = @"C:\Users\aespejel\Downloads\Facturacion3.3-tutorial-pdf\XMLToClassSAT\wkhtmltopdf\wkhtmltopdf.exe";

                GlobalConfig gc = new GlobalConfig();
                //gc.SetMargins(new Margins(100, 100, 100, 100))
                //.SetDocumentTitle("Test document")
                //.SetPaperSize(PaperKind.Letter);

                // Create converter
                IPechkin pechkin = new SynchronizedPechkin(gc);

                // Create document configuration object
                ObjectConfig configuration = new ObjectConfig();

                configuration.SetAllowLocalContent(true)
                .SetPrintBackground(true);
                byte[] pdfContent = pechkin.Convert(configuration, resultHtml);

                ByteArrayToFile(pathF + ".pdf", pdfContent);

                //string pathWKHTMLTOPDF = path + "wkhtmltopdf\\wkhtmltopdf.exe";
                //ProcessStartInfo oProcessStartInfo = new ProcessStartInfo();
                ////oProcessStartInfo.CreateNoWindow = true;
                //oProcessStartInfo.UseShellExecute = false;
                //oProcessStartInfo.FileName = pathWKHTMLTOPDF;
                //oProcessStartInfo.Arguments = "miHtml.html mipdf.pdf";
                ////oProcessStartInfo.Arguments = pathF + ".html "+ pathF +".pdf";

                //using (Process oProcess = Process.Start(oProcessStartInfo))
                //{
                //    oProcess.WaitForExit();
                //}
                //eliminamos el archivo temporal
                System.IO.File.Delete(pathHTMLTemp);
                //File.Move(path + "mipdf.pdf", pathF + ".pdf");
                //System.IO.File.Delete(path + "mipdf.pdf");
                string respuesta;
                respuesta = pathF + ".pdf";
                return respuesta;

            }
            catch (Exception e)
            {
                string respuesta;

                if (splashScreenManager.IsSplashFormVisible.Equals(true))
                {
                    splashScreenManager.CloseWaitForm();
                }
                //XtraMessageBox.Show(e.Message + "\nControlador: LeerXML()", "Error");
                respuesta = e.Message.ToString();
                return respuesta;
            }

        }

        public bool ByteArrayToFile(string _FileName, byte[] _ByteArray)
        {
            try
            {
                // Open file for reading
                FileStream _FileStream = new FileStream(_FileName, FileMode.Create, FileAccess.Write);
                // Writes a block of bytes to this stream using data from  a byte array.
                _FileStream.Write(_ByteArray, 0, _ByteArray.Length);

                // Close file stream
                _FileStream.Close();

                return true;
            }
            catch (Exception _Exception)
            {
                XtraMessageBox.Show("Exception caught in process while trying to save : {0}"  + _Exception.ToString(),"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        [Obsolete]
        public void LeerXML(string pathXML, string pathF, SplashScreenManager splashScreenManager)
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
                splashScreenManager.SetWaitFormCaption("Generando PDF");
                string path = AppDomain.CurrentDomain.BaseDirectory + "/";
                //string path = @"C:\Users\aespejel\source\repos\winAsimilados\winAsimilados\Resources\";
                string pathHTMLTemp = path + "miHtml.html"; //temporal
                string pathHTMLPlantilla = path + "Formato_Factura_33_a.html";
                string sHtml = GetStringOfFile(pathHTMLPlantilla);
                string resultHtml = "";

                resultHtml = RazorEngine.Razor.Parse(sHtml, oComprobante);

                //XtraMessageBox.Show(resultHtml);

                System.IO.File.WriteAllText(pathHTMLTemp, resultHtml);

                //string pathWKHTMLTOPDF = @"C:\Users\aespejel\Downloads\Facturacion3.3-tutorial-pdf\XMLToClassSAT\wkhtmltopdf\wkhtmltopdf.exe";
                string pathWKHTMLTOPDF = path + "wkhtmltopdf\\wkhtmltopdf.exe";
                ProcessStartInfo oProcessStartInfo = new ProcessStartInfo();
                oProcessStartInfo.CreateNoWindow = true;
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
                splashScreenManager.CloseWaitForm();
                XtraMessageBox.Show(e.Message + "\nControlador: LeerXML()", "Error");
            }

        }

        [Obsolete]
        public void LeerXML12(string pathXML, string pathF, SplashScreenManager splashScreenManager)
        {
            try
            {
                Comprobante oComprobante;

                ///*oComprobante*/.Nomina12.Receptor.Departamento
                XmlSerializer oSerializer = new XmlSerializer(typeof(Comprobante));

                using (StreamReader reader = new StreamReader(pathXML))
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
                splashScreenManager.SetWaitFormCaption("Generando PDF");
                string path = AppDomain.CurrentDomain.BaseDirectory + "/";
                //string path = @"C:\Users\aespejel\source\repos\winAsimilados\winAsimilados\Resources\";
                string pathHTMLTemp = path + "miHtml.html"; //temporal
                string pathHTMLPlantilla = path + "Formato_Factura_33_a.html";
                string sHtml = GetStringOfFile(pathHTMLPlantilla);
                string resultHtml = "";

                resultHtml = RazorEngine.Razor.Parse(sHtml, oComprobante);

                //XtraMessageBox.Show(resultHtml);

                System.IO.File.WriteAllText(pathHTMLTemp, resultHtml);

                //string pathWKHTMLTOPDF = @"C:\Users\aespejel\Downloads\Facturacion3.3-tutorial-pdf\XMLToClassSAT\wkhtmltopdf\wkhtmltopdf.exe";
                GlobalConfig gc = new GlobalConfig();
                //gc.SetMargins(new Margins(100, 100, 100, 100))
                //.SetDocumentTitle("Test document")
                //.SetPaperSize(PaperKind.Letter);

                // Create converter
                SynchronizedPechkin pechkin = new SynchronizedPechkin(gc);

                // Create document configuration object
                ObjectConfig configuration = new ObjectConfig();

                configuration.SetAllowLocalContent(true)
                .SetPrintBackground(true);          
                byte[] pdfContent = pechkin.Convert(configuration, resultHtml);           

                ByteArrayToFile(pathF + ".pdf", pdfContent);

                //string pathWKHTMLTOPDF = path + "wkhtmltopdf\\wkhtmltopdf.exe";
                //ProcessStartInfo oProcessStartInfo = new ProcessStartInfo();
                ////oProcessStartInfo.CreateNoWindow = true;
                //oProcessStartInfo.UseShellExecute = false;
                //oProcessStartInfo.FileName = pathWKHTMLTOPDF;
                //oProcessStartInfo.Arguments = "miHtml.html mipdf.pdf";
                ////oProcessStartInfo.Arguments = pathF + ".html "+ pathF +".pdf";

                //using (Process oProcess = Process.Start(oProcessStartInfo))
                //{
                //    oProcess.WaitForExit();
                //}
                //eliminamos el archivo temporal
                //System.IO.File.Delete(pathHTMLTemp);
                //File.Move(path + "mipdf.pdf", pathF + ".pdf");
                //System.IO.File.Delete(path + "mipdf.pdf");
            }
            catch (Exception e)
            {
                splashScreenManager.CloseWaitForm();
                XtraMessageBox.Show(e.Message + "\nControlador: LeerXML()", "Error");
            }

        }
        [Obsolete]
        public void Generar12(List<E.UUID> list, SplashScreenManager splashScreenManager)
        {
            string uuid = null;
            string rutaXML =null;
            string XML = null;
            string fecPago = null;
            string nomEmpl = null;
            string RFC = null;
            string pathPDF = @"C:\XML\";
            string PDF = null;
            int cont = 0;

            if (list.Count() == 0)
            {
                XtraMessageBox.Show("Por favor, seleccione una celda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                splashScreenManager.ShowWaitForm();
                foreach (var item in list)
                {
                    cont++;
                    if (!splashScreenManager.IsSplashFormVisible)
                    {
                        splashScreenManager.ShowWaitForm();
                    }
                    SqlCommand QueryUUID = N.Conexion.PerformConnection().CreateCommand();
                    SqlDataReader readerUUID;
                    QueryUUID.CommandText = @"Select
                    UUID
                    ,XML
                    ,RutaXML
                    ,Empleado
                    ,RFC
                    ,FecPago
                    from FolioXML
                    where UUID = @uuid";
                    QueryUUID.Parameters.AddWithValue("@uuid", item.UIID);
                    readerUUID = QueryUUID.ExecuteReader();

                    while (readerUUID.Read())
                    {
                        rutaXML = readerUUID.GetString(2).ToString();
                        RFC = readerUUID.GetString(4).ToString();
                        fecPago = readerUUID.GetDateTime(5).ToString("dd-MM-yyy");
                        nomEmpl = readerUUID.GetString(3).ToString();
                        uuid = readerUUID.GetString(0).ToString();
                        XML = readerUUID.GetString(1).ToString();
                    }
                    readerUUID.Close();
                    //pathPDF = pathPDF + fecPago + @"\";

                    string cadena = rutaXML;
                    string[] arrayCadena;
                    arrayCadena = cadena.Split(Convert.ToChar(@"\"));
                    //XtraMessageBox.Show(arrayCadena[3]);
                    string newRuta = Path.Combine(arrayCadena[0], arrayCadena[1], arrayCadena[2]);

                    string ruta = arrayCadena[0] + "/" + arrayCadena[1] + "/" + arrayCadena[2] + "/"; //@"C:/XML/" + fecPago + "/";
                    if (!Directory.Exists(ruta))
                    {
                        Directory.CreateDirectory(ruta);
                    }
                    PDF = Path.Combine(ruta, fecPago + "_" + RFC + "_" + nomEmpl + "_" + uuid);
                    if (File.Exists(rutaXML) && File.Exists(Path.Combine(PDF + ".pdf")))
                    {
                        splashScreenManager.CloseWaitForm();
                        XtraMessageBox.Show("Los archivos PDF & XLM de: " + nomEmpl + " UUID: " + uuid + "\nYa fueron creados anteriormente." +
                            "\nRuta: " + ruta, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (File.Exists(rutaXML))
                        {
                            if(!File.Exists(Path.Combine(PDF + ".pdf")))
                            {
                                LeerXML12(rutaXML, Path.Combine(PDF + ".pdf"), splashScreenManager);
                            }
                        }
                        else
                        {
                            splashScreenManager.CloseWaitForm();
                            var result = XtraMessageBox.Show("El archivo XML de " + nomEmpl + " UUID: " + uuid + 
                                " no existe.´\n¿Desea Crearlo?"
                                , "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result.Equals(DialogResult.Yes))
                            {
                                if (!splashScreenManager.IsSplashFormVisible)
                                {
                                    splashScreenManager.ShowWaitForm();
                                }
                                FileStream fs = new FileStream(path: rutaXML, mode: FileMode.Create);
                                byte[] info = new UTF8Encoding(true).GetBytes(XML);
                                fs.Write(info, 0, info.Length);
                                fs.Close();

                                if (!File.Exists(Path.Combine(PDF + ".pdf")))
                                {
                                    splashScreenManager.CloseWaitForm();
                                    var resultPDF = XtraMessageBox.Show("El archivo PDF de " + nomEmpl + " UUID: " + uuid +
                                    " no existe.\n¿Desea Crearlo?"
                                    , "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (resultPDF.Equals(DialogResult.Yes))
                                    {
                                        if (!splashScreenManager.IsSplashFormVisible)
                                        {
                                            splashScreenManager.ShowWaitForm();
                                        }
                                        PDF = Path.Combine(PDF + ".pdf");
                                        LeerXML12(rutaXML, PDF, splashScreenManager);
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("¡XML generado con éxito! Generación del PDF cancelada"
                                            , "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }

                            }
                            else
                            {
                                XtraMessageBox.Show("Error al generar archivo PDF.\n" +
                                    "(El Archivo XML es necesario para crear PDF)", "Error", MessageBoxButtons.OK
                                    , MessageBoxIcon.Error);
                            }
                        }
                    }

                    if (cont == list.Count())
                    {
                        if (splashScreenManager.IsSplashFormVisible)
                        {
                            splashScreenManager.CloseWaitForm();
                        }

                        XtraMessageBox.Show("¡Proceso Terminado!", "Mensaje", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                    }

                }

            }

        }
        [Obsolete]
        public bool Generar(List<E.UUID> list, SplashScreenManager splashScreenManager)
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
                        XtraMessageBox.Show("Por favor, seleccione una celda", "Error");
                        return false;
                    }
                    else
                    {
                        splashScreenManager.ShowWaitForm();
                        //XtraMessageBox.Show(list.Count().ToString());
                        foreach (var uuid in list)
                        {
                            if (!splashScreenManager.IsSplashFormVisible)
                            {
                                splashScreenManager.ShowWaitForm();
                            }
                            cont++;
                            //XtraMessageBox.Show(uuid.UIID,"Información");
                            try
                            {
                                //N.Conexion.PerformConnection().Open();
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
                                splashScreenManager.SetWaitFormCaption("Generando XML de: " + nombreTrabajador);
                                readerUUID.Close();
                               // N.Conexion.PerformConnection().Close();
                                //XtraMessageBox.Show(XML);
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
                                    splashScreenManager.CloseWaitForm();
                                    XtraMessageBox.Show("Los archivos de " + nombreTrabajador + ":\n(UUID: " + UUID + ")" + "\nYa fueron creados con anterioridad.", "Aviso");
                                }
                                else
                                {
                                    FileStream fs = new FileStream(path: ruta + nombre + ".xml", mode: FileMode.Create);
                                    byte[] info = new UTF8Encoding(true).GetBytes(XML);
                                    fs.Write(info, 0, info.Length);
                                    fs.Close();

                                    LeerXML(rutafila, rutafila, splashScreenManager);
                                }

                                if (cont == list.Count())
                                {
                                    if (splashScreenManager.IsSplashFormVisible)
                                    {
                                        splashScreenManager.CloseWaitForm();
                                    }
                                    
                                    XtraMessageBox.Show("¡Proceso Terminado!", "Mensaje");
                                }

                            }
                            catch (Exception e)
                            {
                                //N.Conexion.PerformConnection().Close();
                                splashScreenManager.CloseWaitForm();
                                XtraMessageBox.Show(e.Message + "\nControlador: Generar(Foreach{})", "Error");
                            }
                        }
                        return true;
                    }

                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(e.Message + "\nError Controller: Generar()", "Error");
                    
                    return false;
                }
            }
            else
            {
                XtraMessageBox.Show("Faltan archivos necesarios para generar PDF, Por favor pongase en contacto con el administrador de sistema.", "Error");
                AgregarRecursos();
                return false;
            }
 
        }
    }
}