/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using CapaCompartida;

namespace CapaAccesoDatos
{
    public class ReservaAcceso
    {
        //Atributos
        private string cadenaConexion;
        private static readonly object candado = new();

        //Constructor
        public ReservaAcceso()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexion45GAMES4U"].ConnectionString;
        }

        //Métodos de consulta
        public List<ReservaEntidad> ConsultarReservas()
        {
            List<ReservaEntidad> consultaReservas = new List<ReservaEntidad>();
            string instruccion = "SELECT Id, Id_Tienda, Id_Videojuego, Id_Cliente, FechaReserva, Cantidad FROM Reserva;";
            VideojuegosXTiendaAcceso inventarioAD = new VideojuegosXTiendaAcceso();
            ClienteAcceso clienteAD = new ClienteAcceso();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = instruccion;
                    comando.Connection = conexion;

                    conexion.Open();

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.HasRows)
                        {
                            while (lector.Read())
                            {
                                consultaReservas.Add(new ReservaEntidad
                                {
                                    Id = (int)lector.GetDecimal(0),
                                    existencia = inventarioAD.ConsultaInventario((int)lector.GetDecimal(1), (int)lector.GetDecimal(2)),
                                    cliente = clienteAD.ConsultaCliente((int)lector.GetDecimal(3)),
                                    fechaReserva = lector.GetDateTime(4),
                                    cantidad = (int)lector.GetDecimal(5)
                                });
                            }
                        }
                    }
                }
            }
            return consultaReservas;
        }

        public ReservaEntidad ConsultarReservas(int idReserva)
        {
            List<ReservaEntidad> consultaReservas = ConsultarReservas();

            foreach (ReservaEntidad reserva in consultaReservas)
            {
                if (reserva.Id == idReserva)
                {
                    return reserva;
                }
            }
            return null;
        }

        public List<ReservaEntidad> ConsultarReservasPorCliente(int idCliente)
        {
            List<ReservaEntidad> consultaReservas = ConsultarReservas();
            List<ReservaEntidad> reservasPorCliente = new List<ReservaEntidad>();
            foreach (ReservaEntidad reserva in consultaReservas)
            {
                if (reserva.cliente.Identificacion == idCliente)
                {
                    reservasPorCliente.Add(reserva);
                }
            }
            return reservasPorCliente;
        }

        //Métodos de inserción
        public bool AgregarReserva(ReservaEntidad reserva)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            VideojuegosXTiendaAcceso inventarioAD = new VideojuegosXTiendaAcceso();

            // Con este lock garantizamos que no haya conflictos entre hilos para modificar las existencias
            lock (candado)
            {
                if (inventarioAD.ConsultaInventario(reserva.existencia.Tienda.Id, reserva.existencia.Videojuego.Id).Existencias >= reserva.cantidad)
                {
                    try
                    {
                        // Inserción en la tabla Reserva
                        string instruccionInsert = "INSERT INTO Reserva (Id_Tienda, Id_Videojuego, Id_Cliente, FechaReserva, Cantidad) " +
                                                   "VALUES (@Id_Tienda, @Id_Videojuego, @Id_Cliente, @FechaReserva, @Cantidad)";

                        using (SqlCommand comandoInsert = new SqlCommand(instruccionInsert, conexion))
                        {
                            comandoInsert.CommandType = CommandType.Text;
                            comandoInsert.Parameters.AddWithValue("@Id_Tienda", reserva.existencia.Tienda.Id);
                            comandoInsert.Parameters.AddWithValue("@Id_Videojuego", reserva.existencia.Videojuego.Id);
                            comandoInsert.Parameters.AddWithValue("@Id_Cliente", reserva.cliente.Identificacion);
                            comandoInsert.Parameters.AddWithValue("@FechaReserva", reserva.fechaReserva);
                            comandoInsert.Parameters.AddWithValue("@Cantidad", reserva.cantidad);

                            conexion.Open();
                            comandoInsert.ExecuteNonQuery();
                            conexion.Close();
                        }

                        // Actualización en la tabla VideojuegosXTienda
                        string instruccionUpdate = "UPDATE VideojuegosXTienda " +
                                                   "SET Existencias = Existencias - @Cantidad " +
                                                   "WHERE Id_Tienda = @Id_Tienda AND Id_Videojuego = @Id_Videojuego";

                        using (SqlCommand comandoUpdate = new SqlCommand(instruccionUpdate, conexion))
                        {
                            comandoUpdate.CommandType = CommandType.Text;
                            comandoUpdate.Parameters.AddWithValue("@Id_Tienda", reserva.existencia.Tienda.Id);
                            comandoUpdate.Parameters.AddWithValue("@Id_Videojuego", reserva.existencia.Videojuego.Id);
                            comandoUpdate.Parameters.AddWithValue("@Cantidad", reserva.cantidad);

                            conexion.Open();
                            comandoUpdate.ExecuteNonQuery();
                            conexion.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar errores y registrar para depuración
                        Console.WriteLine($"Error en AgregarReserva: {ex.Message}");
                        conexion.Close();
                        return false;
                    }
                }
                else
                {
                    // No hay suficientes existencias
                    return false;
                }
            }

            // Todo salió bien
            return true;
        }
    }
}