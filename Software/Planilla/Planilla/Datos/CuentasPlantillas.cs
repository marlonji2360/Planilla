using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planilla.Datos
{
    internal class CuentasPlantillas
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void IngresarDetalleLista    (   string P_CUENTA,
                                                string P_NOMBRE_CLIENTE,
                                                string P_DPI,
                                                string P_ID
                                            )
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarCuentasPlanillas";
            comando.CommandType = CommandType.StoredProcedure;
            //Parametros para ejecutar en el Store Procedure
            comando.Parameters.AddWithValue("@P_CUENTA", P_CUENTA);
            comando.Parameters.AddWithValue("@P_NOMBRE_CLIENTE", P_NOMBRE_CLIENTE);
            comando.Parameters.AddWithValue("@P_DPI", P_DPI);
            comando.Parameters.AddWithValue("@P_ID", P_ID);
            
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarDuplicados()
        {

            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ELIMINARDUPLICADOS";
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
            comando.CommandText = "TRUNCATE TABLE dbo.CuentasPlanillas";
           
            //Parametros para ejecutar en el Store Procedure


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
    }
}
