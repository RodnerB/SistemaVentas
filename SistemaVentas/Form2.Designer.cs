namespace SistemaVentas
{
    partial class Form2
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
            dgvClientes = new DataGridView();
            lblClientes = new Label();
            lblCodCli = new Label();
            txtCodCli = new TextBox();
            lblNomCli = new Label();
            txtNomCli = new TextBox();
            lblApeCli = new Label();
            txtApeCli = new TextBox();
            lblDirCli = new Label();
            txtDirCli = new TextBox();
            lblSecCli = new Label();
            txtSecCli = new TextBox();
            lblCiuCli = new Label();
            txtCiuCli = new TextBox();
            lblTelCli = new Label();
            txtTelCli = new TextBox();
            lblFax = new Label();
            txtFax = new TextBox();
            lblNumCre = new Label();
            txtNumCre = new TextBox();
            lblBalCli = new Label();
            txtBalCli = new TextBox();
            lblObsCli = new Label();
            txtObsCli = new TextBox();
            btnAgregarCli = new Button();
            btnModificarCli = new Button();
            btnEliminarCli = new Button();
            btnBuscarCli = new Button();
            btnVolverMenuPrincipal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.ColumnHeadersVisible = false;
            dgvClientes.Location = new Point(408, 12);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(535, 484);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(12, 12);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(72, 20);
            lblClientes.TabIndex = 1;
            lblClientes.Text = "CLIENTES";
            // 
            // lblCodCli
            // 
            lblCodCli.AutoSize = true;
            lblCodCli.Location = new Point(12, 39);
            lblCodCli.Name = "lblCodCli";
            lblCodCli.Size = new Size(61, 20);
            lblCodCli.TabIndex = 2;
            lblCodCli.Text = "Código:";
            // 
            // txtCodCli
            // 
            txtCodCli.Location = new Point(79, 32);
            txtCodCli.Name = "txtCodCli";
            txtCodCli.Size = new Size(323, 27);
            txtCodCli.TabIndex = 3;
            // 
            // lblNomCli
            // 
            lblNomCli.AutoSize = true;
            lblNomCli.Location = new Point(12, 72);
            lblNomCli.Name = "lblNomCli";
            lblNomCli.Size = new Size(67, 20);
            lblNomCli.TabIndex = 4;
            lblNomCli.Text = "Nombre:";
            // 
            // txtNomCli
            // 
            txtNomCli.Location = new Point(79, 65);
            txtNomCli.Name = "txtNomCli";
            txtNomCli.Size = new Size(323, 27);
            txtNomCli.TabIndex = 5;
            // 
            // lblApeCli
            // 
            lblApeCli.AutoSize = true;
            lblApeCli.Location = new Point(12, 105);
            lblApeCli.Name = "lblApeCli";
            lblApeCli.Size = new Size(69, 20);
            lblApeCli.TabIndex = 6;
            lblApeCli.Text = "Apellido:";
            // 
            // txtApeCli
            // 
            txtApeCli.Location = new Point(79, 98);
            txtApeCli.Name = "txtApeCli";
            txtApeCli.Size = new Size(323, 27);
            txtApeCli.TabIndex = 7;
            // 
            // lblDirCli
            // 
            lblDirCli.AutoSize = true;
            lblDirCli.Location = new Point(12, 138);
            lblDirCli.Name = "lblDirCli";
            lblDirCli.Size = new Size(75, 20);
            lblDirCli.TabIndex = 8;
            lblDirCli.Text = "Dirección:";
            // 
            // txtDirCli
            // 
            txtDirCli.Location = new Point(93, 131);
            txtDirCli.Name = "txtDirCli";
            txtDirCli.Size = new Size(309, 27);
            txtDirCli.TabIndex = 9;
            // 
            // lblSecCli
            // 
            lblSecCli.AutoSize = true;
            lblSecCli.Location = new Point(12, 171);
            lblSecCli.Name = "lblSecCli";
            lblSecCli.Size = new Size(54, 20);
            lblSecCli.TabIndex = 10;
            lblSecCli.Text = "Sector:";
            // 
            // txtSecCli
            // 
            txtSecCli.Location = new Point(72, 164);
            txtSecCli.Name = "txtSecCli";
            txtSecCli.Size = new Size(330, 27);
            txtSecCli.TabIndex = 11;
            // 
            // lblCiuCli
            // 
            lblCiuCli.AutoSize = true;
            lblCiuCli.Location = new Point(12, 204);
            lblCiuCli.Name = "lblCiuCli";
            lblCiuCli.Size = new Size(59, 20);
            lblCiuCli.TabIndex = 12;
            lblCiuCli.Text = "Ciudad:";
            // 
            // txtCiuCli
            // 
            txtCiuCli.Location = new Point(77, 197);
            txtCiuCli.Name = "txtCiuCli";
            txtCiuCli.Size = new Size(325, 27);
            txtCiuCli.TabIndex = 13;
            // 
            // lblTelCli
            // 
            lblTelCli.AutoSize = true;
            lblTelCli.Location = new Point(12, 237);
            lblTelCli.Name = "lblTelCli";
            lblTelCli.Size = new Size(70, 20);
            lblTelCli.TabIndex = 14;
            lblTelCli.Text = "Teléfono:";
            // 
            // txtTelCli
            // 
            txtTelCli.Location = new Point(88, 230);
            txtTelCli.Name = "txtTelCli";
            txtTelCli.Size = new Size(314, 27);
            txtTelCli.TabIndex = 15;
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.Location = new Point(12, 270);
            lblFax.Name = "lblFax";
            lblFax.Size = new Size(33, 20);
            lblFax.TabIndex = 16;
            lblFax.Text = "Fax:";
            // 
            // txtFax
            // 
            txtFax.Location = new Point(51, 263);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(351, 27);
            txtFax.TabIndex = 17;
            // 
            // lblNumCre
            // 
            lblNumCre.AutoSize = true;
            lblNumCre.Location = new Point(12, 303);
            lblNumCre.Name = "lblNumCre";
            lblNumCre.Size = new Size(125, 20);
            lblNumCre.TabIndex = 18;
            lblNumCre.Text = "Límite de crédito:";
            // 
            // txtNumCre
            // 
            txtNumCre.Location = new Point(143, 296);
            txtNumCre.Name = "txtNumCre";
            txtNumCre.Size = new Size(259, 27);
            txtNumCre.TabIndex = 19;
            // 
            // lblBalCli
            // 
            lblBalCli.AutoSize = true;
            lblBalCli.Location = new Point(12, 336);
            lblBalCli.Name = "lblBalCli";
            lblBalCli.Size = new Size(108, 20);
            lblBalCli.TabIndex = 20;
            lblBalCli.Text = "Balance actual:";
            // 
            // txtBalCli
            // 
            txtBalCli.Location = new Point(126, 329);
            txtBalCli.Name = "txtBalCli";
            txtBalCli.Size = new Size(276, 27);
            txtBalCli.TabIndex = 21;
            // 
            // lblObsCli
            // 
            lblObsCli.AutoSize = true;
            lblObsCli.Location = new Point(12, 369);
            lblObsCli.Name = "lblObsCli";
            lblObsCli.Size = new Size(112, 20);
            lblObsCli.TabIndex = 22;
            lblObsCli.Text = "Observaciones: ";
            // 
            // txtObsCli
            // 
            txtObsCli.Location = new Point(130, 362);
            txtObsCli.Name = "txtObsCli";
            txtObsCli.Size = new Size(272, 27);
            txtObsCli.TabIndex = 23;
            // 
            // btnAgregarCli
            // 
            btnAgregarCli.Location = new Point(12, 432);
            btnAgregarCli.Name = "btnAgregarCli";
            btnAgregarCli.Size = new Size(125, 29);
            btnAgregarCli.TabIndex = 24;
            btnAgregarCli.Text = "Agregar cliente";
            btnAgregarCli.UseVisualStyleBackColor = true;
            // 
            // btnModificarCli
            // 
            btnModificarCli.Location = new Point(143, 432);
            btnModificarCli.Name = "btnModificarCli";
            btnModificarCli.Size = new Size(131, 29);
            btnModificarCli.TabIndex = 25;
            btnModificarCli.Text = "Modificar cliente";
            btnModificarCli.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCli
            // 
            btnEliminarCli.Location = new Point(280, 432);
            btnEliminarCli.Name = "btnEliminarCli";
            btnEliminarCli.Size = new Size(122, 29);
            btnEliminarCli.TabIndex = 26;
            btnEliminarCli.Text = "Eliminar cliente";
            btnEliminarCli.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCli
            // 
            btnBuscarCli.Location = new Point(12, 467);
            btnBuscarCli.Name = "btnBuscarCli";
            btnBuscarCli.Size = new Size(125, 29);
            btnBuscarCli.TabIndex = 27;
            btnBuscarCli.Text = "Buscar cliente";
            btnBuscarCli.UseVisualStyleBackColor = true;
            // 
            // btnVolverMenuPrincipal
            // 
            btnVolverMenuPrincipal.Location = new Point(143, 467);
            btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            btnVolverMenuPrincipal.Size = new Size(259, 29);
            btnVolverMenuPrincipal.TabIndex = 28;
            btnVolverMenuPrincipal.Text = "Volver al menú principal";
            btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            btnVolverMenuPrincipal.Click += btnVolverMenuPrincipal_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 508);
            Controls.Add(btnVolverMenuPrincipal);
            Controls.Add(btnBuscarCli);
            Controls.Add(btnEliminarCli);
            Controls.Add(btnModificarCli);
            Controls.Add(btnAgregarCli);
            Controls.Add(txtObsCli);
            Controls.Add(lblObsCli);
            Controls.Add(txtBalCli);
            Controls.Add(lblBalCli);
            Controls.Add(txtNumCre);
            Controls.Add(lblNumCre);
            Controls.Add(txtFax);
            Controls.Add(lblFax);
            Controls.Add(txtTelCli);
            Controls.Add(lblTelCli);
            Controls.Add(txtCiuCli);
            Controls.Add(lblCiuCli);
            Controls.Add(txtSecCli);
            Controls.Add(lblSecCli);
            Controls.Add(txtDirCli);
            Controls.Add(lblDirCli);
            Controls.Add(txtApeCli);
            Controls.Add(lblApeCli);
            Controls.Add(txtNomCli);
            Controls.Add(lblNomCli);
            Controls.Add(txtCodCli);
            Controls.Add(lblCodCli);
            Controls.Add(lblClientes);
            Controls.Add(dgvClientes);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private Label lblClientes;
        private Label lblCodCli;
        private TextBox txtCodCli;
        private Label lblNomCli;
        private TextBox txtNomCli;
        private Label lblApeCli;
        private TextBox txtApeCli;
        private Label lblDirCli;
        private TextBox txtDirCli;
        private Label lblSecCli;
        private TextBox txtSecCli;
        private Label lblCiuCli;
        private TextBox txtCiuCli;
        private Label lblTelCli;
        private TextBox txtTelCli;
        private Label lblFax;
        private TextBox txtFax;
        private Label lblNumCre;
        private TextBox txtNumCre;
        private Label lblBalCli;
        private TextBox txtBalCli;
        private Label lblObsCli;
        private TextBox txtObsCli;
        private Button btnAgregarCli;
        private Button btnModificarCli;
        private Button btnEliminarCli;
        private Button btnBuscarCli;
        private Button btnVolverMenuPrincipal;
    }
}