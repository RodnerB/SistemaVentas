using SistemaVentas.Utilidades;
using System.Data;

namespace SistemaVentas
{
    internal class Factura
    {
        public int numeroFactura { get; private set; }
        public DateTime fechaFactura { get; private set; }
        public string? codigoCliente { get; private set; }
        public string condicion { get; private set; }
        public float descuento { get; private set; } = 0;
        public float montoFactura { get; private set; }

        private const string getFacturasQuery = "SELECT * FROM SFTFAC0";
        private const string getFacturaPorCodigoQuery = "SELECT * FROM SFTFAC0 WHERE NUMFAC = @codigo";
        private const string insertarFacturaQuery = @"
                INSERT INTO SFTFAC0 
                (NUMFAC, FECFAC, CODCLI, CONDICION, DESCUENTO, MONFAC) 
                VALUES 
                (@NumeroFactura, @FechaFactura, @CodigoCliente, @Condicion, @Descuento, @MontoFactura)";
        private const string GetUltimoCodigoFacturaQuery = "SELECT ISNULL(MAX(NUMFAC), 0) + 1 FROM SFTFAC0";

        static Dictionary<string, string> filasHeaders = new ()
        {
            {"colNumeroFactura", "NUMFAC"}, // Tipo integer
            {"colFechaFactura", "FECFAC"}, // Tipo date
            {"colCodigoCliente", "CODCLI"}, // codigo de cliente (varchar 10)
            {"colCondicion", "CONDICION"}, // Tipo varchar 1 (1=Contado, 2=Crédito)
            {"colDescuento","DESCUENTO"}, // Tipo float 
            {"colMontoFactura", "MONFAC"} // Tipo float
        };

        public Factura(int numeroFactura, DateTime fechaFactura, string? codigoCliente, string condicion, float descuento, float montoFactura)
        {
            this.numeroFactura = numeroFactura;
            this.fechaFactura = fechaFactura;
            this.codigoCliente = codigoCliente;
            this.condicion = condicion;
            this.descuento = descuento;
            this.montoFactura = montoFactura;
        }

        // Obbtiene el ultimo codigo de una factura y lo retorna sumandole 1 al valor
        public static int ObtenerNuevoCodigoFactura()
        {
            // recupera el datatable con el resultado de la consulta
            DataTable tabla = UtilidadesBD.ObtenerTodosLosRegistros(GetUltimoCodigoFacturaQuery);
            // devuelve el valor convertido a entero
            return Convert.ToInt32(tabla.Rows[0][0]);
        } 

        public static DataTable ObtenerFacturas() => UtilidadesBD.ObtenerTodosLosRegistros(getFacturasQuery);
        public static DataTable ObtenerFacturasCreditoPorCliente(string codigoCliente)
        {
             string getFacturasCreditoPorClienteQuery = @$"
                SELECT NUMFAC, FECFAC, MONFAC FROM SFTFAC0 
                WHERE CODCLI = '{codigoCliente}' AND CONDICION = '2' AND MONFAC > 0";

            return UtilidadesBD.ObtenerTodosLosRegistros(getFacturasCreditoPorClienteQuery);
        }
        public static void CargarFacturasEnGridConFilas(DataGridView dataGrid, DataTable tabla)
        {
            UtilidadesUI.CargarDatosEnGridConFilas(
                tabla,
                dataGrid,
                filasHeaders
            );
        }

        public static Factura? ObtenerFacturaPorCodigo(string numeroFactura)
        {
            Dictionary<string, object>? datos = UtilidadesBD.BuscarRegistro(getFacturaPorCodigoQuery,numeroFactura);
            if(datos == null) return null;
            return new Factura(
                Convert.ToInt32(datos["NUMFAC"]),
                Convert.ToDateTime(datos["FECFAC"]),
                datos["CODCLI"].ToString(),
                datos["CONDICION"].ToString()!,
                Convert.ToSingle(datos["DESCUENTO"]),
                Convert.ToSingle(datos["MONFAC"])
            );
        }

        private static Dictionary<string, object> ObtenerParametrosFactura(Factura factura)
        {
            return new Dictionary<string, object>()
            {
                {"@NumeroFactura", factura.numeroFactura },
                {"@FechaFactura", factura.fechaFactura },
                {"@CodigoCliente", factura.codigoCliente ?? (object)DBNull.Value },
                {"@Condicion", factura.condicion },
                {"@Descuento", factura.descuento },
                {"@MontoFactura", factura.montoFactura }
            };
        }

        public static void InsertarFactura(Factura factura)
        {
            if(string.IsNullOrWhiteSpace(factura.codigoCliente)) 
            {
                factura.codigoCliente = null;
            }
            UtilidadesBD.GuardarRegistro(
                insertarFacturaQuery,
                ObtenerParametrosFactura(factura)
            );
        }

    }
}
