using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentas.Utilidades;

namespace SistemaVentas
{
    public partial class MenuLogin : Form
    {
        private readonly UtilidadesUI resizer = new UtilidadesUI();
        Usuario usuario;
        public MenuLogin()
        {
            InitializeComponent();

            // Manejar Enter en los campos de usuario y contraseña
            inpUsuario.KeyDown += Inputs_KeyDown;
            inpContrasena.KeyDown += Inputs_KeyDown;

            // No ejecutar en tiempo de diseño
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                // Capturar tamaños originales para permitir redimensionado adaptativo
                resizer.CaptureOriginalSizes(this);
                this.Resize += MenuLogin_Resize;

                // Aplicar redondeo cuando el formulario ya esté mostrado y los controles tengan su tamaño final
                this.Shown += (s, e) =>
                {
                    UtilidadesUI.ApplyRoundedExceptTextBoxes(this, 50);
                };
            }
        }

        private void MenuLogin_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
        }


        // NUEVO: manejar Enter para cambiar de campo y después pulsar el botón
        private void Inputs_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || sender is not Control control)
            {
                return;
            }

            e.SuppressKeyPress = true; // evitar beep / salto de línea

            if (control == inpUsuario)
            {
                // Del primer campo (usuario) al segundo (contraseña)
                inpContrasena.Focus();
            }
            else if (control == inpContrasena)
            {
                // Desde contraseña, Enter dispara el botón Entrar
                btnEntrar.PerformClick();
            }
        }

        private Usuario ObtenerUsuarioInputs()
        {
            string usuario = inpUsuario.Text.Trim();
            string password = inpContrasena.Text.Trim();
            return new Usuario(usuario, password);
        }

        private bool ValidarPassword()
        {
            usuario = ObtenerUsuarioInputs();
            return Usuario.validarPassword(usuario);

        }



        private void btnEntrar_Click(object sender, EventArgs e)
        {

            // descomentar la validacion ante de entregar al profe y comentar el menu sin usuario
            
            if (!ValidarPassword())
            {
                MessageBox.Show("Este usuario no existe", "Error", MessageBoxButtons.OK);
                return;
            }
            usuario.existe = true;
            
            MenuPrincipal menuPrincipal = new MenuPrincipal(this, usuario);
            
            /*MenuPrincipal menuPrincipal = new MenuPrincipal(this); // sin usuario pa no tener q iniciar sesion cada ve q pruebe algo*/
            menuPrincipal.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que desea salir?",
                                         "Confirmar",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question,
                                         MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
