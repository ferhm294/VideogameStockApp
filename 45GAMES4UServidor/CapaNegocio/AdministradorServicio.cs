/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using CapaCompartida;
using CapaAccesoDatos;

namespace CapaNegocio
{
    public class AdministradorServicio
    {
        public static bool ValidarId (int Id)
        //Este método va a validar el Id que el usuario quiere utilizar, devuelve true si está disponible
        {
            AdministradorAcceso administradorAD = new AdministradorAcceso();
            foreach (AdministradorEntidad Administrador in administradorAD.ConsultaAdministrador())
            {
                if (Administrador != null)
                {
                    if (Administrador.Identificacion == Id)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool MayorDeEdad (DateTime fechaElegida)
        //Este método va a devolver true si es mayor de edad, sino devuelve false
        {
            int edad = DateTime.Today.Year - fechaElegida.Year; //Se calcula la edad asumiendo que ya pasó el cumpleaños
            if (DateTime.Today < fechaElegida.AddYears(edad)) //Se valida si ya pasó el cumpleaños, si no se le resta un año a la edad
            {
                edad--;
            }
            return (edad >= 18); //Solo devuelve true si es mayor o igual a 18 (mayor de edad)
        }
    }
}