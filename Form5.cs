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
using SistemaVentas;

namespace SistemaVentas
{
    public partial class Form5 : Form
    {
        Form1 formMenuPrincipal; // variable de referencia al formulario principal

        // Constructor que recibe una referencia al formulario principal
        public Form5(Form1 formMenuPrincipal)
        {
            InitializeComponent();  // Inicializa los componentes gráficos del formulario
            this.formMenuPrincipal = formMenuPrincipal; // Guarda la referencia del formulario principal que abrió este formulario

            CargarDetalles();
            CargarArticulosCombo(); // cargar los artículos en el combo "Artículo"
            this.StartPosition = FormStartPosition.CenterScreen;

            // Usar el control definido en el diseñador
            txtNumFacdet.KeyDown += DetectarDetallesEvento;
            cmbÇodArtDet.SelectedIndexChanged += cmbÇodArtDet_SelectedIndexChanged;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.KeyDown += EventoMoverConEnter;
                }
            }
        }

        private void CargarDetalles()
        {
            CargarDetallesGrid();
        }

        // Carga los detalles en el DataGridView (ANTES se estaban cargando unidades de medida)
        private void CargarDetallesGrid()
        {
            try
            {
                // Usar el método estático de la clase 'detalles' para llenar el DataGridView
                detalles.ObtenerDetalles(dgvDetFact);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Carga los artículos en el ComboBox 'cmbÇodArtDet'
        private void CargarArticulosCombo()
        {
            try
            {
                DataTable dt = Utilidades.UtilidadesBD.ObtenerTodosLosRegistros("SELECT CODART, DESART, PREART FROM SFTARTI0");
                if (dt != null)
                {
                    cmbÇodArtDet.DataSource = dt;
                    cmbÇodArtDet.DisplayMember = "DESART";
                    cmbÇodArtDet.ValueMember = "CODART";
                    cmbÇodArtDet.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbÇodArtDet.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar artículos en el combo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cuando se selecciona un artículo, rellenar el precio si está disponible
        private void cmbÇodArtDet_SelectedIndexChanged(object? sender, EventArgs e)
        {
            try
            {
                if (cmbÇodArtDet.SelectedItem is DataRowView drv && drv.Row.Table.Columns.Contains("PREART"))
                {
                    var val = drv["PREART"]?.ToString();
                    if (decimal.TryParse(val, out decimal precio))
                        txtPrecVent.Text = precio.ToString("0.##");
                    else
                        txtPrecVent.Text = string.Empty;
                }
                else if (cmbÇodArtDet.SelectedValue != null)
                {
                    // fallback: obtener artículo por código para leer su precio
                    string codigo = cmbÇodArtDet.SelectedValue.ToString() ?? "";
                    var art = Articulos.ObtenerArticuloPorCodigo(codigo);
                    if (art != null && art.PrecioArticulo.HasValue)
                        txtPrecVent.Text = art.PrecioArticulo.Value.ToString("0.##");
                    else
                        txtPrecVent.Text = string.Empty;
                }
            }
            catch
            {
                txtPrecVent.Text = string.Empty;
            }
        }

        // Usar el tipo existente 'detalles' (no modificar la clase)
        private void GuardarDetalles(detalles detalles)
        {
            try
            {
                using (var conexion = ConexionDB.ObtenerConexion())
                {
                    // columnas y parámetros coherentes con la tabla y con 'detalles.cs'
                    string consulta = "INSERT INTO SFTDETFAC (NUMFAC, CODART, CANTVEN, PRECVEN) VALUES (@NUMFAC, @CODART, @CANTVENT, @PRECVEN)";
                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@NUMFAC", detalles.NumeroFactura ?? "");
                        comando.Parameters.AddWithValue("@CODART", detalles.CodigoArticulo ?? "");
                        comando.Parameters.AddWithValue("@CANTVENT", detalles.CantidadVendida);
                        comando.Parameters.AddWithValue("@PRECVEN", detalles.PrecioVenta);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Detalles guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDetallesGrid();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar los detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la unidad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarDetalle(detalles detalles)
        {
            try
            {
                using (var conexion = ConexionDB.ObtenerConexion())
                {
                    string consulta = "UPDATE SFTDETFAC SET CODART = @CODART, CANTVEN = @CANTVENT, PRECVEN = @PRECVEN WHERE NUMFAC = @NUMFAC";
                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@NUMFAC", detalles.NumeroFactura ?? "");
                        comando.Parameters.AddWithValue("@CODART", detalles.CodigoArticulo ?? "");
                        comando.Parameters.AddWithValue("@CANTVENT", detalles.CantidadVendida);
                        comando.Parameters.AddWithValue("@PRECVEN", detalles.PrecioVenta);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Detalles modificados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDetallesGrid();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar los detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar los detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void eliminarDetalles(string codigoUnidad)
        {
            try
            {
                using (var conexion = ConexionDB.ObtenerConexion())
                {
                    string consulta = "DELETE FROM SFTDETFAC WHERE NUMFAC = @NUMFAC";
                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@NUMFAC", codigoUnidad ?? "");

                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Detalles eliminados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDetallesGrid();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar los detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar los detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Llamar al método estático existente en 'detalles.cs'
        private detalles? BuscarDetalles(string numeroFactura)
        {
            return detalles.ObtenerDetallesPorCodigo(numeroFactura);
        }

        private void DetectarDetallesEvento(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtNumFacdet.Text.Length > 0)
            {
                // si el detalle es encontrado, rellena automáticamente los campos
                detalles? det = BuscarDetalles(txtNumFacdet.Text);
                if (det != null)
                {
                    txtNumFacdet.Text = det.NumeroFactura ?? "";
                    cmbÇodArtDet.Text = det.CodigoArticulo ?? "";
                    txtCantDet.Text = det.CantidadVendida.ToString();
                    txtPrecVent.Text = det.PrecioVenta.ToString("0.##");
                }
            }
        }

        // Implementación para mover foco con Enter
        private void EventoMoverConEnter(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && sender is Control c)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(c, true, true, true, true);
            }
        }



        // Evento del botón para volver al menú principal
        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.Show();// Muestra el formulario principal nuevamente
            this.Close();//Cierra el formulario actual de clientes
        }

        private void btnAgregarDet_Click(object sender, EventArgs e) => GuardarDetalles(ObtenerDetalle());

        private detalles ObtenerDetalle()
        {
            return new detalles
            {
                NumeroFactura = txtNumFacdet.Text,
                // preferir SelectedValue (código) si está disponible
                CodigoArticulo = cmbÇodArtDet.SelectedValue?.ToString() ?? cmbÇodArtDet.Text,
                CantidadVendida = int.TryParse(txtCantDet.Text, out int cant) ? cant : 0,
                PrecioVenta = decimal.TryParse(txtPrecVent.Text, out decimal precio) ? precio : 0
            };
        }

        private void btnEliminarDet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumFacdet.Text))
            {
                MessageBox.Show("Debe escribir el número de factura a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            eliminarDetalles(txtNumFacdet.Text);
        }
    }
}