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
    public partial class FormularioRegistrarAdministradores : Form
    {
        private FormularioPrincipal formularioPrincipal;
        public FormularioRegistrarAdministradores(FormularioPrincipal formularioPrincipal)
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
            AdministradorAcceso administradorAD = new AdministradorAcceso();
            if (CamposRequeridosCompletos())
            {
                try
                {
                    int identificacion = int.Parse(tbIdentificacion.Text.Trim());
                    DateTime fechaNacimiento = dtPFechaNacimiento.Value;
                    DateTime fechaContratacion = dtPFechaContratacion.Value;

                    if (AdministradorServicio.ValidarId(identificacion) && AdministradorServicio.MayorDeEdad(fechaNacimiento))
                    {
                        bool exito = administradorAD.AgregarAdministrador(
                            identificacion,
                            tbNombre.Text,
                            tbPrimerApellido.Text,
                            tbSegundoApellido.Text,
                            fechaNacimiento,
                            fechaContratacion
                        );

                        if (exito)
                        {
                            MessageBox.Show("¡Administrador agregado con éxito!");
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("¡No se pudo agregar el administrador, verifique los datos!");
                        }
                    }
                    else
                    {
                        if (!AdministradorServicio.ValidarId(identificacion))
                        {
                            MessageBox.Show("¡El ID ya se encuentra en uso!");
                        }
                        if (!AdministradorServicio.MayorDeEdad(fechaNacimiento))
                        {
                            MessageBox.Show("¡El administrador debe ser mayor de edad (más de 18 años)!");
                        }
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("¡La identificación debe contener solamente números enteros!");
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("¡No deje campos vacíos!");
            }
        }

        private bool CamposRequeridosCompletos()
        {
            return !string.IsNullOrWhiteSpace(tbIdentificacion.Text) &&
                   !string.IsNullOrWhiteSpace(tbNombre.Text) &&
                   !string.IsNullOrWhiteSpace(tbPrimerApellido.Text) &&
                   !string.IsNullOrWhiteSpace(tbSegundoApellido.Text) &&
                   dtPFechaNacimiento.Value != null &&
                   dtPFechaContratacion.Value != null;
        }

        private void LimpiarCampos()
        {
            tbIdentificacion.Clear();
            tbNombre.Clear();
            tbPrimerApellido.Clear();
            tbSegundoApellido.Clear();
            dtPFechaNacimiento.Value = DateTime.Today;
            dtPFechaContratacion.Value = DateTime.Today;
        }

    }
}