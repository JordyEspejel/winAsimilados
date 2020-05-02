using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class Calculo
    {
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
        private decimal _ISR;
        public decimal ISR
        {
            get { return _ISR; }
            set { _ISR = value; }
        }
        private decimal _Sub;
        public decimal Sub
        {
            get { return _Sub; }
            set { _Sub = value; }
        }
        private decimal _IngresosNetos;
        public decimal IngresosNetos
        {
            get { return _IngresosNetos; }
            set { _IngresosNetos = value; }
        }
    }
}
