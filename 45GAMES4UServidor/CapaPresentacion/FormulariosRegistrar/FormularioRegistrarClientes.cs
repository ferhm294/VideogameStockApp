/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using CapaAccesoDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormularioRegistrarClientes : Form
    {
        private FormularioPrincipal formularioPrincipal;
        public FormularioRegistrarClientes(FormularioPrincipal formularioPrincipal)
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

        private void btGuardar_Click(object sender, EventArgs e)
        {
            ClienteAcceso ClienteAD = new ClienteAcceso();
            if (CamposRequeridosCompletos())
            {
                try
                {
                    int identificacion = int.Parse(tbIdentificacion.Text.Trim());
                    DateTime fechaNacimiento = dtPFechaNacimiento.Value;
                    bool jugadorEnLinea = cbJugadorEnLinea.SelectedItem.ToString() == "Sí";

                    if (ClienteServicio.ValidarId(identificacion))
                    {
                        bool exito = ClienteAD.AgregarCliente(
                            jugadorEnLinea,
                            identificacion,
                            tbNombre.Text.Trim(),
                            tbPrimerApellido.Text.Trim(),
                            tbSegundoApellido.Text.Trim(),
                            fechaNacimiento
                        );

                        if (exito)
                        {
                            MessageBox.Show("¡Cliente agregado con éxito!");
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("¡No se pudo agregar el cliente, verifique los datos!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("¡El ID ya se encuentra en uso!");
                    }
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
        }

        private bool CamposRequeridosCompletos()
        {
            return !string.IsNullOrWhiteSpace(tbIdentificacion.Text) &&
                   !string.IsNullOrWhiteSpace(tbNombre.Text) &&
                   !string.IsNullOrWhiteSpace(tbPrimerApellido.Text) &&
                   !string.IsNullOrWhiteSpace(tbSegundoApellido.Text) &&
                   dtPFechaNacimiento.Value != null &&
                   cbJugadorEnLinea.SelectedItem != null;
        }

        private void LimpiarCampos()
        {
            tbIdentificacion.Clear();
            tbNombre.Clear();
            tbPrimerApellido.Clear();
            tbSegundoApellido.Clear();
            dtPFechaNacimiento.Value = DateTime.Today;
            cbJugadorEnLinea.SelectedItem = null;
        }

    }
}