/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using CapaCompartida;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormularioRegistrarReserva : Form
    {
        private FormularioPrincipal formularioPrincipal;
        private List<VideojuegosXTiendaEntidad> inventario;
        public FormularioRegistrarReserva(FormularioPrincipal formularioPrincipal, List<VideojuegosXTiendaEntidad> inventario)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //Ventana sin bordes
            this.WindowState = FormWindowState.Maximized; //Ventana maximizada
            this.ControlBox = false; //Para que el formulario secundario no se vea como una ventana sino que solo se cambie el contenido del formulario principal
            this.formularioPrincipal = formularioPrincipal;
            this.inventario = inventario;

            //Se crea una lista de strings con las tiendas presentes en el inventario
            List<string> tiendas = new List<string>();
            foreach (VideojuegosXTiendaEntidad videojuego in inventario)
            {
                if (!tiendas.Contains(videojuego.Tienda.Nombre))
                {
                    tiendas.Add(videojuego.Tienda.Nombre);
                }
            }

            //Se invoca al método para cargar el combobox
            cargarComboBoxTiendas(tiendas);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            formularioPrincipal.Inicio();
        }

        //Método paa cargar el combobox de tiendas
        private void cargarComboBoxTiendas(List<string> tiendas)
        {
            //Llenar el combobox de tiendas
            cbTienda.Items.Clear();
            foreach (string tienda in tiendas)
            {
                cbTienda.Items.Add(tienda);
            }
        }

        private void cbTienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se crea la lista del inventario filtrada
            string tiendaSeleccionada = cbTienda.SelectedItem.ToString();
            List<VideojuegosXTiendaEntidad> inventarioFiltrado = new List<VideojuegosXTiendaEntidad>();
            foreach (VideojuegosXTiendaEntidad videojuego in inventario)
            {
                if (videojuego.Tienda.Nombre == tiendaSeleccionada)
                {
                    inventarioFiltrado.Add(videojuego);
                }
            }

            //Se carga el datagridview con el inventario ya filtrado
            dgvExistencias.Rows.Clear();

            //Se configura el datagridview para que las conlumnas sean el nombre del videojuego, existencias en la tienda seleccionada
            dgvExistencias.Columns.Clear();
            dgvExistencias.Columns.Add("Nombre", "Nombre");
            dgvExistencias.Columns.Add("Existencias", "Existencias");


            foreach (VideojuegosXTiendaEntidad videojuego in inventarioFiltrado)
            {
                dgvExistencias.Rows.Add(videojuego.Videojuego.Nombre, videojuego.Existencias);
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            // Validar que el ComboBox tenga una selección  
            if (cbTienda.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una tienda.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que se haya seleccionado una fila en el DataGridView  
            if (dgvExistencias.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un videojuego de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Capturar la fila seleccionada  
            DataGridViewRow filaSeleccionada = dgvExistencias.CurrentRow;
            string nombreVideojuego = filaSeleccionada.Cells["Nombre"].Value.ToString();

            // Buscar el videojuego en el inventario  
            VideojuegosXTiendaEntidad existencia = inventario.FirstOrDefault(x => x.Videojuego.Nombre == nombreVideojuego && x.Tienda.Nombre == cbTienda.SelectedItem.ToString());
            if (existencia == null)
            {
                MessageBox.Show("El videojuego seleccionado no existe en el inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el TextBox tenga un valor válido  
            if (string.IsNullOrWhiteSpace(tbCantidad.Text) || !int.TryParse(tbCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida mayor a 0.");
                return;
            }

            // Crear una nueva instancia de ReservaEntidad  
            ReservaEntidad nuevaReserva = new ReservaEntidad(
                Id: 0,
                existencia: existencia,
                cliente: formularioPrincipal.clienteActual,
                fechaReserva: DateTime.Now,
                cantidad: cantidad
            );

            // Enviar la reserva al servidor  
            bool exito = ClienteTCP.EnviarReserva(nuevaReserva);

            // Mostrar confirmación de creación o realizar acciones adicionales  
            if (exito)
            {
                MessageBox.Show("La reserva se ha creado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al crear la reserva. Por favor, inténtalo de nuevo.");
            }

            // Se devuelve a la pantalla de inicio  
            formularioPrincipal.Inicio();
        }
    }
}