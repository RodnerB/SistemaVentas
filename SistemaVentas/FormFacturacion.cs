using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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

            // Aplicar apariencia local: solo Panels y Buttons redondeados
            // y activar ajuste automático del contenido a cualquier pantalla.
            FormFacturacionAppearanceManager.Apply(this, panelRadius: 12, buttonRadius: 12);
        }

        private void GenerarNumeroFactura()
        {
            try
            {
                txtNumFactura.Text = Factura.ObtenerNuevoCodigoFactura().ToString();
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

    // ------------------------------------------------------------
    // Clases colocadas en este archivo según lo solicitado:
    // - FormFacturacionAppearanceManager: aplica redondeo SOLO a Panel y Button
    // - FormFacturacionResizer: ajusta control y fuentes al cambiar tamaño
    // ------------------------------------------------------------
    internal static class FormFacturacionAppearanceManager
    {
        public static void Apply(Form form, int panelRadius = 12, int buttonRadius = 12)
        {
            if (form == null || form.IsDisposed) return;

            
                // Aplicar redondeo solo a Panel y Button (recursivo)
                foreach (Control c in GetAllChildControls(form))
                {
                    if (c is Panel)
                        RoundedControlHelper.RedondearBordes(c, panelRadius);
                    else if (c is Button)
                        RoundedControlHelper.RedondearBordes(c, buttonRadius);
                }

                // Configurar resizer local para el formulario (ajuste automático)
                var resizer = new FormFacturacionResizer();
                resizer.CaptureOriginalSizes(form);
                form.Resize += (s, e) => resizer.ResizeControls(form);
                // No se guarda en una colección: está ligado al ciclo de vida del Form.
            
          
        }

        private static IEnumerable<Control> GetAllChildControls(Control parent)
        {
            if (parent == null) yield break;
            var stack = new Stack<Control>();
            stack.Push(parent);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                foreach (Control child in current.Controls)
                {
                    yield return child;
                    if (child.HasChildren) stack.Push(child);
                }
            }
        }
    }

    internal sealed class FormFacturacionResizer
    {
        private readonly List<ControlOriginalData> _controlsData = new();
        private Size _formOriginalSize;

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
            try
            {
                _controlsData.Add(new ControlOriginalData
                {
                    Control = control,
                    OriginalLocation = control.Location,
                    OriginalSize = control.Size,
                    OriginalFontSize = control.Font?.Size ?? SystemFonts.DefaultFont.Size,
                    OriginalFontStyle = control.Font?.Style ?? FontStyle.Regular,
                    OriginalFontFamily = control.Font?.FontFamily ?? SystemFonts.DefaultFont.FontFamily
                });
            }
            catch
            {
                // Ignorar controles problemáticos
            }

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

        private sealed class ControlOriginalData
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
