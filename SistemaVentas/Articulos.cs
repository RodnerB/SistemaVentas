using SistemaVentas.Utilidades;
using System.CodeDom;
using System.Data;

namespace SistemaVentas
{
    class Articulo
    {
        public string CodigoArticulo { get; set; } = string.Empty;
        public string DescripcionArticulo { get; set; } = string.Empty;
        public string CodigoUnidad { get; set; } = string.Empty;
        public float ExistenciaMinima { get; set; } = 0;
        public float ExistenciaMaxima { get; set; } = 0;
        public float ExistenciaActual { get; set; } = 0;
        public float PrecioArticulo { get; set; } = 0;
        public float CostoArticulo { get; set; } = 0;

        private const string getArticulosQuery = "SELECT * FROM SFTARTI0 ";
        private const string getArticuloPorCodigoQuery = "SELECT * FROM SFTARTI0 WHERE CODART = @codigo";
        private const string insertarArticuloQuery = @"
            INSERT INTO SFTARTI0 
            (CODART, DESART, CODUNI, EXIMIN, EXIMAX, EXIACT, PREART, COSART) 
            VALUES 
            (@CodigoArticulo, @DescripcionArticulo, @CodigoUnidad, @ExistenciaMinima, @ExistenciaMaxima, @ExistenciaActual, @PrecioArticulo, @CostoArticulo)";

        private const string EliminarArticuloQuery = "DELETE FROM SFTARTI0 WHERE CODART = @codigo";

        private static Dictionary<string, string> articulosHeaders = new()
        {
            {"CODART", "Código" },
            {"DESART", "Descripción" },
            {"CODUNI", "Código Unidad" },
            {"EXIMIN", "Existencia Mínima" },
            {"EXIMAX", "Existencia Máxima" },
            {"EXIACT", "Existencia Actual" },
            {"PREART", "Precio compra" },
            {"COSART", "Costo compra" }
        };
        
        public Articulo() { }

        public Articulo (string codigoArticulo, string descripcionArticulo)
        {
            CodigoArticulo = codigoArticulo;
            DescripcionArticulo = descripcionArticulo;
        }
      
        private static Dictionary<string, object> ObtenerParametrosArticulo(Articulo articulo)
        {
            return new Dictionary<string, object>()
            {
                {"@CodigoArticulo", articulo.CodigoArticulo},
                {"@DescripcionArticulo", articulo.DescripcionArticulo },
                {"@CodigoUnidad", articulo.CodigoUnidad },
                {"@ExistenciaMinima", articulo.ExistenciaMinima },
                {"@ExistenciaMaxima", articulo.ExistenciaMaxima },
                {"@ExistenciaActual", articulo.ExistenciaActual },
                {"@PrecioArticulo", articulo.PrecioArticulo },
                {"@CostoArticulo", articulo.CostoArticulo }
            };
        }
        public static bool InsertarArticulo(Articulo articulo)
        {
            return (UtilidadesBD.GuardarRegistro(
                insertarArticuloQuery,
                ObtenerParametrosArticulo(articulo)
                ) > 0);
        }

        public static void ObtenerArticulos(DataGridView dataGrid) 
        { 
            DataTable tabla = UtilidadesBD.ObtenerTodosLosRegistros(getArticulosQuery);
            Utilidades.UtilidadesUI.CargarDatosEnGrid(
                tabla,
                dataGrid,
                articulosHeaders
                );
        }

        public static Articulo? ObtenerArticuloPorCodigo(string codigoArticulo)
        {
            Dictionary<string, object>? datos = UtilidadesBD.BuscarRegistro(
                getArticuloPorCodigoQuery,
                codigoArticulo);

            if (datos == null || datos.Count == 0) return null;

            return new Articulo()
            {
                CodigoArticulo = datos.ContainsKey("CODART") ? datos["CODART"]?.ToString() ?? "" : "",
                DescripcionArticulo = datos.ContainsKey("DESART") ? datos["DESART"]?.ToString() ?? "" : "",
                CodigoUnidad = datos.ContainsKey("CODUNI") ? datos["CODUNI"]?.ToString() ?? "" : "",

                ExistenciaMinima = datos.ContainsKey("EXIMIN") && datos["EXIMIN"] != DBNull.Value
                    ? Convert.ToSingle(datos["EXIMIN"]) : 0,

                ExistenciaMaxima = datos.ContainsKey("EXIMAX") && datos["EXIMAX"] != DBNull.Value
                    ? Convert.ToSingle(datos["EXIMAX"]) : 0,

                ExistenciaActual = datos.ContainsKey("EXIACT") && datos["EXIACT"] != DBNull.Value
                    ? Convert.ToSingle(datos["EXIACT"]) : 0,

                PrecioArticulo = datos.ContainsKey("PREART") && datos["PREART"] != DBNull.Value
                    ? Convert.ToSingle(datos["PREART"]) : 0,

                CostoArticulo = datos.ContainsKey("COSART") && datos["COSART"] != DBNull.Value
                    ? Convert.ToSingle(datos["COSART"]) : 0
            };
        }

        public static bool EliminarArticulo(string codigoArticulo)
        {
            return (UtilidadesBD.EliminarRegistro(EliminarArticuloQuery, codigoArticulo) > 0);
        }

        public static DataTable ObtenerUnidades()
        {
            string query = "SELECT CODUNI, DESUNI FROM SFTUNI0";
            return UtilidadesBD.ObtenerTodosLosRegistros(query);
        }

    }
}