using System.Data;
using Microsoft.Data.SqlClient;
using SistemaVentas.Utilidades;

namespace SistemaVentas
{
    internal class Detalles
    {
        private const string getDetallesQuery = @"
            SELECT  D.NUMFAC,
                    D.CODART,
                    A.DESART,
                    D.CANTVEN,
                    D.PRECVEN
            FROM SFTDETFAC D
            INNER JOIN SFTARTI0 A ON D.CODART = A.CODART";

        private const string getDetallesPorCodigoQuery = @"
            SELECT  D.NUMFAC,
                    D.CODART,
                    A.DESART,
                    D.CANTVEN,
                    D.PRECVEN
            FROM SFTDETFAC D
            INNER JOIN SFTARTI0 A ON D.CODART = A.CODART
            WHERE D.NUMFAC = @codigo";

        private const string insertDetallesQuery = @"
            INSERT INTO SFTDETFAC 
                (NUMFAC, CODART, CANTVEN, PRECVEN) 
            VALUES 
                (@NUMFAC, @CODART, @CANTVEN, @PRECVEN)";

        private const string actualizarCantidadQuery = @"
            UPDATE SFTARTI0 
            SET EXIACT = EXIACT - @cantidad 
            WHERE CODART = @codigo";

        private static readonly Dictionary<string, string> filasHeaders = new()
        {
            { "colNombreArticulo", "DESART"  },
            { "colCantidad",       "CANTVEN" },
            { "colPrecio",         "PRECVEN" }
        };

        public int NumeroFactura { get; set; }
        public string CodigoArticulo { get; set; }
        public int CantidadVendida { get; set; }
        public float PrecioVenta { get; set; }

        public Detalles(int numeroFactura, string codigoArticulo, int cantidadVendida, float precioVenta)
        {
            NumeroFactura = numeroFactura;
            CodigoArticulo = codigoArticulo;
            CantidadVendida = cantidadVendida;
            PrecioVenta = precioVenta;
        }

        private static Dictionary<string, object> ObtenerParametrosDetalles(Detalles detalle)
        {
            return new Dictionary<string, object>
            {
                { "@NUMFAC", detalle.NumeroFactura },
                { "@CODART", detalle.CodigoArticulo },
                { "@CANTVEN", detalle.CantidadVendida },
                { "@PRECVEN", detalle.PrecioVenta }
            };
        }

        public bool InsertarDetalle()
        {
            return UtilidadesBD.GuardarRegistro(
                insertDetallesQuery,
                ObtenerParametrosDetalles(this)
            ) > 0;
        }

        public static DataTable ObtenerDetalles()
        {
            return UtilidadesBD.ObtenerTodosLosRegistros(getDetallesQuery);
        }

        public static DataTable ObtenerDetallesPorCodigo(int numeroFactura)
        {
            DataTable tabla = new();

            try
            {
                using SqlConnection conexion = ConexionDB.ObtenerConexion();
                using SqlCommand comando = new(getDetallesPorCodigoQuery, conexion);
                comando.Parameters.AddWithValue("@codigo", numeroFactura);

                using SqlDataAdapter adaptador = new(comando);
                adaptador.Fill(tabla);

                return tabla;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener los detalles por código: " + ex.Message);
            }
        }

        public static void CargarDetallesGridConFilas(DataGridView dataGrid, int numeroFactura)
        {
            DataTable tabla = ObtenerDetallesPorCodigo(numeroFactura);

            UtilidadesUI.CargarDatosEnGridConFilas(
                tabla,
                dataGrid,
                filasHeaders
            );
        }

        public static void ActualizarExistenciaArticulo(string codigoArticulo, int cantidadVendida)
        {
            UtilidadesBD.GuardarRegistro(
                actualizarCantidadQuery,
                new Dictionary<string, object>
                {
                    { "@codigo", codigoArticulo },
                    { "@cantidad", cantidadVendida }
                }
            );
        }
    }
}