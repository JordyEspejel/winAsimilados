using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using V = winAsimilados.Views;


namespace winAsimilados
{

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            V.Login login = new V.Login();
            Application.Run(login);
            //V.ListaEmpresas listaEmpresas = new V.ListaEmpresas();
            //Application.Run(listaEmpresas);
        }
    }
}
