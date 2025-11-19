namespace SistemaVentas
{
    partial class MenuConfiguracion
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
            inpEmpresa = new TextBox();
            lblDireccion = new Label();
            inpDireccion = new TextBox();
            lblTelefono = new Label();
            inpTelefono = new TextBox();
            lblFax = new Label();
            lblEmail = new Label();
            inpEmail = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnVolverMenuPrincipal = new Button();
            inpFax = new TextBox();
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
            // inpEmpresa
            // 
            inpEmpresa.Location = new Point(196, 115);
            inpEmpresa.Name = "inpEmpresa";
            inpEmpresa.Size = new Size(322, 27);
            inpEmpresa.TabIndex = 2;
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
            // inpDireccion
            // 
            inpDireccion.Location = new Point(202, 148);
            inpDireccion.Name = "inpDireccion";
            inpDireccion.Size = new Size(316, 27);
            inpDireccion.TabIndex = 4;
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
            // inpTelefono
            // 
            inpTelefono.Location = new Point(202, 181);
            inpTelefono.Name = "inpTelefono";
            inpTelefono.Size = new Size(316, 27);
            inpTelefono.TabIndex = 6;
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
            // inpEmail
            // 
            inpEmail.Location = new Point(262, 247);
            inpEmail.Name = "inpEmail";
            inpEmail.Size = new Size(256, 27);
            inpEmail.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(121, 320);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(203, 29);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
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
            // inpFax
            // 
            inpFax.Location = new Point(160, 214);
            inpFax.Name = "inpFax";
            inpFax.Size = new Size(358, 27);
            inpFax.TabIndex = 13;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 508);
            Controls.Add(inpFax);
            Controls.Add(btnVolverMenuPrincipal);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(inpEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblFax);
            Controls.Add(inpTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(inpDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(inpEmpresa);
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
        private TextBox inpEmpresa;
        private Label lblDireccion;
        private TextBox inpDireccion;
        private Label lblTelefono;
        private TextBox inpTelefono;
        private Label lblFax;
        private Label lblEmail;
        private TextBox inpEmail;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnVolverMenuPrincipal;
        private TextBox inpFax;
    }
}