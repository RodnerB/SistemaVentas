namespace SistemaVentas
{
    partial class Form4
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvFacturas = new DataGridView();
            lblFacturacion = new Label();
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
            btnModificarFac = new Button();
            btnEliminarFac = new Button();
            btnBuscarFac = new Button();
            btnVolverMenuPrincipal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            SuspendLayout();
            // 
            // dgvFacturas
            // 
            dgvFacturas.AllowUserToAddRows = false;
            dgvFacturas.AllowUserToDeleteRows = false;
            dgvFacturas.AllowUserToResizeColumns = false;
            dgvFacturas.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Location = new Point(357, 9);
            dgvFacturas.Margin = new Padding(3, 2, 3, 2);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.RowHeadersVisible = false;
            dgvFacturas.RowHeadersWidth = 51;
            dgvFacturas.Size = new Size(467, 363);
            dgvFacturas.TabIndex = 0;
            // 
            // lblFacturacion
            // 
            lblFacturacion.AutoSize = true;
            lblFacturacion.Location = new Point(10, 7);
            lblFacturacion.Name = "lblFacturacion";
            lblFacturacion.Size = new Size(87, 15);
            lblFacturacion.TabIndex = 1;
            lblFacturacion.Text = "FACTURACIÓN";
            // 
            // lblNumFac
            // 
            lblNumFac.AutoSize = true;
            lblNumFac.Location = new Point(10, 74);
            lblNumFac.Name = "lblNumFac";
            lblNumFac.Size = new Size(94, 15);
            lblNumFac.TabIndex = 2;
            lblNumFac.Text = "Número factura:";
            // 
            // inpNumFactura
            // 
            inpNumFactura.Location = new Point(117, 68);
            inpNumFactura.Margin = new Padding(3, 2, 3, 2);
            inpNumFactura.Name = "inpNumFactura";
            inpNumFactura.Size = new Size(235, 23);
            inpNumFactura.TabIndex = 3;
            // 
            // lblFecFac
            // 
            lblFecFac.AutoSize = true;
            lblFecFac.Location = new Point(10, 97);
            lblFecFac.Name = "lblFecFac";
            lblFecFac.Size = new Size(41, 15);
            lblFecFac.TabIndex = 4;
            lblFecFac.Text = "Fecha:";
            // 
            // inpDateTime
            // 
            inpDateTime.Location = new Point(60, 93);
            inpDateTime.Margin = new Padding(3, 2, 3, 2);
            inpDateTime.Name = "inpDateTime";
            inpDateTime.Size = new Size(293, 23);
            inpDateTime.TabIndex = 5;
            // 
            // lblCodCliFac
            // 
            lblCodCliFac.AutoSize = true;
            lblCodCliFac.Location = new Point(10, 124);
            lblCodCliFac.Name = "lblCodCliFac";
            lblCodCliFac.Size = new Size(47, 15);
            lblCodCliFac.TabIndex = 6;
            lblCodCliFac.Text = "Cliente:";
            // 
            // cmbCodCliente
            // 
            cmbCodCliente.FormattingEnabled = true;
            cmbCodCliente.Location = new Point(74, 118);
            cmbCodCliente.Margin = new Padding(3, 2, 3, 2);
            cmbCodCliente.Name = "cmbCodCliente";
            cmbCodCliente.Size = new Size(279, 23);
            cmbCodCliente.TabIndex = 7;
            // 
            // lblCondicion
            // 
            lblCondicion.AutoSize = true;
            lblCondicion.Location = new Point(10, 149);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(65, 15);
            lblCondicion.TabIndex = 8;
            lblCondicion.Text = "Condición:";
            // 
            // cmbCondicion
            // 
            cmbCondicion.FormattingEnabled = true;
            cmbCondicion.Items.AddRange(new object[] { "Contado", "Credito" });
            cmbCondicion.Location = new Point(85, 143);
            cmbCondicion.Margin = new Padding(3, 2, 3, 2);
            cmbCondicion.Name = "cmbCondicion";
            cmbCondicion.Size = new Size(267, 23);
            cmbCondicion.TabIndex = 9;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(10, 174);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(66, 15);
            lblDescuento.TabIndex = 10;
            lblDescuento.Text = "Descuento:";
            // 
            // inpDescFactura
            // 
            inpDescFactura.Location = new Point(88, 169);
            inpDescFactura.Margin = new Padding(3, 2, 3, 2);
            inpDescFactura.Name = "inpDescFactura";
            inpDescFactura.Size = new Size(265, 23);
            inpDescFactura.TabIndex = 11;
            // 
            // lblMonFac
            // 
            lblMonFac.AutoSize = true;
            lblMonFac.Location = new Point(10, 199);
            lblMonFac.Name = "lblMonFac";
            lblMonFac.Size = new Size(86, 15);
            lblMonFac.TabIndex = 12;
            lblMonFac.Text = "Monto factura:";
            // 
            // inpMonFactura
            // 
            inpMonFactura.Location = new Point(108, 194);
            inpMonFactura.Margin = new Padding(3, 2, 3, 2);
            inpMonFactura.Name = "inpMonFactura";
            inpMonFactura.Size = new Size(244, 23);
            inpMonFactura.TabIndex = 13;
            // 
            // btnAgregarFac
            // 
            btnAgregarFac.Location = new Point(10, 298);
            btnAgregarFac.Margin = new Padding(3, 2, 3, 2);
            btnAgregarFac.Name = "btnAgregarFac";
            btnAgregarFac.Size = new Size(167, 22);
            btnAgregarFac.TabIndex = 14;
            btnAgregarFac.Text = "Agregar factura";
            btnAgregarFac.UseVisualStyleBackColor = true;
            btnAgregarFac.Click += btnAgregarFac_Click;
            // 
            // btnModificarFac
            // 
            btnModificarFac.Location = new Point(183, 298);
            btnModificarFac.Margin = new Padding(3, 2, 3, 2);
            btnModificarFac.Name = "btnModificarFac";
            btnModificarFac.Size = new Size(169, 22);
            btnModificarFac.TabIndex = 15;
            btnModificarFac.Text = "Modificar factura";
            btnModificarFac.UseVisualStyleBackColor = true;
            // 
            // btnEliminarFac
            // 
            btnEliminarFac.Location = new Point(183, 324);
            btnEliminarFac.Margin = new Padding(3, 2, 3, 2);
            btnEliminarFac.Name = "btnEliminarFac";
            btnEliminarFac.Size = new Size(169, 22);
            btnEliminarFac.TabIndex = 16;
            btnEliminarFac.Text = "Eliminar factura";
            btnEliminarFac.UseVisualStyleBackColor = true;
            // 
            // btnBuscarFac
            // 
            btnBuscarFac.Location = new Point(10, 324);
            btnBuscarFac.Margin = new Padding(3, 2, 3, 2);
            btnBuscarFac.Name = "btnBuscarFac";
            btnBuscarFac.Size = new Size(167, 22);
            btnBuscarFac.TabIndex = 17;
            btnBuscarFac.Text = "Buscar factura";
            btnBuscarFac.UseVisualStyleBackColor = true;
            // 
            // btnVolverMenuPrincipal
            // 
            btnVolverMenuPrincipal.Location = new Point(10, 350);
            btnVolverMenuPrincipal.Margin = new Padding(3, 2, 3, 2);
            btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            btnVolverMenuPrincipal.Size = new Size(341, 22);
            btnVolverMenuPrincipal.TabIndex = 18;
            btnVolverMenuPrincipal.Text = "Volver al menú principal";
            btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            btnVolverMenuPrincipal.Click += btnVolverMenuPrincipal_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 381);
            Controls.Add(btnVolverMenuPrincipal);
            Controls.Add(btnBuscarFac);
            Controls.Add(btnEliminarFac);
            Controls.Add(btnModificarFac);
            Controls.Add(btnAgregarFac);
            Controls.Add(inpMonFactura);
            Controls.Add(lblMonFac);
            Controls.Add(inpDescFactura);
            Controls.Add(lblDescuento);
            Controls.Add(cmbCondicion);
            Controls.Add(lblCondicion);
            Controls.Add(cmbCodCliente);
            Controls.Add(lblCodCliFac);
            Controls.Add(inpDateTime);
            Controls.Add(lblFecFac);
            Controls.Add(inpNumFactura);
            Controls.Add(lblNumFac);
            Controls.Add(lblFacturacion);
            Controls.Add(dgvFacturas);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form4";
            Text = "Facturación";
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFacturas;
        private Label lblFacturacion;
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
        private Button btnModificarFac;
        private Button btnEliminarFac;
        private Button btnBuscarFac;
        private Button btnVolverMenuPrincipal;
    }
}