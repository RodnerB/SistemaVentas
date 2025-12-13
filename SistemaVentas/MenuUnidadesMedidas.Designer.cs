namespace SistemaVentas
{
    partial class MenuUnidadesMedidas
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblUnidadesMedida = new Label();
            dgvUnidad = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            button1 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            picClientes = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label5 = new Label();
            lblClientes = new Label();
            panel1 = new Panel();
            tableLayoutPanel12 = new TableLayoutPanel();
            tableLayoutPanel14 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            lblCodUni = new Label();
            txtCodUni = new TextBox();
            lblDesUni = new Label();
            txtDesUni = new TextBox();
            tableLayoutPanel10 = new TableLayoutPanel();
            btnAgregarUni = new Button();
            btnBuscarUni = new Button();
            panel2 = new Panel();
            tableLayoutPanel8 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            colCodigoUnidad = new DataGridViewTextBoxColumn();
            colDescripcionUnidad = new DataGridViewTextBoxColumn();
            colAccion = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUnidad).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClientes).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUnidadesMedida
            // 
            lblUnidadesMedida.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUnidadesMedida.AutoSize = true;
            lblUnidadesMedida.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnidadesMedida.Location = new Point(3, 27);
            lblUnidadesMedida.Name = "lblUnidadesMedida";
            lblUnidadesMedida.Size = new Size(299, 46);
            lblUnidadesMedida.TabIndex = 1;
            lblUnidadesMedida.Text = "Lista de Unidades";
            // 
            // dgvUnidad
            // 
            dgvUnidad.AllowUserToAddRows = false;
            dgvUnidad.AllowUserToDeleteRows = false;
            dgvUnidad.AllowUserToResizeColumns = false;
            dgvUnidad.AllowUserToResizeRows = false;
            dgvUnidad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUnidad.BackgroundColor = SystemColors.ButtonHighlight;
            dgvUnidad.BorderStyle = BorderStyle.None;
            dgvUnidad.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvUnidad.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUnidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUnidad.ColumnHeadersHeight = 25;
            dgvUnidad.Columns.AddRange(new DataGridViewColumn[] { colCodigoUnidad, colDescripcionUnidad, colAccion });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUnidad.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUnidad.EnableHeadersVisualStyles = false;
            dgvUnidad.GridColor = Color.LightGray;
            dgvUnidad.Location = new Point(3, 76);
            dgvUnidad.Name = "dgvUnidad";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUnidad.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUnidad.RowHeadersVisible = false;
            dgvUnidad.RowHeadersWidth = 51;
            dgvUnidad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnidad.Size = new Size(1392, 689);
            dgvUnidad.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.AliceBlue;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel14, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3F));
            tableLayoutPanel1.Size = new Size(1872, 864);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(tableLayoutPanel4);
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(462, 58);
            panel3.TabIndex = 31;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(button1, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(48, 58);
            tableLayoutPanel4.TabIndex = 32;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.return_up_back_icon_233992__1_;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Silver;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(13, 12);
            button1.Name = "button1";
            button1.Size = new Size(32, 34);
            button1.TabIndex = 28;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnVolverMenuPrincipal_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(picClientes, 0, 0);
            tableLayoutPanel2.Location = new Point(50, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(53, 58);
            tableLayoutPanel2.TabIndex = 31;
            // 
            // picClientes
            // 
            picClientes.Anchor = AnchorStyles.Right;
            picClientes.BackColor = Color.Transparent;
            picClientes.BackgroundImage = Properties.Resources.hard_drives_icon_173095__2_;
            picClientes.Location = new Point(4, 8);
            picClientes.Name = "picClientes";
            picClientes.Size = new Size(46, 42);
            picClientes.SizeMode = PictureBoxSizeMode.Zoom;
            picClientes.TabIndex = 5;
            picClientes.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label5, 0, 1);
            tableLayoutPanel3.Controls.Add(lblClientes, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Right;
            tableLayoutPanel3.Location = new Point(105, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(357, 58);
            tableLayoutPanel3.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(3, 29);
            label5.Name = "label5";
            label5.Size = new Size(244, 20);
            label5.TabIndex = 2;
            label5.Text = "Gestiona las unidades del sistema";
            // 
            // lblClientes
            // 
            lblClientes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblClientes.Location = new Point(3, 0);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(211, 29);
            lblClientes.TabIndex = 1;
            lblClientes.Text = "Unidad de Medida";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(tableLayoutPanel12);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(471, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(1398, 768);
            panel1.TabIndex = 30;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(lblUnidadesMedida, 0, 0);
            tableLayoutPanel12.Controls.Add(dgvUnidad, 0, 1);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(0, 0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 9.505208F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 90.49479F));
            tableLayoutPanel12.Size = new Size(1398, 768);
            tableLayoutPanel12.TabIndex = 0;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel14.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel14.ColumnCount = 1;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Controls.Add(label1, 0, 0);
            tableLayoutPanel14.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel14.Controls.Add(tableLayoutPanel10, 0, 3);
            tableLayoutPanel14.Controls.Add(panel2, 0, 2);
            tableLayoutPanel14.Location = new Point(15, 67);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 4;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0944529F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 74.96252F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 14.05F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 99F));
            tableLayoutPanel14.Size = new Size(437, 768);
            tableLayoutPanel14.TabIndex = 29;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 28);
            label1.Name = "label1";
            label1.Size = new Size(246, 46);
            label1.TabIndex = 1;
            label1.Text = "Nueva Unidad";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Location = new Point(48, 77);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(340, 156);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.None;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(334, 150);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.None;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(lblCodUni, 0, 0);
            tableLayoutPanel7.Controls.Add(txtCodUni, 0, 1);
            tableLayoutPanel7.Controls.Add(lblDesUni, 0, 2);
            tableLayoutPanel7.Controls.Add(txtDesUni, 0, 3);
            tableLayoutPanel7.Location = new Point(11, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 4;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.Size = new Size(312, 143);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // lblCodUni
            // 
            lblCodUni.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCodUni.AutoSize = true;
            lblCodUni.Location = new Point(3, 15);
            lblCodUni.Name = "lblCodUni";
            lblCodUni.Size = new Size(58, 20);
            lblCodUni.TabIndex = 2;
            lblCodUni.Text = "Código";
            // 
            // txtCodUni
            // 
            txtCodUni.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCodUni.Location = new Point(3, 40);
            txtCodUni.Name = "txtCodUni";
            txtCodUni.Size = new Size(306, 27);
            txtCodUni.TabIndex = 3;
            // 
            // lblDesUni
            // 
            lblDesUni.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDesUni.AutoSize = true;
            lblDesUni.Location = new Point(3, 85);
            lblDesUni.Name = "lblDesUni";
            lblDesUni.Size = new Size(87, 20);
            lblDesUni.TabIndex = 4;
            lblDesUni.Text = "Descripción";
            // 
            // txtDesUni
            // 
            txtDesUni.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDesUni.Location = new Point(3, 113);
            txtDesUni.Name = "txtDesUni";
            txtDesUni.Size = new Size(306, 27);
            txtDesUni.TabIndex = 5;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(btnAgregarUni, 0, 1);
            tableLayoutPanel10.Controls.Add(btnBuscarUni, 0, 0);
            tableLayoutPanel10.Location = new Point(3, 670);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(430, 94);
            tableLayoutPanel10.TabIndex = 1;
            // 
            // btnAgregarUni
            // 
            btnAgregarUni.Anchor = AnchorStyles.None;
            btnAgregarUni.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarUni.Cursor = Cursors.Hand;
            btnAgregarUni.FlatAppearance.BorderSize = 0;
            btnAgregarUni.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnAgregarUni.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAgregarUni.FlatStyle = FlatStyle.Flat;
            btnAgregarUni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarUni.ForeColor = Color.White;
            btnAgregarUni.Location = new Point(37, 56);
            btnAgregarUni.Name = "btnAgregarUni";
            btnAgregarUni.Size = new Size(356, 28);
            btnAgregarUni.TabIndex = 6;
            btnAgregarUni.Text = "Agregar unidad";
            btnAgregarUni.UseVisualStyleBackColor = false;
            // 
            // btnBuscarUni
            // 
            btnBuscarUni.Anchor = AnchorStyles.None;
            btnBuscarUni.BackColor = SystemColors.HotTrack;
            btnBuscarUni.Cursor = Cursors.Hand;
            btnBuscarUni.FlatAppearance.BorderSize = 0;
            btnBuscarUni.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnBuscarUni.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnBuscarUni.FlatStyle = FlatStyle.Flat;
            btnBuscarUni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarUni.ForeColor = Color.White;
            btnBuscarUni.Location = new Point(37, 9);
            btnBuscarUni.Name = "btnBuscarUni";
            btnBuscarUni.Size = new Size(356, 28);
            btnBuscarUni.TabIndex = 9;
            btnBuscarUni.Text = "Buscar unidad";
            btnBuscarUni.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(tableLayoutPanel8);
            panel2.Location = new Point(9, 587);
            panel2.Name = "panel2";
            panel2.Size = new Size(419, 67);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 361F));
            tableLayoutPanel8.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel8.Controls.Add(label2, 1, 0);
            tableLayoutPanel8.Location = new Point(0, 1);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(419, 66);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.BackgroundImage = Properties.Resources.bulb_icon_icons_com_74600;
            pictureBox1.Location = new Point(26, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 24);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(61, 13);
            label2.Name = "label2";
            label2.Size = new Size(286, 40);
            label2.TabIndex = 0;
            label2.Text = "Las unidades de medidas son utilizadas \r\nen la gestión de artículos e inventario.";
            // 
            // colCodigoUnidad
            // 
            colCodigoUnidad.HeaderText = "Código";
            colCodigoUnidad.MinimumWidth = 6;
            colCodigoUnidad.Name = "colCodigoUnidad";
            colCodigoUnidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            colCodigoUnidad.Width = 464;
            // 
            // colDescripcionUnidad
            // 
            colDescripcionUnidad.HeaderText = "Descripción";
            colDescripcionUnidad.MinimumWidth = 6;
            colDescripcionUnidad.Name = "colDescripcionUnidad";
            colDescripcionUnidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            colDescripcionUnidad.Width = 464;
            // 
            // colAccion
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new Padding(3);
            colAccion.DefaultCellStyle = dataGridViewCellStyle2;
            colAccion.FlatStyle = FlatStyle.Flat;
            colAccion.HeaderText = "Acción";
            colAccion.MinimumWidth = 6;
            colAccion.Name = "colAccion";
            colAccion.Text = "Eliminar";
            colAccion.UseColumnTextForButtonValue = true;
            colAccion.Width = 464;
            // 
            // MenuUnidadesMedidas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1872, 864);
            Controls.Add(tableLayoutPanel1);
            Name = "MenuUnidadesMedidas";
            Text = "Unidades de medidas";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvUnidad).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picClientes).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblUnidadesMedida;
        private DataGridView dgvUnidad;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label lblCodUni;
        private TextBox txtCodUni;
        private Label lblDesUni;
        private TextBox txtDesUni;
        private TableLayoutPanel tableLayoutPanel10;
        private Button btnAgregarUni;
        private Button btnBuscarUni;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel8;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel12;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox picClientes;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label5;
        private Label lblClientes;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button1;
        private DataGridViewTextBoxColumn colCodigoUnidad;
        private DataGridViewTextBoxColumn colDescripcionUnidad;
        private DataGridViewButtonColumn colAccion;
    }
}