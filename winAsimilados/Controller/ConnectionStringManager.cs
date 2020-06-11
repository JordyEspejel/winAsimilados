using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Controller
{
    class ConnectionStringManager
    {
        public static string GetConnectionString(string connectionStringName)
        {
            Configuration appconfig =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringSettings connStringSettings = appconfig.ConnectionStrings.ConnectionStrings[connectionStringName];
            return connStringSettings.ConnectionString;
        }

        public static void SaveConnectionString(string connectionStringName, string connectionString)
        {
            Configuration appconfig =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            appconfig.ConnectionStrings.ConnectionStrings[connectionStringName].ConnectionString = connectionString;
            appconfig.Save();
        }
        public static List<string> GetConnectionStringNames()
        {
            List<string> cns = new List<string>();
            Configuration appconfig =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            foreach (ConnectionStringSettings cn in appconfig.ConnectionStrings.ConnectionStrings)
            {
                cns.Add(cn.Name);
            }
            return cns;
        }

        public static string GetFirstConnectionStringName()
        {
            return GetConnectionStringNames().ElementAtOrDefault(1);
        }
        public static string GetFirstConnectionString(string name)
        {
            return GetConnectionString(name);
        }
        public static string SetConnectionStringServerName(
        string connectionString, string serverName)
        {
            SqlConnectionStringBuilder builder =
                new SqlConnectionStringBuilder(connectionString);
            builder.DataSource = serverName;
            return builder.ConnectionString;
        }

        public static string SetConnectionStringAutenticationIntegrated(
            string connectionString)
        {
            SqlConnectionStringBuilder builder =
                new SqlConnectionStringBuilder(connectionString);
            builder.IntegratedSecurity = true;
            return builder.ConnectionString;
        }

        public static string SetConnectionStringAutenticationSQLServer(
            string connectionString, string username, string password)
        {
            SqlConnectionStringBuilder builder =
                new SqlConnectionStringBuilder(connectionString);
            builder.IntegratedSecurity = false;
            builder.UserID = username;
            builder.Password = password;
            return builder.ConnectionString;
        }

        public static string SetConnectionStringDatabaseName(
            string connectionString, string databaseName)
        {
            SqlConnectionStringBuilder builder =
                new SqlConnectionStringBuilder(connectionString);
            builder.InitialCatalog = databaseName;
            return builder.ConnectionString;
        }
    }
}
