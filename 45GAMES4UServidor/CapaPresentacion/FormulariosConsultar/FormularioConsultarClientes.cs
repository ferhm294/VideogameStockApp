/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using CapaCompartida;
using CapaAccesoDatos;

namespace CapaPresentacion.FormulariosConsultar
{
    public partial class FormularioConsultarClientes : Form
    {
        public FormularioConsultarClientes()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //Ventana sin bordes
            this.WindowState = FormWindowState.Maximized; //Ventana maximizada
            this.ControlBox = false; //Para que el formulario secundario no se vea como una ventana sino que solo se cambie el contenido del formulario principal

            // Obtener la lista de clientes
            ClienteAcceso clienteAD = new ClienteAcceso();
            List<ClienteEntidad> clientes = clienteAD.ConsultaCliente();

            // Configurar las columnas del DataGridView
            dgVClientes.Columns.Clear();
            dgVClientes.Columns.Add("Identificacion", "Identificación");
            dgVClientes.Columns.Add("Nombre", "Nombre");
            dgVClientes.Columns.Add("PrimerApellido", "Primer Apellido");
            dgVClientes.Columns.Add("SegundoApellido", "Segundo Apellido");
            dgVClientes.Columns.Add("FechaNacimiento", "Fecha de Nacimiento");
            dgVClientes.Columns.Add("JugadorEnLinea", "Jugador en Línea");

            // Enlazar la lista de clientes al DataGridView
            dgVClientes.AutoGenerateColumns = false;

            if (clientes.Count > 0)
            {
                foreach (var cliente in clientes)
                {
                    string jugadorEnLinea = cliente.JugadorEnLinea ? "Sí" : "No";
                    string fechaNacimiento = cliente.FechaNacimiento.HasValue ? cliente.FechaNacimiento.Value.ToShortDateString() : "N/A";
                    dgVClientes.Rows.Add(cliente.Identificacion, cliente.Nombre, cliente.PrimerApellido, cliente.SegundoApellido, fechaNacimiento, jugadorEnLinea);
                }
            }
            else
            {
                // Si la lista está vacía, mostrar "N/A"
                dgVClientes.Rows.Clear();
                dgVClientes.Rows.Add("N/A", "N/A", "N/A", "N/A", "N/A", "N/A");
            }
            
        }
    }
}