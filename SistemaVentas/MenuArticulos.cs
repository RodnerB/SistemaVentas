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
        private Resizer resizer = new Resizer();

        // Constructor con referencia al formulario principal (opcional para el diseñador)
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
                btnAgregarArt.Enabled = false;
                btnBuscarArt.Enabled = true;
                if (btnVolverMenuPrincipal is not null)
                    btnVolverMenuPrincipal.Enabled = true;

                // Permitir que Enter active el botón de agregar cuando esté habilitado
                this.AcceptButton = btnAgregarArt;

                CargarArticulos();
                CargarUnidades(); // <-- Asegurar que el combo se llene al crear el formulario

                // Asegurar que el primer cuadro de texto reciba el foco cuando el formulario se muestre
                this.Shown += Form3_Shown;

                // Aplicar redondeos y asignar KeyDown recursivamente
                ApplyRoundedExceptTextBoxes(this, 12);
                AttachKeyDownToTextBoxes(this);
            }
            else
            {
                // En modo diseño evitar acceso a recursos o datos; pero conservar estados básicos si es necesario
                btnAgregarArt.Enabled = false;
            }
        }

        private void MenuArticulos_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
        }

        private void Form3_Shown(object? sender, EventArgs e)
        {
            // Ajustar el nombre del control si el primer textbox tiene otro nombre
            txtCodArt?.Focus();
        }

        // Recorre recursivamente el árbol de controles y aplica el helper salvo a los TextBox
        private void ApplyRoundedExceptTextBoxes(Control parent, int radius)
        {
            if (parent == null) return;

            // Aplicar al propio control si no es TextBox (por ejemplo: GroupBox, Panel, Button, ComboBox, etc.)
            if (parent is not TextBox)
            {
                try
                {
                    RoundedControlHelper.RedondearBordes(parent, radius);
                }
                catch
                {
                    // Si hay controles que el helper no puede procesar, ignorar para no romper el formulario
                }
            }

            foreach (Control c in parent.Controls)
            {
                if (c is not TextBox)
                {
                    RoundedControlHelper.RedondearBordes(c, radius);
                }

                if (c.HasChildren)
                    ApplyRoundedExceptTextBoxes(c, radius);
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
                }

                if (c.HasChildren)
                    AttachKeyDownToTextBoxes(c);
            }
        }

        // Handler para volver al menú principal
        private void BtnVolverMenuPrincipal_Click(object? sender, EventArgs e)
        {
            if (formMenuPrincipal is not null)
            {
                formMenuPrincipal.Show();
                this.Hide();
            }
            // si es null (modo diseño o invocado sin referencia) no hace nada
        }

        // Método para cargar los artículos en el DataGridView
        private void CargarArticulos()
        {
            try
            {
                Articulo.ObtenerArticulos(dgvArticulos); // Llama al método estático para cargar los artículos
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
                if (existeElArticulo)
                {
                    // Ya no se permite modificar; informar al usuario y salir
                    MessageBox.Show("El artículo ya existe. La modificación ha sido deshabilitada.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (Articulo.InsertarArticulo(articulo))
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
            btnAgregarArt.Enabled = false;
            cmbCodUni.SelectedIndex = 0;
        }

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
            btnAgregarArt.Enabled = false;
        }

        private void EventoMoverConEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Evitar pitido y manejar envío si estamos en el último textbox (txtCosArt)
                e.SuppressKeyPress = true;

                Control origen = (Control)sender;

                // Si el botón Agregar está habilitado y el foco está en el último campo,
                // simular el clic en el botón Agregar (esto mostrará el MessageBox).
                if (btnAgregarArt.Enabled && origen == txtCosArt)
                {
                    btnAgregarArt.PerformClick();
                    return;
                }

                // En el resto de casos, mover el foco al siguiente control
                this.SelectNextControl(origen, true, true, true, true);
            }
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
                CodigoArticulo = txtCodArt.Text,
                DescripcionArticulo = txtDesArt.Text,
                CodigoUnidad = cmbCodUni.SelectedValue?.ToString() ?? "",
                ExistenciaMinima = string.IsNullOrWhiteSpace(txtExiMin.Text) ? 0 : Convert.ToSingle(txtExiMin.Text),
                ExistenciaMaxima = string.IsNullOrWhiteSpace(txtExiMax.Text) ? 0 : Convert.ToSingle(txtExiMax.Text),
                ExistenciaActual = string.IsNullOrWhiteSpace(txtExiAct.Text) ? 0 : Convert.ToSingle(txtExiAct.Text),
                PrecioArticulo = string.IsNullOrWhiteSpace(txtPreArt.Text) ? 0 : Convert.ToSingle(txtPreArt.Text),
                CostoArticulo = string.IsNullOrWhiteSpace(txtCosArt.Text) ? 0 : Convert.ToSingle(txtCosArt.Text)
            };
        }

        private bool AdvertenciaDesArt()
        {
            if (string.IsNullOrWhiteSpace(txtDesArt.Text))
            {
                MessageBox.Show("Debe introducir una descripción.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool AdvertenciacmbCodUni()
        {
            if (string.IsNullOrWhiteSpace(cmbCodUni.SelectedValue?.ToString()))
            {
                MessageBox.Show("Debe de seleccionar una unidad de medida.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            if (!AdvertenciaDesArt()) return;

            if (!AdvertenciacmbCodUni()) return;

            articulo = ObtenerArticuloEnText();

            if (articulo == null)
                return;

            GuardarArticulo(articulo);

            // Limpiar casillas después de agregar y restablecer combo
            txtCodArt?.Clear();
            txtDesArt?.Clear();
            txtExiMin?.Clear();
            txtExiMax?.Clear();
            txtExiAct?.Clear();
            txtPreArt?.Clear();
            txtCosArt?.Clear();
            if (cmbCodUni?.Items.Count > 0)
            {
                cmbCodUni.SelectedIndex = 0;
            }

            // Poner foco en la primera casilla
            txtCodArt?.Focus();
        }

        private void btnEliminarArt_Click(object sender, EventArgs e)
        {
            articulo = ObtenerArticuloEnText();
            EliminarArticulo(articulo);
        }

        // Mantener un handler vacío/informativo por si el diseñador sigue enlazando el evento
        private void btnModificarArt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La funcionalidad de modificar artículos ha sido eliminada.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarArt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodArt.Text)) return;

            articulo = BuscarArticulo(txtCodArt.Text);
            if (articulo != null)
            {
                // Rellenar los controles de la interfaz con los datos del artículo
                txtDesArt.Text = articulo.DescripcionArticulo;
                cmbCodUni.SelectedValue = articulo.CodigoUnidad;
                txtExiMin.Text = articulo.ExistenciaMinima.ToString();
                txtExiMax.Text = articulo.ExistenciaMaxima.ToString();
                txtExiAct.Text = articulo.ExistenciaActual.ToString();
                txtPreArt.Text = articulo.PrecioArticulo.ToString("0.##");
                txtCosArt.Text = articulo.CostoArticulo.ToString("0.##");

                existeElArticulo = true;
            }
            else
            {
                existeElArticulo = false;

                txtDesArt.Clear();
                txtExiMin.Clear();
                txtExiMax.Clear();
                txtExiAct.Clear();
                txtPreArt.Clear();
                txtCosArt.Clear();
            }

            btnAgregarArt.Enabled = true;

            // Mover el cursor automáticamente a la segunda casilla (descripción)
            txtDesArt?.Focus();
        }

    }   
}