namespace SistemaVentas.Utilidades
{
    public class Validador
    {
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