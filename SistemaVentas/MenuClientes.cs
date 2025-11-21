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
    public partial class MenuClientes : Form
    {
        bool existeElCliente = false;
        MenuPrincipal formMenuPrincipal; // variable de referencia al formulario principal

        //  Constructor que recibe una referencia al formulario principal
        public MenuClientes(MenuPrincipal MenuPrincipal)
        {
            InitializeComponent(); // Inicializa los componentes gráficos del formulario
            formMenuPrincipal = MenuPrincipal; // Guarda la referencia del formulario principal que abrió este formulario
            CargarClientes();
            this.StartPosition = FormStartPosition.CenterScreen;


            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
#pragma warning disable CS8622 // La nulabilidad de los tipos de referencia del tipo de parámetro no coincide con el delegado de destino (posiblemente debido a los atributos de nulabilidad).
                    c.KeyDown += EventoMoverConEnter;
#pragma warning restore CS8622 // La nulabilidad de los tipos de referencia del tipo de parámetro no coincide con el delegado de destino (posiblemente debido a los atributos de nulabilidad).
                }
            }

            // Cuando el formulario se muestre, establecer el foco en la primera casilla de texto
            this.Shown += Form2_Shown;
        }

        private void Form2_Shown(object? sender, EventArgs e)
        {
            // Ajustar el nombre del control si la primera caja no es `inpCodCliente`
            inpCodCliente?.Focus();
        }

        private void CargarClientes()
        {
            Cliente.ObtenerClientes(dgvClientes);
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
            try
            {
                Cliente? cliente = Cliente.ObtenerClientePorCodigo(codigoCliente);
                if (cliente == null)
                {
                    MessageBox.Show("El cliente no existe.", "No Encontrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        private void GuardarCliente(Cliente cliente)
        {
            if (Cliente.InsertarCliente(cliente))
            {
                MessageBox.Show("Cliente guardado exitosamente", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes(); // Recarga la lista de clientes después de agregar uno
            } else
            {
                MessageBox.Show("Error al guardar el cliente", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarCliente(Cliente cliente)
        {
            if (cliente.CodigoCliente == null) return;
            string codigoCliente = cliente.CodigoCliente;
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
        private void EventoMoverConEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evita sonido y salto de línea

                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private Cliente ObtenerClienteEnInputs()
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
                LimiteCreditoCliente = Convert.ToDecimal(inpCredCliente.Text == "" ? 0 : inpCredCliente.Text),
                BalanceActualCliente = Convert.ToDecimal(inpBalCliente.Text == "" ? 0 : inpBalCliente.Text),
                ObservacionesCliente = inpObsCliente.Text
            };
        }


        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            GuardarCliente(ObtenerClienteEnInputs());
        }

        private void btnEliminarCli_Click(object sender, EventArgs e)
        {
            Cliente? cliente = BuscarCliente(inpCodCliente.Text);
            if (cliente == null) return;
            EliminarCliente(cliente);
        }

        private void btnModificarCli_Click(object sender, EventArgs e)
        {
            Cliente? cliente = BuscarCliente(inpCodCliente.Text);
            if (cliente == null) return;
            ModificarClientes(cliente);
        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {

            Cliente cliente = BuscarCliente(inpCodCliente.Text);
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
                existeElCliente = true;
            }
            btnModificarCli.Enabled = existeElCliente;
            btnEliminarCli.Enabled = existeElCliente;
            btnAgregarCliente.Enabled = true; 
        }
    }
}