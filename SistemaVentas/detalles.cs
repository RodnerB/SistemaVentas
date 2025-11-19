using System.Data;
using Microsoft.Data.SqlClient;
using SistemaVentas.Utilidades;

namespace SistemaVentas
{
    class Detalles
    {
        private const string getDetallesQuery = "SELECT * FROM SFTDETFAC";
        private const string getDetallesPorCodigoQuery = "SELECT * FROM SFTDETFAC WHERE NUMFAC = @codigo";
        private const string insertDetallesQuery = @"
            INSERT INTO SFTDETFAC 
            (NUMFAC, CODART, CANTVEN, PRECVEN) 
            VALUES 
            (@NUMFAC, @CODART, @CANTVEN, @PRECVEN)";
        static Dictionary<string, string> detallesHeaders = new Dictionary<string, string>()
        {
            {"NUMFAC", "Número de Factura" },
            {"CODART", "Código de Artículo"},
            {"CANTVEN", "Cantidad Vendida"},
            {"PRECVEN", "Precio de Venta"}
        };
        public string? NumeroFactura { get; set; }
        public string? CodigoArticulo { get; set; }
        public int CantidadVendida { get; set; } = 0;
        public decimal PrecioVenta { get; set; } = 0.0m;
        public static void ObtenerDetalles(DataGridView dataGrid)
        {
            DataTable tabla = UtilidadesBD.ObtenerTodosLosRegistros(getDetallesQuery);
            Utilidades.UtilidadesUI.CargarDatosEnGrid(
                tabla,
                dataGrid,
                detallesHeaders
                );
        }
        public static Detalles? ObtenerDetallesPorCodigo(string numeroFactura)
        {
            Dictionary<string, object> datos = Utilidades.UtilidadesBD.BuscarRegistro(
                getDetallesPorCodigoQuery,
                numeroFactura);
            if (datos == null) return null;
            return new Detalles()
            {
                NumeroFactura = datos["NUMFAC"].ToString(),
                CodigoArticulo = datos["CODART"].ToString(),
                CantidadVendida = Convert.ToInt32(datos["CANTVEN"]),
                PrecioVenta = Convert.ToDecimal(datos["PRECVEN"]),
            };
        }
        public static DataTable ObtenerTodosDetalles()
        {
            var dt = new DataTable();
            using var conexion = ConexionDB.ObtenerConexion();
            string consulta = "SELECT NUMFAC, CODART, CANTVEN, PRECVEN FROM SFTDETFAC";
            using var comando = new SqlCommand(consulta, conexion);
            using var adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(dt);
            return dt;
        }

    }
}
