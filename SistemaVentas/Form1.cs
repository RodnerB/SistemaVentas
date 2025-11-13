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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSistemaDeFacturacion_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de clientes
            Form2 clientes = new Form2(this);
            clientes.Show(); //Mostrar el formulario de clientes
            this.Hide(); //Ocultar el formulario principal
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de articulos
            Form3 articulos = new Form3(this);
            articulos.Show(); //Mostrar el formulario de articulos
            this.Hide(); //Ocultar el formulario principal 
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de facturacion
            Form4 facturacion = new Form4(this);
            facturacion.Show(); // Mostrar el formulario de facturacion 
            this.Hide(); // Ocultar el formulario principal
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de detalles
            Form5 detalles = new Form5(this);
            detalles.Show(); // Mostrar el formulario de detalles
            this.Hide(); // Ocultar el formulario principal
        }

        private void btnUnidadesDeMedida_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de unidades de medida
            Form6 unidadesdemedida = new Form6(this);
            unidadesdemedida.Show(); // Mostrar el formulario de unidades de medida
            this.Hide(); // Ocultar el formulario principal
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de configuracion
            Form7 configuracion = new Form7(this);
            configuracion.Show(); // Mostrar el formulario de configuracion
            this.Hide(); // Ocultar el formulario principal
        }
    }
}
