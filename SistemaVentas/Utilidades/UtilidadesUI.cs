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

            foreach (var encabezado in encabezados)
            {
                if (gridView.Columns.Contains(encabezado.Key))
                {
                    gridView.Columns[encabezado.Key].HeaderText = encabezado.Value;
                }
            }
        }

        public static void CargarDatosEnGridConFilas(
            DataTable tabla,
            DataGridView gridView,
            Dictionary<string, string> encabezados)
        {
            // Primero limpiamos las filas existentes en el DataGridView
            gridView.Rows.Clear();

            // Recorremos todas las filas del DataTable
            foreach (DataRow filaDataTable in tabla.Rows)
            {
                // Agregar una nueva fila al DataGridView
                int filaIndex = gridView.Rows.Add();
                DataGridViewRow filaGridView = gridView.Rows[filaIndex];

                // Recorremos los encabezados para mapear las columnas
                foreach (var encabezado in encabezados)
                {
                    string columnaGridView = encabezado.Key; // Nombre de la columna en el DataGridView
                    string columnaDataTable = encabezado.Value; // Nombre del campo en el DataTable

                    // Verificamos si la columna del DataTable existe
                    if (tabla.Columns.Contains(columnaDataTable))
                    {
                        // Asignamos el valor de la fila actual del DataTable a la celda del DataGridView
                        filaGridView.Cells[columnaGridView].Value = filaDataTable[columnaDataTable];
                    }
                }
            }
        }
    }
}
