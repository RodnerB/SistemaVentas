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
            DataTable tabla = UtilidadesBD.ObtenerTodosLosRegistros(consulta);
            gridView.DataSource = tabla;
            foreach(var encabezado in encabezados)
            {
                if(gridView.Columns.Contains(encabezado.Key))
                {
                    gridView.Columns[encabezado.Key].HeaderText = encabezado.Value;
                }
            }
        }
    }
}
