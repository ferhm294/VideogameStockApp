/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using System.Collections;
using CapaAccesoDatos;
using CapaCompartida;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormularioRegistrarInventario : Form
    {
        private FormularioPrincipal formularioPrincipal;
        public FormularioRegistrarInventario(FormularioPrincipal formularioPrincipal)
        {
            this.FormBorderStyle = FormBorderStyle.None; //Ventana sin bordes
            this.WindowState = FormWindowState.Maximized; //Ventana maximizada
            this.ControlBox = false; //Para que el formulario secundario no se vea como una ventana sino que solo se cambie el contenido del formulario principal
            this.formularioPrincipal = formularioPrincipal;
            // Obtener tiendas activas
            TiendaAcceso tiendaAD = new TiendaAcceso();
            ArrayList TiendasActivasItems = tiendaAD.TiendasActivasComboBox();
            if (TiendasActivasItems.Count == 0)
            {
                MessageBox.Show("¡No hay tiendas activas registradas, registre al menos una!");
                return;
            }

            // Obtener videojuegos físicos
            VideojuegoAcceso videojuegoAD = new VideojuegoAcceso();
            List<VideojuegoEntidad> VideojuegosFisicos = videojuegoAD.ObtenerJuegosFisicos();
            if (VideojuegosFisicos.Count == 0)
            {
                MessageBox.Show("¡No hay videojuegos físicos registrados, registre al menos uno!");
                return;
            }

            // Solo ejecutar InitializeComponent si hay tiendas activas y videojuegos físicos
            InitializeComponent();

            // Cargar tiendas activas en ComboBox
            foreach (string tienda in TiendasActivasItems)
            {
                cbTienda.Items.Add(tienda);
            }

            // Configurar DataGridView
            dgVVideojuegosFisicos.Columns.Add("ID", "ID");
            dgVVideojuegosFisicos.Columns.Add("Nombre", "Nombre");
            dgVVideojuegosFisicos.Columns.Add("TipoVideojuego", "Tipo de Videojuego");
            dgVVideojuegosFisicos.Columns.Add("Desarrollador", "Desarrollador");
            dgVVideojuegosFisicos.Columns.Add("Lanzamiento", "Año de Lanzamiento");

            // Cargar videojuegos físicos en DataGridView
            foreach (VideojuegoEntidad juego in VideojuegosFisicos)
            {
                //El siguiente String se utiliza para agregar solamente el nombre del tipo de videojuego y no todo el objeto, se agrega una pequeña validación
                string tipoVideojuegoNombre = juego.TipoVideojuego != null ? juego.TipoVideojuego.Nombre : "N/A"; // condición ? valor_si_verdadero : valor_si_falso;
                dgVVideojuegosFisicos.Rows.Add(juego.Id, juego.Nombre, tipoVideojuegoNombre, juego.Desarrollador, juego.Lanzamiento);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            formularioPrincipal.Inicio();
        }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (CamposRequeridosCompletos())
            {
                try
                {
                    // Obtener datos de los controles
                    TiendaAcceso tiendaAD = new TiendaAcceso();
                    TiendaEntidad? tienda = tiendaAD.EncontrarTiendaActiva(cbTienda.SelectedItem.ToString());
                    VideojuegoAcceso videojuegoAD = new VideojuegoAcceso();
                    List<VideojuegoEntidad> videojuegos = new List<VideojuegoEntidad>();
                    int existencias = int.Parse(tbExistencias.Text.Trim());
                    VideojuegosXTiendaAcceso inventarioAD = new VideojuegosXTiendaAcceso();

                    foreach (DataGridViewRow fila in dgVVideojuegosFisicos.SelectedRows)
                    {
                        videojuegos.Add(videojuegoAD.EncontrarVideojuego(Convert.ToInt32(fila.Cells[0].Value)));
                    }

                    bool alMenosUnoGuardado = false;

                    if (tienda != null && videojuegos.Count > 0 && existencias > 0)
                    {
                        foreach (VideojuegoEntidad videojuego in videojuegos)
                        {
                            // Validar registro único para cada videojuego
                            if (!VideojuegosXTiendaServicio.ValidarRegistroUnico(tienda, videojuego))
                            {
                                MessageBox.Show($"¡El videojuego '{videojuego.Nombre}' ya se encuentra en el inventario!");
                                continue;
                            }

                            // Intentar agregar al inventario
                            bool exito = inventarioAD.AgregarInventario(tienda, videojuego, existencias);

                            if (exito)
                            {
                                MessageBox.Show($"¡Inventario agregado con éxito para el videojuego '{videojuego.Nombre}'!");
                                alMenosUnoGuardado = true;
                            }
                            else
                            {
                                MessageBox.Show($"¡No se pudo agregar el inventario para el videojuego '{videojuego.Nombre}'! El registro ya se encuentra en el inventario.");
                            }
                        }

                        // Limpiar campos si al menos uno fue exitoso
                        if (alMenosUnoGuardado)
                        {
                            LimpiarCampos();
                        }
                    }
                    else
                    {
                        if (tienda == null)
                        {
                            MessageBox.Show("¡La tienda seleccionada no es válida!");
                        }
                        if (videojuegos.Count <= 0)
                        {
                            MessageBox.Show("¡Debe seleccionar al menos un videojuego!");
                        }
                        if (existencias <= 0)
                        {
                            MessageBox.Show("¡Las existencias deben ser mayores a cero!");
                        }
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("¡Las existencias deben contener solamente números enteros!");
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
            return cbTienda.SelectedItem != null &&
                   !string.IsNullOrWhiteSpace(tbExistencias.Text) &&
                   dgVVideojuegosFisicos.SelectedRows != null;
        }

        private void LimpiarCampos()
        {
            cbTienda.SelectedItem = null;
            tbExistencias.Clear();
            if (dgVVideojuegosFisicos.SelectedRows != null)
            {
                foreach (DataGridViewRow fila in dgVVideojuegosFisicos.SelectedRows)
                {
                    fila.Selected = false;
                }
            }
        }
    }
}