using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using C = winAsimilados.Controller.ConnectionStringManager;

namespace winAsimilados.Controller
{
    class Conexion
    {
        static SqlConnection Connection_BD;
        static SqlConnection Connection_BDSoprade;
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
                Connection_BDSoprade.Close();
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
                string cString = C.GetFirstConnectionString("localhost_BSNOMINAS_Connection 1");
                if (Connection_BD == null)
                {
                    //Connection_BD = new SqlConnection("Data Source=server-contpaq\\compac17;Initial Catalog=Nomina_Empresa17;User ID=sa;Password=Supervisor2020.;");
                    //Connection_BD = new SqlConnection("Data Source=server-contpaq\\compac17;Initial Catalog=BSNOMINAS;User ID=sa;Password=Supervisor2020.;");
                    //Connection_BD = new SqlConnection("Data Source=192.168.4.182\\COMPAC;Initial Catalog=BSNOMINAS;User ID=sa;Password=Supervisor2020.;");
                    Connection_BD = new SqlConnection(cString);
                }
                return Connection_BD;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return null;
            }
        }

        public static SqlConnection ChangeConnection(string BD)
        {
            try
            {
                if (Connection_BD != null)
                {
                    Connection_BD.ChangeDatabase(BD);
                  
                }
                return Connection_BD;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return null;
            }
        }

        public static SqlConnection PerformConnectionSoprade()
        {
            try
            {
                string cStringSoprade = C.GetConnectionString("localhost_dbDatosNomina_ConnectionNube");
                if (Connection_BDSoprade == null)
                {
                    //Connection_BDSoprade = new SqlConnection("Data Source=db-server\\inarisql;Initial Catalog=dbDatosNomina;User ID=sa;Password=Sql1N4r1;");
                    //Connection_BDSoprade = new SqlConnection("Data Source=192.168.4.142;Initial Catalog=dbDatosNomina;User ID=sa;Password=Sql1N4r1;");
                    Connection_BDSoprade = new SqlConnection(cStringSoprade);
                }
                return Connection_BDSoprade;
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
                Connection_BDSoprade.Close();
                if (Connection_BDSoprade.State == System.Data.ConnectionState.Closed)
                {
                    MessageBox.Show("Conexion Cerrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "Error Conexion()", "Error");
            }
        }
    }
}
