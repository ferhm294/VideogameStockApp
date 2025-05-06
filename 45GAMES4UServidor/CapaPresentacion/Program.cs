/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
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
            // Nombre único para el Mutex en el ámbito global
            const string mutexName = @"Global\CapaPresentacion";

            // Intentar crear el Mutex
            using (Mutex mutex = new Mutex(false, mutexName, out bool createdNew))
            {
                if (!createdNew)
                {
                    MessageBox.Show("La aplicación ya está en ejecución.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Finalizar la aplicación
                }

                // Evitar que el Mutex sea liberado inmediatamente
                GC.KeepAlive(mutex);

                ApplicationConfiguration.Initialize();
                Application.Run(new FormularioPrincipal());
            }
        }
    }
}