/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaCompartida
{
    public class TiendaEntidad
    {

        //Constructores
        public TiendaEntidad()
        {
            Id = 0;
            Nombre = "";
            Administrador = null;
            Direccion = "";
            Telefono = "";
            Activa = true;
        }
        public TiendaEntidad(int id, string nombre, AdministradorEntidad? administrador, string direccion, string telefono, bool activa)
        {
            Id = id;
            Nombre = nombre;
            Administrador = administrador;
            Direccion = direccion;
            Telefono = telefono;
            Activa = activa;
        }

        //Sets y gets
        public int Id { get; set; }
        public string Nombre { get; set; }
        public AdministradorEntidad? Administrador { get; set; }
        //Se crea con el ? para poder usar el constructor sin parámetros y asignarle null en caso de ser necesario
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Activa { get; set;  }
    }
}