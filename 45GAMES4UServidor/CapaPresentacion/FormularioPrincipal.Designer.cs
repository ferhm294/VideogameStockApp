/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaPresentacion
{
    public partial class FormularioPrincipal : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Menu = new MenuStrip();
            InicioToolStripMenuItem = new ToolStripMenuItem();
            RegistrarToolStripMenuItem = new ToolStripMenuItem();
            RegistrarTipodeVideojuegosToolStripMenuItem = new ToolStripMenuItem();
            RegistrarVideojuegosToolStripMenuItem = new ToolStripMenuItem();
            RegistrarAdministradoresToolStripMenuItem = new ToolStripMenuItem();
            RegistrarTiendasToolStripMenuItem = new ToolStripMenuItem();
            RegistrarInventarioToolStripMenuItem = new ToolStripMenuItem();
            RegistrarClientesToolStripMenuItem = new ToolStripMenuItem();
            ConsultasToolStripMenuItem = new ToolStripMenuItem();
            ConsultarTiposDeVideojuegosToolStripMenuItem = new ToolStripMenuItem();
            ConsultarVideojuegosToolStripMenuItem = new ToolStripMenuItem();
            ConsultarAdmnistradoresToolStripMenuItem = new ToolStripMenuItem();
            ConsultarTiendasToolStripMenuItem = new ToolStripMenuItem();
            ConsultarInventarioToolStripMenuItem = new ToolStripMenuItem();
            ConsultarClientesToolStripMenuItem = new ToolStripMenuItem();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Items.AddRange(new ToolStripItem[] { InicioToolStripMenuItem, RegistrarToolStripMenuItem, ConsultasToolStripMenuItem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(784, 24);
            Menu.TabIndex = 1;
            Menu.Text = "Menu";
            // 
            // InicioToolStripMenuItem
            // 
            InicioToolStripMenuItem.Name = "InicioToolStripMenuItem";
            InicioToolStripMenuItem.Size = new Size(48, 20);
            InicioToolStripMenuItem.Text = "Inicio";
            InicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // RegistrarToolStripMenuItem
            // 
            RegistrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RegistrarTipodeVideojuegosToolStripMenuItem, RegistrarVideojuegosToolStripMenuItem, RegistrarAdministradoresToolStripMenuItem, RegistrarTiendasToolStripMenuItem, RegistrarInventarioToolStripMenuItem, RegistrarClientesToolStripMenuItem });
            RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem";
            RegistrarToolStripMenuItem.Size = new Size(65, 20);
            RegistrarToolStripMenuItem.Text = "Registrar";
            // 
            // RegistrarTipodeVideojuegosToolStripMenuItem
            // 
            RegistrarTipodeVideojuegosToolStripMenuItem.Name = "RegistrarTipodeVideojuegosToolStripMenuItem";
            RegistrarTipodeVideojuegosToolStripMenuItem.Size = new Size(186, 22);
            RegistrarTipodeVideojuegosToolStripMenuItem.Text = "Tipos de Videojuegos";
            RegistrarTipodeVideojuegosToolStripMenuItem.Click += RegistrarTipodeVideojuegosToolStripMenuItem_Click;
            // 
            // RegistrarVideojuegosToolStripMenuItem
            // 
            RegistrarVideojuegosToolStripMenuItem.Name = "RegistrarVideojuegosToolStripMenuItem";
            RegistrarVideojuegosToolStripMenuItem.Size = new Size(186, 22);
            RegistrarVideojuegosToolStripMenuItem.Text = "Videojuegos";
            RegistrarVideojuegosToolStripMenuItem.Click += videojuegosToolStripMenuItem_Click;
            // 
            // RegistrarAdministradoresToolStripMenuItem
            // 
            RegistrarAdministradoresToolStripMenuItem.Name = "RegistrarAdministradoresToolStripMenuItem";
            RegistrarAdministradoresToolStripMenuItem.Size = new Size(186, 22);
            RegistrarAdministradoresToolStripMenuItem.Text = "Administradores";
            RegistrarAdministradoresToolStripMenuItem.Click += RegistrarAdministradoresToolStripMenuItem_Click;
            // 
            // RegistrarTiendasToolStripMenuItem
            // 
            RegistrarTiendasToolStripMenuItem.Name = "RegistrarTiendasToolStripMenuItem";
            RegistrarTiendasToolStripMenuItem.Size = new Size(186, 22);
            RegistrarTiendasToolStripMenuItem.Text = "Tiendas";
            RegistrarTiendasToolStripMenuItem.Click += RegistrarTiendasToolStripMenuItem_Click;
            // 
            // RegistrarInventarioToolStripMenuItem
            // 
            RegistrarInventarioToolStripMenuItem.Name = "RegistrarInventarioToolStripMenuItem";
            RegistrarInventarioToolStripMenuItem.Size = new Size(186, 22);
            RegistrarInventarioToolStripMenuItem.Text = "Inventario";
            RegistrarInventarioToolStripMenuItem.Click += RegistrarInventarioToolStripMenuItem_Click;
            // 
            // RegistrarClientesToolStripMenuItem
            // 
            RegistrarClientesToolStripMenuItem.Name = "RegistrarClientesToolStripMenuItem";
            RegistrarClientesToolStripMenuItem.Size = new Size(186, 22);
            RegistrarClientesToolStripMenuItem.Text = "Clientes";
            RegistrarClientesToolStripMenuItem.Click += RegistrarClientesToolStripMenuItem_Click;
            // 
            // ConsultasToolStripMenuItem
            // 
            ConsultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ConsultarTiposDeVideojuegosToolStripMenuItem, ConsultarVideojuegosToolStripMenuItem, ConsultarAdmnistradoresToolStripMenuItem, ConsultarTiendasToolStripMenuItem, ConsultarInventarioToolStripMenuItem, ConsultarClientesToolStripMenuItem });
            ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem";
            ConsultasToolStripMenuItem.Size = new Size(70, 20);
            ConsultasToolStripMenuItem.Text = "Consultar";
            // 
            // ConsultarTiposDeVideojuegosToolStripMenuItem
            // 
            ConsultarTiposDeVideojuegosToolStripMenuItem.Name = "ConsultarTiposDeVideojuegosToolStripMenuItem";
            ConsultarTiposDeVideojuegosToolStripMenuItem.Size = new Size(186, 22);
            ConsultarTiposDeVideojuegosToolStripMenuItem.Text = "Tipos de Videojuegos";
            ConsultarTiposDeVideojuegosToolStripMenuItem.Click += ConsultarTiposDeVideojuegosToolStripMenuItem_Click;
            // 
            // ConsultarVideojuegosToolStripMenuItem
            // 
            ConsultarVideojuegosToolStripMenuItem.Name = "ConsultarVideojuegosToolStripMenuItem";
            ConsultarVideojuegosToolStripMenuItem.Size = new Size(186, 22);
            ConsultarVideojuegosToolStripMenuItem.Text = "Videojuegos";
            ConsultarVideojuegosToolStripMenuItem.Click += ConsultarVideojuegosToolStripMenuItem_Click;
            // 
            // ConsultarAdmnistradoresToolStripMenuItem
            // 
            ConsultarAdmnistradoresToolStripMenuItem.Name = "ConsultarAdmnistradoresToolStripMenuItem";
            ConsultarAdmnistradoresToolStripMenuItem.Size = new Size(186, 22);
            ConsultarAdmnistradoresToolStripMenuItem.Text = "Admnistradores";
            ConsultarAdmnistradoresToolStripMenuItem.Click += ConsultarAdmnistradoresToolStripMenuItem_Click;
            // 
            // ConsultarTiendasToolStripMenuItem
            // 
            ConsultarTiendasToolStripMenuItem.Name = "ConsultarTiendasToolStripMenuItem";
            ConsultarTiendasToolStripMenuItem.Size = new Size(186, 22);
            ConsultarTiendasToolStripMenuItem.Text = "Tiendas";
            ConsultarTiendasToolStripMenuItem.Click += ConsultarTiendasToolStripMenuItem_Click;
            // 
            // ConsultarInventarioToolStripMenuItem
            // 
            ConsultarInventarioToolStripMenuItem.Name = "ConsultarInventarioToolStripMenuItem";
            ConsultarInventarioToolStripMenuItem.Size = new Size(186, 22);
            ConsultarInventarioToolStripMenuItem.Text = "Inventario";
            ConsultarInventarioToolStripMenuItem.Click += ConsultarInventarioToolStripMenuItem_Click;
            // 
            // ConsultarClientesToolStripMenuItem
            // 
            ConsultarClientesToolStripMenuItem.Name = "ConsultarClientesToolStripMenuItem";
            ConsultarClientesToolStripMenuItem.Size = new Size(186, 22);
            ConsultarClientesToolStripMenuItem.Text = "Clientes";
            ConsultarClientesToolStripMenuItem.Click += ConsultarClientesToolStripMenuItem_Click;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(784, 461);
            Controls.Add(Menu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            IsMdiContainer = true;
            MainMenuStrip = Menu;
            Name = "FormularioPrincipal";
            Text = "45GAMES4U - Servidor";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem RegistrarToolStripMenuItem;
        private ToolStripMenuItem RegistrarTipodeVideojuegosToolStripMenuItem;
        private ToolStripMenuItem ConsultasToolStripMenuItem;
        private ToolStripMenuItem RegistrarVideojuegosToolStripMenuItem;
        private ToolStripMenuItem RegistrarAdministradoresToolStripMenuItem;
        private ToolStripMenuItem RegistrarTiendasToolStripMenuItem;
        private ToolStripMenuItem RegistrarInventarioToolStripMenuItem;
        private ToolStripMenuItem RegistrarClientesToolStripMenuItem;
        private ToolStripMenuItem ConsultarTiposDeVideojuegosToolStripMenuItem;
        private ToolStripMenuItem ConsultarVideojuegosToolStripMenuItem;
        private ToolStripMenuItem ConsultarAdmnistradoresToolStripMenuItem;
        private ToolStripMenuItem ConsultarTiendasToolStripMenuItem;
        private ToolStripMenuItem ConsultarInventarioToolStripMenuItem;
        private ToolStripMenuItem ConsultarClientesToolStripMenuItem;
        private ToolStripMenuItem InicioToolStripMenuItem;
    }
}
