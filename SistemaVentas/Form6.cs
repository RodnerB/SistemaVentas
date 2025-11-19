using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SistemaVentas
{
    public partial class Form6 : Form
    {
        Form1 formMenuPrincipal; // variable de referencia al formulario principal


        // Constructor que recibe una referencia al formulario principal
        public Form6(Form1 formMenuPrincipal)
        {
            InitializeComponent(); // Inicializa los componentes gráficos del formulario
            this.formMenuPrincipal = formMenuPrincipal; // Guarda la referencia del formulario principal que abrió este formulario
            this.StartPosition = FormStartPosition.CenterScreen;

            CargarUnidades();
            txtCodUni.KeyDown += DetectarunidadMedidaEvento;
            
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.KeyDown += EventoMoverConEnter;
                }
            }
        }

        private void CargarUnidades()
        {
            try
            {
                UnidadesMedida.ObtenerUnidadesMedida(dgvUnidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las unidades de medida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         private void GuardarUnidad(UnidadesMedida unidad)
        {
            try
            {
                using (var conexion = ConexionDB.ObtenerConexion())
                {
                    string consulta = "INSERT INTO SFTUNID0 (CODUNI, DESUNI) VALUES (@CODUNI, @DESUNI)";
                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@CODUNI", unidad.CodigoUnidad ?? "");
                        comando.Parameters.AddWithValue("@DESUNI", unidad.DescripcionUnidad ?? "");

                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Unidad guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarUnidades();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar la unidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la unidad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarUnidad(UnidadesMedida unidad)
        {
            try
            {
                using (var conexion = ConexionDB.ObtenerConexion())
                {
                    string consulta = "UPDATE SFTUNID0 SET DESUNI = @DESUNI WHERE CODUNI = @CODUNI";
                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@CODUNI", unidad.CodigoUnidad ?? "");
                        comando.Parameters.AddWithValue("@DESUNI", unidad.DescripcionUnidad ?? "");

                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Unidad modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarUnidades();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar la unidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la unidad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarUnidad(string codigoUnidad)
        {
            try
            {
                using (var conexion = ConexionDB.ObtenerConexion())
                {
                    string consulta = "DELETE FROM SFTUNID0 WHERE CODUNI = @CODUNI";
                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@CODUNI", codigoUnidad ?? "");

                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Unidad eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarUnidades();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la unidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la unidad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private UnidadesMedida? BuscarUnidadesMedida(string codigoUnidad)
        {
            return UnidadesMedida.ObtenerUnidadMedidaPorCodigo(codigoUnidad);
        }

        private void DetectarunidadMedidaEvento(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCodUni.Text.Length > 0)
            {
                // si la unidad es encontrada, rellena automáticamente los campos
                UnidadesMedida? unidad = BuscarUnidadesMedida(txtCodUni.Text);
                if (unidad != null)
                {
                    txtDesUni.Text = unidad.DescripcionUnidad;
                }
            }
        }

        private UnidadesMedida ObtenerUnidad()
        {
            return new UnidadesMedida()
            {
                CodigoUnidad = txtCodUni.Text,
                DescripcionUnidad = txtDesUni.Text
            };
        }

        // Evento del botón para volver al menú principal
        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.formMenuPrincipal.Show(); // Muestra el formulario principal nuevamente
            this.Close(); //Cierra el formulario actual de clientes
        }

        private void btnAgregarUni_Click(object sender, EventArgs e) => GuardarUnidad(ObtenerUnidad());

        private void btnModificarUni_Click(object sender, EventArgs e) => ModificarUnidad(ObtenerUnidad());

        private void btnEliminarUni_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodUni.Text))
            {
                MessageBox.Show("Debe escribir el código de la unidad a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            eliminarUnidad(txtCodUni.Text);
        }

        private void btnBuscarUni_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodUni.Text)) return;

            UnidadesMedida? unidadMedia = UnidadesMedida.ObtenerUnidadMedidaPorCodigo(txtCodUni.Text);
            if (unidadMedia != null)
            {
                txtDesUni.Text = unidadMedia.DescripcionUnidad;
            }
            else
            {
                MessageBox.Show("Unidad de medida no encontrada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EventoMoverConEnter(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
