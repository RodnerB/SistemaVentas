using Microsoft.Data.SqlClient;
using System.Data;

namespace SistemaVentas.Utilidades
{
    internal class UtilidadesBD
    {
        public static DataTable ObtenerTodosLosRegistros(string consulta)
        {
            DataTable tabla = new DataTable();
            try
            {
                using(SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    adaptador.Fill(tabla);
                }
            }

            
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al obtener los registros: " + ex.Message,
                                                     "Error de base de datos",
                                                     System.Windows.Forms.MessageBoxButtons.OK,
                                                     System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }

            return tabla;
        }
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
                MessageBox.Show("Error al buscar el registro: " + ex.Message,
                                                     "Error de base de datos",
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Error);
                return null;
            }
        }

        public static void GuardarRegistro(string consulta, Dictionary<string, object> parametros, string tipoRegistro)
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    foreach(var parametro in parametros)
                    {
                        comando.Parameters.AddWithValue(parametro.Key, parametro.Value);
                    }
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show( tipoRegistro + " guardado exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el cliente.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al guardar el registro: " + ex.Message,
                                                     "Error de base de datos",
                                                     System.Windows.Forms.MessageBoxButtons.OK,
                                                     System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
