/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaPresentacion.FormulariosConsultar
{
    partial class FormularioConsultarVideojuegos
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
            dgVVideojuegos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgVVideojuegos).BeginInit();
            SuspendLayout();
            // 
            // EtiquetaTitulo
            // 
            EtiquetaTitulo.AutoSize = true;
            EtiquetaTitulo.Font = new Font("Segoe UI", 16F);
            EtiquetaTitulo.Location = new Point(289, 30);
            EtiquetaTitulo.Name = "EtiquetaTitulo";
            EtiquetaTitulo.Size = new Size(223, 30);
            EtiquetaTitulo.TabIndex = 1;
            EtiquetaTitulo.Text = "Consulta Videojuegos";
            // 
            // dgVVideojuegos
            // 
            dgVVideojuegos.AllowUserToAddRows = false;
            dgVVideojuegos.AllowUserToDeleteRows = false;
            dgVVideojuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVVideojuegos.Location = new Point(12, 63);
            dgVVideojuegos.Name = "dgVVideojuegos";
            dgVVideojuegos.ReadOnly = true;
            dgVVideojuegos.Size = new Size(776, 381);
            dgVVideojuegos.TabIndex = 2;
            // 
            // FormularioConsultarVideojuegos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgVVideojuegos);
            Controls.Add(EtiquetaTitulo);
            Name = "FormularioConsultarVideojuegos";
            Text = "Consulta Videojuegos";
            ((System.ComponentModel.ISupportInitialize)dgVVideojuegos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaTitulo;
        private DataGridView dgVVideojuegos;
    }
}