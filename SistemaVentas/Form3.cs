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
    public partial class Form3 : Form
    {
        Form1 formMenuPrincipal; // variable de referencia al formulario principal
        public Form3()
        {
            InitializeComponent();
            CargarArticulos(); //Llena el DataGridView con los artículos de la base de datos
            this.StartPosition = FormStartPosition.CenterScreen; //Centra el formulario en la pantalla
        }

        // Constructor que recibe una referencia al formulario principal
        public Form3(Form1 MenuPrincipal)
        {
            InitializeComponent(); // Inicializa los componentes gráficos del formulario
            formMenuPrincipal = MenuPrincipal; // Guarda la referencia del formulario principal que abrió este formulario
            CargarArticulos(); //Llena el DataGridView con los artículos de la base de datos
            this.StartPosition = FormStartPosition.CenterScreen; //Centra el formulario en la pantala
        }

        private void CargarArticulos() //Llena el DataGridView con los artículos de la base de datos
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion()) //Abre la conexión a la base de datos
                {
                    string consulta = "SELECT * FROM SFTARTI0"; //Consulta SQL para obtener todos los artículos 
                     
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion)) //Crea un adaptador de datos para ejecutar la consulta
                    {
                        DataTable tabla = new DataTable(); //Crea una tabla de datos para almacenar los resultados
                        adaptador.Fill(tabla); //Llena la tabla con los resultados de la consulta
                        dgvArticulos.DataSource = tabla; //Asigna la tabla como fuente de datos del DataGridView


                        //Configura los encabezados de las columnas del DataGridView
                        dgvArticulos.Columns["CODART"].HeaderText = "Código Artículo"; //
                        dgvArticulos.Columns["DESART"].HeaderText = "Descripción";
                        dgvArticulos.Columns["CODUNI"].HeaderText = "Unidad";
                        dgvArticulos.Columns["EXIMIN"].HeaderText = "Existencia Mínima";
                        dgvArticulos.Columns["EXIMAX"].HeaderText = "Existencia Máxima";
                        dgvArticulos.Columns["EXIACT"].HeaderText = "Existencia Actual";
                        dgvArticulos.Columns["PREART"].HeaderText = "Precio Venta";
                        dgvArticulos.Columns["COSART"].HeaderText = "Costo Compra";

                    }
                }
            }
            catch (Exception ex) //Maneja cualquier error que ocurra durante la carga de los artículos
            {
                MessageBox.Show("Error al cargar artículos: " + ex.Message);
            }
        }

        // Evento del botón para volver al menú principal
        private void btnVolverMenuPrincipal_Click_1(object sender, EventArgs e)
        {
            formMenuPrincipal.Show(); // Muestra el formulario principal nuevamente
            this.Close(); //Cierra el formulario actual de clientes
        }

        private void btnAgregarArt_Click(object sender, EventArgs e) // Evento del botón para agregar un nuevo artículo
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion()) //Abre la conexión a la base de datos
                {
                    string consulta = @"INSERT INTO SFTARTI0  
                            (CODART, DESART, CODUNI, EXIMIN, EXIMAX, EXIACT, PREART, COSART)
                             VALUES (@COD, @DES, @UNI, @EXIM, @EXIMAX, @EXIACT, @PRE, @COS)"; //Consulta SQL para insertar un nuevo artículo

                    using (SqlCommand cmd = new SqlCommand(consulta, conexion)) //Crea un comando SQL para ejecutar la consulta
                    {
                        //Agrega los parámetros necesarios para la consulta
                        cmd.Parameters.AddWithValue("@COD", txtCodArt.Text);
                        cmd.Parameters.AddWithValue("@DES", txtDesArt.Text);
                        cmd.Parameters.AddWithValue("@UNI", cmbCodUni.Text);
                        cmd.Parameters.AddWithValue("@EXIM", int.Parse(txtExiMin.Text));
                        cmd.Parameters.AddWithValue("@EXIMAX", int.Parse(txtExiMax.Text));
                        cmd.Parameters.AddWithValue("@EXIACT", int.Parse(txtExiAct.Text));
                        cmd.Parameters.AddWithValue("@PRE", decimal.Parse(txtPreArt.Text));
                        cmd.Parameters.AddWithValue("@COS", decimal.Parse(txtCosArt.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Artículo agregado correctamente");

                CargarArticulos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificarArt_Click(object sender, EventArgs e) // Evento del botón para modificar un artículo existente
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion()) // 
                {
                    string consulta = @"UPDATE SFTARTI0 SET
                                        DESART = @DES, 
                                        CODUNI = @UNI,
                                        EXIMIN = @EXIM, 
                                        EXIMAX = @EXIMAX,
                                        EXIACT = @EXIACT, 
                                        PREART = @PRE,
                                        COSART = @COS 
                                    WHERE CODART = @COD"; //Consulta SQL para actualizar un artículo existente

                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))     //Crea un comando SQL para ejecutar la consulta
                    {
                        //Agrega los parámetros necesarios para la consulta
                        cmd.Parameters.AddWithValue("@COD", txtCodArt.Text);
                        cmd.Parameters.AddWithValue("@DES", txtDesArt.Text);
                        cmd.Parameters.AddWithValue("@UNI", cmbCodUni.Text);
                        cmd.Parameters.AddWithValue("@EXIM", int.Parse(txtExiMin.Text));
                        cmd.Parameters.AddWithValue("@EXIMAX", int.Parse(txtExiMax.Text));
                        cmd.Parameters.AddWithValue("@EXIACT", int.Parse(txtExiAct.Text));
                        cmd.Parameters.AddWithValue("@PRE", decimal.Parse(txtPreArt.Text));
                        cmd.Parameters.AddWithValue("@COS", decimal.Parse(txtCosArt.Text));


                        cmd.ExecuteNonQuery();
                    }

                }

                MessageBox.Show("Artículo modificado correctamente");
                CargarArticulos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBuscarArt_Click(object sender, EventArgs e)     // Evento del botón para buscar un artículo por su código
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())       //Abre la conexión a la base de datos
                {
                    string consulta = "SELECT * FROM SFTARTI0 WHERE CODART = @COD"; //Consulta SQL para buscar un artículo por su código

                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))   //Crea un comando SQL para ejecutar la consulta
                    {
                        cmd.Parameters.AddWithValue("@COD", txtCodArt.Text);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read()) //Si se encuentra el artículo, llena los campos del formulario con sus datos
                            {
                                //Llena los campos del formulario con los datos del artículo encontrado
                                txtDesArt.Text = dr["DESART"].ToString();
                                cmbCodUni.Text = dr["CODUNI"].ToString();
                                txtExiMin.Text = dr["EXIMIN"].ToString();
                                txtExiMax.Text = dr["EXIMAX"].ToString();
                                txtExiAct.Text = dr["EXIACT"].ToString();
                                txtPreArt.Text = dr["PREART"].ToString();
                                txtCosArt.Text = dr["COSART"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Artículo no encotrado");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminarArt_Click(object sender, EventArgs e) // Evento del botón para eliminar un artículo por su código
        {
            //Verifica que se haya ingresado un código de artículo
            if (txtCodArt.Text == "")
            {
                MessageBox.Show("Debe escribir el código del artículo a eliminar"); //Muestra un mensaje de advertencia
                return;
            }

            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion()) //Abre la conexión a la base de datos
                {
                    string consulta = "DELETE FROM SFTARTI0 WHERE CODART = @COD"; //Consulta SQL para eliminar un artículo por su código

                    using (SqlCommand cmd = new SqlCommand(consulta, conexion)) //Crea un comando SQL para ejecutar la consulta
                    {
                        cmd.Parameters.AddWithValue("@COD", txtCodArt.Text); //Agrega el parámetro necesario para la consulta
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Artículo eliminado correctamente"); //Muestra un mensaje de confirmación
                CargarArticulos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

