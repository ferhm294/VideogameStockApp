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
    public partial class FormularioConsultarTipoVideojuegos: Form
    {
        public FormularioConsultarTipoVideojuegos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //Ventana sin bordes
            this.WindowState = FormWindowState.Maximized; //Ventana maximizada
            this.ControlBox = false; //Para que el formulario secundario no se vea como una ventana sino que solo se cambie el contenido del formulario principal

            // Obtener la lista de tipos de videojuegos
            TipoVideojuegoAcceso tipovideojuegoAD = new TipoVideojuegoAcceso();
            List<TipoVideojuegoEntidad> tiposVideojuego = tipovideojuegoAD.ConsultaTipoVideojuego();

            // Configurar las columnas del DataGridView
            dgVTipoVideojuegos.Columns.Clear();
            dgVTipoVideojuegos.Columns.Add("Id", "ID");
            dgVTipoVideojuegos.Columns.Add("Nombre", "Nombre");
            dgVTipoVideojuegos.Columns.Add("Descripcion", "Descripción");

            // Enlazar la lista de tipos de videojuegos al DataGridView
            dgVTipoVideojuegos.AutoGenerateColumns = false;

            if (tiposVideojuego.Count > 0)
            {
                dgVTipoVideojuegos.DataSource = tiposVideojuego;

                // Configurar DataPropertyNames para enlazar las columnas con las propiedades de TipoVideojuegoEntidad
                dgVTipoVideojuegos.Columns["Id"].DataPropertyName = "Id";
                dgVTipoVideojuegos.Columns["Nombre"].DataPropertyName = "Nombre";
                dgVTipoVideojuegos.Columns["Descripcion"].DataPropertyName = "Descripcion";
            }
            else
            {
                // Si la lista está vacía, mostrar "N/A"
                dgVTipoVideojuegos.Rows.Clear();
                dgVTipoVideojuegos.Rows.Add("N/A", "N/A", "N/A");
            }
        }
    }
}
