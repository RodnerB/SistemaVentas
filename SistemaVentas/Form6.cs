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
    public partial class Form6 : Form
    {
        Form1 formMenuPrincipal; // variable de referencia al formulario principal
        public Form6()
        {
            InitializeComponent();
        }

        private void lblCodUni_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        // Constructor que recibe una referencia al formulario principal
        public Form6(Form1 formMenuPrincipal)
        {
            InitializeComponent(); // Inicializa los componentes gráficos del formulario
            this.formMenuPrincipal = formMenuPrincipal; // Guarda la referencia del formulario principal que abrió este formulario
        }

        // Evento del botón para volver al menú principal
        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.formMenuPrincipal.Show(); // Muestra el formulario principal nuevamente
            this.Close(); //Cierra el formulario actual de clientes
        }
    }
    
}
