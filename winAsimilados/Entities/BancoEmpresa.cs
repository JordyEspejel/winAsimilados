using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class BancoEmpresa
    {
        private int _ID;
        private string _IDEmpresa;
        private string _RazonSocial;
        private string _Banco;
        private string _Cuenta;
        private string _CLABE;

        public int ID { get { return _ID; } set { _ID = value; } }
        public string IDEmpresa { get { return _IDEmpresa; } set { _IDEmpresa = value; } }
        public string RazonSocial { get { return _RazonSocial; } set { _RazonSocial = value; } }
        public string Banco { get { return _Banco; } set { _Banco = value; } }
        public string Cuenta { get { return _Cuenta; } set { _Cuenta = value; } }
        public string CLABE { get { return _CLABE; } set { _CLABE = value; } }

    }
}
