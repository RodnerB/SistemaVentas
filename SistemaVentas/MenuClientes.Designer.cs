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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvClientes = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colSector = new DataGridViewTextBoxColumn();
            colCiudad = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colFax = new DataGridViewTextBoxColumn();
            colLimite = new DataGridViewTextBoxColumn();
            colBalance = new DataGridViewTextBoxColumn();
            colObservaciones = new DataGridViewTextBoxColumn();
            lblClientes = new Label();
            btnVolverMenuPrincipal = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblObsCli = new Label();
            inpBalCliente = new TextBox();
            lblBalCli = new Label();
            inpCredCliente = new TextBox();
            lblNumCre = new Label();
            inpFaxCliente = new TextBox();
            lblFax = new Label();
            inpTelCliente = new TextBox();
            lblTelCli = new Label();
            inpCiuCliente = new TextBox();
            lblCiuCli = new Label();
            inpSecCliente = new TextBox();
            lblSecCli = new Label();
            inpDirCliente = new TextBox();
            lblDirCli = new Label();
            inpApeCliente = new TextBox();
            lblApeCli = new Label();
            inpNomCliente = new TextBox();
            lblNomCli = new Label();
            inpCodCliente = new TextBox();
            inpObsCliente = new TextBox();
            lblCodCli = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnCancelar = new Button();
            btnBuscarCli = new Button();
            btnAgregarCliente = new Button();
            label3 = new Label();
            panel3 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            panel1 = new Panel();
            tableLayoutPanel8 = new TableLayoutPanel();
            picClientes = new PictureBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClientes).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.BackgroundColor = SystemColors.ButtonHighlight;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeight = 35;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNombre, colApellido, colDireccion, colSector, colCiudad, colTelefono, colFax, colLimite, colBalance, colObservaciones });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = SystemColors.HighlightText;
            dgvClientes.Location = new Point(3, 74);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvClientes.Size = new Size(1392, 691);
            dgvClientes.TabIndex = 0;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.MinimumWidth = 6;
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            // 
            // colDireccion
            // 
            colDireccion.HeaderText = "Direccion";
            colDireccion.MinimumWidth = 6;
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            // 
            // colSector
            // 
            colSector.HeaderText = "Sector";
            colSector.MinimumWidth = 6;
            colSector.Name = "colSector";
            colSector.ReadOnly = true;
            // 
            // colCiudad
            // 
            colCiudad.HeaderText = "Ciudad";
            colCiudad.MinimumWidth = 6;
            colCiudad.Name = "colCiudad";
            colCiudad.ReadOnly = true;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Telefono";
            colTelefono.MinimumWidth = 6;
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            // 
            // colFax
            // 
            colFax.HeaderText = "Fax";
            colFax.MinimumWidth = 6;
            colFax.Name = "colFax";
            colFax.ReadOnly = true;
            // 
            // colLimite
            // 
            colLimite.HeaderText = "Limite Credito";
            colLimite.MinimumWidth = 6;
            colLimite.Name = "colLimite";
            colLimite.ReadOnly = true;
            // 
            // colBalance
            // 
            colBalance.HeaderText = "Balance";
            colBalance.MinimumWidth = 6;
            colBalance.Name = "colBalance";
            colBalance.ReadOnly = true;
            // 
            // colObservaciones
            // 
            colObservaciones.HeaderText = "Observaciones";
            colObservaciones.MinimumWidth = 6;
            colObservaciones.Name = "colObservaciones";
            colObservaciones.ReadOnly = true;
            // 
            // lblClientes
            // 
            lblClientes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblClientes.Location = new Point(3, 0);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(219, 29);
            lblClientes.TabIndex = 1;
            lblClientes.Text = "Gestión de Clientes";
            // 
            // btnVolverMenuPrincipal
            // 
            btnVolverMenuPrincipal.Anchor = AnchorStyles.Right;
            btnVolverMenuPrincipal.BackColor = Color.Transparent;
            btnVolverMenuPrincipal.BackgroundImage = Properties.Resources.return_up_back_icon_233992__1_;
            btnVolverMenuPrincipal.Cursor = Cursors.Hand;
            btnVolverMenuPrincipal.FlatAppearance.BorderSize = 0;
            btnVolverMenuPrincipal.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnVolverMenuPrincipal.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnVolverMenuPrincipal.FlatStyle = FlatStyle.Flat;
            btnVolverMenuPrincipal.Location = new Point(12, 16);
            btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            btnVolverMenuPrincipal.Size = new Size(33, 27);
            btnVolverMenuPrincipal.TabIndex = 28;
            btnVolverMenuPrincipal.UseVisualStyleBackColor = false;
            btnVolverMenuPrincipal.Click += BtnVolverMenuPrincipal_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.AliceBlue;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.408092F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.59163F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.00027776F));
            tableLayoutPanel1.Size = new Size(1872, 864);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(tableLayoutPanel5);
            panel2.Location = new Point(15, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 768);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 9.558F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 76.3877F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0542974F));
            tableLayoutPanel5.Size = new Size(437, 768);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(lblObsCli, 0, 20);
            tableLayoutPanel3.Controls.Add(inpBalCliente, 0, 19);
            tableLayoutPanel3.Controls.Add(lblBalCli, 0, 18);
            tableLayoutPanel3.Controls.Add(inpCredCliente, 0, 17);
            tableLayoutPanel3.Controls.Add(lblNumCre, 0, 16);
            tableLayoutPanel3.Controls.Add(inpFaxCliente, 0, 15);
            tableLayoutPanel3.Controls.Add(lblFax, 0, 14);
            tableLayoutPanel3.Controls.Add(inpTelCliente, 0, 13);
            tableLayoutPanel3.Controls.Add(lblTelCli, 0, 12);
            tableLayoutPanel3.Controls.Add(inpCiuCliente, 0, 11);
            tableLayoutPanel3.Controls.Add(lblCiuCli, 0, 10);
            tableLayoutPanel3.Controls.Add(inpSecCliente, 0, 9);
            tableLayoutPanel3.Controls.Add(lblSecCli, 0, 8);
            tableLayoutPanel3.Controls.Add(inpDirCliente, 0, 7);
            tableLayoutPanel3.Controls.Add(lblDirCli, 0, 6);
            tableLayoutPanel3.Controls.Add(inpApeCliente, 0, 5);
            tableLayoutPanel3.Controls.Add(lblApeCli, 0, 4);
            tableLayoutPanel3.Controls.Add(inpNomCliente, 0, 3);
            tableLayoutPanel3.Controls.Add(lblNomCli, 0, 2);
            tableLayoutPanel3.Controls.Add(inpCodCliente, 0, 1);
            tableLayoutPanel3.Controls.Add(inpObsCliente, 0, 21);
            tableLayoutPanel3.Controls.Add(lblCodCli, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 76);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 22;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(431, 580);
            tableLayoutPanel3.TabIndex = 29;
            // 
            // lblObsCli
            // 
            lblObsCli.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblObsCli.AutoSize = true;
            lblObsCli.Location = new Point(3, 530);
            lblObsCli.Name = "lblObsCli";
            lblObsCli.Size = new Size(425, 20);
            lblObsCli.TabIndex = 22;
            lblObsCli.Text = "        Observaciones";
            // 
            // inpBalCliente
            // 
            inpBalCliente.Anchor = AnchorStyles.None;
            inpBalCliente.Location = new Point(34, 500);
            inpBalCliente.Name = "inpBalCliente";
            inpBalCliente.Size = new Size(362, 27);
            inpBalCliente.TabIndex = 21;
            inpBalCliente.KeyPress += ValidarSoloNumerosKeyPress;
            // 
            // lblBalCli
            // 
            lblBalCli.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblBalCli.AutoSize = true;
            lblBalCli.Location = new Point(3, 477);
            lblBalCli.Name = "lblBalCli";
            lblBalCli.Size = new Size(425, 20);
            lblBalCli.TabIndex = 20;
            lblBalCli.Text = "        Balance actual";
            // 
            // inpCredCliente
            // 
            inpCredCliente.Anchor = AnchorStyles.None;
            inpCredCliente.Location = new Point(34, 447);
            inpCredCliente.Name = "inpCredCliente";
            inpCredCliente.Size = new Size(362, 27);
            inpCredCliente.TabIndex = 19;
            inpCredCliente.KeyPress += ValidarSoloNumerosKeyPress;
            // 
            // lblNumCre
            // 
            lblNumCre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNumCre.AutoSize = true;
            lblNumCre.Location = new Point(3, 424);
            lblNumCre.Name = "lblNumCre";
            lblNumCre.Size = new Size(425, 20);
            lblNumCre.TabIndex = 18;
            lblNumCre.Text = "        Límite de crédito";
            // 
            // inpFaxCliente
            // 
            inpFaxCliente.Anchor = AnchorStyles.None;
            inpFaxCliente.Location = new Point(34, 394);
            inpFaxCliente.Name = "inpFaxCliente";
            inpFaxCliente.Size = new Size(362, 27);
            inpFaxCliente.TabIndex = 17;
            // 
            // lblFax
            // 
            lblFax.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblFax.AutoSize = true;
            lblFax.Location = new Point(3, 371);
            lblFax.Name = "lblFax";
            lblFax.Size = new Size(425, 20);
            lblFax.TabIndex = 16;
            lblFax.Text = "        Fax";
            // 
            // inpTelCliente
            // 
            inpTelCliente.Anchor = AnchorStyles.None;
            inpTelCliente.Location = new Point(34, 341);
            inpTelCliente.Name = "inpTelCliente";
            inpTelCliente.Size = new Size(362, 27);
            inpTelCliente.TabIndex = 15;
            // 
            // lblTelCli
            // 
            lblTelCli.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTelCli.AutoSize = true;
            lblTelCli.Location = new Point(3, 318);
            lblTelCli.Name = "lblTelCli";
            lblTelCli.Size = new Size(425, 20);
            lblTelCli.TabIndex = 14;
            lblTelCli.Text = "        Teléfono";
            // 
            // inpCiuCliente
            // 
            inpCiuCliente.Anchor = AnchorStyles.None;
            inpCiuCliente.Location = new Point(34, 288);
            inpCiuCliente.Name = "inpCiuCliente";
            inpCiuCliente.Size = new Size(362, 27);
            inpCiuCliente.TabIndex = 13;
            // 
            // lblCiuCli
            // 
            lblCiuCli.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCiuCli.AutoSize = true;
            lblCiuCli.Location = new Point(3, 265);
            lblCiuCli.Name = "lblCiuCli";
            lblCiuCli.Size = new Size(425, 20);
            lblCiuCli.TabIndex = 12;
            lblCiuCli.Text = "        Ciudad";
            // 
            // inpSecCliente
            // 
            inpSecCliente.Anchor = AnchorStyles.None;
            inpSecCliente.Location = new Point(34, 235);
            inpSecCliente.Name = "inpSecCliente";
            inpSecCliente.Size = new Size(362, 27);
            inpSecCliente.TabIndex = 11;
            // 
            // lblSecCli
            // 
            lblSecCli.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSecCli.AutoSize = true;
            lblSecCli.Location = new Point(3, 212);
            lblSecCli.Name = "lblSecCli";
            lblSecCli.Size = new Size(425, 20);
            lblSecCli.TabIndex = 10;
            lblSecCli.Text = "        Sector";
            // 
            // inpDirCliente
            // 
            inpDirCliente.Anchor = AnchorStyles.None;
            inpDirCliente.Location = new Point(34, 182);
            inpDirCliente.Name = "inpDirCliente";
            inpDirCliente.Size = new Size(362, 27);
            inpDirCliente.TabIndex = 9;
            // 
            // lblDirCli
            // 
            lblDirCli.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDirCli.AutoSize = true;
            lblDirCli.Location = new Point(3, 159);
            lblDirCli.Name = "lblDirCli";
            lblDirCli.Size = new Size(425, 20);
            lblDirCli.TabIndex = 8;
            lblDirCli.Text = "        Dirección";
            // 
            // inpApeCliente
            // 
            inpApeCliente.Anchor = AnchorStyles.None;
            inpApeCliente.Location = new Point(34, 129);
            inpApeCliente.Name = "inpApeCliente";
            inpApeCliente.Size = new Size(362, 27);
            inpApeCliente.TabIndex = 7;
            // 
            // lblApeCli
            // 
            lblApeCli.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblApeCli.AutoSize = true;
            lblApeCli.Location = new Point(3, 106);
            lblApeCli.Name = "lblApeCli";
            lblApeCli.Size = new Size(425, 20);
            lblApeCli.TabIndex = 6;
            lblApeCli.Text = "        Apellido";
            // 
            // inpNomCliente
            // 
            inpNomCliente.Anchor = AnchorStyles.None;
            inpNomCliente.Location = new Point(34, 76);
            inpNomCliente.Name = "inpNomCliente";
            inpNomCliente.Size = new Size(362, 27);
            inpNomCliente.TabIndex = 5;
            // 
            // lblNomCli
            // 
            lblNomCli.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNomCli.AutoSize = true;
            lblNomCli.Location = new Point(3, 53);
            lblNomCli.Name = "lblNomCli";
            lblNomCli.Size = new Size(425, 20);
            lblNomCli.TabIndex = 4;
            lblNomCli.Text = "        Nombre";
            // 
            // inpCodCliente
            // 
            inpCodCliente.Anchor = AnchorStyles.None;
            inpCodCliente.Location = new Point(34, 23);
            inpCodCliente.Name = "inpCodCliente";
            inpCodCliente.Size = new Size(362, 27);
            inpCodCliente.TabIndex = 3;
            // 
            // inpObsCliente
            // 
            inpObsCliente.Anchor = AnchorStyles.Top;
            inpObsCliente.Location = new Point(34, 553);
            inpObsCliente.Name = "inpObsCliente";
            inpObsCliente.Size = new Size(362, 27);
            inpObsCliente.TabIndex = 23;
            // 
            // lblCodCli
            // 
            lblCodCli.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCodCli.AutoSize = true;
            lblCodCli.Location = new Point(3, 0);
            lblCodCli.Name = "lblCodCli";
            lblCodCli.Size = new Size(425, 20);
            lblCodCli.TabIndex = 2;
            lblCodCli.Text = "        Código";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.None;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(btnCancelar, 0, 2);
            tableLayoutPanel6.Controls.Add(btnBuscarCli, 0, 0);
            tableLayoutPanel6.Controls.Add(btnAgregarCliente, 0, 1);
            tableLayoutPanel6.Location = new Point(22, 662);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.Size = new Size(392, 103);
            tableLayoutPanel6.TabIndex = 30;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Enabled = false;
            btnCancelar.FlatAppearance.BorderColor = Color.White;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(3, 71);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(386, 28);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBuscarCli
            // 
            btnBuscarCli.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBuscarCli.BackColor = SystemColors.HotTrack;
            btnBuscarCli.Cursor = Cursors.Hand;
            btnBuscarCli.Enabled = false;
            btnBuscarCli.FlatAppearance.BorderColor = Color.White;
            btnBuscarCli.FlatAppearance.BorderSize = 0;
            btnBuscarCli.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnBuscarCli.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnBuscarCli.FlatStyle = FlatStyle.Flat;
            btnBuscarCli.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarCli.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarCli.Location = new Point(3, 3);
            btnBuscarCli.Name = "btnBuscarCli";
            btnBuscarCli.Size = new Size(386, 28);
            btnBuscarCli.TabIndex = 25;
            btnBuscarCli.Text = "Buscar cliente";
            btnBuscarCli.UseVisualStyleBackColor = false;
            btnBuscarCli.Click += btnBuscarCli_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregarCliente.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarCliente.Cursor = Cursors.Hand;
            btnAgregarCliente.Enabled = false;
            btnAgregarCliente.FlatAppearance.BorderColor = Color.White;
            btnAgregarCliente.FlatAppearance.BorderSize = 0;
            btnAgregarCliente.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnAgregarCliente.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAgregarCliente.FlatStyle = FlatStyle.Flat;
            btnAgregarCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCliente.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarCliente.Location = new Point(3, 37);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(386, 28);
            btnAgregarCliente.TabIndex = 24;
            btnAgregarCliente.Text = "Guardar cliente ";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 13);
            label3.Name = "label3";
            label3.Size = new Size(431, 46);
            label3.TabIndex = 31;
            label3.Text = "Nuevo Cliente";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(tableLayoutPanel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(471, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(1398, 768);
            panel3.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(dgvClientes, 0, 1);
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 9.244792F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 90.75521F));
            tableLayoutPanel4.Size = new Size(1398, 768);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 12);
            label4.Name = "label4";
            label4.Size = new Size(285, 46);
            label4.TabIndex = 1;
            label4.Text = "Lista de Clientes ";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tableLayoutPanel8);
            panel1.Controls.Add(tableLayoutPanel7);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 58);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(picClientes, 0, 0);
            tableLayoutPanel8.Location = new Point(50, 0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(56, 55);
            tableLayoutPanel8.TabIndex = 31;
            // 
            // picClientes
            // 
            picClientes.Anchor = AnchorStyles.Right;
            picClientes.BackColor = Color.Transparent;
            picClientes.BackgroundImage = Properties.Resources.users_people_workers_customers_icon_1242431;
            picClientes.Location = new Point(7, 5);
            picClientes.Name = "picClientes";
            picClientes.Size = new Size(46, 44);
            picClientes.SizeMode = PictureBoxSizeMode.Zoom;
            picClientes.TabIndex = 5;
            picClientes.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(label5, 0, 1);
            tableLayoutPanel7.Controls.Add(lblClientes, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Right;
            tableLayoutPanel7.Location = new Point(109, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(353, 58);
            tableLayoutPanel7.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(3, 29);
            label5.Name = "label5";
            label5.Size = new Size(296, 20);
            label5.TabIndex = 2;
            label5.Text = "Administra la información de tus clientes";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnVolverMenuPrincipal, 0, 0);
            tableLayoutPanel2.Location = new Point(3, -1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(48, 59);
            tableLayoutPanel2.TabIndex = 29;
            // 
            // MenuClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1872, 864);
            Controls.Add(tableLayoutPanel1);
            Name = "MenuClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
            Load += MenuClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picClientes).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
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
        private Button btnVolverMenuPrincipal;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label5;
        private Button btnAgregarCliente;
        private Button btnBuscarCli;
        private TextBox inpObsCliente;
        private PictureBox picClientes;
        private Label label3;
        private DataGridViewButtonColumn Eliminar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colSector;
        private DataGridViewTextBoxColumn colCiudad;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colFax;
        private DataGridViewTextBoxColumn colLimite;
        private DataGridViewTextBoxColumn colBalance;
        private DataGridViewTextBoxColumn colObservaciones;
    }
}