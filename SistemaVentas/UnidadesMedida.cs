using Microsoft.Data.SqlClient;
using SistemaVentas.Utilidades;
using System.Data;

namespace SistemaVentas
{
     class UnidadesMedida
     {
        public string? CodigoUnidad { get; set; } = "";
        public string? DescripcionUnidad { get; set; } = "";

        private const string getUnidadesMedidaQuery = "SELECT * FROM  SFTUNID0";

        private const string getUnidadMedidaPorCodigoQuery = "SELECT * FROM SFTUNID0 WHERE CODUNI = @codigo";

        private const string insertarUnidadQuery = @"
            INSERT INTO SFTUNID0 
            (CODUNI, DESUNI) 
            VALUES 
            (@CodigoUnidad, @DescripcionUnidad)";

        private const string actualizarUnidadQuery = @"
            UPDATE SFTUNID0 SET
                DESUNI = @DescripcionUnidad
            WHERE CODUNI = @CodigoUnidad";

        private const string eliminarUnidadQuery = @"
            DELETE FROM SFTUNID0 WHERE CODUNI = @codigo";

        static Dictionary<string, string> unidadesMedidaHeaders = new Dictionary<string, string>()
        {
            {"colCodigoUnidad", "CODUNI"},
            {"colDescripcionUnidad", "DESUNI"}
        };
       
        public UnidadesMedida() { }

        public UnidadesMedida (string? codigoUnidad, string? descripcionUnidad)
        {
            CodigoUnidad = codigoUnidad;
            DescripcionUnidad = descripcionUnidad;
        }

        private static Dictionary<string, object> ObtenerParametrosUnidadConFilas(UnidadesMedida unidad)
        {
            return new Dictionary<string, object>
            {
                {"@CodigoUnidad", unidad.CodigoUnidad ?? string.Empty},
                {"@DescripcionUnidad", unidad.DescripcionUnidad ?? string.Empty}
            };
        }

        public static bool InsertarUnidad(UnidadesMedida unidad)
        {
            return (UtilidadesBD.GuardarRegistro(
                insertarUnidadQuery,
                ObtenerParametrosUnidadConFilas(unidad)
                ) > 0);
        }

        public bool ActualizarUnidad(UnidadesMedida unidad)
        {
            return (UtilidadesBD.GuardarRegistro(
                actualizarUnidadQuery,
                ObtenerParametrosUnidadConFilas(unidad)
                ) > 0);
        }

        public bool EliminarUnidad(UnidadesMedida unidad)
        {
            if (string.IsNullOrEmpty(unidad.CodigoUnidad))
                throw new ArgumentNullException(nameof(unidad.CodigoUnidad), "El código de unidad no puede ser nulo ni vacío.");

            return (UtilidadesBD.EliminarRegistro(
                eliminarUnidadQuery,
                unidad.CodigoUnidad
                ) > 0);
        }

        public static void ObtenerUnidades(DataGridView dataGrid)
        {
            DataTable tabla = UtilidadesBD.ObtenerTodosLosRegistros(getUnidadesMedidaQuery);

            UtilidadesUI.CargarDatosEnGridConFilas(
                tabla,
                dataGrid,
                unidadesMedidaHeaders
            );
        }

        public static UnidadesMedida? ObtenerUnidadPorCodigo(string codigoUnidad)
        {
            Dictionary<string, object>? datos =
                UtilidadesBD.BuscarRegistro(getUnidadMedidaPorCodigoQuery, codigoUnidad);

            if (datos == null || datos.Count == 0) return null;

            return new UnidadesMedida()
            {
                CodigoUnidad = datos.ContainsKey("CODUNI") ? datos["CODUNI"]?.ToString() : "",
                DescripcionUnidad = datos.ContainsKey("DESUNI") ? datos["DESUNI"]?.ToString() : "",
            };
        }

        public static DataTable ObtenerListadoCodigos()
        {
            string query = "SELECT CODUNI, DESUNI FROM SFTUNID0";
            return UtilidadesBD.ObtenerTodosLosRegistros(query);
        }
    }
}
