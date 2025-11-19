namespace SistemaVentas
{
    internal class ConnectionString
    {
        private static string connectionString = @"Server=JOSE;Database=BDPROGRAMACION3;Trusted_Connection=True;TrustServerCertificate=True;";

        public static string GetConnectionString() => connectionString;
    }
}