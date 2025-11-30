using Helpers;
using System;
using System.Windows.Forms;
using SistemaVentas.Utilidades; 

namespace SistemaVentas
{
    public partial class MenuClientes : Form
    {
        private Resizer resizer = new Resizer();

        Cliente? cliente = new Cliente();
        bool existeElCliente = false;
        MenuPrincipal formMenuPrincipal; // variable de referencia al formulario principal

        public MenuClientes(MenuPrincipal MenuPrincipal)
        {
            InitializeComponent(); // Inicializa los componentes gráficos del formulario

            // Aplicar botones y pasar el handler que gestiona Editar/Eliminar
            GridHelper.AplicarBotonesEditarEliminar(dgvClientes, DgvClientes_ButtonClick);

            // Inicializar resizer antes de cualquier cambio de tamaño y suscribir el evento Resize
            resizer.CaptureOriginalSizes(this);
            this.Resize += MenuClientes_Resize;

            formMenuPrincipal = MenuPrincipal; // Guarda la referencia del formulario principal que abrió este formulario
            CargarClientes();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Aplicar redondeo a todos los controles excepto los TextBox
            ApplyRoundedExceptTextBoxes(this, 12);

            // Asignar handler KeyDown a todos los TextBox (recursivo para controles anidados)
            AttachKeyDownToTextBoxes(this);

            // Cuando el formulario se muestre, establecer el foco en la primera casilla de texto
            this.Shown += Form2_Shown;
        }

        private void MenuClientes_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
        }

        // Recorre recursivamente el árbol de controles y aplica el helper salvo a los TextBox
        private void ApplyRoundedExceptTextBoxes(Control parent, int radius)
        {
            if (parent == null) return;

            foreach (Control c in parent.Controls)
            {
                if (c is TextBox) 
                {
                    // No redondear TextBox
                }
                else
                {
                    // Aplicar el redondeo usando la clase existente
                    RoundedControlHelper.RedondearBordes(c, radius);
                }

                if (c.HasChildren)
                {
                    ApplyRoundedExceptTextBoxes(c, radius);
                }
            }
        }

        // Añadido: asigna el evento KeyDown a todos los TextBox, incluso dentro de contenedores
        private void AttachKeyDownToTextBoxes(Control parent)
        {
            if (parent == null) return;

            foreach (Control c in parent.Controls)
            {
                if (c is TextBox txt)
                {
#pragma warning disable CS8622
                    txt.KeyDown += EventoMoverConEnter;
#pragma warning restore CS8622
                }

                if (c.HasChildren)
                {
                    AttachKeyDownToTextBoxes(c);
                }
            }
        }

        private void Form2_Shown(object? sender, EventArgs e)
        {
            // Ajustar el nombre del control si la primera caja no es `inpCodCliente`
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

        // Busca clientes mediante el codigo del cliente
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
                    return null;
                }
                existeElCliente = true;
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
                    // La modificación ha sido eliminada; informar al usuario
                    MessageBox.Show("El cliente ya existe. La modificación ha sido deshabilitada.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (cliente.InsertarCliente())
                {
                    MessageBox.Show("Cliente guardado exitosamente", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes(); // Recarga la lista de clientes después de agregar uno
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            existeElCliente = false;
            btnAgregarCliente.Enabled = false;
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
                    CargarClientes(); // Recarga la lista de clientes después de eliminar uno
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
            btnAgregarCliente.Enabled = false;
            btnEliminarCli.Enabled = false;
        }

        // Evento del botón para volver al menú principal
        private void BtnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.Show(); // Muestra el formulario principal nuevamente
            this.Close(); //Cierra el formulario actual de clientes
        }
        private void EventoMoverConEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || !(sender is Control control))
                return;

            // Si es TextBox multiline, dejar que el Enter inserte nueva línea
            if (control is TextBox tb && tb.Multiline)
                return;

            e.SuppressKeyPress = true; // evita sonido y salto de línea

            // Si el control es la caja de código del cliente, validar existencia antes de avanzar
            if (control == inpCodCliente)
            {
                // Requiere que haya texto para validar existencia
                if (string.IsNullOrWhiteSpace(inpCodCliente?.Text))
                {
                    MessageBox.Show("Debe introducir el código del cliente antes de continuar.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inpCodCliente?.Focus();
                    return; // NO avanzar si está vacío
                }

                // Buscar el cliente directamente (no pulsar el botón)
                Cliente? encontrado = BuscarCliente(inpCodCliente.Text);

                if (encontrado != null)
                {
                    // Si existe, rellenar campos y avanzar al siguiente control (nombre)
                    inpNomCliente.Text = encontrado.NombreCliente;
                    inpApeCliente.Text = encontrado.ApellidoCliente;
                    inpDirCliente.Text = encontrado.DireccionCliente;
                    inpSecCliente.Text = encontrado.SectorCliente;
                    inpCiuCliente.Text = encontrado.CiudadCliente;
                    inpTelCliente.Text = encontrado.TelefonoCliente;
                    inpFaxCliente.Text = encontrado.FaxCliente;
                    inpCredCliente.Text = encontrado.LimiteCreditoCliente.ToString();
                    inpBalCliente.Text = encontrado.BalanceActualCliente.ToString();
                    inpObsCliente.Text = encontrado.ObservacionesCliente;

                    btnEliminarCli.Enabled = true;
                    btnAgregarCliente.Enabled = true;

                    inpNomCliente?.Focus();
                    return;
                }

                // Si no existe, permitir crear uno nuevo: limpiar campos salvo el código, habilitar Agregar y avanzar
                MessageBox.Show("Cliente no encontrado. Puede crear uno nuevo introduciendo los datos.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                existeElCliente = false;
                btnAgregarCliente.Enabled = true;
                btnEliminarCli.Enabled = false;

                inpNomCliente?.Focus();
                return;
            }

            // Comportamiento por defecto para otros controles: avanzar al siguiente control
            this.SelectNextControl(control, true, true, true, true);
        }

        private Cliente ObtenerClienteEnInputs()
        {
            return new Cliente(inpCodCliente.Text, inpNomCliente.Text, inpDirCliente.Text, inpCiuCliente.Text, inpTelCliente.Text)
            {
                ApellidoCliente = inpApeCliente.Text,
                SectorCliente = inpSecCliente.Text,
                FaxCliente = inpFaxCliente.Text,
                LimiteCreditoCliente = string.IsNullOrWhiteSpace(inpCredCliente.Text)
                    ? 0
                    : Convert.ToSingle(inpCredCliente.Text),
                BalanceActualCliente = string.IsNullOrWhiteSpace(inpBalCliente.Text)
                    ? 0
                    : Convert.ToSingle(inpBalCliente.Text),
                ObservacionesCliente = inpObsCliente.Text
            };
        }


        private void btnAgregarCliente_Click(object sender, EventArgs e)
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

            // Poner foco en la primera casilla
            inpCodCliente?.Focus();
        }

        private void btnEliminarCli_Click(object sender, EventArgs e)
        {
            if (cliente == null) return;
            EliminarCliente(cliente);
        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            // Validar que se ha introducido un código antes de buscar
            if (string.IsNullOrWhiteSpace(inpCodCliente?.Text))
            {
                MessageBox.Show("Debe introducir el código del cliente a buscar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpCodCliente?.Focus();
                return;
            }

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
            }


            btnEliminarCli.Enabled = existeElCliente;
            btnAgregarCliente.Enabled = true;

            // Mover el cursor automáticamente a la segunda casilla (nombre)
            inpNomCliente?.Focus();
        }

        // Handler que conecta los botones del grid con la lógica del formulario
        private void DgvClientes_ButtonClick(DataGridView grid, DataGridViewCellEventArgs e)
        {
            string? accion = GridHelper.DetectarBoton(grid, e, 24, 8, 4);
            if (accion == null) return;

            // Obtener la fila seleccionada
            if (e.RowIndex < 0) return;
            var fila = grid.Rows[e.RowIndex];

            // Intentar leer el código desde la columna CODCLI u otra columna visible
            string codigo = string.Empty;
            if (fila.Cells["CODCLI"] != null && fila.Cells["CODCLI"].Value != null)
                codigo = fila.Cells["CODCLI"].Value.ToString() ?? string.Empty;
            else
            {
                // fallback: primera columna con valor no nulo
                foreach (DataGridViewCell c in fila.Cells)
                {
                    if (c.Value != null)
                    {
                        codigo = c.Value.ToString() ?? string.Empty;
                        break;
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(codigo))
                return;

            if (accion == "Editar")
            {
                // Cargar desde BD para mantener la lógica de validación y tipos
                Cliente? encontrado = Cliente.ObtenerClientePorCodigo(codigo);
                if (encontrado == null)
                {
                    MessageBox.Show("No se pudo cargar el cliente seleccionado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cliente = encontrado;
                existeElCliente = true;

                inpCodCliente.Text = encontrado.CodigoCliente;
                inpNomCliente.Text = encontrado.NombreCliente;
                inpApeCliente.Text = encontrado.ApellidoCliente;
                inpDirCliente.Text = encontrado.DireccionCliente;
                inpSecCliente.Text = encontrado.SectorCliente;
                inpCiuCliente.Text = encontrado.CiudadCliente;
                inpTelCliente.Text = encontrado.TelefonoCliente;
                inpFaxCliente.Text = encontrado.FaxCliente;
                inpCredCliente.Text = encontrado.LimiteCreditoCliente.ToString();
                inpBalCliente.Text = encontrado.BalanceActualCliente.ToString();
                inpObsCliente.Text = encontrado.ObservacionesCliente;

                btnEliminarCli.Enabled = true;
                btnAgregarCliente.Enabled = true;

                inpNomCliente?.Focus();
            }
            else if (accion == "Eliminar")
            {
                var confirm = MessageBox.Show("¿Desea eliminar el cliente seleccionado?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;

                bool eliminado = Cliente.eliminarCliente(codigo);
                if (eliminado)
                {
                    MessageBox.Show("Cliente eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}