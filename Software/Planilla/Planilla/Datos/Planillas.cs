using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planilla.Datos
{
    internal class Planillas
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void IngresarPlanilla(int P_NO_PLANILLA, string NOMBRE_PLANILLA)
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarPlanilla";
            comando.CommandType = CommandType.StoredProcedure;
            //Parametros para ejecutar en el Store Procedure
            comando.Parameters.AddWithValue("@P_NO_PLANILLA", P_NO_PLANILLA);
            comando.Parameters.AddWithValue("@NOMBRE_PLANILLA", NOMBRE_PLANILLA);


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarPlanilla(int P_ID, int P_NO_PLANILLA, string NOMBRE_PLANILLA)
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarPlanilla";
            comando.CommandType = CommandType.StoredProcedure;
            //Parametros para ejecutar en el Store Procedure
            comando.Parameters.AddWithValue("@P_ID", P_ID);
            comando.Parameters.AddWithValue("@P_NO_PLANILLA", P_NO_PLANILLA);
            comando.Parameters.AddWithValue("@NOMBRE_PLANILLA", NOMBRE_PLANILLA);


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable ConsultarPlanilla()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandTimeout = 60000;
            comando.CommandText = "ConsultarPlanilla";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ConsultarTrxPlanilla()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandTimeout = 60000;
            comando.CommandText = "TrxPlanillas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ConsultarClientesActivos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandTimeout = 60000;
            comando.CommandText = "ClientesActivos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
