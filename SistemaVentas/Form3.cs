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
using SistemaVentas; 

namespace SistemaVentas
{
    public partial class Form3 : Form
    {
        Form1 formMenuPrincipal; // referencia al formulario principal

        // Constructor con referencia al formulario principal
        public Form3(Form1 MenuPrincipal)
        {
            InitializeComponent();
            formMenuPrincipal = MenuPrincipal;
            CargarArticulos();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        // Método para cargar los artículos en el DataGridView
        private void CargarArticulos()
        {
            try
            {
                Articulos.ObtenerArticulos(dgvArticulos); // Llama al método estático para cargar los artículos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar artículos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Método para guardar un nuevo artículo
        private void GuardarArticulo(Articulos articulo)
        {
            try
            {
                //  Conexión a la base de datos
                using (var conexion = ConexionDB.ObtenerConexion())
                {
                    // Consulta SQL para insertar un nuevo artículo
                    string consulta = @"
                        INSERT INTO SFTARTI0 (CODART, DESART, CODUNI, EXIMIN, EXIMAX, EXIACT, PREART, COSART)
                        VALUES (@CODART, @DESART, @CODUNI, @EXIMIN, @EXIMAX, @EXIACT, @PREART, @COSART)";
                    using (var comando = new Microsoft.Data.SqlClient.SqlCommand(consulta, conexion)) // Crear el comando SQL
                    {
                        // Agregar los parámetros al comando
                        comando.Parameters.AddWithValue("@CODART", articulo.CodigoArticulo ?? "");// Asegurarse de no pasar null
                        comando.Parameters.AddWithValue("@DESART", articulo.DescripcionArticulo ?? "");// Asegurarse de no pasar null
                        comando.Parameters.AddWithValue("@CODUNI", articulo.CodigoUnidad ?? "");// Asegurarse de no pasar null
                        comando.Parameters.AddWithValue("@EXIMIN", articulo.ExistenciaMinima ?? 0);// Usar 0 si es null
                        comando.Parameters.AddWithValue("@EXIMAX", articulo.ExistenciaMaxima ?? 0);// Usar 0 si es null
                        comando.Parameters.AddWithValue("@EXIACT", articulo.ExistenciaActual ?? 0);// Usar 0 si es null
                        comando.Parameters.AddWithValue("@PREART", articulo.PrecioArticulo ?? 0);// Usar 0 si es null
                        comando.Parameters.AddWithValue("@COSART", articulo.CostoArticulo ?? 0);// Usar 0 si es null

                        int filasAfectadas = comando.ExecuteNonQuery(); // Ejecutar el comando
                        if (filasAfectadas > 0) // Verificar si se insertó correctamente
                        {
                            MessageBox.Show("Artículo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarArticulos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Método para modificar un artículo existente
        private void ModificarArticulo(Articulos articulo)
        {
            try
            {
                using (var conexion = ConexionDB.ObtenerConexion())
                {
                    string consulta = @"
                        UPDATE SFTARTI0 SET 
                            DESART = @DESART,
                            CODUNI = @CODUNI,
                            EXIMIN = @EXIMIN,
                            EXIMAX = @EXIMAX,
                            EXIACT = @EXIACT,
                            PREART = @PREART,
                            COSART = @COSART
                        WHERE CODART = @CODART";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@CODART", articulo.CodigoArticulo ?? "");
                        comando.Parameters.AddWithValue("@DESART", articulo.DescripcionArticulo ?? ""); // Asegurarse de no pasar null
                        comando.Parameters.AddWithValue("@CODUNI", articulo.CodigoUnidad ?? "");
                        comando.Parameters.AddWithValue("@EXIMIN", articulo.ExistenciaMinima ?? 0); // Usar 0 si es null
                        comando.Parameters.AddWithValue("@EXIMAX", articulo.ExistenciaMaxima ?? 0); // Usar 0 si es null
                        comando.Parameters.AddWithValue("@EXIACT", articulo.ExistenciaActual ?? 0); // Usar 0 si es null
                        comando.Parameters.AddWithValue("@PREART", articulo.PrecioArticulo ?? 0); // Usar 0 si es null
                        comando.Parameters.AddWithValue("@COSART", articulo.CostoArticulo ?? 0); // Usar 0 si es null

                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Artículo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarArticulos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar el artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Método para eliminar un artículo
        private void EliminarArticulo(string codigoArticulo)
        {
            try
            {
                using (var conexion = ConexionDB.ObtenerConexion())
                {
                    string consulta = "DELETE FROM SFTARTI0 WHERE CODART = @CODART";
                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@CODART", codigoArticulo);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Artículo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarArticulos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Articulos? BuscarArticulo(string codigoArticulo)
        {
            return Articulos.ObtenerArticuloPorCodigo(codigoArticulo);
        }

        private Articulos ObtenerArticulo()
        {
            return new Articulos()
            {
                CodigoArticulo = txtCodArt.Text,
                DescripcionArticulo = txtDesArt.Text,
                CodigoUnidad = cmbCodUni.Text,
                ExistenciaMinima = int.TryParse(txtExiMin.Text, out int exMin) ? exMin : 0,
                ExistenciaMaxima = int.TryParse(txtExiMax.Text, out int exMax) ? exMax : 0,
                ExistenciaActual = int.TryParse(txtExiAct.Text, out int exAct) ? exAct : 0,
                PrecioArticulo = decimal.TryParse(txtPreArt.Text, out decimal pre) ? pre : 0,
                CostoArticulo = decimal.TryParse(txtCosArt.Text, out decimal cos) ? cos : 0
            };
        }

        // Eventos de botones
        private void btnAgregarArt_Click(object sender, EventArgs e) => GuardarArticulo(ObtenerArticulo()); // Llama al método para guardar un nuevo artículo
        private void btnModificarArt_Click(object sender, EventArgs e) => ModificarArticulo(ObtenerArticulo()); // Llama al método para modificar un artículo existente
        private void btnEliminarArt_Click(object sender, EventArgs e) // Llama al método para eliminar un artículo
        {
            if (string.IsNullOrWhiteSpace(txtCodArt.Text))
            {
                MessageBox.Show("Debe escribir el código del artículo a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            EliminarArticulo(txtCodArt.Text);
        }
        // Evento para buscar un artículo por su código
        private void btnBuscarArt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodArt.Text)) return;

            Articulos? articulo = BuscarArticulo(txtCodArt.Text);
            if (articulo != null)
            {
                txtDesArt.Text = articulo.DescripcionArticulo;
                cmbCodUni.Text = articulo.CodigoUnidad;
                txtExiMin.Text = articulo.ExistenciaMinima?.ToString() ?? "";
                txtExiMax.Text = articulo.ExistenciaMaxima?.ToString() ?? "";
                txtExiAct.Text = articulo.ExistenciaActual?.ToString() ?? "";
                txtPreArt.Text = articulo.PrecioArticulo?.ToString() ?? "";
                txtCosArt.Text = articulo.CostoArticulo?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Artículo no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.Show();
            this.Close();

        }
    }
}
