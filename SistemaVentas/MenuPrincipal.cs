using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;

namespace SistemaVentas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += MenuPrincipal_Load;
        }

        private void MenuPrincipal_Load(object? sender, EventArgs e)
        {
            // Redondear todos los paneles existentes en el formulario
            RoundedControlHelper.RedondearTodosLosPaneles(this, 20);

            btnSalir.TabStop = false;
            btnSalir.FlatAppearance.BorderSize = 0;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de clientes
            MenuClientes clientes = new MenuClientes(this);
            clientes.Show(); //Mostrar el formulario de clientes
            this.Hide(); //Ocultar el formulario principal
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de articulos
            MenuArticulos articulos = new MenuArticulos(this);
            articulos.Show(); //Mostrar el formulario de articulos
            this.Hide(); //Ocultar el formulario principal 
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de facturacion
            MenuFacturas facturacion = new MenuFacturas(this);
            facturacion.Show(); // Mostrar el formulario de facturacion 
            this.Hide(); // Ocultar el formulario principal
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de detalles
            MenuDetalles detalles = new MenuDetalles(this);
            detalles.Show(); // Mostrar el formulario de detalles
            this.Hide(); // Ocultar el formulario principal
        }

        private void btnUnidadesDeMedida_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de unidades de medida
            MenuUnidadesMedidas unidadesdemedida = new MenuUnidadesMedidas(this);
            unidadesdemedida.Show(); // Mostrar el formulario de unidades de medida
            this.Hide(); // Ocultar el formulario principal
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de configuracion
            MenuConfiguracion configuracion = new MenuConfiguracion(this);
            configuracion.Show(); // Mostrar el formulario de configuracion
            this.Hide(); // Ocultar el formulario principal
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que deseas salir?",
                                         "Confirmar",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

