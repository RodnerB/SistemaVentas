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
    public partial class Form7 : Form
    {
        Form1 formMenuPrincipal; // variable de referencia al formulario principal
 
        // Constructor que recibe una referencia al formulario principal
        public Form7(Form1 MenuPrincipal)
        {
            InitializeComponent(); // Inicializa los componentes gráficos del formulario
            this.formMenuPrincipal = MenuPrincipal; // Guarda la referencia del formulario principal que abrió este formulario
            CargarEmpresa();
        }

        // Evento del botón para volver al menú principal
        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.formMenuPrincipal.Show();// Muestra el formulario principal nuevamente
            this.Close(); //Cierra el formulario actual de clientes
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarEmpresa();
            MessageBox.Show("Empresa guardada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GuardarEmpresa()
        {
            Empresa empresa = new Empresa(
                inpEmpresa.Text,
                inpDireccion.Text,
                inpTelefono.Text,
                inpFax.Text,
                inpEmail.Text
            );

            Empresa.InsertarEmpresa(empresa);
        }

        private void CargarEmpresa()
        {   try
            {
                Empresa empresa = Empresa.ObtenerEmpresa();
                inpEmpresa.Text = empresa.empresa;
                inpDireccion.Text = empresa.direccion;
                inpTelefono.Text = empresa.telefono;
                inpFax.Text = empresa.fax;
                inpEmail.Text = empresa.email;
            }

            catch(Exception ex)
            {
                return;
            }
        }

    }
}
