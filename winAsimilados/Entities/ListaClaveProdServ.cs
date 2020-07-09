using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class ListaClaveProdServ
    {
        public string clave { get; set; }
        //public string descripcion { get; set; }
        public override string ToString()
        {
            return clave;
        }
    }
}
