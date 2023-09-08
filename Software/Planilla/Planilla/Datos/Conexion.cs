using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Planilla.Datos
{
    internal class Conexion
    {
        private SqlConnection cn = new SqlConnection(Conexion.GetConnectionStringByName());
        public SqlConnection AbrirConexion()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            return cn;
        }
        public SqlConnection CerrarConexion()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            return cn;
        }

        // Retrieves a connection string by name.
        // Returns null if the name is not found.
        static string GetConnectionStringByName()
        {
            // Assume failure.
            string returnValue = null;

            returnValue = ConfigurationManager.AppSettings["ConexionSQL"];
            // Look for the name in the connectionStrings section.
            //ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string.
            // if (settings != null)
            //   returnValue = settings.ConnectionString;

            return returnValue;
        }
    }
}
