using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class BitacoraXML
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
        private string _Movimiento;
        public string Movimiento
        {
            get { return _Movimiento; }
            set { _Movimiento = value; }
        }
        private DateTime _FecMovimiento;
        public DateTime FecMovimiento
        {
            get { return _FecMovimiento; }
            set { _FecMovimiento = value; }
        }
        private string _IPMovimiento;
        public string IPMovimiento
        {
            get { return _IPMovimiento; }
            set { _IPMovimiento = value; }
        }
        private string _Usuario;
        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        private string _Origen;
        public string Origen
        {
            get { return _Origen; }
            set { _Origen = value; }
        }
    }
}
