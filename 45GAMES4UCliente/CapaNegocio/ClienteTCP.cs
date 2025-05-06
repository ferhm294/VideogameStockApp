/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using CapaCompartida;

namespace CapaNegocio
{
    public class ClienteTCP
    {
        private static IPAddress ipServidor;
        private static TcpClient cliente;
        private static IPEndPoint serverEndPoint;
        private static StreamWriter clienteStreamWriter;
        private static StreamReader clienteStreamReader;

        private static bool EnviarRespuesta(string mensaje)
        {
            try
            {
                clienteStreamWriter.WriteLine(mensaje);
                clienteStreamWriter.Flush();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static ClienteEntidad Conectar(string pIdentificadorCliente)
        {
            ClienteEntidad clienteEntidad = new ClienteEntidad();
            clienteEntidad.Identificacion = int.Parse(pIdentificadorCliente);
            try
            {
                ipServidor = IPAddress.Parse("127.0.0.1");
                cliente = new TcpClient();
                serverEndPoint = new IPEndPoint(ipServidor, 14100);
                cliente.Connect(serverEndPoint);
                MensajeSocket<string> mensajeConectar = new MensajeSocket<string>
                {
                    Metodo = "Conectar",
                    Entidad = pIdentificadorCliente
                };

                clienteStreamReader = new StreamReader(cliente.GetStream());
                clienteStreamWriter = new StreamWriter(cliente.GetStream());
                EnviarRespuesta(JsonConvert.SerializeObject(mensajeConectar));
            }
            catch (Exception ex)
            {
                return null;
            }
            var clienteStream = clienteStreamReader.ReadLine();
            clienteEntidad = JsonConvert.DeserializeObject<ClienteEntidad>(clienteStream);
            return clienteEntidad;
        }

        public static void Desconectar(string pIdentificadorCliente)
        {
            try
            {
                MensajeSocket<string> mensajeDesconectar = new MensajeSocket<string>
                {
                    Metodo = "Desconectar",
                    Entidad = pIdentificadorCliente
                };
                EnviarRespuesta(JsonConvert.SerializeObject(mensajeDesconectar));
                cliente.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static List<VideojuegosXTiendaEntidad> ObtenerInventario(string pIdentificadorCliente)
        {
            MensajeSocket<string> mensajeObtenerInventario = new MensajeSocket<string>
            {
                Metodo = "ObtenerInventario",
                Entidad = pIdentificadorCliente
            };
            EnviarRespuesta(JsonConvert.SerializeObject(mensajeObtenerInventario));

            var mensaje = clienteStreamReader.ReadLine();
            var listaInventario = JsonConvert.DeserializeObject<List<VideojuegosXTiendaEntidad>>(mensaje);

            return listaInventario;
        }

        public static bool EnviarReserva(ReservaEntidad reserva)
        {
            MensajeSocket<string> mensajeReserva = new MensajeSocket<string>
            {
                Metodo = "Reservar",
                Entidad = reserva.ToString()
            };
            EnviarRespuesta(JsonConvert.SerializeObject(mensajeReserva));
            var respuesta = clienteStreamReader.ReadLine();
            return (JsonConvert.DeserializeObject<string>(respuesta) != null);
        }

        public static List<ReservaEntidad> ObtenerReservasCliente(string pIdentificadorCliente)
        {
            MensajeSocket<string> mensajeObtenerReservas = new MensajeSocket<string>
            {
                Metodo = "ConsultaReservaCliente",
                Entidad = pIdentificadorCliente
            };
            EnviarRespuesta(JsonConvert.SerializeObject(mensajeObtenerReservas));
            var mensaje = clienteStreamReader.ReadLine();
            var listaReservas = JsonConvert.DeserializeObject<List<ReservaEntidad>>(mensaje);
            return listaReservas;
        }
    }
}