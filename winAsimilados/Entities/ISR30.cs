using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class ISR30
    {
        private decimal _LimiteInferior;

        public decimal LimiteInferior
        {
            get { return _LimiteInferior; }
            set { _LimiteInferior = value; }
        }

        private decimal _LimiteSuperior;

        public decimal LimiteSuperior
        {
            get { return _LimiteSuperior; }
            set { _LimiteSuperior = value; }
        }

        private decimal _CuotaFija;

        public decimal CuotaFija
        {
            get { return _CuotaFija; }
            set { _CuotaFija = value; }
        }

        private decimal _Porcentaje;

        public decimal Porcentaje
        {
            get { return _Porcentaje; }
            set { _Porcentaje = value; }
        }
    }
}
