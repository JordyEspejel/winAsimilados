using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class Empleado
    {
        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _NumEmpl;
        public string NumEmpl
        {
            get { return _NumEmpl; }
            set { _NumEmpl = value; }
        }

        private string _RFC;
        public string RFC
        {
            get { return _RFC; }
            set { _RFC = value; }
        }

        private string _CURP;
        public string CURP
        {
            get { return _CURP; }
            set { _CURP = value; }
        }
        private string _Periodicidad;
        public string Periodicidad
        {
            get { return _Periodicidad; }
            set { _Periodicidad = value; }
        }

    }
}
