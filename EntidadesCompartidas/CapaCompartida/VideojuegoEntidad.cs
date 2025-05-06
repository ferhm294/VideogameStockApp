/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaCompartida
{
    public class VideojuegoEntidad
    {

        //Constructores
        public VideojuegoEntidad()
        {
            Id = 0;
            Nombre = "";
            TipoVideojuego = null;
            Desarrollador = "";
            Lanzamiento = 0;
            Fisico = true;
        }
        public VideojuegoEntidad(int id, string nombre, TipoVideojuegoEntidad? tipoVideojuego, string desarrollador, int lanzamiento, bool fisico)
        {
            Id = id;
            Nombre = nombre;
            TipoVideojuego = tipoVideojuego;
            Desarrollador = desarrollador;
            Lanzamiento = lanzamiento;
            Fisico = fisico;
        }

        //Sets y gets
        public int Id { get; set; }
        public string Nombre { get; set; }
        public TipoVideojuegoEntidad? TipoVideojuego { get; set; }
        //Se crea con el ? para poder usar el constructor sin parámetros y asignarle null en caso de ser necesario
        public string Desarrollador { get; set; }
        public int Lanzamiento { get; set; }
        public bool Fisico { get; set; }
    }
}