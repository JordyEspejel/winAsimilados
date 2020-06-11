using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class User
    {
        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _usuario;
        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private string _pass;
        public string pass
        {
            get { return _pass; }
            set { _pass = value; }
        }
        private string _nombre;
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; } 
        }
        private string _tipoUsuario;
        public string tipoUsiario
        {
            get { return _tipoUsuario; }
            set { _tipoUsuario = value; }
        }

        private string _estatusUsuario;
        public string estatusUsuario
        {
            get { return _estatusUsuario; }
            set { _estatusUsuario = value; }
        }
        private DateTime _fecReg;
        public DateTime fecReg
        {
            get { return _fecReg; }
            set { _fecReg = value; }
        }

        private DateTime _fecMod;
        public DateTime fecMod
        {
            get { return _fecMod; }
            set { _fecMod = value; }
        }
    }
}
