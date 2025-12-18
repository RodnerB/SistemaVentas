using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaVentas.Utilidades;

namespace SistemaVentas
{
    public class Empresa
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

        // Diccionario para mapear columnas del DataGridView de empresa
        private static readonly Dictionary<string, string> filasHeaders = new()
        {
            { "colNombreEmpresa", "empresa" },
            { "colDireccion", "direccion" },
            { "colTelefono", "telefono" },
            { "colFax", "fax" },
            { "colCorreoElectronico", "email" }
        };

        public Empresa(string nombre, string direccion, string telefono, string fax, string email)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Fax = fax;
            Email = email;
        }

        // Método para cargar los datos de la empresa en un DataGridView usando el patrón "ConFilas"
        public static void CargarEmpresaEnGridConFilas(DataGridView dgv)
        {
            try
            {
                DataTable dtEmpresa = UtilidadesBD.ObtenerTodosLosRegistros("SELECT TOP 1 * FROM SFTCONF0");
                UtilidadesUI.CargarDatosEnGridConFilas(dtEmpresa, dgv, filasHeaders);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información de la empresa: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para guardar una nueva empresa en la base de datos
        public static bool GuardarEmpresa(Empresa empresa)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(empresa.Nombre) ||
                    string.IsNullOrWhiteSpace(empresa.Direccion) ||
                    string.IsNullOrWhiteSpace(empresa.Telefono) ||
                    string.IsNullOrWhiteSpace(empresa.Email))
                {
                    return false;
                }

                var parametros = new Dictionary<string, object>
                {
                    { "@empresa", empresa.Nombre },
                    { "@direccion", empresa.Direccion },
                    { "@telefono", empresa.Telefono },
                    { "@fax", empresa.Fax },
                    { "@email", empresa.Email }
                };
                int filas = UtilidadesBD.GuardarRegistro(
                    "INSERT INTO SFTCONF0 (empresa, direccion, telefono, fax, email) VALUES (@empresa, @direccion, @telefono, @fax, @email)",
                    parametros
                );
                return filas > 0;
            }
            catch
            {
                return false;
            }
        }

        public static bool ActualizarEmpresa(Empresa empresa)
        {
            try
            {
                var parametros = new Dictionary<string, object>
                {
                    { "@empresa", empresa.Nombre },
                    { "@direccion", empresa.Direccion },
                    { "@telefono", empresa.Telefono },
                    { "@fax", empresa.Fax },
                    { "@email", empresa.Email }
                };
                int filas = UtilidadesBD.GuardarRegistro(
                    "UPDATE SFTCONF0 SET empresa = @empresa, direccion = @direccion, telefono = @telefono, fax = @fax, email = @email",
                    parametros
                );
                return filas > 0;
            }
            catch
            {
                return false;
            }
        }

        public static void EliminarInformacionEmpresarial()
        {
            UtilidadesBD.EliminarRegistro("DELETE FROM SFTCONF0", "");
        }
    }
}
