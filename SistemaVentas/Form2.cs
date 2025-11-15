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
using System.Linq.Expressions;

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

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Busca clientes mediante el codigo del cliente
        private bool BuscarCliente(string codigoCliente)
        {
            bool clienteEncontrado = false;
            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    string consulta = "SELECT CODCLI, NOMCLI FROM SFTCLIE0 WHERE CODCLI = @CodigoCliente";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@CodigoCliente", codigoCliente);

                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read())
                    {
                        // Mostrar los datos del cliente en los controles correspondientes
                        inpCodCliente.Text = lector["CODCLI"].ToString();
                        inpNomCliente.Text = lector["NOMCLI"].ToString();
                        clienteEncontrado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return clienteEncontrado;
        }

        public void GuardarCliente(int[] cliente)
        {


        }

        // Evento del botón para volver al menú principal
        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.Show(); // Muestra el formulario principal nuevamente
            this.Close(); //Cierra el formulario actual de clientes
        }

        private void EventoTeclaPresionada(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && inpCodCliente.Text.Length > 0)
            {
                // si el cliente NO es encontrado, enfoca el proximo input
                if (!BuscarCliente(inpCodCliente.Text))
                    inpNomCliente.Focus();
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}