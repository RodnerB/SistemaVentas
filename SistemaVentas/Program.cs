using System;
using System.Windows.Forms;

namespace SistemaVentas
{
    internal static class Program
    {
        /// <summary>
        ///  Punto de entrada principal de la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configuración para que la app se vea bien en pantallas con DPI distinto de 100%
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            // Activar estilos visuales modernos para los controles
            Application.EnableVisualStyles();

            // Configuración de compatibilidad para renderizado de texto
            Application.SetCompatibleTextRenderingDefault(false);

            // Ejecutar el formulario principal
            Application.Run(new MenuPrincipal());
        }
    }
}