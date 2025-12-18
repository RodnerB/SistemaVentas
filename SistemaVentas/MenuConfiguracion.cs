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
        private string? contrasenaUsuari = null;

        public MenuConfiguracion()
        {
            InitializeComponent();

            // Inicializar estados de los botones
            activarInputsUnidad(false);
            ActivarInputsUsuario(false);

            this.AcceptButton = btnBuscarUnidad;

            formMenuPrincipal = null;
            CargarUnidades();
            CargarUsuarios();
            CargarEstados();

            this.StartPosition = FormStartPosition.CenterScreen;

            // Asegurar que el primer cuadro de texto reciba el foco al mostrarse
            this.Shown += MenuUnidadesMedidas_Shown;

            // Integrar Resizer y redondeo (no en tiempo de diseño)
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                resizer.CaptureOriginalSizes(this);
                this.Resize += MenuUnidadesMedidas_Resize;

                // Aplicar redondeo a hijos (no TextBox ni al propio Form)
                try { UtilidadesUI.ApplyRoundedExceptTextBoxes(this, 12); } catch { }

            }

            inpDesUni.KeyPress += validarSoloLetras;
            inpTelefono.KeyPress += Validador.validarSoloNumeros;
            inpFax.KeyPress += Validador.validarSoloNumeros;

            // Inicialización de controles de empresa (llamar en el constructor después de InitializeComponent)
            InicializarEmpresa();

            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            btnGuardarUsuario.Click += btnGuardarUsuario_Click;

        }

        // Constructor con referencia al formulario principal
        public MenuConfiguracion(MenuPrincipal menuPrincipal) : this()
        {
            this.formMenuPrincipal = menuPrincipal;
        }

        private void MenuUnidadesMedidas_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
        }
        // ---------------------------
        // Unidades medida
        // ---------------------------

        private void activarInputsUnidad(bool activar)
        {
            inpCodUni.Enabled = !activar;
            inpDesUni.Enabled = activar;

            btnBuscarUsuario.Enabled = !activar;
            btnGuardarUni.Enabled = activar;
            btnCancelarUnidad.Enabled = activar;
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
            activarInputsUnidad(false);
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
            limpiarCamposUnidad();
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

            btnGuardarUni.Enabled = true;
            this.AcceptButton = btnGuardarUni;
            activarInputsUnidad(true);


        }

        private void limpiarCamposUnidad()
        {
            inpCodUni?.Clear();
            inpDesUni?.Clear();
            inpCodUni?.Focus();
        }

        private void btnCancelarUnidad_Click(object sender, EventArgs e)
        {
            existeUnidad = false;
            activarInputsUnidad(false);
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


        private void ActivarInputsUsuario(bool activar)
        {
            inpUsuario.Enabled = !activar;
            inpNombre.Enabled = activar;
            cmbEstado.Enabled = activar;

            btnBuscarUsuario.Enabled = !activar;
            btnGuardarUsuario.Enabled = activar;
            btnCancelarUsuario.Enabled = activar;
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
                    contrasenaUsuari = usuarioEncontrado.password;
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

        private Usuario ObtenerUsuarioEnInputs()
        {
            return new Usuario(inpUsuario.Text.Trim(), contrasenaUsuari ?? string.Empty)
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
            cmbEstado.SelectedIndex = 0;
        }



        private void btnGuardarEmpresa_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            empresa = ObtenerEmpresaEnInputs();
            if (empresa == null) return;

            if (string.IsNullOrWhiteSpace(empresa.Nombre) ||
                string.IsNullOrWhiteSpace(empresa.Direccion) ||
                string.IsNullOrWhiteSpace(empresa.Telefono) ||
                string.IsNullOrWhiteSpace(empresa.Email))
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Empresa.GuardarEmpresa(empresa))
                {
                    MessageBox.Show("Información empresarial guardada/actualizada exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la información empresarial.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CargarEmpresaEnGrid();
                activarInputsEmpresa(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ---------------------------
        // Información Empresarial
        // ---------------------------

        private Empresa? empresa = null;
        private bool existeEmpresa = false;

        private void InicializarEmpresa()
        {
            activarInputsEmpresa(true);
            Empresa.CargarEmpresaEnGridConFilas(dgvEmpresa);
            btnCancelar.Click += btnCancelar_Click;
            btnGuardarInfomacionEmpresarial.Click += btnGuardarInfomacionEmpresarial_Click;
        }


        private void activarInputsEmpresa(bool activar)
        {
            inpEmpresa.Enabled = true;
            inpDireccion.Enabled = true;
            inpTelefono.Enabled = true;
            inpFax.Enabled = true;
            inpEmail.Enabled = true;

            btnGuardarInfomacionEmpresarial.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void EmpresaInput_TextChanged(object? sender, EventArgs e)
        {
            if (!ValidarCamposEmpresa()) return;
            var empresa = ObtenerEmpresaEnInputs();
            Empresa.GuardarEmpresa(empresa);
            Empresa.CargarEmpresaEnGridConFilas(dgvEmpresa);
        }

        // Carga la información de la empresa en los TextBox si existe
        private void CargarEmpresaEnGrid()
        {
            try
            {
                empresa = null;
                existeEmpresa = false;
                DataTable dtEmpresa = UtilidadesBD.ObtenerTodosLosRegistros("SELECT TOP 1 * FROM SFTCONF0");
                if (dtEmpresa.Rows.Count > 0)
                {
                    DataRow row = dtEmpresa.Rows[0];
                    inpEmpresa.Text = row["empresa"]?.ToString() ?? "";
                    inpDireccion.Text = row["direccion"]?.ToString() ?? "";
                    inpTelefono.Text = row["telefono"]?.ToString() ?? "";
                    inpFax.Text = row["fax"]?.ToString() ?? "";
                    inpEmail.Text = row["email"]?.ToString() ?? "";
                    existeEmpresa = true;
                }
                else
                {
                    LimpiarCamposEmpresa();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información de la empresa: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancelarEmpresa_Click(object sender, EventArgs e)
        {
            CargarEmpresaEnGrid();
            activarInputsEmpresa(false);
            inpEmpresa.Focus();
        }

        // Obtiene los datos de los inputs
        private Empresa ObtenerEmpresaEnInputs()
        {
            return new Empresa(
                inpEmpresa.Text.Trim(),
                inpDireccion.Text.Trim(),
                inpTelefono.Text.Trim(),
                inpFax.Text.Trim(),
                inpEmail.Text.Trim()
            );
        }

        // Limpia los campos de empresa
        private void LimpiarCamposEmpresa()
        {
            inpEmpresa.Clear();
            inpDireccion.Clear();
            inpTelefono.Clear();
            inpFax.Clear();
            inpEmail.Clear();
        }

        // Validación de campos empresariales
        private bool ValidarCamposEmpresa()
        {
            if (string.IsNullOrWhiteSpace(inpEmpresa.Text))
            {
                MessageBox.Show("Debe introducir el nombre de la empresa.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpEmpresa.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(inpDireccion.Text))
            {
                MessageBox.Show("Debeintroducir la dirección de la empresa.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpDireccion.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(inpTelefono.Text))
            {
                MessageBox.Show("Debe introducir el teléfono de la empresa.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpTelefono.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(inpEmail.Text))
            {
                MessageBox.Show("Debe introducir el email de la empresa.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpEmail.Focus();
                return false;
            }
            return true;
        }

        private void MenuUnidadesMedidas_Shown(object? sender, EventArgs e)
        {

            inpCodUni?.Focus();
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            LimpiarCamposEmpresa();
            activarInputsEmpresa(false);
            inpEmpresa.Focus();
        }

        private void btnGuardarInfomacionEmpresarial_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            empresa = ObtenerEmpresaEnInputs();
            if (empresa == null) return;

            if (string.IsNullOrWhiteSpace(empresa.Nombre) ||
                string.IsNullOrWhiteSpace(empresa.Direccion) ||
                string.IsNullOrWhiteSpace(empresa.Telefono) ||
                string.IsNullOrWhiteSpace(empresa.Email))
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Empresa.EliminarInformacionEmpresarial();

                if (Empresa.GuardarEmpresa(empresa))
                {
                    MessageBox.Show("Información empresarial guardada exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la información empresarial.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Empresa.CargarEmpresaEnGridConFilas(dgvEmpresa);
                LimpiarCamposEmpresa();
                activarInputsEmpresa(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()
        {
            if (!Validador.ValidarTamanoPermitido(inpEmpresa.Text, 60))
            {
                MessageBox.Show("El nombre de la empresa debe tener máximo 60 caracteres.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpEmpresa.Focus();
                return false;
            }
            if (!Validador.ValidarTamanoPermitido(inpDireccion.Text, 60))
            {
                MessageBox.Show("La dirección debe tener máximo 60 caracteres.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpDireccion.Focus();
                return false;
            }
            if (!Validador.ValidarTamanoPermitido(inpTelefono.Text, 10))
            {
                MessageBox.Show("El teléfono debe tener máximo 10 caracteres.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpTelefono.Focus();
                return false;
            }
            if (!Validador.ValidarTamanoPermitido(inpFax.Text, 10))
            {
                MessageBox.Show("El fax debe tener máximo 10 caracteres.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpFax.Focus();
                return false;
            }
            if (!Validador.ValidarTamanoPermitido(inpEmail.Text, 60))
            {
                MessageBox.Show("El email debe tener máximo 60 caracteres.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpEmail.Focus();
                return false;
            }
            return true;
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inpUsuario.Text)) return;

            usuario = BuscarUsuario(inpUsuario.Text);
            if (usuario != null)
            {
                inpNombre.Text = usuario.nombre;
                cmbEstado.SelectedValue = usuario.estado;
                existeUsuario = true;
            }
            else
            {
                existeUsuario = false;
                inpNombre.Clear();
                cmbEstado.SelectedIndex = 0;
            }

            btnGuardarUsuario.Enabled = true;
            this.AcceptButton = btnGuardarUsuario;
            ActivarInputsUsuario(true);
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposUsuario()) return;

            usuario = ObtenerUsuarioEnInputs();
            if (usuario == null) return;

            GuardarUsuario(usuario);
            LimpiarCamposUsuario();
            ActivarInputsUsuario(false);
        }

        private void btnVolverAlMenuPrincipal_Click(object sender, EventArgs e)
        {
            formMenuPrincipal?.Show(); // Muestra el formulario principal nuevamente
            this.Close(); //Cierra el formulario actual de artículos
        }
    }
}