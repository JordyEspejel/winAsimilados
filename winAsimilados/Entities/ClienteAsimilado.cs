using DevExpress.Utils.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class ClienteAsimilado
    {
        private string _ID;
        private string _CLIENTE;
        private DateTime _FECHA_ALTA_PRIMER_PAGO;
        private DateTime _FECHA_BAJA;
        private string _COMISIONISTA;
        private decimal _PORCENTAJE_ISN;
        private decimal _PORCENTAJE_COMISION;
        private decimal _TOTAL;
        private string _FACTURACION_CON_IVA_SIN_IVA;
        private string _RETENCION;
        private string _PERIODO_DE_PAGO;
        private string _ESTATUS;
        private string _EJECUTIVO_RESPONSABLE;
        private string _EMPRESA_PAGADORA_EMITE_CFDI;
        private string _PROVEEDOR;
        private string _EMPRESA_QUE_FACTUR_A_CLIENTE;
        private string _EMPRESA_QUE_FACTURA_A_CLIENTE1;
        private string _EMPRESA_QUE_FACTURA_A_CLIENTE2;
        private string _EMPRESA_QUE_FACTURA_A_CLIENTE3;
        private string _Metodo_Pago;
        private string _Observaciones;
        private string _Forma_Pago;
        private decimal _PORCENTAJE_RETENCION;

        public string ID{ get { return _ID; } set { _ID = value; } }
        public string CLIENTE{ get { return _CLIENTE; } set { _CLIENTE = value; } }
        public DateTime FECHA_ALTA_PRIMER_PAGO { get { return _FECHA_ALTA_PRIMER_PAGO; } set { _FECHA_ALTA_PRIMER_PAGO = value; } }
        public DateTime FECHA_BAJA { get { return _FECHA_BAJA; } set { _FECHA_BAJA = value; } }
        public string COMISIONISTA{ get { return _COMISIONISTA; } set { _COMISIONISTA = value; } }
        public decimal PORCENTAJE_ISN{ get { return _PORCENTAJE_ISN; } set { _PORCENTAJE_ISN = value; } }
        public decimal PORCENTAJE_COMISION { get { return _PORCENTAJE_COMISION; } set { _PORCENTAJE_COMISION = value; } }
        public decimal TOTAL { get { return _TOTAL; } set { _TOTAL = value; } }
        public string FACTURACION_CON_IVA_SIN_IVA{ get { return _FACTURACION_CON_IVA_SIN_IVA; } set { _FACTURACION_CON_IVA_SIN_IVA = value; } }
        public string RETENCION{ get { return _RETENCION; } set { _RETENCION = value; } }
        public string PERIODO_DE_PAGO{ get { return _PERIODO_DE_PAGO; } set { _PERIODO_DE_PAGO = value; } }
        public string ESTATUS{ get { return _ESTATUS; } set { _ESTATUS = value; } }
        public string EJECUTIVO_RESPONSABLE{ get { return _EJECUTIVO_RESPONSABLE; } set { _EJECUTIVO_RESPONSABLE = value; } }
        public string EMPRESA_PAGADORA_EMITE_CFDI{ get { return _EMPRESA_PAGADORA_EMITE_CFDI; } set { _EMPRESA_PAGADORA_EMITE_CFDI = value; } }
        public string PROVEEDOR{ get { return _PROVEEDOR; } set { _PROVEEDOR = value; } }
        public string EMPRESA_QUE_FACTUR_A_CLIENTE{ get { return _EMPRESA_QUE_FACTUR_A_CLIENTE; } set { _EMPRESA_QUE_FACTUR_A_CLIENTE = value; } }
        public string EMPRESA_QUE_FACTURA_A_CLIENTE1{ get { return _EMPRESA_QUE_FACTURA_A_CLIENTE1; } set { _EMPRESA_QUE_FACTURA_A_CLIENTE1 = value; } }
        public string EMPRESA_QUE_FACTURA_A_CLIENTE2{ get { return _EMPRESA_QUE_FACTURA_A_CLIENTE2; } set { _EMPRESA_QUE_FACTURA_A_CLIENTE2 = value; } }
        public string EMPRESA_QUE_FACTURA_A_CLIENTE3{ get { return _EMPRESA_QUE_FACTURA_A_CLIENTE3; } set { _EMPRESA_QUE_FACTURA_A_CLIENTE3 = value; } }
        public string Metodo_Pago { get { return _Metodo_Pago; } set { _Metodo_Pago = value; } }
        public string Observaciones { get { return _Observaciones; } set { _Observaciones = value; } }

        public string Forma_Pago { get { return _Forma_Pago; } set { _Forma_Pago = value; } }

        public decimal PORCENTAJE_RETENCION { get { return _PORCENTAJE_RETENCION; } set { _PORCENTAJE_RETENCION = value; } }
    }
}
