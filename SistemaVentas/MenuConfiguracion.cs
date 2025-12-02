using SistemaVentas.Utilidades;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class MenuConfiguracion : Form
    {
        private readonly Resizer resizer = new Resizer();
        private MenuPrincipal? formMenuPrincipal; // Permite valores null

        public MenuConfiguracion()
        {
            InitializeComponent();

            // Evitar ejecutar en tiempo de diseño
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                resizer.CaptureOriginalSizes(this);
                this.Resize += MenuConfiguracion_Resize;
            }
        }

        // Constructor que recibe una referencia al formulario principal
        public MenuConfiguracion(MenuPrincipal MenuPrincipal)
        {
            InitializeComponent();

            // Evitar ejecutar en tiempo de diseño
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                resizer.CaptureOriginalSizes(this);
                this.Resize += MenuConfiguracion_Resize;
            }

            this.formMenuPrincipal = MenuPrincipal; // Guarda la referencia del formulario principal que abrió este formulario
            CargarEmpresa();
        }

        // Evento del botón para volver al menú principal
        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            if (this.formMenuPrincipal != null)
            {
                this.formMenuPrincipal.Show(); // Muestra el formulario principal nuevamente
            }
            this.Close(); //Cierra el formulario actual de clientes
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarEmpresa();
            MessageBox.Show("Empresa guardada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GuardarEmpresa()
        {
            Empresa empresa = new Empresa(
                inpEmpresa.Text,
                inpDireccion.Text,
                inpTelefono.Text,
                inpFax.Text,
                inpEmail.Text
            );

            Empresa.InsertarEmpresa(empresa);
        }

        private void CargarEmpresa()
        {
            try
            {
                Empresa empresa = Empresa.ObtenerEmpresa();
                inpEmpresa.Text = empresa.empresa;
                inpDireccion.Text = empresa.direccion;
                inpTelefono.Text = empresa.telefono;
                inpFax.Text = empresa.fax;
                inpEmail.Text = empresa.email;
            }
            catch(Exception)
            {
                return;
            }
        }

        private void MenuConfiguracion_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
        }
    }
}
