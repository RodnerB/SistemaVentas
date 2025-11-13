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
    public partial class Form2 : Form
    {
        Form1 formMenuPrincipal; // variable de referencia al formulario principal

        public Form2()
        {
            InitializeComponent();
        }

        //  Constructor que recibe una referencia al formulario principal
        public Form2(Form1 MenuPrincipal)
        {
            InitializeComponent(); // Inicializa los componentes gráficos del formulario
            formMenuPrincipal = MenuPrincipal; // Guarda la referencia del formulario principal que abrió este formulario
        }
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Evento del botón para volver al menú principal
        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.Show(); // Muestra el formulario principal nuevamente
            this.Close(); //Cierra el formulario actual de clientes
        }
    }
}
