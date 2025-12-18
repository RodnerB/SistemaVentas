using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using SistemaVentas.Utilidades;

namespace SistemaVentas
{
    public partial class MenuConfiguracion : Form
    {
        UnidadesMedida? unidadesMedida = new UnidadesMedida();
        bool existeUnidad = false;
        
        Usuario? usuario = null;
        bool existeUsuario = false;
        
        private MenuPrincipal? formMenuPrincipal;
        private readonly UtilidadesUI resizer = new UtilidadesUI();

        // Constructor sin parámetros (necesario para el diseñador)
        public MenuConfiguracion()
        {
            InitializeComponent();

            // Inicializar estados de los botones
            InicializarEstadoBotones();
            InicializarEstadoBotonesUsuario();

            this.AcceptButton = btnBuscarUnidad;

            formMenuPrincipal = null;
            CargarUnidades();
            CargarUsuarios();
            CargarEstados();
            
            this.StartPosition = FormStartPosition.CenterScreen;

            // Asegurar que el primer cuadro de texto reciba el foco al mostrarse
            this.Shown += MenuUnidadesMedidas_Shown;

            // Asignar comportamiento de Enter a los TextBox (recorre controles anidados)
            foreach (Control c in this.Controls)
            {
                AddKeyDownToTextBoxesRecursive(c);
            }

            // Integrar Resizer y redondeo (no en tiempo de diseño)
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                resizer.CaptureOriginalSizes(this);
                this.Resize += MenuUnidadesMedidas_Resize;

                // Aplicar redondeo a hijos (no TextBox ni al propio Form)
                try { UtilidadesUI.ApplyRoundedExceptTextBoxes(this, 12); } catch { }
                
                // AGREGAR ESTA LÍNEA
                this.Load += MenuConfiguracion_Load;
            }

            inpDesUni.KeyPress += validarSoloLetras;
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

        #region Unidades de Medida

        private void InicializarEstadoBotones()
        {
            btnBuscarUnidad.Enabled = true;
            btnAgregarUni.Enabled = false;
            this.AcceptButton = btnBuscarUnidad;
        }

        private void activarInputsUnidad(bool activar)
        {
            inpCodUni.Enabled = !activar;
            inpDesUni.Enabled = activar;
        }

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

        private UnidadesMedida ObtenerUnidadesEnText()
        {
            return new UnidadesMedida()
            {
                CodigoUnidad = inpCodUni.Text,
                DescripcionUnidad = inpDesUni.Text
            };
        }

        private bool Validaciones()
        {
            if (string.IsNullOrWhiteSpace(inpDesUni.Text))
            {
                MessageBox.Show("Debe introducir una descripción.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Validador.ValidarTamanoPermitido(inpCodUni.Text, 3))
            {
                MessageBox.Show("La descripción debe tener 3 caracteres.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static void validarSoloLetras(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void btnAgregarUni_Click(object sender, EventArgs e)
        {
            if (!Validaciones()) return;

            unidadesMedida = ObtenerUnidadesEnText();

            if (unidadesMedida == null)
                return;

            GuardarUnidad(unidadesMedida);

            inpCodUni?.Clear();
            inpDesUni?.Clear();
            inpCodUni?.Focus();
        }

        private void btnModificarUni_Click(object sender, EventArgs e)
        {
            if (!Validaciones()) return;

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

            btnAgregarUni.Enabled = true;
            this.AcceptButton = btnAgregarUni;
            activarInputsUnidad(true); 

            inpDesUni?.Focus();
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

        #endregion

        #region Usuarios

        private void InicializarEstadoBotonesUsuario()
        {
            btnBuscarUsuario.Enabled = true;
            btnGuardarUsuario.Enabled = false;
            btnCancelarUsuario.Enabled = false;
            ActivarInputsUsuario(false);
        }

        private void ActivarInputsUsuario(bool activar)
        {
            inpUsuario.Enabled = !activar; // Usuario solo se puede escribir cuando está desactivado (para buscar)
            inpNombre.Enabled = activar;
            inpContrasena.Enabled = activar;
            cmbEstado.Enabled = activar;
        }

        private void CargarEstados()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Codigo", typeof(string));
            tabla.Columns.Add("Descripcion", typeof(string));

            DataRow filaVacia = tabla.NewRow();
            filaVacia["Codigo"] = "";
            filaVacia["Descripcion"] = "Seleccione un estado";
            tabla.Rows.Add(filaVacia);

            DataRow filaActivo = tabla.NewRow();
            filaActivo["Codigo"] = "1";
            filaActivo["Descripcion"] = "Activo";
            tabla.Rows.Add(filaActivo);

            DataRow filaInactivo = tabla.NewRow();
            filaInactivo["Codigo"] = "2";
            filaInactivo["Descripcion"] = "Inactivo";
            tabla.Rows.Add(filaInactivo);

            cmbEstado.DataSource = tabla;
            cmbEstado.DisplayMember = "Descripcion";
            cmbEstado.ValueMember = "Codigo";
            cmbEstado.SelectedIndex = 0;
        }

        private void CargarUsuarios()
        {
            try
            {
                Usuario.CargarUsuariosGridConFilas(dgvVerUsuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Usuario? BuscarUsuario(string codigoUsuario)
        {
            try
            {
                Usuario? usuarioEncontrado = Usuario.ObtenerUsuarioPorUsuario(codigoUsuario);
                if (usuarioEncontrado == null)
                {
                    existeUsuario = false;
                    MessageBox.Show("Usuario no encontrado.", "No encontrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    existeUsuario = true;
                }
                return usuarioEncontrado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                existeUsuario = false;
                return null;
            }
        }

        private void GuardarUsuario(Usuario usuario)
        {
            try
            {
                usuario.existe = existeUsuario;
                
                if (usuario.GuardarUsuario())
                {
                    string mensaje = existeUsuario ? "Usuario modificado exitosamente" : "Usuario guardado exitosamente";
                    MessageBox.Show(mensaje, "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                    LimpiarCamposUsuario();
                    InicializarEstadoBotonesUsuario();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el usuario.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarUsuario(string codigoUsuario)
        {
            try
            {
                if (Usuario.EliminarUsuario(codigoUsuario))
                {
                    MessageBox.Show("Usuario eliminado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Usuario ObtenerUsuarioEnInputs()
        {
            return new Usuario(inpUsuario.Text.Trim(), inpContrasena.Text.Trim())
            {
                nombre = inpNombre.Text.Trim(),
                estado = cmbEstado.SelectedValue?.ToString() ?? "2"
            };
        }

        private bool ValidarCamposUsuario()
        {
            if (string.IsNullOrWhiteSpace(inpUsuario.Text))
            {
                MessageBox.Show("Debe introducir un nombre de usuario.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(inpNombre.Text))
            {
                MessageBox.Show("Debe introducir el nombre completo.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(inpContrasena.Text))
            {
                MessageBox.Show("Debe introducir una contraseña.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpContrasena.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbEstado.SelectedValue?.ToString()))
            {
                MessageBox.Show("Debe seleccionar un estado.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEstado.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCamposUsuario()
        {
            inpUsuario.Clear();
            inpNombre.Clear();
            inpContrasena.Clear();
            cmbEstado.SelectedIndex = 0;
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inpUsuario.Text))
            {
                MessageBox.Show("Debe introducir el nombre de usuario a buscar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpUsuario.Focus();
                return;
            }

            usuario = BuscarUsuario(inpUsuario.Text.Trim());
            
            if (usuario != null)
            {
                // Usuario encontrado - cargar datos
                inpNombre.Text = usuario.nombre;
                inpContrasena.Text = usuario.password;
                cmbEstado.SelectedValue = usuario.estado;
                existeUsuario = true;
            }
            else
            {
                // Usuario no encontrado - limpiar campos para crearlo nuevo
                existeUsuario = false;
                inpNombre.Clear();
                inpContrasena.Clear();
                cmbEstado.SelectedIndex = 0;
            }

            // Habilitar campos para editar/crear
            ActivarInputsUsuario(true);
            btnGuardarUsuario.Enabled = true;
            btnCancelarUsuario.Enabled = true;
            
            // Mover foco al nombre
            inpNombre?.Focus();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposUsuario()) return;

            usuario = ObtenerUsuarioEnInputs();

            if (usuario == null) return;

            GuardarUsuario(usuario);
        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            LimpiarCamposUsuario();
            InicializarEstadoBotonesUsuario();
            inpUsuario.Focus();
        }

        private void dgvVerUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que sea un clic válido en la columna de eliminar
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvVerUsuarios.Columns["colEliminar"].Index)
            {
                string codigoUsuario = dgvVerUsuarios.Rows[e.RowIndex].Cells["colUsuario"].Value.ToString()!;
                
                var confirm = MessageBox.Show($"¿Está seguro de eliminar el usuario '{codigoUsuario}'?", 
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);
                
                if (confirm == DialogResult.Yes)
                {
                    EliminarUsuario(codigoUsuario);
                }
            }
        }

        #endregion

        #region Eventos Generales

        private void EventoMoverConEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Control origen = (Control)sender;

                // Para unidades de medida
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

        private void MenuConfiguracion_Load(object sender, EventArgs e)
        {
            activarInputsUnidad(false);
        }

        #endregion
    }
}
