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
        private readonly Resizer resizer = new Resizer();

        // Radio distinto para botones
        private const int ButtonRadius = 12;

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
                    ApplyRoundedExceptTextBoxes(this, 50);
                };
            }
        }

        private void MenuLogin_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
        }

        private void ApplyRoundedExceptTextBoxes(Control parent, int radius)
        {
            if (parent == null) return;

            // Si el parent es el Form, NO aplicamos al propio Form; procesamos solo sus hijos.
            if (parent is Form)
            {
                foreach (Control c in parent.Controls)
                {
                    if (c is not TextBox)
                    {
                        // Si es botón, usar radio específico para botones
                        if (c is Button)
                            RoundedControlHelper.RedondearBordes(c, ButtonRadius);
                        else
                            RoundedControlHelper.RedondearBordes(c, radius);

                    }
                    if (c.HasChildren) ApplyRoundedExceptTextBoxes(c, radius);
                }
                return;
            }

            // Para controles que no son el Form, aplicar normalmente (excepto TextBox)
            if (parent is not TextBox)
            {

                if (parent is Button)
                    RoundedControlHelper.RedondearBordes(parent, ButtonRadius);
                else
                    RoundedControlHelper.RedondearBordes(parent, radius);
            }

            foreach (Control c in parent.Controls)
            {
                if (c is not TextBox)
                {

                    if (c is Button)
                        RoundedControlHelper.RedondearBordes(c, ButtonRadius);
                    else
                        RoundedControlHelper.RedondearBordes(c, radius);

                }
                if (c.HasChildren) ApplyRoundedExceptTextBoxes(c, radius);
            }
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
            Usuario usuario = ObtenerUsuarioInputs();

            return Usuario.validarPassword(usuario);

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            /*
            if (!ValidarPassword())
            {
                MessageBox.Show("Ete usuario no esite", "Error", MessageBoxButtons.OK);
                return;
            }*/
            MenuPrincipal menuPrincipal = new MenuPrincipal(this);
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
