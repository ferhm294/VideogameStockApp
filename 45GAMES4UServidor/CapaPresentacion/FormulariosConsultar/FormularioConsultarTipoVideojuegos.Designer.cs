/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaPresentacion.FormulariosConsultar
{
    partial class FormularioConsultarTipoVideojuegos
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
            dgVTipoVideojuegos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgVTipoVideojuegos).BeginInit();
            SuspendLayout();
            // 
            // EtiquetaTitulo
            // 
            EtiquetaTitulo.AutoSize = true;
            EtiquetaTitulo.Font = new Font("Segoe UI", 16F);
            EtiquetaTitulo.Location = new Point(244, 34);
            EtiquetaTitulo.Name = "EtiquetaTitulo";
            EtiquetaTitulo.Size = new Size(303, 30);
            EtiquetaTitulo.TabIndex = 0;
            EtiquetaTitulo.Text = "Consulta Tipo de Videojuegos";
            // 
            // dgVTipoVideojuegos
            // 
            dgVTipoVideojuegos.AllowUserToAddRows = false;
            dgVTipoVideojuegos.AllowUserToDeleteRows = false;
            dgVTipoVideojuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVTipoVideojuegos.Location = new Point(12, 67);
            dgVTipoVideojuegos.Name = "dgVTipoVideojuegos";
            dgVTipoVideojuegos.ReadOnly = true;
            dgVTipoVideojuegos.Size = new Size(776, 381);
            dgVTipoVideojuegos.TabIndex = 1;
            // 
            // FormularioConsultarTipoVideojuegos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgVTipoVideojuegos);
            Controls.Add(EtiquetaTitulo);
            Name = "FormularioConsultarTipoVideojuegos";
            Text = "Consulta Tipo de Videojuegos";
            ((System.ComponentModel.ISupportInitialize)dgVTipoVideojuegos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaTitulo;
        private DataGridView dgVTipoVideojuegos;
    }
}