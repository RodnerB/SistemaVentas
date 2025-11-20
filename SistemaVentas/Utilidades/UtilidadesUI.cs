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
            DataTable tabla,
            DataGridView gridView,
            Dictionary<string, string> encabezados)
        {
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
