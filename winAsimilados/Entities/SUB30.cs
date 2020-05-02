using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class SUB30
    {
        private decimal _rango1;

        public decimal rango1
        {
            get { return _rango1; }
            set { _rango1 = value; }
        }

        private decimal _rango2;

        public decimal rango2
        {
            get { return _rango2; }
            set { _rango2 = value; }
        }

        private decimal _subsidio;

        public decimal subsidio
        {
            get { return _subsidio; }
            set { _subsidio = value; }
        }
    }
}
