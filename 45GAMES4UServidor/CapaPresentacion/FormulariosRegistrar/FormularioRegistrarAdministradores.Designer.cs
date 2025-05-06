/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

using static System.Windows.Forms.DataFormats;

/**
 * UNED I Cuatrimestre 2025
 * Proyecto I: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 23 de Febrero de 2025
 */

namespace CapaPresentacion
{
    partial class FormularioRegistrarAdministradores
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
            EtiquetaIdentificacion = new Label();
            EtiquetaNombre = new Label();
            EtiquetaPrimerApellido = new Label();
            EtiquetaSegundoApellido = new Label();
            EtiquetaFechaNacimiento = new Label();
            EtiquetaFechaContratacion = new Label();
            tbIdentificacion = new TextBox();
            tbNombre = new TextBox();
            tbPrimerApellido = new TextBox();
            tbSegundoApellido = new TextBox();
            dtPFechaNacimiento = new DateTimePicker();
            dtPFechaContratacion = new DateTimePicker();
            btGuardar = new Button();
            btCancelar = new Button();
            SuspendLayout();
            // 
            // EtiquetaTitulo
            // 
            EtiquetaTitulo.AutoSize = true;
            EtiquetaTitulo.Font = new Font("Segoe UI", 16F);
            EtiquetaTitulo.Location = new Point(253, 44);
            EtiquetaTitulo.Name = "EtiquetaTitulo";
            EtiquetaTitulo.Size = new Size(262, 30);
            EtiquetaTitulo.TabIndex = 0;
            EtiquetaTitulo.Text = "Registrar Administradores";
            // 
            // EtiquetaIdentificacion
            // 
            EtiquetaIdentificacion.AutoSize = true;
            EtiquetaIdentificacion.Font = new Font("Segoe UI", 12F);
            EtiquetaIdentificacion.Location = new Point(204, 101);
            EtiquetaIdentificacion.Name = "EtiquetaIdentificacion";
            EtiquetaIdentificacion.Size = new Size(102, 21);
            EtiquetaIdentificacion.TabIndex = 1;
            EtiquetaIdentificacion.Text = "Identificación";
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Font = new Font("Segoe UI", 12F);
            EtiquetaNombre.Location = new Point(204, 146);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(68, 21);
            EtiquetaNombre.TabIndex = 2;
            EtiquetaNombre.Text = "Nombre";
            // 
            // EtiquetaPrimerApellido
            // 
            EtiquetaPrimerApellido.AutoSize = true;
            EtiquetaPrimerApellido.Font = new Font("Segoe UI", 12F);
            EtiquetaPrimerApellido.Location = new Point(204, 188);
            EtiquetaPrimerApellido.Name = "EtiquetaPrimerApellido";
            EtiquetaPrimerApellido.Size = new Size(118, 21);
            EtiquetaPrimerApellido.TabIndex = 3;
            EtiquetaPrimerApellido.Text = "Primer Apellido";
            // 
            // EtiquetaSegundoApellido
            // 
            EtiquetaSegundoApellido.AutoSize = true;
            EtiquetaSegundoApellido.Font = new Font("Segoe UI", 12F);
            EtiquetaSegundoApellido.Location = new Point(204, 233);
            EtiquetaSegundoApellido.Name = "EtiquetaSegundoApellido";
            EtiquetaSegundoApellido.Size = new Size(133, 21);
            EtiquetaSegundoApellido.TabIndex = 4;
            EtiquetaSegundoApellido.Text = "Segundo Apellido";
            // 
            // EtiquetaFechaNacimiento
            // 
            EtiquetaFechaNacimiento.AutoSize = true;
            EtiquetaFechaNacimiento.Font = new Font("Segoe UI", 12F);
            EtiquetaFechaNacimiento.Location = new Point(204, 281);
            EtiquetaFechaNacimiento.Name = "EtiquetaFechaNacimiento";
            EtiquetaFechaNacimiento.Size = new Size(155, 21);
            EtiquetaFechaNacimiento.TabIndex = 5;
            EtiquetaFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // EtiquetaFechaContratacion
            // 
            EtiquetaFechaContratacion.AutoSize = true;
            EtiquetaFechaContratacion.Font = new Font("Segoe UI", 12F);
            EtiquetaFechaContratacion.Location = new Point(204, 329);
            EtiquetaFechaContratacion.Name = "EtiquetaFechaContratacion";
            EtiquetaFechaContratacion.Size = new Size(164, 21);
            EtiquetaFechaContratacion.TabIndex = 6;
            EtiquetaFechaContratacion.Text = "Fecha de Contratación";
            // 
            // tbIdentificacion
            // 
            tbIdentificacion.Location = new Point(397, 99);
            tbIdentificacion.Name = "tbIdentificacion";
            tbIdentificacion.PlaceholderText = "1234";
            tbIdentificacion.Size = new Size(137, 23);
            tbIdentificacion.TabIndex = 7;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(397, 148);
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "Pepito";
            tbNombre.Size = new Size(137, 23);
            tbNombre.TabIndex = 8;
            // 
            // tbPrimerApellido
            // 
            tbPrimerApellido.Location = new Point(397, 190);
            tbPrimerApellido.Name = "tbPrimerApellido";
            tbPrimerApellido.PlaceholderText = "Valverde";
            tbPrimerApellido.Size = new Size(137, 23);
            tbPrimerApellido.TabIndex = 9;
            // 
            // tbSegundoApellido
            // 
            tbSegundoApellido.Location = new Point(397, 235);
            tbSegundoApellido.Name = "tbSegundoApellido";
            tbSegundoApellido.PlaceholderText = "Mora";
            tbSegundoApellido.Size = new Size(137, 23);
            tbSegundoApellido.TabIndex = 10;
            // 
            // dtPFechaNacimiento
            // 
            dtPFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtPFechaNacimiento.Location = new Point(397, 281);
            dtPFechaNacimiento.MaxDate = DateTime.Now;
            dtPFechaNacimiento.Name = "dtPFechaNacimiento";
            dtPFechaNacimiento.Size = new Size(137, 23);
            dtPFechaNacimiento.TabIndex = 11;
            dtPFechaNacimiento.Value = DateTime.Today;
            // 
            // dtPFechaContratacion
            // 
            dtPFechaContratacion.Format = DateTimePickerFormat.Short;
            dtPFechaContratacion.Location = new Point(397, 328);
            dtPFechaContratacion.MaxDate = DateTime.Now;
            dtPFechaContratacion.Name = "dtPFechaContratacion";
            dtPFechaContratacion.Size = new Size(137, 23);
            dtPFechaContratacion.TabIndex = 12;
            dtPFechaContratacion.Value = DateTime.Today;
            // 
            // btGuardar
            // 
            btGuardar.Font = new Font("Segoe UI", 12F);
            btGuardar.Location = new Point(253, 374);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(87, 34);
            btGuardar.TabIndex = 13;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Font = new Font("Segoe UI", 12F);
            btCancelar.Location = new Point(428, 374);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(87, 34);
            btCancelar.TabIndex = 14;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // FormularioRegistrarAdministradores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btCancelar);
            Controls.Add(btGuardar);
            Controls.Add(dtPFechaContratacion);
            Controls.Add(dtPFechaNacimiento);
            Controls.Add(tbSegundoApellido);
            Controls.Add(tbPrimerApellido);
            Controls.Add(tbNombre);
            Controls.Add(tbIdentificacion);
            Controls.Add(EtiquetaFechaContratacion);
            Controls.Add(EtiquetaFechaNacimiento);
            Controls.Add(EtiquetaSegundoApellido);
            Controls.Add(EtiquetaPrimerApellido);
            Controls.Add(EtiquetaNombre);
            Controls.Add(EtiquetaIdentificacion);
            Controls.Add(EtiquetaTitulo);
            Name = "FormularioRegistrarAdministradores";
            Text = "Registrar Administradores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaTitulo;
        private Label EtiquetaIdentificacion;
        private Label EtiquetaNombre;
        private Label EtiquetaPrimerApellido;
        private Label EtiquetaSegundoApellido;
        private Label EtiquetaFechaNacimiento;
        private Label EtiquetaFechaContratacion;
        private TextBox tbIdentificacion;
        private TextBox tbNombre;
        private TextBox tbPrimerApellido;
        private TextBox tbSegundoApellido;
        private DateTimePicker dtPFechaNacimiento;
        private DateTimePicker dtPFechaContratacion;
        private Button btGuardar;
        private Button btCancelar;
    }
}