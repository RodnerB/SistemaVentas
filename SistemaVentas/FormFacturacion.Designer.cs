namespace SistemaVentas
{
    partial class FormFacturacion
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
            btnGuardarFactura = new Button();
            btnCancelar = new Button();
            groupBoxResumen = new GroupBox();
            lblTotalFinalValor = new Label();
            lblTotalFinal = new Label();
            lblDescuentoValor = new Label();
            lblDescuentoAplicado = new Label();
            lblSubtotalValor = new Label();
            lblSubtotal = new Label();
            groupBoxResumen.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(34, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(260, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Facturar Productos";
            // 
            // lblNumFactura
            // 
            lblNumFactura.AutoSize = true;
            lblNumFactura.Font = new Font("Segoe UI", 11F);
            lblNumFactura.Location = new Point(34, 107);
            lblNumFactura.Name = "lblNumFactura";
            lblNumFactura.Size = new Size(190, 25);
            lblNumFactura.TabIndex = 1;
            lblNumFactura.Text = "Número de Factura: *";
            // 
            // txtNumFactura
            // 
            txtNumFactura.Font = new Font("Segoe UI", 11F);
            txtNumFactura.Location = new Point(251, 103);
            txtNumFactura.Margin = new Padding(3, 4, 3, 4);
            txtNumFactura.Name = "txtNumFactura";
            txtNumFactura.Size = new Size(342, 32);
            txtNumFactura.TabIndex = 2;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 11F);
            lblFecha.Location = new Point(34, 173);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(170, 25);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha de Factura: *";
            // 
            // dtpFechaFactura
            // 
            dtpFechaFactura.Font = new Font("Segoe UI", 11F);
            dtpFechaFactura.Format = DateTimePickerFormat.Short;
            dtpFechaFactura.Location = new Point(251, 169);
            dtpFechaFactura.Margin = new Padding(3, 4, 3, 4);
            dtpFechaFactura.Name = "dtpFechaFactura";
            dtpFechaFactura.Size = new Size(342, 32);
            dtpFechaFactura.TabIndex = 4;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 11F);
            lblCliente.Location = new Point(34, 240);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(88, 25);
            lblCliente.TabIndex = 5;
            lblCliente.Text = "Cliente: *";
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.Font = new Font("Segoe UI", 11F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(251, 236);
            cmbCliente.Margin = new Padding(3, 4, 3, 4);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(342, 33);
            cmbCliente.TabIndex = 6;
            // 
            // lblCondicion
            // 
            lblCondicion.AutoSize = true;
            lblCondicion.Font = new Font("Segoe UI", 11F);
            lblCondicion.Location = new Point(34, 307);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(115, 25);
            lblCondicion.TabIndex = 7;
            lblCondicion.Text = "Condición: *";
            // 
            // cmbCondicion
            // 
            cmbCondicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondicion.Font = new Font("Segoe UI", 11F);
            cmbCondicion.FormattingEnabled = true;
            cmbCondicion.Items.AddRange(new object[] { "Contado", "Crédito" });
            cmbCondicion.Location = new Point(251, 303);
            cmbCondicion.Margin = new Padding(3, 4, 3, 4);
            cmbCondicion.Name = "cmbCondicion";
            cmbCondicion.Size = new Size(342, 33);
            cmbCondicion.TabIndex = 8;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI", 11F);
            lblDescuento.Location = new Point(34, 373);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(138, 25);
            lblDescuento.TabIndex = 9;
            lblDescuento.Text = "Descuento (%):";
            // 
            // txtDescuento
            // 
            txtDescuento.Font = new Font("Segoe UI", 11F);
            txtDescuento.Location = new Point(251, 369);
            txtDescuento.Margin = new Padding(3, 4, 3, 4);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(171, 32);
            txtDescuento.TabIndex = 10;
            txtDescuento.Text = "0";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMontoTotal.Location = new Point(34, 453);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(169, 28);
            lblMontoTotal.TabIndex = 11;
            lblMontoTotal.Text = "Monto de Venta:";
            // 
            // lblTotalValor
            // 
            lblTotalValor.AutoSize = true;
            lblTotalValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalValor.ForeColor = Color.Green;
            lblTotalValor.Location = new Point(251, 453);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(65, 28);
            lblTotalValor.TabIndex = 12;
            lblTotalValor.Text = "$0.00";
            // 
            // btnGuardarFactura
            // 
            btnGuardarFactura.BackColor = Color.FromArgb(0, 192, 0);
            btnGuardarFactura.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardarFactura.ForeColor = Color.White;
            btnGuardarFactura.Location = new Point(320, 693);
            btnGuardarFactura.Margin = new Padding(3, 4, 3, 4);
            btnGuardarFactura.Name = "btnGuardarFactura";
            btnGuardarFactura.Size = new Size(274, 67);
            btnGuardarFactura.TabIndex = 13;
            btnGuardarFactura.Text = "Guardar Factura";
            btnGuardarFactura.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(34, 693);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(274, 67);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // groupBoxResumen
            // 
            groupBoxResumen.Controls.Add(lblTotalFinalValor);
            groupBoxResumen.Controls.Add(lblTotalFinal);
            groupBoxResumen.Controls.Add(lblDescuentoValor);
            groupBoxResumen.Controls.Add(lblDescuentoAplicado);
            groupBoxResumen.Controls.Add(lblSubtotalValor);
            groupBoxResumen.Controls.Add(lblSubtotal);
            groupBoxResumen.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxResumen.Location = new Point(34, 520);
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
            // FormFacturacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(629, 800);
            Controls.Add(groupBoxResumen);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarFactura);
            Controls.Add(lblTotalValor);
            Controls.Add(lblMontoTotal);
            Controls.Add(txtDescuento);
            Controls.Add(lblDescuento);
            Controls.Add(cmbCondicion);
            Controls.Add(lblCondicion);
            Controls.Add(cmbCliente);
            Controls.Add(lblCliente);
            Controls.Add(dtpFechaFactura);
            Controls.Add(lblFecha);
            Controls.Add(txtNumFactura);
            Controls.Add(lblNumFactura);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFacturacion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Facturar Venta";
            groupBoxResumen.ResumeLayout(false);
            groupBoxResumen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnGuardarFactura;
        private Button btnCancelar;
        private GroupBox groupBoxResumen;
        private Label lblTotalFinalValor;
        private Label lblTotalFinal;
        private Label lblDescuentoValor;
        private Label lblDescuentoAplicado;
        private Label lblSubtotalValor;
        private Label lblSubtotal;
    }
}
