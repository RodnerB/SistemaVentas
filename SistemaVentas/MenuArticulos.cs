using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using SistemaVentas.Utilidades;

namespace SistemaVentas
{
    public partial class MenuArticulos : Form
    {
        Articulo? articulo = new Articulo();
        bool existeElArticulo = false;
        MenuPrincipal? formMenuPrincipal; // ahora nullable para soportar diseñador
        private readonly UtilidadesUI resizer = new UtilidadesUI();

        private Control? ultimoControlConFoco;

        public MenuArticulos(MenuPrincipal? MenuPrincipal = null)
        {
            InitializeComponent();

            formMenuPrincipal = MenuPrincipal;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Asegurar que el botón "volver" ejecute el handler (si existe en el diseñador)
            if (btnVolverMenuPrincipal is not null)
                btnVolverMenuPrincipal.Click += BtnVolverMenuPrincipal_Click;

            // Evitar ejecutar lógica que puede fallar en tiempo de diseño
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                // Inicializar resizer antes de cualquier cambio de tamaño
                resizer.CaptureOriginalSizes(this);
                this.Resize += MenuArticulos_Resize;

                // Inicializar estados de los botones: solo Buscar y Volver habilitados
                btnGuardarArt.Enabled = false;
                btnBuscarArt.Enabled = true;
                if (btnVolverMenuPrincipal is not null)
                    btnVolverMenuPrincipal.Enabled = true;

                // Permitir que Enter active el botón de agregar cuando esté habilitado
                this.AcceptButton = btnGuardarArt;

                CargarArticulos();
                CargarUnidades(); // <-- Asegurar que el combo se llene al crear el formulario

                // Asegurar que el primer cuadro de texto reciba el foco cuando el formulario se muestre
                this.Shown += Form3_Shown;

                // Aplicar redondeos pero NUNCA al formulario (NO modificar this.Region)
                UtilidadesUI.ApplyRoundedExceptTextBoxes(this, 12);
                AttachKeyDownToTextBoxes(this);
            }
            else
            {
                // En modo diseño evitar acceso a recursos o datos; pero conservar estados básicos si es necesario
                btnGuardarArt.Enabled = false;
            }

            inpExiMin.KeyPress += ValidarSoloNumerosKeyPress;
            inpExiMax.KeyPress += ValidarSoloNumerosKeyPress;
            inpExiAct.KeyPress += ValidarSoloNumerosKeyPress;
            inpPreArt.KeyPress += ValidarSoloNumerosKeyPress;
            inpCosArt.KeyPress += ValidarSoloNumerosKeyPress;
            inpDesArt.KeyPress += validarSoloLetras;
        }

        private void MenuArticulos_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
        }

        private void Form3_Shown(object? sender, EventArgs e)
        {
            // Ajustar el nombre del control si el primer textbox tiene otro nombre
            inpCodArt?.Focus();
            ultimoControlConFoco = inpCodArt;
        }

        private void MostrarAdvertenciasCampoVacio(string mensaje, Control? controlFoco = null)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Control? objetivo = controlFoco ?? ultimoControlConFoco;

            if (objetivo is not null)
            {
                this.BeginInvoke(() => objetivo.Focus());
            }
        }

        // Asigna el evento KeyDown a todos los TextBox, incluso dentro de contenedores
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

        // activar o desactivar texto de los inputs
        private void activarInputs(bool activar)
        {
            inpCodArt.Enabled = !activar;
            inpDesArt.Enabled = activar;
            cmbCodUni.Enabled = activar;
            inpExiMin.Enabled = activar;
            inpExiMax.Enabled = activar;
            inpExiAct.Enabled = activar;
            inpPreArt.Enabled = activar;
            inpCosArt.Enabled = activar;

            btnBuscarArt.Enabled = !activar;
            btnGuardarArt.Enabled = activar;
            btnCancelar.Enabled = activar;
        }

        // Handler para volver al menú principal
        private void BtnVolverMenuPrincipal_Click(object? sender, EventArgs e)
        {
            formMenuPrincipal?.Show(); // Muestra el formulario principal nuevamente
            this.Close(); //Cierra el formulario actual de artículos
        }

        // Método para cargar los artículos en el DataGridView
        private void CargarArticulos()
        {
            try
            {
                Articulo.CargarArticulosGridConFilas(dgvArticulos); // Llama al método estático para cargar los artículos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar artículos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private Articulo? BuscarArticulo(string codigoArticulo)
        {
            try
            {
                Articulo? articulo = Articulo.ObtenerArticuloPorCodigo(codigoArticulo);
                if (articulo == null)
                {
                    existeElArticulo = false;
                    MessageBox.Show("El artículo no existe.", "No encontrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    existeElArticulo = true;
                }
                return articulo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                existeElArticulo = false;
                return null;
            }
        }

        private void GuardarArticulo(Articulo articulo)
        {
            try
            {
                articulo.existe = existeElArticulo;
                if (articulo.InsertarArticulo())
                {
                    MessageBox.Show("Artículo guardado existosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarArticulos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            existeElArticulo = false;
            cmbCodUni.SelectedIndex = 0;
        }
        /*
        private void EliminarArticulo(Articulo articulo)
        {
            try
            {
                string codigoArticulo = articulo.CodigoArticulo;
                if (Articulo.EliminarArticulo(codigoArticulo))
                {
                    MessageBox.Show("Artículo eliminado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarArticulos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el artículo.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            existeElArticulo = false;
            btnGuardarArt.Enabled = false;
        }*/

        private void EventoMoverConEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || !(sender is Control control))
                return;

            e.SuppressKeyPress = true; // salto de línea

            // Comportamiento por defecto para otros controles: avanzar al siguiente control
            this.SelectNextControl(control, true, true, true, true);
        }
        private void CargarUnidades()
        {
            DataTable tabla = UnidadesMedida.ObtenerListadoCodigos();

            DataRow fila = tabla.NewRow();
            fila["CODUNI"] = "";
            fila["DESUNI"] = "Seleccione una unidad";
            tabla.Rows.InsertAt(fila, 0);

            // Cargar la tabla en el combo
            cmbCodUni.DataSource = tabla;
            cmbCodUni.DisplayMember = "DESUNI";
            cmbCodUni.ValueMember = "CODUNI";

            cmbCodUni.SelectedIndex = 0; // Se asegura de que empiece en "Seleccione una unidad"
        }

        private Articulo ObtenerArticuloEnText()
        {
            return new Articulo()
            {
                CodigoArticulo = inpCodArt.Text,
                DescripcionArticulo = inpDesArt.Text,
                CodigoUnidad = cmbCodUni.SelectedValue?.ToString() ?? "",
                ExistenciaMinima = string.IsNullOrWhiteSpace(inpExiMin.Text) ? 0 : Convert.ToSingle(inpExiMin.Text),
                ExistenciaMaxima = string.IsNullOrWhiteSpace(inpExiMax.Text) ? 0 : Convert.ToSingle(inpExiMax.Text),
                ExistenciaActual = string.IsNullOrWhiteSpace(inpExiAct.Text) ? 0 : Convert.ToSingle(inpExiAct.Text),
                PrecioArticulo = string.IsNullOrWhiteSpace(inpPreArt.Text) ? 0 : Convert.ToSingle(inpPreArt.Text),
                CostoArticulo = string.IsNullOrWhiteSpace(inpCosArt.Text) ? 0 : Convert.ToSingle(inpCosArt.Text)
            };
        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            if (!Validaciones())
                return;

            articulo = ObtenerArticuloEnText();

            if (articulo == null)
                return;

            GuardarArticulo(articulo);

            // Limpiar casillas después de agregar y restablecer combo
            activarInputs(false);
            limpiarInputs();
            if (cmbCodUni?.Items.Count > 0)
            {
                cmbCodUni.SelectedIndex = 0;
            }

            // Poner foco en la primera casilla
            inpCodArt?.Focus();
        }

        // Mantener un handler vacío/informativo por si el diseñador sigue enlazando el evento
        private void btnModificarArt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La funcionalidad de modificar artículos ha sido eliminada.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarArt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inpCodArt.Text))
            {
                MostrarAdvertenciasCampoVacio("Debe introducir el código del artículo a buscar.", inpCodArt);
                return;
            }

            articulo = BuscarArticulo(inpCodArt.Text);

            // Siempre habilitar los inputs después de buscar (encuentre o no el artículo)
            activarInputs(true);
            btnGuardarArt.Enabled = true;

            if (articulo != null)
            {
                // Rellenar los controles de la interfaz con los datos del artículo
                inpDesArt.Text = articulo.DescripcionArticulo;
                cmbCodUni.SelectedValue = articulo.CodigoUnidad;
                inpExiMin.Text = articulo.ExistenciaMinima.ToString();
                inpExiMax.Text = articulo.ExistenciaMaxima.ToString();
                inpExiAct.Text = articulo.ExistenciaActual.ToString();
                inpPreArt.Text = articulo.PrecioArticulo.ToString("0.##");
                inpCosArt.Text = articulo.CostoArticulo.ToString("0.##");
            }

            // Mover el cursor automáticamente a la segunda casilla (descripción)
            inpDesArt?.Focus();
            ultimoControlConFoco = inpDesArt;
        }

        private void MenuArticulos_Load(object sender, EventArgs e)
        {
            CargarArticulos();
            activarInputs(false);
        }

        private void ValidarSoloNumerosKeyPress(object? sender, KeyPressEventArgs e)
        {
            Validador.validarSoloNumeros(sender, e);
        }

        public static void validarSoloLetras(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            activarInputs(false);
            limpiarInputs();
        }

        private void limpiarInputs()
        {
            inpCodArt.Clear();
            inpDesArt.Clear();
            inpExiMin.Clear();
            inpExiMax.Clear();
            inpExiAct.Clear();
            inpPreArt.Clear();
            inpCosArt.Clear();
            cmbCodUni.SelectedIndex = 0;
        }

        private bool Validaciones()
        {
            if (!Validador.ValidarTamanoPermitido(inpDesArt.Text, 40))
            {
                MessageBox.Show("Debe introducir una descripción.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Validador.ValidarTamanoPermitido(inpCodArt.Text, 20))
            {
                MessageBox.Show("Debe de introducir un código de artículo válido de máximo 20 caracteres.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbCodUni.SelectedValue?.ToString()))
            {
                MessageBox.Show("Debe de seleccionar una unidad de medida.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar existencias
            int exiMin = string.IsNullOrWhiteSpace(inpExiMin.Text) ? 0 : Convert.ToInt32(inpExiMin.Text);
            int exiMax = string.IsNullOrWhiteSpace(inpExiMax.Text) ? 0 : Convert.ToInt32(inpExiMax.Text);
            int exiAct = string.IsNullOrWhiteSpace(inpExiAct.Text) ? 0 : Convert.ToInt32(inpExiAct.Text);

            // Validar que la existencia máxima sea mayor que la mínima
            if (!Validador.EsCantidadMenorAlTope(exiMax, exiMin))
            {
                MessageBox.Show("La existencia máxima debe ser mayor que la existencia mínima.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpExiMax.Focus();
                return false;
            }

            // Validar que la existencia actual esté dentro del rango
            if (!Validador.EsCantidadMenorAlTope(exiAct, exiMin))
            {
                MessageBox.Show("La existencia actual no puede ser menor que la existencia mínima.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpExiAct.Focus();
                return false;
            }

            if (!Validador.EsCantidadMenorAlTope(exiMax, exiAct))
            {
                MessageBox.Show("La existencia actual no puede ser mayor que la existencia máxima.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpExiAct.Focus();
                return false;
            }

            return true;
        }
    }
}