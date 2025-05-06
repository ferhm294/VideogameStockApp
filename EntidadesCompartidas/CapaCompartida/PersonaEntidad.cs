/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaCompartida
{
    public class PersonaEntidad
    {

        //Constructores
        public PersonaEntidad()
        {
            Identificacion = 0;
            Nombre = "";
            PrimerApellido = "";
            SegundoApellido = "";
            FechaNacimiento = null;
        }
        public PersonaEntidad(int identificacion, string nombre, string primerApellido, string segundoApellito, DateTime? fechaNacimiento)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellito;
            FechaNacimiento = fechaNacimiento;
        }
        
        //Sets y gets
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime? FechaNacimiento { get; set; } 
        /**Se utiliza DateTime? para permitir valores nulos en caso de ser necesario
         * La validación de la fecha se va a realizar en la capa de negocio
         */
    }
}