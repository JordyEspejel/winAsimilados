using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class Banco
    {
        private string _cveBanco;
        private string _nomnbre;
        private string _razonSocial;
        private string _clabe;
        private string _cuenta;

        public string cveBanco{ get { return _cveBanco; } set { _cveBanco = value; } }
        public string nombre{ get { return _nomnbre; } set { _nomnbre = value; } }
        public string razonSocial{ get { return _razonSocial; } set { _razonSocial = value; } }
        public string clabe{ get { return _clabe; } set { _clabe = value; } }
        public string cuenta{ get { return _cuenta; } set { _cuenta = value; } }

    }
}
