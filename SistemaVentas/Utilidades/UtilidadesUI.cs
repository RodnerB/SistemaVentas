using Microsoft.Data.SqlClient;
using SistemaVentas;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace SistemaVentas.Utilidades
{
    internal class UtilidadesUI
    {
        private readonly List<ControlOriginalData> _controlsData = new();
        private Size _formOriginalSize;

        // ============================================
        //    CARGAR REGISTROS EN DATAGRIDVIEW 
        // ============================================
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

        // ============================================
        //    FUNCIONES DE REDONDEO
        // ============================================

        public static void RedondearBordes(Control control, int radius)
        {
            if (control == null || radius <= 0) return;

            void ApplyRegion(Control c)
            {
                var path = new GraphicsPath();
                int w = Math.Max(0, c.Width);
                int h = Math.Max(0, c.Height);
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(w - radius, 0, radius, radius, 270, 90);
                path.AddArc(w - radius, h - radius, radius, radius, 0, 90);
                path.AddArc(0, h - radius, radius, radius, 90, 90);
                path.CloseFigure();
                c.Region = new Region(path);
            }

            ApplyRegion(control);

            // Reaplicar cuando cambie el tamaño
            control.Resize += (s, e) =>
            {
                if (s is Control c && c != null)
                {
                    ApplyRegion(c);
                }
            };
        }

        public static void RedondearTodosLosPaneles(Control parent, int radius)
        {
            if (parent == null) return;
            foreach (Control c in parent.Controls)
            {
                if (c is Panel)
                {
                    RedondearBordes(c, radius);
                }
                if (c.HasChildren)
                {
                    RedondearTodosLosPaneles(c, radius);
                }
            }
        }


        public static void RedondearTodosLosBotones(Control parent, int radius)
        {
            if (parent == null) return;

            foreach (Control c in parent.Controls)
            {
                if (c is Button btn)
                {
                    // Opcional: estilo para que respete la Region
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    RedondearBordes(btn, radius);
                }

                if (c.HasChildren)
                {
                    RedondearTodosLosBotones(c, radius);
                }
            }
        }

        public static void ApplyRoundedExceptTextBoxes(Control parent, int radius)
        {
            if (parent == null) return;

            foreach (Control c in parent.Controls)
            {
                if (c is not TextBox)
                {
                    int r = c is Button ? 12 : radius;
                    RedondearBordes(c, r);
                }

                if (c.HasChildren)
                    ApplyRoundedExceptTextBoxes(c, radius);
            }
        }

        // ============================================
        //    FUNCIONES PARA MANEJO DE REDIMENSIONADO
        // ============================================
        public void CaptureOriginalSizes(Form form)
        {
            if (form == null) return;
            _formOriginalSize = form.ClientSize;
            _controlsData.Clear();
            SaveControl(form);
        }

        private void SaveControl(Control control)
        {
            if (control == null) return;


            _controlsData.Add(new ControlOriginalData
            {
                Control = control,
                OriginalLocation = control.Location,
                OriginalSize = control.Size,
                OriginalFontSize = control.Font?.Size ?? SystemFonts.DefaultFont.Size,
                OriginalFontStyle = control.Font?.Style ?? FontStyle.Regular,
                OriginalFontFamily = control.Font?.FontFamily ?? SystemFonts.DefaultFont.FontFamily
            });


            foreach (Control child in control.Controls)
                SaveControl(child);
        }

        public void ResizeControls(Form form)
        {
            if (form == null) return;
            if (_formOriginalSize.Width == 0 || _formOriginalSize.Height == 0) return;

            float xRatio = (float)form.ClientSize.Width / _formOriginalSize.Width;
            float yRatio = (float)form.ClientSize.Height / _formOriginalSize.Height;
            float scale = Math.Min(xRatio, yRatio);

            foreach (var item in _controlsData)
            {
                var ctrl = item.Control;
                if (ctrl == null || ctrl.IsDisposed) continue;

                try
                {
                    ctrl.Location = new Point(
                        (int)Math.Round(item.OriginalLocation.X * xRatio),
                        (int)Math.Round(item.OriginalLocation.Y * yRatio));

                    ctrl.Size = new Size(
                        Math.Max(1, (int)Math.Round(item.OriginalSize.Width * xRatio)),
                        Math.Max(1, (int)Math.Round(item.OriginalSize.Height * yRatio)));

                    float newFontSize = Math.Max(6f, item.OriginalFontSize * scale);
                    ctrl.Font = new Font(item.OriginalFontFamily, newFontSize, item.OriginalFontStyle);
                }
                catch
                {
                    // Ignorar errores individuales
                }
            }
        }

        private class ControlOriginalData
        {
            public Control Control { get; set; } = null!;
            public Point OriginalLocation { get; set; }
            public Size OriginalSize { get; set; }
            public float OriginalFontSize { get; set; }
            public FontStyle OriginalFontStyle { get; set; }
            public FontFamily OriginalFontFamily { get; set; } = null!;
        }
    }

}

