/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaPresentacion
{
    partial class FormularioPrincipal
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
            menuStrip = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            conectarToolStripMenuItem = new ToolStripMenuItem();
            desconectarToolStripMenuItem = new ToolStripMenuItem();
            reservarToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            consultaClienteToolStripMenuItem = new ToolStripMenuItem();
            consultaPorReservaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, conectarToolStripMenuItem, desconectarToolStripMenuItem, reservarToolStripMenuItem, consultasToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menu";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // conectarToolStripMenuItem
            // 
            conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            conectarToolStripMenuItem.Size = new Size(67, 20);
            conectarToolStripMenuItem.Text = "Conectar";
            conectarToolStripMenuItem.Click += conectarToolStripMenuItem_Click;
            // 
            // desconectarToolStripMenuItem
            // 
            desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            desconectarToolStripMenuItem.Size = new Size(84, 20);
            desconectarToolStripMenuItem.Text = "Desconectar";
            desconectarToolStripMenuItem.Click += desconectarToolStripMenuItem_Click;
            // 
            // reservarToolStripMenuItem
            // 
            reservarToolStripMenuItem.Name = "reservarToolStripMenuItem";
            reservarToolStripMenuItem.Size = new Size(63, 20);
            reservarToolStripMenuItem.Text = "Reservar";
            reservarToolStripMenuItem.Click += reservarToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultaClienteToolStripMenuItem, consultaPorReservaToolStripMenuItem });
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(71, 20);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaClienteToolStripMenuItem
            // 
            consultaClienteToolStripMenuItem.Name = "consultaClienteToolStripMenuItem";
            consultaClienteToolStripMenuItem.Size = new Size(199, 22);
            consultaClienteToolStripMenuItem.Text = "Consulta Reservas";
            consultaClienteToolStripMenuItem.Click += consultaClienteToolStripMenuItem_Click;
            // 
            // consultaPorReservaToolStripMenuItem
            // 
            consultaPorReservaToolStripMenuItem.Name = "consultaPorReservaToolStripMenuItem";
            consultaPorReservaToolStripMenuItem.Size = new Size(199, 22);
            consultaPorReservaToolStripMenuItem.Text = "Consulta Reserva por ID";
            consultaPorReservaToolStripMenuItem.Click += consultaPorReservaToolStripMenuItem_Click;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "FormularioPrincipal";
            Text = "45GAMES4U - Cliente";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem conectarToolStripMenuItem;
        private ToolStripMenuItem desconectarToolStripMenuItem;
        private ToolStripMenuItem reservarToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem consultaClienteToolStripMenuItem;
        private ToolStripMenuItem consultaPorReservaToolStripMenuItem;
    }
}
