/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using CapaNegocio;
using CapaCompartida;
using Newtonsoft.Json;
using CapaAccesoDatos;

namespace CapaPresentacion
{
    public partial class FormularioServidor : Form
    {
        //Propiedades requeridas
        public ServidorTCPServicio servidorTCP { get; set; }

        //Delegados necesarios para modificar la interfaz desde subprocesos
        private delegate void EscribirEnTexboxDelegado(string texto);
        private delegate void ModificarListBoxDelegado(string texto, bool agregar);

        //Declaración de delegados
        EscribirEnTexboxDelegado escribirEnTexboxDelegado;
        ModificarListBoxDelegado modificarListBoxDelegado;

        public FormularioServidor()
        {
            InitializeComponent();

            //Suscripción del evento
            servidorTCP = new ServidorTCPServicio();
            servidorTCP.MensajeRecibido += ServidorTCPServicio_MensajeRecibido;
            escribirEnTexboxDelegado = new EscribirEnTexboxDelegado(EscribirEnTexbox);
            modificarListBoxDelegado = new ModificarListBoxDelegado(ModificarListBox);

            //Configuración del formulario
            this.FormBorderStyle = FormBorderStyle.None; //Ventana sin bordes
            this.WindowState = FormWindowState.Maximized; //Ventana maximizada
            this.ControlBox = false; //Para que el formulario secundario no se vea como una ventana sino que solo se cambie el contenido del formulario principal

            //Detalles del estado del servidor al iniciar la aplicación
            lbEstadoDinamico.Text = "Desconectado";
            lbEstadoDinamico.ForeColor = Color.Red;
            btDesconectar.Enabled = false;
        }

        private void ServidorTCPServicio_MensajeRecibido(object sender, (string mensaje, StreamWriter streamWriter) e)
        {
            //Manejar el mensaje recibido
            try
            {
                var mensajeRecibido = JsonConvert.DeserializeObject<MensajeSocket<object>>(e.mensaje);
                SeleccionarMetodo(mensajeRecibido.Metodo, mensajeRecibido.Entidad, ref e.streamWriter);
            }
            catch (JsonException)
            {
                //Se maneja error de deserialización de ser necesario
                MessageBox.Show("No fue posible convertir el objeto.");
            }
            catch (Exception ex)
            {
                //Se maneja error de deserialización de ser necesario
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Método para escribir en la bitácora desde subproceso
        private void EscribirEnTexbox(string texto)
        {
            if (tbBitacora.InvokeRequired)
            {
                tbBitacora.Invoke(new Action<string>(EscribirEnTexbox), texto);
            }
            else
            {
                tbBitacora.AppendText(DateTime.Now.ToString() + " - " + texto + Environment.NewLine);
            }
        }

        //Método para modificar los usuarios conectados desde subproceso
        private void ModificarListBox(string texto, bool agregar)
        {
            if (lBClientesConectados.InvokeRequired)
            {
                lBClientesConectados.Invoke(new Action<string, bool>(ModificarListBox), texto, agregar);
            }
            else
            {
                if (agregar)
                {
                    lBClientesConectados.Items.Add(texto);
                }
                else
                {
                    lBClientesConectados.Items.Remove(texto);
                }
            }
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            //Iniciar el servidor
            servidorTCP.Iniciar();

            //Modificar la interfaz
            lbEstadoDinamico.Text = "Conectado";
            lbEstadoDinamico.ForeColor = Color.Green;
            btConectar.Enabled = false;
            btDesconectar.Enabled = true;

            //Se actualiza la bitácora
            escribirEnTexboxDelegado.Invoke("Servidor iniciado (127.0.0.1, 14100), esperando clientes...");
        }

        private void btDesconectar_Click(object sender, EventArgs e)
        {
            //Detiene el servidor
            servidorTCP.Detener();

            //Modificar la interfaz
            lbEstadoDinamico.Text = "Desconectado";
            lbEstadoDinamico.ForeColor = Color.Red;
            btConectar.Enabled = true;
            btDesconectar.Enabled = false;

            //Se actualiza la bitácora
            escribirEnTexboxDelegado.Invoke("Servidor detenido.");
        }

        public void SeleccionarMetodo(string pMetodo, object entidad, ref StreamWriter servidorStreamWriter)
        {
            switch (pMetodo)
            {
                case "Conectar":
                    ConectarCliente((string)entidad, ref servidorStreamWriter);
                    break;

                case "Desconectar":
                    DesconectarCliente((string)entidad, ref servidorStreamWriter);
                    break;

                case "ObtenerInventario":
                    ObtenerInventario((string) entidad, ref servidorStreamWriter);
                    break;

                case "Reservar":
                    Reservar((string)entidad, ref servidorStreamWriter);
                    break;

                case "ConsultaReservaCliente":
                    ConsultaReservaCliente((string)entidad, ref servidorStreamWriter);
                    break;
            }
        }

        //Método para devolver mensajes al cliente
        public void EnviarRespuesta(string respuesta, ref StreamWriter servidorStreamWriter)
        {
            try
            {
                servidorStreamWriter.WriteLine(respuesta);
                servidorStreamWriter.Flush();
            }
            catch
            {
                //Manejo de excepciones al enviar respuesta
                MessageBox.Show("No fue posible enviar datos con el stream writer.");
            }
        }

        //Método para conectar el cliente al servidor, modifica la interfaz si se conecta y contribuye a la validación en caso de que no se conecte
        public void ConectarCliente(string cliente, ref StreamWriter servidorStreamWriter)
        {
            ClienteEntidad clienteEncontrado = ClienteServicio.BuscarCliente(int.Parse(cliente));
            if (clienteEncontrado != null)
            {
                //Agregar cliente a la lista de clientes conectados
                modificarListBoxDelegado.Invoke(clienteEncontrado.Identificacion.ToString(), true);
                //Escribir en la bitácora
                escribirEnTexboxDelegado.Invoke("Cliente conectado: " + cliente);
                //Devolver la entidad al cliente
                EnviarRespuesta(JsonConvert.SerializeObject(clienteEncontrado), ref servidorStreamWriter);
            }
            else
            {
                //Se devuelve la referencia null
                EnviarRespuesta(JsonConvert.SerializeObject(clienteEncontrado), ref servidorStreamWriter);
            }
        }

        //Método para desconectar el cliente del servidor, modifica la interfaz si se desconecta
        public void DesconectarCliente(string cliente, ref StreamWriter servidorStreamWriter)
        {
            ClienteEntidad clienteEncontrado = ClienteServicio.BuscarCliente(int.Parse(cliente));
            //Agregar cliente a la lista de clientes conectados
            modificarListBoxDelegado.Invoke(clienteEncontrado.Identificacion.ToString(), false);
            //Escribir en la bitácora
            escribirEnTexboxDelegado.Invoke("Cliente desconectado: " + cliente);
        }

        //Método para enviar todo el inventario al cliente
        public void ObtenerInventario(string cliente, ref StreamWriter servidorStreamWriter)
        {
            VideojuegosXTiendaAcceso inventarioAD = new VideojuegosXTiendaAcceso();
            List <VideojuegosXTiendaEntidad> inventario = inventarioAD.ConsultaInventario();
            EnviarRespuesta(JsonConvert.SerializeObject(inventario), ref servidorStreamWriter);

            //Escribir en la bitácora
            escribirEnTexboxDelegado.Invoke("Inventario solicitado por cliente: " + cliente);
        }

        public void ConsultaReservaCliente(string cliente, ref StreamWriter servidorStreamWriter)
        {
            ReservaAcceso reservaAD = new ReservaAcceso();
            List<ReservaEntidad> reservas = reservaAD.ConsultarReservasPorCliente(int.Parse(cliente));
            EnviarRespuesta(JsonConvert.SerializeObject(reservas), ref servidorStreamWriter);

            //Escribir en la bitácora
            escribirEnTexboxDelegado.Invoke("Consulta de reservas solicitada por cliente: " + cliente);
        }

        public void Reservar(string reserva, ref StreamWriter servidorStreamWriter)
        {
            string reservaRecibida = JsonConvert.DeserializeObject<string>(JsonConvert.SerializeObject(reserva));
            ReservaAcceso reservaAD = new ReservaAcceso();
            ClienteAcceso clienteAD = new ClienteAcceso();
            VideojuegosXTiendaAcceso inventarioAD = new VideojuegosXTiendaAcceso();
            DateTime fechaReserva;

            string[] partesReserva = reservaRecibida.Split(';');
            DateTime.TryParse(partesReserva[3], out fechaReserva);
            ReservaEntidad reservaConstruida = new ReservaEntidad(0, inventarioAD.ConsultaInventario(int.Parse(partesReserva[0]), int.Parse(partesReserva[1])), clienteAD.ConsultaCliente(int.Parse(partesReserva[2])), fechaReserva, int.Parse(partesReserva[4]));
            if (reservaAD.AgregarReserva(reservaConstruida))
            {
                //Se devuelve la referencia de la reservación completada
                EnviarRespuesta(JsonConvert.SerializeObject(reservaRecibida), ref servidorStreamWriter);

                //Escribir en la bitácora
                escribirEnTexboxDelegado.Invoke("Reserva realizada por cliente: " + reservaConstruida.cliente.Identificacion);
            }
            else
            {
                //Se devuelve la referencia null
                EnviarRespuesta(JsonConvert.SerializeObject(null), ref servidorStreamWriter);

                //Escribir en la bitácora
                escribirEnTexboxDelegado.Invoke("Erro al realizar reserva por cliente: " + reservaConstruida.cliente.Identificacion);
            }
        }
    }
}