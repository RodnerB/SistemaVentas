namespace SistemaVentas
{
    partial class Form7
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
            lblConfiguracion = new Label();
            lblEmpresa = new Label();
            txtEmpresa = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblFax = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnVolverMenuPrincipal = new Button();
            txtFax = new TextBox();
            SuspendLayout();
            // 
            // lblConfiguracion
            // 
            lblConfiguracion.AutoSize = true;
            lblConfiguracion.Location = new Point(12, 9);
            lblConfiguracion.Name = "lblConfiguracion";
            lblConfiguracion.Size = new Size(125, 20);
            lblConfiguracion.TabIndex = 0;
            lblConfiguracion.Text = "CONFIGURACIÓN";
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(121, 122);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(69, 20);
            lblEmpresa.TabIndex = 1;
            lblEmpresa.Text = "Empresa:";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(196, 115);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(322, 27);
            txtEmpresa.TabIndex = 2;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(121, 155);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 3;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(202, 148);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(316, 27);
            txtDireccion.TabIndex = 4;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(121, 188);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(202, 181);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(316, 27);
            txtTelefono.TabIndex = 6;
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.Location = new Point(121, 221);
            lblFax.Name = "lblFax";
            lblFax.Size = new Size(33, 20);
            lblFax.TabIndex = 7;
            lblFax.Text = "Fax:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(121, 254);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(135, 20);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Correo electrónico:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(262, 247);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 27);
            txtEmail.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(121, 320);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(203, 29);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(330, 320);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(188, 29);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnVolverMenuPrincipal
            // 
            btnVolverMenuPrincipal.Location = new Point(121, 355);
            btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            btnVolverMenuPrincipal.Size = new Size(397, 29);
            btnVolverMenuPrincipal.TabIndex = 12;
            btnVolverMenuPrincipal.Text = "Volver al menú principal";
            btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            btnVolverMenuPrincipal.Click += btnVolverMenuPrincipal_Click;
            // 
            // txtFax
            // 
            txtFax.Location = new Point(160, 214);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(358, 27);
            txtFax.TabIndex = 13;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 508);
            Controls.Add(txtFax);
            Controls.Add(btnVolverMenuPrincipal);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblFax);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtEmpresa);
            Controls.Add(lblEmpresa);
            Controls.Add(lblConfiguracion);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form7";
            Text = "Configuración";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConfiguracion;
        private Label lblEmpresa;
        private TextBox txtEmpresa;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblFax;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnVolverMenuPrincipal;
        private TextBox txtFax;
    }
}