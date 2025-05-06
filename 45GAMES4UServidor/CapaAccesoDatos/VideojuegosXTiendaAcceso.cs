/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using System.Configuration;
using CapaCompartida;
using System.Data.SqlClient;
using System.Data;

namespace CapaAccesoDatos
{
    public class VideojuegosXTiendaAcceso
    {
        //Atributos
        private string cadenaConexion;
        private static readonly object candado = new();

        //Constructor
        public VideojuegosXTiendaAcceso()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexion45GAMES4U"].ConnectionString;
        }

        //Consultas
        public List<VideojuegosXTiendaEntidad> ConsultaInventario()
        {
            List<VideojuegosXTiendaEntidad> consultaInventario = new List<VideojuegosXTiendaEntidad>();
            string instruccion = "SELECT Id_Tienda, Id_Videojuego, Existencias FROM VideojuegosXTienda;";
            TiendaAcceso tiendaAD = new TiendaAcceso();
            VideojuegoAcceso videojuegoAD = new VideojuegoAcceso();

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
                                consultaInventario.Add(new VideojuegosXTiendaEntidad()
                                {
                                    Tienda = tiendaAD.EncontrarTiendaActiva((int)lector.GetDecimal(0)),
                                    Videojuego = videojuegoAD.EncontrarVideojuego((int)lector.GetDecimal(1)),
                                    Existencias = (int)lector.GetDecimal(2)
                                });
                            }
                        }
                    }
                }
            }
            return consultaInventario;
        }

        public VideojuegosXTiendaEntidad ConsultaInventario(int idTienda, int idVideojuego)
        {
            List<VideojuegosXTiendaEntidad> consultaInventario = ConsultaInventario();

            //Recorre la lista de videojuegos por tienda
            foreach (VideojuegosXTiendaEntidad videojuego in consultaInventario)
            {
                if (videojuego != null)
                {
                    if (videojuego.Tienda.Id == idTienda && videojuego.Videojuego.Id == idVideojuego)
                    {
                        return videojuego;
                    }
                }
            }
            return null;
        }

        //Métodos de inserción
        public bool AgregarInventario(TiendaEntidad? tienda, VideojuegoEntidad? videojuego, int existencias)
        {
            VideojuegosXTiendaEntidad registro = new VideojuegosXTiendaEntidad(tienda, videojuego, existencias);
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string instruccion;
            int indicador = 0;

            conexion = new SqlConnection(cadenaConexion);
            instruccion = "Insert Into VideojuegosXTienda (Id_Tienda, Id_Videojuego, Existencias)" +
                          "Values (@Id_Tienda, @Id_Videojuego, @Existencias)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = instruccion;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@Id_Tienda", registro.Tienda.Id);
            comando.Parameters.AddWithValue("@Id_Videojuego", registro.Videojuego.Id);
            comando.Parameters.AddWithValue("@Existencias", registro.Existencias);

            lock (candado)
            {
                conexion.Open();
                try
                {
                    indicador = comando.ExecuteNonQuery();
                } catch (SqlException)
                {
                    // Registro ya se encuentra en la base de datos
                    return false;
                }
                
                conexion.Close();
            }
            return indicador != 0;
        }
    }
}