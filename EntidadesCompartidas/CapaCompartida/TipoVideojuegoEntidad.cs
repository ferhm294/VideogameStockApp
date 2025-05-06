/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaCompartida
{
    public class TipoVideojuegoEntidad
    {

        //Constructores
        public TipoVideojuegoEntidad()
        {
            Id = 0;
            Nombre = "";
            Descripcion = "";
        }
        public TipoVideojuegoEntidad(int id, string nombre, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        //Sets y gets
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}