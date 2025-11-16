using Microsoft.Data.SqlClient;

namespace SistemaVentas.Utilidades
{
    internal class UtilidadesBD
    {
        public static Dictionary<string, object>? BuscarRegistro(string consulta, string codigo)
        {
            try
            {
                using(SqlConnection conexion = ConexionDB.ObtenerConexion())
                using(SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@codigo", codigo);
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (!lector.Read()) return null;

                        Dictionary<string, object> registro = new();
                        for(int i = 0; i < lector.FieldCount; i++)
                        {
                            registro[lector.GetName(i)] = lector.GetValue(i);
                        }

                        return registro;
                    }
                }
            }

            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al buscar el registro: " + ex.Message,
                                                     "Error de base de datos",
                                                     System.Windows.Forms.MessageBoxButtons.OK,
                                                     System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
