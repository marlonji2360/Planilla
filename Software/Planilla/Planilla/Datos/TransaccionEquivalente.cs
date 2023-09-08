using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planilla.Datos
{
    internal class TransaccionEquivalente
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable ConsultarTransacciones()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandTimeout = 60000;
            comando.CommandText = "ConsultaTransaccionEquivalente";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarTransacciones(string P_TRANSACCION, string P_EQUIVALENTE)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarTransaccionEquivalente";
            comando.CommandType = CommandType.StoredProcedure;
            //Parametros para ejecutar en el Store Procedure
            comando.Parameters.AddWithValue("@P_TRANSACCION", P_TRANSACCION);
            comando.Parameters.AddWithValue("@P_EQUIVALENTE", P_EQUIVALENTE);
           
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarTransacciones(int P_ID, string P_TRANSACCION, string P_EQUIVALENTE)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarTransaccionEquivalente";
            comando.CommandType = CommandType.StoredProcedure;
            //Parametros para ejecutar en el Store Procedure
            comando.Parameters.AddWithValue("@P_ID", P_ID);
            comando.Parameters.AddWithValue("@P_TRANSACCION", P_TRANSACCION);
            comando.Parameters.AddWithValue("@P_EQUIVALENTE", P_EQUIVALENTE);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
