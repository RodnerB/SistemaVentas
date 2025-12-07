using SistemaVentas.Utilidades;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

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
                ApplyRoundedCornersToControls(12); // Aplica redondeo al inicializar (no afecta Form ni TextBox)
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
                ApplyRoundedCornersToControls(12); // Aplica redondeo al inicializar (no afecta Form ni TextBox)
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
            catch (Exception)
            {
                return;
            }
        }

        private void MenuConfiguracion_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
            ApplyRoundedCornersToControls(12); // Reaplica el redondeo tras el redimensionado
        }

        // Aplica esquinas redondeadas recursivamente a los controles del formulario,
        // excluyendo el propio Form y los TextBox.
        private void ApplyRoundedCornersToControls(int radius)
        {
            foreach (Control ctrl in this.Controls)
            {
                ApplyRoundedCornersRecursive(ctrl, radius);
            }
        }

        private void ApplyRoundedCornersRecursive(Control ctrl, int radius)
        {
            // No modificar el Form ni los TextBox
            if (ctrl is Form || ctrl is TextBox)
            {
                // Recurse en hijos solo si no queremos cambiar la región del TextBox, 
                // pero sí mantener hijos (por ejemplo paneles dentro del TextBox no existen usualmente)
                foreach (Control child in ctrl.Controls)
                {
                    ApplyRoundedCornersRecursive(child, radius);
                }
                return;
            }

            // Evitar aplicar a controles con tamaño 0
            if (ctrl.Width > 0 && ctrl.Height > 0)
            {
                using (GraphicsPath path = RoundedRectPath(new Rectangle(0, 0, ctrl.Width, ctrl.Height), radius))
                {
                    // Asignar la región redondeada
                    ctrl.Region = new Region(path);
                }
            }

            // Recurse a los hijos
            foreach (Control child in ctrl.Controls)
            {
                ApplyRoundedCornersRecursive(child, radius);
            }
        }

        private GraphicsPath RoundedRectPath(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            if (diameter > bounds.Width) diameter = bounds.Width;
            if (diameter > bounds.Height) diameter = bounds.Height;
            int rx = diameter / 2;
            // Si el radio es 0 o el control es demasiado pequeño, devolver recta
            if (radius <= 0 || bounds.Width == 0 || bounds.Height == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // Asegurar que los arcos no se salgan de los límites
            path.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
