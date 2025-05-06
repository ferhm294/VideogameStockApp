/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaPresentacion
{
    partial class FormularioConectar
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
            lbIdentificacion = new Label();
            tbIdentificacion = new TextBox();
            btConectar = new Button();
            btCancelar = new Button();
            lbTitulo = new Label();
            SuspendLayout();
            // 
            // lbIdentificacion
            // 
            lbIdentificacion.AutoSize = true;
            lbIdentificacion.Font = new Font("Segoe UI", 12F);
            lbIdentificacion.Location = new Point(264, 155);
            lbIdentificacion.Name = "lbIdentificacion";
            lbIdentificacion.Size = new Size(105, 21);
            lbIdentificacion.TabIndex = 0;
            lbIdentificacion.Text = "Identificacion:";
            // 
            // tbIdentificacion
            // 
            tbIdentificacion.Location = new Point(375, 153);
            tbIdentificacion.Name = "tbIdentificacion";
            tbIdentificacion.Size = new Size(150, 23);
            tbIdentificacion.TabIndex = 1;
            // 
            // btConectar
            // 
            btConectar.Font = new Font("Segoe UI", 12F);
            btConectar.Location = new Point(264, 233);
            btConectar.Name = "btConectar";
            btConectar.Size = new Size(82, 36);
            btConectar.TabIndex = 2;
            btConectar.Text = "Conectar";
            btConectar.UseVisualStyleBackColor = true;
            btConectar.Click += btConectar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Font = new Font("Segoe UI", 12F);
            btCancelar.Location = new Point(441, 233);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(84, 36);
            btCancelar.TabIndex = 3;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 16F);
            lbTitulo.Location = new Point(323, 74);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(164, 30);
            lbTitulo.TabIndex = 5;
            lbTitulo.Text = "Inicio de Sesión";
            // 
            // FormularioConectar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTitulo);
            Controls.Add(btCancelar);
            Controls.Add(btConectar);
            Controls.Add(tbIdentificacion);
            Controls.Add(lbIdentificacion);
            Name = "FormularioConectar";
            Text = "FormularioConectar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbIdentificacion;
        private TextBox tbIdentificacion;
        private Button btConectar;
        private Button btCancelar;
        private Label lbTitulo;
    }
}