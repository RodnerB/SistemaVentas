namespace SistemaVentas
{
    partial class MenuClientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            btnEliminarCli = new Button();
            btnBuscarCli = new Button();
            btnVolverMenuPrincipal = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(465, 40);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(1380, 484);
            dgvClientes.TabIndex = 0;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(205, 6);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(72, 20);
            lblClientes.TabIndex = 1;
            lblClientes.Text = "CLIENTES";
            // 
            // lblCodCli
            // 
            lblCodCli.AutoSize = true;
            lblCodCli.Location = new Point(11, 39);
            lblCodCli.Name = "lblCodCli";
            lblCodCli.Size = new Size(61, 20);
            lblCodCli.TabIndex = 2;
            lblCodCli.Text = "Código:";
            // 
            // inpCodCliente
            // 
            inpCodCliente.Location = new Point(79, 32);
            inpCodCliente.Name = "inpCodCliente";
            inpCodCliente.Size = new Size(323, 27);
            inpCodCliente.TabIndex = 3;
            // 
            // lblNomCli
            // 
            lblNomCli.AutoSize = true;
            lblNomCli.Location = new Point(11, 72);
            lblNomCli.Name = "lblNomCli";
            lblNomCli.Size = new Size(67, 20);
            lblNomCli.TabIndex = 4;
            lblNomCli.Text = "Nombre:";
            // 
            // inpNomCliente
            // 
            inpNomCliente.Location = new Point(79, 65);
            inpNomCliente.Name = "inpNomCliente";
            inpNomCliente.Size = new Size(323, 27);
            inpNomCliente.TabIndex = 5;
            // 
            // lblApeCli
            // 
            lblApeCli.AutoSize = true;
            lblApeCli.Location = new Point(11, 105);
            lblApeCli.Name = "lblApeCli";
            lblApeCli.Size = new Size(69, 20);
            lblApeCli.TabIndex = 6;
            lblApeCli.Text = "Apellido:";
            // 
            // inpApeCliente
            // 
            inpApeCliente.Location = new Point(79, 99);
            inpApeCliente.Name = "inpApeCliente";
            inpApeCliente.Size = new Size(323, 27);
            inpApeCliente.TabIndex = 7;
            // 
            // lblDirCli
            // 
            lblDirCli.AutoSize = true;
            lblDirCli.Location = new Point(11, 139);
            lblDirCli.Name = "lblDirCli";
            lblDirCli.Size = new Size(75, 20);
            lblDirCli.TabIndex = 8;
            lblDirCli.Text = "Dirección:";
            // 
            // inpDirCliente
            // 
            inpDirCliente.Location = new Point(93, 131);
            inpDirCliente.Name = "inpDirCliente";
            inpDirCliente.Size = new Size(309, 27);
            inpDirCliente.TabIndex = 9;
            // 
            // lblSecCli
            // 
            lblSecCli.AutoSize = true;
            lblSecCli.Location = new Point(11, 171);
            lblSecCli.Name = "lblSecCli";
            lblSecCli.Size = new Size(54, 20);
            lblSecCli.TabIndex = 10;
            lblSecCli.Text = "Sector:";
            // 
            // inpSecCliente
            // 
            inpSecCliente.Location = new Point(72, 164);
            inpSecCliente.Name = "inpSecCliente";
            inpSecCliente.Size = new Size(330, 27);
            inpSecCliente.TabIndex = 11;
            // 
            // lblCiuCli
            // 
            lblCiuCli.AutoSize = true;
            lblCiuCli.Location = new Point(11, 204);
            lblCiuCli.Name = "lblCiuCli";
            lblCiuCli.Size = new Size(59, 20);
            lblCiuCli.TabIndex = 12;
            lblCiuCli.Text = "Ciudad:";
            // 
            // inpCiuCliente
            // 
            inpCiuCliente.Location = new Point(77, 197);
            inpCiuCliente.Name = "inpCiuCliente";
            inpCiuCliente.Size = new Size(325, 27);
            inpCiuCliente.TabIndex = 13;
            // 
            // lblTelCli
            // 
            lblTelCli.AutoSize = true;
            lblTelCli.Location = new Point(11, 237);
            lblTelCli.Name = "lblTelCli";
            lblTelCli.Size = new Size(70, 20);
            lblTelCli.TabIndex = 14;
            lblTelCli.Text = "Teléfono:";
            // 
            // inpTelCliente
            // 
            inpTelCliente.Location = new Point(88, 229);
            inpTelCliente.Name = "inpTelCliente";
            inpTelCliente.Size = new Size(314, 27);
            inpTelCliente.TabIndex = 15;
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.Location = new Point(11, 269);
            lblFax.Name = "lblFax";
            lblFax.Size = new Size(33, 20);
            lblFax.TabIndex = 16;
            lblFax.Text = "Fax:";
            // 
            // inpFaxCliente
            // 
            inpFaxCliente.Location = new Point(51, 263);
            inpFaxCliente.Name = "inpFaxCliente";
            inpFaxCliente.Size = new Size(351, 27);
            inpFaxCliente.TabIndex = 17;
            // 
            // lblNumCre
            // 
            lblNumCre.AutoSize = true;
            lblNumCre.Location = new Point(11, 303);
            lblNumCre.Name = "lblNumCre";
            lblNumCre.Size = new Size(125, 20);
            lblNumCre.TabIndex = 18;
            lblNumCre.Text = "Límite de crédito:";
            // 
            // inpCredCliente
            // 
            inpCredCliente.Location = new Point(143, 296);
            inpCredCliente.Name = "inpCredCliente";
            inpCredCliente.Size = new Size(259, 27);
            inpCredCliente.TabIndex = 19;
            // 
            // lblBalCli
            // 
            lblBalCli.AutoSize = true;
            lblBalCli.Location = new Point(11, 336);
            lblBalCli.Name = "lblBalCli";
            lblBalCli.Size = new Size(108, 20);
            lblBalCli.TabIndex = 20;
            lblBalCli.Text = "Balance actual:";
            // 
            // inpBalCliente
            // 
            inpBalCliente.Location = new Point(126, 329);
            inpBalCliente.Name = "inpBalCliente";
            inpBalCliente.Size = new Size(276, 27);
            inpBalCliente.TabIndex = 21;
            // 
            // lblObsCli
            // 
            lblObsCli.AutoSize = true;
            lblObsCli.Location = new Point(11, 369);
            lblObsCli.Name = "lblObsCli";
            lblObsCli.Size = new Size(112, 20);
            lblObsCli.TabIndex = 22;
            lblObsCli.Text = "Observaciones: ";
            // 
            // inpObsCliente
            // 
            inpObsCliente.Anchor = AnchorStyles.None;
            inpObsCliente.Location = new Point(89, 413);
            inpObsCliente.Name = "inpObsCliente";
            inpObsCliente.Size = new Size(271, 27);
            inpObsCliente.TabIndex = 23;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Enabled = false;
            btnAgregarCliente.Location = new Point(142, 481);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(125, 29);
            btnAgregarCliente.TabIndex = 24;
            btnAgregarCliente.Text = "Agregar cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnEliminarCli
            // 
            btnEliminarCli.Enabled = false;
            btnEliminarCli.Location = new Point(142, 678);
            btnEliminarCli.Name = "btnEliminarCli";
            btnEliminarCli.Size = new Size(122, 29);
            btnEliminarCli.TabIndex = 26;
            btnEliminarCli.Text = "Eliminar cliente";
            btnEliminarCli.UseVisualStyleBackColor = true;
            btnEliminarCli.Click += btnEliminarCli_Click;
            // 
            // btnBuscarCli
            // 
            btnBuscarCli.Location = new Point(142, 455);
            btnBuscarCli.Name = "btnBuscarCli";
            btnBuscarCli.Size = new Size(125, 29);
            btnBuscarCli.TabIndex = 27;
            btnBuscarCli.Text = "Buscar cliente";
            btnBuscarCli.UseVisualStyleBackColor = true;
            btnBuscarCli.Click += btnBuscarCli_Click;
            // 
            // btnVolverMenuPrincipal
            // 
            btnVolverMenuPrincipal.Anchor = AnchorStyles.None;
            btnVolverMenuPrincipal.Location = new Point(-3, 0);
            btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            btnVolverMenuPrincipal.Size = new Size(259, 29);
            btnVolverMenuPrincipal.TabIndex = 28;
            btnVolverMenuPrincipal.Text = "Volver al menú principal";
            btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            btnVolverMenuPrincipal.Click += BtnVolverMenuPrincipal_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvClientes, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            tableLayoutPanel1.Size = new Size(1848, 759);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblClientes);
            panel1.Controls.Add(btnVolverMenuPrincipal);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 31);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom;
            panel2.Controls.Add(inpObsCliente);
            panel2.Controls.Add(btnEliminarCli);
            panel2.Controls.Add(btnBuscarCli);
            panel2.Controls.Add(btnAgregarCliente);
            panel2.Location = new Point(13, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 716);
            panel2.TabIndex = 2;
            // 
            // MenuClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1848, 759);
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
            Controls.Add(lblNomCli);
            Controls.Add(inpCodCliente);
            Controls.Add(lblCodCli);
            Controls.Add(inpNomCliente);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Button btnEliminarCli;
        private Button btnBuscarCli;
        private Button btnVolverMenuPrincipal;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
    }
}