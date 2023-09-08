using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planilla.Datos
{
    internal class ClientesActivosApp
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void IngresarClientesActivosApp(string P_DOCUMENTO                                                
                                            )
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarClientesActivosApp";
            comando.CommandType = CommandType.StoredProcedure;
            //Parametros para ejecutar en el Store Procedure
            comando.Parameters.AddWithValue("@P_DOCUMENTO", P_DOCUMENTO);
           

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void LimpiarTabla()
        {

            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandTimeout = 60000;
            comando.CommandText = "TRUNCATE TABLE dbo.ClientesActivosApp";
            
            //Parametros para ejecutar en el Store Procedure


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
    }
}
