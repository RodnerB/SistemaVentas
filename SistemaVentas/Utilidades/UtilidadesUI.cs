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

            gridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            gridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            DataGridViewColumn? obsCol = null;

            if (gridView.Columns.Contains("OBSCLI"))
            {
                obsCol = gridView.Columns["OBSCLI"];
            }
            else
            {
                foreach (DataGridViewColumn col in gridView.Columns)
                {
                    if (string.Equals(col.HeaderText, "Observaciones",
                        StringComparison.OrdinalIgnoreCase))
                    {
                        obsCol = col;
                        break;
                    }
                }
            }

            foreach (var encabezado in encabezados)
            {
                if (gridView.Columns.Contains(encabezado.Key))
                {
                    gridView.Columns[encabezado.Key].HeaderText = encabezado.Value;
                }
            }
        }
    }
}
