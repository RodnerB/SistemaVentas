using SistemaVentas.Utilidades;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class MenuVerUsuarios : Form
    {
        private readonly MenuConfiguracion parentMenuConfiguracion;
        private readonly Resizer resizer = new Resizer();

        public MenuVerUsuarios(MenuConfiguracion menuConfiguracion)
        {
            InitializeComponent();
            parentMenuConfiguracion = menuConfiguracion;

            // Evitar ejecutar lógica en tiempo de diseño
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                // Inicializar resizer
                resizer.CaptureOriginalSizes(this);
                Resize += MenuVerUsuarios_Resize;

               
                ApplyRoundedExceptTextBoxes(this, 12);
            }
        }

        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            parentMenuConfiguracion.Show();
            Close();
        }

        private void MenuVerUsuarios_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);
        }

        private void ApplyRoundedExceptTextBoxes(Control parent, int radius)
        {
            if (parent == null) return;

            if (parent is Form)
            {
                foreach (Control c in parent.Controls)
                {
                    if (c is not TextBox)
                    {
                        RoundedControlHelper.RedondearBordes(c, radius);
                    }

                    if (c.HasChildren)
                    {
                        ApplyRoundedExceptTextBoxes(c, radius);
                    }
                }

                return;
            }

            if (parent is not TextBox)
            {
                RoundedControlHelper.RedondearBordes(parent, radius);
            }

            foreach (Control c in parent.Controls)
            {
                if (c is not TextBox)
                {
                    RoundedControlHelper.RedondearBordes(c, radius);
                }

                if (c.HasChildren)
                {
                    ApplyRoundedExceptTextBoxes(c, radius);
                }
            }
        }
    }
}
