/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaPresentacion
{
    public partial class FormularioRegistrarTipoVideojuegos : Form
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
            EtiquetaTitulo = new Label();
            EtiquetaNombre = new Label();
            EtiquetaDescripcion = new Label();
            tbNombre = new TextBox();
            tbDescripcion = new TextBox();
            btGuardar = new Button();
            btCancelar = new Button();
            SuspendLayout();
            // 
            // EtiquetaTitulo
            // 
            EtiquetaTitulo.AutoSize = true;
            EtiquetaTitulo.Font = new Font("Segoe UI", 16F);
            EtiquetaTitulo.Location = new Point(227, 63);
            EtiquetaTitulo.Name = "EtiquetaTitulo";
            EtiquetaTitulo.Size = new Size(314, 30);
            EtiquetaTitulo.TabIndex = 0;
            EtiquetaTitulo.Text = "Registrar Tipos de Videojuegos";
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Font = new Font("Segoe UI", 12F);
            EtiquetaNombre.Location = new Point(227, 158);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(68, 21);
            EtiquetaNombre.TabIndex = 2;
            EtiquetaNombre.Text = "Nombre";
            // 
            // EtiquetaDescripcion
            // 
            EtiquetaDescripcion.AutoSize = true;
            EtiquetaDescripcion.Font = new Font("Segoe UI", 12F);
            EtiquetaDescripcion.Location = new Point(227, 216);
            EtiquetaDescripcion.Name = "EtiquetaDescripcion";
            EtiquetaDescripcion.Size = new Size(91, 21);
            EtiquetaDescripcion.TabIndex = 3;
            EtiquetaDescripcion.Text = "Descripción";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(367, 160);
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "Acción";
            tbNombre.Size = new Size(174, 23);
            tbNombre.TabIndex = 5;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(367, 218);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.PlaceholderText = "Describe la categoría";
            tbDescripcion.Size = new Size(174, 23);
            tbDescripcion.TabIndex = 6;
            // 
            // btGuardar
            // 
            btGuardar.Font = new Font("Segoe UI", 12F);
            btGuardar.Location = new Point(271, 291);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(79, 32);
            btGuardar.TabIndex = 7;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Font = new Font("Segoe UI", 12F);
            btCancelar.Location = new Point(415, 291);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(79, 32);
            btCancelar.TabIndex = 8;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // FormularioRegistrarTipoVideojuegos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btCancelar);
            Controls.Add(btGuardar);
            Controls.Add(tbDescripcion);
            Controls.Add(tbNombre);
            Controls.Add(EtiquetaDescripcion);
            Controls.Add(EtiquetaNombre);
            Controls.Add(EtiquetaTitulo);
            Name = "FormularioRegistrarTipoVideojuegos";
            Text = "Registrar Tipo de Videojuegos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaTitulo;
        private Label EtiquetaNombre;
        private Label EtiquetaDescripcion;
        private TextBox tbNombre;
        private TextBox tbDescripcion;
        private Button btGuardar;
        private Button btCancelar;
    }
}