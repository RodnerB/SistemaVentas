using System;
using System.ComponentModel;
using System.Windows.Forms;
using SistemaVentas.Utilidades;

namespace SistemaVentas
{
    public partial class MenuConfiguracion : Form
    {
        UnidadesMedida? unidadesMedida = new UnidadesMedida();
        bool existeUnidad = false;
        private MenuPrincipal? formMenuPrincipal; // referencia al formulario principal
        private readonly UtilidadesUI resizer = new UtilidadesUI();

        // Constructor sin parámetros (necesario para el diseñador)
        public MenuConfiguracion()
        {
            InitializeComponent();

            // Inicializar estados de los botones: solo Buscar habilitado
            InicializarEstadoBotones();

            // AceptButton existente en el diseñador
            this.AcceptButton = btnAgregarUni;

            formMenuPrincipal = null;
            CargarUnidades();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Asegurar que el primer cuadro de texto reciba el foco al mostrarse
            this.Shown += MenuUnidadesMedidas_Shown;

            // Asignar comportamiento de Enter a los TextBox (recorre controles anidados)
            foreach (Control c in this.Controls)
            {
                AddKeyDownToTextBoxesRecursive(c);
            }

            // Asignar manejadores de evento de botones si no están definidos en el diseñador
            btnAgregarUni.Click -= btnAgregarUni_Click;
            btnAgregarUni.Click += btnAgregarUni_Click;

            btnBuscarUnidad.Click -= btnBuscarUnidad_Click;
            btnBuscarUnidad.Click += btnBuscarUnidad_Click;

            // Integrar Resizer y redondeo (no en tiempo de diseño)
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                resizer.CaptureOriginalSizes(this);
                this.Resize += MenuUnidadesMedidas_Resize;

                // Aplicar redondeo a hijos (no TextBox ni al propio Form)
                try { UtilidadesUI.ApplyRoundedExceptTextBoxes(this, 12); } catch { }
            }
        }

        // Constructor con referencia al formulario principal
        public MenuConfiguracion(MenuPrincipal menuPrincipal) : this()
        {
            this.formMenuPrincipal = menuPrincipal;
        }

        private void AddKeyDownToTextBoxesRecursive(Control control)
        {
            if (control is TextBox tb)
            {
#pragma warning disable CS8622
                tb.KeyDown -= EventoMoverConEnter;
                tb.KeyDown += EventoMoverConEnter;
#pragma warning restore CS8622
            }

            foreach (Control child in control.Controls)
            {
                AddKeyDownToTextBoxesRecursive(child);
            }
        }

        private void MenuUnidadesMedidas_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
        }

        private void InicializarEstadoBotones()
        {
            // Ajustado a los nombres del diseñador de MenuConfiguracion
            btnBuscarUnidad.Enabled = true;
            btnAgregarUni.Enabled = false;
            this.AcceptButton = btnBuscarUnidad;
        }

        // Método para cargar las unidades en el DataGridView
        private void CargarUnidades()
        {
            try
            {
                UnidadesMedida.ObtenerUnidades(dgvUnidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las unidades de medida: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private UnidadesMedida? BuscarUnidad(string codigoUnidad)
        {
            try
            {
                UnidadesMedida? unidad = UnidadesMedida.ObtenerUnidadPorCodigo(codigoUnidad);
                if (unidad == null)
                {
                    existeUnidad = false;
                    MessageBox.Show("Unidad de medida no encontrada.", "No encontrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return unidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                existeUnidad = false;
                return null;
            }
        }

        private void GuardarUnidad(UnidadesMedida unidad)
        {
            try
            {
                if (existeUnidad)
                {
                    ModificarUnidad(unidad);
                    CargarUnidades();
                }
                else if (UnidadesMedida.InsertarUnidad(unidad))
                {
                    MessageBox.Show("Unidad guardada exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUnidades();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Después de guardar, volver al estado inicial (buscar)
            existeUnidad = false;
            InicializarEstadoBotones();
        }

        private void EliminarUnidad(UnidadesMedida unidad)
        {
            try
            {
                if (unidad != null && unidad.CodigoUnidad != null)
                {
                    if (unidad.EliminarUnidad(unidad))
                    {
                        MessageBox.Show("Unidad eliminada exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarUnidades();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la unidad.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            existeUnidad = false;
            InicializarEstadoBotones();
        }

        // Manejo de Enter para mover foco y para ejecutar Agregar si corresponde
        private void EventoMoverConEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                Control origen = (Control)sender;

                // Comparaciones con los nombres del diseñador del formulario de configuración
                if (btnAgregarUni.Enabled && origen == inpDesUni)
                {
                    btnAgregarUni.PerformClick();
                    return;
                }

                if (origen == inpCodUni)
                {
                    inpDesUni?.Focus();
                    return;
                }

                this.SelectNextControl(origen, true, true, true, true);
            }
        }

        private UnidadesMedida ObtenerUnidadesEnText()
        {
            return new UnidadesMedida()
            {
                CodigoUnidad = inpCodUni.Text,
                DescripcionUnidad = inpDesUni.Text
            };
        }

        private bool AdvertenciaDesUni()
        {
            if (string.IsNullOrWhiteSpace(inpDesUni.Text))
            {
                MessageBox.Show("Debe introducir una descripción.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAgregarUni_Click(object sender, EventArgs e)
        {
            if (!AdvertenciaDesUni()) return;

            unidadesMedida = ObtenerUnidadesEnText();

            if (unidadesMedida == null)
                return;

            GuardarUnidad(unidadesMedida);

            // Limpiar casillas después de agregar
            inpCodUni?.Clear();
            inpDesUni?.Clear();
            inpCodUni?.Focus();
        }

        // Si necesita soporte para modificar/eliminar, añada botones en el diseñador y adapte nombres.
        private void btnModificarUni_Click(object sender, EventArgs e)
        {
            if (!AdvertenciaDesUni()) return;

            unidadesMedida = ObtenerUnidadesEnText();

            if (unidadesMedida == null)
                return;

            ModificarUnidad(unidadesMedida);
            CargarUnidades();

            btnAgregarUni.Enabled = false;
        }

        private void btnEliminarUni_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Confirma que desea eliminar esta unidad?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            unidadesMedida = ObtenerUnidadesEnText();
            EliminarUnidad(unidadesMedida);
        }

        private void btnBuscarUnidad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inpCodUni.Text)) return;

            unidadesMedida = BuscarUnidad(inpCodUni.Text);
            if (unidadesMedida != null)
            {
                inpDesUni.Text = unidadesMedida.DescripcionUnidad;
                existeUnidad = true;
            }
            else
            {
                existeUnidad = false;
                inpDesUni.Clear();
            }

            // Después de buscar: permitir agregar; permitir modificar/eliminar si existe
            btnAgregarUni.Enabled = true;
            this.AcceptButton = btnAgregarUni;

            // Mover el cursor automáticamente a la segunda casilla (descripción)
            inpDesUni?.Focus();
        }

        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            if (formMenuPrincipal != null)
            {
                formMenuPrincipal.Show();
            }
            this.Close();
        }

        private void MenuUnidadesMedidas_Shown(object? sender, EventArgs e)
        {
            inpCodUni?.Focus();
        }

        private void ModificarUnidad(UnidadesMedida unidad)
        {
            try
            {
                if (unidad != null && unidad.CodigoUnidad != null)
                {
                    if (unidad.ActualizarUnidad(unidad))
                    {
                        MessageBox.Show("Unidad modificada exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar la unidad.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
