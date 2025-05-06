

using CapaCompartida;



using CapaNegocio;

/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaPresentacion.FormulariosConsultar
{
    public partial class FormularioConsultaReservaXID : Form
    {
        FormularioPrincipal formularioPrincipal;
        public FormularioConsultaReservaXID(FormularioPrincipal formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;

            this.FormBorderStyle = FormBorderStyle.None; //Ventana sin bordes
            this.WindowState = FormWindowState.Maximized; //Ventana maximizada
            this.ControlBox = false; //Para que el formulario secundario no se vea como una ventana sino que solo se cambie el contenido del formulario principal
            this.formularioPrincipal = formularioPrincipal;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            formularioPrincipal.Inicio();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            // Validar que el TextBox no esté vacío
            if (string.IsNullOrWhiteSpace(tbIDReserva.Text))
            {
                MessageBox.Show("El campo ID Reserva no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el contenido sea un número entero
            if (!int.TryParse(tbIDReserva.Text, out int idReserva))
            {
                MessageBox.Show("Por favor, ingresa un valor numérico válido para el ID de Reserva.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Llamar al método cargarDatos si las validaciones son correctas
            cargarDatos(idReserva);
        }

        private void cargarDatos(int id)
        {
            // Llenar el DataGridView con los datos de los clientes
            List<ReservaEntidad> reservas = ClienteTCP.ObtenerReservasCliente(formularioPrincipal.clienteActual.Identificacion.ToString());

            // Se crean las columnas del DataGridView si aún no existen
            dgvReservasCliente.Columns.Clear();
            dgvReservasCliente.Columns.Add("IdReserva", "Id Reserva");
            dgvReservasCliente.Columns.Add("NombreTienda", "Tienda");
            dgvReservasCliente.Columns.Add("NombreVideojuego", "Videojuego");
            dgvReservasCliente.Columns.Add("FechaReserva", "Fecha de Reserva");
            dgvReservasCliente.Columns.Add("CantidadReservada", "Cantidad Reservada");
            dgvReservasCliente.Columns["FechaReserva"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Formato de fecha

            // Bandera para determinar si se encontró la reserva
            bool reservaEncontrada = false;

            // Validar si la lista contiene elementos
            if (reservas != null && reservas.Count > 0)
            {
                foreach (ReservaEntidad reserva in reservas)
                {
                    if (id == reserva.Id) // Comparar el ID proporcionado
                    {
                        // Si se encuentra la reserva, se agrega al DataGridView
                        dgvReservasCliente.Rows.Add(reserva.Id, reserva.existencia.Tienda.Nombre, reserva.existencia.Videojuego.Nombre, reserva.fechaReserva, reserva.cantidad);
                        reservaEncontrada = true;
                        break; // Salir del bucle una vez encontrada la reserva
                    }
                }
            }

            // Si no se encontró la reserva, agregar un registro con "N/A"
            if (!reservaEncontrada)
            {
                dgvReservasCliente.Rows.Add("N/A", "N/A", "N/A", "N/A", "N/A");
            }
        }
    }
}
