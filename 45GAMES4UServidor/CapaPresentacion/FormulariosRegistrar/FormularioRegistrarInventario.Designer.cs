/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaPresentacion
{
    partial class FormularioRegistrarInventario
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
            EtiquetaTienda = new Label();
            EtiquetaVideojuego = new Label();
            EtiquetaExistencias = new Label();
            cbTienda = new ComboBox();
            tbExistencias = new TextBox();
            btGuardar = new Button();
            btCancelar = new Button();
            dgVVideojuegosFisicos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgVVideojuegosFisicos).BeginInit();
            SuspendLayout();
            // 
            // EtiquetaTitulo
            // 
            EtiquetaTitulo.AutoSize = true;
            EtiquetaTitulo.Font = new Font("Segoe UI", 16F);
            EtiquetaTitulo.Location = new Point(281, 54);
            EtiquetaTitulo.Name = "EtiquetaTitulo";
            EtiquetaTitulo.Size = new Size(201, 30);
            EtiquetaTitulo.TabIndex = 0;
            EtiquetaTitulo.Text = "Registrar Inventario";
            // 
            // EtiquetaTienda
            // 
            EtiquetaTienda.AutoSize = true;
            EtiquetaTienda.Font = new Font("Segoe UI", 12F);
            EtiquetaTienda.Location = new Point(26, 94);
            EtiquetaTienda.Name = "EtiquetaTienda";
            EtiquetaTienda.Size = new Size(56, 21);
            EtiquetaTienda.TabIndex = 1;
            EtiquetaTienda.Text = "Tienda";
            // 
            // EtiquetaVideojuego
            // 
            EtiquetaVideojuego.AutoSize = true;
            EtiquetaVideojuego.Font = new Font("Segoe UI", 12F);
            EtiquetaVideojuego.Location = new Point(26, 131);
            EtiquetaVideojuego.Name = "EtiquetaVideojuego";
            EtiquetaVideojuego.Size = new Size(89, 21);
            EtiquetaVideojuego.TabIndex = 2;
            EtiquetaVideojuego.Text = "Videojuego";
            // 
            // EtiquetaExistencias
            // 
            EtiquetaExistencias.AutoSize = true;
            EtiquetaExistencias.Font = new Font("Segoe UI", 12F);
            EtiquetaExistencias.Location = new Point(291, 94);
            EtiquetaExistencias.Name = "EtiquetaExistencias";
            EtiquetaExistencias.Size = new Size(84, 21);
            EtiquetaExistencias.TabIndex = 3;
            EtiquetaExistencias.Text = "Existencias";
            // 
            // cbTienda
            // 
            cbTienda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTienda.FormattingEnabled = true;
            cbTienda.Location = new Point(99, 96);
            cbTienda.Name = "cbTienda";
            cbTienda.Size = new Size(163, 23);
            cbTienda.TabIndex = 4;
            // 
            // tbExistencias
            // 
            tbExistencias.Location = new Point(414, 96);
            tbExistencias.Name = "tbExistencias";
            tbExistencias.PlaceholderText = "7";
            tbExistencias.Size = new Size(167, 23);
            tbExistencias.TabIndex = 6;
            // 
            // btGuardar
            // 
            btGuardar.Font = new Font("Segoe UI", 12F);
            btGuardar.Location = new Point(251, 404);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(84, 34);
            btGuardar.TabIndex = 7;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Font = new Font("Segoe UI", 12F);
            btCancelar.Location = new Point(457, 404);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(84, 34);
            btCancelar.TabIndex = 8;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // dgVVideojuegosFisicos
            // 
            dgVVideojuegosFisicos.AllowUserToAddRows = false;
            dgVVideojuegosFisicos.AllowUserToDeleteRows = false;
            dgVVideojuegosFisicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVVideojuegosFisicos.Location = new Point(26, 162);
            dgVVideojuegosFisicos.Name = "dgVVideojuegosFisicos";
            dgVVideojuegosFisicos.ReadOnly = true;
            dgVVideojuegosFisicos.Size = new Size(762, 236);
            dgVVideojuegosFisicos.TabIndex = 9;
            dgVVideojuegosFisicos.MultiSelect = true;
            dgVVideojuegosFisicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // FormularioRegistrarInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgVVideojuegosFisicos);
            Controls.Add(btCancelar);
            Controls.Add(btGuardar);
            Controls.Add(tbExistencias);
            Controls.Add(cbTienda);
            Controls.Add(EtiquetaExistencias);
            Controls.Add(EtiquetaVideojuego);
            Controls.Add(EtiquetaTienda);
            Controls.Add(EtiquetaTitulo);
            Name = "FormularioRegistrarInventario";
            Text = "Registrar Inventario";
            ((System.ComponentModel.ISupportInitialize)dgVVideojuegosFisicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaTitulo;
        private Label EtiquetaTienda;
        private Label EtiquetaVideojuego;
        private Label EtiquetaExistencias;
        private ComboBox cbTienda;
        private TextBox tbExistencias;
        private Button btGuardar;
        private Button btCancelar;
        private DataGridView dgVVideojuegosFisicos;
    }
}