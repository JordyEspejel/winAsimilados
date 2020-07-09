using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Entities
{
    class ListaBancos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public string cuenta { get; set; }

        public string CLABE { get; set; }
        public override string ToString()
        {
            return Nombre;
        }

    }
}
