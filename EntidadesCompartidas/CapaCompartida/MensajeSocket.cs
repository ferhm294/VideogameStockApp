/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaCompartida
{
    // Este namespace contiene la clase MensajeSocket, que se utiliza para enviar mensajes a través de un socket TCP.
    public class MensajeSocket<T>
    {
        // Se usa para indicar el método a ejecutar
        public string Metodo { get; set; }

        // Se usa para indicar el tipo de entidad a la que se le aplicará el método
        public T Entidad { get; set; }
    }
}