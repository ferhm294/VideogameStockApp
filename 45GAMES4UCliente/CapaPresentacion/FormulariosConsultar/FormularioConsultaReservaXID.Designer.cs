namespace CapaPresentacion.FormulariosConsultar
{
    partial class FormularioConsultaReservaXID
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
            dgvReservasCliente = new DataGridView();
            lbTitulo = new Label();
            lbIDReserva = new Label();
            tbIDReserva = new TextBox();
            btCancelar = new Button();
            btConsultar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReservasCliente).BeginInit();
            SuspendLayout();
            // 
            // dgvReservasCliente
            // 
            dgvReservasCliente.AllowUserToAddRows = false;
            dgvReservasCliente.AllowUserToDeleteRows = false;
            dgvReservasCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservasCliente.Location = new Point(12, 136);
            dgvReservasCliente.Name = "dgvReservasCliente";
            dgvReservasCliente.Size = new Size(776, 282);
            dgvReservasCliente.TabIndex = 9;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 16F);
            lbTitulo.Location = new Point(307, 33);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(186, 30);
            lbTitulo.TabIndex = 8;
            lbTitulo.Text = "Consulta Reservas";
            // 
            // lbIDReserva
            // 
            lbIDReserva.AutoSize = true;
            lbIDReserva.Font = new Font("Segoe UI", 12F);
            lbIDReserva.Location = new Point(12, 87);
            lbIDReserva.Name = "lbIDReserva";
            lbIDReserva.Size = new Size(124, 21);
            lbIDReserva.TabIndex = 10;
            lbIDReserva.Text = "ID de la Reserva:";
            // 
            // tbIDReserva
            // 
            tbIDReserva.Location = new Point(142, 89);
            tbIDReserva.Name = "tbIDReserva";
            tbIDReserva.Size = new Size(168, 23);
            tbIDReserva.TabIndex = 11;
            // 
            // btCancelar
            // 
            btCancelar.Font = new Font("Segoe UI", 12F);
            btCancelar.Location = new Point(702, 81);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(86, 33);
            btCancelar.TabIndex = 12;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btConsultar
            // 
            btConsultar.Font = new Font("Segoe UI", 12F);
            btConsultar.Location = new Point(594, 81);
            btConsultar.Name = "btConsultar";
            btConsultar.Size = new Size(86, 33);
            btConsultar.TabIndex = 13;
            btConsultar.Text = "Consultar";
            btConsultar.UseVisualStyleBackColor = true;
            btConsultar.Click += btConsultar_Click;
            // 
            // FormularioConsultaReservaXID
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btConsultar);
            Controls.Add(btCancelar);
            Controls.Add(tbIDReserva);
            Controls.Add(lbIDReserva);
            Controls.Add(dgvReservasCliente);
            Controls.Add(lbTitulo);
            Name = "FormularioConsultaReservaXID";
            Text = "FormularioConsultaReservaXID";
            ((System.ComponentModel.ISupportInitialize)dgvReservasCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReservasCliente;
        private Label lbTitulo;
        private Label lbIDReserva;
        private TextBox tbIDReserva;
        private Button btCancelar;
        private Button btConsultar;
    }
}