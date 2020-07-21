using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class Empleado
    {
        private int _IDEmpleado;
        public int IDEmpleado
        {
            get { return _IDEmpleado; }
            set { _IDEmpleado = value; }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _NumEmpl;
        public string NumEmpl
        {
            get { return _NumEmpl; }
            set { _NumEmpl = value; }
        }

        private string _RFC;
        public string RFC
        {
            get { return _RFC; }
            set { _RFC = value; }
        }

        private string _CURP;
        public string CURP
        {
            get { return _CURP; }
            set { _CURP = value; }
        }
        private string _Periodicidad;
        public string Periodicidad
        {
            get { return _Periodicidad; }
            set { _Periodicidad = value; }
        }
        private string _TipoRegimen;
        public string TipoRegimen
        {
            get { return _TipoRegimen; }
            set { _TipoRegimen = value; }
        }

        private string _TipoContrato;
        public string TipoContrato
        {
            get { return _TipoContrato; }
            set { _TipoContrato = value; }
        }
        private string _Sindicalizado;
        public string Sindicalizado
        {
            get { return _Sindicalizado; }
            set { _Sindicalizado = value; }
        }
        private string _Departamento;
        public string Departamento
        {
            get { return _Departamento; }
            set { _Departamento = value; }
        }
        private string _Puesto;
        public string Puesto
        {
            get { return _Puesto; }
            set { _Puesto = value; }
        }

        private decimal _IngresosBrutos;
        public decimal IngresosBrutos
        {
            get { return _IngresosBrutos; }
            set { _IngresosBrutos = value; }
        }
        private decimal _LimInferior;
        public decimal LimInferior
        {
            get { return _LimInferior; }
            set { _LimInferior = value; }
        }
        private decimal _ExLimInf;
        public decimal ExLimInf
        {
            get { return _ExLimInf; }
            set { _ExLimInf = value; }
        }
        private decimal _PerExLimInf;
        public decimal PerExLimInf
        {
            get { return _PerExLimInf; }
            set { _PerExLimInf = value; }
        }
        private decimal _ImpMarg;
        public decimal ImpMarg
        {
            get { return _ImpMarg; }
            set { _ImpMarg = value; }
        }
        private decimal _CF;
        public decimal CF
        {
            get { return _CF; }
            set { _CF = value; }
        }

        private decimal _Sub;
        public decimal Sub
        {
            get { return _Sub; }
            set { _Sub = value; }
        }

        private decimal _ISR;
        public decimal ISR
        {
            get { return _ISR; }
            set { _ISR = value; }
        }
        private decimal _IngresosNetos;
        public decimal IngresosNetos
        {
            get { return _IngresosNetos; }
            set { _IngresosNetos = value; }
        }
        private string _CUENTA;
        public string cuenta
        {
            get { return _CUENTA; }
            set { _CUENTA = value; }
        }
        private string _CLABE_BANCARIA;
        public string clabe_bancaria
        {
            get { return _CLABE_BANCARIA; }
            set { _CLABE_BANCARIA = value; }
        }
        private string _CVE_BANCO;
        public string cve_banco
        {
            get { return _CVE_BANCO; }
            set { _CVE_BANCO = value; }
        }
        private string _BANCO;
        public string banco
        {
            get { return _BANCO; }
            set { _BANCO = value; }
        }

        private string _empresa;
        public string empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }

        private string _idEmpresa;
        public string idEmpresa
        {
            get { return _idEmpresa; }
            set { _idEmpresa = value; }
        }

        private string _tipoPago;

        public string tipoPago
        {
            get { return _tipoPago; }
            set { _tipoPago = value; }
        }

        private decimal _descuento;
        public decimal descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }

        private DateTime _fechaAplicacion;
        private DateTime _fecIniPeri;
        private DateTime _fecFinPeri;
        public DateTime fechaAplicacion { get { return _fechaAplicacion; } set { _fechaAplicacion = value; } }
        public DateTime fecIniPeri { get { return _fecIniPeri; } set { _fecIniPeri = value; } }
        public DateTime fecFinPeri { get { return _fecFinPeri; } set { _fecFinPeri = value; } }
    }
}

