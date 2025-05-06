/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaPresentacion
{
    partial class FormularioRegistrarTiendas
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
            EtiquetaNombre = new Label();
            EtiquetaAdministrador = new Label();
            EtiquetaDireccion = new Label();
            EtiquetaTelefono = new Label();
            EtiquetaActiva = new Label();
            tbNombre = new TextBox();
            tbDireccion = new TextBox();
            cbAdministrador = new ComboBox();
            cbActiva = new ComboBox();
            btGuardar = new Button();
            btCancelar = new Button();
            mtbTelefono = new MaskedTextBox();
            SuspendLayout();
            // 
            // EtiquetaTitulo
            // 
            EtiquetaTitulo.AutoSize = true;
            EtiquetaTitulo.Font = new Font("Segoe UI", 16F);
            EtiquetaTitulo.Location = new Point(284, 45);
            EtiquetaTitulo.Name = "EtiquetaTitulo";
            EtiquetaTitulo.Size = new Size(178, 30);
            EtiquetaTitulo.TabIndex = 0;
            EtiquetaTitulo.Text = "Registrar Tiendas";
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Font = new Font("Segoe UI", 12F);
            EtiquetaNombre.Location = new Point(252, 121);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(68, 21);
            EtiquetaNombre.TabIndex = 2;
            EtiquetaNombre.Text = "Nombre";
            // 
            // EtiquetaAdministrador
            // 
            EtiquetaAdministrador.AutoSize = true;
            EtiquetaAdministrador.Font = new Font("Segoe UI", 12F);
            EtiquetaAdministrador.Location = new Point(252, 159);
            EtiquetaAdministrador.Name = "EtiquetaAdministrador";
            EtiquetaAdministrador.Size = new Size(110, 21);
            EtiquetaAdministrador.TabIndex = 3;
            EtiquetaAdministrador.Text = "Administrador";
            // 
            // EtiquetaDireccion
            // 
            EtiquetaDireccion.AutoSize = true;
            EtiquetaDireccion.Font = new Font("Segoe UI", 12F);
            EtiquetaDireccion.Location = new Point(252, 197);
            EtiquetaDireccion.Name = "EtiquetaDireccion";
            EtiquetaDireccion.Size = new Size(75, 21);
            EtiquetaDireccion.TabIndex = 4;
            EtiquetaDireccion.Text = "Dirección";
            // 
            // EtiquetaTelefono
            // 
            EtiquetaTelefono.AutoSize = true;
            EtiquetaTelefono.Font = new Font("Segoe UI", 12F);
            EtiquetaTelefono.Location = new Point(252, 238);
            EtiquetaTelefono.Name = "EtiquetaTelefono";
            EtiquetaTelefono.Size = new Size(68, 21);
            EtiquetaTelefono.TabIndex = 5;
            EtiquetaTelefono.Text = "Teléfono";
            // 
            // EtiquetaActiva
            // 
            EtiquetaActiva.AutoSize = true;
            EtiquetaActiva.Font = new Font("Segoe UI", 12F);
            EtiquetaActiva.Location = new Point(252, 275);
            EtiquetaActiva.Name = "EtiquetaActiva";
            EtiquetaActiva.Size = new Size(52, 21);
            EtiquetaActiva.TabIndex = 6;
            EtiquetaActiva.Text = "Activa";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(390, 123);
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "Sucursal Escazú";
            tbNombre.Size = new Size(140, 23);
            tbNombre.TabIndex = 8;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(390, 199);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.PlaceholderText = "100 M Norte de la Iglesia de Escazú";
            tbDireccion.Size = new Size(140, 23);
            tbDireccion.TabIndex = 9;
            // 
            // cbAdministrador
            // 
            cbAdministrador.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAdministrador.FormattingEnabled = true;
            cbAdministrador.Location = new Point(390, 161);
            cbAdministrador.Name = "cbAdministrador";
            cbAdministrador.Size = new Size(140, 23);
            cbAdministrador.TabIndex = 11;
            // 
            // cbActiva
            // 
            cbActiva.DropDownStyle = ComboBoxStyle.DropDownList;
            cbActiva.FormattingEnabled = true;
            cbActiva.Items.AddRange(new object[] { "Sí", "No" });
            cbActiva.Location = new Point(390, 277);
            cbActiva.Name = "cbActiva";
            cbActiva.Size = new Size(140, 23);
            cbActiva.TabIndex = 12;
            // 
            // btGuardar
            // 
            btGuardar.Font = new Font("Segoe UI", 12F);
            btGuardar.Location = new Point(252, 342);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(83, 35);
            btGuardar.TabIndex = 13;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Font = new Font("Segoe UI", 12F);
            btCancelar.Location = new Point(447, 342);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(83, 35);
            btCancelar.TabIndex = 14;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // mtbTelefono
            // 
            mtbTelefono.Location = new Point(390, 240);
            mtbTelefono.Mask = "00000000";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(140, 23);
            mtbTelefono.TabIndex = 15;
            // 
            // FormularioRegistrarTiendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mtbTelefono);
            Controls.Add(btCancelar);
            Controls.Add(btGuardar);
            Controls.Add(cbActiva);
            Controls.Add(cbAdministrador);
            Controls.Add(tbDireccion);
            Controls.Add(tbNombre);
            Controls.Add(EtiquetaActiva);
            Controls.Add(EtiquetaTelefono);
            Controls.Add(EtiquetaDireccion);
            Controls.Add(EtiquetaAdministrador);
            Controls.Add(EtiquetaNombre);
            Controls.Add(EtiquetaTitulo);
            Name = "FormularioRegistrarTiendas";
            Text = "Registrar Tiendas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaTitulo;
        private Label EtiquetaNombre;
        private Label EtiquetaAdministrador;
        private Label EtiquetaDireccion;
        private Label EtiquetaTelefono;
        private Label EtiquetaActiva;
        private TextBox tbNombre;
        private TextBox tbDireccion;
        private ComboBox cbAdministrador;
        private ComboBox cbActiva;
        private Button btGuardar;
        private Button btCancelar;
        private MaskedTextBox mtbTelefono;
    }
}