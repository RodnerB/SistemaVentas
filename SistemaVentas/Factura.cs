namespace SistemaVentas
{
    internal class Factura
    {
        private const string getFacturasQuery = "SELECT * FROM SFTFAC0";
        private const string getFacturaPorCodigoQuery = "SELECT * FROM SFTFAC0 WHERE NUMFAC = @codigo";
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

        public static void ObtenerFacturas(DataGridView dataGrid)
        {
            Utilidades.UtilidadesUI.CargarDatosEnGrid(
                getFacturasQuery,
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

    }
}
