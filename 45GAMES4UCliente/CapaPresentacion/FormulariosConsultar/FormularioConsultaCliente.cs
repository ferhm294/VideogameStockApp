

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
    public partial class FormularioConsultaCliente: Form
    {
        private FormularioPrincipal formularioPrincipal;
        public FormularioConsultaCliente(FormularioPrincipal formularioPrincipal)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None; //Ventana sin bordes
            this.WindowState = FormWindowState.Maximized; //Ventana maximizada
            this.ControlBox = false; //Para que el formulario secundario no se vea como una ventana sino que solo se cambie el contenido del formulario principal
            this.formularioPrincipal = formularioPrincipal;

            cargarDatos();
        }

        private void cargarDatos()
        {
            //Llenar el DataGridView con los datos de los clientes
            List<ReservaEntidad> reservas = ClienteTCP.ObtenerReservasCliente(formularioPrincipal.clienteActual.Identificacion.ToString());

            //Se crean las columnas del DataGridView
            dgvReservasCliente.Columns.Clear();
            dgvReservasCliente.Columns.Add("IdReserva", "Id Reserva");
            dgvReservasCliente.Columns.Add("NombreTienda", "Tienda");
            dgvReservasCliente.Columns.Add("NombreVideojuego", "Videojuego");
            dgvReservasCliente.Columns.Add("FechaReserva", "Fecha de Reserva");
            dgvReservasCliente.Columns.Add("CantidadReservada", "Cantidad Reservada");
            dgvReservasCliente.Columns["FechaReserva"].DefaultCellStyle.Format = "dd/MM/yyyy"; //Formato de fecha

            //Se carga el DataGridView con los datos de la lista
            if (reservas.Count > 0)
            {
                foreach (ReservaEntidad reserva in reservas)
                {
                    dgvReservasCliente.Rows.Add(reserva.Id, reserva.existencia.Tienda.Nombre, reserva.existencia.Videojuego.Nombre, reserva.fechaReserva, reserva.cantidad);
                }
            } else
            {
                //Se rellena el DataGridView con N/A
                dgvReservasCliente.Rows.Add("N/A", "N/A", "N/A", "N/A", "N/A");
            }
        }
    }
}
