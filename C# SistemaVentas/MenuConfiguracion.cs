using System;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class MenuConfiguracion : Form
    {
        private Usuario? usuario;
        private bool existeUsuario;

        public MenuConfiguracion()
        {
            InitializeComponent();
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            btnGuardarUsuario.Click += btnGuardarUsuario_Click;
            btnCancelarUsuario.Click += btnCancelarUsuario_Click;
            dgvVerUsuarios.CellClick += dgvVerUsuarios_CellClick;
            CargarEstados();
            CargarUsuarios();
            InicializarEstadoBotonesUsuario();
        }

        private void InicializarEstadoBotonesUsuario()
        {
            btnBuscarUsuario.Enabled = true;
            btnGuardarUsuario.Enabled = false;
            btnCancelarUsuario.Enabled = false;
            inpUsuario.Enabled = true;
            inpNombre.Enabled = false;
            inpContrasena.Enabled = false;
            cmbEstado.Enabled = false;
            LimpiarCamposUsuario();
            existeUsuario = false;
        }

        private void ActivarInputsUsuario(bool activar)
        {
            inpUsuario.Enabled = !activar;
            inpNombre.Enabled = activar;
            inpContrasena.Enabled = activar;
            cmbEstado.Enabled = activar;
        }

        private void LimpiarCamposUsuario()
        {
            inpUsuario.Clear();
            inpNombre.Clear();
            inpContrasena.Clear();
            if (cmbEstado.Items.Count > 0)
                cmbEstado.SelectedIndex = 0;
        }

        private void CargarEstados()
        {
            var tabla = new System.Data.DataTable();
            tabla.Columns.Add("Codigo", typeof(string));
            tabla.Columns.Add("Descripcion", typeof(string));
            tabla.Rows.Add("", "Seleccione un estado");
            tabla.Rows.Add("1", "Activo");
            tabla.Rows.Add("2", "Inactivo");
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
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCamposUsuario()
        {
            string usuarioTexto = inpUsuario.Text.Trim();
            string nombre = inpNombre.Text.Trim();
            string contrasena = inpContrasena.Text.Trim();
            string? estadoValor = cmbEstado.SelectedValue?.ToString();

            if (string.IsNullOrWhiteSpace(usuarioTexto))
            {
                MessageBox.Show("Debe introducir un nombre de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpUsuario.Focus();
                return false;
            }
            if (!Utilidades.Validador.ValidarTamanoPermitido(usuarioTexto, 20, 3))
            {
                MessageBox.Show("El usuario debe tener entre 3 y 20 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpUsuario.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe introducir el nombre completo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpNombre.Focus();
                return false;
            }
            if (!Utilidades.Validador.ValidarTamanoPermitido(nombre, 60, 3))
            {
                MessageBox.Show("El nombre debe tener entre 3 y 60 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpNombre.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Debe introducir una contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpContrasena.Focus();
                return false;
            }
            if (!Utilidades.Validador.ValidarTamanoPermitido(contrasena, 30, 4))
            {
                MessageBox.Show("La contraseña debe tener entre 4 y 30 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpContrasena.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(estadoValor))
            {
                MessageBox.Show("Debe seleccionar un estado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEstado.Focus();
                return false;
            }
            return true;
        }

        private Usuario ObtenerUsuarioEnInputs()
        {
            return new Usuario(inpUsuario.Text.Trim(), inpContrasena.Text.Trim())
            {
                nombre = inpNombre.Text.Trim(),
                estado = cmbEstado.SelectedValue?.ToString() ?? "2"
            };
        }

        private Usuario? BuscarUsuario(string codigoUsuario)
        {
            try
            {
                Usuario? usuarioEncontrado = Usuario.ObtenerUsuarioPorUsuario(codigoUsuario);
                existeUsuario = usuarioEncontrado != null;
                if (!existeUsuario)
                    MessageBox.Show("Usuario no encontrado.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return usuarioEncontrado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                    InicializarEstadoBotonesUsuario();
                    inpUsuario.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarUsuario(string codigoUsuario)
        {
            try
            {
                if (Usuario.EliminarUsuario(codigoUsuario))
                {
                    MessageBox.Show("Usuario eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            string usuarioTexto = inpUsuario.Text.Trim();
            if (string.IsNullOrWhiteSpace(usuarioTexto))
            {
                MessageBox.Show("Debe introducir el nombre de usuario a buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpUsuario.Focus();
                return;
            }
            if (!Utilidades.Validador.ValidarTamanoPermitido(usuarioTexto, 20, 3))
            {
                MessageBox.Show("El usuario debe tener entre 3 y 20 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inpUsuario.Focus();
                return;
            }
            usuario = BuscarUsuario(usuarioTexto);
            inpNombre.Text = usuario?.nombre ?? "";
            inpContrasena.Text = usuario?.password ?? "";
            cmbEstado.SelectedValue = usuario?.estado ?? "2";
            ActivarInputsUsuario(true);
            btnGuardarUsuario.Enabled = true;
            btnCancelarUsuario.Enabled = true;
            btnBuscarUsuario.Enabled = false;
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
            InicializarEstadoBotonesUsuario();
            inpUsuario.Focus();
        }

        private void dgvVerUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.ColumnIndex == dgvVerUsuarios.Columns["colEliminar"].Index)
            {
                string codigoUsuario = dgvVerUsuarios.Rows[e.RowIndex].Cells["colUsuario"].Value?.ToString() ?? string.Empty;
                if (string.IsNullOrWhiteSpace(codigoUsuario)) return;
                var confirm = MessageBox.Show($"¿Está seguro de eliminar el usuario '{codigoUsuario}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                    EliminarUsuario(codigoUsuario);
            }
        }
    }
}