﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Razor.Parser;

namespace winAsimilados.Entities
{
    class CancelarUUID
    {
        private string _uuid;
        public string UIID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
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
        public DateTime FecInicio
        {
            get { return _FecIni; }
            set { _FecIni = value; }
        }
        private DateTime _FecFin;
        public DateTime FecFinal
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

        private string _RFCEmpl;
        public string RFCEmpl
        {
            get { return _RFCEmpl; }
            set { _RFCEmpl = value; }
        }
        private string _selloCFD;
        public string selloCFD
        {
            get { return _selloCFD; }
            set { _selloCFD = value; }
        }
        private decimal _total;
        public decimal total
        {
            get { return _total; }
            set { _total = value; }
        }
    }
}

