namespace SistemaVentas
{
    partial class MenuVentas
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel8 = new TableLayoutPanel();
            picClientes = new PictureBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            label5 = new Label();
            lblVentas = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            btnVolverMenuPrincipal = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblTotalMonto = new Label();
            btnFacturar = new Button();
            lblTotal = new Label();
            dgvProductosSeleccionados = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colPrecioUnitario = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colEliminar = new DataGridViewButtonColumn();
            label2 = new Label();
            panel3 = new Panel();
            tableLayoutPanel10 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            lblBuscarProducto = new Label();
            lstResultadosBusqueda = new ListBox();
            txtBuscarProducto = new TextBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClientes).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosSeleccionados).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1906, 1055);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel3.Controls.Add(panel1, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1900, 72);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tableLayoutPanel8);
            panel1.Controls.Add(tableLayoutPanel7);
            panel1.Controls.Add(tableLayoutPanel9);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 66);
            panel1.TabIndex = 2;
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
            tableLayoutPanel8.Size = new Size(53, 58);
            tableLayoutPanel8.TabIndex = 31;
            // 
            // picClientes
            // 
            picClientes.Anchor = AnchorStyles.Right;
            picClientes.BackColor = Color.Transparent;
            picClientes.BackgroundImage = Properties.Resources.sale_basket_cart_ecommerce_on_buy_shop_trolley_bag_shopping_icon_266849__1_;
            picClientes.Location = new Point(4, 7);
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
            tableLayoutPanel7.Controls.Add(lblVentas, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Right;
            tableLayoutPanel7.Location = new Point(112, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(357, 66);
            tableLayoutPanel7.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(3, 33);
            label5.Name = "label5";
            label5.Size = new Size(163, 20);
            label5.TabIndex = 2;
            label5.Text = "Administra tus ventas";
            // 
            // lblVentas
            // 
            lblVentas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblVentas.AutoSize = true;
            lblVentas.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblVentas.Location = new Point(3, 2);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(85, 31);
            lblVentas.TabIndex = 1;
            lblVentas.Text = "Ventas";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(btnVolverMenuPrincipal, 0, 0);
            tableLayoutPanel9.Location = new Point(0, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(48, 58);
            tableLayoutPanel9.TabIndex = 29;
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
            btnVolverMenuPrincipal.Size = new Size(33, 26);
            btnVolverMenuPrincipal.TabIndex = 28;
            btnVolverMenuPrincipal.UseVisualStyleBackColor = false;
            btnVolverMenuPrincipal.Click += BtnVolverMenu_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Location = new Point(478, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 60.82474F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 39.17526F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tableLayoutPanel6.Size = new Size(1401, 66);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.AliceBlue;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 2);
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 81);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 96.47577F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 3.524229F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 654F));
            tableLayoutPanel2.Size = new Size(1900, 939);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 287);
            panel2.Name = "panel2";
            panel2.Size = new Size(1894, 649);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel5.Controls.Add(dgvProductosSeleccionados, 0, 1);
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 11.2847223F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 88.71528F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel5.Size = new Size(1894, 649);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.52767F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.4723244F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel4.Controls.Add(lblTotalMonto, 2, 0);
            tableLayoutPanel4.Controls.Add(btnFacturar, 0, 0);
            tableLayoutPanel4.Controls.Add(lblTotal, 1, 0);
            tableLayoutPanel4.Location = new Point(1148, 579);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(743, 67);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // lblTotalMonto
            // 
            lblTotalMonto.Anchor = AnchorStyles.Left;
            lblTotalMonto.AutoSize = true;
            lblTotalMonto.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalMonto.ForeColor = Color.Green;
            lblTotalMonto.Location = new Point(545, 17);
            lblTotalMonto.Name = "lblTotalMonto";
            lblTotalMonto.Size = new Size(77, 32);
            lblTotalMonto.TabIndex = 6;
            lblTotalMonto.Text = "$0.00";
            // 
            // btnFacturar
            // 
            btnFacturar.Anchor = AnchorStyles.Right;
            btnFacturar.BackColor = Color.FromArgb(0, 192, 0);
            btnFacturar.Cursor = Cursors.Hand;
            btnFacturar.FlatAppearance.BorderSize = 0;
            btnFacturar.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnFacturar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnFacturar.FlatStyle = FlatStyle.Flat;
            btnFacturar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFacturar.ForeColor = Color.White;
            btnFacturar.Location = new Point(151, 8);
            btnFacturar.Margin = new Padding(3, 4, 3, 4);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(212, 51);
            btnFacturar.TabIndex = 7;
            btnFacturar.Text = "Facturar";
            btnFacturar.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.None;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotal.Location = new Point(369, 17);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(170, 32);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total a Pagar:";
            // 
            // dgvProductosSeleccionados
            // 
            dgvProductosSeleccionados.AllowUserToAddRows = false;
            dgvProductosSeleccionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductosSeleccionados.BackgroundColor = SystemColors.ButtonHighlight;
            dgvProductosSeleccionados.BorderStyle = BorderStyle.None;
            dgvProductosSeleccionados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProductosSeleccionados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductosSeleccionados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductosSeleccionados.ColumnHeadersHeight = 40;
            dgvProductosSeleccionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductosSeleccionados.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colDescripcion, colPrecioUnitario, colCantidad, colSubtotal, colEliminar });
            dgvProductosSeleccionados.Dock = DockStyle.Fill;
            dgvProductosSeleccionados.EnableHeadersVisualStyles = false;
            dgvProductosSeleccionados.GridColor = Color.LightGray;
            dgvProductosSeleccionados.Location = new Point(3, 69);
            dgvProductosSeleccionados.Margin = new Padding(3, 4, 3, 4);
            dgvProductosSeleccionados.Name = "dgvProductosSeleccionados";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductosSeleccionados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductosSeleccionados.RowHeadersVisible = false;
            dgvProductosSeleccionados.RowHeadersWidth = 51;
            dgvProductosSeleccionados.Size = new Size(1888, 503);
            dgvProductosSeleccionados.TabIndex = 6;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // colPrecioUnitario
            // 
            colPrecioUnitario.HeaderText = "Precio Unitario";
            colPrecioUnitario.MinimumWidth = 6;
            colPrecioUnitario.Name = "colPrecioUnitario";
            colPrecioUnitario.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 6;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // colEliminar
            // 
            colEliminar.HeaderText = "Accion";
            colEliminar.MinimumWidth = 6;
            colEliminar.Name = "colEliminar";
            colEliminar.Text = "Eliminar";
            colEliminar.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(403, 46);
            label2.TabIndex = 7;
            label2.Text = "Artículos seleccionados ";
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel10);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1894, 268);
            panel3.TabIndex = 1;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(tableLayoutPanel11, 0, 0);
            tableLayoutPanel10.Location = new Point(0, 0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(1870, 287);
            tableLayoutPanel10.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(lblBuscarProducto, 0, 1);
            tableLayoutPanel11.Controls.Add(lstResultadosBusqueda, 0, 3);
            tableLayoutPanel11.Controls.Add(txtBuscarProducto, 0, 2);
            tableLayoutPanel11.Controls.Add(label1, 0, 0);
            tableLayoutPanel11.Location = new Point(3, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 4;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 63.88889F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 36.11111F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 166F));
            tableLayoutPanel11.Size = new Size(775, 281);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscarProducto.Location = new Point(3, 60);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(254, 20);
            lblBuscarProducto.TabIndex = 1;
            lblBuscarProducto.Text = "Buscar Producto (Código o Nombre):";
            // 
            // lstResultadosBusqueda
            // 
            lstResultadosBusqueda.BackColor = SystemColors.ButtonHighlight;
            lstResultadosBusqueda.BorderStyle = BorderStyle.None;
            lstResultadosBusqueda.Font = new Font("Segoe UI", 10F);
            lstResultadosBusqueda.FormattingEnabled = true;
            lstResultadosBusqueda.ItemHeight = 23;
            lstResultadosBusqueda.Location = new Point(3, 118);
            lstResultadosBusqueda.Margin = new Padding(3, 4, 3, 4);
            lstResultadosBusqueda.Name = "lstResultadosBusqueda";
            lstResultadosBusqueda.Size = new Size(591, 138);
            lstResultadosBusqueda.TabIndex = 3;
            lstResultadosBusqueda.Visible = false;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(3, 83);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(591, 27);
            txtBuscarProducto.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(221, 46);
            label1.TabIndex = 5;
            label1.Text = "Nueva Venta";
            // 
            // MenuVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1906, 1055);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuVentas";
            Text = "Ventas";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picClientes).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosSeleccionados).EndInit();
            panel3.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox lstResultadosBusqueda;
        private Label lblBuscarProducto;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox txtBuscarProducto;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel8;
        private PictureBox picClientes;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label5;
        private Label lblVentas;
        private TableLayoutPanel tableLayoutPanel9;
        private Button btnVolverMenuPrincipal;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblTotalMonto;
        private Button btnFacturar;
        private Label lblTotal;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridView dgvProductosSeleccionados;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colPrecioUnitario;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewButtonColumn colEliminar;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel11;
        private Label label1;
        private Label label2;
    }
}