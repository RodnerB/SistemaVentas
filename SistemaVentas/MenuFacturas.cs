using System.Data;

namespace SistemaVentas
{
    public partial class MenuFacturas : Form
    {
        MenuPrincipal formMenuPrincipal; // variable de referencia al formulario principal

        // Constructor que recibe una referencia al formulario principal
        public MenuFacturas(MenuPrincipal MenuPrincipal)
        {
            InitializeComponent();  // Inicializa los componentes gráficos del formulario
            formMenuPrincipal = MenuPrincipal;  // Guarda la referencia del formulario principal que abrió este formulario
            CargarFacturas(); // Carga las facturas en el DataGridView al iniciar el formulario
            cmbCondicion.SelectedIndex = 0;
            ObtenerClientesComboBox();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CargarFacturas() => Factura.ObtenerFacturas(dgvFacturas);

        // Método para obtener los datos de entrada y crear un objeto Factura
        private Factura obtenerFacturaInputs()
        {
            float descuento = inpDescFactura.Text.Length == 0 ? 0 : float.Parse(inpDescFactura.Text);
            float montoFactura = inpMonFactura.Text.Length == 0 ? 0 : float.Parse(inpMonFactura.Text);
            return new Factura(
                Convert.ToInt32(inpNumFactura.Text),
                inpDateTime.Value,
                cmbCodCliente.SelectedValue.ToString(),
                cmbCondicion.Text == "Contado" ? "1" : "2",
                descuento,
                montoFactura
            );
        }

        private void ObtenerClientesComboBox()
        {
            // Lógica para obtener y cargar los clientes en el ComboBox
            DataTable tablaClientes = Utilidades.UtilidadesBD.ObtenerTodosLosRegistros("SELECT CODCLI, NOMCLI FROM SFTCLIE0");
            cmbCodCliente.DataSource = tablaClientes;
            cmbCodCliente.DisplayMember = "NOMCLI"; // Muestra el nombre del cliente
            cmbCodCliente.ValueMember = "CODCLI"; // Usa el código del cliente como valor
        }

        // Evento del botón para volver al menú principal
        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.Show(); // Muestra el formulario principal nuevamente
            this.Close(); //Cierra el formulario actual de clientes
        }

        private void btnAgregarFac_Click(object sender, EventArgs e)
        {
            Factura factura = obtenerFacturaInputs();
            Factura.InsertarFactura(factura);
            CargarFacturas();

        }
    }
}
