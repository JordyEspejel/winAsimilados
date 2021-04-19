using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class DetalleLayout
    {
        private string _ID;
        private string _Layout;
        private string _Caratula;
        private decimal _SalarioAsimilado;
        private decimal _ImpuestoNomina;
        private decimal _ComisionServicio;
        private decimal _SubTotal;
        private decimal _IVA;
        private decimal _RetencionIVA;
        private decimal _Total;
        private string _Detalles;
        private decimal _Descuentos;

        public string ID{ get { return _ID; } set { _ID = value; } }
        public string Layout { get { return _Layout; } set { _Layout = value; } }
        public string Caratula { get { return _Caratula; } set { _Caratula = value; } }
        public decimal SalarioAsimilado { get { return _SalarioAsimilado; } set { _SalarioAsimilado = value; } }
        public decimal ImpuestoNomina { get { return _ImpuestoNomina; } set { _ImpuestoNomina = value; } }
        public decimal ComisionServicio { get { return _ComisionServicio; } set { _ComisionServicio = value; } }
        public decimal SubTotal { get { return _SubTotal; } set { _SubTotal = value; } }
        public decimal IVA { get { return _IVA; } set { _IVA = value; } }
        public decimal RetencionIVA { get { return _RetencionIVA; } set { _RetencionIVA = value; } }
        public decimal Total { get { return _Total; } set { _Total = value; } }
        public string Detalles { get { return _Detalles; } set { _Detalles = value; } }

        public decimal Descuentos { get { return _Descuentos; } set { _Descuentos = value; } }
        private string _nominaEmpresaID;
        public string nominaEmpresaID
        {
            get { return _nominaEmpresaID; }
            set { _nominaEmpresaID = value; }
        }
    }
}
