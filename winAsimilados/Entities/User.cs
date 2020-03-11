using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class User
    {
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

    }
}
