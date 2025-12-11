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
                this.StartPosition = FormStartPosition.CenterScreen;

                // Aplicar redondeo a todos los controles excepto los TextBox
                ApplyRoundedExceptTextBoxes(this, 12);
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
                this.StartPosition = FormStartPosition.CenterScreen;

                // Aplicar redondeo a todos los controles excepto los TextBox
                ApplyRoundedExceptTextBoxes(this, 12);
            }

            this.formMenuPrincipal = MenuPrincipal; // Guarda la referencia del formulario principal que abrió este formulario
            CargarEmpresa();
        }

        private void MenuConfiguracion_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
        }

        // Recorre recursivamente el árbol de controles y aplica el helper salvo a los TextBox
        private void ApplyRoundedExceptTextBoxes(Control parent, int radius)
        {
            if (parent == null) return;

            foreach (Control c in parent.Controls)
            {
                if (c is not TextBox)
                {
                    // No redondear TextBox
                    // Aplicar el redondeo usando la clase existente
                    RoundedControlHelper.RedondearBordes(c, radius);
                }

                if (c.HasChildren)
                {
                    ApplyRoundedExceptTextBoxes(c, radius);
                }
            }
        }

        // Evento del botón para volver al menú principal
        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.Show(); // Muestra el formulario principal nuevamente
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

            empresa.InsertarEmpresa();
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
            catch (Exception)
            {
                return;
            }
        }

    }
}
