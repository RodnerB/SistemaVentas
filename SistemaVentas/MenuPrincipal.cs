using SistemaVentas.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class MenuPrincipal : Form
    {
        private readonly UtilidadesUI resizer = new UtilidadesUI();
        private readonly MenuLogin parentLogin;
        private Usuario usuario;

        public MenuPrincipal(MenuLogin parent, Usuario usuario = null)
        {
            InitializeComponent();
            parentLogin = parent;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += MenuPrincipal_Load;
            resizer.CaptureOriginalSizes(this);
            this.Resize += MenuPrincipal_Resize;
            this.usuario = usuario;
        }

        private void MenuPrincipal_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
        }

        private void MenuPrincipal_Load(object? sender, EventArgs e)
        {

            UtilidadesUI.RedondearTodosLosPaneles(this, 50);
            UtilidadesUI.RedondearBordes(btnCerrarSesion, 12);
            UtilidadesUI.RedondearBordes(picLogo, 15);

            btnCerrarSesion.TabStop = false;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
        }

        protected override void OnShown(EventArgs e)
        {
            if (usuario == null || usuario.password != usuario.usuario)
            {
                return;
            }
            MessageBox.Show("Por favor, cambie su contraseña por motivos de seguridad.", "Cambio de Contraseña Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            base.OnShown(e);

            MenuContraseña popup = new MenuContraseña(usuario);
            popup.ShowDialog(); 

        }
        
        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de clientes
            MenuClientes clientes = new MenuClientes(this);
            clientes.Show(); //Mostrar el formulario de clientes
            this.Hide(); //Ocultar el formulario principal
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de articulos
            MenuArticulos articulos = new MenuArticulos(this);
            articulos.Show(); //Mostrar el formulario de articulos
            this.Hide(); //Ocultar el formulario principal 
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de facturacion
            MenuFacturas facturacion = new MenuFacturas(this);
            facturacion.Show(); // Mostrar el formulario de facturacion 
            this.Hide(); // Ocultar el formulario principal
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de detalles
            MenuVentas detalles = new MenuVentas(this);
            detalles.Show(); // Mostrar el formulario de detalles
            this.Hide(); // Ocultar el formulario principal
        }

        private void btnUnidadesDeMedida_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de unidades de medida
            MenuUnidadesMedidas unidadesdemedida = new MenuUnidadesMedidas(this);
            unidadesdemedida.Show(); // Mostrar el formulario de unidades de medida
            this.Hide(); // Ocultar el formulario principal
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de configuracion
            MenuConfiguracion configuracion = new MenuConfiguracion(this);
            configuracion.Show(); // Mostrar el formulario de configuracion
            this.Hide(); // Ocultar el formulario principal
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que desea cerrar sesión?",
                                         "Confirmar",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question,
                                         MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                MenuLogin menuLogin = new MenuLogin();
                menuLogin.Show();
                this.Close();
            }
        }

       
    }
}

