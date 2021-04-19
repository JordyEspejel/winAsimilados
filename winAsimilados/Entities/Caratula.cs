using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace winAsimilados.Entities
{
    class Caratula
    {
        private string _ID;
        private string _caratula;
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
        private decimal _Ajuste;
        private decimal _TotalDeposito;
        private string _Banco;
        private string _NumCuenta;
        private string _CLABE;
        private string _ClaveFacturacion;
        private string _TipoPago;
        private string _FormaPago;
        private string _Observaciones;
        private string _RutaLogo;
        private string _Imagen;
        private DateTime _FechaValidaPago;
        private string _UsuarioPago;
        private DateTime _FechaModificacion;
        private string _UsuarioModificacion;
        private DateTime _FechaReaperturaPeriodo;
        private string _UsuarioReapertura;
        private decimal _descuentos;
        private decimal _PorcentajeISN;
        private decimal _PorcentajeComision;
        private decimal _PorcentajeIVA;
        private decimal _PorcentajeRetencion;

        public string ID { get { return _ID; } set { _ID = value; } }
        public string caratula { get { return _caratula; } set { _caratula = value; } }
        public string Layout { get { return _Layout; } set { _Layout = value; } }
        public string IDCliente { get { return _IDCliente; } set { _IDCliente = value; } }
        public string Cliente { get { return _Cliente; } set { _Cliente = value; } }
        public string IDEmpresa { get { return _IDEmpresa; } set { _IDEmpresa = value; } }
        public string Empresa { get { return _Empresa; } set { _Empresa = value; } }
        public DateTime FechaCreacion { get { return _FechaCreacion; } set { _FechaCreacion = value; } }
        public DateTime FechaAplicacion { get { return _FechaAplicacion; } set { _FechaAplicacion = value; } }
        public DateTime FechaIniPeriodo { get { return _FechaIniPeriodo; } set { _FechaIniPeriodo = value; } }
        public DateTime FechaFinPeriodo { get { return _FechaFinPeriodo; } set { _FechaFinPeriodo = value; } }
        public int TotalEmpleados { get { return _TotalEmpleados; } set { _TotalEmpleados = value; } }
        public decimal TotalPagoAsimilados { get { return _TotalPagoAsimilados; } set { _TotalPagoAsimilados = value; } }
        public string Estatus { get { return _Estatus; } set { _Estatus = value; } }
        public string usuario { get { return _usuario; } set { _usuario = value; } }
        public string TipoPeri { get { return _TipoPeri; } set { _TipoPeri = value; } }
        public decimal AsimiSalarios { get { return _AsimiSalarios; } set { _AsimiSalarios = value; } }
        public decimal ProvAguinaldo { get { return _ProvAguinaldo; } set { _ProvAguinaldo = value; } }
        public decimal ProviVacaciones { get { return _ProviVacaciones; } set { _ProviVacaciones = value; } }
        public decimal ProviPrimVacacional { get { return _ProviPrimVacacional; } set { _ProviPrimVacacional = value; } }
        public decimal SubTotalIAS { get { return _SubTotalIAS; } set { _SubTotalIAS = value; } }
        public decimal ComisionServicio { get { return _ComisionServicio; } set { _ComisionServicio = value; } }
        public decimal ImpNomi { get { return _ImpNomi; } set { _ImpNomi = value; } }
        public decimal Total { get { return _Total; } set { _Total = value; } }
        public decimal IVA { get { return _IVA; } set { _IVA = value; } }
        public decimal RetencionIVA { get { return _RetencionIVA; } set { _RetencionIVA = value; } }
        public decimal TotalFactura { get { return _TotalFactura; } set { _TotalFactura = value; } }
        public decimal Ajuste { get { return _Ajuste; } set { _Ajuste = value; } }
        public decimal TotalDeposito { get { return _TotalDeposito; } set { _TotalDeposito = value; } }
        public string Banco { get { return _Banco; } set { _Banco = value; } }
        public string NumCuenta { get { return _NumCuenta; } set { _NumCuenta = value; } }
        public string CLABE { get { return _CLABE; } set { _CLABE = value; } }
        public string ClaveFacturacion { get { return _ClaveFacturacion; } set { _ClaveFacturacion = value; } }
        public string TipoPago { get { return _TipoPago; } set { _TipoPago = value; } }
        public string FormaPago { get { return _FormaPago; } set { _FormaPago = value; } }
        public string Observaciones { get { return _Observaciones; } set { _Observaciones = value; } }

        public string RutaLogo { get { return _RutaLogo; } set { _RutaLogo = value; } }

        public string Imagen { get { return _Imagen; } set { _Imagen = value; } }

        public DateTime FechaValidaPago { get { return _FechaValidaPago; } set { _FechaValidaPago = value; } }
        public string UsuarioPago { get { return _UsuarioPago; } set { _UsuarioPago = value; } }
        public DateTime FechaModificacion { get { return _FechaModificacion; } set { _FechaModificacion = value; } }
        public string UsuarioModificacion { get { return _UsuarioModificacion; } set { _UsuarioModificacion = value; } }
        public decimal descuentos { get { return _descuentos; } set { _descuentos = value; } }
        public decimal PorcentajeISN { get { return _PorcentajeISN; } set { _PorcentajeISN = value; } }
        public decimal PorcentajeComision { get { return _PorcentajeComision; } set { _PorcentajeComision = value; } }
        public decimal PorcentajeIVA { get { return _PorcentajeIVA; } set { _PorcentajeIVA = value; } }
        public decimal PorcentajeRetencion { get { return _PorcentajeRetencion; } set { _PorcentajeRetencion = value; } }


        public DateTime FechaReaperturaPeriodo { get { return _FechaReaperturaPeriodo; } set { _FechaReaperturaPeriodo = value; } }
        public string UsuarioReapertura { get { return _UsuarioReapertura; } set { _UsuarioReapertura = value; } }
        private string _nominaEmpresaID;
        public string nominaEmpresaID
        {
            get { return _nominaEmpresaID; }
            set { _nominaEmpresaID = value; }
        }
    }
}
