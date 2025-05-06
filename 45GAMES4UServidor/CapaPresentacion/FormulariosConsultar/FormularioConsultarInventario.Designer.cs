/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaPresentacion.FormulariosConsultar
{
    partial class FormularioConsultarInventario
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
            dgVInventario = new DataGridView();
            EtiquetaTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgVInventario).BeginInit();
            SuspendLayout();
            // 
            // dgVInventario
            // 
            dgVInventario.AllowUserToAddRows = false;
            dgVInventario.AllowUserToDeleteRows = false;
            dgVInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVInventario.Location = new Point(12, 69);
            dgVInventario.Name = "dgVInventario";
            dgVInventario.ReadOnly = true;
            dgVInventario.Size = new Size(776, 381);
            dgVInventario.TabIndex = 5;
            // 
            // EtiquetaTitulo
            // 
            EtiquetaTitulo.AutoSize = true;
            EtiquetaTitulo.Font = new Font("Segoe UI", 16F);
            EtiquetaTitulo.Location = new Point(302, 36);
            EtiquetaTitulo.Name = "EtiquetaTitulo";
            EtiquetaTitulo.Size = new Size(199, 30);
            EtiquetaTitulo.TabIndex = 6;
            EtiquetaTitulo.Text = "Consulta Inventario";
            // 
            // FormularioConsultarInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EtiquetaTitulo);
            Controls.Add(dgVInventario);
            Name = "FormularioConsultarInventario";
            Text = "Consulta Inventario";
            ((System.ComponentModel.ISupportInitialize)dgVInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgVInventario;
        private Label EtiquetaTitulo;
    }
}