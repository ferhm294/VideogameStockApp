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
    public class VideojuegoServicio
    {
        public static bool ValidarId (int Id)
        //Este método va a validar el Id que el usuario quiere utilizar, devuelve true si está disponible
        {
            VideojuegoAcceso videojuegoAD = new VideojuegoAcceso();
            foreach (VideojuegoEntidad Videojuego in videojuegoAD.ConsultaVideojuego())
            {
                if (Videojuego != null)
                {
                    if (Videojuego.Id == Id)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}