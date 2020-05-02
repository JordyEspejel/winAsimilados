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

        public string GetEntFed(string bd,string CodPost)
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

            }catch(Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: GetEntFed()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public E.Parametros GetParametros(string RFC)
        {
            try
            {
                E.Parametros parametros = new E.Parametros();

                SqlCommand queryParametros = N.Conexion.PerformConnection().CreateCommand();
                queryParametros.CommandText = @"SELECT TOP (1) [ID]
                      ,[NOMBRE_EMPRESA]
                      ,[RFC]
                      ,[REGISTRO_PATRONAL]
                      ,[REGISTRO_NSS]
                      ,[REPRESENTANTE]
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
                      ,[COD_CONCEPTO_Cti]
                      ,[FECHA_INICIO_CERTIFICADO]
                      ,[ORIGEN_RECURSOS]
                      ,[TIPO_NOMINA]
                      ,[ARCHIVO_CER]
                      ,[ARCHIVO_KEY]
                      ,[ASUNTO_CERTIFICADO]
                      ,[COLONIA]
                      ,[RUTA_ALMACEN_PDF]
                  FROM [PARAMETROS] WHERE RFC = @RFC";
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
                }
                readerParametros.Close();

                return parametros;
            }catch(Exception e)
            {
                XtraMessageBox.Show(e.Message + "Error controlador: GetParametros()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public E.Calculo GeneraCalculo(decimal Ingresos, string Periodicidad, string TipoIngresos)
        {
            try
            {
                E.Calculo calculo = new E.Calculo();                

                if (TipoIngresos.Equals("Brutos"))
                {
                    calculo.IngresosBrutos = Ingresos;

                    if (Periodicidad.Equals("Semanal"))
                    {
                        var ISR07 = new List<E.ISR7>();
                        E.ISR7[] isr07 = null;

                        var SUB07 = new List<E.SUB7>();
                        E.SUB7[] sub07 = null;

                        N.Conexion.PerformConnectionSoprade().Open();
                        SqlCommand queryTablaISR = N.Conexion.PerformConnectionSoprade().CreateCommand();
                        queryTablaISR.CommandText = @"select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                        from genTablasNumericasDet 
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

                        SqlCommand queryTablaSub = N.Conexion.PerformConnectionSoprade().CreateCommand();
                        queryTablaSub.CommandText = @"
                        select tnudValor1, tnudValor2, tnudValor3
                        from genTablasNumericasDet 
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
                            if(Ingresos >= valor.rango1 && Ingresos <= valor.rango2)
                            {
                                calculo.Sub = valor.subsidio;
                            }
                        }

                        foreach (var valor in isr07)
                        {
                            if (Ingresos >= valor.LimiteInferior && Ingresos <= valor.LimiteSuperior)
                            {
                                calculo.LimInferior = valor.LimiteInferior;
                                calculo.PerExLimInf = valor.Porcentaje;
                                calculo.CF = valor.CuotaFija;
                            }
                        }
                        calculo.ExLimInf = calculo.IngresosBrutos - calculo.LimInferior;
                        calculo.ImpMarg = calculo.ExLimInf * calculo.PerExLimInf;
                        calculo.ISR = calculo.CF + calculo.ImpMarg;
                        calculo.IngresosNetos = calculo.IngresosBrutos - calculo.ISR + calculo.Sub;
                    }

                    if (Periodicidad.Equals("Quincenal"))
                    {
                        var ISR15 = new List<E.ISR15>();
                        E.ISR15[] isr15 = null;

                        var SUB15 = new List<E.SUB15>();
                        E.SUB15[] sub15 = null;

                        N.Conexion.PerformConnectionSoprade().Open();
                        SqlCommand queryTablaISR = N.Conexion.PerformConnectionSoprade().CreateCommand();
                        queryTablaISR.CommandText = @"select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                        from genTablasNumericasDet 
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
                        SqlCommand queryTablaSub = N.Conexion.PerformConnectionSoprade().CreateCommand();
                        queryTablaSub.CommandText = @"
                        select tnudValor1, tnudValor2, tnudValor3
                        from genTablasNumericasDet 
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
                                calculo.Sub = valor.subsidio;
                            }
                        }

                        foreach (var valor in isr15)
                        {
                            if (Ingresos >= valor.LimiteInferior && Ingresos <= valor.LimiteSuperior)
                            {
                                calculo.LimInferior = valor.LimiteInferior;
                                calculo.PerExLimInf = valor.Porcentaje;
                                calculo.CF = valor.CuotaFija;
                            }
                        }
                        calculo.ExLimInf = calculo.IngresosBrutos - calculo.LimInferior;
                        calculo.ImpMarg = calculo.ExLimInf * calculo.PerExLimInf;
                        calculo.ISR = calculo.CF + calculo.ImpMarg;
                        calculo.IngresosNetos = calculo.IngresosBrutos - calculo.ISR + calculo.Sub;
                    }

                    if (Periodicidad.Equals("Mensual"))
                    {
                        var ISR30 = new List<E.ISR30>();
                        E.ISR30[] isr30 = null;

                        var SUB30 = new List<E.SUB30>();
                        E.SUB30[] sub30 = null;

                        N.Conexion.PerformConnectionSoprade().Open();
                        SqlCommand queryTablaISR = N.Conexion.PerformConnectionSoprade().CreateCommand();
                        queryTablaISR.CommandText = @"select tnudValor1, tnudValor2, tnudValor3, tnudValor4 
                        from genTablasNumericasDet 
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
                        SqlCommand queryTablaSub = N.Conexion.PerformConnectionSoprade().CreateCommand();
                        queryTablaSub.CommandText = @"
                        select tnudValor1, tnudValor2, tnudValor3
                        from genTablasNumericasDet 
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
                        N.Conexion.PerformConnectionSoprade().Close();

                        foreach (var valor in sub30)
                        {
                            if (Ingresos >= valor.rango1 && Ingresos <= valor.rango2)
                            {
                                calculo.Sub = valor.subsidio;
                            }
                        }

                        foreach (var valor in isr30)
                        {
                            if (Ingresos >= valor.LimiteInferior && Ingresos <= valor.LimiteSuperior)
                            {
                                calculo.LimInferior = valor.LimiteInferior;
                                calculo.PerExLimInf = valor.Porcentaje;
                                calculo.CF = valor.CuotaFija;
                            }
                        }
                        calculo.ExLimInf = calculo.IngresosBrutos - calculo.LimInferior;
                        calculo.ImpMarg = calculo.ExLimInf * calculo.PerExLimInf;
                        calculo.ISR = calculo.CF + calculo.ImpMarg;
                        calculo.IngresosNetos = calculo.IngresosBrutos - calculo.ISR + calculo.Sub;
                    }
                }

                return calculo;
            }
            catch(Exception e)
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
                E.Empleado empleado = new E.Empleado();

                SqlCommand queryEmpleado = N.Conexion.PerformConnection().CreateCommand();
                queryEmpleado.CommandText = @"select NUM_EMPLEADO, RFC, CURP, Descripcion as [Periodicidad Pago]
                , NOMBRE, TIPO_REGIMEN, TIPO_CONTRATO, SINDICALIZADO
                , DEPARTAMENTO, PUESTO
                from EMPLEADOS 
                inner join [BSNOMINAS].[dbo].[PeriodicidadPago] as Peri
                on EMPLEADOS.PERIODICIDAD_PAGO = Peri.c_PeriodicidadPago
                where RFC = @RFC";
                queryEmpleado.Parameters.AddWithValue("@RFC", RFC);

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
                }
                readerEmpleado.Close();

                //XtraMessageBox.Show(empleado.NumEmpl + "\n" + empleado.RFC + "\n" + empleado.CURP + "\n" + empleado.Periodicidad);

                return empleado;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: BuscaEmpleado()" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<E.Colonia> Colonias(string BD, string CP, List <E.Colonia> colonias)
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
                    colonias.Add(new E.Colonia{
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

        public List <E.Municipio> Municipios(string BD, string Estado, List <E.Municipio> municipios)
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
            }catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: CreaTablas()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string nameDB = "Nomina_Empresa", newNameDB = null, localidad = null, fechaIniCer = parametros.FECHA_INICIO_CERTIFICADO.ToString("yyyy-MM-dd"), fechaFincer = parametros.FECHA_VENCIMIENTO_CERTIFICADO.ToString("yyy-MM-dd");
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

                SqlCommand queryCreaBD = N.Conexion.PerformConnection().CreateCommand();
                queryCreaBD.CommandText = @"CREATE DATABASE " + newNameDB;

                #region creaTablas 
                SqlCommand queryCreaTablas2 = N.Conexion.PerformConnection().CreateCommand();
                queryCreaTablas2.CommandText = CreaTablas2();
                //SqlCommand queryCreaTablas = N.Conexion.PerformConnection().CreateCommand();
                #endregion
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
                                               ,[RUTA_ALMACEN_PDF])
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
                                               "'" + parametros.RUTA_ALMACEN_PDF + "')";

                if (queryInsertEmpr.ExecuteNonQuery().Equals(1))
                {
                    if (!queryCreaBD.ExecuteNonQuery().Equals(1))
                    {
                        N.Conexion.PerformConnection().ChangeDatabase(newNameDB);
                        if (!queryCreaTablas2.ExecuteNonQuery().Equals(0))
                        {
                            //XtraMessageBox.Show("¡Empresa Agregada con Éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //splashScreenManager.CloseWaitForm();
                            //XtraMessageBox.Show(queryParametros.CommandText.ToString());
                            if (queryParametros.ExecuteNonQuery().Equals(1))
                            {
                                splashScreenManager.CloseWaitForm();
                                XtraMessageBox.Show("¡Empresa Agregada con Éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                }


                N.Conexion.PerformConnection().ChangeDatabase(BD);
                //splashScreenManager.CloseWaitForm();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador:CrearBDEmpresa()" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                splashScreenManager.CloseWaitForm();
            }
        }
        public bool AccedeEmpresa(string Empresa)
        {
            try
            {
                N.Conexion.PerformConnection().Open();
                N.Conexion.PerformConnection().ChangeDatabase(Empresa);
                return true;
            }catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError en controlador:AccedeEmpresa()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                //XtraMessageBox.Show("\nPASS: " + passEncrip + "\nUsua: " + User.usuario.ToUpper());

                queryLogin.CommandText = @"select usuaIDUsua, usuaPasswd from segUsuarios where usuaIDUsua = @usuario and usuaPasswd = @pass";
                queryLogin.Parameters.AddWithValue("@usuario", User.usuario.ToUpper());
                queryLogin.Parameters.AddWithValue("@pass", passEncrip.ToString());
                readerLogin = queryLogin.ExecuteReader();
                

                if (readerLogin.Read())
                {
                    //XtraMessageBox.Show("Entra", "");
                    //Form1 frm = new Form1();
                    //frm.Show();
                    readerLogin.Close();
                    N.Conexion.PerformConnectionSoprade().Close();
                    return true;
                }
                else
                {
                    //XtraMessageBox.Show("no entra", "");
                    readerLogin.Close();
                    N.Conexion.PerformConnectionSoprade().Close();
                    return false;
                }


                           
            }catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "Error login()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ,[SINDICALIZADO])
                VALUES
                ('" + numEmplNue + "','" + empleado.Nombre + "','" + empleado.RFC + "','" + empleado.CURP + "','" + "09'," + "'ASIMILADOS'," + "'01/01/1900'," + "'ASIMILADOS',"
                + "'99'," + "'00','" + empleado.Periodicidad + "'," + "'No'" + ")";
                
                if (ReaderEmpl.Read())
                {
                    XtraMessageBox.Show("El empleado:" + empleado.Nombre + "\nYa se encuentra registrado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReaderEmpl.Close();
                }
                else
                {
                    //XtraMessageBox.Show("No existe");
                    ReaderEmpl.Close();
                    if (queryInsertaEmpl.ExecuteNonQuery().Equals(1))
                    {
                        XtraMessageBox.Show("¡Empleado agregado satisfactoriamente!", "Agregar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: AgregaEmpleado()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        public void EditarEmpleado(Object _P, SplashScreenManager splashScreenManager)
        {
            try
            {
                E.Empleado empleado = (E.Empleado)_P;

                //query update
                SqlCommand queryUpdateEmpl = N.Conexion.PerformConnection().CreateCommand();
                queryUpdateEmpl.CommandText = @"UPDATE EMPLEADOS set NOMBRE = '" + empleado.Nombre +"',"+ "RFC = '" + empleado.RFC + "',"
                + "CURP = '" + empleado.CURP + "', PERIODICIDAD_PAGO = '" + empleado.Periodicidad + "' where idempleado = " + empleado.IDEmpleado + ""; //lo modifica por el ID del empleado
                if (queryUpdateEmpl.ExecuteNonQuery().Equals(1))
                {
                    splashScreenManager.CloseWaitForm();
                    XtraMessageBox.Show("¡Información Actualizada Con Éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    splashScreenManager.CloseWaitForm();
                    XtraMessageBox.Show("¡Error Al  Actualizar La Información!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception e)
            {
                splashScreenManager.CloseWaitForm();
                XtraMessageBox.Show(e.Message + "\nError Controlador: EditarEMpleado()", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int numEmplAnt = 0, numEmplNue = 0, contErroresExis = 0, contErrores = 0, contExito = 0, cont = 0, contErrRFC = 0, contErrCURP = 0, validaCURP = 0, ValidaRFC = 0, ValidaExiste = 0, TotalErrores = 0;
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
                        contErrores++;
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
                        contErroresExis++;
                        contErrCURP++;
                        string MensajeCURP = "CURP no cumple con el formato correcto, favor de verificar";
                        contErrores++;
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
                        //XtraMessageBox.Show("El empleado:" + empleado.Nombre + "\nYa se encuentra registrado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    //XtraMessageBox.Show("No existe");

                    if (validaCURP == 1 && ValidaRFC == 1 && ValidaExiste == 1)
                    {
                        if (queryInsertaEmpl.ExecuteNonQuery().Equals(1))
                        {
                            contExito++;
                            //XtraMessageBox.Show("¡Empleado agregado satisfactoriamente!", "Agregar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            TotalErrores = contErroresExis + contErrRFC + contErrCURP;
                            builder.AppendLine();
                            builder.Append("********************************       Fin Erroes      ******************************************" + "\r\n");
                            splashManager.CloseWaitForm();
                            XtraMessageBox.Show("Proceso terminado con " + TotalErrores + " errores y " + contExito + " con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            writer = new StreamWriter(path, true);
                            writer.Write(builder);
                            writer.Close();
                            Process proceso = new Process();
                            proceso.StartInfo.FileName = path;
                            proceso.Start();
                        }
                        else
                        {
                            splashManager.CloseWaitForm();
                            XtraMessageBox.Show("¡Carga masiva terminada con éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }
            catch (Exception e)
            {
               
                XtraMessageBox.Show(e.Message + "\nError Controlador: AgregaEmpleadoMasivo()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                splashManager.CloseWaitForm();
            }
        }

        public void ListaEmpleadosNomiMasiv(GridControl grid)
        {
            SqlCommand queryListaEmpleados = N.Conexion.PerformConnection().CreateCommand();
            queryListaEmpleados.CommandText = @"SELECT
            [idempleado]
            ,[NUM_EMPLEADO]
            ,[NOMBRE] 
            ,[RFC]   
            ,[CURP]
            ,Descripcion as [Periodicidad Pago]  from EMPLEADOS 
            inner join [BSNOMINAS].[dbo].[PeriodicidadPago] as Peri 
            on EMPLEADOS.PERIODICIDAD_PAGO = Peri.c_PeriodicidadPago";

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = queryListaEmpleados;
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            grid.DataSource = dataSet.Tables[0];
        }
        public void ListaEmpleados (string bd, GridControl grid)
        {
            try
            {
                //N.Conexion.PerformConnection().Close();
                //N.Conexion.PerformConnection().Open();
                //N.Conexion.PerformConnection().ChangeDatabase(bd);

                SqlCommand queryListaEmpleados = N.Conexion.PerformConnection().CreateCommand();
                queryListaEmpleados.CommandText = @"SELECT
                                                   [idempleado]
                                                  ,[NUM_EMPLEADO]
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

            }catch (Exception e)
            {
                XtraMessageBox.Show(e.Message + "\nError Controlador: ListadoEmpresas()","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                //XtraMessageBox.Show(resultHtml);

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
                XtraMessageBox.Show(e.Message + "\nControlador: LeerXML()", "Error");
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
                            //if (splashScreenManager.IsSplashFormVisible)
                            //{

                            //}
                            //else
                            //{
                            //    splashScreenManager.CloseWaitForm();
                            //}
                            cont++;
                            //XtraMessageBox.Show(uuid.UIID,"Información");
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

                                    XtraMessageBox.Show("Los archivos de " + nombreTrabajador + ":\n(UUID: " + UUID + ")" + "\nYa fueron creados con anterioridad.", "Aviso");

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
                                    splashScreenManager.CloseWaitForm();
                                    XtraMessageBox.Show("¡Proceso Terminado!", "Mensaje");
                                }

                            }
                            catch (Exception e)
                            {
                                N.Conexion.PerformConnection().Close();
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