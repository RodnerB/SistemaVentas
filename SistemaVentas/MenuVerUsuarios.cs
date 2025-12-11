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

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                resizer.CaptureOriginalSizes(this);
                Resize += MenuVerUsuarios_Resize;

                RoundedControlHelper.RedondearTodosLosPaneles(this, 12);
                RoundedControlHelper.RedondearTodosLosBotones(this, 12);
            }
        }

        private void MenuVerUsuarios_Resize(object? sender, EventArgs e)
        {
            resizer.ResizeControls(this);

            RoundedControlHelper.RedondearTodosLosPaneles(this, 12);
            RoundedControlHelper.RedondearTodosLosBotones(this, 12);
        }

        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            parentMenuConfiguracion.Show();
            Close();
        }
    }
}
