using SistemaVentas.Utilidades;
using System.CodeDom;
using System.Data;

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

        private static Dictionary<string, object> ObtenerParametrosCliente(Cliente cliente)
        {
            if (cliente.CodigoCliente == null) throw new ArgumentException("El código del cliente no puede ser nulo.");
            if (cliente.NombreCliente == null) throw new ArgumentException("El nombre del cliente no puede ser nulo.");
            return new Dictionary<string, object>()
            {
                {"@CodigoCliente", cliente.CodigoCliente},
                {"@NombreCliente", cliente.NombreCliente},
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

        public static bool InsertarCliente(Cliente cliente)
        {
            return (Utilidades.UtilidadesBD.GuardarRegistro(
                insertarClienteQuery,
                ObtenerParametrosCliente(cliente)
            ) > 0);
        }


        public string CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string? ApellidoCliente { get; set; }
        public string? DireccionCliente { get; set; }
        public string? SectorCliente { get; set; }
        public string? CiudadCliente { get; set; }
        public string? TelefonoCliente { get; set; }
        public string? FaxCliente { get; set; }
        public decimal? LimiteCreditoCliente { get; set; }
        public decimal? BalanceActualCliente { get; set; }
        public string? ObservacionesCliente { get; set; }

        //public Cliente(string? codigoCliente, string? nombreCliente, string? apellidoCliente, string? direccionCliente, string? sectorCliente, string? ciudadCliente, string? telefonoCliente, string? faxCliente, decimal? limiteCreditoCliente, decimal? balanceActualCliente, string? observacionesCliente)
        //{
        //    CodigoCliente = codigoCliente;
        //    NombreCliente = nombreCliente;
        //    ApellidoCliente = apellidoCliente;
        //    DireccionCliente = direccionCliente;
        //    SectorCliente = sectorCliente;
        //    CiudadCliente = ciudadCliente;
        //    TelefonoCliente = telefonoCliente;
        //    FaxCliente = faxCliente;
        //    LimiteCreditoCliente = limiteCreditoCliente;
        //    BalanceActualCliente = balanceActualCliente;
        //    ObservacionesCliente = observacionesCliente;
        //}

        public static void ObtenerClientes(DataGridView dataGrid)
        {
            DataTable tabla = UtilidadesBD.ObtenerTodosLosRegistros(getClientesQuery);
            Utilidades.UtilidadesUI.CargarDatosEnGrid(
                tabla,
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
