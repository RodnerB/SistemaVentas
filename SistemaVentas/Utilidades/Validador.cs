namespace SistemaVentas.Utilidades
{
    public class Validador
    {
        // Procedimiento para validad que las propiedades marcadas
        // como [Requerido] no sean nulas, vacias, o que si sean del tipo esperado
        public static void Requerido(object objeto)
        {
            ArgumentNullException.ThrowIfNull(objeto);

            var tipoObjeto = objeto.GetType();
            var propiedades = tipoObjeto.GetProperties();

            foreach( var propiedad in propiedades)
            {
                // Si la propiedad no tiene el atributo [Requerido], pasa a la proxima propiedad
                if (!propiedad.IsDefined(typeof(RequeridoAttribute), false))
                    continue;

                // se recupera el valor y el tipo de la propiedad
                var valorPropiedad = propiedad.GetValue(objeto);
                var tipoPropiedad = propiedad.PropertyType;

                // validacion para tipo string
                if (tipoPropiedad == typeof(string))
                {
                    // cast de valorPropiedad (actualmente un Object) a string
                    string? s = (string?)valorPropiedad;
                    // valida que no sea nulo o vacio
                    if (string.IsNullOrWhiteSpace(s)) throw new ArgumentException($"{propiedad.Name} es obligatorio.");
                    continue;
                }

                // Validacion para tipos numericos
                if (tipoPropiedad == typeof(int) ||
                   tipoPropiedad == typeof(float) ||
                   tipoPropiedad == typeof(double) ||
                   tipoPropiedad == typeof(decimal))
                {
                    // convierte el valor a decimal para la validacion
                    decimal numero = Convert.ToDecimal(valorPropiedad);
                    if (numero < 0) throw new ArgumentException($"{propiedad.Name} no puede ser menor a 0");
                    continue;
                }
                
                // Validacion para tipos no contemplados
                if(valorPropiedad == null)
                {
                    throw new ArgumentException($"{propiedad.Name} es obligatorio.");
                }
            }
        }

        public static void validarSoloNumeros(object? sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, un punto decimal y teclas de control (como retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignorar el carácter si no es válido
            }
            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox)?.Text.Contains('.') == true)
            {
                e.Handled = true; // Ignorar el carácter si ya hay un punto
            }
        }

        public static bool EsCantidadMenorAlTope(decimal cantidadTope, decimal cantidadAComparar) => cantidadAComparar <= cantidadTope;
        public static bool ValidarTamanoPermitido(string texto, int tamanoMaximo) => texto.Length >= 5 && texto.Length <= tamanoMaximo;
        public static bool ValidarTamanoPermitido(string texto, int tamanoMaximo, int tamanoMinimo) => texto.Length >= 5 && texto.Length <= tamanoMaximo;
    }
}