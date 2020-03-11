using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class Empresa
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Empresa;
        public string empresa
        {
            get { return _Empresa; }
            set { _Empresa = value; }
        }

        private string _RFC;
        public string RFC
        {
            get { return _RFC; }
            set { _RFC = value; }
        }
        private int _Status;
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private string _BD;
        public string BD
        {
            get { return _BD; }
            set { _BD = value; }
        }
    }
}
