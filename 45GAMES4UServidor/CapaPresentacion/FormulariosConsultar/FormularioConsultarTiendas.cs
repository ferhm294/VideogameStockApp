/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using CapaAccesoDatos;
using CapaCompartida;

namespace CapaPresentacion.FormulariosConsultar
{
    public partial class FormularioConsultarTiendas : Form
    {
        public FormularioConsultarTiendas()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //Ventana sin bordes
            this.WindowState = FormWindowState.Maximized; //Ventana maximizada
            this.ControlBox = false; //Para que el formulario secundario no se vea como una ventana sino que solo se cambie el contenido del formulario principal

            // Obtener la lista de tiendas
            TiendaAcceso tiendaAD = new TiendaAcceso();
            List<TiendaEntidad> tiendas = tiendaAD.ConsultaTienda();

            // Configurar las columnas del DataGridView
            dgVTiendas.Columns.Clear();
            dgVTiendas.Columns.Add("Id", "ID");
            dgVTiendas.Columns.Add("Nombre", "Nombre");
            dgVTiendas.Columns.Add("Administrador", "Administrador");
            dgVTiendas.Columns.Add("Direccion", "Dirección");
            dgVTiendas.Columns.Add("Telefono", "Teléfono");
            dgVTiendas.Columns.Add("Activa", "Activa");

            // Enlazar la lista de tiendas al DataGridView
            dgVTiendas.AutoGenerateColumns = false;

            if (tiendas.Count > 0)
            {
                foreach (var tienda in tiendas)
                {
                    string nombreCompletoAdministrador = tienda.Administrador != null
                        ? $"{tienda.Administrador.Nombre} {tienda.Administrador.PrimerApellido} {tienda.Administrador.SegundoApellido}"
                        : "N/A";
                    string activa = tienda.Activa ? "Sí" : "No";
                    dgVTiendas.Rows.Add(tienda.Id, tienda.Nombre, nombreCompletoAdministrador, tienda.Direccion, tienda.Telefono, activa);
                }
            }
            else
            {
                // Si la lista está vacía, mostrar "N/A"
                dgVTiendas.Rows.Clear();
                dgVTiendas.Rows.Add("N/A", "N/A", "N/A", "N/A", "N/A", "N/A");

            }
        }
    }
}