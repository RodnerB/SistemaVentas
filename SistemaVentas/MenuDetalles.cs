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
    public partial class MenuDetalles : Form
    {
        MenuPrincipal formMenuPrincipal; // variable de referencia al formulario principal
        public MenuDetalles()
        {
            InitializeComponent();
        }

        // Constructor que recibe una referencia al formulario principal
        public MenuDetalles(MenuPrincipal formMenuPrincipal)
        {
            InitializeComponent();  // Inicializa los componentes gráficos del formulario
            this.formMenuPrincipal = formMenuPrincipal; // Guarda la referencia del formulario principal que abrió este formulario
        }

        // Evento del botón para volver al menú principal
        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.Show();// Muestra el formulario principal nuevamente
            this.Close();//Cierra el formulario actual de clientes
        }
    }
}
