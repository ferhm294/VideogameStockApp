/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using CapaCompartida;

namespace CapaAccesoDatos
{
    public class VideojuegoAcceso
    {
        //Atributos
        private string cadenaConexion;
        private static readonly object candado = new();

        //Constructor
        public VideojuegoAcceso()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexion45GAMES4U"].ConnectionString;
        }

        //Consultas
        public List<VideojuegoEntidad> ObtenerJuegosFisicos()
        {
            List<VideojuegoEntidad> juegosFisicos = new List<VideojuegoEntidad>();
            foreach (VideojuegoEntidad juego in ConsultaVideojuego())
            {
                if (juego != null)
                {
                    if (juego.Fisico)
                    {
                        juegosFisicos.Add(juego);
                    }
                }
            }
            return juegosFisicos;
        }

        public VideojuegoEntidad? EncontrarVideojuego(int id)
        {
            foreach (VideojuegoEntidad videojuego in ConsultaVideojuego())
            {
                if (videojuego != null)
                {
                    if (videojuego.Id == id)
                    {
                        return videojuego;
                    }
                }
            }
            return null;
        }
        public List<VideojuegoEntidad> ConsultaVideojuego()
        {
            List<VideojuegoEntidad> consultaVideojuego = new List<VideojuegoEntidad>();
            string instruccion = "SELECT Id, Nombre, Id_TipoVideojuego, Desarrollador, Lanzamiento, Fisico FROM Videojuego;";
            TipoVideojuegoAcceso tipoVideojuegoAD = new TipoVideojuegoAcceso();

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
                                consultaVideojuego.Add(new VideojuegoEntidad
                                {
                                    Id = (int)lector.GetDecimal(0),
                                    Nombre = lector.GetString(1),
                                    TipoVideojuego = tipoVideojuegoAD.EncontrarTipoVideojuego((int)lector.GetDecimal(2)),
                                    Desarrollador = lector.GetString(3),
                                    Lanzamiento = (int)lector.GetDecimal(4),
                                    Fisico = lector.GetBoolean(5)
                                });
                            }
                        }
                    }
                }
            }
            return consultaVideojuego;
        }

        //Métodos de inserción
        public bool AgregarVideojuego(string nombre, TipoVideojuegoEntidad? tipoVideojuego, string desarrollador, int lanzamiento, bool fisico)
        {
            VideojuegoEntidad videojuego = new VideojuegoEntidad(0, nombre, tipoVideojuego, desarrollador, lanzamiento, fisico);
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string instruccion;
            int indicador = 0;

            conexion = new SqlConnection(cadenaConexion);
            instruccion = "Insert Into Videojuego (nombre, Id_TipoVideojuego, desarrollador, lanzamiento, fisico)" +
                          "Values (@Nombre, @Id_TipoVideojuego, @Desarrollador, @Lanzamiento, @Fisico)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = instruccion;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@Nombre", videojuego.Nombre);
            comando.Parameters.AddWithValue("@Id_TipoVideojuego", videojuego.TipoVideojuego.Id);
            comando.Parameters.AddWithValue("@Desarrollador", videojuego.Desarrollador);
            comando.Parameters.AddWithValue("@Lanzamiento", videojuego.Lanzamiento);
            comando.Parameters.AddWithValue("@Fisico", videojuego.Fisico);

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