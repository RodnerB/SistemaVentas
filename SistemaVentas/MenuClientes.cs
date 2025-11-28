using Helpers;

namespace SistemaVentas
{
    public partial class MenuClientes : Form
    {
        Cliente? cliente = new Cliente();
        bool existeElCliente = false;
        MenuPrincipal formMenuPrincipal; // variable de referencia al formulario principal

        //  Constructor que recibe una referencia al formulario principal
        public MenuClientes(MenuPrincipal MenuPrincipal)
        {
            InitializeComponent(); // Inicializa los componentes gráficos del formulario
            formMenuPrincipal = MenuPrincipal; // Guarda la referencia del formulario principal que abrió este formulario

            // Estados iniciales (como en MenuArticulos)
            btnAgregarCli.Enabled = false;
            btnEliminarCli.Enabled = false;
            btnBuscarCli.Enabled = true;
            btnVolverAlMenuPrincipal.Enabled = true;

            // Permitir que Enter active el botón Agregar cuando esté habilitado
            this.AcceptButton = btnAgregarCli;

            CargarClientes();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Asegurar que el evento Load esté suscrito
            this.Load += Clientes_Load;

            // Suscribir eventos (usar nombres reales del diseñador)
            if (btnAgregarCli != null) btnAgregarCli.Click += btnAgregarCli_Click;
            if (btnEliminarCli != null) btnEliminarCli.Click += btnEliminarCli_Click;
            if (btnBuscarCli != null) btnBuscarCli.Click += btnBuscarCli_Click;
            if (btnVolverAlMenuPrincipal != null) btnVolverAlMenuPrincipal.Click += btnVolverMenuPrincipal_Click;

            // Suscribir KeyDown recursivamente (paneles contienen controles)
            AddKeyDownRecursively(this);

            // Cuando el formulario se muestre, establecer el foco en la primera casilla de texto
            this.Shown += Form2_Shown;
        }

        private void AddKeyDownRecursively(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox tb)
                {
#pragma warning disable CS8622
                    tb.KeyDown += EventoMoverConEnter;
#pragma warning restore CS8622
                }
                if (c.HasChildren) AddKeyDownRecursively(c);
            }
        }

        private void Clientes_Load(object? sender, EventArgs e)
        {
            RoundedControlHelper.RedondearTodosLosPaneles(this, 20);
        }

        private void Form2_Shown(object? sender, EventArgs e)
        {
            inpCodCliente?.Focus();
        }

        private void CargarClientes()
        {
            try
            {
                Cliente.ObtenerClientes(dgvClientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarClientes(Cliente cliente)
        {
            try
            {
                if (cliente.ActualizarCliente())
                {
                    MessageBox.Show("Cliente modificado exitosamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el cliente.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            existeElCliente = false;
            btnAgregarCli.Enabled = false;
            btnEliminarCli.Enabled = false;
        }

        private Cliente? BuscarCliente(string codigoCliente)
        {
            try
            {
                Cliente? cliente = Cliente.ObtenerClientePorCodigo(codigoCliente);
                if (cliente == null)
                {
                    existeElCliente = false;
                    MessageBox.Show("El cliente no existe.", "No Encontrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                existeElCliente = false;
                return null;
            }
        }

        private void GuardarCliente(Cliente cliente)
        {
            try
            {
                if (existeElCliente)
                {
                    ModificarClientes(cliente);
                    CargarClientes();
                }
                else if (cliente.InsertarCliente())
                {
                    MessageBox.Show("Cliente guardado exitosamente", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            existeElCliente = false;
            btnAgregarCli.Enabled = false;
            btnEliminarCli.Enabled = false;
        }

        private void EliminarCliente(Cliente cliente)
        {
            try
            {
                string codigoCliente = cliente.CodigoCliente;
                if (Cliente.eliminarCliente(codigoCliente))
                {
                    MessageBox.Show("Cliente eliminado exitosamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el cliente.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            existeElCliente = false;
            btnAgregarCli.Enabled = false;
            btnEliminarCli.Enabled = false;
        }

        private void btnVolverMenuPrincipal_Click(object? sender, EventArgs e)
        {
            formMenuPrincipal.Show();
            this.Close();
        }

        private void EventoMoverConEnter(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                Control? origen = sender as Control;

                // Si el botón Agregar está habilitado y foco está en la última caja, activar Agregar
                if (btnAgregarCli.Enabled && origen == inpObsCliente)
                {
                    btnAgregarCli.PerformClick();
                    return;
                }

                this.SelectNextControl(origen, true, true, true, true);
            }
        }

        private Cliente ObtenerClienteEnInputs()
        {
            return new Cliente(inpCodCliente.Text, inpNomCliente.Text, inpDirCliente.Text, inpCiuCliente.Text, inpTelCliente.Text)
            {
                ApellidoCliente = inpApeCliente.Text,
                SectorCliente = inpSecCliente.Text,
                FaxCliente = inpFaxCliente.Text,
                LimiteCreditoCliente = string.IsNullOrWhiteSpace(inpCredCliente.Text) ? 0 : Convert.ToSingle(inpCredCliente.Text),
                BalanceActualCliente = string.IsNullOrWhiteSpace(inpBalCliente.Text) ? 0 : Convert.ToSingle(inpBalCliente.Text),
                ObservacionesCliente = inpObsCliente.Text
            };
        }

        private void btnAgregarCli_Click(object? sender, EventArgs e)
        {
            cliente = ObtenerClienteEnInputs();
            GuardarCliente(cliente);

            // Limpiar casillas después de agregar
            inpCodCliente?.Clear();
            inpNomCliente?.Clear();
            inpApeCliente?.Clear();
            inpDirCliente?.Clear();
            inpSecCliente?.Clear();
            inpCiuCliente?.Clear();
            inpTelCliente?.Clear();
            inpFaxCliente?.Clear();
            inpCredCliente?.Clear();
            inpBalCliente?.Clear();
            inpObsCliente?.Clear();

            inpCodCliente?.Focus();
        }

        // Delegadores (si el diseñador enlaza los métodos con sufijo "_1")
        private void btnAgregarCli_Click_1(object sender, EventArgs e) => btnAgregarCli_Click(sender, e);

        private void btnEliminarCli_Click(object? sender, EventArgs e)
        {
            // Obtener cliente desde inputs si no se buscó antes
            cliente = ObtenerClienteEnInputs();
            EliminarCliente(cliente);
        }

        private void btnEliminarCli_Click_1(object sender, EventArgs e) => btnEliminarCli_Click(sender, e);

        private void btnModificarCliente_Click(object? sender, EventArgs e)
        {
            // Obtener datos actuales y modificar
            cliente = ObtenerClienteEnInputs();
            ModificarClientes(cliente);
        }

        private void btnBuscarCli_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inpCodCliente.Text)) return;

            cliente = BuscarCliente(inpCodCliente.Text);
            if (cliente != null)
            {
                inpNomCliente.Text = cliente.NombreCliente;
                inpApeCliente.Text = cliente.ApellidoCliente;
                inpDirCliente.Text = cliente.DireccionCliente;
                inpSecCliente.Text = cliente.SectorCliente;
                inpCiuCliente.Text = cliente.CiudadCliente;
                inpTelCliente.Text = cliente.TelefonoCliente;
                inpFaxCliente.Text = cliente.FaxCliente;
                inpCredCliente.Text = cliente.LimiteCreditoCliente.ToString();
                inpBalCliente.Text = cliente.BalanceActualCliente.ToString();
                inpObsCliente.Text = cliente.ObservacionesCliente;
                existeElCliente = true;
            }
            else
            {
                existeElCliente = false;

                // Limpiar campos si no existe
                inpNomCliente.Clear();
                inpApeCliente.Clear();
                inpDirCliente.Clear();
                inpSecCliente.Clear();
                inpCiuCliente.Clear();
                inpTelCliente.Clear();
                inpFaxCliente.Clear();
                inpCredCliente.Clear();
                inpBalCliente.Clear();
                inpObsCliente.Clear();
            }

            btnAgregarCli.Enabled = true;
            btnEliminarCli.Enabled = existeElCliente;

            inpNomCliente?.Focus();
        }
    }
}