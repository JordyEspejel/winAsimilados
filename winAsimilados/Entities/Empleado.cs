using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class Empleado
    {
        private int _IDEmpleado;
        public int IDEmpleado
        {
            get { return _IDEmpleado; }
            set { _IDEmpleado = value; }
        }

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
        private string _TipoRegimen;
        public string TipoRegimen
        {
            get { return _TipoRegimen; }
            set { _TipoRegimen = value; }
        }

        private string _TipoContrato;
        public string TipoContrato
        {
            get { return _TipoContrato; }
            set { _TipoContrato = value; }
        }
        private string _Sindicalizado;
        public string Sindicalizado
        {
            get { return _Sindicalizado; }
            set { _Sindicalizado = value; }
        }
        private string _Departamento;
        public string Departamento
        {
            get { return _Departamento; }
            set { _Departamento = value; }
        }
        private string _Puesto;
        public string Puesto
        {
            get { return _Puesto; }
            set { _Puesto = value; }
        }
    }
}
