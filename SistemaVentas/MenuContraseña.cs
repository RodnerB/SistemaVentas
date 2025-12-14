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

        public MenuContraseña()
        {
            InitializeComponent();

            RoundedControlHelper.RedondearTodosLosPaneles(this, 15);
            RoundedControlHelper.RedondearTodosLosBotones(this, 15);
        }


        public MenuContraseña(MenuPrincipal parent) : this()
        {
            parentForm = parent;
        }



        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            if (parentForm != null)
            {
                parentForm.Show();
            }
            else
            {
                MenuLogin menuLogin = new MenuLogin();
                MenuPrincipal menuPrincipal = new MenuPrincipal(menuLogin);
                menuPrincipal.Show();
            }
            this.Hide();
        }
    }
}
