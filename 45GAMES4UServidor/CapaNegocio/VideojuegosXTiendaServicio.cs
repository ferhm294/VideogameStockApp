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
    public class VideojuegosXTiendaServicio
    {
        public static bool ValidarRegistroUnico (TiendaEntidad Tienda, VideojuegoEntidad Videojuego)
        //Método para validar que el registro (combinación Tienda-Videojuego) en el inventario sea único
        {
            VideojuegosXTiendaAcceso inventarioAD = new VideojuegosXTiendaAcceso();
            foreach (VideojuegosXTiendaEntidad Registro in inventarioAD.ConsultaInventario()) //Se recorren todos los registros del inventario
            {
                if (Registro != null)
                {
                    if ((Registro.Tienda == Tienda) && (Registro.Videojuego == Videojuego)) //Si se encuentra una coincidencia Tienda-Videojuego se invalida
                    {
                        return false;
                    }
                }
            }
            return true; //Se valida si se recorre todo el inventario y no se ha registrado la combinación Tienda-Videojuego
        }
    }
}