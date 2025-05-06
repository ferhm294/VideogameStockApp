/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaPresentacion.FormulariosConsultar
{
    partial class FormularioConsultarAdministradores
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
            dgVAdministradores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgVAdministradores).BeginInit();
            SuspendLayout();
            // 
            // EtiquetaTitulo
            // 
            EtiquetaTitulo.AutoSize = true;
            EtiquetaTitulo.Font = new Font("Segoe UI", 16F);
            EtiquetaTitulo.Location = new Point(265, 33);
            EtiquetaTitulo.Name = "EtiquetaTitulo";
            EtiquetaTitulo.Size = new Size(260, 30);
            EtiquetaTitulo.TabIndex = 2;
            EtiquetaTitulo.Text = "Consulta Administradores";
            // 
            // dgVAdministradores
            // 
            dgVAdministradores.AllowUserToAddRows = false;
            dgVAdministradores.AllowUserToDeleteRows = false;
            dgVAdministradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVAdministradores.Location = new Point(12, 66);
            dgVAdministradores.Name = "dgVAdministradores";
            dgVAdministradores.ReadOnly = true;
            dgVAdministradores.Size = new Size(776, 381);
            dgVAdministradores.TabIndex = 3;
            // 
            // FormularioConsultarAdministradores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgVAdministradores);
            Controls.Add(EtiquetaTitulo);
            Name = "FormularioConsultarAdministradores";
            Text = "Consulta Administradores";
            ((System.ComponentModel.ISupportInitialize)dgVAdministradores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaTitulo;
        private DataGridView dgVAdministradores;
    }
}