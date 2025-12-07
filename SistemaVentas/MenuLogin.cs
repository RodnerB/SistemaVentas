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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
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
