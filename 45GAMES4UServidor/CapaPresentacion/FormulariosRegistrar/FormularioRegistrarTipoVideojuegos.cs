/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAccesoDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormularioRegistrarTipoVideojuegos : Form
    {
        private FormularioPrincipal formularioPrincipal;
        public FormularioRegistrarTipoVideojuegos(FormularioPrincipal formularioPrincipal)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //Ventana sin bordes
            this.WindowState = FormWindowState.Maximized; //Ventana maximizada
            this.ControlBox = false; //Para que el formulario secundario no se vea como una ventana sino que solo se cambie el contenido del formulario principal
            this.formularioPrincipal = formularioPrincipal;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            formularioPrincipal.Inicio();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            TipoVideojuegoAcceso tipoVideojuegoAD = new TipoVideojuegoAcceso();
            if (CamposRequeridosCompletos())
            {
                tipoVideojuegoAD.AgregarTipoVideojuego(tbNombre.Text, tbDescripcion.Text);
                MessageBox.Show("¡Tipo de videojuego agregado con éxito!");

                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("¡No deje campos vacíos!");
            }
        }

        private bool CamposRequeridosCompletos()
        {
            return !string.IsNullOrWhiteSpace(tbNombre.Text) &&
                   !string.IsNullOrWhiteSpace(tbDescripcion.Text);
        }

        private void LimpiarCampos()
        {
            tbNombre.Clear();
            tbDescripcion.Clear();
        }

    }
}