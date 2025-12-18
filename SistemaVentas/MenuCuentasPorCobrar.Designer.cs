namespace SistemaVentas
{
    partial class MenuCuentasPorCobrar
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel8 = new TableLayoutPanel();
            picClientes = new PictureBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            label5 = new Label();
            lblClientes = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnVolverMenuPrincipal = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            lblCodigoCliente = new Label();
            lblNombreDelCliente = new Label();
            lblFactura = new Label();
            lblValorAPagar = new Label();
            inpCodigoDelCliente = new TextBox();
            inpNombreDelCliente = new TextBox();
            inpFactura = new TextBox();
            inpValorAPagar = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnCancelar = new Button();
            btnPagar = new Button();
            btnBuscarCuentasPorCobrar = new Button();
            label1 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            dgvCuentasPorCobrar = new DataGridView();
            colNumeroDeFactura = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClientes).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuentasPorCobrar).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.410741F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.58895F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.0003F));
            tableLayoutPanel1.Size = new Size(1638, 650);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tableLayoutPanel8);
            panel1.Controls.Add(tableLayoutPanel7);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 44);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(picClientes, 0, 0);
            tableLayoutPanel8.Location = new Point(44, 0);
            tableLayoutPanel8.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(49, 41);
            tableLayoutPanel8.TabIndex = 31;
            // 
            // picClientes
            // 
            picClientes.Anchor = AnchorStyles.Right;
            picClientes.BackColor = Color.Transparent;
            picClientes.BackgroundImage = Properties.Resources.money_cash_currency_finance_bank_icon_192201__1_1;
            picClientes.Location = new Point(4, 4);
            picClientes.Margin = new Padding(3, 2, 3, 2);
            picClientes.Name = "picClientes";
            picClientes.Size = new Size(42, 33);
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
            tableLayoutPanel7.Location = new Point(94, 0);
            tableLayoutPanel7.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(309, 44);
            tableLayoutPanel7.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(3, 22);
            label5.Name = "label5";
            label5.Size = new Size(191, 15);
            label5.TabIndex = 2;
            label5.Text = "Administra las cuentas por cobrar";
            // 
            // lblClientes
            // 
            lblClientes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblClientes.Location = new Point(3, 0);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(184, 22);
            lblClientes.TabIndex = 1;
            lblClientes.Text = "Cuentas por cobrar";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnVolverMenuPrincipal, 0, 0);
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(41, 39);
            tableLayoutPanel2.TabIndex = 29;
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
            btnVolverMenuPrincipal.Location = new Point(6, 9);
            btnVolverMenuPrincipal.Margin = new Padding(3, 2, 3, 2);
            btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            btnVolverMenuPrincipal.Size = new Size(32, 20);
            btnVolverMenuPrincipal.TabIndex = 28;
            btnVolverMenuPrincipal.UseVisualStyleBackColor = false;
            btnVolverMenuPrincipal.Click += btnVolverMenuPrincipal_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel3.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Location = new Point(13, 50);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.56F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 76.39F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.05F));
            tableLayoutPanel3.Size = new Size(382, 578);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(lblCodigoCliente, 0, 0);
            tableLayoutPanel5.Controls.Add(lblNombreDelCliente, 0, 2);
            tableLayoutPanel5.Controls.Add(lblFactura, 0, 4);
            tableLayoutPanel5.Controls.Add(lblValorAPagar, 0, 6);
            tableLayoutPanel5.Controls.Add(inpCodigoDelCliente, 0, 1);
            tableLayoutPanel5.Controls.Add(inpNombreDelCliente, 0, 3);
            tableLayoutPanel5.Controls.Add(inpFactura, 0, 5);
            tableLayoutPanel5.Controls.Add(inpValorAPagar, 0, 7);
            tableLayoutPanel5.Location = new Point(40, 57);
            tableLayoutPanel5.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 8;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel5.Size = new Size(301, 235);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // lblCodigoCliente
            // 
            lblCodigoCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCodigoCliente.AutoSize = true;
            lblCodigoCliente.Location = new Point(3, 14);
            lblCodigoCliente.Name = "lblCodigoCliente";
            lblCodigoCliente.Size = new Size(103, 15);
            lblCodigoCliente.TabIndex = 0;
            lblCodigoCliente.Text = "Código del cliente";
            // 
            // lblNombreDelCliente
            // 
            lblNombreDelCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNombreDelCliente.AutoSize = true;
            lblNombreDelCliente.Location = new Point(3, 72);
            lblNombreDelCliente.Name = "lblNombreDelCliente";
            lblNombreDelCliente.Size = new Size(108, 15);
            lblNombreDelCliente.TabIndex = 1;
            lblNombreDelCliente.Text = "Nombre del cliente";
            // 
            // lblFactura
            // 
            lblFactura.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFactura.AutoSize = true;
            lblFactura.Location = new Point(3, 130);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(46, 15);
            lblFactura.TabIndex = 2;
            lblFactura.Text = "Factura";
            // 
            // lblValorAPagar
            // 
            lblValorAPagar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblValorAPagar.AutoSize = true;
            lblValorAPagar.Location = new Point(3, 188);
            lblValorAPagar.Name = "lblValorAPagar";
            lblValorAPagar.Size = new Size(75, 15);
            lblValorAPagar.TabIndex = 3;
            lblValorAPagar.Text = "Valor a pagar";
            // 
            // inpCodigoDelCliente
            // 
            inpCodigoDelCliente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inpCodigoDelCliente.Location = new Point(3, 32);
            inpCodigoDelCliente.Margin = new Padding(3, 2, 3, 2);
            inpCodigoDelCliente.Name = "inpCodigoDelCliente";
            inpCodigoDelCliente.Size = new Size(295, 23);
            inpCodigoDelCliente.TabIndex = 4;
            // 
            // inpNombreDelCliente
            // 
            inpNombreDelCliente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inpNombreDelCliente.Location = new Point(3, 90);
            inpNombreDelCliente.Margin = new Padding(3, 2, 3, 2);
            inpNombreDelCliente.Name = "inpNombreDelCliente";
            inpNombreDelCliente.ReadOnly = true;
            inpNombreDelCliente.Size = new Size(295, 23);
            inpNombreDelCliente.TabIndex = 5;
            // 
            // inpFactura
            // 
            inpFactura.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inpFactura.Location = new Point(3, 148);
            inpFactura.Margin = new Padding(3, 2, 3, 2);
            inpFactura.Name = "inpFactura";
            inpFactura.Size = new Size(295, 23);
            inpFactura.TabIndex = 6;
            // 
            // inpValorAPagar
            // 
            inpValorAPagar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inpValorAPagar.Location = new Point(3, 207);
            inpValorAPagar.Margin = new Padding(3, 2, 3, 2);
            inpValorAPagar.Name = "inpValorAPagar";
            inpValorAPagar.ReadOnly = true;
            inpValorAPagar.Size = new Size(295, 23);
            inpValorAPagar.TabIndex = 7;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(btnCancelar, 0, 2);
            tableLayoutPanel6.Controls.Add(btnPagar, 0, 1);
            tableLayoutPanel6.Controls.Add(btnBuscarCuentasPorCobrar, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 498);
            tableLayoutPanel6.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.Size = new Size(376, 78);
            tableLayoutPanel6.TabIndex = 27;
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
            btnCancelar.Location = new Point(3, 54);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(370, 21);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnPagar
            // 
            btnPagar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPagar.BackColor = Color.FromArgb(0, 192, 0);
            btnPagar.Cursor = Cursors.Hand;
            btnPagar.Enabled = false;
            btnPagar.FlatAppearance.BorderColor = Color.White;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnPagar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagar.ForeColor = SystemColors.ButtonHighlight;
            btnPagar.Location = new Point(3, 28);
            btnPagar.Margin = new Padding(3, 2, 3, 2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(370, 21);
            btnPagar.TabIndex = 27;
            btnPagar.Text = "Pagar factura";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // btnBuscarCuentasPorCobrar
            // 
            btnBuscarCuentasPorCobrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBuscarCuentasPorCobrar.BackColor = SystemColors.HotTrack;
            btnBuscarCuentasPorCobrar.Cursor = Cursors.Hand;
            btnBuscarCuentasPorCobrar.FlatAppearance.BorderColor = Color.White;
            btnBuscarCuentasPorCobrar.FlatAppearance.BorderSize = 0;
            btnBuscarCuentasPorCobrar.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnBuscarCuentasPorCobrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnBuscarCuentasPorCobrar.FlatStyle = FlatStyle.Flat;
            btnBuscarCuentasPorCobrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarCuentasPorCobrar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarCuentasPorCobrar.Location = new Point(3, 2);
            btnBuscarCuentasPorCobrar.Margin = new Padding(3, 2, 3, 2);
            btnBuscarCuentasPorCobrar.Name = "btnBuscarCuentasPorCobrar";
            btnBuscarCuentasPorCobrar.Size = new Size(370, 21);
            btnBuscarCuentasPorCobrar.TabIndex = 26;
            btnBuscarCuentasPorCobrar.Text = "Buscar factura";
            btnBuscarCuentasPorCobrar.UseVisualStyleBackColor = false;
            btnBuscarCuentasPorCobrar.Click += btnBuscarCuentasPorCobrar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 37);
            label1.TabIndex = 28;
            label1.Text = "Detalles del recibo ";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(dgvCuentasPorCobrar, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(412, 50);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(1223, 578);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // dgvCuentasPorCobrar
            // 
            dgvCuentasPorCobrar.AllowUserToAddRows = false;
            dgvCuentasPorCobrar.AllowUserToDeleteRows = false;
            dgvCuentasPorCobrar.AllowUserToResizeColumns = false;
            dgvCuentasPorCobrar.AllowUserToResizeRows = false;
            dgvCuentasPorCobrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCuentasPorCobrar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCuentasPorCobrar.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCuentasPorCobrar.BorderStyle = BorderStyle.None;
            dgvCuentasPorCobrar.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCuentasPorCobrar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvCuentasPorCobrar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCuentasPorCobrar.ColumnHeadersHeight = 35;
            dgvCuentasPorCobrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCuentasPorCobrar.Columns.AddRange(new DataGridViewColumn[] { colNumeroDeFactura, colFecha, colValor });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCuentasPorCobrar.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCuentasPorCobrar.Dock = DockStyle.Fill;
            dgvCuentasPorCobrar.EnableHeadersVisualStyles = false;
            dgvCuentasPorCobrar.GridColor = SystemColors.HighlightText;
            dgvCuentasPorCobrar.Location = new Point(3, 2);
            dgvCuentasPorCobrar.Margin = new Padding(3, 2, 3, 2);
            dgvCuentasPorCobrar.Name = "dgvCuentasPorCobrar";
            dgvCuentasPorCobrar.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCuentasPorCobrar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCuentasPorCobrar.RowHeadersVisible = false;
            dgvCuentasPorCobrar.RowHeadersWidth = 51;
            dgvCuentasPorCobrar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCuentasPorCobrar.Size = new Size(1217, 574);
            dgvCuentasPorCobrar.TabIndex = 1;
            // 
            // colNumeroDeFactura
            // 
            colNumeroDeFactura.HeaderText = "N. de factura";
            colNumeroDeFactura.MinimumWidth = 6;
            colNumeroDeFactura.Name = "colNumeroDeFactura";
            colNumeroDeFactura.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colValor
            // 
            colValor.HeaderText = "Valor";
            colValor.MinimumWidth = 6;
            colValor.Name = "colValor";
            colValor.ReadOnly = true;
            // 
            // MenuCuentasPorCobrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1638, 650);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuCuentasPorCobrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuCuentasPorCobrar";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picClientes).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCuentasPorCobrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel8;
        private PictureBox picClientes;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label5;
        private Label lblClientes;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnVolverMenuPrincipal;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dgvCuentasPorCobrar;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label lblCodigoCliente;
        private Label lblNombreDelCliente;
        private Label lblFactura;
        private Label lblValorAPagar;
        private TextBox inpCodigoDelCliente;
        private TextBox inpNombreDelCliente;
        private TextBox inpFactura;
        private TextBox inpValorAPagar;
        private Button btnBuscarCuentasPorCobrar;
        private Label label1;
        private Button button2;
        private Button btnPagar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn colNumeroDeFactura;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colValor;
    }
}