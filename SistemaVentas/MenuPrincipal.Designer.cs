namespace SistemaVentas
{
    partial class MenuPrincipal
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
            btnClientes = new Button();
            btnArticulos = new Button();
            btnFacturacion = new Button();
            btnDetalles = new Button();
            btnUnidadesDeMedida = new Button();
            btnConfiguracion = new Button();
            lblSistemaDeFacturacion = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(12, 228);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(198, 29);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnArticulos
            // 
            btnArticulos.Location = new Point(216, 228);
            btnArticulos.Name = "btnArticulos";
            btnArticulos.Size = new Size(198, 29);
            btnArticulos.TabIndex = 1;
            btnArticulos.Text = "Artículos";
            btnArticulos.UseVisualStyleBackColor = true;
            btnArticulos.Click += btnArticulos_Click;
            // 
            // btnFacturacion
            // 
            btnFacturacion.Location = new Point(422, 228);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(198, 29);
            btnFacturacion.TabIndex = 2;
            btnFacturacion.Text = "Facturación";
            btnFacturacion.UseVisualStyleBackColor = true;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(12, 294);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(198, 29);
            btnDetalles.TabIndex = 3;
            btnDetalles.Text = "Detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // btnUnidadesDeMedida
            // 
            btnUnidadesDeMedida.Location = new Point(216, 294);
            btnUnidadesDeMedida.Name = "btnUnidadesDeMedida";
            btnUnidadesDeMedida.Size = new Size(198, 29);
            btnUnidadesDeMedida.TabIndex = 4;
            btnUnidadesDeMedida.Text = "Unidades de medida";
            btnUnidadesDeMedida.UseVisualStyleBackColor = true;
            btnUnidadesDeMedida.Click += btnUnidadesDeMedida_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Location = new Point(422, 294);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(198, 29);
            btnConfiguracion.TabIndex = 5;
            btnConfiguracion.Text = "Configuración";
            btnConfiguracion.UseVisualStyleBackColor = true;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // lblSistemaDeFacturacion
            // 
            lblSistemaDeFacturacion.AutoSize = true;
            lblSistemaDeFacturacion.Location = new Point(222, 134);
            lblSistemaDeFacturacion.Name = "lblSistemaDeFacturacion";
            lblSistemaDeFacturacion.Size = new Size(192, 20);
            lblSistemaDeFacturacion.TabIndex = 6;
            lblSistemaDeFacturacion.Text = "SISTEMA DE FACTURACIÓN";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(216, 356);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(198, 29);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 508);
            Controls.Add(btnSalir);
            Controls.Add(lblSistemaDeFacturacion);
            Controls.Add(btnConfiguracion);
            Controls.Add(btnUnidadesDeMedida);
            Controls.Add(btnDetalles);
            Controls.Add(btnFacturacion);
            Controls.Add(btnArticulos);
            Controls.Add(btnClientes);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClientes;
        private Button btnArticulos;
        private Button btnFacturacion;
        private Button btnDetalles;
        private Button btnUnidadesDeMedida;
        private Button btnConfiguracion;
        private Label lblSistemaDeFacturacion;
        private Button btnSalir;
    }
}