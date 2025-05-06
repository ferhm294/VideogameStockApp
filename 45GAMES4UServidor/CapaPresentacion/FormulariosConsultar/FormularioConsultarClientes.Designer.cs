/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaPresentacion.FormulariosConsultar
{
    partial class FormularioConsultarClientes
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
            dgVClientes = new DataGridView();
            EtiquetaTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgVClientes).BeginInit();
            SuspendLayout();
            // 
            // dgVClientes
            // 
            dgVClientes.AllowUserToAddRows = false;
            dgVClientes.AllowUserToDeleteRows = false;
            dgVClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVClientes.Location = new Point(12, 66);
            dgVClientes.Name = "dgVClientes";
            dgVClientes.ReadOnly = true;
            dgVClientes.Size = new Size(776, 381);
            dgVClientes.TabIndex = 6;
            // 
            // EtiquetaTitulo
            // 
            EtiquetaTitulo.AutoSize = true;
            EtiquetaTitulo.Font = new Font("Segoe UI", 16F);
            EtiquetaTitulo.Location = new Point(298, 33);
            EtiquetaTitulo.Name = "EtiquetaTitulo";
            EtiquetaTitulo.Size = new Size(178, 30);
            EtiquetaTitulo.TabIndex = 7;
            EtiquetaTitulo.Text = "Consulta Clientes";
            // 
            // FormularioConsultarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EtiquetaTitulo);
            Controls.Add(dgVClientes);
            Name = "FormularioConsultarClientes";
            Text = "Consulta Clientes";
            ((System.ComponentModel.ISupportInitialize)dgVClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgVClientes;
        private Label EtiquetaTitulo;
    }
}