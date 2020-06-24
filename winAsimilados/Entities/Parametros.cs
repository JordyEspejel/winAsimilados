using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class Parametros
    {
        private string _NombreEmpresa;
        public string NombreEmpresa
        {
            get { return _NombreEmpresa; }
            set { _NombreEmpresa = value; }
        }
        private string _RFC;
        public string RFC
        {
            get { return _RFC; }
            set { _RFC = value; }
        }
        private string _RegistroPatronal;
        public string RegistroPatronal
        {
            get { return _RegistroPatronal; }
            set { _RegistroPatronal = value; }
        }
        private string _NSS;
        public string NSS
        {
            get { return _NSS; }
            set { _NSS = value; }
        }
        private string _Representante;
        public string Representante
        {
            get { return _Representante; }
            set { _Representante = value; }
        }
        private string _Calle;
        public string Calle
        {
            get { return _Calle; }
            set { _Calle = value; }
        }
        private string _NUM_EXT;
        private string _NUM_INT;
        private string _CODIGO_POSTAL;
        private string _MUNICIPIO;
        private string _LOCALIDAD;
        private string _ESTADO;
        private string _PAIS;
        private string _REGIMEN;
        private string _RIESGO_PUESTO;
        private string _CLAVE_CERTIFICADO;
        private string _NUMERO_CERTIFICADO;
        private DateTime _FECHA_VENCIMIENTO_CERTIFICADO;
        private string _RUTA_Cti;
        private string _COD_CONCEPTO_Cti;
        private DateTime _FECHA_INICIO_CERTIFICADO;
        private string _ORIGEN_RECURSOS;
        private string _TIPO_NOMINA;
        private string _ARCHIVO_CER;
        private string _ARCHIVO_KEY;
        private string _ASUNTO_CERTIFICADO;
        private string _COLONIA;
        private string _RUTA_ALMACEN_PDF;

        public string NUM_EXT
        {
            get { return _NUM_EXT; }
            set { _NUM_EXT = value; }
        }
        public string NUM_INT
        {
            get { return _NUM_INT; }
            set { _NUM_INT = value; }
        }
        public string CODIGO_POSTAL
        {
            get { return _CODIGO_POSTAL; }
            set { _CODIGO_POSTAL = value; }
        }
        public string MUNICIPIO
        {
            get { return _MUNICIPIO; }
            set { _MUNICIPIO = value; }
        }
        public string LOCALIDAD
        {
            get { return _LOCALIDAD; }
            set { _LOCALIDAD = value; }
        }
        public string ESTADO
        {
            get { return _ESTADO; }
            set { _ESTADO = value; }
        }
        public string PAIS
        {
            get { return _PAIS; }
            set { _PAIS = value; }
        }
        public string REGIMEN
        {
            get { return _REGIMEN; }
            set { _REGIMEN = value; }
        }
        public string RIESGO_PUESTO
        {
            get { return _RIESGO_PUESTO; }
            set { _RIESGO_PUESTO = value; }
        }
        public string CLAVE_CERTIFICADO
        {
            get { return _CLAVE_CERTIFICADO; }
            set { _CLAVE_CERTIFICADO = value; }
        }
        public string NUMERO_CERTIFICADO
        {
            get { return _NUMERO_CERTIFICADO; }
            set { _NUMERO_CERTIFICADO = value; }
        }
        public DateTime FECHA_VENCIMIENTO_CERTIFICADO
        {
            get { return _FECHA_VENCIMIENTO_CERTIFICADO; }
            set { _FECHA_VENCIMIENTO_CERTIFICADO = value; }
        }
        public string RUTA_Cti
        {
            get { return _RUTA_Cti; }
            set { _RUTA_Cti = value; }
        }
        public string COD_CONCEPTO_Cti
        {
            get { return _COD_CONCEPTO_Cti; }
            set { _COD_CONCEPTO_Cti = value; }
        }
        public DateTime FECHA_INICIO_CERTIFICADO
        {
            get { return _FECHA_INICIO_CERTIFICADO; }
            set { _FECHA_INICIO_CERTIFICADO = value; }
        }
        public string ORIGEN_RECURSOS
        {
            get { return _ORIGEN_RECURSOS; }
            set { _ORIGEN_RECURSOS = value; }
        }
        public string TIPO_NOMINA
        {
            get { return _TIPO_NOMINA; }
            set { _TIPO_NOMINA = value; }
        }
        public string ARCHIVO_CER
        {
            get { return _ARCHIVO_CER; }
            set { _ARCHIVO_CER = value; }
        }
        public string ARCHIVO_KEY
        {
            get { return _ARCHIVO_KEY; }
            set { _ARCHIVO_KEY = value; }
        }
        public string ASUNTO_CERTIFICADO
        {
            get { return _ASUNTO_CERTIFICADO; }
            set { _ASUNTO_CERTIFICADO = value; }
        }
        public string COLONIA
        {
            get { return _COLONIA; }
            set { _COLONIA = value; }
        }
        public string RUTA_ALMACEN_PDF
        {
            get { return _RUTA_ALMACEN_PDF; }
            set { _RUTA_ALMACEN_PDF = value; }
        }

        private string _DescripcionRegimen;
        public string DescripcionRegimen
        {
            get { return _DescripcionRegimen; }
            set { _DescripcionRegimen = value; }
        }
        private string _DescripcionRecursos;
        public string DescripcionRecursos
        {
            get { return _DescripcionRecursos; }
            set { _DescripcionRecursos = value; }
        }
        private string _DescripcionPuesto;
        public string DescripcionPuesto
        {
            get { return _DescripcionPuesto; }
            set { _DescripcionPuesto = value; }
        }
        private string _DescripcionNomina;
        public string DescripcionNomina
        {
            get { return _DescripcionNomina; }
            set { _DescripcionNomina = value; }
        }

        private string _cuentaOrigen;
        public string cuentaOrigen
        {
            get { return _cuentaOrigen; }
            set { _cuentaOrigen = value; }
        }
    }
}
