namespace SistemaVentas
{
    partial class MenuFacturas
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvFacturas = new DataGridView();
            lblNumFac = new Label();
            inpNumFactura = new TextBox();
            lblFecFac = new Label();
            inpDateTime = new DateTimePicker();
            lblCodCliFac = new Label();
            cmbCodCliente = new ComboBox();
            lblCondicion = new Label();
            cmbCondicion = new ComboBox();
            lblDescuento = new Label();
            inpDescFactura = new TextBox();
            lblMonFac = new Label();
            inpMonFactura = new TextBox();
            btnAgregarFac = new Button();
            btnBuscarFac = new Button();
            btnVolverMenuPrincipal = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label3 = new Label();
            panel1 = new Panel();
            tableLayoutPanel12 = new TableLayoutPanel();
            label2 = new Label();
            label4 = new Label();
            tableLayoutPanel11 = new TableLayoutPanel();
            picArtículos = new PictureBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picArtículos).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // dgvFacturas
            // 
            dgvFacturas.AllowUserToAddRows = false;
            dgvFacturas.AllowUserToDeleteRows = false;
            dgvFacturas.AllowUserToResizeColumns = false;
            dgvFacturas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dgvFacturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFacturas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFacturas.BackgroundColor = SystemColors.ButtonHighlight;
            dgvFacturas.BorderStyle = BorderStyle.None;
            dgvFacturas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvFacturas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvFacturas.ColumnHeadersHeight = 20;
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvFacturas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvFacturas.Dock = DockStyle.Fill;
            dgvFacturas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvFacturas.EnableHeadersVisualStyles = false;
            dgvFacturas.GridColor = Color.LightGray;
            dgvFacturas.Location = new Point(3, 73);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.RowHeadersVisible = false;
            dgvFacturas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dgvFacturas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvFacturas.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFacturas.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F);
            dgvFacturas.RowTemplate.Height = 35;
            dgvFacturas.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvFacturas.Size = new Size(1392, 692);
            dgvFacturas.TabIndex = 0;
            // 
            // lblNumFac
            // 
            lblNumFac.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNumFac.AutoSize = true;
            lblNumFac.Location = new Point(3, 14);
            lblNumFac.Name = "lblNumFac";
            lblNumFac.Size = new Size(113, 20);
            lblNumFac.TabIndex = 2;
            lblNumFac.Text = "Número factura";
            // 
            // inpNumFactura
            // 
            inpNumFactura.Location = new Point(3, 37);
            inpNumFactura.Name = "inpNumFactura";
            inpNumFactura.Size = new Size(350, 27);
            inpNumFactura.TabIndex = 3;
            // 
            // lblFecFac
            // 
            lblFecFac.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFecFac.AutoSize = true;
            lblFecFac.Location = new Point(3, 82);
            lblFecFac.Name = "lblFecFac";
            lblFecFac.Size = new Size(47, 20);
            lblFecFac.TabIndex = 4;
            lblFecFac.Text = "Fecha";
            // 
            // inpDateTime
            // 
            inpDateTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inpDateTime.CustomFormat = "";
            inpDateTime.Format = DateTimePickerFormat.Custom;
            inpDateTime.Location = new Point(3, 106);
            inpDateTime.Name = "inpDateTime";
            inpDateTime.Size = new Size(350, 27);
            inpDateTime.TabIndex = 5;
            // 
            // lblCodCliFac
            // 
            lblCodCliFac.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCodCliFac.AutoSize = true;
            lblCodCliFac.Location = new Point(3, 150);
            lblCodCliFac.Name = "lblCodCliFac";
            lblCodCliFac.Size = new Size(55, 20);
            lblCodCliFac.TabIndex = 6;
            lblCodCliFac.Text = "Cliente";
            // 
            // cmbCodCliente
            // 
            cmbCodCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbCodCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCodCliente.FormattingEnabled = true;
            cmbCodCliente.Location = new Point(3, 173);
            cmbCodCliente.Name = "cmbCodCliente";
            cmbCodCliente.Size = new Size(350, 28);
            cmbCodCliente.TabIndex = 7;
            // 
            // lblCondicion
            // 
            lblCondicion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCondicion.AutoSize = true;
            lblCondicion.Location = new Point(3, 218);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(76, 20);
            lblCondicion.TabIndex = 8;
            lblCondicion.Text = "Condición";
            // 
            // cmbCondicion
            // 
            cmbCondicion.Anchor = AnchorStyles.None;
            cmbCondicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondicion.FormattingEnabled = true;
            cmbCondicion.Items.AddRange(new object[] { "Seleccione una condición", "Contado", "Credito" });
            cmbCondicion.Location = new Point(3, 241);
            cmbCondicion.Name = "cmbCondicion";
            cmbCondicion.Size = new Size(350, 28);
            cmbCondicion.TabIndex = 9;
            // 
            // lblDescuento
            // 
            lblDescuento.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(3, 354);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(79, 20);
            lblDescuento.TabIndex = 10;
            lblDescuento.Text = "Descuento";
            // 
            // inpDescFactura
            // 
            inpDescFactura.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inpDescFactura.Location = new Point(3, 383);
            inpDescFactura.Name = "inpDescFactura";
            inpDescFactura.Size = new Size(350, 27);
            inpDescFactura.TabIndex = 11;
            // 
            // lblMonFac
            // 
            lblMonFac.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMonFac.AutoSize = true;
            lblMonFac.Location = new Point(3, 286);
            lblMonFac.Name = "lblMonFac";
            lblMonFac.Size = new Size(103, 20);
            lblMonFac.TabIndex = 12;
            lblMonFac.Text = "Monto factura";
            // 
            // inpMonFactura
            // 
            inpMonFactura.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inpMonFactura.Location = new Point(3, 310);
            inpMonFactura.Name = "inpMonFactura";
            inpMonFactura.Size = new Size(350, 27);
            inpMonFactura.TabIndex = 13;
            // 
            // btnAgregarFac
            // 
            btnAgregarFac.Anchor = AnchorStyles.None;
            btnAgregarFac.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarFac.Cursor = Cursors.Hand;
            btnAgregarFac.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnAgregarFac.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAgregarFac.FlatStyle = FlatStyle.Flat;
            btnAgregarFac.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarFac.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarFac.Location = new Point(37, 62);
            btnAgregarFac.Name = "btnAgregarFac";
            btnAgregarFac.Size = new Size(356, 28);
            btnAgregarFac.TabIndex = 14;
            btnAgregarFac.Text = "Agregar factura";
            btnAgregarFac.UseVisualStyleBackColor = false;
            btnAgregarFac.Click += btnAgregarFac_Click;
            // 
            // btnBuscarFac
            // 
            btnBuscarFac.Anchor = AnchorStyles.None;
            btnBuscarFac.BackColor = SystemColors.HotTrack;
            btnBuscarFac.Cursor = Cursors.Hand;
            btnBuscarFac.FlatAppearance.BorderSize = 0;
            btnBuscarFac.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnBuscarFac.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnBuscarFac.FlatStyle = FlatStyle.Flat;
            btnBuscarFac.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarFac.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarFac.Location = new Point(37, 11);
            btnBuscarFac.Name = "btnBuscarFac";
            btnBuscarFac.Size = new Size(356, 28);
            btnBuscarFac.TabIndex = 17;
            btnBuscarFac.Text = "Buscar factura";
            btnBuscarFac.UseVisualStyleBackColor = false;
            // 
            // btnVolverMenuPrincipal
            // 
            btnVolverMenuPrincipal.Anchor = AnchorStyles.Right;
            btnVolverMenuPrincipal.BackgroundImage = Properties.Resources.return_up_back_icon_233992__1_;
            btnVolverMenuPrincipal.Cursor = Cursors.Hand;
            btnVolverMenuPrincipal.FlatAppearance.BorderSize = 0;
            btnVolverMenuPrincipal.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnVolverMenuPrincipal.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnVolverMenuPrincipal.FlatStyle = FlatStyle.Flat;
            btnVolverMenuPrincipal.Location = new Point(18, 11);
            btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            btnVolverMenuPrincipal.Size = new Size(33, 34);
            btnVolverMenuPrincipal.TabIndex = 18;
            btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            btnVolverMenuPrincipal.Click += btnVolverMenuPrincipal_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.AliceBlue;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.410741F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.58895F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.0003F));
            tableLayoutPanel1.Size = new Size(1872, 864);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgvFacturas, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(471, 67);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.24F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90.76F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1398, 768);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(324, 46);
            label1.TabIndex = 1;
            label1.Text = "Listado de Facturas";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel3.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Location = new Point(16, 67);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.555223F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 76.39181F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0529737F));
            tableLayoutPanel3.Size = new Size(436, 768);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.None;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 76);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(430, 580);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(lblNumFac, 0, 0);
            tableLayoutPanel5.Controls.Add(inpNumFactura, 0, 1);
            tableLayoutPanel5.Controls.Add(lblDescuento, 0, 10);
            tableLayoutPanel5.Controls.Add(cmbCondicion, 0, 7);
            tableLayoutPanel5.Controls.Add(inpMonFactura, 0, 9);
            tableLayoutPanel5.Controls.Add(lblMonFac, 0, 8);
            tableLayoutPanel5.Controls.Add(lblFecFac, 0, 2);
            tableLayoutPanel5.Controls.Add(inpDateTime, 0, 3);
            tableLayoutPanel5.Controls.Add(lblCodCliFac, 0, 4);
            tableLayoutPanel5.Controls.Add(cmbCodCliente, 0, 5);
            tableLayoutPanel5.Controls.Add(inpDescFactura, 0, 11);
            tableLayoutPanel5.Controls.Add(lblCondicion, 0, 6);
            tableLayoutPanel5.Location = new Point(37, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 12;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel5.Size = new Size(356, 413);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.None;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(btnBuscarFac, 0, 0);
            tableLayoutPanel6.Controls.Add(btnAgregarFac, 0, 1);
            tableLayoutPanel6.Location = new Point(3, 662);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(430, 102);
            tableLayoutPanel6.TabIndex = 19;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 27);
            label3.Name = "label3";
            label3.Size = new Size(247, 46);
            label3.TabIndex = 20;
            label3.Text = "Nueva Factura";
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel12);
            panel1.Controls.Add(tableLayoutPanel11);
            panel1.Controls.Add(tableLayoutPanel7);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 58);
            panel1.TabIndex = 19;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(label2, 0, 0);
            tableLayoutPanel12.Controls.Add(label4, 0, 1);
            tableLayoutPanel12.Location = new Point(110, 2);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(352, 56);
            tableLayoutPanel12.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(222, 28);
            label2.TabIndex = 0;
            label2.Text = "Gestión de Facturas";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(3, 30);
            label4.Name = "label4";
            label4.Size = new Size(249, 23);
            label4.TabIndex = 1;
            label4.Text = "Crea y administra tus facturas";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.7475719F));
            tableLayoutPanel11.Controls.Add(picArtículos, 0, 0);
            tableLayoutPanel11.Location = new Point(56, 2);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(57, 56);
            tableLayoutPanel11.TabIndex = 1;
            // 
            // picArtículos
            // 
            picArtículos.Anchor = AnchorStyles.None;
            picArtículos.BackColor = Color.Transparent;
            picArtículos.BackgroundImage = Properties.Resources._1492617381_9_sheet_data_spreadsheets_file_google_suit_service_83434__2_;
            picArtículos.Location = new Point(4, 6);
            picArtículos.Name = "picArtículos";
            picArtículos.Size = new Size(49, 43);
            picArtículos.SizeMode = PictureBoxSizeMode.Zoom;
            picArtículos.TabIndex = 4;
            picArtículos.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(btnVolverMenuPrincipal, 0, 0);
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(54, 56);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // MenuFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1872, 864);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuFacturas";
            Text = "Facturación";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picArtículos).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFacturas;
        private Label lblNumFac;
        private TextBox inpNumFactura;
        private Label lblFecFac;
        private DateTimePicker inpDateTime;
        private Label lblCodCliFac;
        private ComboBox cmbCodCliente;
        private Label lblCondicion;
        private ComboBox cmbCondicion;
        private Label lblDescuento;
        private TextBox inpDescFactura;
        private Label lblMonFac;
        private TextBox inpMonFactura;
        private Button btnAgregarFac;
        private Button btnBuscarFac;
        private Button btnVolverMenuPrincipal;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel11;
        private PictureBox picArtículos;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label4;
    }
}