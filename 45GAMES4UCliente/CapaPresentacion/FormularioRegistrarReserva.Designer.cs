namespace CapaPresentacion
{
    partial class FormularioRegistrarReserva
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
            gbParametrosReserva = new GroupBox();
            btCancelar = new Button();
            btGuardar = new Button();
            tbCantidad = new TextBox();
            lbCantidad = new Label();
            lbFechaReserva = new Label();
            dateTimePicker1 = new DateTimePicker();
            cbTienda = new ComboBox();
            lbTienda = new Label();
            dgvExistencias = new DataGridView();
            gbParametrosReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExistencias).BeginInit();
            SuspendLayout();
            // 
            // EtiquetaTitulo
            // 
            EtiquetaTitulo.AutoSize = true;
            EtiquetaTitulo.Font = new Font("Segoe UI", 16F);
            EtiquetaTitulo.Location = new Point(299, 47);
            EtiquetaTitulo.Name = "EtiquetaTitulo";
            EtiquetaTitulo.Size = new Size(201, 30);
            EtiquetaTitulo.TabIndex = 1;
            EtiquetaTitulo.Text = "Registrar Inventario";
            // 
            // gbParametrosReserva
            // 
            gbParametrosReserva.Controls.Add(btCancelar);
            gbParametrosReserva.Controls.Add(btGuardar);
            gbParametrosReserva.Controls.Add(tbCantidad);
            gbParametrosReserva.Controls.Add(lbCantidad);
            gbParametrosReserva.Controls.Add(lbFechaReserva);
            gbParametrosReserva.Controls.Add(dateTimePicker1);
            gbParametrosReserva.Controls.Add(cbTienda);
            gbParametrosReserva.Controls.Add(lbTienda);
            gbParametrosReserva.Font = new Font("Segoe UI", 12F);
            gbParametrosReserva.Location = new Point(12, 95);
            gbParametrosReserva.Name = "gbParametrosReserva";
            gbParametrosReserva.Size = new Size(776, 106);
            gbParametrosReserva.TabIndex = 2;
            gbParametrosReserva.TabStop = false;
            gbParametrosReserva.Text = "Parámetros de Reserva";
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(403, 65);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(85, 35);
            btCancelar.TabIndex = 7;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(218, 65);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(85, 35);
            btGuardar.TabIndex = 6;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(559, 25);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.Size = new Size(211, 29);
            tbCantidad.TabIndex = 5;
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.Location = new Point(478, 28);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(75, 21);
            lbCantidad.TabIndex = 4;
            lbCantidad.Text = "Cantidad:";
            // 
            // lbFechaReserva
            // 
            lbFechaReserva.AutoSize = true;
            lbFechaReserva.Location = new Point(218, 28);
            lbFechaReserva.Name = "lbFechaReserva";
            lbFechaReserva.Size = new Size(112, 21);
            lbFechaReserva.TabIndex = 3;
            lbFechaReserva.Text = "Fecha Reserva:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(336, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(126, 29);
            dateTimePicker1.TabIndex = 2;
            // 
            // cbTienda
            // 
            cbTienda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTienda.FormattingEnabled = true;
            cbTienda.Location = new Point(71, 25);
            cbTienda.Name = "cbTienda";
            cbTienda.Size = new Size(141, 29);
            cbTienda.TabIndex = 1;
            cbTienda.SelectedIndexChanged += cbTienda_SelectedIndexChanged;
            // 
            // lbTienda
            // 
            lbTienda.AutoSize = true;
            lbTienda.Location = new Point(6, 28);
            lbTienda.Name = "lbTienda";
            lbTienda.Size = new Size(59, 21);
            lbTienda.TabIndex = 0;
            lbTienda.Text = "Tienda:";
            // 
            // dgvExistencias
            // 
            dgvExistencias.AllowUserToAddRows = false;
            dgvExistencias.AllowUserToDeleteRows = false;
            dgvExistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExistencias.Location = new Point(12, 207);
            dgvExistencias.MultiSelect = false;
            dgvExistencias.Name = "dgvExistencias";
            dgvExistencias.ReadOnly = true;
            dgvExistencias.Size = new Size(776, 240);
            dgvExistencias.TabIndex = 3;
            // 
            // FormularioRegistrarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvExistencias);
            Controls.Add(gbParametrosReserva);
            Controls.Add(EtiquetaTitulo);
            Name = "FormularioRegistrarReserva";
            Text = "FormularioRegistrarReserva";
            gbParametrosReserva.ResumeLayout(false);
            gbParametrosReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExistencias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaTitulo;
        private GroupBox gbParametrosReserva;
        private Label lbTienda;
        private ComboBox cbTienda;
        private TextBox tbCantidad;
        private Label lbCantidad;
        private Label lbFechaReserva;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgvExistencias;
        private Button btCancelar;
        private Button btGuardar;
    }
}