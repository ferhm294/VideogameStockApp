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
    public partial class FormularioConsultarAdministradores: Form
    {
        public FormularioConsultarAdministradores()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //Ventana sin bordes
            this.WindowState = FormWindowState.Maximized; //Ventana maximizada
            this.ControlBox = false; //Para que el formulario secundario no se vea como una ventana sino que solo se cambie el contenido del formulario principal

            // Obtener la lista de administradores
            AdministradorAcceso administradorAD = new AdministradorAcceso();
            List<AdministradorEntidad> administradores = administradorAD.ConsultaAdministrador();

            // Configurar las columnas del DataGridView
            dgVAdministradores.Columns.Clear();
            dgVAdministradores.Columns.Add("Identificacion", "Identificación");
            dgVAdministradores.Columns.Add("Nombre", "Nombre");
            dgVAdministradores.Columns.Add("PrimerApellido", "Primer Apellido");
            dgVAdministradores.Columns.Add("SegundoApellido", "Segundo Apellido");
            dgVAdministradores.Columns.Add("FechaNacimiento", "Fecha de Nacimiento");
            dgVAdministradores.Columns.Add("FechaContratacion", "Fecha de Contratación");

            // Enlazar la lista de administradores al DataGridView
            dgVAdministradores.AutoGenerateColumns = false;

            if (administradores.Count > 0)
            {
                foreach (var administrador in administradores)
                {
                    string fechaNacimiento = administrador.FechaNacimiento.HasValue ? administrador.FechaNacimiento.Value.ToShortDateString() : "N/A";
                    string fechaContratacion = administrador.FechaContratacion.HasValue ? administrador.FechaContratacion.Value.ToShortDateString() : "N/A";
                    dgVAdministradores.Rows.Add(administrador.Identificacion, administrador.Nombre, administrador.PrimerApellido, administrador.SegundoApellido, fechaNacimiento, fechaContratacion);
                }
            }
            else
            {
                // Si la lista está vacía, mostrar "N/A"
                dgVAdministradores.Rows.Clear();
                dgVAdministradores.Rows.Add("N/A", "N/A", "N/A", "N/A", "N/A", "N/A");
            }
        }
    }
}
