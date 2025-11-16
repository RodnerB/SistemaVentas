namespace SistemaVentas
{
    partial class Form3
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
            dgvArticulos = new DataGridView();
            lblArticulos = new Label();
            lblCodArt = new Label();
            txtCodArt = new TextBox();
            lblDesArt = new Label();
            txtDesArt = new TextBox();
            lblCodUni = new Label();
            cmbCodUni = new ComboBox();
            lblExiMin = new Label();
            txtExiMin = new TextBox();
            lblExiMax = new Label();
            txtExiMax = new TextBox();
            lblExiAct = new Label();
            txtExiAct = new TextBox();
            lblCosArt = new Label();
            lblPreArt = new Label();
            txtPreArt = new TextBox();
            txtCosArt = new TextBox();
            btnAgregarArt = new Button();
            btnModificarArt = new Button();
            btnEliminarArt = new Button();
            btnBuscarArt = new Button();
            btnVolverMenuPrincipal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            SuspendLayout();
            // 
            // dgvArticulos
            // 
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Location = new Point(408, 12);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.RowHeadersWidth = 51;
            dgvArticulos.Size = new Size(924, 484);
            dgvArticulos.TabIndex = 0;
            // 
            // lblArticulos
            // 
            lblArticulos.AutoSize = true;
            lblArticulos.Location = new Point(12, 9);
            lblArticulos.Name = "lblArticulos";
            lblArticulos.Size = new Size(83, 20);
            lblArticulos.TabIndex = 1;
            lblArticulos.Text = "ARTÍCULOS";
            // 
            // lblCodArt
            // 
            lblCodArt.AutoSize = true;
            lblCodArt.Location = new Point(12, 50);
            lblCodArt.Name = "lblCodArt";
            lblCodArt.Size = new Size(61, 20);
            lblCodArt.TabIndex = 2;
            lblCodArt.Text = "Código:";
            // 
            // txtCodArt
            // 
            txtCodArt.Location = new Point(79, 43);
            txtCodArt.Name = "txtCodArt";
            txtCodArt.Size = new Size(323, 27);
            txtCodArt.TabIndex = 3;
            // 
            // lblDesArt
            // 
            lblDesArt.AutoSize = true;
            lblDesArt.Location = new Point(12, 83);
            lblDesArt.Name = "lblDesArt";
            lblDesArt.Size = new Size(90, 20);
            lblDesArt.TabIndex = 4;
            lblDesArt.Text = "Descripción:";
            // 
            // txtDesArt
            // 
            txtDesArt.Location = new Point(108, 76);
            txtDesArt.Name = "txtDesArt";
            txtDesArt.Size = new Size(294, 27);
            txtDesArt.TabIndex = 5;
            // 
            // lblCodUni
            // 
            lblCodUni.AutoSize = true;
            lblCodUni.Location = new Point(13, 117);
            lblCodUni.Name = "lblCodUni";
            lblCodUni.Size = new Size(60, 20);
            lblCodUni.TabIndex = 6;
            lblCodUni.Text = "Unidad:";
            // 
            // cmbCodUni
            // 
            cmbCodUni.FormattingEnabled = true;
            cmbCodUni.Location = new Point(79, 109);
            cmbCodUni.Name = "cmbCodUni";
            cmbCodUni.Size = new Size(323, 28);
            cmbCodUni.TabIndex = 7;
            // 
            // lblExiMin
            // 
            lblExiMin.AutoSize = true;
            lblExiMin.Location = new Point(13, 150);
            lblExiMin.Name = "lblExiMin";
            lblExiMin.Size = new Size(131, 20);
            lblExiMin.TabIndex = 8;
            lblExiMin.Text = "Existencia mínima:";
            // 
            // txtExiMin
            // 
            txtExiMin.Location = new Point(150, 143);
            txtExiMin.Name = "txtExiMin";
            txtExiMin.Size = new Size(252, 27);
            txtExiMin.TabIndex = 9;
            // 
            // lblExiMax
            // 
            lblExiMax.AutoSize = true;
            lblExiMax.Location = new Point(13, 183);
            lblExiMax.Name = "lblExiMax";
            lblExiMax.Size = new Size(134, 20);
            lblExiMax.TabIndex = 10;
            lblExiMax.Text = "Existencia máxima:";
            // 
            // txtExiMax
            // 
            txtExiMax.Location = new Point(153, 176);
            txtExiMax.Name = "txtExiMax";
            txtExiMax.Size = new Size(249, 27);
            txtExiMax.TabIndex = 11;
            // 
            // lblExiAct
            // 
            lblExiAct.AutoSize = true;
            lblExiAct.Location = new Point(13, 216);
            lblExiAct.Name = "lblExiAct";
            lblExiAct.Size = new Size(121, 20);
            lblExiAct.TabIndex = 12;
            lblExiAct.Text = "Existencia actual:";
            // 
            // txtExiAct
            // 
            txtExiAct.Location = new Point(140, 209);
            txtExiAct.Name = "txtExiAct";
            txtExiAct.Size = new Size(262, 27);
            txtExiAct.TabIndex = 13;
            // 
            // lblCosArt
            // 
            lblCosArt.AutoSize = true;
            lblCosArt.Location = new Point(12, 282);
            lblCosArt.Name = "lblCosArt";
            lblCosArt.Size = new Size(105, 20);
            lblCosArt.TabIndex = 14;
            lblCosArt.Text = "Costo compra:";
            // 
            // lblPreArt
            // 
            lblPreArt.AutoSize = true;
            lblPreArt.Location = new Point(12, 249);
            lblPreArt.Name = "lblPreArt";
            lblPreArt.Size = new Size(93, 20);
            lblPreArt.TabIndex = 15;
            lblPreArt.Text = "Precio venta:";
            // 
            // txtPreArt
            // 
            txtPreArt.Location = new Point(111, 242);
            txtPreArt.Name = "txtPreArt";
            txtPreArt.Size = new Size(291, 27);
            txtPreArt.TabIndex = 16;
            // 
            // txtCosArt
            // 
            txtCosArt.Location = new Point(123, 275);
            txtCosArt.Name = "txtCosArt";
            txtCosArt.Size = new Size(279, 27);
            txtCosArt.TabIndex = 17;
            // 
            // btnAgregarArt
            // 
            btnAgregarArt.Location = new Point(12, 379);
            btnAgregarArt.Name = "btnAgregarArt";
            btnAgregarArt.Size = new Size(193, 29);
            btnAgregarArt.TabIndex = 18;
            btnAgregarArt.Text = "Agregar artículo";
            btnAgregarArt.UseVisualStyleBackColor = true;
            btnAgregarArt.Click += btnAgregarArt_Click;
            // 
            // btnModificarArt
            // 
            btnModificarArt.Location = new Point(211, 379);
            btnModificarArt.Name = "btnModificarArt";
            btnModificarArt.Size = new Size(191, 29);
            btnModificarArt.TabIndex = 19;
            btnModificarArt.Text = "Modificar artículo";
            btnModificarArt.UseVisualStyleBackColor = true;
            btnModificarArt.Click += btnModificarArt_Click;
            // 
            // btnEliminarArt
            // 
            btnEliminarArt.Location = new Point(211, 414);
            btnEliminarArt.Name = "btnEliminarArt";
            btnEliminarArt.Size = new Size(191, 29);
            btnEliminarArt.TabIndex = 20;
            btnEliminarArt.Text = "Eliminar artículo";
            btnEliminarArt.UseVisualStyleBackColor = true;
            btnEliminarArt.Click += btnEliminarArt_Click;
            // 
            // btnBuscarArt
            // 
            btnBuscarArt.Location = new Point(12, 414);
            btnBuscarArt.Name = "btnBuscarArt";
            btnBuscarArt.Size = new Size(193, 29);
            btnBuscarArt.TabIndex = 21;
            btnBuscarArt.Text = "Buscar artículo";
            btnBuscarArt.UseVisualStyleBackColor = true;
            btnBuscarArt.Click += btnBuscarArt_Click;
            // 
            // btnVolverMenuPrincipal
            // 
            btnVolverMenuPrincipal.Location = new Point(13, 449);
            btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            btnVolverMenuPrincipal.Size = new Size(389, 29);
            btnVolverMenuPrincipal.TabIndex = 22;
            btnVolverMenuPrincipal.Text = "Volver al menú principal";
            btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            btnVolverMenuPrincipal.Click += btnVolverMenuPrincipal_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 508);
            Controls.Add(btnVolverMenuPrincipal);
            Controls.Add(btnBuscarArt);
            Controls.Add(btnEliminarArt);
            Controls.Add(btnModificarArt);
            Controls.Add(btnAgregarArt);
            Controls.Add(txtCosArt);
            Controls.Add(txtPreArt);
            Controls.Add(lblPreArt);
            Controls.Add(lblCosArt);
            Controls.Add(txtExiAct);
            Controls.Add(lblExiAct);
            Controls.Add(txtExiMax);
            Controls.Add(lblExiMax);
            Controls.Add(txtExiMin);
            Controls.Add(lblExiMin);
            Controls.Add(cmbCodUni);
            Controls.Add(lblCodUni);
            Controls.Add(txtDesArt);
            Controls.Add(lblDesArt);
            Controls.Add(txtCodArt);
            Controls.Add(lblCodArt);
            Controls.Add(lblArticulos);
            Controls.Add(dgvArticulos);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            Text = "Artículos";
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvArticulos;
        private Label lblArticulos;
        private Label lblCodArt;
        private TextBox txtCodArt;
        private Label lblDesArt;
        private TextBox txtDesArt;
        private Label lblCodUni;
        private ComboBox cmbCodUni;
        private Label lblExiMin;
        private TextBox txtExiMin;
        private Label lblExiMax;
        private TextBox txtExiMax;
        private Label lblExiAct;
        private TextBox txtExiAct;
        private Label lblCosArt;
        private Label lblPreArt;
        private TextBox txtPreArt;
        private TextBox txtCosArt;
        private Button btnAgregarArt;
        private Button btnModificarArt;
        private Button btnEliminarArt;
        private Button btnBuscarArt;
        private Button btnVolverMenuPrincipal;
    }
}