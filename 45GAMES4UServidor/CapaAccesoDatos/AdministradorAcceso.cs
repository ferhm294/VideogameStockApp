/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using CapaCompartida;

namespace CapaAccesoDatos
{

    public class AdministradorAcceso
    {
        //Atributos
        private string cadenaConexion;
        private static readonly object candado = new();

        //Constructor
        public AdministradorAcceso()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexion45GAMES4U"].ConnectionString;
        }

        //Métodos de consulta
        public ArrayList AdministradoresComboBox()
        {
            ArrayList cadena = new ArrayList();
            foreach (AdministradorEntidad administrador in ConsultaAdministrador())
            {
                if (administrador != null)
                {
                    cadena.Add(administrador.Nombre);
                }
            }
            return cadena;
        }

        public AdministradorEntidad? EncontrarAdministrador(string nombre)
        {
            foreach (AdministradorEntidad administrador in ConsultaAdministrador())
            {
                if (administrador.Nombre == nombre)
                    return administrador;
            }
            return null;
        }
        public AdministradorEntidad? EncontrarAdministrador(int identificacion)
        {
            foreach (AdministradorEntidad administrador in ConsultaAdministrador())
            {
                if (administrador.Identificacion == identificacion)
                    return administrador;
            }
            return null;
        }
        public List<AdministradorEntidad> ConsultaAdministrador()
        {
            List<AdministradorEntidad> consultaAdministrador = new List<AdministradorEntidad>();
            string instruccion = "SELECT Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, FechaContratacion FROM Administrador;";

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
                                consultaAdministrador.Add(new AdministradorEntidad
                                {
                                    Identificacion = (int)lector.GetDecimal(0),
                                    Nombre = lector.GetString(1),
                                    PrimerApellido = lector.GetString(2),
                                    SegundoApellido = lector.GetString(3),
                                    FechaNacimiento = lector.GetDateTime(4),
                                    FechaContratacion = lector.GetDateTime(5)
                                });
                            }
                        }
                    }
                }
            }
            return consultaAdministrador;
        }

        //Métodos de inserción
        public bool AgregarAdministrador(int identificacion, string nombre, string primerApellido, string segundoApellito, DateTime? fechaNacimiento, DateTime? fechaContratacion)
        {
            AdministradorEntidad administrador = new AdministradorEntidad(identificacion, nombre, primerApellido, segundoApellito, fechaNacimiento, fechaContratacion);
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string instruccion;
            int indicador = 0;

            conexion = new SqlConnection(cadenaConexion);
            instruccion = "Insert Into Administrador (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, FechaContratacion)" +
                          "values (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @FechaContratacion)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = instruccion;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@Identificacion", administrador.Identificacion);
            comando.Parameters.AddWithValue("@Nombre", administrador.Nombre);
            comando.Parameters.AddWithValue("@PrimerApellido", administrador.PrimerApellido);
            comando.Parameters.AddWithValue("@SegundoApellido", administrador.SegundoApellido);
            comando.Parameters.AddWithValue("@FechaNacimiento", administrador.FechaNacimiento);
            comando.Parameters.AddWithValue("@FechaContratacion", administrador.FechaContratacion);

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