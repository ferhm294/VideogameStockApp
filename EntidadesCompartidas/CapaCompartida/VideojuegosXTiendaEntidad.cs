/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaCompartida
{
    public class VideojuegosXTiendaEntidad
    {

        //Constructores
        public VideojuegosXTiendaEntidad()
        {
            Tienda = null;
            Videojuego = null;
            Existencias = 0;
        }
        public VideojuegosXTiendaEntidad(TiendaEntidad? tienda, VideojuegoEntidad? videojuego, int existencias)
        {
            Tienda = tienda;
            Videojuego = videojuego;
            Existencias = existencias;
        }

        //Sets y gets
        public TiendaEntidad? Tienda { get; set; }
        public VideojuegoEntidad? Videojuego { get; set; }
        //Se usa ? en estas dos propiedades para poder usar constructor sin parámetros y que sean null en caso de ser necesario
        public int Existencias { get; set; }
    }
}