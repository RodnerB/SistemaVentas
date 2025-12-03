using System;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;
using SistemaVentas.Utilidades;

namespace SistemaVentas
{
    public partial class MenuFacturas : Form
    {
        private Resizer resizer = new Resizer();

        MenuPrincipal formMenuPrincipal; // variable de referencia al formulario principal

        // Estado relativo al cliente seleccionado/buscado
        private Cliente? cliente = null;
        private bool clienteBuscado = false;

        // Guarda el último control que tuvo el foco (para restaurarlo tras un MessageBox)
        private Control? ultimoControlConFoco;

        // Constructor que recibe una referencia al formulario principal
        public MenuFacturas(MenuPrincipal MenuPrincipal)
        {
            InitializeComponent();  // Inicializa los componentes gráficos del formulario

            formMenuPrincipal = MenuPrincipal;  // Guarda la referencia del formulario principal que abrió este formulario

            // Estado inicial: deshabilitar el botón hasta que se cumplan condiciones
            btnAgregarFac.Enabled = false;

            // Inicializar resizer y suscribir evento Resize
            resizer.CaptureOriginalSizes(this);
            this.Resize += MenuFacturas_Resize;

            CargarFacturas(); // Carga las facturas en el DataGridView al iniciar el formulario
            cmbCondicion.SelectedIndex = 0;

            ObtenerClientesComboBox();

            // Suscribir eventos que controlan si se puede habilitar el botón Agregar
            cmbCodCliente.SelectedIndexChanged += CmbCodCliente_SelectedIndexChanged;
            inpNumFactura.TextChanged += InputsChanged;

            // Asignar handler KeyDown a todos los TextBox (recursivo para controles anidados)
            AttachKeyDownToTextBoxes(this);

            // Aplicar redondeo a todos los controles excepto los TextBox
            ApplyRoundedExceptTextBoxes(this, 12);

            // Evitar subrayado azul en el DateTimePicker al recibir foco
            if (inpDateTime is not null)
                inpDateTime.GotFocus += (s, e) => inpDateTime.Select();

            // Cuando el formulario se muestre, establecer el foco en la primera casilla de texto
            this.Shown += MenuFacturas_Shown;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MenuFacturas_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
        }

        private void MenuFacturas_Shown(object? sender, EventArgs e)
        {
            // Poner foco en el número de factura al mostrar
            inpNumFactura?.Focus();
            ultimoControlConFoco = inpNumFactura;
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
                cmbCodCliente.SelectedValue?.ToString() ?? "",
                cmbCondicion.Text == "Contado" ? "1" : "2",
                descuento,
                montoFactura
            );
        }

        private void ObtenerClientesComboBox()
        {
            // Lógica para obtener y cargar los clientes en el ComboBox
            DataTable tablaClientes = UtilidadesBD.ObtenerTodosLosRegistros("SELECT CODCLI, NOMCLI FROM SFTCLIE0") ?? new DataTable();

            // Asegurar esquema mínimo
            if (!tablaClientes.Columns.Contains("CODCLI")) tablaClientes.Columns.Add("CODCLI", typeof(string));
            if (!tablaClientes.Columns.Contains("NOMCLI")) tablaClientes.Columns.Add("NOMCLI", typeof(string));

            // Insertar placeholder al inicio
            DataRow fila = tablaClientes.NewRow();
            fila["CODCLI"] = "";
            fila["NOMCLI"] = "Seleccione un cliente";
            tablaClientes.Rows.InsertAt(fila, 0);

            cmbCodCliente.DataSource = tablaClientes;
            cmbCodCliente.DisplayMember = "NOMCLI"; // Muestra el nombre del cliente
            cmbCodCliente.ValueMember = "CODCLI"; // Usa el código del cliente como valor

            // Asegurar SelectedIndex seguro
            if (cmbCodCliente.Items.Count > 0)
                cmbCodCliente.SelectedIndex = 0;

            // Evaluar estado inicial del botón Agregar
            UpdateAgregarButtonState();
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

            // Después de insertar, resetear estado de búsqueda de cliente para exigir nueva búsqueda si procede
            clienteBuscado = false;
            UpdateAgregarButtonState();
        }

        // Actualiza el estado del botón "Agregar factura".
        // Ahora requiere: número de factura válido, cliente seleccionado y cliente previamente buscado/confirmado.
        private void UpdateAgregarButtonState()
        {
            bool tieneNumero = !string.IsNullOrWhiteSpace(inpNumFactura.Text);
            bool clienteSeleccionado = cmbCodCliente?.SelectedValue != null && !string.IsNullOrWhiteSpace(cmbCodCliente.SelectedValue.ToString());

            btnAgregarFac.Enabled = tieneNumero && clienteSeleccionado && clienteBuscado;
        }

        private void CmbCodCliente_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Cuando cambia la selección, si el valor no es el placeholder, intentar confirmar/buscar el cliente
            string? codigo = cmbCodCliente.SelectedValue?.ToString();
            if (!string.IsNullOrWhiteSpace(codigo))
            {
                Cliente? encontrado = BuscarCliente(codigo);
                if (encontrado != null)
                {
                    cliente = encontrado;
                    clienteBuscado = true;
                }
                else
                {
                    cliente = null;
                    clienteBuscado = false;
                }
            }
            else
            {
                cliente = null;
                clienteBuscado = false;
            }

            UpdateAgregarButtonState();
        }

        private void InputsChanged(object? sender, EventArgs e) => UpdateAgregarButtonState();

        // Buscar cliente por código usando la capa de dominio similar a MenuClientes
        private Cliente? BuscarCliente(string codigoCliente)
        {
            try
            {
                Cliente? c = Cliente.ObtenerClientePorCodigo(codigoCliente);
                if (c == null)
                {
                    clienteBuscado = false;
                    MessageBox.Show("El cliente no existe.", "No Encontrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }
                clienteBuscado = true;
                return c;
            }
            catch (Exception ex)
            {
                clienteBuscado = false;
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        // Recorre recursivamente el árbol de controles y asigna handler KeyDown a TextBox
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
                    txt.Enter += (s, e) => { ultimoControlConFoco = txt; };
                }

                if (c.HasChildren)
                    AttachKeyDownToTextBoxes(c);
            }
        }

        private void EventoMoverConEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || !(sender is Control control))
                return;

            // Si es TextBox multiline, dejar que el Enter inserte nueva línea
            if (control is TextBox tb && tb.Multiline)
                return;

            e.SuppressKeyPress = true; // evita sonido y salto de línea


            // Si el control es la caja de número de factura, validar antes de avanzar
            if (control == inpNumFactura)
            {
                if (string.IsNullOrWhiteSpace(inpNumFactura?.Text))
                {
                    MostrarAdvertenciaCampoVacio("Debe introducir el número de factura antes de continuar.", inpNumFactura);
                    return; // NO avanzar si está vacío
                }

                // Avanzar al siguiente control
                this.SelectNextControl(control, true, true, true, true);
                return;
            }

            // Comportamiento por defecto: avanzar al siguiente control
            this.SelectNextControl(control, true, true, true, true);
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

        // Aplica RoundedControlHelper a todos los controles excepto TextBox
        // CORRECCIÓN: nunca aplicar el helper al propio Form (evita modificar this.Region)
        private void ApplyRoundedExceptTextBoxes(Control parent, int radius)
        {
            if (parent == null) return;

            // Si el control es el formulario raíz, NO aplicamos RedondearBordes sobre él.
            // Solo procesamos sus hijos.
            if (parent is Form)
            {
                foreach (Control c in parent.Controls)
                {
                    if (c is not TextBox)
                    {
                        try
                        {
                            RoundedControlHelper.RedondearBordes(c, radius);
                        }
                        catch
                        {
                            // Ignorar errores para no romper el formulario
                        }
                    }

                    if (c.HasChildren)
                        ApplyRoundedExceptTextBoxes(c, radius);
                }

                return;
            }

            // Para controles que no son el Form, aplicar normalmente (excepto TextBox)
            if (parent is not TextBox)
            {
                try
                {
                    RoundedControlHelper.RedondearBordes(parent, radius);
                }
                catch
                {
                    // Ignorar errores del helper para no romper el formulario
                }
            }

            foreach (Control c in parent.Controls)
            {
                if (c is not TextBox)
                {
                    try
                    {
                        RoundedControlHelper.RedondearBordes(c, radius);
                    }
                    catch
                    {
                        // Ignorar por seguridad
                    }
                }

                if (c.HasChildren)
                    ApplyRoundedExceptTextBoxes(c, radius);
            }
        }
    }
}
