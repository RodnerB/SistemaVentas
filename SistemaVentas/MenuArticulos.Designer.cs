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
            colCodigo = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colUnidad = new DataGridViewTextBoxColumn();
            colExistenciaMinima = new DataGridViewTextBoxColumn();
            colExisteciaMaxima = new DataGridViewTextBoxColumn();
            colExistenciaActual = new DataGridViewTextBoxColumn();
            colPrecioDeVenta = new DataGridViewTextBoxColumn();
            colCostoDeCompra = new DataGridViewTextBoxColumn();
            colAccion = new DataGridViewButtonColumn();
            lblCosArt = new Label();
            lblPreArt = new Label();
            btnAgregarArt = new Button();
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
            dgvArticulos.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colDescripcion, colUnidad, colExistenciaMinima, colExisteciaMaxima, colExistenciaActual, colPrecioDeVenta, colCostoDeCompra, colAccion });
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
            dgvArticulos.Location = new Point(3, 74);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvArticulos.RowHeadersVisible = false;
            dgvArticulos.RowHeadersWidth = 51;
            dgvArticulos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvArticulos.RowTemplate.Height = 32;
            dgvArticulos.Size = new Size(1392, 672);
            dgvArticulos.TabIndex = 0;
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
            // colAccion
            // 
            colAccion.FlatStyle = FlatStyle.Flat;
            colAccion.HeaderText = "Acción";
            colAccion.MinimumWidth = 6;
            colAccion.Name = "colAccion";
            colAccion.Text = "Eliminar";
            colAccion.UseColumnTextForButtonValue = true;
            // 
            // lblCosArt
            // 
            lblCosArt.AutoSize = true;
            lblCosArt.Location = new Point(3, 66);
            lblCosArt.Name = "lblCosArt";
            lblCosArt.Size = new Size(126, 20);
            lblCosArt.TabIndex = 14;
            lblCosArt.Text = "Precio de compra";
            // 
            // lblPreArt
            // 
            lblPreArt.AutoSize = true;
            lblPreArt.Location = new Point(3, 0);
            lblPreArt.Name = "lblPreArt";
            lblPreArt.Size = new Size(111, 20);
            lblPreArt.TabIndex = 15;
            lblPreArt.Text = "Precio de venta";
            // 
            // btnAgregarArt
            // 
            btnAgregarArt.Anchor = AnchorStyles.Top;
            btnAgregarArt.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarArt.Cursor = Cursors.Hand;
            btnAgregarArt.FlatAppearance.BorderSize = 0;
            btnAgregarArt.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnAgregarArt.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAgregarArt.FlatStyle = FlatStyle.Flat;
            btnAgregarArt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarArt.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarArt.Location = new Point(38, 54);
            btnAgregarArt.Name = "btnAgregarArt";
            btnAgregarArt.Size = new Size(354, 28);
            btnAgregarArt.TabIndex = 18;
            btnAgregarArt.Text = "Agregar artículo";
            btnAgregarArt.UseVisualStyleBackColor = false;
            btnAgregarArt.Click += btnAgregarArt_Click;
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
            btnBuscarArt.Location = new Point(37, 11);
            btnBuscarArt.Name = "btnBuscarArt";
            btnBuscarArt.Size = new Size(357, 28);
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.41074133F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.58896F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.00030017F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1872, 864);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel12);
            panel3.Controls.Add(tableLayoutPanel11);
            panel3.Controls.Add(tableLayoutPanel10);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(462, 58);
            panel3.TabIndex = 25;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(label1, 0, 0);
            tableLayoutPanel12.Controls.Add(label2, 0, 1);
            tableLayoutPanel12.Location = new Point(110, 0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(352, 56);
            tableLayoutPanel12.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 28);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Artículos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(3, 28);
            label2.Name = "label2";
            label2.Size = new Size(283, 23);
            label2.TabIndex = 1;
            label2.Text = "Administra tu inventario y precios";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.7475719F));
            tableLayoutPanel11.Controls.Add(picArtículos, 0, 0);
            tableLayoutPanel11.Location = new Point(50, 0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(57, 56);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // picArtículos
            // 
            picArtículos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            picArtículos.BackColor = Color.Transparent;
            picArtículos.BackgroundImage = Properties.Resources.box_51241;
            picArtículos.Location = new Point(5, 10);
            picArtículos.Name = "picArtículos";
            picArtículos.Size = new Size(49, 43);
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
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(54, 56);
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
            btnVolverMenuPrincipal.Location = new Point(18, 10);
            btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            btnVolverMenuPrincipal.Size = new Size(33, 35);
            btnVolverMenuPrincipal.TabIndex = 22;
            btnVolverMenuPrincipal.UseVisualStyleBackColor = false;
            btnVolverMenuPrincipal.Click += BtnVolverMenuPrincipal_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(tableLayoutPanel13);
            panel4.Location = new Point(471, 67);
            panel4.Name = "panel4";
            panel4.Size = new Size(1398, 768);
            panel4.TabIndex = 26;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(label4, 0, 0);
            tableLayoutPanel13.Controls.Add(dgvArticulos, 0, 1);
            tableLayoutPanel13.Location = new Point(0, 0);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 2;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 9.6F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 90.4F));
            tableLayoutPanel13.Size = new Size(1398, 749);
            tableLayoutPanel13.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 12);
            label4.Name = "label4";
            label4.Size = new Size(194, 46);
            label4.TabIndex = 12;
            label4.Text = "Inventario ";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.BackColor = SystemColors.ButtonHighlight;
            panel7.Controls.Add(tableLayoutPanel3);
            panel7.Location = new Point(15, 67);
            panel7.Name = "panel7";
            panel7.Size = new Size(437, 768);
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
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.555223F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 76.39181F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0529737F));
            tableLayoutPanel3.Size = new Size(437, 759);
            tableLayoutPanel3.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 573);
            panel1.TabIndex = 15;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.None;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Location = new Point(-3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 443F));
            tableLayoutPanel4.Size = new Size(433, 443);
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
            tableLayoutPanel5.Location = new Point(29, 5);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 15.9353352F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 44.1108551F));
            tableLayoutPanel5.Size = new Size(374, 433);
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
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 7;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(368, 167);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // lblCodArt
            // 
            lblCodArt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCodArt.AutoSize = true;
            lblCodArt.Location = new Point(3, 4);
            lblCodArt.Name = "lblCodArt";
            lblCodArt.Size = new Size(58, 20);
            lblCodArt.TabIndex = 9;
            lblCodArt.Text = "Código";
            // 
            // inpCodArt
            // 
            inpCodArt.Anchor = AnchorStyles.Bottom;
            inpCodArt.Location = new Point(4, 27);
            inpCodArt.Name = "inpCodArt";
            inpCodArt.Size = new Size(359, 27);
            inpCodArt.TabIndex = 3;
            // 
            // lblUniArt
            // 
            lblUniArt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUniArt.AutoSize = true;
            lblUniArt.Location = new Point(3, 100);
            lblUniArt.Name = "lblUniArt";
            lblUniArt.Size = new Size(57, 20);
            lblUniArt.TabIndex = 11;
            lblUniArt.Text = "Unidad";
            // 
            // lblDesArt
            // 
            lblDesArt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDesArt.AutoSize = true;
            lblDesArt.Location = new Point(3, 52);
            lblDesArt.Name = "lblDesArt";
            lblDesArt.Size = new Size(91, 20);
            lblDesArt.TabIndex = 10;
            lblDesArt.Text = "Descripción ";
            // 
            // inpDesArt
            // 
            inpDesArt.Anchor = AnchorStyles.Bottom;
            inpDesArt.Location = new Point(4, 75);
            inpDesArt.Name = "inpDesArt";
            inpDesArt.Size = new Size(359, 27);
            inpDesArt.TabIndex = 8;
            // 
            // cmbCodUni
            // 
            cmbCodUni.Anchor = AnchorStyles.Bottom;
            cmbCodUni.BackColor = Color.White;
            cmbCodUni.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCodUni.ForeColor = Color.Black;
            cmbCodUni.FormattingEnabled = true;
            cmbCodUni.Location = new Point(4, 123);
            cmbCodUni.Name = "cmbCodUni";
            cmbCodUni.Size = new Size(359, 28);
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
            tableLayoutPanel7.Location = new Point(3, 176);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(368, 62);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // lblExiMin
            // 
            lblExiMin.AutoSize = true;
            lblExiMin.Location = new Point(3, 0);
            lblExiMin.Name = "lblExiMin";
            lblExiMin.Size = new Size(71, 20);
            lblExiMin.TabIndex = 8;
            lblExiMin.Text = "Exist. Mín";
            // 
            // lblExiMax
            // 
            lblExiMax.AutoSize = true;
            lblExiMax.Location = new Point(125, 0);
            lblExiMax.Name = "lblExiMax";
            lblExiMax.Size = new Size(74, 20);
            lblExiMax.TabIndex = 10;
            lblExiMax.Text = "Exist. Máx";
            // 
            // inpExiMax
            // 
            inpExiMax.Location = new Point(125, 34);
            inpExiMax.Name = "inpExiMax";
            inpExiMax.Size = new Size(115, 27);
            inpExiMax.TabIndex = 11;
            inpExiMax.KeyPress += txtExiMax_KeyPress;
            // 
            // inpExiMin
            // 
            inpExiMin.Location = new Point(3, 34);
            inpExiMin.Name = "inpExiMin";
            inpExiMin.Size = new Size(115, 27);
            inpExiMin.TabIndex = 14;
            inpExiMin.KeyPress += txtExiMin_KeyPress;
            // 
            // lblExiAct
            // 
            lblExiAct.AutoSize = true;
            lblExiAct.Location = new Point(247, 0);
            lblExiAct.Name = "lblExiAct";
            lblExiAct.Size = new Size(68, 20);
            lblExiAct.TabIndex = 12;
            lblExiAct.Text = "Exist. Act";
            // 
            // inpExiAct
            // 
            inpExiAct.Location = new Point(247, 34);
            inpExiAct.Name = "inpExiAct";
            inpExiAct.Size = new Size(115, 27);
            inpExiAct.TabIndex = 13;
            inpExiAct.KeyPress += txtExiAct_KeyPress;
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
            tableLayoutPanel8.Location = new Point(3, 244);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 4;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 12.365591F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 23.11828F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 49.4444427F));
            tableLayoutPanel8.Size = new Size(368, 186);
            tableLayoutPanel8.TabIndex = 2;
            // 
            // inpCosArt
            // 
            inpCosArt.Anchor = AnchorStyles.Left;
            inpCosArt.Location = new Point(3, 31);
            inpCosArt.Name = "inpCosArt";
            inpCosArt.Size = new Size(359, 27);
            inpCosArt.TabIndex = 16;
            inpCosArt.KeyPress += txtCosArt_KeyPress;
            // 
            // inpPreArt
            // 
            inpPreArt.Location = new Point(3, 96);
            inpPreArt.Name = "inpPreArt";
            inpPreArt.Size = new Size(359, 27);
            inpPreArt.TabIndex = 17;
            inpPreArt.KeyPress += txtPreArt_KeyPress;
            // 
            // lblArticulos
            // 
            lblArticulos.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblArticulos.AutoSize = true;
            lblArticulos.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArticulos.Location = new Point(3, 13);
            lblArticulos.Name = "lblArticulos";
            lblArticulos.Size = new Size(431, 46);
            lblArticulos.TabIndex = 1;
            lblArticulos.Text = "Nuevo Artículo";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(btnAgregarArt, 0, 1);
            tableLayoutPanel9.Controls.Add(btnBuscarArt, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 654);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(431, 102);
            tableLayoutPanel9.TabIndex = 16;
            // 
            // MenuArticulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1872, 864);
            Controls.Add(tableLayoutPanel1);
            Name = "MenuArticulos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Artículos";
            WindowState = FormWindowState.Maximized;
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
        private Button btnAgregarArt;
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
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colUnidad;
        private DataGridViewTextBoxColumn colExistenciaMinima;
        private DataGridViewTextBoxColumn colExisteciaMaxima;
        private DataGridViewTextBoxColumn colExistenciaActual;
        private DataGridViewTextBoxColumn colPrecioDeVenta;
        private DataGridViewTextBoxColumn colCostoDeCompra;
        private DataGridViewButtonColumn colAccion;
    }
}