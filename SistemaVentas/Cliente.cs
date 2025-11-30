using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SistemaVentas.Utilidades;

namespace SistemaVentas
{
    internal class Cliente
    {
        private const string getClientesQuery = "SELECT * FROM SFTCLI0";
        private const string getClientePorCodigoQuery = "SELECT * FROM SFTCLI0 WHERE CODCLI = @codigo";
        private const string insertarClienteQuery = @"
            INSERT INTO SFTCLI0
            (CODCLI, NOMCLI, APECLI, DIRCLI, SECCLI, CIUCLI, TELCLI, FAXCLI, LIMCRED, BALACT, OBSCLI)
            VALUES
            (@CodigoCliente, @NombreCliente, @ApellidoCliente, @DireccionCliente, @SectorCliente, @CiudadCliente, @TelefonoCliente, @FaxCliente, @LimiteCreditoCliente, @BalanceActualCliente, @ObservacionesCliente)";
        private const string eliminarClienteQuery = "DELETE FROM SFTCLI0 WHERE CODCLI = @codigo";

        static readonly Dictionary<string, string> clientesHeaders = new()
        {
            {"CODCLI", "Código Cliente"},
            {"NOMCLI", "Nombre"},
            {"APECLI", "Apellido"},
            {"DIRCLI", "Dirección"},
            {"SECCLI", "Sector"},
            {"CIUCLI", "Ciudad"},
            {"TELCLI", "Teléfono"},
            {"FAXCLI", "Fax"},
            {"LIMCRED", "Límite Crédito"},
            {"BALACT", "Balance Actual"},
            {"OBSCLI", "Observaciones"}
        };

        public string? CodigoCliente { get; set; } = "";
        public string? NombreCliente { get; set; } = "";
        public string? ApellidoCliente { get; set; } = "";
        public string? DireccionCliente { get; set; } = "";
        public string? SectorCliente { get; set; } = "";
        public string? CiudadCliente { get; set; } = "";
        public string? TelefonoCliente { get; set; } = "";
        public string? FaxCliente { get; set; } = "";
        public float LimiteCreditoCliente { get; set; } = 0;
        public float BalanceActualCliente { get; set; } = 0;
        public string? ObservacionesCliente { get; set; } = "";

        public Cliente() { }

        public Cliente(string? codigo, string? nombre, string? direccion, string? ciudad, string? telefono)
        {
            CodigoCliente = codigo ?? "";
            NombreCliente = nombre ?? "";
            DireccionCliente = direccion ?? "";
            CiudadCliente = ciudad ?? "";
            TelefonoCliente = telefono ?? "";
        }

        private static Dictionary<string, object> ObtenerParametrosCliente(Cliente c)
        {
            return new Dictionary<string, object>()
            {
                {"@CodigoCliente", c.CodigoCliente ?? string.Empty},
                {"@NombreCliente", c.NombreCliente ?? string.Empty},
                {"@ApellidoCliente", c.ApellidoCliente ?? string.Empty},
                {"@DireccionCliente", c.DireccionCliente ?? string.Empty},
                {"@SectorCliente", c.SectorCliente ?? string.Empty},
                {"@CiudadCliente", c.CiudadCliente ?? string.Empty},
                {"@TelefonoCliente", c.TelefonoCliente ?? string.Empty},
                {"@FaxCliente", c.FaxCliente ?? string.Empty},
                {"@LimiteCreditoCliente", c.LimiteCreditoCliente},
                {"@BalanceActualCliente", c.BalanceActualCliente},
                {"@ObservacionesCliente", c.ObservacionesCliente ?? string.Empty}
            };
        }

        public static void ObtenerClientes(DataGridView dataGrid)
        {
            DataTable tabla = UtilidadesBD.ObtenerTodosLosRegistros(getClientesQuery);
            UtilidadesUI.CargarDatosEnGrid(tabla, dataGrid, clientesHeaders);
        }

        public static Cliente? ObtenerClientePorCodigo(string codigo)
        {
            Dictionary<string, object>? datos = UtilidadesBD.BuscarRegistro(getClientePorCodigoQuery, codigo);
            if (datos == null || datos.Count == 0) return null;

            return new Cliente()
            {
                CodigoCliente = datos.ContainsKey("CODCLI") ? datos["CODCLI"]?.ToString() : "",
                NombreCliente = datos.ContainsKey("NOMCLI") ? datos["NOMCLI"]?.ToString() : "",
                ApellidoCliente = datos.ContainsKey("APECLI") ? datos["APECLI"]?.ToString() : "",
                DireccionCliente = datos.ContainsKey("DIRCLI") ? datos["DIRCLI"]?.ToString() : "",
                SectorCliente = datos.ContainsKey("SECCLI") ? datos["SECCLI"]?.ToString() : "",
                CiudadCliente = datos.ContainsKey("CIUCLI") ? datos["CIUCLI"]?.ToString() : "",
                TelefonoCliente = datos.ContainsKey("TELCLI") ? datos["TELCLI"]?.ToString() : "",
                FaxCliente = datos.ContainsKey("FAXCLI") ? datos["FAXCLI"]?.ToString() : "",
                LimiteCreditoCliente = datos.ContainsKey("LIMCRED") && float.TryParse(datos["LIMCRED"]?.ToString(), out var lc) ? lc : 0,
                BalanceActualCliente = datos.ContainsKey("BALACT") && float.TryParse(datos["BALACT"]?.ToString(), out var ba) ? ba : 0,
                ObservacionesCliente = datos.ContainsKey("OBSCLI") ? datos["OBSCLI"]?.ToString() : ""
            };
        }

        public bool InsertarCliente()
        {
            int filas = UtilidadesBD.GuardarRegistro(insertarClienteQuery, ObtenerParametrosCliente(this));
            return filas > 0;
        }

        public static bool eliminarCliente(string codigo)
        {
            int filas = UtilidadesBD.EliminarRegistro(eliminarClienteQuery, codigo);
            return filas > 0;
        }
    }
}