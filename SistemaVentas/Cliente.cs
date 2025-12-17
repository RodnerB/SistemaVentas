using SistemaVentas.Utilidades;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVentas
{
    class Cliente
    {
        /* Parametros obligatorios */
        // inicializado para evitar nullables en el constructor vacio, estos seran llenados obligatoriamente
        
        public string CodigoCliente { get; set; } = string.Empty;
        
        public string NombreCliente { get; set; } = string.Empty;
        
        public string DireccionCliente { get; set; } = string.Empty;
        
        public string CiudadCliente { get; set; } = string.Empty;
        
        public string TelefonoCliente { get; set; } = string.Empty;

        /* Parametros opcionales */
        public string ApellidoCliente { get; set; } = string.Empty;
        public string SectorCliente { get; set; } = string.Empty;
        public string FaxCliente { get; set; } = string.Empty;
        public string ObservacionesCliente { get; set; } = string.Empty;
        // Aun parametros opcionales, pero se valida que estos no contengan
        // un valor negativo

        public float LimiteCreditoCliente { get; set; } = 0f;

        public float BalanceActualCliente { get; set; } = 0f;

        // Estado para determinar si se debe crear o actualizar el cliente
        public bool existe { get; set; } = false;

        // Querys generales
        private const string getClientesQuery = "SELECT * FROM SFTCLIE0";
        private const string getClientePorCodigoQuery = "SELECT * FROM SFTCLIE0 WHERE CODCLI = @codigo";
        private const string insertarClienteQuery = @"
            INSERT INTO SFTCLIE0 
            (CODCLI, NOMCLI, APECLI, DIRCLI, SECCLI, CIUCLI, TELCLI, NUMFAX, LIMCRE, BALCLI, OBSCLI) 
            VALUES 
            (@CodigoCliente, @NombreCliente, @ApellidoCliente, @DireccionCliente, @SectorCliente, @CiudadCliente, @TelefonoCliente, @FaxCliente, @LimiteCreditoCliente, @BalanceActualCliente, @ObservacionesCliente)";
        private const string actualizarClienteQuery = @"
            UPDATE SFTCLIE0
            SET 
                NOMCLI = @NombreCliente,
                APECLI = @ApellidoCliente,
                DIRCLI = @DireccionCliente,
                SECCLI = @SectorCliente,
                CIUCLI = @CiudadCliente,
                TELCLI = @TelefonoCliente,
                NUMFAX = @FaxCliente,
                LIMCRE = @LimiteCreditoCliente,
                BALCLI = @BalanceActualCliente,
                OBSCLI = @ObservacionesCliente
            WHERE 
                CODCLI = @CodigoCliente";
        private const string eliminarClienteQuery = "DELETE FROM SFTCLIE0 WHERE CODCLI = @codigo";

        // Headers para renombrar columnas 

        private static Dictionary<string, string> filasHeaders = new()
        {
            {"colCodigo", "CODCLI" },
            {"colNombre", "NOMCLI" },
            {"colApellido", "APECLI" },
            {"colDireccion", "DIRCLI" },
            {"colSector", "SECCLI" },
            {"colCiudad", "CIUCLI" },
            {"colTelefono", "TELCLI" },
            {"colFax", "NUMFAX" },
            {"colLimite", "LIMCRE" },
            {"colBalance", "BALCLI" },
            {"colObservaciones", "OBSCLI" }
        };

        public Cliente() { }
        public Cliente(string codigoCliente, string nombreCliente, string direccionCliente, string ciudadCliente, string telefonoCliente)
        {
            CodigoCliente = codigoCliente;
            NombreCliente = nombreCliente;
            DireccionCliente = direccionCliente;
            CiudadCliente = ciudadCliente;
            TelefonoCliente = telefonoCliente;
        }

        // Metodo para obtener parametros del cliente
        private static Dictionary<string, object> ObtenerParametrosCliente(Cliente cliente)
        {
            return new Dictionary<string, object>()
            {
                {"@CodigoCliente", cliente.CodigoCliente},
                {"@NombreCliente", cliente.NombreCliente},
                {"@ApellidoCliente", cliente.ApellidoCliente},
                {"@DireccionCliente", cliente.DireccionCliente},
                {"@SectorCliente", cliente.SectorCliente},
                {"@CiudadCliente", cliente.CiudadCliente},
                {"@TelefonoCliente", cliente.TelefonoCliente},
                {"@FaxCliente", cliente.FaxCliente},
                {"@LimiteCreditoCliente", cliente.LimiteCreditoCliente},
                {"@BalanceActualCliente", cliente.BalanceActualCliente},
                {"@ObservacionesCliente", cliente.ObservacionesCliente}
            };
        }

        public bool InsertarCliente()
        {
            string query = existe ? actualizarClienteQuery : insertarClienteQuery;
            Validador.Requerido(this);
            return (UtilidadesBD.GuardarRegistro(
                query,
                ObtenerParametrosCliente(this)
            ) > 0);
        }

        public static DataTable ObtenerClientes() => UtilidadesBD.ObtenerTodosLosRegistros(getClientesQuery);

        public static void CargarClientesGridConFilas(DataGridView dataGrid)
        {
            DataTable tabla = ObtenerClientes();
            UtilidadesUI.CargarDatosEnGridConFilas(
                tabla,
                dataGrid,
                filasHeaders
                );
        }
        public static Cliente? ObtenerClientePorCodigo(string codigoCliente)
        {
            Dictionary<string, object>? datos = UtilidadesBD.BuscarRegistro(
                getClientePorCodigoQuery,
                codigoCliente);

            if (datos == null) return null;

            return new Cliente()
            {
                CodigoCliente = (string)datos["CODCLI"]!,
                NombreCliente = (string)datos["NOMCLI"]!,
                ApellidoCliente = datos["APECLI"] as string ?? string.Empty,
                DireccionCliente = (string)datos["DIRCLI"]!,
                SectorCliente = datos["SECCLI"] as string ?? string.Empty,
                CiudadCliente = (string)datos["CIUCLI"]!,
                TelefonoCliente = (string)datos["TELCLI"]!,
                FaxCliente = datos["NUMFAX"] as string ?? string.Empty,
                LimiteCreditoCliente = datos["LIMCRE"] is DBNull ? 0 : Convert.ToSingle(datos["LIMCRE"]),
                BalanceActualCliente = datos["BALCLI"] is DBNull ? 0 : Convert.ToSingle(datos["BALCLI"]),
                ObservacionesCliente = datos["OBSCLI"] as string ?? string.Empty
            };



        }

        public static bool eliminarCliente(string codigoCliente) => (UtilidadesBD.
            EliminarRegistro(eliminarClienteQuery, codigoCliente) > 0);
    }
}
