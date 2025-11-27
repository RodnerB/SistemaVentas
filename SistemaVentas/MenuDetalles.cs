using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SistemaVentas
{
    public partial class MenuDetalles : Form
    {
        MenuPrincipal formMenuPrincipal; // variable de referencia al formulario principal
     

        // Constructor que recibe una referencia al formulario principal
        public MenuDetalles(MenuPrincipal formMenuPrincipal)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            this.StartPosition = FormStartPosition.CenterScreen;

            CargarDetalles();
            ObtenerDetalleComboBox();

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.KeyDown += EventoMoverConEnter;
            }

            this.Shown += Form5_Shown;

        }
        private void Form5_Shown(object? sender, EventArgs e)
        {
            txtNumFacdet?.Focus();
        }
        private void CargarDetalles()
        {
            try
            {
                Detalles.ObtenerDetalles(dgvDetFact);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles: " + ex.Message);
            }
        }

        private void ObtenerDetalleComboBox()
        {
            try
            {
                DataTable tablaDetalles = Utilidades.UtilidadesBD.ObtenerTodosLosRegistros(
                    "SELECT CODART, DESART FROM SFTARTI0"
                );
                if (cmbArtDet != null)
                {
                    cmbArtDet.DataSource = tablaDetalles;
                    cmbArtDet.ValueMember = "CODART";
                    cmbArtDet.DisplayMember = "DESART";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar artículos en el ComboBox: " + ex.Message);
            }
        }

        private Detalles ObtenerDetalle()
        {
            return new Detalles
            {
                NumeroFactura = txtNumFacdet?.Text,
                CodigoArticulo = cmbArtDet?.SelectedValue?.ToString(),
                CantidadVendida = int.TryParse(txtCantDet?.Text, out int cant) ? cant : 0,
                PrecioVenta = decimal.TryParse(txtPrecVent?.Text, out decimal precio) ? precio : 0
            };
        }

        private void DetectarDetallesEvento(object? sender, KeyEventArgs e)
        {
            var txt = txtNumFacdet?.Text;
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txt))
            {
                
                var numFac = txtNumFacdet?.Text;
                if (!string.IsNullOrEmpty(numFac))
                {
                    Detalles? det = Detalles.ObtenerDetallesPorCodigo(numFac);
                    if (det != null)
                    {
                        if (txtNumFacdet != null)
                            txtNumFacdet.Text = det.NumeroFactura;
                        if (cmbArtDet != null)
                            cmbArtDet.SelectedValue = det.CodigoArticulo;
                        txtCantDet.Text = det.CantidadVendida.ToString();
                        txtPrecVent.Text = det.PrecioVenta.ToString("0.##");
                    }
                }
            }
        }

        private void EventoMoverConEnter(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && sender is Control control)
            {
                SelectNextControl(control, true, true, true, true);
                e.SuppressKeyPress = true;
            }
        }

        private void btnAgregarDet_Click(object sender, EventArgs e)
        {
            GuardarDetalles(ObtenerDetalle());
        }

        private void GuardarDetalles(Detalles det)
        {
            try
            {
                using (var conexion = ConexionDB.ObtenerConexion())
                {
                    string consulta = "INSERT INTO SFTDETFAC (NUMFAC, CODART, CANTVEN, PRECVEN) VALUES (@NUMFAC, @CODART, @CANTVENT, @PRECVEN)";
                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@NUMFAC", det.NumeroFactura ?? "");
                        comando.Parameters.AddWithValue("@CODART", det.CodigoArticulo ?? "");
                        comando.Parameters.AddWithValue("@CANTVENT", det.CantidadVendida);
                        comando.Parameters.AddWithValue("@PRECVEN", det.PrecioVenta);

                        int filas = comando.ExecuteNonQuery();
                        if (filas > 0)
                        {
                            MessageBox.Show("Detalle guardado correctamente.");
                            CargarDetalles();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el detalle.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el detalle: " + ex.Message);
            }
        }

        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            formMenuPrincipal.Show();
            this.Close();
        }

        private void btnEliminarDet_Click(object sender, EventArgs e)
        {
            // Obtener código desde la fila seleccionada (evita depender de un TextBox que puede no existir)
            string? codDet = null;
            if (dgvDetFact.CurrentRow != null)
            {
                if (dgvDetFact.Columns.Contains("CODDET"))
                    codDet = dgvDetFact.CurrentRow.Cells["CODDET"].Value?.ToString();
                else if (dgvDetFact.CurrentRow.Cells.Count > 0)
                    codDet = dgvDetFact.CurrentRow.Cells[0].Value?.ToString();
            }

            if (string.IsNullOrWhiteSpace(codDet))
            {
                MessageBox.Show("Seleccione un detalle en la tabla para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EliminarDetalle(codDet);
        }

        private void EliminarDetalle(string codDet)
        {
            if (dgvDetFact.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un detalle en la tabla.", "Advertencia");
                return;
            }

            // Obtener claves compuestas
            string? numFac = dgvDetFact.CurrentRow.Cells["NUMFAC"].Value?.ToString();
            string? codArt = dgvDetFact.CurrentRow.Cells["CODART"].Value?.ToString();

            if (string.IsNullOrEmpty(numFac) || string.IsNullOrEmpty(codArt))
            {
                MessageBox.Show("No se pudo obtener los datos necesarios para eliminar el detalle.", "Advertencia");
                return;
            }

            EliminarDetalle(numFac, codArt);
        }

        private void EliminarDetalle(string numFac, string codArt)
        {
            try
            {
                using (var conexion = ConexionDB.ObtenerConexion())
                {
                    string consulta = "DELETE FROM SFTDETFAC WHERE NUMFAC = @NUMFAC AND CODART = @CODART";
                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@NUMFAC", numFac);
                        comando.Parameters.AddWithValue("@CODART", codArt);

                        int filas = comando.ExecuteNonQuery();
                        if (filas > 0)
                        {
                            MessageBox.Show("Detalle eliminado correctamente.");
                            CargarDetalles();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el detalle.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el detalle: " + ex.Message);
            }
        }
    }
}
