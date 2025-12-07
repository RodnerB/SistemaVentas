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
using SistemaVentas.Utilidades;

namespace SistemaVentas
{
    public partial class MenuUnidadesMedidas : Form
    {
        UnidadesMedida? unidadesMedida = new UnidadesMedida();
        bool existeUnidad = false;
        private MenuPrincipal? formMenuPrincipal; // referencia al formulario principal
        private readonly Resizer resizer = new Resizer();

        // Constructor sin parámetros (necesario para el diseñador)
        public MenuUnidadesMedidas()
        {
            InitializeComponent();

            // Inicializar estados de los botones: solo Buscar habilitado
            InicializarEstadoBotones();

            this.AcceptButton = btnAgregarUni;

            formMenuPrincipal = null;
            CargarUnidades();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Asegurar que el primer cuadro de texto reciba el foco al mostrarse
            this.Shown += MenuUnidadesMedidas_Shown;

            // Asignar comportamiento de Enter a los TextBox
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
#pragma warning disable CS8622
                    c.KeyDown += EventoMoverConEnter;
#pragma warning restore CS8622
                }
            }

            // Integrar Resizer y redondeo (no en tiempo de diseño)
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                resizer.CaptureOriginalSizes(this);
                this.Resize += MenuUnidadesMedidas_Resize;

                // Aplicar redondeo a hijos (no TextBox ni al propio Form)
                try { ApplyRoundedExceptTextBoxes(this, 12); } catch { }
            }
        }

        // Constructor con referencia al formulario principal
        public MenuUnidadesMedidas(MenuPrincipal menuPrincipal) : this()
        {
            this.formMenuPrincipal = menuPrincipal;
        }

        private void MenuUnidadesMedidas_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
        }

        private void InicializarEstadoBotones()
        {
            // Al iniciar: solo buscar habilitado
            btnBuscarUni.Enabled = true;
            btnAgregarUni.Enabled = false;
            this.AcceptButton = btnBuscarUni;
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
                    // Corregido: crear una instancia y pasarla al método
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

                // Si el botón Agregar está habilitado y el foco está en el último campo (txtDesUni),
                // simular el clic en Agregar.
                if (btnAgregarUni.Enabled && origen == txtDesUni)
                {
                    btnAgregarUni.PerformClick();
                    return;
                }

                // Si se presiona Enter en el primer campo, ir explícitamente al segundo
                if (origen == txtCodUni)
                {
                    txtDesUni?.Focus();
                    return;
                }

                // En el resto de casos, mover el foco al siguiente control
                this.SelectNextControl(origen, true, true, true, true);
            }
        }

        private UnidadesMedida ObtenerUnidadesEnText()
        {
            return new UnidadesMedida()
            {
                CodigoUnidad = txtCodUni.Text,
                DescripcionUnidad = txtDesUni.Text
            };
        }

        private bool AdvertenciaDesUni()
        {
            if (string.IsNullOrWhiteSpace(txtDesUni.Text))
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
            txtCodUni?.Clear();
            txtDesUni?.Clear();
            txtCodUni?.Focus();
        }

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

        private void btnBuscarUni_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodUni.Text)) return;

            unidadesMedida = BuscarUnidad(txtCodUni.Text);
            if (unidadesMedida != null)
            {
                txtDesUni.Text = unidadesMedida.DescripcionUnidad;
                existeUnidad = true;
            }
            else
            {
                existeUnidad = false;
                txtDesUni.Clear();
            }

            // Después de buscar: permitir agregar; permitir modificar/eliminar si existe
            btnAgregarUni.Enabled = true;
            this.AcceptButton = btnAgregarUni;

            // Mover el cursor automáticamente a la segunda casilla (descripción)
            txtDesUni?.Focus();
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
            txtCodUni?.Focus();
        }

        private void ModificarUnidad(UnidadesMedida unidad)
        {
            try
            {
                if (unidad != null && unidad.CodigoUnidad != null)
                {
                    // Corregido: llamar al método de instancia en vez de estático
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

        // Aplica RoundedControlHelper a todos los controles hijos excepto TextBox y sin tocar el propio Form.
        private void ApplyRoundedExceptTextBoxes(Control parent, int radius)
        {
            if (parent == null) return;

            // Si el parent es el formulario raíz, no aplicamos al formulario; sí a sus hijos.
            if (parent is Form)
            {
                foreach (Control c in parent.Controls)
                {
                    if (c is not TextBox)
                    {
                        try { RoundedControlHelper.RedondearBordes(c, radius); }
                        catch { /* ignorar errores */ }
                    }
                    if (c.HasChildren) ApplyRoundedExceptTextBoxes(c, radius);
                }
                return;
            }

            // Para controles que no son el Form, aplicar normalmente (excepto TextBox)
            if (parent is not TextBox)
            {
                try { RoundedControlHelper.RedondearBordes(parent, radius); }
                catch { /* ignorar errores */ }
            }

            foreach (Control c in parent.Controls)
            {
                if (c is not TextBox)
                {
                    try { RoundedControlHelper.RedondearBordes(c, radius); }
                    catch { /* ignorar errores */ }
                }
                if (c.HasChildren) ApplyRoundedExceptTextBoxes(c, radius);
            }
        }
    }
}
