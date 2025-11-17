using System.CodeDom;

namespace SistemaVentas
{
    class Cliente
    {
        private const string getClientesQuery = "SELECT * FROM SFTCLIE0";
        private const string getClientePorCodigoQuery = "SELECT * FROM SFTCLIE0 WHERE CODCLI = @codigo";
        private const string insertarClienteQuery = @"
            INSERT INTO SFTCLIE0 
            (CODCLI, NOMCLI, APECLI, DIRCLI, SECCLI, CIUCLI, TELCLI, NUMFAX, LIMCRE, BALCLI, OBSCLI) 
            VALUES 
            (@CodigoCliente, @NombreCliente, @ApellidoCliente, @DireccionCliente, @SectorCliente, @CiudadCliente, @TelefonoCliente, @FaxCliente, @LimiteCreditoCliente, @BalanceActualCliente, @ObservacionesCliente)";
        private static Dictionary<string, string> clientesHeaders = new Dictionary<string, string>()
        {
            {"CODCLI", "Código Cliente" },
            {"NOMCLI", "Nombre Cliente" },
            {"APECLI", "Apellido Cliente" },
            {"DIRCLI", "Dirección Cliente" },
            {"SECCLI", "Sector Cliente" },
            {"CIUCLI", "Ciudad Cliente" },
            {"TELCLI", "Teléfono Cliente" },
            {"NUMFAX", "Fax Cliente" },
            {"LIMCRE", "Límite Créditicio Cliente" },
            {"BALCLI", "Balance Actual Cliente" },
            {"OBSCLI", "Observaciones Cliente" }
        };

        private static Dictionary<string, object> ObtenerParametrosInsertarCliente(Cliente cliente)
        {
            if (cliente.CodigoCliente == null) throw new ArgumentException("El código del cliente no puede ser nulo.");
            if (cliente.NombreCliente == null) throw new ArgumentException("El nombre del cliente no puede ser nulo.");
            return new Dictionary<string, object>()
            {
                {"@CodigoCliente", cliente.CodigoCliente},
                {"@NombreCliente", cliente.NombreCliente ?? ""},
                {"@ApellidoCliente", cliente.ApellidoCliente ?? ""},
                {"@DireccionCliente", cliente.DireccionCliente ?? ""},
                {"@SectorCliente", cliente.SectorCliente ?? ""},
                {"@CiudadCliente", cliente.CiudadCliente ?? ""},
                {"@TelefonoCliente", cliente.TelefonoCliente ?? ""},
                {"@FaxCliente", cliente.FaxCliente ?? ""},
                {"@LimiteCreditoCliente", cliente.LimiteCreditoCliente ?? 0 },
                {"@BalanceActualCliente", cliente.BalanceActualCliente ?? 0 },
                {"@ObservacionesCliente", cliente.ObservacionesCliente ?? ""}
            };
        }

        public static void InsertarCliente(Cliente cliente)
        {
            Utilidades.UtilidadesBD.GuardarRegistro(
                insertarClienteQuery,
                ObtenerParametrosInsertarCliente(cliente),
                "Cliente"
            );
        }


        public string? CodigoCliente { get; set; } = "";
        public string? NombreCliente { get; set; }
        public string? ApellidoCliente { get; set; }
        public string? DireccionCliente { get; set; }
        public string? SectorCliente { get; set; }
        public string? CiudadCliente { get; set; }
        public string? TelefonoCliente { get; set; }
        public string? FaxCliente { get; set; }
        public decimal? LimiteCreditoCliente { get; set; }
        public decimal? BalanceActualCliente { get; set; }
        public string? ObservacionesCliente { get; set; }

        public static void ObtenerClientes(DataGridView dataGrid)
        {
            Utilidades.UtilidadesUI.CargarDatosEnGrid(
                getClientesQuery,
                dataGrid,
                clientesHeaders
                );
        }

        public static Cliente? ObtenerClientePorCodigo(string codigoCliente)
        {
            Dictionary<string, object>? datos = Utilidades.UtilidadesBD.BuscarRegistro(
                getClientePorCodigoQuery,
                codigoCliente);

            if (datos == null) throw new ArgumentNullException("Cliente no encontrado");

            return new Cliente()
            {
                CodigoCliente = datos["CODCLI"].ToString(),
                NombreCliente = datos["NOMCLI"].ToString(),
                ApellidoCliente = datos["APECLI"].ToString(),
                DireccionCliente = datos["DIRCLI"].ToString(),
                SectorCliente = datos["SECCLI"].ToString(),
                CiudadCliente = datos["CIUCLI"].ToString(),
                TelefonoCliente = datos["TELCLI"].ToString(),
                FaxCliente = datos["NUMFAX"].ToString(),
                LimiteCreditoCliente = Convert.ToDecimal(datos["LIMCRE"]),
                BalanceActualCliente = Convert.ToDecimal(datos["BALCLI"]),
                ObservacionesCliente = datos["OBSCLI"].ToString()
            };

        }

    }
}
