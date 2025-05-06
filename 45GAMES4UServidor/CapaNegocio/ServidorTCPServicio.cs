/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using System.Net.Sockets;

namespace CapaNegocio
{
    public class ServidorTCPServicio
    {
        private TcpListener tcpListener;
        private bool servidorIniciado;

        //Delegado genérico predefinido que se utiliza comúnmente para manejar eventos
        public event EventHandler<(string mensaje, StreamWriter streamWriter)> MensajeRecibido;

        //Semáforo para poder aceptar máximo 5 clientes simultáneos
        private static Semaphore semaforo = new Semaphore(5, 5);

        public ServidorTCPServicio()
        {
            //Configurar la comunicación TCP
            var local = System.Net.IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(local, 14100);
            servidorIniciado = false;
        }

        public void Iniciar()
        {
            servidorIniciado = true;
            tcpListener.Start();

            //Iniciar un hilo para escuchar clientes
            var subprocesoEscuchaClientes = new Thread(EscucharClientes);
            subprocesoEscuchaClientes.IsBackground = true;
            subprocesoEscuchaClientes.Start();
        }

        public void Detener()
        {
            servidorIniciado = false;
            tcpListener.Stop();
        }

        public void EscucharClientes()
        {
            while (servidorIniciado)
            {
                try
                {
                    var cliente = tcpListener.AcceptTcpClient();
                    var clienteThread = new Thread(ComunicacionCliente);
                    clienteThread.Start(cliente);
                }
                catch (SocketException)
                {
                    // SocketException se lanza cuando se detiene el servidor, no es necesario manejarlo
                }
            }
        }
        public void ComunicacionCliente(object cliente)
        {
            var tcpCliente = (TcpClient)cliente;

            // Intentar adquirir un permiso del semáforo
            semaforo.WaitOne();

            try
            {
                var stream = tcpCliente.GetStream();
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream);

                while (servidorIniciado)
                {
                    try
                    {
                        // Leer el mensaje del cliente
                        var mensaje = reader.ReadLine();
                        if (mensaje == null) break;

                        // Disparar el evento MensajeRecibido
                        MensajeRecibido?.Invoke(this, (mensaje, writer));
                    }
                    catch (IOException)
                    {
                        // IOException se lanza cuando el cliente se desconecta, no es necesario manejarlo
                        break;
                    }
                }

                // Cerrar la conexión con el cliente
                tcpCliente.Close();
            }
            finally
            {
                // Liberar el permiso del semáforo para permitir la entrada de otro cliente
                semaforo.Release();
            }
        }
    }
}