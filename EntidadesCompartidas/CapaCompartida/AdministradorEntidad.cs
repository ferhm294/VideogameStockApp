/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaCompartida
{
    public class AdministradorEntidad : PersonaEntidad
    {

        //Constructores
        public AdministradorEntidad() : base()
        {
            FechaContratacion = null;
        }
        public AdministradorEntidad(int identificacion, string nombre, string primerApellido, string segundoApellito, DateTime? fechaNacimiento, DateTime? fechaContratacion) : base(identificacion, nombre, primerApellido, segundoApellito, fechaNacimiento)
        {
            FechaContratacion = fechaContratacion;
        }

        //Sets y gets
        public DateTime? FechaContratacion { get; set; }        
    }
}