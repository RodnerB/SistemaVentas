
using SistemaVentas.Utilidades;
using System.Data;

namespace SistemaVentas
{
    class Articulos
    {
        private const string getArticulosQuery = "SELECT * FROM SFTARTI0 ";
        private const string getArticuloPorCodigoQuery = "SELECT * FROM SFTARTI0 WHERE CODART = @codigo";
        private const string insertArticuloQuery = @"
            INSERT INTO SFTARTI0 
            (CODART, DESART, CODUNI, EXIMIN, EXIMAX, EXIACT, PREART, COSART) 
            VALUES 
            (@CODART, @DESART, @CODUNI, @EXIMIN, @EXIMAX, @EXIACT, @PREART, @COSART)";
        static Dictionary<string, string> articulosHeaders = new Dictionary<string, string>()
        {
            {"CODART", "Código Artículo" },
            {"DESART", "Descripción Artículo" },
            {"CODUNI", "Código Unidad de Medida" },
            {"EXIMIN", "Existencia Mínima" },
            {"EXIMAX", "Existencia Máxima" },
            {"EXIACT", "Existencia Actual" },
            {"PREART", "Precio Artículo" },
            {"COSART", "Costo Artículo" }
        };
        public string? CodigoArticulo { get; set; }
        public string? DescripcionArticulo { get; set; } = "";
        public string? CodigoUnidad { get; set; }
        public int? ExistenciaMinima { get; set; }
        public int? ExistenciaMaxima { get; set; }
        public int? ExistenciaActual { get; set; }
        public decimal? PrecioArticulo { get; set; }
        public decimal? CostoArticulo { get; set; }
        public static void ObtenerArticulos(DataGridView dataGrid)
        {
            DataTable tabla = UtilidadesBD.ObtenerTodosLosRegistros(getArticulosQuery);
            Utilidades.UtilidadesUI.CargarDatosEnGrid(
                tabla,
                dataGrid,
                articulosHeaders
                );
        }
        public static Articulos? ObtenerArticuloPorCodigo(string codigoArticulo)
        {
            Dictionary<string, object>? datos = Utilidades.UtilidadesBD.BuscarRegistro(
                getArticuloPorCodigoQuery,
                codigoArticulo);
            if (datos == null) return null;
            return new Articulos()
            {
                CodigoArticulo = datos["CODART"].ToString(),
                DescripcionArticulo = datos["DESART"].ToString(),
                CodigoUnidad = datos["CODUNI"].ToString(),
                ExistenciaMinima = Convert.ToInt32(datos["EXIMIN"]),
                ExistenciaMaxima = Convert.ToInt32(datos["EXIMAX"]),
                ExistenciaActual = Convert.ToInt32(datos["EXIACT"]),
                PrecioArticulo = Convert.ToDecimal(datos["PREART"]),
                CostoArticulo = Convert.ToDecimal(datos["COSART"])
            };
        }
    }
}