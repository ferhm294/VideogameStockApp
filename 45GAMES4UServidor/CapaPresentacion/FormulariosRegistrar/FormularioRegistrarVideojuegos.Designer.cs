/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using System.Collections;
using CapaAccesoDatos;

namespace CapaPresentacion
{
    partial class FormularioRegistrarVideojuegos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbTipoVideojuego = new ComboBox();
            EtiquetaTitulo = new Label();
            EtiquetaNombre = new Label();
            EtiquetaTipoVideojuego = new Label();
            EtiquetaDesarrollador = new Label();
            EtiquetaLanzamiento = new Label();
            EtiquetaFisico = new Label();
            btGuardar = new Button();
            btCancelar = new Button();
            tbNombre = new TextBox();
            tbDesarrollador = new TextBox();
            tbLanzamiento = new TextBox();
            cbFisico = new ComboBox();
            SuspendLayout();
            // 
            // cbTipoVideojuego
            // 
            cbTipoVideojuego.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoVideojuego.FormattingEnabled = true;
            cbTipoVideojuego.Location = new Point(397, 159);
            cbTipoVideojuego.Name = "cbTipoVideojuego";
            cbTipoVideojuego.Size = new Size(161, 23);
            cbTipoVideojuego.TabIndex = 13;
            // 
            // EtiquetaTitulo
            // 
            EtiquetaTitulo.AutoSize = true;
            EtiquetaTitulo.Font = new Font("Segoe UI", 16F);
            EtiquetaTitulo.Location = new Point(271, 48);
            EtiquetaTitulo.Name = "EtiquetaTitulo";
            EtiquetaTitulo.Size = new Size(225, 30);
            EtiquetaTitulo.TabIndex = 0;
            EtiquetaTitulo.Text = "Registrar Videojuegos";
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Font = new Font("Segoe UI", 12F);
            EtiquetaNombre.Location = new Point(245, 114);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(68, 21);
            EtiquetaNombre.TabIndex = 2;
            EtiquetaNombre.Text = "Nombre";
            // 
            // EtiquetaTipoVideojuego
            // 
            EtiquetaTipoVideojuego.AutoSize = true;
            EtiquetaTipoVideojuego.Font = new Font("Segoe UI", 12F);
            EtiquetaTipoVideojuego.Location = new Point(245, 157);
            EtiquetaTipoVideojuego.Name = "EtiquetaTipoVideojuego";
            EtiquetaTipoVideojuego.Size = new Size(119, 21);
            EtiquetaTipoVideojuego.TabIndex = 3;
            EtiquetaTipoVideojuego.Text = "TipoVideojuego";
            // 
            // EtiquetaDesarrollador
            // 
            EtiquetaDesarrollador.AutoSize = true;
            EtiquetaDesarrollador.Font = new Font("Segoe UI", 12F);
            EtiquetaDesarrollador.Location = new Point(245, 202);
            EtiquetaDesarrollador.Name = "EtiquetaDesarrollador";
            EtiquetaDesarrollador.Size = new Size(105, 21);
            EtiquetaDesarrollador.TabIndex = 4;
            EtiquetaDesarrollador.Text = "Desarrollador";
            // 
            // EtiquetaLanzamiento
            // 
            EtiquetaLanzamiento.AutoSize = true;
            EtiquetaLanzamiento.Font = new Font("Segoe UI", 12F);
            EtiquetaLanzamiento.Location = new Point(245, 248);
            EtiquetaLanzamiento.Name = "EtiquetaLanzamiento";
            EtiquetaLanzamiento.Size = new Size(99, 21);
            EtiquetaLanzamiento.TabIndex = 5;
            EtiquetaLanzamiento.Text = "Lanzamiento";
            // 
            // EtiquetaFisico
            // 
            EtiquetaFisico.AutoSize = true;
            EtiquetaFisico.Font = new Font("Segoe UI", 12F);
            EtiquetaFisico.Location = new Point(245, 289);
            EtiquetaFisico.Name = "EtiquetaFisico";
            EtiquetaFisico.Size = new Size(49, 21);
            EtiquetaFisico.TabIndex = 6;
            EtiquetaFisico.Text = "Físico";
            // 
            // btGuardar
            // 
            btGuardar.Font = new Font("Segoe UI", 12F);
            btGuardar.Location = new Point(261, 352);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(83, 31);
            btGuardar.TabIndex = 7;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Font = new Font("Segoe UI", 12F);
            btCancelar.Location = new Point(446, 352);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(83, 31);
            btCancelar.TabIndex = 8;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click_1;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(397, 116);
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "Super Smash";
            tbNombre.Size = new Size(161, 23);
            tbNombre.TabIndex = 10;
            // 
            // tbDesarrollador
            // 
            tbDesarrollador.Location = new Point(397, 200);
            tbDesarrollador.Name = "tbDesarrollador";
            tbDesarrollador.PlaceholderText = "Nintendo";
            tbDesarrollador.Size = new Size(161, 23);
            tbDesarrollador.TabIndex = 11;
            // 
            // tbLanzamiento
            // 
            tbLanzamiento.Location = new Point(397, 246);
            tbLanzamiento.Name = "tbLanzamiento";
            tbLanzamiento.PlaceholderText = "2006";
            tbLanzamiento.Size = new Size(161, 23);
            tbLanzamiento.TabIndex = 12;
            // 
            // cbFisico
            // 
            cbFisico.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFisico.FormattingEnabled = true;
            cbFisico.Items.AddRange(new object[] { "Físico", "Virtual" });
            cbFisico.Location = new Point(397, 291);
            cbFisico.Name = "cbFisico";
            cbFisico.Size = new Size(161, 23);
            cbFisico.TabIndex = 14;
            // 
            // FormularioRegistrarVideojuegos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbFisico);
            Controls.Add(cbTipoVideojuego);
            Controls.Add(tbLanzamiento);
            Controls.Add(tbDesarrollador);
            Controls.Add(tbNombre);
            Controls.Add(btCancelar);
            Controls.Add(btGuardar);
            Controls.Add(EtiquetaFisico);
            Controls.Add(EtiquetaLanzamiento);
            Controls.Add(EtiquetaDesarrollador);
            Controls.Add(EtiquetaTipoVideojuego);
            Controls.Add(EtiquetaNombre);
            Controls.Add(EtiquetaTitulo);
            Name = "FormularioRegistrarVideojuegos";
            Text = "Registrar Videojuegos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaTitulo;
        private Label EtiquetaNombre;
        private Label EtiquetaTipoVideojuego;
        private Label EtiquetaDesarrollador;
        private Label EtiquetaLanzamiento;
        private Label EtiquetaFisico;
        private Button btGuardar;
        private Button btCancelar;
        private TextBox tbNombre;
        private TextBox tbDesarrollador;
        private TextBox tbLanzamiento;
        private ComboBox cbTipoVideojuego;
        private ComboBox cbFisico;
    }
}