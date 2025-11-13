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
            dataGridView1 = new DataGridView();
            lblFacturacion = new Label();
            lblNumFac = new Label();
            txtNumFac = new TextBox();
            lblFecFac = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblCodCliFac = new Label();
            cmbCodCliFax = new ComboBox();
            lblCondicion = new Label();
            cmbCondicion = new ComboBox();
            lblDescuento = new Label();
            txtDescuento = new TextBox();
            lblMonFac = new Label();
            txtMonFac = new TextBox();
            btnAgregarFAc = new Button();
            btnModificarFac = new Button();
            btnEliminarFac = new Button();
            btnBuscarFac = new Button();
            btnVolverMenuPrincipal = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(408, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(212, 484);
            dataGridView1.TabIndex = 0;
            // 
            // lblFacturacion
            // 
            lblFacturacion.AutoSize = true;
            lblFacturacion.Location = new Point(12, 9);
            lblFacturacion.Name = "lblFacturacion";
            lblFacturacion.Size = new Size(106, 20);
            lblFacturacion.TabIndex = 1;
            lblFacturacion.Text = "FACTURACIÓN";
            // 
            // lblNumFac
            // 
            lblNumFac.AutoSize = true;
            lblNumFac.Location = new Point(12, 98);
            lblNumFac.Name = "lblNumFac";
            lblNumFac.Size = new Size(116, 20);
            lblNumFac.TabIndex = 2;
            lblNumFac.Text = "Número factura:";
            // 
            // txtNumFac
            // 
            txtNumFac.Location = new Point(134, 91);
            txtNumFac.Name = "txtNumFac";
            txtNumFac.Size = new Size(268, 27);
            txtNumFac.TabIndex = 3;
            // 
            // lblFecFac
            // 
            lblFecFac.AutoSize = true;
            lblFecFac.Location = new Point(12, 129);
            lblFecFac.Name = "lblFecFac";
            lblFecFac.Size = new Size(50, 20);
            lblFecFac.TabIndex = 4;
            lblFecFac.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(68, 124);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(334, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // lblCodCliFac
            // 
            lblCodCliFac.AutoSize = true;
            lblCodCliFac.Location = new Point(12, 165);
            lblCodCliFac.Name = "lblCodCliFac";
            lblCodCliFac.Size = new Size(58, 20);
            lblCodCliFac.TabIndex = 6;
            lblCodCliFac.Text = "Cliente:";
            // 
            // cmbCodCliFax
            // 
            cmbCodCliFax.FormattingEnabled = true;
            cmbCodCliFax.Location = new Point(84, 157);
            cmbCodCliFax.Name = "cmbCodCliFax";
            cmbCodCliFax.Size = new Size(318, 28);
            cmbCodCliFax.TabIndex = 7;
            // 
            // lblCondicion
            // 
            lblCondicion.AutoSize = true;
            lblCondicion.Location = new Point(12, 199);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(79, 20);
            lblCondicion.TabIndex = 8;
            lblCondicion.Text = "Condición:";
            // 
            // cmbCondicion
            // 
            cmbCondicion.FormattingEnabled = true;
            cmbCondicion.Location = new Point(97, 191);
            cmbCondicion.Name = "cmbCondicion";
            cmbCondicion.Size = new Size(305, 28);
            cmbCondicion.TabIndex = 9;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(12, 232);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(82, 20);
            lblDescuento.TabIndex = 10;
            lblDescuento.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(100, 225);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(302, 27);
            txtDescuento.TabIndex = 11;
            // 
            // lblMonFac
            // 
            lblMonFac.AutoSize = true;
            lblMonFac.Location = new Point(12, 265);
            lblMonFac.Name = "lblMonFac";
            lblMonFac.Size = new Size(106, 20);
            lblMonFac.TabIndex = 12;
            lblMonFac.Text = "Monto factura:";
            // 
            // txtMonFac
            // 
            txtMonFac.Location = new Point(124, 258);
            txtMonFac.Name = "txtMonFac";
            txtMonFac.Size = new Size(278, 27);
            txtMonFac.TabIndex = 13;
            // 
            // btnAgregarFAc
            // 
            btnAgregarFAc.Location = new Point(12, 397);
            btnAgregarFAc.Name = "btnAgregarFAc";
            btnAgregarFAc.Size = new Size(191, 29);
            btnAgregarFAc.TabIndex = 14;
            btnAgregarFAc.Text = "Agregar factura";
            btnAgregarFAc.UseVisualStyleBackColor = true;
            // 
            // btnModificarFac
            // 
            btnModificarFac.Location = new Point(209, 397);
            btnModificarFac.Name = "btnModificarFac";
            btnModificarFac.Size = new Size(193, 29);
            btnModificarFac.TabIndex = 15;
            btnModificarFac.Text = "Modificar factura";
            btnModificarFac.UseVisualStyleBackColor = true;
            // 
            // btnEliminarFac
            // 
            btnEliminarFac.Location = new Point(209, 432);
            btnEliminarFac.Name = "btnEliminarFac";
            btnEliminarFac.Size = new Size(193, 29);
            btnEliminarFac.TabIndex = 16;
            btnEliminarFac.Text = "Eliminar factura";
            btnEliminarFac.UseVisualStyleBackColor = true;
            // 
            // btnBuscarFac
            // 
            btnBuscarFac.Location = new Point(12, 432);
            btnBuscarFac.Name = "btnBuscarFac";
            btnBuscarFac.Size = new Size(191, 29);
            btnBuscarFac.TabIndex = 17;
            btnBuscarFac.Text = "Buscar factura";
            btnBuscarFac.UseVisualStyleBackColor = true;
            // 
            // btnVolverMenuPrincipal
            // 
            btnVolverMenuPrincipal.Location = new Point(12, 467);
            btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            btnVolverMenuPrincipal.Size = new Size(390, 29);
            btnVolverMenuPrincipal.TabIndex = 18;
            btnVolverMenuPrincipal.Text = "Volver al menú principal";
            btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            btnVolverMenuPrincipal.Click += btnVolverMenuPrincipal_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 508);
            Controls.Add(btnVolverMenuPrincipal);
            Controls.Add(btnBuscarFac);
            Controls.Add(btnEliminarFac);
            Controls.Add(btnModificarFac);
            Controls.Add(btnAgregarFAc);
            Controls.Add(txtMonFac);
            Controls.Add(lblMonFac);
            Controls.Add(txtDescuento);
            Controls.Add(lblDescuento);
            Controls.Add(cmbCondicion);
            Controls.Add(lblCondicion);
            Controls.Add(cmbCodCliFax);
            Controls.Add(lblCodCliFac);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblFecFac);
            Controls.Add(txtNumFac);
            Controls.Add(lblNumFac);
            Controls.Add(lblFacturacion);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form4";
            Text = "Facturación";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblFacturacion;
        private Label lblNumFac;
        private TextBox txtNumFac;
        private Label lblFecFac;
        private DateTimePicker dateTimePicker1;
        private Label lblCodCliFac;
        private ComboBox cmbCodCliFax;
        private Label lblCondicion;
        private ComboBox cmbCondicion;
        private Label lblDescuento;
        private TextBox txtDescuento;
        private Label lblMonFac;
        private TextBox txtMonFac;
        private Button btnAgregarFAc;
        private Button btnModificarFac;
        private Button btnEliminarFac;
        private Button btnBuscarFac;
        private Button btnVolverMenuPrincipal;
    }
}