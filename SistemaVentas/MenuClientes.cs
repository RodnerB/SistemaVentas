using System;
using System.Windows.Forms;
using SistemaVentas.Utilidades; 

namespace SistemaVentas
{
    public partial class MenuClientes : Form
    {
        private readonly Resizer resizer = new Resizer();

        Cliente? cliente = new Cliente();
        bool existeElCliente = false;
        MenuPrincipal formMenuPrincipal; // variable de referencia al formulario principal

        // Nuevo: guarda el último control que tuvo el foco (para restaurarlo tras un MessageBox)
        private Control? ultimoControlConFoco;

        public MenuClientes(MenuPrincipal MenuPrincipal)
        {
            InitializeComponent(); // Inicializa los componentes gráficos del formulario

            // Asegurar que el botón Buscar esté habilitado y que tenga su handler
            if (btnBuscarCli is not null)
            {
                btnBuscarCli.Enabled = true;
                btnBuscarCli.Click += btnBuscarCli_Click;
            }

            // Capturar tamaños originales y suscribir resize
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
        // también suscribe Enter para registrar el último control con foco
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
                    // Registrar el control cuando reciba foco
                    txt.Enter += (s, e) => { ultimoControlConFoco = txt; };
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
            ultimoControlConFoco = inpCodCliente;
        }

        // Nuevo helper: mostrar advertencia por campo vacío sin borrar otros campos
        // y restaurar el foco en el último control con foco (o en controlAFocar si se pasa)
        private void MostrarAdvertenciaCampoVacio(string mensaje, Control? controlAFocar = null)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Priorizar el control pasado; si es null, usar el último control que tuvo foco
            Control? objetivo = controlAFocar ?? ultimoControlConFoco;

            // Restaurar foco (usar BeginInvoke para asegurarnos de que ocurra después del MessageBox)
            if (objetivo is not null)
            {
                this.BeginInvoke(() => objetivo.Focus());
            }
        }

        private void CargarClientes()
        {
            try
            {
                Cliente.CargarClientesEnGrid(dgvClientes);
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


        private bool GuardarCliente(Cliente cliente)
        {
            try
            {


                // Intentar insertar; InsertarCliente debe validar los campos y devolver false si faltan datos
                if (cliente.InsertarCliente())
                {
                    MessageBox.Show("Cliente guardado exitosamente", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes(); // Recarga la lista de clientes después de agregar uno

                    // Estado post-inserción
                    existeElCliente = false;
                    btnAgregarCliente.Enabled = false;
                    return true;
                }

                // Si InsertarCliente devolvió false, no hacer limpiezas; el método responsabiliza de mostrar mensajes
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
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
                    // Usar helper: muestra advertencia y mantiene otros campos intactos
                    MostrarAdvertenciaCampoVacio("Debe introducir el código del cliente antes de continuar.", inpCodCliente);
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

                    btnAgregarCliente.Enabled = true;

                    inpNomCliente?.Focus();
                    return;
                }

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


        private void btnAgregarCliente_Click(object? sender, EventArgs e)
        {
            cliente = ObtenerClienteEnInputs();

            // Intentar guardar; sólo limpiar campos si la inserción fue exitosa
            bool guardado = GuardarCliente(cliente);
            if (!guardado)
            {
                // No borrar los campos — deja los datos para que el usuario corrija
                // Asegurar que el foco vuelva al control donde estaba el cursor
                MostrarAdvertenciaCampoVacio("Faltan datos o validación fallida. Corrija los campos marcados.", null);
                return;
            }

            // Limpiar casillas después de agregar (solo si guardado con éxito)
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

        private void btnBuscarCli_Click(object? sender, EventArgs e)
        {
            // Validar que se ha introducido un código antes de buscar
            if (string.IsNullOrWhiteSpace(inpCodCliente?.Text))
            {
                // Usar helper para aviso por campo vacío sin borrar otros campos
                MostrarAdvertenciaCampoVacio("Debe introducir el código del cliente a buscar.", inpCodCliente);
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

            btnAgregarCliente.Enabled = true;

            // Mover el cursor automáticamente a la segunda casilla (nombre)
            inpNomCliente?.Focus();
            ultimoControlConFoco = inpNomCliente;
        }

        private void MenuClientes_Load(object sender, EventArgs e)
        {

        }
    }
}