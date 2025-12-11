namespace SistemaVentas
{
    partial class MenuFacturacion
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
            lblTitulo = new Label();
            lblNumFactura = new Label();
            txtNumFactura = new TextBox();
            lblFecha = new Label();
            dtpFechaFactura = new DateTimePicker();
            lblCliente = new Label();
            cmbCliente = new ComboBox();
            lblCondicion = new Label();
            cmbCondicion = new ComboBox();
            lblDescuento = new Label();
            txtDescuento = new TextBox();
            lblMontoTotal = new Label();
            lblTotalValor = new Label();
            groupBoxResumen = new GroupBox();
            lblTotalFinalValor = new Label();
            lblTotalFinal = new Label();
            lblDescuentoValor = new Label();
            lblDescuentoAplicado = new Label();
            lblSubtotalValor = new Label();
            lblSubtotal = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnCancelar = new Button();
            btnGuardarFactura = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            groupBoxResumen.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(260, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Facturar Productos";
            // 
            // lblNumFactura
            // 
            lblNumFactura.Anchor = AnchorStyles.Left;
            lblNumFactura.AutoSize = true;
            lblNumFactura.Font = new Font("Segoe UI", 11F);
            lblNumFactura.Location = new Point(3, 16);
            lblNumFactura.Name = "lblNumFactura";
            lblNumFactura.Size = new Size(182, 25);
            lblNumFactura.TabIndex = 1;
            lblNumFactura.Text = "Número de Factura: ";
            // 
            // txtNumFactura
            // 
            txtNumFactura.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNumFactura.Font = new Font("Segoe UI", 11F);
            txtNumFactura.Location = new Point(207, 12);
            txtNumFactura.Margin = new Padding(3, 4, 3, 4);
            txtNumFactura.Name = "txtNumFactura";
            txtNumFactura.Size = new Size(362, 32);
            txtNumFactura.TabIndex = 2;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Left;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 11F);
            lblFecha.Location = new Point(3, 73);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(162, 25);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha de Factura: ";
            // 
            // dtpFechaFactura
            // 
            dtpFechaFactura.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaFactura.Font = new Font("Segoe UI", 11F);
            dtpFechaFactura.Format = DateTimePickerFormat.Short;
            dtpFechaFactura.Location = new Point(207, 69);
            dtpFechaFactura.Margin = new Padding(3, 4, 3, 4);
            dtpFechaFactura.Name = "dtpFechaFactura";
            dtpFechaFactura.Size = new Size(362, 32);
            dtpFechaFactura.TabIndex = 4;
            // 
            // lblCliente
            // 
            lblCliente.Anchor = AnchorStyles.Left;
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 11F);
            lblCliente.Location = new Point(3, 130);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(80, 25);
            lblCliente.TabIndex = 5;
            lblCliente.Text = "Cliente: ";
            // 
            // cmbCliente
            // 
            cmbCliente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.Font = new Font("Segoe UI", 11F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(207, 126);
            cmbCliente.Margin = new Padding(3, 4, 3, 4);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(362, 33);
            cmbCliente.TabIndex = 6;
            // 
            // lblCondicion
            // 
            lblCondicion.Anchor = AnchorStyles.Left;
            lblCondicion.AutoSize = true;
            lblCondicion.Font = new Font("Segoe UI", 11F);
            lblCondicion.Location = new Point(3, 187);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(107, 25);
            lblCondicion.TabIndex = 7;
            lblCondicion.Text = "Condición: ";
            // 
            // cmbCondicion
            // 
            cmbCondicion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbCondicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondicion.Font = new Font("Segoe UI", 11F);
            cmbCondicion.FormattingEnabled = true;
            cmbCondicion.Items.AddRange(new object[] { "Contado", "Crédito" });
            cmbCondicion.Location = new Point(207, 183);
            cmbCondicion.Margin = new Padding(3, 4, 3, 4);
            cmbCondicion.Name = "cmbCondicion";
            cmbCondicion.Size = new Size(362, 33);
            cmbCondicion.TabIndex = 8;
            // 
            // lblDescuento
            // 
            lblDescuento.Anchor = AnchorStyles.Left;
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI", 11F);
            lblDescuento.Location = new Point(3, 244);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(138, 25);
            lblDescuento.TabIndex = 9;
            lblDescuento.Text = "Descuento (%):";
            // 
            // txtDescuento
            // 
            txtDescuento.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDescuento.Font = new Font("Segoe UI", 11F);
            txtDescuento.Location = new Point(207, 240);
            txtDescuento.Margin = new Padding(3, 4, 3, 4);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(362, 32);
            txtDescuento.TabIndex = 10;
            txtDescuento.Text = "0";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.Anchor = AnchorStyles.Left;
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMontoTotal.Location = new Point(3, 302);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(169, 28);
            lblMontoTotal.TabIndex = 11;
            lblMontoTotal.Text = "Monto de Venta:";
            // 
            // lblTotalValor
            // 
            lblTotalValor.Anchor = AnchorStyles.Left;
            lblTotalValor.AutoSize = true;
            lblTotalValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalValor.ForeColor = Color.Green;
            lblTotalValor.Location = new Point(207, 302);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(65, 28);
            lblTotalValor.TabIndex = 12;
            lblTotalValor.Text = "$0.00";
            // 
            // groupBoxResumen
            // 
            groupBoxResumen.Anchor = AnchorStyles.None;
            groupBoxResumen.Controls.Add(lblTotalFinalValor);
            groupBoxResumen.Controls.Add(lblTotalFinal);
            groupBoxResumen.Controls.Add(lblDescuentoValor);
            groupBoxResumen.Controls.Add(lblDescuentoAplicado);
            groupBoxResumen.Controls.Add(lblSubtotalValor);
            groupBoxResumen.Controls.Add(lblSubtotal);
            groupBoxResumen.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxResumen.Location = new Point(9, 404);
            groupBoxResumen.Margin = new Padding(3, 4, 3, 4);
            groupBoxResumen.Name = "groupBoxResumen";
            groupBoxResumen.Padding = new Padding(3, 4, 3, 4);
            groupBoxResumen.Size = new Size(560, 147);
            groupBoxResumen.TabIndex = 15;
            groupBoxResumen.TabStop = false;
            groupBoxResumen.Text = "Resumen de Factura";
            // 
            // lblTotalFinalValor
            // 
            lblTotalFinalValor.AutoSize = true;
            lblTotalFinalValor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalFinalValor.ForeColor = Color.Green;
            lblTotalFinalValor.Location = new Point(229, 107);
            lblTotalFinalValor.Name = "lblTotalFinalValor";
            lblTotalFinalValor.Size = new Size(61, 25);
            lblTotalFinalValor.TabIndex = 5;
            lblTotalFinalValor.Text = "$0.00";
            // 
            // lblTotalFinal
            // 
            lblTotalFinal.AutoSize = true;
            lblTotalFinal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalFinal.Location = new Point(23, 107);
            lblTotalFinal.Name = "lblTotalFinal";
            lblTotalFinal.Size = new Size(133, 25);
            lblTotalFinal.TabIndex = 4;
            lblTotalFinal.Text = "Total a Pagar:";
            // 
            // lblDescuentoValor
            // 
            lblDescuentoValor.AutoSize = true;
            lblDescuentoValor.Font = new Font("Segoe UI", 10F);
            lblDescuentoValor.ForeColor = Color.Red;
            lblDescuentoValor.Location = new Point(229, 73);
            lblDescuentoValor.Name = "lblDescuentoValor";
            lblDescuentoValor.Size = new Size(50, 23);
            lblDescuentoValor.TabIndex = 3;
            lblDescuentoValor.Text = "$0.00";
            // 
            // lblDescuentoAplicado
            // 
            lblDescuentoAplicado.AutoSize = true;
            lblDescuentoAplicado.Font = new Font("Segoe UI", 10F);
            lblDescuentoAplicado.Location = new Point(23, 73);
            lblDescuentoAplicado.Name = "lblDescuentoAplicado";
            lblDescuentoAplicado.Size = new Size(95, 23);
            lblDescuentoAplicado.TabIndex = 2;
            lblDescuentoAplicado.Text = "Descuento:";
            // 
            // lblSubtotalValor
            // 
            lblSubtotalValor.AutoSize = true;
            lblSubtotalValor.Font = new Font("Segoe UI", 10F);
            lblSubtotalValor.Location = new Point(229, 40);
            lblSubtotalValor.Name = "lblSubtotalValor";
            lblSubtotalValor.Size = new Size(50, 23);
            lblSubtotalValor.TabIndex = 1;
            lblSubtotalValor.Text = "$0.00";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 10F);
            lblSubtotal.Location = new Point(23, 40);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(78, 23);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "Subtotal:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 96F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.Size = new Size(629, 800);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel2.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Location = new Point(16, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(596, 762);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 756);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 5.79096031F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 78.1073456F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15.9604521F));
            tableLayoutPanel3.Size = new Size(590, 756);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnCancelar, 0, 0);
            tableLayoutPanel4.Controls.Add(btnGuardarFactura, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 637);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(584, 116);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(51, 31);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(190, 53);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardarFactura
            // 
            btnGuardarFactura.Anchor = AnchorStyles.None;
            btnGuardarFactura.BackColor = Color.FromArgb(0, 192, 0);
            btnGuardarFactura.FlatAppearance.BorderSize = 0;
            btnGuardarFactura.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnGuardarFactura.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnGuardarFactura.FlatStyle = FlatStyle.Flat;
            btnGuardarFactura.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardarFactura.ForeColor = Color.White;
            btnGuardarFactura.Location = new Point(343, 31);
            btnGuardarFactura.Margin = new Padding(3, 4, 3, 4);
            btnGuardarFactura.Name = "btnGuardarFactura";
            btnGuardarFactura.Size = new Size(190, 53);
            btnGuardarFactura.TabIndex = 13;
            btnGuardarFactura.Text = "Guardar Factura";
            btnGuardarFactura.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(panel2, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 46);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(584, 585);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(578, 579);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Controls.Add(groupBoxResumen, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 65.2495346F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 34.75046F));
            tableLayoutPanel6.Size = new Size(578, 579);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.72621F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.27379F));
            tableLayoutPanel7.Controls.Add(lblMontoTotal, 0, 5);
            tableLayoutPanel7.Controls.Add(lblTotalValor, 1, 5);
            tableLayoutPanel7.Controls.Add(txtNumFactura, 1, 0);
            tableLayoutPanel7.Controls.Add(lblNumFactura, 0, 0);
            tableLayoutPanel7.Controls.Add(lblDescuento, 0, 4);
            tableLayoutPanel7.Controls.Add(dtpFechaFactura, 1, 1);
            tableLayoutPanel7.Controls.Add(lblFecha, 0, 1);
            tableLayoutPanel7.Controls.Add(lblCondicion, 0, 3);
            tableLayoutPanel7.Controls.Add(cmbCondicion, 1, 3);
            tableLayoutPanel7.Controls.Add(cmbCliente, 1, 2);
            tableLayoutPanel7.Controls.Add(txtDescuento, 1, 4);
            tableLayoutPanel7.Controls.Add(lblCliente, 0, 2);
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 6;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(572, 347);
            tableLayoutPanel7.TabIndex = 16;
            // 
            // FormFacturacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(629, 800);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFacturacion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Facturar Venta";
            groupBoxResumen.ResumeLayout(false);
            groupBoxResumen.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblNumFactura;
        private TextBox txtNumFactura;
        private Label lblFecha;
        private DateTimePicker dtpFechaFactura;
        private Label lblCliente;
        private ComboBox cmbCliente;
        private Label lblCondicion;
        private ComboBox cmbCondicion;
        private Label lblDescuento;
        private TextBox txtDescuento;
        private Label lblMontoTotal;
        private Label lblTotalValor;
        private GroupBox groupBoxResumen;
        private Label lblTotalFinalValor;
        private Label lblTotalFinal;
        private Label lblDescuentoValor;
        private Label lblDescuentoAplicado;
        private Label lblSubtotalValor;
        private Label lblSubtotal;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnCancelar;
        private Button btnGuardarFactura;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
    }
}
