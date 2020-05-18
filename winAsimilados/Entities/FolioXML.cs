using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class FolioXML
    {
        private string _Folio;
        public string Folio
        {
            get { return _Folio; }
            set { _Folio = value; }
        }
        private string _UUID;
        public string UUID
        {
            get { return _UUID; }
            set { _UUID = value; }
        }
        private string _XML;
        public string XML
        {
            get { return _XML; }
            set { _XML = value; }
        }
        private string _RutaXML;
        public string RutaXML
        {
            get { return _RutaXML; }
            set { _RutaXML = value; }
        }
        private string _Empleado;
        public string Empleado
        {
            get { return _Empleado; }
            set { _Empleado = value; }
        }
        private decimal _Importe;
        public decimal Importe
        {
            get { return _Importe; }
            set { _Importe = value; }
        }
        private string _StatusSAT;
        public string StatusSAT
        {
            get { return _StatusSAT; }
            set { _StatusSAT = value; }
        }
        private DateTime _FecPago;
        public DateTime FecPago
        {
            get { return _FecPago; }
            set { _FecPago = value; }
        }
        private DateTime _FecIni;
        public DateTime FecIni
        {
            get { return _FecIni; }
            set { _FecIni = value; }
        }
        private DateTime _FecFin;
        public DateTime FecFin
        {
            get { return _FecFin; }
            set { _FecFin = value; }
        }
        private string _Empresa;
        public string Empresa
        {
            get { return _Empresa; }
            set { _Empresa = value; }
        }
        private string _RFC;

        public string RFC
        {
            get { return _RFC; }
            set { _RFC = value; }
        }
    }
}
