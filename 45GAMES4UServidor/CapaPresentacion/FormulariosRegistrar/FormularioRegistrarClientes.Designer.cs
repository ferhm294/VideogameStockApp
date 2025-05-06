/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaPresentacion
{
    partial class FormularioRegistrarClientes
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
            EtiquetaJugadorEnLinea = new Label();
            tbIdentificacion = new TextBox();
            tbNombre = new TextBox();
            tbPrimerApellido = new TextBox();
            tbSegundoApellido = new TextBox();
            dtPFechaNacimiento = new DateTimePicker();
            cbJugadorEnLinea = new ComboBox();
            btGuardar = new Button();
            btCancelar = new Button();
            SuspendLayout();
            // 
            // EtiquetaTitulo
            // 
            EtiquetaTitulo.AutoSize = true;
            EtiquetaTitulo.Font = new Font("Segoe UI", 16F);
            EtiquetaTitulo.Location = new Point(303, 59);
            EtiquetaTitulo.Name = "EtiquetaTitulo";
            EtiquetaTitulo.Size = new Size(180, 30);
            EtiquetaTitulo.TabIndex = 0;
            EtiquetaTitulo.Text = "Registrar Clientes";
            // 
            // EtiquetaIdentificacion
            // 
            EtiquetaIdentificacion.AutoSize = true;
            EtiquetaIdentificacion.Font = new Font("Segoe UI", 12F);
            EtiquetaIdentificacion.Location = new Point(226, 118);
            EtiquetaIdentificacion.Name = "EtiquetaIdentificacion";
            EtiquetaIdentificacion.Size = new Size(102, 21);
            EtiquetaIdentificacion.TabIndex = 1;
            EtiquetaIdentificacion.Text = "Identificación";
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Font = new Font("Segoe UI", 12F);
            EtiquetaNombre.Location = new Point(226, 160);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(68, 21);
            EtiquetaNombre.TabIndex = 2;
            EtiquetaNombre.Text = "Nombre";
            // 
            // EtiquetaPrimerApellido
            // 
            EtiquetaPrimerApellido.AutoSize = true;
            EtiquetaPrimerApellido.Font = new Font("Segoe UI", 12F);
            EtiquetaPrimerApellido.Location = new Point(226, 201);
            EtiquetaPrimerApellido.Name = "EtiquetaPrimerApellido";
            EtiquetaPrimerApellido.Size = new Size(118, 21);
            EtiquetaPrimerApellido.TabIndex = 3;
            EtiquetaPrimerApellido.Text = "Primer Apellido";
            // 
            // EtiquetaSegundoApellido
            // 
            EtiquetaSegundoApellido.AutoSize = true;
            EtiquetaSegundoApellido.Font = new Font("Segoe UI", 12F);
            EtiquetaSegundoApellido.Location = new Point(226, 242);
            EtiquetaSegundoApellido.Name = "EtiquetaSegundoApellido";
            EtiquetaSegundoApellido.Size = new Size(133, 21);
            EtiquetaSegundoApellido.TabIndex = 4;
            EtiquetaSegundoApellido.Text = "Segundo Apellido";
            // 
            // EtiquetaFechaNacimiento
            // 
            EtiquetaFechaNacimiento.AutoSize = true;
            EtiquetaFechaNacimiento.Font = new Font("Segoe UI", 12F);
            EtiquetaFechaNacimiento.Location = new Point(226, 284);
            EtiquetaFechaNacimiento.Name = "EtiquetaFechaNacimiento";
            EtiquetaFechaNacimiento.Size = new Size(155, 21);
            EtiquetaFechaNacimiento.TabIndex = 5;
            EtiquetaFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // EtiquetaJugadorEnLinea
            // 
            EtiquetaJugadorEnLinea.AutoSize = true;
            EtiquetaJugadorEnLinea.Font = new Font("Segoe UI", 12F);
            EtiquetaJugadorEnLinea.Location = new Point(226, 326);
            EtiquetaJugadorEnLinea.Name = "EtiquetaJugadorEnLinea";
            EtiquetaJugadorEnLinea.Size = new Size(128, 21);
            EtiquetaJugadorEnLinea.TabIndex = 6;
            EtiquetaJugadorEnLinea.Text = "Jugador En Línea";
            // 
            // tbIdentificacion
            // 
            tbIdentificacion.Location = new Point(405, 116);
            tbIdentificacion.Name = "tbIdentificacion";
            tbIdentificacion.PlaceholderText = "123456789";
            tbIdentificacion.Size = new Size(137, 23);
            tbIdentificacion.TabIndex = 7;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(405, 162);
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "Pepito";
            tbNombre.Size = new Size(137, 23);
            tbNombre.TabIndex = 8;
            // 
            // tbPrimerApellido
            // 
            tbPrimerApellido.Location = new Point(405, 203);
            tbPrimerApellido.Name = "tbPrimerApellido";
            tbPrimerApellido.PlaceholderText = "Valverde";
            tbPrimerApellido.Size = new Size(137, 23);
            tbPrimerApellido.TabIndex = 9;
            // 
            // tbSegundoApellido
            // 
            tbSegundoApellido.Location = new Point(405, 244);
            tbSegundoApellido.Name = "tbSegundoApellido";
            tbSegundoApellido.PlaceholderText = "Mora";
            tbSegundoApellido.Size = new Size(137, 23);
            tbSegundoApellido.TabIndex = 10;
            // 
            // dtPFechaNacimiento
            // 
            dtPFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtPFechaNacimiento.Location = new Point(405, 284);
            dtPFechaNacimiento.MaxDate = DateTime.Now;
            dtPFechaNacimiento.Name = "dtPFechaNacimiento";
            dtPFechaNacimiento.Size = new Size(137, 23);
            dtPFechaNacimiento.TabIndex = 11;
            dtPFechaNacimiento.Value = DateTime.Today;
            // 
            // cbJugadorEnLinea
            // 
            cbJugadorEnLinea.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJugadorEnLinea.FormattingEnabled = true;
            cbJugadorEnLinea.Items.AddRange(new object[] { "Sí", "No" });
            cbJugadorEnLinea.Location = new Point(405, 328);
            cbJugadorEnLinea.Name = "cbJugadorEnLinea";
            cbJugadorEnLinea.Size = new Size(137, 23);
            cbJugadorEnLinea.TabIndex = 12;
            // 
            // btGuardar
            // 
            btGuardar.Font = new Font("Segoe UI", 12F);
            btGuardar.Location = new Point(226, 382);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(75, 34);
            btGuardar.TabIndex = 13;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Font = new Font("Segoe UI", 12F);
            btCancelar.Location = new Point(467, 382);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 34);
            btCancelar.TabIndex = 14;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // FormularioRegistrarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btCancelar);
            Controls.Add(btGuardar);
            Controls.Add(cbJugadorEnLinea);
            Controls.Add(dtPFechaNacimiento);
            Controls.Add(tbSegundoApellido);
            Controls.Add(tbPrimerApellido);
            Controls.Add(tbNombre);
            Controls.Add(tbIdentificacion);
            Controls.Add(EtiquetaJugadorEnLinea);
            Controls.Add(EtiquetaFechaNacimiento);
            Controls.Add(EtiquetaSegundoApellido);
            Controls.Add(EtiquetaPrimerApellido);
            Controls.Add(EtiquetaNombre);
            Controls.Add(EtiquetaIdentificacion);
            Controls.Add(EtiquetaTitulo);
            Name = "FormularioRegistrarClientes";
            Text = "Registrar Clientes";
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
        private Label EtiquetaJugadorEnLinea;
        private TextBox tbIdentificacion;
        private TextBox tbNombre;
        private TextBox tbPrimerApellido;
        private TextBox tbSegundoApellido;
        private DateTimePicker dtPFechaNacimiento;
        private ComboBox cbJugadorEnLinea;
        private Button btGuardar;
        private Button btCancelar;
    }
}