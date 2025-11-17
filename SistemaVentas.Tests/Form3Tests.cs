using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Moq;
using Xunit;
using SistemaVentas;

namespace SistemaVentas.Tests
{
    public class Form3Tests : IDisposable
    {
        private readonly string testTableName = "SFTARTI0_TEST";

        public Form3Tests()
        {
            // Usamos una base de datos de prueba
            CrearTablaTest();
        }

        public void Dispose()
        {
            // Limpieza: eliminar la tabla de prueba
            EliminarTablaTest();
        }

        private void CrearTablaTest()
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    string consulta = $@"
                        IF OBJECT_ID('{testTableName}', 'U') IS NOT NULL 
                            DROP TABLE {testTableName};
                        
                        CREATE TABLE {testTableName} (
                            CODART NVARCHAR(50) PRIMARY KEY,
                            DESART NVARCHAR(200),
                            CODUNI NVARCHAR(20),
                            EXIMIN INT,
                            EXIMAX INT,
                            EXIACT INT,
                            PREART DECIMAL(18,2),
                            COSART DECIMAL(18,2)
                        );";
                    
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear tabla de prueba: {ex.Message}");
            }
        }

        private void EliminarTablaTest()
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    string consulta = $"IF OBJECT_ID('{testTableName}', 'U') IS NOT NULL DROP TABLE {testTableName}";
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                // Ignorar errores al limpiar
            }
        }

        private void InsertarArticuloPrueba(string codigo, string descripcion, string unidad, 
            int exiMin, int exiMax, int exiAct, decimal precio, decimal costo)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = $@"INSERT INTO {testTableName} 
                    (CODART, DESART, CODUNI, EXIMIN, EXIMAX, EXIACT, PREART, COSART)
                    VALUES (@COD, @DES, @UNI, @EXIM, @EXIMAX, @EXIACT, @PRE, @COS)";
                
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@COD", codigo);
                    cmd.Parameters.AddWithValue("@DES", descripcion);
                    cmd.Parameters.AddWithValue("@UNI", unidad);
                    cmd.Parameters.AddWithValue("@EXIM", exiMin);
                    cmd.Parameters.AddWithValue("@EXIMAX", exiMax);
                    cmd.Parameters.AddWithValue("@EXIACT", exiAct);
                    cmd.Parameters.AddWithValue("@PRE", precio);
                    cmd.Parameters.AddWithValue("@COS", costo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Prueba 1: CargarArticulos() carga todos los artículos de la base de datos en dgvArticulos
        /// </summary>
        [Fact]
        public void CargarArticulos_DebeCargarTodosLosArticulosEnDataGridView()
        {
            // Arrange: Insertar artículos de prueba
            InsertarArticuloPrueba("ART001", "Artículo 1", "UNI", 5, 100, 50, 150.00m, 100.00m);
            InsertarArticuloPrueba("ART002", "Artículo 2", "KG", 10, 200, 75, 250.00m, 180.00m);
            InsertarArticuloPrueba("ART003", "Artículo 3", "LT", 3, 50, 25, 80.00m, 60.00m);

            // Act: Cargar artículos desde la base de datos
            DataTable resultado = new DataTable();
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = $"SELECT * FROM {testTableName}";
                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion))
                {
                    adaptador.Fill(resultado);
                }
            }

            // Assert: Verificar que se cargaron todos los artículos
            Assert.Equal(3, resultado.Rows.Count);
            Assert.Equal("ART001", resultado.Rows[0]["CODART"]);
            Assert.Equal("Artículo 1", resultado.Rows[0]["DESART"]);
            Assert.Equal("ART002", resultado.Rows[1]["CODART"]);
            Assert.Equal("ART003", resultado.Rows[2]["CODART"]);
        }

        /// <summary>
        /// Prueba 2: btnAgregarArt_Click() inserta exitosamente un nuevo artículo en la base de datos
        /// </summary>
        [Fact]
        public void AgregarArticulo_DebeInsertarNuevoArticuloEnBaseDatos()
        {
            // Arrange: Datos del nuevo artículo
            string codigo = "ART999";
            string descripcion = "Nuevo Artículo";
            string unidad = "UNI";
            int exiMin = 10;
            int exiMax = 100;
            int exiAct = 50;
            decimal precio = 200.00m;
            decimal costo = 150.00m;

            // Act: Insertar el artículo
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = $@"INSERT INTO {testTableName}  
                    (CODART, DESART, CODUNI, EXIMIN, EXIMAX, EXIACT, PREART, COSART)
                    VALUES (@COD, @DES, @UNI, @EXIM, @EXIMAX, @EXIACT, @PRE, @COS)";
                
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@COD", codigo);
                    cmd.Parameters.AddWithValue("@DES", descripcion);
                    cmd.Parameters.AddWithValue("@UNI", unidad);
                    cmd.Parameters.AddWithValue("@EXIM", exiMin);
                    cmd.Parameters.AddWithValue("@EXIMAX", exiMax);
                    cmd.Parameters.AddWithValue("@EXIACT", exiAct);
                    cmd.Parameters.AddWithValue("@PRE", precio);
                    cmd.Parameters.AddWithValue("@COS", costo);
                    cmd.ExecuteNonQuery();
                }
            }

            // Assert: Verificar que el artículo se insertó correctamente
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = $"SELECT * FROM {testTableName} WHERE CODART = @COD";
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@COD", codigo);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        Assert.True(dr.Read());
                        Assert.Equal(descripcion, dr["DESART"].ToString());
                        Assert.Equal(unidad, dr["CODUNI"].ToString());
                        Assert.Equal(exiMin, Convert.ToInt32(dr["EXIMIN"]));
                        Assert.Equal(exiMax, Convert.ToInt32(dr["EXIMAX"]));
                        Assert.Equal(exiAct, Convert.ToInt32(dr["EXIACT"]));
                        Assert.Equal(precio, Convert.ToDecimal(dr["PREART"]));
                        Assert.Equal(costo, Convert.ToDecimal(dr["COSART"]));
                    }
                }
            }
        }

        /// <summary>
        /// Prueba 3: btnModificarArt_Click() actualiza un artículo existente con nuevos valores
        /// </summary>
        [Fact]
        public void ModificarArticulo_DebeActualizarArticuloExistenteEnBaseDatos()
        {
            // Arrange: Insertar un artículo inicial
            string codigo = "ART500";
            InsertarArticuloPrueba(codigo, "Descripción Original", "UNI", 5, 50, 25, 100.00m, 80.00m);

            // Nuevos valores para actualizar
            string nuevaDescripcion = "Descripción Modificada";
            string nuevaUnidad = "KG";
            int nuevoExiMin = 10;
            int nuevoExiMax = 150;
            int nuevoExiAct = 75;
            decimal nuevoPrecio = 250.00m;
            decimal nuevoCosto = 200.00m;

            // Act: Actualizar el artículo
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = $@"UPDATE {testTableName} SET
                    DESART = @DES, 
                    CODUNI = @UNI,
                    EXIMIN = @EXIM, 
                    EXIMAX = @EXIMAX,
                    EXIACT = @EXIACT, 
                    PREART = @PRE,
                    COSART = @COS 
                WHERE CODART = @COD";
                
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@COD", codigo);
                    cmd.Parameters.AddWithValue("@DES", nuevaDescripcion);
                    cmd.Parameters.AddWithValue("@UNI", nuevaUnidad);
                    cmd.Parameters.AddWithValue("@EXIM", nuevoExiMin);
                    cmd.Parameters.AddWithValue("@EXIMAX", nuevoExiMax);
                    cmd.Parameters.AddWithValue("@EXIACT", nuevoExiAct);
                    cmd.Parameters.AddWithValue("@PRE", nuevoPrecio);
                    cmd.Parameters.AddWithValue("@COS", nuevoCosto);
                    cmd.ExecuteNonQuery();
                }
            }

            // Assert: Verificar que el artículo se actualizó correctamente
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = $"SELECT * FROM {testTableName} WHERE CODART = @COD";
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@COD", codigo);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        Assert.True(dr.Read());
                        Assert.Equal(nuevaDescripcion, dr["DESART"].ToString());
                        Assert.Equal(nuevaUnidad, dr["CODUNI"].ToString());
                        Assert.Equal(nuevoExiMin, Convert.ToInt32(dr["EXIMIN"]));
                        Assert.Equal(nuevoExiMax, Convert.ToInt32(dr["EXIMAX"]));
                        Assert.Equal(nuevoExiAct, Convert.ToInt32(dr["EXIACT"]));
                        Assert.Equal(nuevoPrecio, Convert.ToDecimal(dr["PREART"]));
                        Assert.Equal(nuevoCosto, Convert.ToDecimal(dr["COSART"]));
                    }
                }
            }
        }

        /// <summary>
        /// Prueba 4: btnBuscarArt_Click() recupera y muestra los detalles correctos cuando se proporciona un código válido
        /// </summary>
        [Fact]
        public void BuscarArticulo_DebeRecuperarDetallesCorrectosConCodigoValido()
        {
            // Arrange: Insertar un artículo de prueba
            string codigo = "ART777";
            string descripcion = "Artículo de Búsqueda";
            string unidad = "LT";
            int exiMin = 8;
            int exiMax = 80;
            int exiAct = 40;
            decimal precio = 120.00m;
            decimal costo = 90.00m;

            InsertarArticuloPrueba(codigo, descripcion, unidad, exiMin, exiMax, exiAct, precio, costo);

            // Act: Buscar el artículo
            string? desartEncontrado = null;
            string? coduniEncontrado = null;
            int eximinEncontrado = 0;
            int eximaxEncontrado = 0;
            int exiactEncontrado = 0;
            decimal preartEncontrado = 0;
            decimal cosartEncontrado = 0;

            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = $"SELECT * FROM {testTableName} WHERE CODART = @COD";
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@COD", codigo);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            desartEncontrado = dr["DESART"].ToString();
                            coduniEncontrado = dr["CODUNI"].ToString();
                            eximinEncontrado = Convert.ToInt32(dr["EXIMIN"]);
                            eximaxEncontrado = Convert.ToInt32(dr["EXIMAX"]);
                            exiactEncontrado = Convert.ToInt32(dr["EXIACT"]);
                            preartEncontrado = Convert.ToDecimal(dr["PREART"]);
                            cosartEncontrado = Convert.ToDecimal(dr["COSART"]);
                        }
                    }
                }
            }

            // Assert: Verificar que los datos recuperados son correctos
            Assert.Equal(descripcion, desartEncontrado);
            Assert.Equal(unidad, coduniEncontrado);
            Assert.Equal(exiMin, eximinEncontrado);
            Assert.Equal(exiMax, eximaxEncontrado);
            Assert.Equal(exiAct, exiactEncontrado);
            Assert.Equal(precio, preartEncontrado);
            Assert.Equal(costo, cosartEncontrado);
        }

        /// <summary>
        /// Prueba 5: btnEliminarArt_Click() elimina un artículo especificado de la base de datos
        /// </summary>
        [Fact]
        public void EliminarArticulo_DebeEliminarArticuloEspecificadoDeBaseDatos()
        {
            // Arrange: Insertar un artículo para eliminar
            string codigo = "ART888";
            InsertarArticuloPrueba(codigo, "Artículo a Eliminar", "UNI", 5, 50, 25, 100.00m, 80.00m);

            // Verificar que el artículo existe antes de eliminarlo
            bool existeAntes = false;
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consultaVerificar = $"SELECT COUNT(*) FROM {testTableName} WHERE CODART = @COD";
                using (SqlCommand cmd = new SqlCommand(consultaVerificar, conexion))
                {
                    cmd.Parameters.AddWithValue("@COD", codigo);
                    existeAntes = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }

            // Act: Eliminar el artículo
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consulta = $"DELETE FROM {testTableName} WHERE CODART = @COD";
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@COD", codigo);
                    cmd.ExecuteNonQuery();
                }
            }

            // Assert: Verificar que el artículo fue eliminado
            bool existeDespues = false;
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string consultaVerificar = $"SELECT COUNT(*) FROM {testTableName} WHERE CODART = @COD";
                using (SqlCommand cmd = new SqlCommand(consultaVerificar, conexion))
                {
                    cmd.Parameters.AddWithValue("@COD", codigo);
                    existeDespues = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }

            Assert.True(existeAntes, "El artículo debería existir antes de eliminarlo");
            Assert.False(existeDespues, "El artículo no debería existir después de eliminarlo");
        }
    }
}
