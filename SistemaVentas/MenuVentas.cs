using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentas.Utilidades;

namespace SistemaVentas
{
    public partial class MenuVentas : Form
    {
        private MenuPrincipal? formMenuPrincipal;
        private List<Articulo> productosDisponibles;
        private float totalVenta = 0f;
        private UtilidadesUI resizer = new UtilidadesUI();
        
        private const int ControlRadius = 12;

        public MenuVentas(MenuPrincipal? menuPrincipal = null)
        {
            InitializeComponent();
            formMenuPrincipal = menuPrincipal;
            productosDisponibles = new List<Articulo>();

            this.StartPosition = FormStartPosition.CenterScreen;

            // Capturar tamaños originales y suscribir resize
            resizer.CaptureOriginalSizes(this);
            this.Resize += MenuVentas_Resize;

            // Ocultar lista de resultados inicialmente
            lstResultadosBusqueda.Visible = false;

            // Cargar productos desde la base de datos
            CargarProductos();
            ActualizarTotal();

            // Aplicar bordes redondeados al formulario y a sus controles (excepto TextBox)
            UtilidadesUI.ApplyRoundedExceptTextBoxes(this, ControlRadius);
        }

        private void MenuVentas_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
        }

        // ============================================
        //    CARGAR PRODUCTOS DESDE LA BD
        // ============================================
        private void CargarProductos()
        {
            try
            {
                DataTable tabla = Articulo.ObtenerArticulos();
                productosDisponibles.Clear();

                foreach (DataRow row in tabla.Rows)
                {
                    productosDisponibles.Add(new Articulo
                    {
                        CodigoArticulo = row["CODART"].ToString()!,
                        DescripcionArticulo = row["DESART"].ToString()!,
                        PrecioArticulo = Convert.ToSingle(row["PREART"]),
                        ExistenciaActual = row["EXIACT"] != DBNull.Value ? Convert.ToSingle(row["EXIACT"]) : 0
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================
        //    BUSCAR MIENTRAS ESCRIBE
        // ============================================
        private void TxtBuscarProducto_TextChanged(object? sender, EventArgs e)
        {
            string busqueda = txtBuscarProducto.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                lstResultadosBusqueda.Visible = false;
                return;
            }

            // Filtrar productos que coincidan con código o descripción
            // y cuya existencia actual (stock) sea mayor a 0
            var coincidencias = productosDisponibles
                .Where(p => (p.CodigoArticulo.ToLower().Contains(busqueda) ||
                           p.DescripcionArticulo.ToLower().Contains(busqueda)) &&
                           p.ExistenciaActual > 0)
                .Take(10)
                .ToList();

            lstResultadosBusqueda.Items.Clear(); // Limpiar resultados anteriores

            if (coincidencias.Any())
            {
                lstResultadosBusqueda.Visible = true;

                foreach (var producto in coincidencias)
                {
                    lstResultadosBusqueda.Items.Add(
                        $"{producto.CodigoArticulo} - {producto.DescripcionArticulo} - ${producto.PrecioArticulo:F2}"
                    );
                }
            }
            else
            {
                lstResultadosBusqueda.Visible = false;
            }
        }

        // ============================================
        //    NAVEGACIÓN CON TECLADO
        // ============================================
        private void TxtBuscarProducto_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && lstResultadosBusqueda.Visible && lstResultadosBusqueda.Items.Count > 0)
            {
                lstResultadosBusqueda.Focus();
                lstResultadosBusqueda.SelectedIndex = 0;
                e.Handled = true;
            }

        }

        private void LstResultadosBusqueda_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgregarProductoSeleccionado();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                lstResultadosBusqueda.Visible = false;
                txtBuscarProducto.Focus();
                e.Handled = true;
            }
        }

        // ============================================
        //    AGREGAR PRODUCTO AL HACER DOBLE CLIC
        // ============================================
        private void LstResultadosBusqueda_DoubleClick(object? sender, EventArgs e)
        {
            AgregarProductoSeleccionado();
        }

        // ============================================
        // ? AGREGAR PRODUCTO AL DGV
        // ============================================
        private void AgregarProductoSeleccionado()
        {
            if (lstResultadosBusqueda.SelectedItem == null) return;

            string seleccion = lstResultadosBusqueda.SelectedItem.ToString() ?? "";
            string codigoProducto = seleccion.Split('-')[0].Trim();

            var producto = productosDisponibles.FirstOrDefault(p => p.CodigoArticulo == codigoProducto);
            if (producto == null) return;

            // Si el producto ya existe, incrementar cantidad
            bool productoExiste = false;
            foreach (DataGridViewRow row in dgvProductosSeleccionados.Rows)
            {
                if (row.Cells["colCodigo"].Value?.ToString() == producto.CodigoArticulo)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["colCantidad"].Value);
                    row.Cells["colCantidad"].Value = cantidadActual + 1;

                    decimal precio = Convert.ToDecimal(row.Cells["colPrecioUnitario"].Value);
                    row.Cells["colSubtotal"].Value = (cantidadActual + 1) * precio;

                    productoExiste = true;
                    break;
                }
            }

            // Si no existe, agregar nuevo
            if (!productoExiste)
            {
                int rowIndex = dgvProductosSeleccionados.Rows.Add();
                DataGridViewRow row = dgvProductosSeleccionados.Rows[rowIndex];

                row.Cells["colCodigo"].Value = producto.CodigoArticulo;
                row.Cells["colDescripcion"].Value = producto.DescripcionArticulo;
                row.Cells["colPrecioUnitario"].Value = producto.PrecioArticulo;
                row.Cells["colCantidad"].Value = 1;
                row.Cells["colSubtotal"].Value = producto.PrecioArticulo;
            }

            ActualizarTotal();

            // Limpiar búsqueda
            txtBuscarProducto.Clear();
            lstResultadosBusqueda.Visible = false;
            txtBuscarProducto.Focus();
        }

        // ============================================
        //  RECALCULAR SUBTOTAL AL CAMBIAR CANTIDAD
        // ============================================
        private void DgvProductosSeleccionados_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Cuando se edita la cantidad, actualizar el subtotal
            if (e.ColumnIndex == dgvProductosSeleccionados.Columns["colCantidad"].Index)
            {
                DataGridViewRow row = dgvProductosSeleccionados.Rows[e.RowIndex];

                try
                {
                    int cantidad;
                    if (!int.TryParse(row.Cells["colCantidad"].Value?.ToString(), out cantidad) || cantidad <= 0)
                    {
                        MessageBox.Show("La cantidad debe ser mayor a 0", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.Cells["colCantidad"].Value = 1;
                        cantidad = 1;
                    }

                    string codigoProducto = row.Cells["colCodigo"].Value?.ToString()!;
                    Articulo producto = productosDisponibles.FirstOrDefault(p => p.CodigoArticulo == codigoProducto);

                    if (producto == null) return;
                    if (cantidad > producto.ExistenciaActual) {
                        cantidad = (int)producto.ExistenciaActual;
                        row.Cells["colCantidad"].Value = producto.ExistenciaActual;
                    }

                    float precio = Convert.ToSingle(row.Cells["colPrecioUnitario"].Value);
                    row.Cells["colSubtotal"].Value = cantidad * precio;

                    dgvProductosSeleccionados.RefreshEdit();

                    ActualizarTotal();
                }
                catch
                {
                    MessageBox.Show("Ingrese una cantidad válida", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    row.Cells["colCantidad"].Value = 1;
                }
            }
        }

        // ============================================
        //  ELIMINAR PRODUCTO
        // ============================================
        private void DgvProductosSeleccionados_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvProductosSeleccionados.Columns["colEliminar"].Index)
            {
                dgvProductosSeleccionados.Rows.RemoveAt(e.RowIndex);
                ActualizarTotal();
            }
        }

        private void DgvProductosSeleccionados_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en el botón eliminar
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvProductosSeleccionados.Columns["colEliminar"].Index)
            {
                var resultado = MessageBox.Show(
                    "¿Está seguro de eliminar este producto de la venta?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    dgvProductosSeleccionados.Rows.RemoveAt(e.RowIndex);
                    ActualizarTotal();
                }
            }
        }

        // ============================================
        //  ACTUALIZAR TOTAL
        // ============================================
        private void ActualizarTotal()
        {
            totalVenta = 0;
            foreach (DataGridViewRow row in dgvProductosSeleccionados.Rows)
            {
                if (row.Cells["colSubtotal"].Value != null)
                {
                    totalVenta += Convert.ToSingle(row.Cells["colSubtotal"].Value);
                }
            }
            lblTotalMonto.Text = $"${totalVenta:F2}";
        }

        // ============================================
        //  IR A FACTURAR
        // ============================================
        private void BtnFacturar_Click(object? sender, EventArgs e)
        {
            if (dgvProductosSeleccionados.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto para facturar", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Abrir formulario de facturación
            using var formFacturacion = new MenuFacturacion(dgvProductosSeleccionados, totalVenta);
            if (formFacturacion.ShowDialog() == DialogResult.OK)
            {
                // Limpiar el grid después de facturar exitosamente
                dgvProductosSeleccionados.Rows.Clear();
                ActualizarTotal();
                txtBuscarProducto.Clear();

                MessageBox.Show("Factura generada exitosamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ============================================
        //  VOLVER AL MENÚ PRINCIPAL
        // ============================================
        private void BtnVolverMenu_Click(object? sender, EventArgs e)
        {
            if (formMenuPrincipal != null)
            {
                formMenuPrincipal.Show();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
