/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaCompartida
{
    public class ClienteEntidad : PersonaEntidad
    {

        //Constructores
        public ClienteEntidad() : base()
        {
            JugadorEnLinea = true;
        }
        public ClienteEntidad(bool jugadorEnLinea, int identificacion, string nombre, string primerApellido, string segundoApellito, DateTime? fechaNacimiento) : base (identificacion, nombre, primerApellido, segundoApellito, fechaNacimiento)
        {
            JugadorEnLinea = jugadorEnLinea;
        }

        //Sets y gets
        public bool JugadorEnLinea { get; set; }        
    }
}