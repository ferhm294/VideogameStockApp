/**
 * UNED I Cuatrimestre 2025
 * Proyecto II: aplicación de administración de inventario para 45GAMES4U
 * Estudiante: Fernando Hernández Murillo
 * Fecha: 06 de Abril de 2025
 */

namespace CapaPresentacion
{
    partial class FormularioServidor
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
            gBInfoServidor = new GroupBox();
            btDesconectar = new Button();
            btConectar = new Button();
            lbEstadoDinamico = new Label();
            lbEstadoEstatico = new Label();
            gBInfoClientes = new GroupBox();
            lBClientesConectados = new ListBox();
            gBBitacora = new GroupBox();
            tbBitacora = new TextBox();
            gBInfoServidor.SuspendLayout();
            gBInfoClientes.SuspendLayout();
            gBBitacora.SuspendLayout();
            SuspendLayout();
            // 
            // gBInfoServidor
            // 
            gBInfoServidor.Controls.Add(btDesconectar);
            gBInfoServidor.Controls.Add(btConectar);
            gBInfoServidor.Controls.Add(lbEstadoDinamico);
            gBInfoServidor.Controls.Add(lbEstadoEstatico);
            gBInfoServidor.Location = new Point(12, 34);
            gBInfoServidor.Name = "gBInfoServidor";
            gBInfoServidor.Size = new Size(776, 111);
            gBInfoServidor.TabIndex = 0;
            gBInfoServidor.TabStop = false;
            gBInfoServidor.Text = "Información del Servidor";
            // 
            // btDesconectar
            // 
            btDesconectar.Location = new Point(397, 51);
            btDesconectar.Name = "btDesconectar";
            btDesconectar.Size = new Size(82, 23);
            btDesconectar.TabIndex = 3;
            btDesconectar.Text = "Desconectar";
            btDesconectar.UseVisualStyleBackColor = true;
            btDesconectar.Click += btDesconectar_Click;
            // 
            // btConectar
            // 
            btConectar.Location = new Point(304, 51);
            btConectar.Name = "btConectar";
            btConectar.Size = new Size(75, 23);
            btConectar.TabIndex = 2;
            btConectar.Text = "Conectar";
            btConectar.UseVisualStyleBackColor = true;
            btConectar.Click += btConectar_Click;
            // 
            // lbEstadoDinamico
            // 
            lbEstadoDinamico.AutoSize = true;
            lbEstadoDinamico.Location = new Point(61, 55);
            lbEstadoDinamico.Name = "lbEstadoDinamico";
            lbEstadoDinamico.Size = new Size(0, 15);
            lbEstadoDinamico.TabIndex = 1;
            // 
            // lbEstadoEstatico
            // 
            lbEstadoEstatico.AutoSize = true;
            lbEstadoEstatico.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbEstadoEstatico.Location = new Point(6, 54);
            lbEstadoEstatico.Name = "lbEstadoEstatico";
            lbEstadoEstatico.Size = new Size(46, 15);
            lbEstadoEstatico.TabIndex = 0;
            lbEstadoEstatico.Text = "Estado:";
            // 
            // gBInfoClientes
            // 
            gBInfoClientes.Controls.Add(lBClientesConectados);
            gBInfoClientes.Location = new Point(12, 151);
            gBInfoClientes.Name = "gBInfoClientes";
            gBInfoClientes.Size = new Size(385, 287);
            gBInfoClientes.TabIndex = 1;
            gBInfoClientes.TabStop = false;
            gBInfoClientes.Text = "Clientes Conectados";
            // 
            // lBClientesConectados
            // 
            lBClientesConectados.FormattingEnabled = true;
            lBClientesConectados.ItemHeight = 15;
            lBClientesConectados.Location = new Point(6, 22);
            lBClientesConectados.Name = "lBClientesConectados";
            lBClientesConectados.Size = new Size(373, 259);
            lBClientesConectados.TabIndex = 0;
            // 
            // gBBitacora
            // 
            gBBitacora.Controls.Add(tbBitacora);
            gBBitacora.Location = new Point(403, 151);
            gBBitacora.Name = "gBBitacora";
            gBBitacora.Size = new Size(385, 287);
            gBBitacora.TabIndex = 2;
            gBBitacora.TabStop = false;
            gBBitacora.Text = "Bitácora";
            // 
            // tbBitacora
            // 
            tbBitacora.Enabled = false;
            tbBitacora.Location = new Point(6, 22);
            tbBitacora.Multiline = true;
            tbBitacora.Name = "tbBitacora";
            tbBitacora.ScrollBars = ScrollBars.Vertical;
            tbBitacora.Size = new Size(373, 259);
            tbBitacora.TabIndex = 0;
            // 
            // FormularioServidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gBBitacora);
            Controls.Add(gBInfoClientes);
            Controls.Add(gBInfoServidor);
            Name = "FormularioServidor";
            Text = "Inicio";
            gBInfoServidor.ResumeLayout(false);
            gBInfoServidor.PerformLayout();
            gBInfoClientes.ResumeLayout(false);
            gBBitacora.ResumeLayout(false);
            gBBitacora.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBInfoServidor;
        private Label lbEstadoEstatico;
        private Label lbEstadoDinamico;
        private GroupBox gBInfoClientes;
        private GroupBox gBBitacora;
        private ListBox lBClientesConectados;
        private TextBox tbBitacora;
        private Button btDesconectar;
        private Button btConectar;
    }
}