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
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public bool CreaTablas()
        {
            try
            {
                string path = @"C:\DocAsimilados\CreaTablasEmpresa.sql";
                string path2 = @"C:\DocAsimilados\prueba.sql";
                ProcessStartInfo cmd;
                cmd = new ProcessStartInfo("sqlcmd", "-S server-contpaq\\compac17 -i " + path);

                cmd.UseShellExecute = false;
                cmd.CreateNoWindow = false;
                cmd.RedirectStandardOutput = true;

                Process process = new Process();
                process.StartInfo = cmd;
                process.Start();
                return true;
            }catch (Exception e)
            {
                MessageBox.Show(e.Message + "\nError Controlador: CreaTablas()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;          
            }
        }
        public void CreaBDEmpresa(string BD, Object _P, SplashScreenManager splashScreenManager)
        {
            try
            {
                E.Empresa empresa = (E.Empresa)_P;
                //splashScreenManager.WaitForSplashFormClose();
                string nameDB = "Nomina_Empresa", newNameDB = null;
                int num = 0, nextNum = 0;
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
                //MessageBox.Show(newNameDB);

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
                SqlCommand queryCreaTablas = N.Conexion.PerformConnection().CreateCommand();

                queryCreaTablas.CommandText = @"SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADC](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](50) NOT NULL,
	[XML_ADJUNTO] [text] NULL,
	[TIPO_DOCUMENTO] [varchar](10) NOT NULL,
	[NATURALEZA_DOCUMENTO] [varchar](5) NOT NULL,
	[ESTATUS_SAT] [varchar](20) NOT NULL,
	[FECHA_INICIAL] [date] NOT NULL,
	[FECHA_FINAL] [date] NOT NULL,
	[RFC] [varchar](13) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[UUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALMACEN_TIMBRES](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](50) NOT NULL,
	[FECHA_PAGO] [date] NULL,
	[FICHERO_XML] [text] NULL,
	[RFC_TRABAJADOR] [varchar](13) NULL,
	[REGISTRO_PATRONAL] [varchar](20) NULL,
	[XML_ADJUNTO] [text] NULL,
	[FECHA_INICIAL_PAGO] [date] NULL,
	[FECHA_FINAL_PAGO] [date] NULL,
	[DIAS_PAGADOS] [int] NULL,
	[TIPO_NOMINA] [varchar](20) NULL,
	[FECHA_REAL_LABORAL] [varchar](30) NULL,
	[FECHA_TIMBRADO] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[UUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALMACEN_XML](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](40) NULL,
	[Fecha_Emision] [date] NULL,
	[serie_factura] [varchar](20) NULL,
	[folio_factura] [varchar](50) NULL,
	[rfc_emisor] [varchar](13) NULL,
	[rsocial_emisor] [varchar](max) NULL,
	[rfc_receptor] [varchar](13) NULL,
	[rsocial_receptor] [varchar](max) NULL,
	[status] [varchar](20) NULL,
	[metodo_pago] [varchar](800) NULL,
	[tipo_documento] [varchar](11) NULL,
	[Nombre_Moneda] [text] NULL,
	[Tipo_Cambio] [money] NULL,
	[importe_Neto] [money] NULL,
	[importe_Descuento] [money] NULL,
	[Total] [money] NULL,
	[xml_adjunto] [text] NULL,
	[Lugar_Expedicion] [text] NULL,
	[Tipo_Venta] [varchar](11) NULL,
	[Tipo_Comprobante] [varchar](50) NULL,
	[cuenta_contable] [varchar](50) NULL,
	[DC] [varchar](2) NULL,
	[Numero_Empresa] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALMACEN_XML_DETALLE](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](50) NULL,
	[Prod_Codigo] [varchar](max) NULL,
	[Prod_Descripcion] [varchar](max) NULL,
	[Prod_Cantidad] [varchar](max) NULL,
	[Prod_Unidad] [varchar](max) NULL,
	[Prod_ValorUnitario] [money] NULL,
	[Prod_ValorTotal] [money] NULL,
	[Numero_Empresa] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATALOGO_CONCEPTOS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](255) NULL,
	[Clave_SAT] [nvarchar](4) NULL,
	[Tipo] [varchar](1) NULL,
	[Clave_Interna] [varchar](255) NULL,
	[Descipcion_Interna] [varchar](100) NULL,
	[Tipo_Interna] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMPLEMENTONOMINAS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](50) NULL,
	[RegistroPatronal] [varchar](20) NULL,
	[NumEmpleado] [varchar](20) NULL,
	[CURP] [varchar](20) NULL,
	[TipoRegimen] [varchar](5) NULL,
	[NumSeguridadSocial] [varchar](20) NULL,
	[FechaPago] [date] NULL,
	[NumDiasPagados] [varchar](4) NULL,
	[Departamento] [varchar](255) NULL,
	[FechaInicioRelLaboral] [date] NULL,
	[Antiguedad] [varchar](4) NULL,
	[Puesto] [varchar](255) NULL,
	[TipoContrato] [varchar](20) NULL,
	[TipoJornada] [varchar](20) NULL,
	[PeriodicidadPago] [varchar](20) NULL,
	[SalarioBaseCotApor] [money] NULL,
	[RiesgoPuesto] [int] NULL,
	[SalarioDiarioIntegrado] [money] NULL,
	[FechaInicialPago] [date] NULL,
	[FechaFinalPago] [date] NULL,
	[Numero_Empresa] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Concepto_Documento](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](50) NOT NULL,
	[cantidad] [varchar](255) NULL,
	[descripcion] [varchar](255) NULL,
	[valorUnitario] [money] NULL,
	[importe] [money] NULL,
	[unidad] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[UUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONCEPTOSNOMINA](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](50) NOT NULL,
	[ImporteExento] [money] NULL,
	[ImporteGravado] [money] NULL,
	[Concepto] [varchar](255) NULL,
	[ClaveInt] [varchar](4) NULL,
	[ClaveSAT] [varchar](4) NULL,
	[Tipo] [varchar](20) NULL,
	[Numero_Empresa] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConceptosUnidos](
	[ID] [int] NOT NULL,
	[UUID] [varchar](50) NOT NULL,
	[TipoPercepcion] [varchar](3) NULL,
	[TipoDeduccion] [varchar](3) NULL,
	[ClavePInterno] [varchar](3) NULL,
	[ClaveDInterno] [varchar](3) NULL,
	[ConceptoP] [varchar](255) NULL,
	[ConceptoD] [varchar](255) NULL,
	[Importe] [money] NULL,
	[ImporteGravado] [money] NULL,
	[ImporteExento] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[UUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Datos_Emisor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](50) NOT NULL,
	[nombre] [text] NULL,
	[rfc] [varchar](13) NOT NULL,
	[Curp] [varchar](20) NULL,
	[RfcPatronOrigen] [varchar](13) NULL,
	[Regimen] [varchar](255) NULL,
	[RegistroPatronal] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[UUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Datos_Receptor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](50) NOT NULL,
	[nombre] [text] NULL,
	[rfc] [varchar](13) NOT NULL,
	[Curp] [varchar](18) NOT NULL,
	[NumSeguridadSocial] [varchar](30) NULL,
	[FechaInicioRelLaboral] [date] NULL,
	[Antiguedad] [varchar](10) NULL,
	[TipoContrato] [varchar](10) NULL,
	[Sindicalizado] [varchar](3) NULL,
	[TipoJornada] [varchar](10) NULL,
	[TipoRegimen] [varchar](10) NULL,
	[NumEmpleado] [varchar](255) NULL,
	[Departamento] [varchar](255) NULL,
	[Puesto] [varchar](255) NULL,
	[RiesgoPuesto] [varchar](10) NULL,
	[PeriodicidadPago] [varchar](10) NULL,
	[Banco] [varchar](10) NULL,
	[CuentaBancaria] [varchar](20) NULL,
	[SalarioBaseCotApor] [money] NULL,
	[SalarioDiarioIntegrado] [money] NULL,
	[ClaveEntFed] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[UUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEDUCCIONES](
	[iddeducciones] [int] IDENTITY(1,1) NOT NULL,
	[periodo] [int] NOT NULL,
	[num_empleado] [int] NOT NULL,
	[nombre] [varchar](250) NULL,
	[clave_sat] [varchar](100) NULL,
	[clave_interna] [varchar](100) NULL,
	[concepto] [varchar](250) NULL,
	[importe_gravado] [int] NULL,
	[import_excento] [int] NULL
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doc_Detalles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ClaveProdServ] [varchar](50) NULL,
	[ClaveUnidad] [varchar](50) NULL,
	[NoIdentificacion] [varchar](50) NULL,
	[Cantidad] [varchar](50) NULL,
	[Unidad] [varchar](50) NULL,
	[Descripcion] [varchar](max) NULL,
	[ValorUnitario] [money] NULL,
	[Importe] [money] NULL,
	[TBase] [varchar](50) NULL,
	[TImpuesto] [varchar](50) NULL,
	[TTipoFactor] [varchar](50) NULL,
	[TTasaOCuota] [money] NULL,
	[TImporte] [money] NULL,
	[RBase] [varchar](50) NULL,
	[RImpuesto] [varchar](50) NULL,
	[RTipoFactor] [varchar](50) NULL,
	[RTasaOCuota] [money] NULL,
	[RImporte] [varchar](50) NULL,
	[InformacionAduanera_NumeroPedimento] [varchar](50) NULL,
	[UUID] [varchar](50) NULL,
	[NumeroCuentaPredial] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doc_Encabezados](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Vcfdi] [nvarchar](4) NULL,
	[Folio] [nvarchar](50) NULL,
	[Serie] [nvarchar](25) NULL,
	[Fecha] [date] NULL,
	[Emisor_RFC] [varchar](13) NULL,
	[Emisor_Nombre] [ntext] NULL,
	[RegimenFiscal] [varchar](50) NULL,
	[Receptor_Rfc] [varchar](50) NULL,
	[Receptor_Nombre] [ntext] NULL,
	[UsoCFDI] [varchar](50) NULL,
	[FormaPago] [varchar](50) NULL,
	[MetodoPago] [varchar](50) NULL,
	[CondicionesDePago] [varchar](50) NULL,
	[TipoDeComprobante] [varchar](10) NULL,
	[LugarExpedicion] [ntext] NULL,
	[Moneda] [varchar](50) NULL,
	[TipoCambio] [money] NULL,
	[SubTotal] [money] NULL,
	[Descuento] [money] NULL,
	[Total] [money] NULL,
	[TipoRelacion_CFDI] [varchar](50) NULL,
	[UUIDRelacion_CFDI] [varchar](50) NULL,
	[TotalImpuestosRetenidos] [money] NULL,
	[TotalImpuestosTrasladados] [money] NULL,
	[UUID] [varchar](50) NULL,
	[FechaTimbrado] [varchar](50) NULL,
	[NumEmpresa] [int] NULL,
	[TRetencionesLocales] [money] NULL,
	[TTrasladosLocales] [money] NULL,
	[ImpLocRetenido] [varchar](max) NULL,
	[TasadeRetencion] [decimal](18, 0) NULL,
	[ImporteRetencion] [money] NULL,
	[ImpLocTrasladado] [varchar](max) NULL,
	[TasadeTraslado] [decimal](18, 0) NULL,
	[Importe] [money] NULL,
	[Confirmacion] [varchar](50) NULL,
	[VigenciaSAT] [varchar](50) NULL,
	[MiDocumento] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLEADOS](
	[idempleado] [int] IDENTITY(1,1) NOT NULL,
	[NUM_EMPLEADO] [varchar](10) NULL,
	[NOMBRE] [varchar](250) NULL,
	[RFC] [varchar](13) NOT NULL,
	[MAIL] [varchar](50) NULL,
	[CURP] [varchar](50) NULL,
	[TIPO_REGIMEN] [varchar](50) NULL,
	[NUMERO_SS] [numeric](18, 0) NULL,
	[DEPARTAMENTO] [varchar](250) NULL,
	[CLABE_BANCARIA] [varchar](18) NULL,
	[BANCO] [varchar](4) NULL,
	[FECHA_INICIO_LABORAL] [date] NULL,
	[PUESTO] [varchar](250) NULL,
	[TIPO_CONTRATO] [varchar](50) NULL,
	[TIPO_JORNADA] [varchar](50) NULL,
	[PERIODICIDAD_PAGO] [varchar](50) NULL,
	[SBC] [varchar](50) NULL,
	[SDI] [varchar](255) NULL,
	[SINDICALIZADO] [varchar](2) NULL,
	[REGISTRO_PATRONAL] [varchar](20) NULL,
	[RIESGO_PUESTO] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idempleado] ASC,
	[RFC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[RFC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Encabezado_Importes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](50) NOT NULL,
	[serie] [varchar](80) NULL,
	[folio] [varchar](80) NULL,
	[fecha] [date] NULL,
	[tipoDeComprobante] [varchar](10) NULL,
	[formaDePago] [varchar](255) NULL,
	[metodoDePago] [varchar](100) NULL,
	[subTotal] [money] NULL,
	[descuento] [money] NULL,
	[Moneda] [varchar](30) NULL,
	[TipoCambio] [money] NULL,
	[total] [money] NULL,
	[LugarExpedicion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[UUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HEXTRASNOMINAS](
	[ID] [int] NOT NULL,
	[UUID] [varchar](50) NULL,
	[Dias] [varchar](5) NULL,
	[TipoHoras] [varchar](4) NULL,
	[HorasExtra] [varchar](4) NULL,
	[ImportePagado] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IMPUESTOS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](60) NULL,
	[Nombre_Impuesto] [varchar](50) NULL,
	[Tasa_Impuesto] [varchar](10) NULL,
	[Importe_Impuesto] [money] NULL,
	[Tipo_Impuesto] [varchar](50) NULL,
	[Etiqueta] [varchar](50) NULL,
	[Subtotal_Docto] [money] NULL,
	[Descto_Docto] [money] NULL,
	[Total_Docto] [money] NULL,
	[Numero_Empresa] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INCAPACIDADESNOMINAS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](50) NULL,
	[DiasIncapacidad] [int] NULL,
	[TipoIncapacidad] [varchar](4) NULL,
	[Descuento] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOGTIMBRADO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NUMEMPLEADO] [varchar](50) NULL,
	[RFC] [varchar](13) NULL,
	[FECHA_PAGO] [date] NULL,
	[OBSERVACIONES] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nom_Detalles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](50) NULL,
	[TipoPercepcion] [varchar](10) NULL,
	[Clave_P] [varchar](10) NULL,
	[Concepto_P] [varchar](50) NULL,
	[ImporteGravado_P] [money] NULL,
	[ImporteExento_P] [money] NULL,
	[ImporteExento_D] [money] NULL,
	[ImporteGravado_D] [money] NULL,
	[Concepto_D] [varchar](50) NULL,
	[Clave_D] [varchar](10) NULL,
	[TipoDeduccion] [varchar](10) NULL,
	[Importe] [money] NULL,
	[DiasIncapacidad] [int] NULL,
	[TipoIncapacidad] [int] NULL,
	[Descuento] [money] NULL,
	[Dias] [int] NULL,
	[TipoHoras] [varchar](50) NULL,
	[HorasExtra] [int] NULL,
	[ImportePagado] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nom_Generales](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Version] [varchar](10) NULL,
	[TipoNomina] [varchar](10) NULL,
	[FechaPago] [date] NULL,
	[FechaInicialPago] [date] NULL,
	[FechaFinalPago] [date] NULL,
	[NumDiasPagados] [decimal](18, 0) NULL,
	[TotalPercepciones] [money] NULL,
	[TotalDeducciones] [money] NULL,
	[TotalOtrosPagos] [money] NULL,
	[Curp] [varchar](20) NULL,
	[NumSeguridadSocial] [varchar](20) NULL,
	[FechaInicioRelLaboral] [date] NULL,
	[Antigüedad] [varchar](10) NULL,
	[TipoContrato] [varchar](50) NULL,
	[Sindicalizado] [varchar](10) NULL,
	[TipoJornada] [varchar](50) NULL,
	[TipoRegimen] [nvarchar](max) NULL,
	[NumEmpleado] [varchar](50) NULL,
	[Departamento] [varchar](max) NULL,
	[Puesto] [varchar](max) NULL,
	[RiesgoPuesto] [varchar](10) NULL,
	[PeriodicidadPago] [varchar](30) NULL,
	[CuentaBancaria] [varchar](50) NULL,
	[Banco] [varchar](10) NULL,
	[SalarioBaseCotApor] [money] NULL,
	[SalarioDiarioIntegrado] [money] NULL,
	[RegistroPatronal] [varchar](50) NULL,
	[UUID] [varchar](50) NULL,
	[PTotalGravado] [money] NULL,
	[PTotalExento] [money] NULL,
	[DTotalGravado] [money] NULL,
	[DTotalExento] [money] NULL,
	[SubsidioAlEmpleoCausado] [money] NULL,
	[TotalImpuestosRetenidos] [money] NULL,
	[TotalOtrasDeducciones] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos_Detalles](
	[id] [int] NOT NULL,
	[Confirmacion] [varchar](max) NULL,
	[IdDocumento] [varchar](max) NULL,
	[MonedaDR] [varchar](50) NULL,
	[MetodoDePagoDR] [smalldatetime] NULL,
	[NumParcialidad] [int] NULL,
	[ImpSaldoAnt] [money] NULL,
	[ImpPagado] [money] NULL,
	[ImpSaldoInsoluto] [money] NULL,
	[TipoCambioDR] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos_Generales](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Confirmacion] [varchar](max) NULL,
	[Version] [varchar](5) NULL,
	[FechaPago] [date] NULL,
	[FormaDePagoP] [varchar](max) NULL,
	[MonedaP] [varchar](max) NULL,
	[Monto] [money] NULL,
	[RfcEmisorCtaOrd] [varchar](50) NULL,
	[CtaOrdenante] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PARAMETROS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_EMPRESA] [varchar](255) NULL,
	[RFC] [varchar](13) NULL,
	[REGISTRO_PATRONAL] [varchar](20) NULL,
	[REGISTRO_NSS] [varchar](20) NULL,
	[REPRESENTANTE] [varchar](255) NULL,
	[CALLE] [varchar](200) NULL,
	[NUM_EXT] [varchar](10) NULL,
	[NUM_INT] [varchar](10) NULL,
	[CODIGO_POSTAL] [varchar](5) NULL,
	[MUNICIPIO] [varchar](255) NULL,
	[LOCALIDAD] [varchar](255) NULL,
	[ESTADO] [varchar](255) NULL,
	[PAIS] [varchar](255) NULL,
	[REGIMEN] [varchar](4) NULL,
	[RIESGO_PUESTO] [varchar](4) NULL,
	[CLAVE_CERTIFICADO] [varchar](255) NULL,
	[NUMERO_CERTIFICADO] [varchar](100) NULL,
	[FECHA_VENCIMIENTO_CERTIFICADO] [date] NULL,
	[RUTA_Cti] [varchar](255) NULL,
	[COD_CONCEPTO_Cti] [varchar](255) NULL,
	[FECHA_INICIO_CERTIFICADO] [date] NULL,
	[ORIGEN_RECURSOS] [varchar](3) NULL,
	[TIPO_NOMINA] [varchar](2) NULL,
	[ARCHIVO_CER] [varchar](255) NULL,
	[ARCHIVO_KEY] [varchar](255) NULL,
	[ASUNTO_CERTIFICADO] [varchar](255) NULL,
	[COLONIA] [varchar](100) NULL,
	[RUTA_ALMACEN_PDF] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERCEPCIONES](
	[idpercepciones] [int] IDENTITY(1,1) NOT NULL,
	[periodo] [int] NOT NULL,
	[num_empleado] [int] NOT NULL,
	[nombre] [varchar](250) NULL,
	[clave_sat] [varchar](100) NULL,
	[clave_interna] [varchar](100) NULL,
	[concepto] [varchar](250) NULL,
	[importe_gravado] [int] NULL,
	[import_excento] [int] NULL
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERIODOS](
	[id_periodo] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](250) NULL,
	[fecha_ini] [date] NULL,
	[fecha_fin] [date] NULL
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro_Patronales](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[RegistroPatronal] [nvarchar](50) NOT NULL,
	[Riesgo_Puesto] [int] NULL,
	[NumCertificadoSAT] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[RegistroPatronal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SMTP](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[NombreServidor] [varchar](50) NULL,
	[ServidorSMTP] [varchar](50) NULL,
	[PuertoSMTP] [varchar](50) NULL,
	[SeguridadSSL] [int] NULL,
	[ClaveSMTP] [varchar](255) NULL,
	[DominioCorreo] [nvarchar](50) NULL,
	[CorreoEnvio] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tabla_Complemento](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](50) NOT NULL,
	[Version] [varchar](5) NULL,
	[TipoNomina] [varchar](10) NULL,
	[FechaPago] [date] NULL,
	[FechaInicialPago] [date] NULL,
	[FechaFinalPago] [date] NULL,
	[NumDiasPagados] [varchar](10) NULL,
	[TotalPercepciones] [money] NULL,
	[TotalDeducciones] [money] NULL,
	[TotalOtrosPagos] [money] NULL
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLA_DEDUDCCIONES](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](50) NOT NULL,
	[TipoDeduccion] [varchar](10) NULL,
	[Clave] [varchar](10) NULL,
	[Concepto] [varchar](255) NULL,
	[Importe] [money] NULL
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLA_HEXTRAS](
	[ID] [int] NOT NULL,
	[UUID] [varchar](50) NOT NULL,
	[DIAS] [varchar](10) NULL,
	[TipoHoras] [varchar](10) NULL,
	[HorasExtra] [varchar](10) NULL,
	[ImportePagado] [money] NULL
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tabla_Incapacidades](
	[ID] [int] NOT NULL,
	[UUID] [varchar](50) NOT NULL,
	[DiasIncapacidad] [varchar](10) NULL,
	[TipoIncapacidad] [varchar](10) NULL,
	[ImporteMonetario] [money] NULL
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLA_PERCEPCIONES](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](50) NOT NULL,
	[TipoPercepcion] [varchar](10) NULL,
	[Clave] [varchar](10) NULL,
	[Concepto] [varchar](255) NULL,
	[ImporteGravado] [money] NULL,
	[ImporteExento] [money] NULL
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Total_Deducciones](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](50) NOT NULL,
	[TotalOtrasDeducciones] [money] NULL,
	[TotalImpuestosRetenidos] [money] NULL
) ON [PRIMARY]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Total_Percepciones](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](50) NOT NULL,
	[TotalSueldos] [money] NULL,
	[TotalSeparacionIndemnizacion] [money] NULL,
	[TotalJubilacionPensionRetiro] [money] NULL,
	[TotalGravado] [money] NULL,
	[TotalExento] [money] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [UUID]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [serie_factura]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [folio_factura]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [rfc_emisor]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [rsocial_emisor]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [rfc_receptor]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [rsocial_receptor]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [status]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [metodo_pago]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [tipo_documento]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [Nombre_Moneda]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT ((0.00)) FOR [Tipo_Cambio]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [importe_Neto]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [importe_Descuento]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [Total]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [xml_adjunto]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [Lugar_Expedicion]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [Tipo_Venta]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT ('FAC') FOR [Tipo_Comprobante]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT (NULL) FOR [cuenta_contable]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT ((0)) FOR [DC]
GO
ALTER TABLE [dbo].[ALMACEN_XML] ADD  DEFAULT ((0)) FOR [Numero_Empresa]
GO
ALTER TABLE [dbo].[ALMACEN_XML_DETALLE] ADD  DEFAULT (NULL) FOR [UUID]
GO
ALTER TABLE [dbo].[ALMACEN_XML_DETALLE] ADD  DEFAULT (NULL) FOR [Prod_Codigo]
GO
ALTER TABLE [dbo].[ALMACEN_XML_DETALLE] ADD  DEFAULT (NULL) FOR [Prod_Descripcion]
GO
ALTER TABLE [dbo].[ALMACEN_XML_DETALLE] ADD  DEFAULT (NULL) FOR [Prod_Cantidad]
GO
ALTER TABLE [dbo].[ALMACEN_XML_DETALLE] ADD  DEFAULT (NULL) FOR [Prod_Unidad]
GO
ALTER TABLE [dbo].[ALMACEN_XML_DETALLE] ADD  DEFAULT (NULL) FOR [Prod_ValorUnitario]
GO
ALTER TABLE [dbo].[ALMACEN_XML_DETALLE] ADD  DEFAULT (NULL) FOR [Prod_ValorTotal]
GO
ALTER TABLE [dbo].[ALMACEN_XML_DETALLE] ADD  DEFAULT ((0)) FOR [Numero_Empresa]
GO
ALTER TABLE [dbo].[ConceptosUnidos] ADD  DEFAULT ((0.00)) FOR [Importe]
GO
ALTER TABLE [dbo].[ConceptosUnidos] ADD  DEFAULT ((0.00)) FOR [ImporteGravado]
GO
ALTER TABLE [dbo].[ConceptosUnidos] ADD  DEFAULT ((0.00)) FOR [ImporteExento]
GO
ALTER TABLE [dbo].[Datos_Emisor] ADD  DEFAULT ('') FOR [Curp]
GO
ALTER TABLE [dbo].[Datos_Receptor] ADD  DEFAULT ((0)) FOR [Banco]
GO
ALTER TABLE [dbo].[Datos_Receptor] ADD  DEFAULT ((0)) FOR [CuentaBancaria]
GO
ALTER TABLE [dbo].[Datos_Receptor] ADD  DEFAULT ((0.00)) FOR [SalarioBaseCotApor]
GO
ALTER TABLE [dbo].[Datos_Receptor] ADD  DEFAULT ((0.00)) FOR [SalarioDiarioIntegrado]
GO
ALTER TABLE [dbo].[Doc_Encabezados] ADD  DEFAULT ((0.00)) FOR [SubTotal]
GO
ALTER TABLE [dbo].[Doc_Encabezados] ADD  DEFAULT ((0.00)) FOR [Descuento]
GO
ALTER TABLE [dbo].[Doc_Encabezados] ADD  DEFAULT ((0.00)) FOR [Total]
GO
ALTER TABLE [dbo].[Doc_Encabezados] ADD  DEFAULT ((0)) FOR [MiDocumento]
GO
ALTER TABLE [dbo].[EMPLEADOS] ADD  DEFAULT ('No') FOR [SINDICALIZADO]
GO
ALTER TABLE [dbo].[Encabezado_Importes] ADD  DEFAULT ((0.00)) FOR [subTotal]
GO
ALTER TABLE [dbo].[Encabezado_Importes] ADD  DEFAULT ((0.00)) FOR [descuento]
GO
ALTER TABLE [dbo].[Encabezado_Importes] ADD  DEFAULT ((0.00)) FOR [TipoCambio]
GO
ALTER TABLE [dbo].[Encabezado_Importes] ADD  DEFAULT ((0.00)) FOR [total]
GO
ALTER TABLE [dbo].[IMPUESTOS] ADD  DEFAULT ('') FOR [Tasa_Impuesto]
GO
ALTER TABLE [dbo].[IMPUESTOS] ADD  DEFAULT ((0.00)) FOR [Importe_Impuesto]
GO
ALTER TABLE [dbo].[IMPUESTOS] ADD  DEFAULT ((0)) FOR [Numero_Empresa]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [NOMBRE_EMPRESA]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [RFC]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [REGISTRO_PATRONAL]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [REGISTRO_NSS]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [REPRESENTANTE]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [CALLE]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [NUM_EXT]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [NUM_INT]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('00000') FOR [CODIGO_POSTAL]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [MUNICIPIO]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [LOCALIDAD]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [ESTADO]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('MXN') FOR [PAIS]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [REGIMEN]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [RIESGO_PUESTO]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [CLAVE_CERTIFICADO]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [NUMERO_CERTIFICADO]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('c:\CompacW\Empresas\Predeterminada') FOR [RUTA_Cti]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [COD_CONCEPTO_Cti]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [FECHA_INICIO_CERTIFICADO]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [ORIGEN_RECURSOS]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [TIPO_NOMINA]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [ARCHIVO_CER]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [ARCHIVO_KEY]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [ASUNTO_CERTIFICADO]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('') FOR [COLONIA]
GO
ALTER TABLE [dbo].[PARAMETROS] ADD  DEFAULT ('C:\NOMINASCFDI\') FOR [RUTA_ALMACEN_PDF]
GO
ALTER TABLE [dbo].[TABLA_DEDUDCCIONES] ADD  DEFAULT ((0.00)) FOR [Importe]
GO
ALTER TABLE [dbo].[TABLA_HEXTRAS] ADD  DEFAULT ((0.00)) FOR [ImportePagado]
GO
ALTER TABLE [dbo].[Tabla_Incapacidades] ADD  DEFAULT ((0.00)) FOR [ImporteMonetario]
GO
ALTER TABLE [dbo].[TABLA_PERCEPCIONES] ADD  DEFAULT ((0.00)) FOR [ImporteGravado]
GO
ALTER TABLE [dbo].[TABLA_PERCEPCIONES] ADD  DEFAULT ((0.00)) FOR [ImporteExento]
GO
ALTER TABLE [dbo].[Total_Deducciones] ADD  DEFAULT ((0.00)) FOR [TotalOtrasDeducciones]
GO
ALTER TABLE [dbo].[Total_Deducciones] ADD  DEFAULT ((0.00)) FOR [TotalImpuestosRetenidos]
GO
ALTER TABLE [dbo].[Total_Percepciones] ADD  DEFAULT ((0.00)) FOR [UUID]
GO
ALTER TABLE [dbo].[Total_Percepciones] ADD  DEFAULT ((0.00)) FOR [TotalSueldos]
GO
ALTER TABLE [dbo].[Total_Percepciones] ADD  DEFAULT ((0.00)) FOR [TotalSeparacionIndemnizacion]
GO
ALTER TABLE [dbo].[Total_Percepciones] ADD  DEFAULT ((0.00)) FOR [TotalJubilacionPensionRetiro]
GO
ALTER TABLE [dbo].[Total_Percepciones] ADD  DEFAULT ((0.00)) FOR [TotalGravado]
GO
ALTER TABLE [dbo].[Total_Percepciones] ADD  DEFAULT ((0.00)) FOR [TotalExento]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo de Documento, si es nomina o factura' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ALMACEN_XML', @level2type=N'COLUMN',@level2name=N'Tipo_Comprobante'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Documento Contabilizado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ALMACEN_XML', @level2type=N'COLUMN',@level2name=N'DC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SE UTILIZA COMO IDENTIFICADOR DE EMPRESA' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ALMACEN_XML', @level2type=N'COLUMN',@level2name=N'Numero_Empresa'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SI ES PERCEPCION O DEDUCCION' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CONCEPTOSNOMINA', @level2type=N'COLUMN',@level2name=N'Tipo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Forma de Etiquetal al Impuesto para Llamarlo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IMPUESTOS', @level2type=N'COLUMN',@level2name=N'Etiqueta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Subtotal del Documento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IMPUESTOS', @level2type=N'COLUMN',@level2name=N'Subtotal_Docto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Total de Descuento del Documento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IMPUESTOS', @level2type=N'COLUMN',@level2name=N'Descto_Docto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Total del Documento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IMPUESTOS', @level2type=N'COLUMN',@level2name=N'Total_Docto'
GO";
                #endregion

                if (queryInsertEmpr.ExecuteNonQuery().Equals(1))
                {
                    if (!queryCreaBD.ExecuteNonQuery().Equals(1))
                    {
                        N.Conexion.PerformConnection().ChangeDatabase(newNameDB);
                        if (CreaTablas().Equals(true))
                        {
                            MessageBox.Show("¡Empresa Agregada con Éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }


                N.Conexion.PerformConnection().ChangeDatabase(BD);
                splashScreenManager.CloseWaitForm();
            }
            catch (Exception e)
            {
                splashScreenManager.CloseWaitForm();
                MessageBox.Show(e.Message + "\nError Controlador:CrearBDEmpresa()" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("¡Información Actualizada Con Éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    splashScreenManager.CloseWaitForm();
                    MessageBox.Show("¡Error Al  Actualizar La Información!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception e)
            {
                splashScreenManager.CloseWaitForm();
                MessageBox.Show(e.Message + "\nError Controlador: EditarEMpleado()", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            Process proceso = new Process();
                            proceso.StartInfo.FileName = path;
                            proceso.Start();
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
               
                MessageBox.Show(e.Message + "\nError Controlador: AgregaEmpleadoMasivo()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        MessageBox.Show("Por favor, seleccione una celda", "Error");
                        return false;
                    }
                    else
                    {
                        splashScreenManager.ShowWaitForm();
                        //MessageBox.Show(list.Count().ToString());
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
                                    splashScreenManager.CloseWaitForm();
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