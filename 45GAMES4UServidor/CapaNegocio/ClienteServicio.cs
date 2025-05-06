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
    public class ClienteServicio
    {
        //Este método va a validar el Id que el usuario quiere utilizar, devuelve true si está disponible
        public static bool ValidarId(int Id)
        {
            ClienteAcceso ClienteAD = new ClienteAcceso();
            List <ClienteEntidad> clientes = ClienteAD.ConsultaCliente();
            foreach (ClienteEntidad Cliente in clientes)
            {
                if (Cliente == null)
                {
                    return true;
                }
                else if (Cliente.Identificacion == Id)
                {
                    return false;
                }
            }
            return true;
        }

        //Método para buscar cliente, devuelve null si no lo encuentra
        public static ClienteEntidad BuscarCliente(int Id)
        {
            ClienteAcceso ClienteAD = new ClienteAcceso();
            List<ClienteEntidad> clientes = ClienteAD.ConsultaCliente();
            foreach (ClienteEntidad cliente in clientes)
            {
                if (cliente.Identificacion == Id)
                {
                    return cliente;
                }
            }
            return null;
        }
    }
}