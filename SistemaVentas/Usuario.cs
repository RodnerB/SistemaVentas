using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.Utilidades;
namespace SistemaVentas
{
    internal class Usuario
    {
        public string usuario;
        public string password;
        public string nombre;
        public string estado;

        private const string getUsuarioPorCodigoQuery = "SELECT * FROM SFTUSUA0 WHERE USUARIO = @codigo";

        public Usuario(string usuario, string password)
        {
            this.usuario = usuario;
            this.password = password;
        }

        public Usuario() { }

        public static Usuario? ObtenerUsuarioPorUsuario(string usuario)
        {
            Dictionary<string, object>? datos = UtilidadesBD.BuscarRegistro(
                getUsuarioPorCodigoQuery,
                usuario);

            if (datos == null) return null;

            return new Usuario
            {
                usuario = (string)datos["USUARIO"]!,
                password = (string)datos["PASSWORD"]!,
                nombre = (string)datos["NOMUSU"]!,
                estado = (string)datos["ESTAUSU"]!
            };


        }
        public static bool validarPassword(Usuario usuarioEntrante)
        {
            Usuario? usuarioBD = ObtenerUsuarioPorUsuario(usuarioEntrante.usuario);
            if(usuarioBD == null || usuarioBD.password != usuarioEntrante.password) return false;
            return true;
        }
    }
}
