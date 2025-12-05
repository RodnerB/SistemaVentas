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
        private const string actualizarCantidadQuery = @"UPDATE SFTARTI0 
                               SET EXIACT = EXIACT - @cantidad 
                               WHERE CODART = @codigo";
        static Dictionary<string, string> detallesHeaders = new Dictionary<string, string>()
        {
            {"NUMFAC", "Número de Factura" },
            {"CODART", "Código de Artículo"},
            {"CANTVEN", "Cantidad Vendida"},
            {"PRECVEN", "Precio de Venta"}
        };
        public int NumeroFactura { get; set; }
        public string CodigoArticulo { get; set; }
        public int CantidadVendida { get; set; }
        public float PrecioVenta { get; set; }
        public Detalles(int NumeroFactura, string CodigoArticulo, int CantidadVendida, float PrecioVenta)
        {
            this.NumeroFactura = NumeroFactura;
            this.CodigoArticulo = CodigoArticulo;
            this.CantidadVendida = CantidadVendida;
            this.PrecioVenta = PrecioVenta;
        }
        private static Dictionary<string, object> ObtenerParametrosDetalles(Detalles detalle)
        {
            return new Dictionary<string, object>()
            {
                {"@NUMFAC", detalle.NumeroFactura},
                {"@CODART", detalle.CodigoArticulo },
                {"@CANTVEN", detalle.CantidadVendida },
                {"@PRECVEN", detalle.PrecioVenta }
            };
        }
        public bool InsertarDetalle()
        {
            return (UtilidadesBD.GuardarRegistro(
                insertDetallesQuery,
                ObtenerParametrosDetalles(this)
                ) > 0);
        }
        public static DataTable ObtenerDetalles() => UtilidadesBD.ObtenerTodosLosRegistros(getDetallesQuery);
        public static void CargarDetallesEnGrid(DataGridView dataGrid)
        {
            DataTable tabla = ObtenerDetalles();
            UtilidadesUI.CargarDatosEnGrid(
                tabla,
                dataGrid,
                detallesHeaders
                );
        }
        public static Detalles? ObtenerDetallesPorCodigo(string numeroFactura)
        {
            Dictionary<string, object>? datos = UtilidadesBD.BuscarRegistro(
                getDetallesPorCodigoQuery,
                numeroFactura);
            if (datos == null) return null;

            int NumeroFactura = Convert.ToInt32(datos["NUMFAC"]);
            string CodigoArticulo = datos["CODART"].ToString()!;
            int CantidadVendida = Convert.ToInt32(datos["CANTVEN"]);
            float PrecioVenta = Convert.ToSingle(datos["PRECVEN"]);

            return new Detalles(NumeroFactura, CodigoArticulo, CantidadVendida, PrecioVenta);
        }

        public static void ActualizarExistenciaArticulo(string codigoArticulo, int cantidadVendida)
        {
            var parametros = new Dictionary<string, object>()
            {
                {"@codigo", codigoArticulo },
                {"@cantidad", cantidadVendida }
            };
            UtilidadesBD.GuardarRegistro(actualizarCantidadQuery, parametros);
        }

    }
}
