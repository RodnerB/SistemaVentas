using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
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

        //  Constructor que recibe una referencia al formulario principal
        public Form2(Form1 MenuPrincipal)
        {
            InitializeComponent(); // Inicializa los componentes gráficos del formulario
            formMenuPrincipal = MenuPrincipal; // Guarda la referencia del formulario principal que abrió este formulario
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    string consulta = "SELECT CODCLI, NOMCLI FROM SFTCLIE0";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvClientes.DataSource = tabla;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
