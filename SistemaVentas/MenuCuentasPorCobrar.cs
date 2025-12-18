using SistemaVentas.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class MenuCuentasPorCobrar : Form
    {
        private Form formMenuPrincipal;
        private UtilidadesUI resizer = new UtilidadesUI();

        public MenuCuentasPorCobrar(Form menuPrincipal)
        {
            InitializeComponent();
            formMenuPrincipal = menuPrincipal;

            resizer.CaptureOriginalSizes(this);
            this.Resize += MenuCuentasPorCobrar_Resize;

            // Aplicar redondeo a todos los controles excepto los TextBox
            UtilidadesUI.ApplyRoundedExceptTextBoxes(this, 12);

        }

        private void activarInputs(bool activar)
        {
            inpCodigoDelCliente.Enabled = !activar;
            inpFactura.Enabled = activar;

            btnBuscarCuentasPorCobrar.Enabled = !activar;
            btnPagar.Enabled = activar;
            btnCancelar.Enabled = activar;
        }
        private void limpiarInputs()
        {
            inpCodigoDelCliente.Text = "";
            inpNombreDelCliente.Text = "";
            inpFactura.Text = "";
            inpValorAPagar.Text = "";
        }

        private Cliente? BuscarCliente(string codigoCliente)
        {
            try
            {
                Cliente? cliente = Cliente.ObtenerClientePorCodigo(codigoCliente);
                if (cliente == null)
                {
                    MessageBox.Show("El cliente no existe.", "No Encontrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }
                return cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No Encontrado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }


        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.Show();
            this.Close();
        }

        private void MenuCuentasPorCobrar_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            activarInputs(false);
            limpiarInputs();
        }

        private void btnBuscarCuentasPorCobrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = BuscarCliente(inpCodigoDelCliente.Text);

            if (cliente == null) return;

            inpNombreDelCliente.Text = cliente.NombreCliente;

            activarInputs(true);

            DataTable facturasPendientes = Factura.ObtenerFacturasCreditoPorCliente(cliente.CodigoCliente);
            dgvCuentasPorCobrar.Rows.Clear();
            Factura.CargarFacturasEnGridConFilas(dgvCuentasPorCobrar, facturasPendientes);
        }
    }
}
