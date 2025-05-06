/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using CapaNegocio;
using CapaCompartida;

namespace CapaPresentacion
{
    public partial class FormularioConectar : Form
    {
        private FormularioPrincipal formularioPrincipal;
        public FormularioConectar(FormularioPrincipal formularioPrincipal)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //Ventana sin bordes
            this.WindowState = FormWindowState.Maximized; //Ventana maximizada
            this.ControlBox = false; //Para que el formulario secundario no se vea como una ventana sino que solo se cambie el contenido del formulario principal
            this.formularioPrincipal = formularioPrincipal;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            formularioPrincipal.Inicio();
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            ClienteEntidad cliente = new ClienteEntidad();
            if (CamposRequeridosCompletos())
            {
                try
                {
                    int identificacion = int.Parse(tbIdentificacion.Text.Trim());
                    cliente = ClienteTCP.Conectar(tbIdentificacion.Text.Trim());
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("¡La identificación debe contener solamente números enteros!");
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("¡No deje campos vacíos!");
            }
            if (cliente == null)
            {
                MessageBox.Show("¡No se pudo conectar al servidor!");
                return;
            } else
            {
                formularioPrincipal.estadoConectado(cliente);
                formularioPrincipal.clienteActual = cliente;
                formularioPrincipal.Inicio();
            }
        }

        private bool CamposRequeridosCompletos()
        {
            return !string.IsNullOrWhiteSpace(tbIdentificacion.Text);
        }
    }
}