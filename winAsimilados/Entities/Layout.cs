using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace winAsimilados.Entities
{
    class Layout
    {
        private string _ID;
        private int _numEmpl;
        private string _nombreEmpleado;
        private string _RFCEmpleado;
        private string _CURPEmpleado;
        private string _PeriPago;
        private decimal _ingresos;
        private decimal _LimInferior;
        private decimal _ExLimInf;
        private decimal _PerExLimInf;
        private decimal _ImpMarg;
        private decimal _CF;
        private decimal _ISR;
        private decimal _ingresosNet;
        private string _operacion;
        private string _claveID;
        private string _cuentaOrigen;
        private string _cuenta_ClaveDestino;
        private decimal _importe;
        private string _referencia;
        private string _descripcion;
        private string _RFCOrdenante;
        private decimal _IVA;
        private DateTime _fechaAplicacion;
        private DateTime _fecIniPeri;
        private DateTime _fecFinPeri;
        private string _institucionPago;
        private string _claveTipoCambio;
        private DateTime _fechaCreacion;
        private string _estatus;
        private string _bancoEmpleado;
        private decimal _Sub;
        private string _caratula;
        private string _IDEmpresa;
        private string _periodo;
        private string _IDCliente;
        private string _layout;
        private string _tipoPago;
        private decimal _otrosConceptos;
        private decimal _depositoNeto;
        private string _cuentaBancaria;
        private string _CLABE;
        private string _bancoEmpresaPago;


        public string ID { get { return _ID; } set { _ID = value; } }
        public int numEmpl { get { return _numEmpl; } set { _numEmpl = value; } }
        public string nombreEmpleado { get { return _nombreEmpleado; } set { _nombreEmpleado = value; } }
        public string RFCEmpleado { get { return _RFCEmpleado; } set { _RFCEmpleado = value; } }
        public string CURPEmpleado { get { return _CURPEmpleado; } set { _CURPEmpleado = value; } }
        public decimal ingresos { get { return _ingresos; } set { _ingresos = value; } }

        public string periPago { get { return _PeriPago; } set { _PeriPago = value; } }

        public string bancoEmpresaPago { get { return _bancoEmpresaPago; }  set { _bancoEmpresaPago = value; } }

        public decimal LimInferior
        {
            get { return _LimInferior; }
            set { _LimInferior = value; }
        }

        public decimal ExLimInf
        {
            get { return _ExLimInf; }
            set { _ExLimInf = value; }
        }

        public decimal PerExLimInf
        {
            get { return _PerExLimInf; }
            set { _PerExLimInf = value; }
        }

        public decimal ImpMarg
        {
            get { return _ImpMarg; }
            set { _ImpMarg = value; }
        }

        public decimal CF
        {
            get { return _CF; }
            set { _CF = value; }
        }
        public decimal ISR
        {
            get { return _ISR; }
            set { _ISR = value; }
        }

        public decimal Sub
        {
            get { return _Sub; }
            set { _Sub = value; }
        }
        public decimal ingresosNet { get { return _ingresosNet; } set { _ingresosNet = value; } }
        public string operacion { get { return _operacion; } set { _operacion = value; } }
        public string claveID { get { return _claveID; } set { _claveID = value; } }
        public string cuentaOrigen { get { return _cuentaOrigen; } set { _cuentaOrigen = value; } }
        public string cuentaClaveDestino { get { return _cuenta_ClaveDestino; } set { _cuenta_ClaveDestino = value; } }
        public decimal importe { get { return _importe; } set { _importe = value; } }
        public string referencia { get { return _referencia; } set { _referencia = value; } }
        public string descripcion { get { return _descripcion; } set { _descripcion = value; } }
        public string RFCOrdenante { get { return _RFCOrdenante; } set { _RFCOrdenante = value; } }
        public decimal IVA { get { return _IVA; } set { _IVA = value; } }
        public DateTime fechaAplicacion { get { return _fechaAplicacion; } set { _fechaAplicacion = value; } }
        public DateTime fecIniPeri { get { return _fecIniPeri; } set { _fecIniPeri = value; } }
        public DateTime fecFinPeri { get { return _fecFinPeri; } set { _fecFinPeri = value; } }
        public string institucionPago { get { return _institucionPago; } set { _institucionPago = value; } }
        public string claveTipoCambio { get { return _claveTipoCambio; } set { _claveTipoCambio = value; } }
        public DateTime fechaCreacion { get { return _fechaCreacion; } set { _fechaCreacion = value; } }
        public string estatus { get { return _estatus; } set { _estatus = value; } }

        public string bancoEmpleado { get { return _bancoEmpleado; } set { _bancoEmpleado = value; } }

        public string caratula { get { return _caratula; } set { _caratula = value; } }

        public string IDEmpresa { get { return _IDEmpresa; } set { _IDEmpresa = value; } }
        public string IDCliente { get { return _IDCliente; } set { _IDCliente = value; } }

        public string periodo { get { return _periodo; } set { _periodo = value; } }

        public string layout { get { return _layout; } set { _layout = value; } }

        public string tipoPago { get { return _tipoPago; } set { _tipoPago = value; } }

        public decimal otrosConceptos{ get { return _otrosConceptos; } set { _otrosConceptos = value; } }
        public decimal depositoNeto{ get { return _depositoNeto; } set { _depositoNeto = value; } }
        public string cuentaBancaria{ get { return _cuentaBancaria; } set { _cuentaBancaria = value; } }
        public string CLABE{ get { return _CLABE; } set { _CLABE = value; } }

    }
}