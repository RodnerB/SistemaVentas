using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SistemaVentas
{
    
    internal class ConexionDB
    {
        private static string connectionString = ConnectionString.GetConnectionString();

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new(connectionString);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al conectar a la base de datos" + ex.Message);
            }
        }

        public static bool ProbarConexion()
        {
            try
            {
                using (SqlConnection conexion = ObtenerConexion())
                {
                    return conexion.State == ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
