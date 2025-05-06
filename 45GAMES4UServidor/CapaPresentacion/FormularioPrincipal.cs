/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using CapaPresentacion.FormulariosConsultar;

namespace CapaPresentacion
{
    public partial class FormularioPrincipal : Form
    {
        private Form? formularioActual; //Esto se va a utilizar para manejar el estado actual del formulario secundario que se va a tener en el formulario principal
        private FormularioServidor? formularioServidor; //Este va a ser el formulario que mantiene el estado del servidor
        public FormularioPrincipal()
        {
            InitializeComponent();
            formularioServidor = new FormularioServidor()
            {
                MdiParent = this
            };
            formularioActual = formularioServidor;
            formularioActual.Show();

            //Evento para detener el servidor al cerrar la aplicación
            this.FormClosing += new FormClosingEventHandler(FormularioPrincipal_FormClosing);
        }
        private void RegistrarTipodeVideojuegosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio();
            formularioActual = new FormularioRegistrarTipoVideojuegos(this)
            {
                MdiParent = this
            };
            formularioActual.Show();
        }

        private void videojuegosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio();
            formularioActual = new FormularioRegistrarVideojuegos(this)
            {
                MdiParent = this
            };
            formularioActual.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio();
        }

        public void Inicio()
        {
            if (formularioActual != null && (!(formularioActual is FormularioServidor)))
            {
                formularioActual.Close();
                formularioActual = formularioServidor;
            }
        }

        private void RegistrarAdministradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio();
            formularioActual = new FormularioRegistrarAdministradores(this)
            {
                MdiParent = this
            };
            formularioActual.Show();
        }

        private void RegistrarTiendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio();
            formularioActual = new FormularioRegistrarTiendas(this)
            {
                MdiParent = this
            };
            formularioActual.Show();
        }

        private void RegistrarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio();
            formularioActual = new FormularioRegistrarInventario(this)
            {
                MdiParent = this
            };
            formularioActual.Show();
        }

        private void RegistrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio();
            formularioActual = new FormularioRegistrarClientes(this)
            {
                MdiParent = this
            };
            formularioActual.Show();
        }

        private void ConsultarTiposDeVideojuegosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio();
            formularioActual = new FormularioConsultarTipoVideojuegos()
            {
                MdiParent = this
            };
            formularioActual.Show();
        }

        private void ConsultarVideojuegosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio();
            formularioActual = new FormularioConsultarVideojuegos()
            {
                MdiParent = this
            };
            formularioActual.Show();
        }

        private void ConsultarAdmnistradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio();
            formularioActual = new FormularioConsultarAdministradores()
            {
                MdiParent = this
            };
            formularioActual.Show();
        }

        private void ConsultarTiendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio();
            formularioActual = new FormularioConsultarTiendas()
            {
                MdiParent = this
            };
            formularioActual.Show();
        }

        private void ConsultarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio();
            formularioActual = new FormularioConsultarInventario()
            {
                MdiParent = this
            };
            formularioActual.Show();
        }

        private void ConsultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio();
            formularioActual = new FormularioConsultarClientes()
            {
                MdiParent = this
            };
            formularioActual.Show();
        }

        public void FormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            formularioServidor.servidorTCP.Detener();
        }
    }
}
