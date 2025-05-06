namespace CapaPresentacion.FormulariosConsultar
{
    partial class FormularioConsultaCliente
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
            lbTitulo = new Label();
            dgvReservasCliente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReservasCliente).BeginInit();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 16F);
            lbTitulo.Location = new Point(307, 53);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(186, 30);
            lbTitulo.TabIndex = 6;
            lbTitulo.Text = "Consulta Reservas";
            // 
            // dgvReservasCliente
            // 
            dgvReservasCliente.AllowUserToAddRows = false;
            dgvReservasCliente.AllowUserToDeleteRows = false;
            dgvReservasCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservasCliente.Location = new Point(12, 86);
            dgvReservasCliente.Name = "dgvReservasCliente";
            dgvReservasCliente.Size = new Size(776, 352);
            dgvReservasCliente.TabIndex = 7;
            // 
            // FormularioConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvReservasCliente);
            Controls.Add(lbTitulo);
            Name = "FormularioConsultaCliente";
            Text = "FormularioConsultaCliente";
            ((System.ComponentModel.ISupportInitialize)dgvReservasCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private DataGridView dgvReservasCliente;
    }
}