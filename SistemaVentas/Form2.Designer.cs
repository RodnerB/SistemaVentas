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
            inpCodCliente = new TextBox();
            lblNomCli = new Label();
            inpNomCliente = new TextBox();
            lblApeCli = new Label();
            inpApeCliente = new TextBox();
            lblDirCli = new Label();
            inpDirCliente = new TextBox();
            lblSecCli = new Label();
            inpSecCliente = new TextBox();
            lblCiuCli = new Label();
            inpCiuCliente = new TextBox();
            lblTelCli = new Label();
            inpTelCliente = new TextBox();
            lblFax = new Label();
            inpFaxCliente = new TextBox();
            lblNumCre = new Label();
            inpCredCliente = new TextBox();
            lblBalCli = new Label();
            inpBalCliente = new TextBox();
            lblObsCli = new Label();
            inpObsCliente = new TextBox();
            btnAgregarCliente = new Button();
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
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(357, 9);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(468, 363);
            dgvClientes.TabIndex = 0;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(10, 9);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(58, 15);
            lblClientes.TabIndex = 1;
            lblClientes.Text = "CLIENTES";
            // 
            // lblCodCli
            // 
            lblCodCli.AutoSize = true;
            lblCodCli.Location = new Point(10, 29);
            lblCodCli.Name = "lblCodCli";
            lblCodCli.Size = new Size(49, 15);
            lblCodCli.TabIndex = 2;
            lblCodCli.Text = "Código:";
            // 
            // inpCodCliente
            // 
            inpCodCliente.Location = new Point(69, 24);
            inpCodCliente.Margin = new Padding(3, 2, 3, 2);
            inpCodCliente.Name = "inpCodCliente";
            inpCodCliente.Size = new Size(283, 23);
            inpCodCliente.TabIndex = 3;
            inpCodCliente.KeyDown += EventoTeclaPresionada;
            // 
            // lblNomCli
            // 
            lblNomCli.AutoSize = true;
            lblNomCli.Location = new Point(10, 54);
            lblNomCli.Name = "lblNomCli";
            lblNomCli.Size = new Size(54, 15);
            lblNomCli.TabIndex = 4;
            lblNomCli.Text = "Nombre:";
            // 
            // inpNomCliente
            // 
            inpNomCliente.Location = new Point(69, 49);
            inpNomCliente.Margin = new Padding(3, 2, 3, 2);
            inpNomCliente.Name = "inpNomCliente";
            inpNomCliente.Size = new Size(283, 23);
            inpNomCliente.TabIndex = 5;
            // 
            // lblApeCli
            // 
            lblApeCli.AutoSize = true;
            lblApeCli.Location = new Point(10, 79);
            lblApeCli.Name = "lblApeCli";
            lblApeCli.Size = new Size(54, 15);
            lblApeCli.TabIndex = 6;
            lblApeCli.Text = "Apellido:";
            // 
            // inpApeCliente
            // 
            inpApeCliente.Location = new Point(69, 74);
            inpApeCliente.Margin = new Padding(3, 2, 3, 2);
            inpApeCliente.Name = "inpApeCliente";
            inpApeCliente.Size = new Size(283, 23);
            inpApeCliente.TabIndex = 7;
            // 
            // lblDirCli
            // 
            lblDirCli.AutoSize = true;
            lblDirCli.Location = new Point(10, 104);
            lblDirCli.Name = "lblDirCli";
            lblDirCli.Size = new Size(60, 15);
            lblDirCli.TabIndex = 8;
            lblDirCli.Text = "Dirección:";
            // 
            // inpDirCliente
            // 
            inpDirCliente.Location = new Point(81, 98);
            inpDirCliente.Margin = new Padding(3, 2, 3, 2);
            inpDirCliente.Name = "inpDirCliente";
            inpDirCliente.Size = new Size(271, 23);
            inpDirCliente.TabIndex = 9;
            // 
            // lblSecCli
            // 
            lblSecCli.AutoSize = true;
            lblSecCli.Location = new Point(10, 128);
            lblSecCli.Name = "lblSecCli";
            lblSecCli.Size = new Size(43, 15);
            lblSecCli.TabIndex = 10;
            lblSecCli.Text = "Sector:";
            // 
            // inpSecCliente
            // 
            inpSecCliente.Location = new Point(63, 123);
            inpSecCliente.Margin = new Padding(3, 2, 3, 2);
            inpSecCliente.Name = "inpSecCliente";
            inpSecCliente.Size = new Size(289, 23);
            inpSecCliente.TabIndex = 11;
            // 
            // lblCiuCli
            // 
            lblCiuCli.AutoSize = true;
            lblCiuCli.Location = new Point(10, 153);
            lblCiuCli.Name = "lblCiuCli";
            lblCiuCli.Size = new Size(48, 15);
            lblCiuCli.TabIndex = 12;
            lblCiuCli.Text = "Ciudad:";
            // 
            // inpCiuCliente
            // 
            inpCiuCliente.Location = new Point(67, 148);
            inpCiuCliente.Margin = new Padding(3, 2, 3, 2);
            inpCiuCliente.Name = "inpCiuCliente";
            inpCiuCliente.Size = new Size(285, 23);
            inpCiuCliente.TabIndex = 13;
            // 
            // lblTelCli
            // 
            lblTelCli.AutoSize = true;
            lblTelCli.Location = new Point(10, 178);
            lblTelCli.Name = "lblTelCli";
            lblTelCli.Size = new Size(56, 15);
            lblTelCli.TabIndex = 14;
            lblTelCli.Text = "Teléfono:";
            // 
            // inpTelCliente
            // 
            inpTelCliente.Location = new Point(77, 172);
            inpTelCliente.Margin = new Padding(3, 2, 3, 2);
            inpTelCliente.Name = "inpTelCliente";
            inpTelCliente.Size = new Size(275, 23);
            inpTelCliente.TabIndex = 15;
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.Location = new Point(10, 202);
            lblFax.Name = "lblFax";
            lblFax.Size = new Size(27, 15);
            lblFax.TabIndex = 16;
            lblFax.Text = "Fax:";
            // 
            // inpFaxCliente
            // 
            inpFaxCliente.Location = new Point(45, 197);
            inpFaxCliente.Margin = new Padding(3, 2, 3, 2);
            inpFaxCliente.Name = "inpFaxCliente";
            inpFaxCliente.Size = new Size(308, 23);
            inpFaxCliente.TabIndex = 17;
            // 
            // lblNumCre
            // 
            lblNumCre.AutoSize = true;
            lblNumCre.Location = new Point(10, 227);
            lblNumCre.Name = "lblNumCre";
            lblNumCre.Size = new Size(99, 15);
            lblNumCre.TabIndex = 18;
            lblNumCre.Text = "Límite de crédito:";
            // 
            // inpCredCliente
            // 
            inpCredCliente.Location = new Point(125, 222);
            inpCredCliente.Margin = new Padding(3, 2, 3, 2);
            inpCredCliente.Name = "inpCredCliente";
            inpCredCliente.Size = new Size(227, 23);
            inpCredCliente.TabIndex = 19;
            // 
            // lblBalCli
            // 
            lblBalCli.AutoSize = true;
            lblBalCli.Location = new Point(10, 252);
            lblBalCli.Name = "lblBalCli";
            lblBalCli.Size = new Size(86, 15);
            lblBalCli.TabIndex = 20;
            lblBalCli.Text = "Balance actual:";
            // 
            // inpBalCliente
            // 
            inpBalCliente.Location = new Point(110, 247);
            inpBalCliente.Margin = new Padding(3, 2, 3, 2);
            inpBalCliente.Name = "inpBalCliente";
            inpBalCliente.Size = new Size(242, 23);
            inpBalCliente.TabIndex = 21;
            // 
            // lblObsCli
            // 
            lblObsCli.AutoSize = true;
            lblObsCli.Location = new Point(10, 277);
            lblObsCli.Name = "lblObsCli";
            lblObsCli.Size = new Size(90, 15);
            lblObsCli.TabIndex = 22;
            lblObsCli.Text = "Observaciones: ";
            // 
            // inpObsCliente
            // 
            inpObsCliente.Location = new Point(114, 272);
            inpObsCliente.Margin = new Padding(3, 2, 3, 2);
            inpObsCliente.Name = "inpObsCliente";
            inpObsCliente.Size = new Size(238, 23);
            inpObsCliente.TabIndex = 23;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(10, 324);
            btnAgregarCliente.Margin = new Padding(3, 2, 3, 2);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(109, 22);
            btnAgregarCliente.TabIndex = 24;
            btnAgregarCliente.Text = "Agregar cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnModificarCli
            // 
            btnModificarCli.Location = new Point(125, 324);
            btnModificarCli.Margin = new Padding(3, 2, 3, 2);
            btnModificarCli.Name = "btnModificarCli";
            btnModificarCli.Size = new Size(115, 22);
            btnModificarCli.TabIndex = 25;
            btnModificarCli.Text = "Modificar cliente";
            btnModificarCli.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCli
            // 
            btnEliminarCli.Location = new Point(245, 324);
            btnEliminarCli.Margin = new Padding(3, 2, 3, 2);
            btnEliminarCli.Name = "btnEliminarCli";
            btnEliminarCli.Size = new Size(107, 22);
            btnEliminarCli.TabIndex = 26;
            btnEliminarCli.Text = "Eliminar cliente";
            btnEliminarCli.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCli
            // 
            btnBuscarCli.Location = new Point(10, 350);
            btnBuscarCli.Margin = new Padding(3, 2, 3, 2);
            btnBuscarCli.Name = "btnBuscarCli";
            btnBuscarCli.Size = new Size(109, 22);
            btnBuscarCli.TabIndex = 27;
            btnBuscarCli.Text = "Buscar cliente";
            btnBuscarCli.UseVisualStyleBackColor = true;
            // 
            // btnVolverMenuPrincipal
            // 
            btnVolverMenuPrincipal.Location = new Point(125, 350);
            btnVolverMenuPrincipal.Margin = new Padding(3, 2, 3, 2);
            btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            btnVolverMenuPrincipal.Size = new Size(227, 22);
            btnVolverMenuPrincipal.TabIndex = 28;
            btnVolverMenuPrincipal.Text = "Volver al menú principal";
            btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            btnVolverMenuPrincipal.Click += btnVolverMenuPrincipal_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 381);
            Controls.Add(btnVolverMenuPrincipal);
            Controls.Add(btnBuscarCli);
            Controls.Add(btnEliminarCli);
            Controls.Add(btnModificarCli);
            Controls.Add(btnAgregarCliente);
            Controls.Add(inpObsCliente);
            Controls.Add(lblObsCli);
            Controls.Add(inpBalCliente);
            Controls.Add(lblBalCli);
            Controls.Add(inpCredCliente);
            Controls.Add(lblNumCre);
            Controls.Add(inpFaxCliente);
            Controls.Add(lblFax);
            Controls.Add(inpTelCliente);
            Controls.Add(lblTelCli);
            Controls.Add(inpCiuCliente);
            Controls.Add(lblCiuCli);
            Controls.Add(inpSecCliente);
            Controls.Add(lblSecCli);
            Controls.Add(inpDirCliente);
            Controls.Add(lblDirCli);
            Controls.Add(inpApeCliente);
            Controls.Add(lblApeCli);
            Controls.Add(inpNomCliente);
            Controls.Add(lblNomCli);
            Controls.Add(inpCodCliente);
            Controls.Add(lblCodCli);
            Controls.Add(lblClientes);
            Controls.Add(dgvClientes);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox inpCodCliente;
        private Label lblNomCli;
        private TextBox inpNomCliente;
        private Label lblApeCli;
        private TextBox inpApeCliente;
        private Label lblDirCli;
        private TextBox inpDirCliente;
        private Label lblSecCli;
        private TextBox inpSecCliente;
        private Label lblCiuCli;
        private TextBox inpCiuCliente;
        private Label lblTelCli;
        private TextBox inpTelCliente;
        private Label lblFax;
        private TextBox inpFaxCliente;
        private Label lblNumCre;
        private TextBox inpCredCliente;
        private Label lblBalCli;
        private TextBox inpBalCliente;
        private Label lblObsCli;
        private TextBox inpObsCliente;
        private Button btnAgregarCliente;
        private Button btnModificarCli;
        private Button btnEliminarCli;
        private Button btnBuscarCli;
        private Button btnVolverMenuPrincipal;
    }
}