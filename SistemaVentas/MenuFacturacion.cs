using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SistemaVentas.Utilidades;
using Microsoft.Data.SqlClient;

namespace SistemaVentas
{
    public partial class MenuFacturacion : Form
    {
        private DataGridView dgvProductos;
        private float montoTotal;
        private float subtotal;
        private float descuentoAplicado;

        public MenuFacturacion(DataGridView productos, float total)
        {
            InitializeComponent();

            dgvProductos = productos;
            montoTotal = total;
            subtotal = total;

            lblTotalValor.Text = $"${montoTotal:F2}";
            lblSubtotalValor.Text = $"${subtotal:F2}";
            lblDescuentoValor.Text = "$0.00";
            lblTotalFinalValor.Text = $"${montoTotal:F2}";

            // valores predeterminados
            dtpFechaFactura.Value = DateTime.Now;
            cmbCondicion.SelectedIndex = 0;

            CargarClientes();
            GenerarNumeroFactura();

            // Aplicar apariencia local: solo Panels y Buttons redondeados
            // y activar ajuste automático del contenido a cualquier pantalla.
            UtilidadesUI.ApplyRoundedExceptTextBoxes(this, 12);

        }

        private void GenerarNumeroFactura()
        {
            try
            {
                txtNumFactura.Text = Factura.ObtenerNuevoCodigoFactura().ToString();
               
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
                DataTable tablaClientes = Cliente.ObtenerClientes();
                if (tablaClientes != null && tablaClientes.Rows.Count > 0)
                {
                    // Crear una nueva columna para la combinación de CODCLI y NOMCLI
                    tablaClientes.Columns.Add("ClienteCompleto", typeof(string));

                    // Llenar la columna "ClienteCompleto" con la combinación de CODCLI y NOMCLI
                    foreach (DataRow fila in tablaClientes.Rows)
                    {
                        fila["ClienteCompleto"] = fila["CODCLI"].ToString() + " - " + fila["NOMCLI"].ToString();
                    }

                    // Crear una fila en la parte superior para el mensaje predeterminado
                    DataRow filaDefault = tablaClientes.NewRow();
                    filaDefault["CODCLI"] = "";
                    filaDefault["NOMCLI"] = "Seleccione un cliente";
                    filaDefault["ClienteCompleto"] = "Seleccione un cliente";  // Usar la misma columna para el valor predeterminado
                    tablaClientes.Rows.InsertAt(filaDefault, 0);

                    // Asignar la tabla al ComboBox
                    cmbCliente.DataSource = tablaClientes;
                    cmbCliente.DisplayMember = "ClienteCompleto";  // Mostrar la nueva columna
                    cmbCliente.ValueMember = "CODCLI";  // Mantener CODCLI como el valor
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
            GuardarFactura();
        }

        private void GuardarFactura()
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
                if(condicion == "2")
                {

                    Cliente.RestarBalanceCliente(codigoCliente, (int)montoTotal);
                }

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
                foreach (DataGridViewRow fila in dgvProductos.Rows)
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

            if (string.IsNullOrWhiteSpace(cmbCliente.SelectedValue?.ToString()) && cmbCondicion.SelectedIndex != 0)
            {
                MessageBox.Show("Para realizar una factura a credito debe seleccionar un cliente", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCliente.Focus();
                return false;
            }

            // 0 = Contado, 1 = Crédito
            if (cmbCondicion.SelectedIndex == 1)
            {

                DataRowView clienteSeleccionado = (DataRowView)cmbCliente.SelectedItem;
                float balanceCliente = Convert.ToSingle(clienteSeleccionado["BALCLI"]);

                if (montoTotal > balanceCliente)
                {
                MessageBox.Show(
                    $"El monto de la factura sobrepasa el balance disponible del cliente \nMonto: ${montoTotal} \nBalance disponible: ${balanceCliente}",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbCondicion.Focus();
                return false;

                }
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
