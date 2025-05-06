/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using CapaCompartida;

namespace CapaAccesoDatos

{
    public class TipoVideojuegoAcceso
    {
        //Atributos
        private string cadenaConexion;
        private static readonly object candado = new();

        //Constructor
        public TipoVideojuegoAcceso()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexion45GAMES4U"].ConnectionString;
        }

        //Consultas
        public ArrayList TiposVideojuegosComboBox()
        {
            ArrayList cadena = new ArrayList();
            foreach (TipoVideojuegoEntidad TipoVideojuego in ConsultaTipoVideojuego())
            {
                if (TipoVideojuego != null)
                {
                    cadena.Add(TipoVideojuego.Nombre);
                }
            }
            return cadena;
        }
        public TipoVideojuegoEntidad? EncontrarTipoVideojuego(string nombre)
        {
            foreach (TipoVideojuegoEntidad TipoVideojuego in ConsultaTipoVideojuego())
            {
                if (TipoVideojuego.Nombre == nombre)
                    return TipoVideojuego;
            }
            return null;
        }

        public TipoVideojuegoEntidad? EncontrarTipoVideojuego(int id)
        {
            foreach (TipoVideojuegoEntidad TipoVideojuego in ConsultaTipoVideojuego())
            {
                if (TipoVideojuego.Id == id)
                    return TipoVideojuego;
            }
            return null;
        }
        public List<TipoVideojuegoEntidad> ConsultaTipoVideojuego()
        {
            List <TipoVideojuegoEntidad> consultaTipoVideojuego = new List<TipoVideojuegoEntidad>();
            string instruccion = "SELECT Id, Nombre, Descripcion FROM TipoVideojuego;";

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
                                consultaTipoVideojuego.Add(new TipoVideojuegoEntidad
                                {
                                    Id = (int)lector.GetDecimal(0),
                                    Nombre = lector.GetString(1),
                                    Descripcion = lector.GetString(2),
                                });
                            }
                        }
                    }
                }
            }
            return consultaTipoVideojuego;
        }

        //Métodos de inserción
        public bool AgregarTipoVideojuego(string nombre, string descripcion)
        {
            TipoVideojuegoEntidad tipoVideojuego = new TipoVideojuegoEntidad(0, nombre, descripcion);
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string instruccion;
            int indicador = 0;

            conexion = new SqlConnection(cadenaConexion);
            instruccion = "Insert Into TipoVideojuego (Nombre, Descripcion)" +
                          "Values (@Nombre, @Descripcion)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = instruccion;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@Nombre", tipoVideojuego.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", tipoVideojuego.Descripcion);

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
