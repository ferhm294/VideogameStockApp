/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaCompartida;

namespace CapaAccesoDatos
{
    public class ClienteAcceso
    {
        //Atributos

        private string cadenaConexion;
        private static readonly object candado = new();

        //Constructor
        public ClienteAcceso()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexion45GAMES4U"].ConnectionString;
        }

        //Métodos de consulta
        public List<ClienteEntidad> ConsultaCliente()
        {
            List<ClienteEntidad> consultaCliente = new List<ClienteEntidad>();
            string instruccion = "SELECT Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, JugadorEnLinea FROM Cliente;";

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
                                consultaCliente.Add(new ClienteEntidad
                                {
                                    Identificacion = (int)lector.GetDecimal(0),
                                    Nombre = lector.GetString(1),
                                    PrimerApellido = lector.GetString(2),
                                    SegundoApellido = lector.GetString(3),
                                    FechaNacimiento = lector.GetDateTime(4),
                                    JugadorEnLinea = lector.GetBoolean(5)
                                });
                            }
                        }
                    }
                }
            }
            return consultaCliente;
        }

        public ClienteEntidad ConsultaCliente(int idCliente)
        {
            List<ClienteEntidad> consultaCliente = ConsultaCliente();

            //Buscar el cliente por su ID
            foreach (ClienteEntidad cliente in consultaCliente)
            {
                if (cliente.Identificacion == idCliente)
                {
                    return cliente;
                }
            }
            return null;
        }

        //Métodos de inserción
        public bool AgregarCliente(bool jugadorEnLinea, int identificacion, string nombre, string primerApellido, string segundoApellito, DateTime? fechaNacimiento)
        {
            ClienteEntidad cliente = new ClienteEntidad(jugadorEnLinea, identificacion, nombre, primerApellido, segundoApellito, fechaNacimiento);
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string instruccion;
            int indicador = 0;

            conexion = new SqlConnection(cadenaConexion);
            instruccion = "Insert Into Cliente (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, JugadorEnLinea)" +
                          "values (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @JugadorEnLinea)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = instruccion;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
            comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@PrimerApellido", cliente.PrimerApellido);
            comando.Parameters.AddWithValue("@SegundoApellido", cliente.SegundoApellido);
            comando.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
            comando.Parameters.AddWithValue("@JugadorEnLinea", cliente.JugadorEnLinea);

            lock (candado)
            {
                conexion.Open();
                indicador = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return indicador != 0;
        }
    }
}
