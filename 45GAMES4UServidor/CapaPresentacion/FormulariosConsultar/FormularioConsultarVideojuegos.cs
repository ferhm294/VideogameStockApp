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
    public partial class FormularioConsultarVideojuegos: Form
    {
        public FormularioConsultarVideojuegos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //Ventana sin bordes
            this.WindowState = FormWindowState.Maximized; //Ventana maximizada
            this.ControlBox = false; //Para que el formulario secundario no se vea como una ventana sino que solo se cambie el contenido del formulario principal

            // Obtener la lista de videojuegos
            VideojuegoAcceso videojuegoAD = new VideojuegoAcceso();
            List<VideojuegoEntidad> videojuegos = videojuegoAD.ConsultaVideojuego();

            // Configurar las columnas del DataGridView
            dgVVideojuegos.Columns.Clear();
            dgVVideojuegos.Columns.Add("Id", "ID");
            dgVVideojuegos.Columns.Add("Nombre", "Nombre");
            dgVVideojuegos.Columns.Add("TipoVideojuego", "Tipo de Videojuego");
            dgVVideojuegos.Columns.Add("Desarrollador", "Desarrollador");
            dgVVideojuegos.Columns.Add("Lanzamiento", "Año de Lanzamiento");
            dgVVideojuegos.Columns.Add("Fisico", "Físico");

            // Enlazar la lista de videojuegos al DataGridView
            dgVVideojuegos.AutoGenerateColumns = false;

            if (videojuegos.Count > 0)
            {
                foreach (var videojuego in videojuegos)
                {
                    string tipoVideojuegoNombre = videojuego.TipoVideojuego != null ? videojuego.TipoVideojuego.Nombre : "N/A";
                    string fisico = videojuego.Fisico ? "Sí" : "No";
                    dgVVideojuegos.Rows.Add(videojuego.Id, videojuego.Nombre, tipoVideojuegoNombre, videojuego.Desarrollador, videojuego.Lanzamiento, fisico);
                }
            }
            else
            {
                // Si la lista está vacía, mostrar "N/A"
                dgVVideojuegos.Rows.Clear();
                dgVVideojuegos.Rows.Add("N/A", "N/A", "N/A", "N/A", "N/A", "N/A");
            }
        }
    }
}