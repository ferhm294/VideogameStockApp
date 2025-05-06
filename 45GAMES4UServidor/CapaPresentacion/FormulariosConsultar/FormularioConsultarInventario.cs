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
    public partial class FormularioConsultarInventario: Form
    {
        public FormularioConsultarInventario()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //Ventana sin bordes
            this.WindowState = FormWindowState.Maximized; //Ventana maximizada
            this.ControlBox = false; //Para que el formulario secundario no se vea como una ventana sino que solo se cambie el contenido del formulario principal

            // Obtener la lista del inventario de tiendas y videojuegos
            VideojuegosXTiendaAcceso inventarioAD = new VideojuegosXTiendaAcceso();
            List<VideojuegosXTiendaEntidad> inventarios = inventarioAD.ConsultaInventario();

            // Configurar las columnas del DataGridView
            dgVInventario.Columns.Clear();
            dgVInventario.Columns.Add("IdTienda", "ID Tienda");
            dgVInventario.Columns.Add("NombreTienda", "Nombre Tienda");
            dgVInventario.Columns.Add("DireccionTienda", "Dirección Tienda");
            dgVInventario.Columns.Add("IdVideojuego", "ID Videojuego");
            dgVInventario.Columns.Add("NombreVideojuego", "Nombre Videojuego");
            dgVInventario.Columns.Add("TipoVideojuego", "Tipo Videojuego");
            dgVInventario.Columns.Add("Inventario", "Existencias");

            // Enlazar la lista del inventario al DataGridView
            dgVInventario.AutoGenerateColumns = false;

            if (inventarios.Count > 0)
            {
                foreach (var inventario in inventarios)
                {
                    string tipoVideojuego = inventario.Videojuego.TipoVideojuego != null
                        ? inventario.Videojuego.TipoVideojuego.Nombre
                        : "N/A";
                    dgVInventario.Rows.Add(inventario.Tienda.Id, inventario.Tienda.Nombre, inventario.Tienda.Direccion, inventario.Videojuego.Id, inventario.Videojuego.Nombre, tipoVideojuego, inventario.Existencias);
                }
            }
            else
            {
                // Si la lista está vacía, mostrar "N/A"
                dgVInventario.Rows.Clear();
                dgVInventario.Rows.Add("N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A");
            }

        }
    }
}
