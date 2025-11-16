using System.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaVentas;
namespace SistemaVentas.Utilidades
{
    internal class UtilidadesUI
    {
        public static void CargarDatosEnGrid(
            string consulta,
            DataGridView gridView,
            Dictionary<string, string> encabezados)
        {
            try
            {
                using(SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    gridView.DataSource = tabla;
                    foreach (var encabezado in encabezados)
                    {
                        if (gridView.Columns.Contains(encabezado.Key))
                        {
                            gridView.Columns[encabezado.Key].HeaderText = encabezado.Value;
                        }
                    }
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error al cargar los datos en el grid: " + ex.Message,
                                "Error de base de datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
