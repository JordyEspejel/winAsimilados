using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace winAsimilados.Controller
{
    class Conexion
    {
        static SqlConnection Connection_BD;
        private static Conexion Instance = null;

        private Conexion()
        {
            try
            {
                PerformConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Error");
            }
        }

        private static void CreateInstance()
        {
            try
            {
                if (Instance == null)
                {
                    Instance = new Conexion();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");            
            }
        }

        public static Conexion GetInstance()
        {
            try
            {
                if (Instance == null)
                {
                    CreateInstance();     
                }
                return Instance;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return null;
            }
        }

        public static void DeleteInstance()
        {
            try
            {
                Instance = null;
                Connection_BD.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public static SqlConnection PerformConnection()
        {
            try
            {
                if (Connection_BD == null)
                {
                    Connection_BD = new SqlConnection("Data Source=server-contpaq\\compac17;Initial Catalog=Nomina_Empresa17;User ID=sa;Password=Supervisor2020.;");
                }
                return Connection_BD;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return null;
            }
        }

        public static void CloseConnection()
        {
            try
            {
                Connection_BD.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }
    }
}
