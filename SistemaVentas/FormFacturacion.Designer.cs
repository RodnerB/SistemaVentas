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
            lblSubtotal = new Label();
            lblSubtotalValor = new Label();
            lblDescuentoAplicado = new Label();
            lblDescuentoValor = new Label();
            lblTotalFinal = new Label();
            lblTotalFinalValor = new Label();
            groupBoxResumen.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(215, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Facturar Productos";
            // 
            // lblNumFactura
            // 
            lblNumFactura.AutoSize = true;
            lblNumFactura.Font = new Font("Segoe UI", 11F);
            lblNumFactura.Location = new Point(30, 80);
            lblNumFactura.Name = "lblNumFactura";
            lblNumFactura.Size = new Size(158, 20);
            lblNumFactura.TabIndex = 1;
            lblNumFactura.Text = "Número de Factura: *";
            // 
            // txtNumFactura
            // 
            txtNumFactura.Font = new Font("Segoe UI", 11F);
            txtNumFactura.Location = new Point(220, 77);
            txtNumFactura.Name = "txtNumFactura";
            txtNumFactura.Size = new Size(300, 27);
            txtNumFactura.TabIndex = 2;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 11F);
            lblFecha.Location = new Point(30, 130);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(137, 20);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha de Factura: *";
            // 
            // dtpFechaFactura
            // 
            dtpFechaFactura.Font = new Font("Segoe UI", 11F);
            dtpFechaFactura.Format = DateTimePickerFormat.Short;
            dtpFechaFactura.Location = new Point(220, 127);
            dtpFechaFactura.Name = "dtpFechaFactura";
            dtpFechaFactura.Size = new Size(300, 27);
            dtpFechaFactura.TabIndex = 4;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 11F);
            lblCliente.Location = new Point(30, 180);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(71, 20);
            lblCliente.TabIndex = 5;
            lblCliente.Text = "Cliente: *";
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.Font = new Font("Segoe UI", 11F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(220, 177);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(300, 28);
            cmbCliente.TabIndex = 6;
            // 
            // lblCondicion
            // 
            lblCondicion.AutoSize = true;
            lblCondicion.Font = new Font("Segoe UI", 11F);
            lblCondicion.Location = new Point(30, 230);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(94, 20);
            lblCondicion.TabIndex = 7;
            lblCondicion.Text = "Condición: *";
            // 
            // cmbCondicion
            // 
            cmbCondicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondicion.Font = new Font("Segoe UI", 11F);
            cmbCondicion.FormattingEnabled = true;
            cmbCondicion.Items.AddRange(new object[] { "Contado", "Crédito" });
            cmbCondicion.Location = new Point(220, 227);
            cmbCondicion.Name = "cmbCondicion";
            cmbCondicion.Size = new Size(300, 28);
            cmbCondicion.TabIndex = 8;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI", 11F);
            lblDescuento.Location = new Point(30, 280);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(112, 20);
            lblDescuento.TabIndex = 9;
            lblDescuento.Text = "Descuento (%):";
            // 
            // txtDescuento
            // 
            txtDescuento.Font = new Font("Segoe UI", 11F);
            txtDescuento.Location = new Point(220, 277);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(150, 27);
            txtDescuento.TabIndex = 10;
            txtDescuento.Text = "0";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMontoTotal.Location = new Point(30, 340);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(140, 21);
            lblMontoTotal.TabIndex = 11;
            lblMontoTotal.Text = "Monto de Venta:";
            // 
            // lblTotalValor
            // 
            lblTotalValor.AutoSize = true;
            lblTotalValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalValor.ForeColor = Color.Green;
            lblTotalValor.Location = new Point(220, 340);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(54, 21);
            lblTotalValor.TabIndex = 12;
            lblTotalValor.Text = "$0.00";
            // 
            // btnGuardarFactura
            // 
            btnGuardarFactura.BackColor = Color.FromArgb(0, 192, 0);
            btnGuardarFactura.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardarFactura.ForeColor = Color.White;
            btnGuardarFactura.Location = new Point(280, 520);
            btnGuardarFactura.Name = "btnGuardarFactura";
            btnGuardarFactura.Size = new Size(240, 50);
            btnGuardarFactura.TabIndex = 13;
            btnGuardarFactura.Text = "Guardar Factura";
            btnGuardarFactura.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(30, 520);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(240, 50);
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
            groupBoxResumen.Location = new Point(30, 390);
            groupBoxResumen.Name = "groupBoxResumen";
            groupBoxResumen.Size = new Size(490, 110);
            groupBoxResumen.TabIndex = 15;
            groupBoxResumen.TabStop = false;
            groupBoxResumen.Text = "Resumen de Factura";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 10F);
            lblSubtotal.Location = new Point(20, 30);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(65, 19);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblSubtotalValor
            // 
            lblSubtotalValor.AutoSize = true;
            lblSubtotalValor.Font = new Font("Segoe UI", 10F);
            lblSubtotalValor.Location = new Point(200, 30);
            lblSubtotalValor.Name = "lblSubtotalValor";
            lblSubtotalValor.Size = new Size(44, 19);
            lblSubtotalValor.TabIndex = 1;
            lblSubtotalValor.Text = "$0.00";
            // 
            // lblDescuentoAplicado
            // 
            lblDescuentoAplicado.AutoSize = true;
            lblDescuentoAplicado.Font = new Font("Segoe UI", 10F);
            lblDescuentoAplicado.Location = new Point(20, 55);
            lblDescuentoAplicado.Name = "lblDescuentoAplicado";
            lblDescuentoAplicado.Size = new Size(79, 19);
            lblDescuentoAplicado.TabIndex = 2;
            lblDescuentoAplicado.Text = "Descuento:";
            // 
            // lblDescuentoValor
            // 
            lblDescuentoValor.AutoSize = true;
            lblDescuentoValor.Font = new Font("Segoe UI", 10F);
            lblDescuentoValor.ForeColor = Color.Red;
            lblDescuentoValor.Location = new Point(200, 55);
            lblDescuentoValor.Name = "lblDescuentoValor";
            lblDescuentoValor.Size = new Size(44, 19);
            lblDescuentoValor.TabIndex = 3;
            lblDescuentoValor.Text = "$0.00";
            // 
            // lblTotalFinal
            // 
            lblTotalFinal.AutoSize = true;
            lblTotalFinal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalFinal.Location = new Point(20, 80);
            lblTotalFinal.Name = "lblTotalFinal";
            lblTotalFinal.Size = new Size(95, 20);
            lblTotalFinal.TabIndex = 4;
            lblTotalFinal.Text = "Total a Pagar:";
            // 
            // lblTotalFinalValor
            // 
            lblTotalFinalValor.AutoSize = true;
            lblTotalFinalValor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalFinalValor.ForeColor = Color.Green;
            lblTotalFinalValor.Location = new Point(200, 80);
            lblTotalFinalValor.Name = "lblTotalFinalValor";
            lblTotalFinalValor.Size = new Size(50, 20);
            lblTotalFinalValor.TabIndex = 5;
            lblTotalFinalValor.Text = "$0.00";
            // 
            // FormFacturacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(550, 600);
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
