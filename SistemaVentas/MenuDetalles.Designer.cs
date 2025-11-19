namespace SistemaVentas
{
    partial class MenuDetalles
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
            lblDetalle = new Label();
            dgvDetFact = new DataGridView();
            lblNumFacDet = new Label();
            txtNumFacdet = new TextBox();
            lblCodArtDet = new Label();
            cmbÇodArtDet = new ComboBox();
            lblCantDet = new Label();
            txtCantDet = new TextBox();
            lblPrecVen = new Label();
            txtPrecVent = new TextBox();
            btnAgregarDet = new Button();
            btnEliminarDet = new Button();
            btnVolverMenuPrincipal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetFact).BeginInit();
            SuspendLayout();
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Location = new Point(12, 9);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(75, 20);
            lblDetalle.TabIndex = 0;
            lblDetalle.Text = "DETALLES";
            // 
            // dgvDetFact
            // 
            dgvDetFact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetFact.Location = new Point(408, 12);
            dgvDetFact.Name = "dgvDetFact";
            dgvDetFact.RowHeadersWidth = 51;
            dgvDetFact.Size = new Size(212, 484);
            dgvDetFact.TabIndex = 1;
            // 
            // lblNumFacDet
            // 
            lblNumFacDet.AutoSize = true;
            lblNumFacDet.Location = new Point(12, 109);
            lblNumFacDet.Name = "lblNumFacDet";
            lblNumFacDet.Size = new Size(120, 20);
            lblNumFacDet.TabIndex = 2;
            lblNumFacDet.Text = "Número factura: ";
            // 
            // txtNumFacdet
            // 
            txtNumFacdet.Location = new Point(138, 102);
            txtNumFacdet.Name = "txtNumFacdet";
            txtNumFacdet.Size = new Size(264, 27);
            txtNumFacdet.TabIndex = 3;
            // 
            // lblCodArtDet
            // 
            lblCodArtDet.AutoSize = true;
            lblCodArtDet.Location = new Point(12, 143);
            lblCodArtDet.Name = "lblCodArtDet";
            lblCodArtDet.Size = new Size(64, 20);
            lblCodArtDet.TabIndex = 4;
            lblCodArtDet.Text = "Artículo:";
            // 
            // cmbÇodArtDet
            // 
            cmbÇodArtDet.FormattingEnabled = true;
            cmbÇodArtDet.Location = new Point(82, 135);
            cmbÇodArtDet.Name = "cmbÇodArtDet";
            cmbÇodArtDet.Size = new Size(320, 28);
            cmbÇodArtDet.TabIndex = 5;
            // 
            // lblCantDet
            // 
            lblCantDet.AutoSize = true;
            lblCantDet.Location = new Point(12, 176);
            lblCantDet.Name = "lblCantDet";
            lblCantDet.Size = new Size(72, 20);
            lblCantDet.TabIndex = 6;
            lblCantDet.Text = "Cantidad:";
            // 
            // txtCantDet
            // 
            txtCantDet.Location = new Point(90, 169);
            txtCantDet.Name = "txtCantDet";
            txtCantDet.Size = new Size(312, 27);
            txtCantDet.TabIndex = 7;
            // 
            // lblPrecVen
            // 
            lblPrecVen.AutoSize = true;
            lblPrecVen.Location = new Point(12, 209);
            lblPrecVen.Name = "lblPrecVen";
            lblPrecVen.Size = new Size(53, 20);
            lblPrecVen.TabIndex = 8;
            lblPrecVen.Text = "Precio:";
            // 
            // txtPrecVent
            // 
            txtPrecVent.Location = new Point(71, 202);
            txtPrecVent.Name = "txtPrecVent";
            txtPrecVent.Size = new Size(331, 27);
            txtPrecVent.TabIndex = 9;
            // 
            // btnAgregarDet
            // 
            btnAgregarDet.Location = new Point(12, 383);
            btnAgregarDet.Name = "btnAgregarDet";
            btnAgregarDet.Size = new Size(194, 29);
            btnAgregarDet.TabIndex = 10;
            btnAgregarDet.Text = " Agregar detalle";
            btnAgregarDet.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDet
            // 
            btnEliminarDet.Location = new Point(212, 383);
            btnEliminarDet.Name = "btnEliminarDet";
            btnEliminarDet.Size = new Size(190, 29);
            btnEliminarDet.TabIndex = 11;
            btnEliminarDet.Text = "Eliminar detalle";
            btnEliminarDet.UseVisualStyleBackColor = true;
            // 
            // btnVolverMenuPrincipal
            // 
            btnVolverMenuPrincipal.Location = new Point(12, 418);
            btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            btnVolverMenuPrincipal.Size = new Size(390, 29);
            btnVolverMenuPrincipal.TabIndex = 12;
            btnVolverMenuPrincipal.Text = "Volver al menú principal";
            btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            btnVolverMenuPrincipal.Click += btnVolverMenuPrincipal_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 508);
            Controls.Add(btnVolverMenuPrincipal);
            Controls.Add(btnEliminarDet);
            Controls.Add(btnAgregarDet);
            Controls.Add(txtPrecVent);
            Controls.Add(lblPrecVen);
            Controls.Add(txtCantDet);
            Controls.Add(lblCantDet);
            Controls.Add(cmbÇodArtDet);
            Controls.Add(lblCodArtDet);
            Controls.Add(txtNumFacdet);
            Controls.Add(lblNumFacDet);
            Controls.Add(dgvDetFact);
            Controls.Add(lblDetalle);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form5";
            Text = "Detalles";
            ((System.ComponentModel.ISupportInitialize)dgvDetFact).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDetalle;
        private DataGridView dgvDetFact;
        private Label lblNumFacDet;
        private TextBox txtNumFacdet;
        private Label lblCodArtDet;
        private ComboBox cmbÇodArtDet;
        private Label lblCantDet;
        private TextBox txtCantDet;
        private Label lblPrecVen;
        private TextBox txtPrecVent;
        private Button btnAgregarDet;
        private Button btnEliminarDet;
        private Button btnVolverMenuPrincipal;
    }
}