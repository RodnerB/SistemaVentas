using SistemaVentas.Utilidades;
using System.Data;

namespace SistemaVentas
{
    internal class Factura
    {
        private const string getFacturasQuery = "SELECT * FROM SFTFAC0";
        private const string getFacturaPorCodigoQuery = "SELECT * FROM SFTFAC0 WHERE NUMFAC = @codigo";
        private const string insertarFacturaQuery = @"
                INSERT INTO SFTFAC0 
                (NUMFAC, FECFAC, CODCLI, CONDICION, DESCUENTO, MONFAC) 
                VALUES 
                (@NumeroFactura, @FechaFactura, @CodigoCliente, @Condicion, @Descuento, @MontoFactura)";
        private const string GetUltimoCodigoFacturaQuery = "SELECT ISNULL(MAX(NUMFAC), 0) + 1 FROM SFTFAC0";
        static Dictionary<string, string> facturasHeaders = new Dictionary<string, string>()
        {
            {"NUMFAC", "Número Factura" }, // Tipo integer
            {"FECFAC", "Fecha Factura" }, // Tipo date
            {"CODCLI", "Código Cliente" }, // codigo de cliente (varchar 10)
            {"CONDICION", "Condición" }, // Tipo varchar 1 (1=Contado, 2=Crédito)
            {"DESCUENTO", "Descuento" }, // Tipo float 
            {"MONFAC", "Monto Factura" } // Tipo float
        };
        public int numeroFactura { get; private set; }
        public DateTime fechaFactura { get; private set; }
        public string? codigoCliente { get; private set; }
        public string condicion { get; private set; }
        public float descuento { get; private set; } = 0;
        public float montoFactura { get; private set; }

        public Factura(int numeroFactura, DateTime fechaFactura, string? codigoCliente, string condicion, float descuento, float montoFactura)
        {
            this.numeroFactura = numeroFactura;
            this.fechaFactura = fechaFactura;
            this.codigoCliente = codigoCliente;
            this.condicion = condicion;
            this.descuento = descuento;
            this.montoFactura = montoFactura;
        }
        public static DataTable ObtenerFacturas() => UtilidadesBD.ObtenerTodosLosRegistros(getFacturasQuery);
        // Obbtiene el ultimo codigo de una factura y lo retorna sumandole 1 al valor
        public static int ObtenerNuevoCodigoFactura()
        {
            // recupera el datatable con el resultado de la consulta
            DataTable tabla = UtilidadesBD.ObtenerTodosLosRegistros(GetUltimoCodigoFacturaQuery);
            // devuelve el valor convertido a entero
            return Convert.ToInt32(tabla.Rows[0][0]);
        } 

        public static void CargarFacturasEnGrid(DataGridView dataGrid)
        {
            DataTable tabla = ObtenerFacturas();
            UtilidadesUI.CargarDatosEnGrid(
                tabla,
                dataGrid,
                facturasHeaders
            );
        }

        public static Factura? ObtenerFacturaPorCodigo(string numeroFactura)
        {
            Dictionary<string, object>? datos = Utilidades.UtilidadesBD.BuscarRegistro(getFacturaPorCodigoQuery,numeroFactura);
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
