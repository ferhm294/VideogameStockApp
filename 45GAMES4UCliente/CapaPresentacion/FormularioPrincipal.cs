/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using CapaCompartida;
using CapaNegocio;
using CapaPresentacion.FormulariosConsultar;

namespace CapaPresentacion
{
    public partial class FormularioPrincipal : Form
    {
        private Form? formularioActual; //Esto se va a utilizar para manejar el estado actual del formulario secundario que se va a tener en el formulario principal
        private ClienteTCP clienteTCP = new ClienteTCP(); //Cliente TCP para manejar la conexión con el servidor
        public ClienteEntidad clienteActual { get; set; } //Cliente actual que se va a utilizar para manejar la conexión con el servidor
        public FormularioPrincipal()
        {
            InitializeComponent();

            //Se inicia el estado del MDI como desconectado del servidor
            estadoDesconectado();

            //Evento para detener el servidor al cerrar la aplicación
            this.FormClosing += new FormClosingEventHandler(FormularioPrincipal_FormClosing);
        }

        public void Inicio()
        {
            if (formularioActual != null)
            {
                formularioActual.Close();
            }
        }

        public void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio();
        }

        public void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio();
            formularioActual = new FormularioConectar(this)
            {
                MdiParent = this
            };
            formularioActual.Show();
        }

        public void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteTCP.Desconectar(clienteActual.Identificacion.ToString());
            estadoDesconectado();
        }

        public void FormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClienteTCP.Desconectar(clienteActual.Identificacion.ToString());
        }

        public void estadoConectado(ClienteEntidad cliente)
        {
            //Se habilitan funcionalidades dependientes del cliente
            desconectarToolStripMenuItem.Enabled = true;
            reservarToolStripMenuItem.Enabled = true;
            consultasToolStripMenuItem.Enabled = true;

            //Se deshabilita la función de conectar
            conectarToolStripMenuItem.Enabled = false;

            //Se modifica el título para que aparezca el nombre del cliente
            this.Text = "45GAMES4U - " + cliente.Nombre + " " + cliente.PrimerApellido + " " + cliente.SegundoApellido;
        }

        public void estadoDesconectado()
        {
            //Se deshabilitan funcionalidades dependientes del cliente
            desconectarToolStripMenuItem.Enabled = false;
            reservarToolStripMenuItem.Enabled = false;
            consultasToolStripMenuItem.Enabled = false;

            //Se modificar el título para que se muestre sin nombre de cliente
            this.Text = "45GAMES4U - Cliente Desconectado";

            //Se habilita la función de conectar
            conectarToolStripMenuItem.Enabled = true;
        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<VideojuegosXTiendaEntidad> inventario = ClienteTCP.ObtenerInventario(clienteActual.Identificacion.ToString());
            if (inventario.Count > 0)
            {
                formularioActual = new FormularioRegistrarReserva(this, inventario)
                {
                    MdiParent = this
                };
                formularioActual.Show();
            }
            else
            {
                MessageBox.Show("¡No hay inventario disponible para reservar!");
            }
        }

        private void consultaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio();
            formularioActual = new FormularioConsultaCliente(this)
            {
                MdiParent = this
            };
            formularioActual.Show();
        }

        private void consultaPorReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio();
            formularioActual = new FormularioConsultaReservaXID(this)
            {
                MdiParent = this
            };
            formularioActual.Show();
        }
    }
}