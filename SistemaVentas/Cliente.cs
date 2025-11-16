namespace SistemaVentas
{
    class Cliente
    {
        private const string getClientesQuery = "SELECT * FROM SFTCLIE0";
        private const string getClientePorCodigoQuery = "SELECT * FROM SFTCLIE0 WHERE CODCLI = @codigo";
        private const string insertClienteQuery = @"
            INSERT INTO SFTCLIE0 
            (CODCLI, NOMCLI, APECLI, DIRCLI, SECCLI, CIUCLI, TELCLI, NUMFAX, LIMCRE, BALCLI, OBSCLI) 
            VALUES 
            (@CodigoCliente, @NombreCliente, @ApellidoCliente, @DireccionCliente, @SectorCliente, @CiudadCliente, @TelefonoCliente, @FaxCliente, @LimiteCreditoCliente, @BalanceActualCliente, @ObservacionesCliente)";
        static Dictionary<string, string> clientesHeaders = new Dictionary<string, string>()
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
        public string? CodigoCliente { get; set; }
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

            if (datos == null) return null;

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
