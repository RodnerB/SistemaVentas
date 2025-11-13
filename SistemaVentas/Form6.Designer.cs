namespace SistemaVentas
{
    partial class Form6
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
            dgvUnidades = new DataGridView();
            lblUnidadesMedida = new Label();
            lblCodUni = new Label();
            txtCodUni = new TextBox();
            lblDesUni = new Label();
            txtDesUni = new TextBox();
            btnAgregarUni = new Button();
            btnModificarUni = new Button();
            btnEliminarUni = new Button();
            btnBuscarUni = new Button();
            btnVolverMenuPrincipal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUnidades).BeginInit();
            SuspendLayout();
            // 
            // dgvUnidades
            // 
            dgvUnidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnidades.Location = new Point(408, 12);
            dgvUnidades.Name = "dgvUnidades";
            dgvUnidades.RowHeadersWidth = 51;
            dgvUnidades.Size = new Size(212, 484);
            dgvUnidades.TabIndex = 0;
            // 
            // lblUnidadesMedida
            // 
            lblUnidadesMedida.AutoSize = true;
            lblUnidadesMedida.Location = new Point(12, 12);
            lblUnidadesMedida.Name = "lblUnidadesMedida";
            lblUnidadesMedida.Size = new Size(174, 20);
            lblUnidadesMedida.TabIndex = 1;
            lblUnidadesMedida.Text = "UNIDADES DE MEDIDAS";
            // 
            // lblCodUni
            // 
            lblCodUni.AutoSize = true;
            lblCodUni.Location = new Point(12, 162);
            lblCodUni.Name = "lblCodUni";
            lblCodUni.Size = new Size(148, 20);
            lblCodUni.TabIndex = 2;
            lblCodUni.Text = "Código de la unidad:";
            lblCodUni.Click += lblCodUni_Click;
            // 
            // txtCodUni
            // 
            txtCodUni.Location = new Point(166, 155);
            txtCodUni.Name = "txtCodUni";
            txtCodUni.Size = new Size(236, 27);
            txtCodUni.TabIndex = 3;
            // 
            // lblDesUni
            // 
            lblDesUni.AutoSize = true;
            lblDesUni.Location = new Point(12, 195);
            lblDesUni.Name = "lblDesUni";
            lblDesUni.Size = new Size(90, 20);
            lblDesUni.TabIndex = 4;
            lblDesUni.Text = "Descripción:";
            // 
            // txtDesUni
            // 
            txtDesUni.Location = new Point(108, 188);
            txtDesUni.Name = "txtDesUni";
            txtDesUni.Size = new Size(294, 27);
            txtDesUni.TabIndex = 5;
            // 
            // btnAgregarUni
            // 
            btnAgregarUni.Location = new Point(12, 398);
            btnAgregarUni.Name = "btnAgregarUni";
            btnAgregarUni.Size = new Size(190, 29);
            btnAgregarUni.TabIndex = 6;
            btnAgregarUni.Text = "Agregar unidad";
            btnAgregarUni.UseVisualStyleBackColor = true;
            // 
            // btnModificarUni
            // 
            btnModificarUni.Location = new Point(208, 398);
            btnModificarUni.Name = "btnModificarUni";
            btnModificarUni.Size = new Size(194, 29);
            btnModificarUni.TabIndex = 7;
            btnModificarUni.Text = "Modificar unidad";
            btnModificarUni.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUni
            // 
            btnEliminarUni.Location = new Point(12, 433);
            btnEliminarUni.Name = "btnEliminarUni";
            btnEliminarUni.Size = new Size(190, 29);
            btnEliminarUni.TabIndex = 8;
            btnEliminarUni.Text = "Eliminar unidad";
            btnEliminarUni.UseVisualStyleBackColor = true;
            // 
            // btnBuscarUni
            // 
            btnBuscarUni.Location = new Point(208, 433);
            btnBuscarUni.Name = "btnBuscarUni";
            btnBuscarUni.Size = new Size(194, 29);
            btnBuscarUni.TabIndex = 9;
            btnBuscarUni.Text = "Buscar unidad";
            btnBuscarUni.UseVisualStyleBackColor = true;
            // 
            // btnVolverMenuPrincipal
            // 
            btnVolverMenuPrincipal.Location = new Point(12, 468);
            btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            btnVolverMenuPrincipal.Size = new Size(390, 29);
            btnVolverMenuPrincipal.TabIndex = 10;
            btnVolverMenuPrincipal.Text = "Volver al menú principal";
            btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 508);
            Controls.Add(btnVolverMenuPrincipal);
            Controls.Add(btnBuscarUni);
            Controls.Add(btnEliminarUni);
            Controls.Add(btnModificarUni);
            Controls.Add(btnAgregarUni);
            Controls.Add(txtDesUni);
            Controls.Add(lblDesUni);
            Controls.Add(txtCodUni);
            Controls.Add(lblCodUni);
            Controls.Add(lblUnidadesMedida);
            Controls.Add(dgvUnidades);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)dgvUnidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUnidades;
        private Label lblUnidadesMedida;
        private Label lblCodUni;
        private TextBox txtCodUni;
        private Label lblDesUni;
        private TextBox txtDesUni;
        private Button btnAgregarUni;
        private Button btnModificarUni;
        private Button btnEliminarUni;
        private Button btnBuscarUni;
        private Button btnVolverMenuPrincipal;
    }
}