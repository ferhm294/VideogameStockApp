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
    public partial class FormularioRegistrarVideojuegos : Form
    {
        private FormularioPrincipal formularioPrincipal;
        public FormularioRegistrarVideojuegos(FormularioPrincipal formularioPrincipal)
        {
            this.FormBorderStyle = FormBorderStyle.None; //Ventana sin bordes
            this.WindowState = FormWindowState.Maximized; //Ventana maximizada
            this.ControlBox = false; //Para que el formulario secundario no se vea como una ventana sino que solo se cambie el contenido del formulario principal
            this.formularioPrincipal = formularioPrincipal;
            TipoVideojuegoAcceso tipoVideojuegoAD = new TipoVideojuegoAcceso();
            ArrayList TiposVideojuegosItems = tipoVideojuegoAD.TiposVideojuegosComboBox();
            if (TiposVideojuegosItems.Count == 0)
            {
                MessageBox.Show("¡No hay tipos de videojuegos registrados, registre al menos uno!");
            }
            else
            {
                InitializeComponent();
                foreach (String elemento in TiposVideojuegosItems)
                {
                    cbTipoVideojuego.Items.Add(elemento);
                }
            }
        }

        private void btCancelar_Click_1(object sender, EventArgs e)
        {
            formularioPrincipal.Inicio();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            int IntID, IntLanzamiento;
            bool fisico;
            TipoVideojuegoEntidad? tipoVideojuego;
            TipoVideojuegoAcceso tipoVideojuegoAD = new TipoVideojuegoAcceso();

            if (CamposRequeridosCompletos())
            {
                try
                {
                    IntLanzamiento = int.Parse(tbLanzamiento.Text.Trim());

                    fisico = cbFisico.SelectedItem.ToString() == "Físico";
                    tipoVideojuego = tipoVideojuegoAD.EncontrarTipoVideojuego(cbTipoVideojuego.SelectedItem.ToString());

                    VideojuegoAcceso videojuegoAD = new VideojuegoAcceso();
                    videojuegoAD.AgregarVideojuego(tbNombre.Text, tipoVideojuego, tbDesarrollador.Text, IntLanzamiento, fisico);
                    MessageBox.Show("¡Juego agregado con éxito!");

                    LimpiarCampos();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("¡ID y Lanzamiento solamente pueden contener números enteros!");
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("¡Todos los campos son requeridos!");
            }
        }

        private bool CamposRequeridosCompletos()
        {
            return !string.IsNullOrWhiteSpace(tbNombre.Text) &&
                   !string.IsNullOrWhiteSpace(tbDesarrollador.Text) &&
                   !string.IsNullOrWhiteSpace(tbLanzamiento.Text) &&
                   cbTipoVideojuego.SelectedItem != null &&
                   cbFisico.SelectedItem != null;
        }

        private void LimpiarCampos()
        {
            tbNombre.Clear();
            tbDesarrollador.Clear();
            tbLanzamiento.Clear();
            cbTipoVideojuego.SelectedItem = null;
            cbFisico.SelectedItem = null;
        }

    }
}