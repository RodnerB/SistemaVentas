namespace SistemaVentas
{
    partial class MenuArticulos
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
            dgvArticulos = new DataGridView();
            lblCosArt = new Label();
            lblPreArt = new Label();
            btnGuardarArt = new Button();
            btnBuscarArt = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            tableLayoutPanel12 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel11 = new TableLayoutPanel();
            picArtículos = new PictureBox();
            tableLayoutPanel10 = new TableLayoutPanel();
            btnVolverMenuPrincipal = new Button();
            panel4 = new Panel();
            tableLayoutPanel13 = new TableLayoutPanel();
            label4 = new Label();
            panel7 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            lblCodArt = new Label();
            inpCodArt = new TextBox();
            lblUniArt = new Label();
            lblDesArt = new Label();
            inpDesArt = new TextBox();
            cmbCodUni = new ComboBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            lblExiMin = new Label();
            lblExiMax = new Label();
            inpExiMax = new TextBox();
            inpExiMin = new TextBox();
            lblExiAct = new Label();
            inpExiAct = new TextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            inpCosArt = new TextBox();
            inpPreArt = new TextBox();
            lblArticulos = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            btnCancelar = new Button();
            colCodigo = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colUnidad = new DataGridViewTextBoxColumn();
            colExistenciaMinima = new DataGridViewTextBoxColumn();
            colExisteciaMaxima = new DataGridViewTextBoxColumn();
            colExistenciaActual = new DataGridViewTextBoxColumn();
            colPrecioDeVenta = new DataGridViewTextBoxColumn();
            colCostoDeCompra = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picArtículos).BeginInit();
            tableLayoutPanel10.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            SuspendLayout();
            // 
            // dgvArticulos
            // 
            dgvArticulos.AllowUserToAddRows = false;
            dgvArticulos.AllowUserToDeleteRows = false;
            dgvArticulos.AllowUserToResizeRows = false;
            dgvArticulos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArticulos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvArticulos.BorderStyle = BorderStyle.None;
            dgvArticulos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvArticulos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvArticulos.ColumnHeadersHeight = 35;
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvArticulos.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colDescripcion, colUnidad, colExistenciaMinima, colExisteciaMaxima, colExistenciaActual, colPrecioDeVenta, colCostoDeCompra });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvArticulos.EnableHeadersVisualStyles = false;
            dgvArticulos.GridColor = Color.White;
            dgvArticulos.Location = new Point(3, 55);
            dgvArticulos.Margin = new Padding(3, 2, 3, 2);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvArticulos.RowHeadersVisible = false;
            dgvArticulos.RowHeadersWidth = 51;
            dgvArticulos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvArticulos.RowTemplate.Height = 32;
            dgvArticulos.Size = new Size(1217, 505);
            dgvArticulos.TabIndex = 0;
            // 
            // lblCosArt
            // 
            lblCosArt.AutoSize = true;
            lblCosArt.Location = new Point(3, 49);
            lblCosArt.Name = "lblCosArt";
            lblCosArt.Size = new Size(100, 15);
            lblCosArt.TabIndex = 14;
            lblCosArt.Text = "Precio de compra";
            // 
            // lblPreArt
            // 
            lblPreArt.AutoSize = true;
            lblPreArt.Location = new Point(3, 0);
            lblPreArt.Name = "lblPreArt";
            lblPreArt.Size = new Size(88, 15);
            lblPreArt.TabIndex = 15;
            lblPreArt.Text = "Precio de venta";
            // 
            // btnGuardarArt
            // 
            btnGuardarArt.Anchor = AnchorStyles.Top;
            btnGuardarArt.BackColor = Color.FromArgb(0, 192, 0);
            btnGuardarArt.Cursor = Cursors.Hand;
            btnGuardarArt.FlatAppearance.BorderSize = 0;
            btnGuardarArt.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnGuardarArt.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnGuardarArt.FlatStyle = FlatStyle.Flat;
            btnGuardarArt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardarArt.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarArt.Location = new Point(32, 27);
            btnGuardarArt.Margin = new Padding(3, 2, 3, 2);
            btnGuardarArt.Name = "btnGuardarArt";
            btnGuardarArt.Size = new Size(312, 20);
            btnGuardarArt.TabIndex = 18;
            btnGuardarArt.Text = "Guardar artículo";
            btnGuardarArt.UseVisualStyleBackColor = false;
            btnGuardarArt.Click += btnAgregarArt_Click;
            // 
            // btnBuscarArt
            // 
            btnBuscarArt.Anchor = AnchorStyles.None;
            btnBuscarArt.BackColor = SystemColors.HotTrack;
            btnBuscarArt.Cursor = Cursors.Hand;
            btnBuscarArt.FlatAppearance.BorderSize = 0;
            btnBuscarArt.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnBuscarArt.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnBuscarArt.FlatStyle = FlatStyle.Flat;
            btnBuscarArt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarArt.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarArt.Location = new Point(32, 2);
            btnBuscarArt.Margin = new Padding(3, 2, 3, 2);
            btnBuscarArt.Name = "btnBuscarArt";
            btnBuscarArt.Size = new Size(312, 20);
            btnBuscarArt.TabIndex = 21;
            btnBuscarArt.Text = "Buscar artículo";
            btnBuscarArt.UseVisualStyleBackColor = false;
            btnBuscarArt.Click += btnBuscarArt_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.AliceBlue;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Controls.Add(panel7, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.41074133F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.58896F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.00030017F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new Size(1638, 648);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel12);
            panel3.Controls.Add(tableLayoutPanel11);
            panel3.Controls.Add(tableLayoutPanel10);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(403, 44);
            panel3.TabIndex = 25;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(label1, 0, 0);
            tableLayoutPanel12.Controls.Add(label2, 0, 1);
            tableLayoutPanel12.Location = new Point(96, 0);
            tableLayoutPanel12.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(308, 42);
            tableLayoutPanel12.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 21);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Artículos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(3, 21);
            label2.Name = "label2";
            label2.Size = new Size(236, 19);
            label2.TabIndex = 1;
            label2.Text = "Administra tu inventario y precios";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.7475719F));
            tableLayoutPanel11.Controls.Add(picArtículos, 0, 0);
            tableLayoutPanel11.Location = new Point(44, 0);
            tableLayoutPanel11.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(50, 42);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // picArtículos
            // 
            picArtículos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            picArtículos.BackColor = Color.Transparent;
            picArtículos.BackgroundImage = Properties.Resources.box_51241;
            picArtículos.Location = new Point(4, 8);
            picArtículos.Margin = new Padding(3, 2, 3, 2);
            picArtículos.Name = "picArtículos";
            picArtículos.Size = new Size(43, 32);
            picArtículos.SizeMode = PictureBoxSizeMode.Zoom;
            picArtículos.TabIndex = 4;
            picArtículos.TabStop = false;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.Anchor = AnchorStyles.Left;
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(btnVolverMenuPrincipal, 0, 0);
            tableLayoutPanel10.Location = new Point(0, 1);
            tableLayoutPanel10.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(47, 42);
            tableLayoutPanel10.TabIndex = 25;
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
            btnVolverMenuPrincipal.Location = new Point(15, 8);
            btnVolverMenuPrincipal.Margin = new Padding(3, 2, 3, 2);
            btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            btnVolverMenuPrincipal.Size = new Size(29, 26);
            btnVolverMenuPrincipal.TabIndex = 22;
            btnVolverMenuPrincipal.UseVisualStyleBackColor = false;
            btnVolverMenuPrincipal.Click += BtnVolverMenuPrincipal_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(tableLayoutPanel13);
            panel4.Location = new Point(412, 50);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1223, 576);
            panel4.TabIndex = 26;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(label4, 0, 0);
            tableLayoutPanel13.Controls.Add(dgvArticulos, 0, 1);
            tableLayoutPanel13.Location = new Point(0, 0);
            tableLayoutPanel13.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 2;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 9.6F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 90.4F));
            tableLayoutPanel13.Size = new Size(1223, 562);
            tableLayoutPanel13.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 8);
            label4.Name = "label4";
            label4.Size = new Size(157, 37);
            label4.TabIndex = 12;
            label4.Text = "Inventario ";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.BackColor = SystemColors.ButtonHighlight;
            panel7.Controls.Add(tableLayoutPanel3);
            panel7.Location = new Point(13, 50);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(382, 576);
            panel7.TabIndex = 27;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.None;
            tableLayoutPanel3.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel1, 0, 1);
            tableLayoutPanel3.Controls.Add(lblArticulos, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel9, 0, 2);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.555223F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 76.39181F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0529737F));
            tableLayoutPanel3.Size = new Size(382, 569);
            tableLayoutPanel3.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 56);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 430);
            panel1.TabIndex = 15;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.None;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Location = new Point(-3, 2);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 332F));
            tableLayoutPanel4.Size = new Size(379, 332);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.None;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel8, 0, 2);
            tableLayoutPanel5.Location = new Point(26, 3);
            tableLayoutPanel5.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 15.9353352F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 44.1108551F));
            tableLayoutPanel5.Size = new Size(327, 325);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(lblCodArt, 0, 0);
            tableLayoutPanel6.Controls.Add(inpCodArt, 0, 1);
            tableLayoutPanel6.Controls.Add(lblUniArt, 0, 4);
            tableLayoutPanel6.Controls.Add(lblDesArt, 0, 2);
            tableLayoutPanel6.Controls.Add(inpDesArt, 0, 3);
            tableLayoutPanel6.Controls.Add(cmbCodUni, 0, 5);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 2);
            tableLayoutPanel6.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 7;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel6.Size = new Size(321, 125);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // lblCodArt
            // 
            lblCodArt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCodArt.AutoSize = true;
            lblCodArt.Location = new Point(3, 3);
            lblCodArt.Name = "lblCodArt";
            lblCodArt.Size = new Size(46, 15);
            lblCodArt.TabIndex = 9;
            lblCodArt.Text = "Código";
            // 
            // inpCodArt
            // 
            inpCodArt.Anchor = AnchorStyles.Bottom;
            inpCodArt.Location = new Point(3, 20);
            inpCodArt.Margin = new Padding(3, 2, 3, 2);
            inpCodArt.Name = "inpCodArt";
            inpCodArt.Size = new Size(315, 23);
            inpCodArt.TabIndex = 3;
            // 
            // lblUniArt
            // 
            lblUniArt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUniArt.AutoSize = true;
            lblUniArt.Location = new Point(3, 75);
            lblUniArt.Name = "lblUniArt";
            lblUniArt.Size = new Size(45, 15);
            lblUniArt.TabIndex = 11;
            lblUniArt.Text = "Unidad";
            // 
            // lblDesArt
            // 
            lblDesArt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDesArt.AutoSize = true;
            lblDesArt.Location = new Point(3, 39);
            lblDesArt.Name = "lblDesArt";
            lblDesArt.Size = new Size(72, 15);
            lblDesArt.TabIndex = 10;
            lblDesArt.Text = "Descripción ";
            // 
            // inpDesArt
            // 
            inpDesArt.Anchor = AnchorStyles.Bottom;
            inpDesArt.Location = new Point(3, 56);
            inpDesArt.Margin = new Padding(3, 2, 3, 2);
            inpDesArt.Name = "inpDesArt";
            inpDesArt.Size = new Size(315, 23);
            inpDesArt.TabIndex = 8;
            // 
            // cmbCodUni
            // 
            cmbCodUni.Anchor = AnchorStyles.Bottom;
            cmbCodUni.BackColor = Color.White;
            cmbCodUni.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCodUni.ForeColor = Color.Black;
            cmbCodUni.FormattingEnabled = true;
            cmbCodUni.Location = new Point(3, 92);
            cmbCodUni.Margin = new Padding(3, 2, 3, 2);
            cmbCodUni.Name = "cmbCodUni";
            cmbCodUni.Size = new Size(315, 23);
            cmbCodUni.TabIndex = 7;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.Controls.Add(lblExiMin, 0, 0);
            tableLayoutPanel7.Controls.Add(lblExiMax, 1, 0);
            tableLayoutPanel7.Controls.Add(inpExiMax, 1, 1);
            tableLayoutPanel7.Controls.Add(inpExiMin, 0, 1);
            tableLayoutPanel7.Controls.Add(lblExiAct, 2, 0);
            tableLayoutPanel7.Controls.Add(inpExiAct, 2, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 131);
            tableLayoutPanel7.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(321, 47);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // lblExiMin
            // 
            lblExiMin.AutoSize = true;
            lblExiMin.Location = new Point(3, 0);
            lblExiMin.Name = "lblExiMin";
            lblExiMin.Size = new Size(57, 15);
            lblExiMin.TabIndex = 8;
            lblExiMin.Text = "Exist. Mín";
            // 
            // lblExiMax
            // 
            lblExiMax.AutoSize = true;
            lblExiMax.Location = new Point(110, 0);
            lblExiMax.Name = "lblExiMax";
            lblExiMax.Size = new Size(58, 15);
            lblExiMax.TabIndex = 10;
            lblExiMax.Text = "Exist. Máx";
            // 
            // inpExiMax
            // 
            inpExiMax.Location = new Point(110, 25);
            inpExiMax.Margin = new Padding(3, 2, 3, 2);
            inpExiMax.Name = "inpExiMax";
            inpExiMax.Size = new Size(101, 23);
            inpExiMax.TabIndex = 11;
            inpExiMax.KeyPress += ValidarSoloNumerosKeyPress;
            // 
            // inpExiMin
            // 
            inpExiMin.Location = new Point(3, 25);
            inpExiMin.Margin = new Padding(3, 2, 3, 2);
            inpExiMin.Name = "inpExiMin";
            inpExiMin.Size = new Size(101, 23);
            inpExiMin.TabIndex = 14;
            inpExiMin.KeyPress += ValidarSoloNumerosKeyPress;
            // 
            // lblExiAct
            // 
            lblExiAct.AutoSize = true;
            lblExiAct.Location = new Point(217, 0);
            lblExiAct.Name = "lblExiAct";
            lblExiAct.Size = new Size(54, 15);
            lblExiAct.TabIndex = 12;
            lblExiAct.Text = "Exist. Act";
            // 
            // inpExiAct
            // 
            inpExiAct.Location = new Point(217, 25);
            inpExiAct.Margin = new Padding(3, 2, 3, 2);
            inpExiAct.Name = "inpExiAct";
            inpExiAct.Size = new Size(101, 23);
            inpExiAct.TabIndex = 13;
            inpExiAct.KeyPress += ValidarSoloNumerosKeyPress;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(lblPreArt, 0, 0);
            tableLayoutPanel8.Controls.Add(inpCosArt, 0, 1);
            tableLayoutPanel8.Controls.Add(inpPreArt, 0, 3);
            tableLayoutPanel8.Controls.Add(lblCosArt, 0, 2);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 182);
            tableLayoutPanel8.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 4;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 12.365591F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 23.11828F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 49.4444427F));
            tableLayoutPanel8.Size = new Size(321, 141);
            tableLayoutPanel8.TabIndex = 2;
            // 
            // inpCosArt
            // 
            inpCosArt.Anchor = AnchorStyles.Left;
            inpCosArt.Location = new Point(3, 21);
            inpCosArt.Margin = new Padding(3, 2, 3, 2);
            inpCosArt.Name = "inpCosArt";
            inpCosArt.Size = new Size(315, 23);
            inpCosArt.TabIndex = 16;
            inpCosArt.KeyPress += ValidarSoloNumerosKeyPress;
            // 
            // inpPreArt
            // 
            inpPreArt.Location = new Point(3, 72);
            inpPreArt.Margin = new Padding(3, 2, 3, 2);
            inpPreArt.Name = "inpPreArt";
            inpPreArt.Size = new Size(315, 23);
            inpPreArt.TabIndex = 17;
            inpPreArt.KeyPress += ValidarSoloNumerosKeyPress;
            // 
            // lblArticulos
            // 
            lblArticulos.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblArticulos.AutoSize = true;
            lblArticulos.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArticulos.Location = new Point(3, 8);
            lblArticulos.Name = "lblArticulos";
            lblArticulos.Size = new Size(376, 37);
            lblArticulos.TabIndex = 1;
            lblArticulos.Text = "Nuevo Artículo";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(btnCancelar, 0, 2);
            tableLayoutPanel9.Controls.Add(btnGuardarArt, 0, 1);
            tableLayoutPanel9.Controls.Add(btnBuscarArt, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 490);
            tableLayoutPanel9.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 3;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.Size = new Size(376, 77);
            tableLayoutPanel9.TabIndex = 16;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(32, 52);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(312, 20);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "colCodigo";
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            // 
            // colUnidad
            // 
            colUnidad.HeaderText = "Unidad";
            colUnidad.MinimumWidth = 6;
            colUnidad.Name = "colUnidad";
            // 
            // colExistenciaMinima
            // 
            colExistenciaMinima.HeaderText = "Existencia mínima";
            colExistenciaMinima.MinimumWidth = 6;
            colExistenciaMinima.Name = "colExistenciaMinima";
            // 
            // colExisteciaMaxima
            // 
            colExisteciaMaxima.HeaderText = "Existencia maxima";
            colExisteciaMaxima.MinimumWidth = 6;
            colExisteciaMaxima.Name = "colExisteciaMaxima";
            // 
            // colExistenciaActual
            // 
            colExistenciaActual.HeaderText = "Existencia actual";
            colExistenciaActual.MinimumWidth = 6;
            colExistenciaActual.Name = "colExistenciaActual";
            // 
            // colPrecioDeVenta
            // 
            colPrecioDeVenta.HeaderText = "Precio de venta";
            colPrecioDeVenta.MinimumWidth = 6;
            colPrecioDeVenta.Name = "colPrecioDeVenta";
            // 
            // colCostoDeCompra
            // 
            colCostoDeCompra.HeaderText = "Costo de compra";
            colCostoDeCompra.MinimumWidth = 6;
            colCostoDeCompra.Name = "colCostoDeCompra";
            // 
            // MenuArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 648);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuArticulos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Artículos";
            WindowState = FormWindowState.Maximized;
            Load += MenuArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picArtículos).EndInit();
            tableLayoutPanel10.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            panel7.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvArticulos;
        private Label lblCosArt;
        private Label lblPreArt;
        private Button btnGuardarArt;
        private Button btnBuscarArt;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel7;
        private Panel panel5;
        private Panel panel6;
        private Panel panel1;
        private Label lblUniArt;
        private Label lblCodArt;
        private TextBox inpDesArt;
        private Label lblDesArt;
        private ComboBox cmbCodUni;
        private TextBox inpCodArt;
        private Label lblExiMax;
        private Label lblExiMin;
        private Label lblExiAct;
        private TextBox inpExiAct;
        private TextBox inpExiMax;
        private TextBox inpExiMin;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel8;
        private TextBox inpCosArt;
        private TextBox inpPreArt;
        private TableLayoutPanel tableLayoutPanel9;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel10;
        private Button btnVolverMenuPrincipal;
        private PictureBox picArtículos;
        private Label label1;
        private Label label2;
        private Label lblArticulos;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel13;
        private Panel panel7;
        private Label label4;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colUnidad;
        private DataGridViewTextBoxColumn colExistenciaMinima;
        private DataGridViewTextBoxColumn colExisteciaMaxima;
        private DataGridViewTextBoxColumn colExistenciaActual;
        private DataGridViewTextBoxColumn colPrecioDeVenta;
        private DataGridViewTextBoxColumn colCostoDeCompra;
    }
}