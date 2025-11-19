using Microsoft.Data.SqlClient;
using SistemaVentas.Utilidades;
using System.Data;

namespace SistemaVentas
{
     class UnidadesMedida
    {
        private const string getUnidadesMedidaQuery = "SELECT * FROM  SFTUNID0";
        private const string getUnidadMedidaPorCodigoQuery = "SELECT * FROM SFTUNID0 WHERE CODUNI = @codigo";
        private const string insertUnidadMedidaQuery = @"
            INSERT INTO SFTUNID0 
            (CODUNI, DESUNI) 
            VALUES 
            (@CODUNI, @DESUNI)";
        static Dictionary<string, string> unidadesMedidaHeaders = new Dictionary<string, string>()
        {
            {"CODUNI", "Código Unidad de Medida" },
            {"DESUNI", "Descripción Unidad de Medida"}
        };
        public string? CodigoUnidad { get; set; } = "";
        public string? DescripcionUnidad { get; set; } = "";

        public static void ObtenerUnidadesMedida(DataGridView dataGrid)
        {
            DataTable tabla = UtilidadesBD.ObtenerTodosLosRegistros(getUnidadesMedidaQuery);
            Utilidades.UtilidadesUI.CargarDatosEnGrid(
                tabla,
                dataGrid,
                unidadesMedidaHeaders
                );
        }
        public static UnidadesMedida? ObtenerUnidadMedidaPorCodigo(string codigoUnidad)
        {
            Dictionary<string, object> datos = Utilidades.UtilidadesBD.BuscarRegistro(
                getUnidadMedidaPorCodigoQuery,
                codigoUnidad);
            if (datos == null) return null;
            return new UnidadesMedida()
            {
                CodigoUnidad = datos["CODUNI"].ToString(),
                DescripcionUnidad = datos["DESUNI"].ToString(),
            };
        }

        public static DataTable ObtenerTodasUnidades()
        {
            var dt = new DataTable();
            using var conexion = ConexionDB.ObtenerConexion();
            string consulta = "SELECT CODUNI, DESUNI FROM SFTUNID0";
            using var comando = new SqlCommand(consulta, conexion);
            using var adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(dt);
            return dt;
        }
    }
}
