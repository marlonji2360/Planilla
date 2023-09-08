using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planilla.Datos
{
    internal class Transacciones
    {
        private Conexion conexion = new Conexion();

        
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void InsertarTransacciones(string P_DOCUMENTO, string P_NUM_DOCUMENTO, float P_MONTO, string P_DESCRIPCION)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarTransacciones";
            comando.CommandType = CommandType.StoredProcedure;
            //Parametros para ejecutar en el Store Procedure
            
            comando.Parameters.AddWithValue("@P_DOCUMENTO", P_DOCUMENTO);
            comando.Parameters.AddWithValue("@P_NUM_DOCUMENTO", P_NUM_DOCUMENTO);
            comando.Parameters.AddWithValue("@P_MONTO", Math.Round(P_MONTO,2));
            comando.Parameters.AddWithValue("@P_DESCRIPCION", P_DESCRIPCION);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarVacios()
        {

            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandTimeout = 60000;
            comando.CommandText = "EliminarDocumentosVaciosTrx";
            comando.CommandType = CommandType.StoredProcedure;
            //Parametros para ejecutar en el Store Procedure


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
            comando.CommandText = "TRUNCATE TABLE dbo.Transacciones";
            
            //Parametros para ejecutar en el Store Procedure


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
    }
}
