/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using System.Collections;
using CapaAccesoDatos;
using CapaCompartida;

namespace CapaPresentacion
{
    public partial class FormularioRegistrarTiendas : Form
    {
        private FormularioPrincipal formularioPrincipal;
        public FormularioRegistrarTiendas(FormularioPrincipal formularioPrincipal)
        {
            this.FormBorderStyle = FormBorderStyle.None; //Ventana sin bordes
            this.WindowState = FormWindowState.Maximized; //Ventana maximizada
            this.ControlBox = false; //Para que el formulario secundario no se vea como una ventana sino que solo se cambie el contenido del formulario principal
            this.formularioPrincipal = formularioPrincipal;
            AdministradorAcceso administradorAD = new AdministradorAcceso();
            ArrayList AdministradoresItems = administradorAD.AdministradoresComboBox();
            if (AdministradoresItems.Count == 0)
            {
                MessageBox.Show("¡No hay administradores registrados, registre al menos uno!");
            }
            else
            {
                InitializeComponent();
                foreach (string elemento in AdministradoresItems)
                {
                    cbAdministrador.Items.Add(elemento);
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            formularioPrincipal.Inicio();
        }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            TiendaAcceso tiendaAD = new TiendaAcceso();
            if (CamposRequeridosCompletos())
            {
                try
                {
                    int telefono = int.Parse(mtbTelefono.Text.Trim());
                    bool activa = cbActiva.SelectedItem.ToString() == "Sí";
                    AdministradorAcceso administradorAD = new AdministradorAcceso();
                    AdministradorEntidad? administrador = administradorAD.EncontrarAdministrador(cbAdministrador.SelectedItem.ToString());

                    if (administrador != null)
                    {
                        bool exito = tiendaAD.AgregarTienda(
                            tbNombre.Text.Trim(),
                            administrador,
                            tbDireccion.Text.Trim(),
                            mtbTelefono.Text.Trim(),
                            activa
                        );

                        if (exito)
                        {
                            MessageBox.Show("¡Tienda agregada con éxito!");
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("¡No se pudo agregar la tienda, verifique los datos!");
                        }
                    }
                    else
                    {
                        if (administrador == null)
                        {
                            MessageBox.Show("¡El administrador seleccionado no es válido!");
                        }
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("¡La identificación y el teléfono deben contener solamente números enteros!");
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
            return !string.IsNullOrWhiteSpace(tbNombre.Text) &&
                   !string.IsNullOrWhiteSpace(tbDireccion.Text) &&
                   !string.IsNullOrWhiteSpace(mtbTelefono.Text) &&
                   cbAdministrador.SelectedItem != null &&
                   cbActiva.SelectedItem != null;
        }

        private void LimpiarCampos()
        {
            tbNombre.Clear();
            tbDireccion.Clear();
            mtbTelefono.Clear();
            cbAdministrador.SelectedItem = null;
            cbActiva.SelectedItem = null;
        }
    }
}