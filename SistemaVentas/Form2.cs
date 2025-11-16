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
using System.Runtime.CompilerServices;

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

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.KeyDown += EventoMoverConEnter;
                }
            }
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

                    dgvClientes.Columns["CODCLI"].HeaderText = "Código Cliente";
                    dgvClientes.Columns["NOMCLI"].HeaderText = "Nombre Cliente";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarClientes(Cliente cliente)
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    string consulta = @"UPDATE SFTCLIE0 SET
                                        NOMCLI = @NOMCLI,
                                        APECLI = @APECLI,
                                        DIRCLI = @DIRCLI,
                                        SECCLI = @SECCLI,
                                        CIUCLI = @CIUCLI,
                                        TELCLI = @TELCLI,
                                        NUMFAX = @NUMFAX,
                                        LIMCRE = @LIMCRE,
                                        BALCLI = @BALCLI,
                                        OBSCLI = @OBSCLI
                                    WHERE CODCLI = @CODCLI";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@CODCLI", cliente.CodigoCliente);
                        comando.Parameters.AddWithValue("@NOMCLI", cliente.NombreCliente);
                        comando.Parameters.AddWithValue("@APECLI", cliente.ApellidoCliente);
                        comando.Parameters.AddWithValue("@DIRCLI", cliente.DireccionCliente);
                        comando.Parameters.AddWithValue("@SECCLI", cliente.SectorCliente);
                        comando.Parameters.AddWithValue("@CIUCLI", cliente.CiudadCliente);
                        comando.Parameters.AddWithValue("@TELCLI", cliente.TelefonoCliente);
                        comando.Parameters.AddWithValue("@NUMFAX", cliente.FaxCliente);
                        comando.Parameters.AddWithValue("@LIMCRE", cliente.LimiteCreditoCliente);
                        comando.Parameters.AddWithValue("@BALCLI", cliente.BalanceActualCliente);
                        comando.Parameters.AddWithValue("@OBSCLI", cliente.ObservacionesCliente);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente modificado exitosamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarClientes(); // Recarga la lista de clientes después de modificar uno
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar el cliente.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Busca clientes mediante el codigo del cliente
        private Cliente? BuscarCliente(string codigoCliente)
        {
            Cliente? cliente = null;
            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    string consulta = "SELECT * FROM SFTCLIE0 WHERE CODCLI = @CodigoCliente";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@CodigoCliente", codigoCliente);

                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read())
                    {
                        // Mostrar los datos del cliente en los controles correspondientes
                        inpCodCliente.Text = lector["CODCLI"].ToString();
                        inpNomCliente.Text = lector["NOMCLI"].ToString();
                        cliente = new Cliente
                        {
                            CodigoCliente = lector["CODCLI"] is DBNull ? "" : lector["CODCLI"].ToString(),
                            NombreCliente = lector["NOMCLI"] is DBNull ? "" : lector["NOMCLI"].ToString(),
                            ApellidoCliente = lector["APECLI"] is DBNull ? "" : lector["APECLI"].ToString(),
                            DireccionCliente = lector["DIRCLI"] is DBNull ? "" : lector["DIRCLI"].ToString(),
                            SectorCliente = lector["SECCLI"] is DBNull ? "" : lector["SECCLI"].ToString(),
                            CiudadCliente = lector["CIUCLI"] is DBNull ? "" : lector["CIUCLI"].ToString(),
                            TelefonoCliente = lector["TELCLI"] is DBNull ? "" : lector["TELCLI"].ToString(),
                            FaxCliente = lector["NUMFAX"] is DBNull ? "" : lector["NUMFAX"].ToString(),
                            LimiteCreditoCliente = Convert.ToDecimal(lector["LIMCRE"]),
                            BalanceActualCliente = Convert.ToDecimal(lector["BALCLI"]),
                            ObservacionesCliente = lector["OBSCLI"] is DBNull ? "" : lector["OBSCLI"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return cliente;
        }

        private void GuardarCliente(Cliente cliente)
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    string consulta = "INSERT INTO SFTCLIE0 (CODCLI, NOMCLI, APECLI, DIRCLI, SECCLI, CIUCLI, TELCLI, NUMFAX, LIMCRE, BALCLI, OBSCLI) " +
                                        "VALUES (@CODCLI, @NOMCLI, @APECLI, @DIRCLI, @SECCLI, @CIUCLI, @TELCLI, @NUMFAX, @LIMCRE, @BALCLI, @OBSCLI)";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@CODCLI", cliente.CodigoCliente);
                        comando.Parameters.AddWithValue("@NOMCLI", cliente.NombreCliente);
                        comando.Parameters.AddWithValue("@APECLI", cliente.ApellidoCliente);
                        comando.Parameters.AddWithValue("@DIRCLI", cliente.DireccionCliente);
                        comando.Parameters.AddWithValue("@SECCLI", cliente.SectorCliente);
                        comando.Parameters.AddWithValue("@CIUCLI", cliente.CiudadCliente);
                        comando.Parameters.AddWithValue("@TELCLI", cliente.TelefonoCliente);
                        comando.Parameters.AddWithValue("@NUMFAX", cliente.FaxCliente);
                        comando.Parameters.AddWithValue("@LIMCRE", cliente.LimiteCreditoCliente);
                        comando.Parameters.AddWithValue("@BALCLI", cliente.BalanceActualCliente);
                        comando.Parameters.AddWithValue("@OBSCLI", cliente.ObservacionesCliente);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente guardado exitosamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarClientes(); // Recarga la lista de clientes después de guardar uno nuevo
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el cliente.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void EliminarCliente(string codigoCliente)
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    string consulta = "DELETE FROM SFTCLIE0 WHERE CODCLI = @CodigoCliente";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@CodigoCliente", codigoCliente);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente eliminado exitosamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarClientes(); // Recarga la lista de clientes después de eliminar uno
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el cliente.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento del botón para volver al menú principal
        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.Show(); // Muestra el formulario principal nuevamente
            this.Close(); //Cierra el formulario actual de clientes
        }

        private void DetectarClienteEvento(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && inpCodCliente.Text.Length > 0)
            {
                // si el cliente es encontrado, rellena automáticamente los campos
                Cliente? cliente = BuscarCliente(inpCodCliente.Text);
                if (cliente != null)
                {
                    inpNomCliente.Text = cliente.NombreCliente;
                    inpApeCliente.Text = cliente.ApellidoCliente;
                    inpDirCliente.Text = cliente.DireccionCliente;
                    inpSecCliente.Text = cliente.SectorCliente;
                    inpCiuCliente.Text = cliente.CiudadCliente;
                    inpTelCliente.Text = cliente.TelefonoCliente;
                    inpFaxCliente.Text = cliente.FaxCliente;
                    inpCredCliente.Text = cliente.LimiteCreditoCliente.ToString();
                    inpBalCliente.Text = cliente.BalanceActualCliente.ToString();
                    inpObsCliente.Text = cliente.ObservacionesCliente;

                }
            }
        }
        private void EventoMoverConEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evita sonido y salto de línea

                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private Cliente ObtenerCliente()
        {
            return new Cliente
            {
                CodigoCliente = inpCodCliente.Text,
                NombreCliente = inpNomCliente.Text,
                ApellidoCliente = inpApeCliente.Text,
                DireccionCliente = inpDirCliente.Text,
                SectorCliente = inpSecCliente.Text,
                CiudadCliente = inpCiuCliente.Text,
                TelefonoCliente = inpTelCliente.Text,
                FaxCliente = inpFaxCliente.Text,
                LimiteCreditoCliente = Convert.ToDecimal(inpCredCliente.Text),
                BalanceActualCliente = Convert.ToDecimal(inpBalCliente.Text),
                ObservacionesCliente = inpObsCliente.Text
            };
        }


        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            GuardarCliente(ObtenerCliente());
        }

        private void btnEliminarCli_Click(object sender, EventArgs e)
        {
            Cliente cliente = ObtenerCliente();
            EliminarCliente(cliente.CodigoCliente);
        }

        private void btnModificarCli_Click(object sender, EventArgs e)
        {
            Cliente? cliente = ObtenerCliente();
            ModificarClientes(cliente);
        }

        private void RefrezcarPagina(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F5)
            {
                // Crear una nueva instancia del mismo formulario
                Form2 nuevo = new Form2(formMenuPrincipal);

                // Mostrar el nuevo
                nuevo.Show();

                // Cerrar el actual
                this.Close();

            }
        }
    }
}