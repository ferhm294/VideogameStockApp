/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicaci�n de administraci�n de inventario para 45GAMES4U
 * Estudiante: Fernando Hern�ndez Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Nombre �nico para el Mutex en el �mbito global
            const string mutexName = @"Global\CapaPresentacion";

            // Intentar crear el Mutex
            using (Mutex mutex = new Mutex(false, mutexName, out bool createdNew))
            {
                if (!createdNew)
                {
                    MessageBox.Show("La aplicaci�n ya est� en ejecuci�n.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Finalizar la aplicaci�n
                }

                // Evitar que el Mutex sea liberado inmediatamente
                GC.KeepAlive(mutex);

                ApplicationConfiguration.Initialize();
                Application.Run(new FormularioPrincipal());
            }
        }
    }
}