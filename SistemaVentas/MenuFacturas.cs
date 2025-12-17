using System;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using SistemaVentas.Utilidades;

namespace SistemaVentas
{
    public partial class MenuFacturas : Form
    {
        private UtilidadesUI resizer = new UtilidadesUI();

        MenuPrincipal formMenuPrincipal; // variable de referencia al formulario principal

        // Estado relativo al cliente seleccionado/buscado
        private Cliente? cliente = null;
        private bool clienteBuscado = false;

        private Factura? facturaBuscada = null;
        private bool facturaEncontrada = false;

        // Guarda el último control que tuvo el foco (para restaurarlo tras un MessageBox)
        private Control? ultimoControlConFoco;

        // Constructor que recibe una referencia al formulario principal
        public MenuFacturas(MenuPrincipal MenuPrincipal)
        {
            InitializeComponent();  // Inicializa los componentes gráficos del formulario

            formMenuPrincipal = MenuPrincipal;  // Guarda la referencia del formulario principal que abrió este formulario


            // Inicializar resizer y suscribir evento Resize
            resizer.CaptureOriginalSizes(this);
            this.Resize += MenuFacturas_Resize;

            CargarFacturas(); // Carga las facturas en el DataGridView al iniciar el formulario

            // Intentar establecer SelectedIndex de cmbCondicion si existe en tiempo de ejecución
            var cbCond = this.Controls.Find("cmbCondicion", true).FirstOrDefault() as ComboBox;
            if (cbCond != null && cbCond.Items.Count > 0)
                cbCond.SelectedIndex = 0;

            ObtenerClientesComboBox();

            // Suscribir eventos que controlan si se puede habilitar el botón Agregar
            var cbCliente = this.Controls.Find("cmbCodCliente", true).FirstOrDefault() as ComboBox;
            if (cbCliente != null)
                cbCliente.SelectedIndexChanged += CmbCodCliente_SelectedIndexChanged;

            var txtNumFac = this.Controls.Find("inpNumFactura", true).FirstOrDefault() as TextBox;
            if (txtNumFac != null)
                txtNumFac.TextChanged += InputsChanged;

            // Asignar handler KeyDown a todos los TextBox (recursivo para controles anidados)
            AttachKeyDownToTextBoxes(this);

            // Aplicar redondeo a todos los controles excepto los TextBox
            UtilidadesUI.ApplyRoundedExceptTextBoxes(this, 12);

            // Evitar subrayado azul en el DateTimePicker al recibir foco
            var dt = this.Controls.Find("inpDateTime", true).FirstOrDefault() as DateTimePicker;
            if (dt is not null)
                dt.GotFocus += (s, e) => dt.Select();

            // Cuando el formulario se muestre, establecer el foco en la primera casilla de texto
            this.Shown += MenuFacturas_Shown;

            this.StartPosition = FormStartPosition.CenterScreen;

            dgvFacturas.CellContentClick += dgvFacturas_CellContentClick;

            // Inicializar botón Ver Detalles deshabilitado
            var btnVerDetalles = this.Controls.Find("btnVerDetalles", true).FirstOrDefault() as Button;
            if (btnVerDetalles != null)
            {
                btnVerDetalles.Enabled = false;
                btnVerDetalles.Click += btnVerDetalles_Click; // Conectar el evento
            }
        }

        private void dgvFacturas_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvFacturas.Columns[e.ColumnIndex].Name == "colAccion")
            {
                var cellValue = dgvFacturas.Rows[e.RowIndex].Cells["colNumeroFactura"].Value;
                if (cellValue == null || cellValue == DBNull.Value)
                {
                    MessageBox.Show("Número de factura inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(cellValue.ToString(), out int datoFactura))
                {
                    MessageBox.Show("Número de factura no es un entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var form = new MenuDetallesFactura(datoFactura))
                {
                    form.ShowDialog();
                }
            }
        }


        private void MenuFacturas_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
        }

        private void MenuFacturas_Shown(object? sender, EventArgs e)
        {
            // Poner foco en el número de factura al mostrar (si existe)
            var txtNum = inpNumeroFactura;
            txtNum?.Focus();
            ultimoControlConFoco = txtNum;
        }


        private void CargarFacturas() => Factura.CargarFacturasEnGridConFilas(dgvFacturas);

        // Método para obtener los datos de entrada y crear un objeto Factura
        private Factura obtenerFacturaInputs()
        {
            var txtDesc = this.Controls.Find("inpDescFactura", true).FirstOrDefault() as TextBox;
            var txtMon = this.Controls.Find("inpMonFactura", true).FirstOrDefault() as TextBox;
            var txtNum = this.Controls.Find("inpNumFactura", true).FirstOrDefault() as TextBox;
            var dt = this.Controls.Find("inpDateTime", true).FirstOrDefault() as DateTimePicker;
            var cbCliente = this.Controls.Find("cmbCodCliente", true).FirstOrDefault() as ComboBox;
            var cbCond = this.Controls.Find("cmbCondicion", true).FirstOrDefault() as ComboBox;

            float descuento = string.IsNullOrWhiteSpace(txtDesc?.Text) ? 0 : float.Parse(txtDesc.Text);
            float montoFactura = string.IsNullOrWhiteSpace(txtMon?.Text) ? 0 : float.Parse(txtMon.Text);
            int numero = 0;
            if (!string.IsNullOrWhiteSpace(txtNum?.Text))
                int.TryParse(txtNum.Text, out numero);

            string codigoCliente = cbCliente?.SelectedValue?.ToString() ?? "";
            string condicion = (cbCond?.Text == "Contado") ? "1" : "2";
            DateTime fecha = dt?.Value ?? DateTime.Now;

            return new Factura(
                numero,
                fecha,
                codigoCliente,
                condicion,
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

            var cbCliente = this.Controls.Find("cmbCodCliente", true).FirstOrDefault() as ComboBox;
            if (cbCliente == null) return;

            cbCliente.DataSource = tablaClientes;
            cbCliente.DisplayMember = "NOMCLI"; // Muestra el nombre del cliente
            cbCliente.ValueMember = "CODCLI"; // Usa el código del cliente como valor

            // Asegurar SelectedIndex seguro
            if (cbCliente.Items.Count > 0)
                cbCliente.SelectedIndex = 0;

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
            var txtNum = this.Controls.Find("inpNumFactura", true).FirstOrDefault() as TextBox;
            var cbCliente = this.Controls.Find("cmbCodCliente", true).FirstOrDefault() as ComboBox;
            var btnAgregar = this.Controls.Find("btnAgregarFac", true).FirstOrDefault() as Button;

            bool tieneNumero = !string.IsNullOrWhiteSpace(txtNum?.Text);
            bool clienteSeleccionado = cbCliente?.SelectedValue != null && !string.IsNullOrWhiteSpace(cbCliente.SelectedValue.ToString());

            if (btnAgregar != null)
                btnAgregar.Enabled = tieneNumero && clienteSeleccionado && clienteBuscado;
        }

        private void CmbCodCliente_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Obtener el combo desde el sender o por búsqueda
            var cb = sender as ComboBox ?? this.Controls.Find("cmbCodCliente", true).FirstOrDefault() as ComboBox;
            if (cb == null)
            {
                cliente = null;
                clienteBuscado = false;
                UpdateAgregarButtonState();
                return;
            }

            string? codigo = cb.SelectedValue?.ToString();
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
            if (control.Name == "inpNumFactura")
            {
                var txtNum = control as TextBox;
                if (string.IsNullOrWhiteSpace(txtNum?.Text))
                {
                    MostrarAdvertenciaCampoVacio("Debe introducir el número de factura antes de continuar.", control);
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

        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            // Validar que se ha introducido un número de factura
            if (string.IsNullOrWhiteSpace(inpNumeroFactura?.Text))
            {
                MostrarAdvertenciaCampoVacio("Debe introducir el número de factura a buscar.", inpNumeroFactura);
                facturaEncontrada = false;
                var btnVerDetalles = this.Controls.Find("btnVerDetalles", true).FirstOrDefault() as Button;
                if (btnVerDetalles != null)
                    btnVerDetalles.Enabled = false;
                return;
            }

            // Buscar la factura
            facturaBuscada = Factura.ObtenerFacturaPorCodigo(inpNumeroFactura.Text);

            if (facturaBuscada != null)
            {
                // Factura encontrada
                facturaEncontrada = true;
                MessageBox.Show("Factura encontrada exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Factura no encontrada
                facturaEncontrada = false;
                MessageBox.Show("Factura no encontrada.", "No encontrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Actualizar estado del botón Ver Detalles
            var btnVer = this.Controls.Find("btnVerDetalles", true).FirstOrDefault() as Button;
            if (btnVer != null)
                btnVer.Enabled = facturaEncontrada;
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            if (facturaBuscada != null)
            {
                using (var form = new MenuDetallesFactura(facturaBuscada.numeroFactura))
                {
                    form.ShowDialog();
                }

                // Limpiar el textBox y resetear el estado
                inpNumeroFactura?.Clear();
                facturaBuscada = null;
                facturaEncontrada = false;

                // Deshabilitar el botón Ver Detalles
                var btnVerDetalles = this.Controls.Find("btnVerDetalles", true).FirstOrDefault() as Button;
                if (btnVerDetalles != null)
                    btnVerDetalles.Enabled = false;

                // Devolver el foco al textBox
                inpNumeroFactura?.Focus();
            }
        }
    }
}
