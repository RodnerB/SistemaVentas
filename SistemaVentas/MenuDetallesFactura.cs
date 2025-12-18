using System;
using System.Windows.Forms;
using SistemaVentas.Utilidades;

namespace SistemaVentas
{
    public partial class MenuDetallesFactura : Form
    {
        private readonly int numeroFactura;
        private float totalFactura;

        private readonly UtilidadesUI resizer = new UtilidadesUI();

        public MenuDetallesFactura(int numFactura)
        {
            InitializeComponent();

            numeroFactura = numFactura;
            StartPosition = FormStartPosition.CenterScreen;

            // Solo usamos el resizer y el redondeo
            resizer.CaptureOriginalSizes(this);
            Resize += MenuDetallesFactura_Resize;
            UtilidadesUI.ApplyRoundedExceptTextBoxes(this, 12);

            Load += MenuDetallesFactura_Load;

            // Si tienes un TextBox para buscar por número de factura, asegúrate
            // de que su Name en el diseñador coincida con "inpNumeroFacturaDetalles"
            var txtBusqueda = Controls.Find("inpNumeroFactura", true);
            if (txtBusqueda.Length > 0 && txtBusqueda[0] is TextBox txt)
            {
                txt.KeyDown += InpNumeroFacturaDetalles_KeyDown;
            }
        }

        // Deja SOLO UNA definición de este método en el archivo
        private void MenuDetallesFactura_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
        }

        private void MenuDetallesFactura_Load(object? sender, EventArgs e)
        {
            try
            {
                CargarDatosFactura();
                CargarDetalles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error en Load de MenuDetallesFactura: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void InpNumeroFacturaDetalles_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            e.SuppressKeyPress = true;

            if (sender is not TextBox txt)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show(
                    "Debe introducir un número de factura para buscar.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txt.Text, out int numFac))
            {
                MessageBox.Show(
                    "El número de factura debe ser un número entero.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            BuscarYMostrarFactura(numFac);
        }

        private void BuscarYMostrarFactura(int numFac)
        {
            try
            {
                Factura? factura = Factura.ObtenerFacturaPorCodigo(numFac.ToString());
                if (factura == null)
                {
                    MessageBox.Show(
                        "No se encontró la factura.",
                        "No encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                lblFactura.Text = "Factura #: " + numFac;

                if (!string.IsNullOrWhiteSpace(factura.codigoCliente))
                {
                    Cliente? cliente = Cliente.ObtenerClientePorCodigo(factura.codigoCliente);
                    lblCliente.Text = cliente != null
                        ? "Cliente: " + cliente.NombreCliente + " " + cliente.ApellidoCliente
                        : "Cliente: No especificado";
                }
                else
                {
                    lblCliente.Text = "Cliente: No especificado";
                }

                CargarDetallesPorNumero(numFac);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar la factura: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarDetalles()
        {
            CargarDetallesPorNumero(numeroFactura);
        }

        private void CargarDetallesPorNumero(int numFac)
        {
            try
            {
                Detalles.CargarDetallesGridConFilas(dgvDetalles, numFac);

                if (dgvDetalles.Rows.Count == 0)
                {
                    lblTotalFactura.Text = "Total: $0.00";
                    return;
                }

                CalcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los detalles: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarDatosFactura()
        {
            try
            {
                Factura? factura = Factura.ObtenerFacturaPorCodigo(numeroFactura.ToString());

                if (factura == null)
                {
                    MessageBox.Show(
                        "No se encontró la factura.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                lblFactura.Text = "Factura #: " + numeroFactura;

                if (!string.IsNullOrWhiteSpace(factura.codigoCliente))
                {
                    Cliente? cliente = Cliente.ObtenerClientePorCodigo(factura.codigoCliente);
                    lblCliente.Text = cliente != null
                        ? "Cliente: " + cliente.NombreCliente + " " + cliente.ApellidoCliente
                        : "Cliente: No especificado";
                }
                else
                {
                    lblCliente.Text = "Cliente: No especificado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar datos de la factura: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CalcularTotal()
        {
            totalFactura = 0;

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                object cant = row.Cells["colCantidad"].Value;
                object prec = row.Cells["colPrecio"].Value;

                if (cant == null || prec == null ||
                    cant == DBNull.Value || prec == DBNull.Value)
                {
                    continue;
                }

                float cantidad = Convert.ToSingle(cant);
                float precio = Convert.ToSingle(prec);
                totalFactura += cantidad * precio;
            }

            lblTotalFactura.Text = $"Total: ${totalFactura:N2}";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}