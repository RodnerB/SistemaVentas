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
            activarInputs(false);
            IniciarComboFacturas();
        }

        private void activarInputs(bool activar)
        {
            inpCodigoDelCliente.Enabled = !activar;
            cmbFacturas.Enabled = activar;

            btnBuscarCuentasPorCobrar.Enabled = !activar;
            btnPagar.Enabled = activar;
            btnCancelar.Enabled = activar;
        }
        private void limpiarInputs()
        {
            inpCodigoDelCliente.Text = "";
            inpNombreDelCliente.Text = "";
            cmbFacturas.SelectedIndex = 0;
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
            dgvCuentasPorCobrar.Rows.Clear();
            IniciarComboFacturas();
        }

        private void btnBuscarCuentasPorCobrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = BuscarCliente(inpCodigoDelCliente.Text);

            if (cliente == null) return;

            inpNombreDelCliente.Text = cliente.NombreCliente;

            activarInputs(true);
            CargarFacturasCliente(cliente);

        }

        private void CargarFacturasCliente(Cliente cliente)
        {
            DataTable facturasPendientes = Factura.ObtenerFacturasCreditoPorCliente(cliente.CodigoCliente);
            dgvCuentasPorCobrar.Rows.Clear();
            Factura.CargarFacturasEnGridConFilas(dgvCuentasPorCobrar, facturasPendientes);

            // Asegurar que aparezca en el formato correcto (dia, mes, año)
            if (dgvCuentasPorCobrar.Columns.Contains("colFechaFactura"))
                dgvCuentasPorCobrar.Columns["colFechaFactura"].DefaultCellStyle.Format = "dd/MM/yyyy";

            CargarFacturasCombo(facturasPendientes);
        }

        private void CargarFacturasCombo(DataTable facturas)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NUMFAC", typeof(int));
            dt.Columns.Add("MONFAC", typeof(decimal));
            dt.Columns.Add("Descripcion", typeof(string));

            // Fila por defecto
            DataRow filaDefault = dt.NewRow();
            filaDefault["NUMFAC"] = 0;
            filaDefault["MONFAC"] = 0;
            filaDefault["Descripcion"] = "-- Seleccionar factura --";
            dt.Rows.Add(filaDefault);

            foreach (DataRow fila in facturas.Rows)
            {
                DataRow nuevaFila = dt.NewRow();
                nuevaFila["NUMFAC"] = fila["NUMFAC"];
                nuevaFila["MONFAC"] = fila["MONFAC"];
                nuevaFila["Descripcion"] = $"Factura {fila["NUMFAC"]}";
                dt.Rows.Add(nuevaFila);
            }

            cmbFacturas.DataSource = dt;
            cmbFacturas.DisplayMember = "Descripcion";
            cmbFacturas.ValueMember = "NUMFAC";
            cmbFacturas.SelectedIndex = 0;
        }

        private void IniciarComboFacturas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NUMFAC", typeof(int));
            dt.Columns.Add("MONFAC", typeof(decimal));
            dt.Columns.Add("Descripcion", typeof(string));

            DataRow filaDefault = dt.NewRow();
            filaDefault["NUMFAC"] = 0;
            filaDefault["MONFAC"] = 0;
            filaDefault["Descripcion"] = "-- Seleccionar factura --";
            dt.Rows.Add(filaDefault);

            cmbFacturas.DataSource = dt;
            cmbFacturas.DisplayMember = "Descripcion";
            cmbFacturas.ValueMember = "NUMFAC";
            cmbFacturas.SelectedIndex = 0;
        }


        private void cmbFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFacturas.SelectedIndex <= 0)
            {
                inpValorAPagar.Text = "";
                return;
            }

            DataRowView fila = (DataRowView)cmbFacturas.SelectedItem;
            float monto = Convert.ToSingle(fila["MONFAC"]);

            inpValorAPagar.Text = monto.ToString("F2");
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (cmbFacturas.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione una factura para pagar",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int numFactura = Convert.ToInt32(cmbFacturas.SelectedValue);

            // Quitar la factura en el datagrid
            foreach (DataGridViewRow row in dgvCuentasPorCobrar.Rows)
            {
                if (Convert.ToInt32(row.Cells["colNumeroFactura"].Value) == numFactura)
                {
                    dgvCuentasPorCobrar.Rows.Remove(row);
                    break;
                }
            }

            // quitar la factura del cmb
            DataTable dt = (DataTable)cmbFacturas.DataSource;
            DataRow filaEliminar = dt.AsEnumerable()
                .FirstOrDefault(r => r.Field<int>("NUMFAC") == numFactura);

            if (filaEliminar != null)
                dt.Rows.Remove(filaEliminar);


            // poner el valor default del cmb
            cmbFacturas.SelectedIndex = 0;
            inpValorAPagar.Text = "";
        }
    }
}
