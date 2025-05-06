/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaPresentacion.FormulariosConsultar
{
    partial class FormularioConsultarTiendas
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
            dgVTiendas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgVTiendas).BeginInit();
            SuspendLayout();
            // 
            // EtiquetaTitulo
            // 
            EtiquetaTitulo.AutoSize = true;
            EtiquetaTitulo.Font = new Font("Segoe UI", 16F);
            EtiquetaTitulo.Location = new Point(285, 33);
            EtiquetaTitulo.Name = "EtiquetaTitulo";
            EtiquetaTitulo.Size = new Size(176, 30);
            EtiquetaTitulo.TabIndex = 3;
            EtiquetaTitulo.Text = "Consulta Tiendas";
            // 
            // dgVTiendas
            // 
            dgVTiendas.AllowUserToAddRows = false;
            dgVTiendas.AllowUserToDeleteRows = false;
            dgVTiendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVTiendas.Location = new Point(12, 66);
            dgVTiendas.Name = "dgVTiendas";
            dgVTiendas.ReadOnly = true;
            dgVTiendas.Size = new Size(776, 381);
            dgVTiendas.TabIndex = 4;
            // 
            // FormularioConsultarTiendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgVTiendas);
            Controls.Add(EtiquetaTitulo);
            Name = "FormularioConsultarTiendas";
            Text = "Consulta Tiendas";
            ((System.ComponentModel.ISupportInitialize)dgVTiendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaTitulo;
        private DataGridView dgVTiendas;
    }
}