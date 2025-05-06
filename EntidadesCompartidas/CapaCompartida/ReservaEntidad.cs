/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaCompartida
{
    public class ReservaEntidad
    {
        //Constructores

        public ReservaEntidad(int Id, VideojuegosXTiendaEntidad existencia, ClienteEntidad cliente, DateTime? fechaReserva, int cantidad)
        {
            this.Id = Id;
            this.existencia = existencia;
            this.cliente = cliente;
            this.fechaReserva = fechaReserva;
            this.cantidad = cantidad;
        }

        public ReservaEntidad()
        {
            Id = 0;
            existencia = null;
            cliente = null;
            fechaReserva = null;
            cantidad = 0;
        }

        //Sets y gets
        public int Id { get; set; }
        public VideojuegosXTiendaEntidad existencia { get; set; }
        public ClienteEntidad cliente { get; set; }
        public DateTime? fechaReserva { get; set; }
        public int cantidad { get; set; }

        public override string ToString()
        {
            return existencia.Tienda.Id.ToString() + ";" + existencia.Videojuego.Id.ToString() + ";" + cliente.Identificacion.ToString() + ";" + fechaReserva.ToString() + ";" + cantidad.ToString();
        }
    }
}