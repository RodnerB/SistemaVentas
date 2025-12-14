using SistemaVentas.Utilidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SistemaVentas
{
    public partial class Usuario
    {
        public string usuario;
        public string password;
        public string nombre = string.Empty;
        public string estado = "2";
        public bool existe = false;
        private const string getUsuarioPorCodigoQuery = "SELECT * FROM SFTUSUA0 WHERE USUARIO = @codigo";
        private const string insertarUsuarioQuery = @"INSERT INTO SFTUSUA0 (USUARIO, PASSWORD, NOMUSU, ESTAUSU)
                                                        VALUES(@usuario, @password, @nomusu, @estausu)";
        private const string actualizarUsuarioQuery = @"
            UPDATE SFTUSUA0
            SET 
                NOMUSU = @nomusu,
                PASSWORD = @password,
                ESTAUSU = @estausu
            WHERE 
                USUARIO = @usuario";
        public Usuario(string usuario, string password)
        {
            this.usuario = usuario;
            this.password = password;
        }

        private static Dictionary<string, object> ObtenerParametrosUsuario(Usuario usuario)
        {
            return new Dictionary<string, object>()
            {
                {"@usuario", usuario.usuario},
                {"@password", usuario.password},
                {"@nomusu", usuario.nombre},
                {"@estausu", usuario.estado}
            };
        }

        public static Usuario? ObtenerUsuarioPorUsuario(string usuario)
        {
            Dictionary<string, object>? datos = UtilidadesBD.BuscarRegistro(
                getUsuarioPorCodigoQuery,
                usuario);

            if (datos == null) return null;

            return new Usuario((string)datos["USUARIO"], (string)datos["PASSWORD"])
            {
                nombre = (string)datos["NOMUSU"]!,
                estado = (string)datos["ESTAUSU"]!,
                existe = true
            };
        }

        public bool GuardarUsuario()
        {
            string query = existe ? actualizarUsuarioQuery : insertarUsuarioQuery;
            return (UtilidadesBD.GuardarRegistro(
                query,
                ObtenerParametrosUsuario(this)
            ) > 0);
        }
        public static bool validarPassword(Usuario usuarioEntrante)
        {
            Usuario? usuarioBD = ObtenerUsuarioPorUsuario(usuarioEntrante.usuario);
            if(usuarioBD == null || usuarioBD.password != usuarioEntrante.password) return false;
            return true;
        }
    }
}
