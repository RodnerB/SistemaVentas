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
    public partial class MenuCuentasPorCobrar : Form
    {
        private Form formMenuPrincipal;

        public MenuCuentasPorCobrar(Form menuPrincipal)
        {
            InitializeComponent();
            formMenuPrincipal = menuPrincipal;


            // Aplicar redondeo a todos los controles excepto los TextBox
            UtilidadesUI.ApplyRoundedExceptTextBoxes(this, 12);

        }

        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.Show();
            this.Close();
        }


    }
}
