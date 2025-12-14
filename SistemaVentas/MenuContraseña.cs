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
    public partial class MenuContraseña : Form
    {
        private MenuPrincipal parentForm;
        private Usuario usuario;
        private readonly Resizer resizer = new Resizer();
        public MenuContraseña(Usuario usuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            RoundedControlHelper.RedondearTodosLosPaneles(this, 15);
            this.usuario = usuario;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // si la contraseña no e valida, no hace na
            if (!Validar()) return;

            string password = inpConfirmarContrasena.Text.Trim();
            usuario.password = password;


        private bool Validar()
        {
            string nuevaPassword = inpNuevaContrasena.Text.Trim();
            string confirmarPassword = inpConfirmarContrasena.Text.Trim();
            if (!Validador.ValidarTamanoPermitido(nuevaPassword, 30, 6))
            {
                MessageBox.Show("La nueva contraseña debe tener entre 6 y 30 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(nuevaPassword != confirmarPassword)
            {
                MenuLogin menuLogin = new MenuLogin();
                MenuPrincipal menuPrincipal = new MenuPrincipal(menuLogin);
                menuPrincipal.Show();
            }
            return true;
        }
    }
}
