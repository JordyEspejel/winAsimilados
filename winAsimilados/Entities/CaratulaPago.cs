using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class CaratulaPago
    {
        private string _ID;
        private string _Caratula;
        private string _Layout;
        private string _IDCliente;
        private string _Cliente;
        private string _IDEmpresa;
        private string _Empresa;
        private DateTime _FechaCreacion;
        private DateTime _FechaAplicacion;
        private DateTime _FechaIniPeriodo;
        private DateTime _FechaFinPeriodo;
        private int _TotalEmpleados;
        private decimal _TotalPagoAsimilados;
        private string _Estatus;
        private string _usuario;
        private string _TipoPeri;
        private decimal _AsimiSalarios;
        private decimal _ProvAguinaldo;
        private decimal _ProviVacaciones;
        private decimal _ProviPrimVacacional;
        private decimal _SubTotalIAS;
        private decimal _ComisionServicio;
        private decimal _ImpNomi;
        private decimal _Total;
        private decimal _IVA;
        private decimal _RetencionIVA;
        private decimal _TotalFactura;
        private string _Ajuste;
        private string _TotalDeposito;
        private string _Banco;
        private string _NumCuenta;
        private string _CLABE;
        private string _ClaveFacturacion;
        private string _TipoPago;
        private string _FormaPago;
        private string _Observaciones;

        public string ID{ get { return _ID; } set { _ID = value;} }
        public string Caratula{ get { return _Caratula; } set { _Caratula = value; } }
        public string Layout{ get { return _Layout; } set { _Layout = value; } }
        public string IDCliente{ get { return _IDCliente; } set { _IDCliente = value; } }
        public string Cliente{ get { return _Cliente; } set { _Cliente = value; } }
        public string IDEmpresa{ get { return _IDEmpresa; } set { _IDEmpresa = value; } }
        public string Empresa{ get { return _Empresa; } set { _Empresa = value; } }
        public DateTime FechaCreacion{ get { return _FechaCreacion; } set { _FechaCreacion = value; } }
        public DateTime FechaAplicacion{ get { return _FechaAplicacion; } set { _FechaAplicacion = value; } }
        public DateTime FechaIniPeriodo{ get { return _FechaIniPeriodo; } set { _FechaIniPeriodo = value; } }
        public DateTime FechaFinPeriodo{ get { return _FechaFinPeriodo; } set { _FechaFinPeriodo = value; } }
        public int TotalEmpleados{ get { return _TotalEmpleados; } set { _TotalEmpleados = value; } }
        public decimal TotalPagoAsimilados{ get { return _TotalPagoAsimilados; } set { _TotalPagoAsimilados = value; } }
        public string Estatus{ get { return _Estatus; } set { _Estatus = value; } }
        public string usuario{ get { return _usuario; } set { _usuario = value; } }
        public string TipoPeri{ get { return _TipoPeri; } set { _TipoPeri = value; } }
        public decimal AsimiSalarios{ get { return _AsimiSalarios; } set { _AsimiSalarios = value; } }
        public decimal ProvAguinaldo{ get { return _ProvAguinaldo; } set { _ProvAguinaldo = value; } }
        public decimal ProviVacaciones{ get { return _ProviVacaciones; } set { _ProviVacaciones = value; } }
        public decimal ProviPrimVacacional{ get { return _ProviPrimVacacional; } set { _ProviPrimVacacional = value; } }
        public decimal SubTotalIAS{ get { return _SubTotalIAS; } set { _SubTotalIAS = value; } }
        public decimal ComisionServicio{ get { return _ComisionServicio; } set { _ComisionServicio = value; } }
        public decimal ImpNomi{ get { return _ImpNomi; } set { _ImpNomi = value; } }
        public decimal Total{ get { return _Total; } set { _Total = value; } }
        public decimal IVA{ get { return _IVA; } set { _IVA = value; } }
        public decimal RetencionIVA{ get { return _RetencionIVA; } set { _RetencionIVA = value; } }
        public decimal TotalFactura{ get { return _TotalFactura; } set { _TotalFactura = value; } }
        public string Ajuste{ get { return _Ajuste; } set { _Ajuste = value; } }
        public string TotalDeposito{ get { return _TotalDeposito; } set { _TotalDeposito = value; } }
        public string Banco{ get { return _Banco; } set { _Banco = value; } }
        public string NumCuenta{ get { return _NumCuenta; } set { _NumCuenta = value; } }
        public string CLABE{ get { return _CLABE; } set { _CLABE = value; } }
        public string ClaveFacturacion{ get { return _ClaveFacturacion; } set { _ClaveFacturacion = value; } }
        public string TipoPago{ get { return _TipoPago; } set { _TipoPago = value; } }
        public string FormaPago{ get { return _FormaPago; } set { _FormaPago = value; } }
        public string Observaciones{ get { return _Observaciones; } set { _Observaciones = value; } }
    }
}
