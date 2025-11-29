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

namespace SistemaVentas
{
    public partial class MenuArticulos : Form
    {
        Articulo? articulo = new Articulo();
        bool existeElArticulo = false;
        MenuPrincipal formMenuPrincipal; // referencia al formulario principal
        private Resizer resizer = new Resizer();

        // Constructor con referencia al formulario principal
        public MenuArticulos(MenuPrincipal MenuPrincipal)
        {
            InitializeComponent();

            // Inicializar resizer antes de cualquier cambio de tamaño
            resizer.CaptureOriginalSizes(this);
            this.Resize += MenuArticulos_Resize;

            // Inicializar estados de los botones: solo Buscar y Volver habilitados
            btnAgregarArt.Enabled = false;
            btnEliminarArt.Enabled = false;
            btnBuscarArt.Enabled = true;
            btnVolverMenuPrincipal.Enabled = true;

            // Permitir que Enter active el botón de agregar cuando esté habilitado
            this.AcceptButton = btnAgregarArt;

            formMenuPrincipal = MenuPrincipal;
            CargarArticulos();
            CargarUnidades(); // <-- Asegurar que el combo se llene al crear el formulario

            this.StartPosition = FormStartPosition.CenterScreen;

            // Asegurar que el primer cuadro de texto reciba el foco cuando el formulario se muestre
            this.Shown += Form3_Shown;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
#pragma warning disable CS8622
                    c.KeyDown += EventoMoverConEnter;
#pragma warning restore CS8622
                }
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
            btnEliminarArt.Enabled = false;
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
            btnEliminarArt.Enabled = false;
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
            btnEliminarArt.Enabled = existeElArticulo;

            // Mover el cursor automáticamente a la segunda casilla (descripción)
            txtDesArt?.Focus();
        }

        private void btnVolverMenuPrincipal_Click_1(object sender, EventArgs e)
        {
            formMenuPrincipal.Show();
            this.Close();
        }

      
    }
}