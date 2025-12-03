using System;
using System.Data;
using System.Windows.Forms;
using SistemaVentas.Utilidades;
using Microsoft.Data.SqlClient;

namespace SistemaVentas
{
    public partial class FormFacturacion : Form
    {
        private DataGridView dgvProductos;
        private float montoTotal;
        private float subtotal;
        private float descuentoAplicado;

        public FormFacturacion(DataGridView productos, float total)
        {
            InitializeComponent();
            
            dgvProductos = productos;
            montoTotal = total;
            subtotal = total;
            
            lblTotalValor.Text = $"${montoTotal:F2}";
            lblSubtotalValor.Text = $"${subtotal:F2}";
            lblDescuentoValor.Text = "$0.00";
            lblTotalFinalValor.Text = $"${montoTotal:F2}";
            
            // Configurar eventos
            btnGuardarFactura.Click += BtnGuardarFactura_Click;
            btnCancelar.Click += BtnCancelar_Click;
            txtDescuento.TextChanged += TxtDescuento_TextChanged;
            
            // Configurar valores predeterminados
            dtpFechaFactura.Value = DateTime.Now;
            cmbCondicion.SelectedIndex = 0;
            
            CargarClientes();
            GenerarNumeroFactura();
        }

        private void GenerarNumeroFactura()
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    string query = "SELECT ISNULL(MAX(NUMFAC), 0) + 1 FROM SFTFAC0";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        int nuevoNumero = Convert.ToInt32(comando.ExecuteScalar());
                        txtNumFactura.Text = nuevoNumero.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar número de factura: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumFactura.Text = "1";
            }
        }

        private void CargarClientes()
        {
            try
            {
                DataTable tablaClientes = UtilidadesBD.ObtenerTodosLosRegistros(
                    "SELECT CODCLI, NOMCLI + ' ' + APECLI AS NombreCompleto FROM SFTCLIE0");

                if (tablaClientes != null && tablaClientes.Rows.Count > 0)
                {
                    DataRow fila = tablaClientes.NewRow();
                    fila["CODCLI"] = "";
                    fila["NombreCompleto"] = "Seleccione un cliente";
                    tablaClientes.Rows.InsertAt(fila, 0);

                    cmbCliente.DataSource = tablaClientes;
                    cmbCliente.DisplayMember = "NombreCompleto";
                    cmbCliente.ValueMember = "CODCLI";
                    cmbCliente.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtDescuento_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                float descuentoPorcentaje = string.IsNullOrWhiteSpace(txtDescuento.Text) 
                    ? 0 
                    : float.Parse(txtDescuento.Text);

                if (descuentoPorcentaje < 0 || descuentoPorcentaje > 100)
                {
                    descuentoPorcentaje = 0;
                    txtDescuento.Text = "0";
                }

                descuentoAplicado = subtotal * (float)(descuentoPorcentaje / 100);
                montoTotal = subtotal - descuentoAplicado;

                lblDescuentoValor.Text = $"-${descuentoAplicado:F2}";
                lblTotalFinalValor.Text = $"${montoTotal:F2}";
            }
            catch
            {
                txtDescuento.Text = "0";
            }
        }

        private void BtnGuardarFactura_Click(object? sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                // Crear la factura
                int numeroFactura = Convert.ToInt32(txtNumFactura.Text);
                DateTime fechaFactura = dtpFechaFactura.Value;
                string codigoCliente = cmbCliente.SelectedValue?.ToString() ?? "";
                string condicion = cmbCondicion.SelectedIndex == 0 ? "1" : "2";
                float descuento = string.IsNullOrWhiteSpace(txtDescuento.Text) 
                    ? 0 
                    : float.Parse(txtDescuento.Text);

                Factura factura = new Factura(
                    numeroFactura,
                    fechaFactura,
                    codigoCliente,
                    condicion,
                    descuento,
                    (float)montoTotal
                );

                // Guardar factura
                Factura.InsertarFactura(factura);

                // Guardar detalles de la factura
                GuardarDetallesFactura(numeroFactura);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la factura: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarDetallesFactura(int numeroFactura)
        {
            try
            {
                foreach(DataGridViewRow fila in dgvProductos.Rows)
                {
                    // Obtener datos de cada fila
                    string codigoArticulo = fila.Cells["colCodigo"].Value.ToString()!;
                    int cantidadVendida = Convert.ToInt32(fila.Cells["colCantidad"].Value);
                    float precioVenta = Convert.ToSingle(fila.Cells["colPrecioUnitario"].Value ?? 0);

                    // crear el objeto para insertarlo en la base de datos
                    Detalles detalles = new Detalles(numeroFactura, codigoArticulo, cantidadVendida, precioVenta);
                    detalles.InsertarDetalle();

                    ActualizarExistenciaArticulo(codigoArticulo, cantidadVendida);

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar detalles de factura: " + ex.Message);
            }
        }

        private void ActualizarExistenciaArticulo(string codigoArticulo, int cantidadVendida)
        {
            try
            {
                Detalles.ActualizarExistenciaArticulo(codigoArticulo, cantidadVendida);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar existencia del artículo {codigoArticulo}: " + ex.Message);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNumFactura.Text))
            {
                MessageBox.Show("Debe ingresar un número de factura", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumFactura.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbCliente.SelectedValue?.ToString()))
            {
                MessageBox.Show("Debe seleccionar un cliente", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCliente.Focus();
                return false;
            }

            if (cmbCondicion.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una condición de pago", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCondicion.Focus();
                return false;
            }

            return true;
        }

        private void BtnCancelar_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
