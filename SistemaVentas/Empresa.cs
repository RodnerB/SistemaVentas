using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas
{
    internal class Empresa
    {
        public string empresa { get; private set; }
        public string direccion { get; private set; }
        public string telefono { get; private set; }
        public string fax { get; private set; }
        public string email { get; private set; }
        public Empresa(string empresa, string direccion, string telefono, string fax, string email)
        {
            this.empresa = empresa;
            this.direccion = direccion;
            this.telefono = telefono;
            this.fax = fax;
            this.email = email;
        }

        private const string insertarEmpresaQuery = @"
            INSERT INTO SFTCONF0
            (EMPRESA, DIRECCION, TELEFONO, FAX, EMAIL)
            VALUES
            (@EMPRESA, @DIRECCION, @TELEFONO, @FAX, @EMAIL)";
        private static Dictionary<string, object> ObtenerParametrosEmpresa(Empresa empresa)
        {
            return new Dictionary<string, object>()
            {
                {"@EMPRESA", empresa.empresa},
                {"@DIRECCION", empresa.direccion},
                {"@TELEFONO", empresa.telefono},
                {"@FAX", empresa.fax},
                {"@EMAIL", empresa.email}
            };
        }

        public static void InsertarEmpresa(Empresa empresa)
        {
            Utilidades.UtilidadesBD.GuardarRegistro(
                insertarEmpresaQuery,
                ObtenerParametrosEmpresa(empresa),
                "Empresa"
            );
        }

        public static Empresa ObtenerEmpresa()
        {
            DataTable tabla = Utilidades.UtilidadesBD.ObtenerTodosLosRegistros("SELECT TOP 1 * FROM SFTCONF0");
            if (tabla.Rows.Count == 0)
            {
                throw new Exception("No se encontró ninguna empresa en la base de datos.");
            }

            DataRow fila = tabla.Rows[0];
            return new Empresa(
                fila["empresa"].ToString(),
                fila["direccion"].ToString(),
                fila["telefono"].ToString(),
                fila["fax"].ToString(),
                fila["email"].ToString());
        }
    }
}
