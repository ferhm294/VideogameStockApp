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
    public class TiendaAcceso
    {
        //Atributos
        private string cadenaConexion;
        private static readonly object candado = new();

        //Constructor
        public TiendaAcceso()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexion45GAMES4U"].ConnectionString;
        }

        //Consultas
        public ArrayList TiendasActivasComboBox()
        {
            ArrayList cadena = new ArrayList();
            foreach (TiendaEntidad tienda in ConsultaTienda())
            {
                if (tienda != null && tienda.Activa)
                {
                    cadena.Add(tienda.Nombre);
                }
            }
            return cadena;
        }

        public TiendaEntidad? EncontrarTiendaActiva(string nombre)
        {
            foreach (TiendaEntidad tienda in ConsultaTienda())
            {
                if (tienda != null)
                {
                    if (tienda.Nombre == nombre)
                    {
                        return tienda;
                    }
                }
                
            }
            return null;
        }
        public TiendaEntidad? EncontrarTiendaActiva(int id)
        {
            foreach (TiendaEntidad tienda in ConsultaTienda())
            {
                if (tienda != null)
                {
                    if (tienda.Id == id)
                    {
                        return tienda;
                    }
                }

            }
            return null;
        }
        public List<TiendaEntidad> ConsultaTienda()
        {
            List<TiendaEntidad> consultaTienda = new List<TiendaEntidad>();
            string instruccion = "SELECT Id, Nombre, Id_Administrador, Direccion, Telefono, Activa FROM Tienda;";
            AdministradorAcceso administradorAD = new AdministradorAcceso();

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
                                consultaTienda.Add(new TiendaEntidad
                                {
                                    Id = (int)lector.GetDecimal(0),
                                    Nombre = lector.GetString(1),
                                    Administrador = administradorAD.EncontrarAdministrador((int)lector.GetDecimal(2)),
                                    Direccion = lector.GetString(3),
                                    Telefono = lector.GetString(4),
                                    Activa = lector.GetBoolean(5)
                                });
                            }
                        }
                    }
                }
            }
            return consultaTienda;
        }

        //Métodos de inserción
        public bool AgregarTienda(string nombre, AdministradorEntidad? administrador, string direccion, string telefono, bool activa)
        {
            TiendaEntidad tienda = new TiendaEntidad(0, nombre, administrador, direccion, telefono, activa);
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string instruccion;
            int indicador = 0;

            conexion = new SqlConnection(cadenaConexion);
            instruccion = "Insert Into Tienda (nombre, Id_Administrador, Direccion, Telefono, Activa)" +
                          "Values (@Nombre, @Id_Administrador, @Direccion, @Telefono, @Activa)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = instruccion;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@Nombre", tienda.Nombre);
            comando.Parameters.AddWithValue("@Id_Administrador", tienda.Administrador.Identificacion);
            comando.Parameters.AddWithValue("@Direccion", tienda.Direccion);
            comando.Parameters.AddWithValue("@Telefono", tienda.Telefono);
            comando.Parameters.AddWithValue("@Activa", tienda.Activa);

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