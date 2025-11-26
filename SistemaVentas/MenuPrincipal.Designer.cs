namespace SistemaVentas
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Panel panelArtículos;
        private Label lblFacturaciónSub;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            lblSistemaDeFacturacion = new Label();
            lblSubtitulo = new Label();
            panelArtículos = new Panel();
            picArtículos = new PictureBox();
            lblArticulosSub = new Label();
            lblArticulosTitulo = new Label();
            panelFacturación = new Panel();
            pictureBox1 = new PictureBox();
            lblFacturaciónSub = new Label();
            lblFacturacionTitulo = new Label();
            panelDetalles = new Panel();
            pictureBox2 = new PictureBox();
            lblDetallesSub = new Label();
            lblDetallesTitulo = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            lblUnidadesDeMedidasSub = new Label();
            lblUnidadesMedidaTitulo = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            lblConfiguraciónTitulo = new Label();
            pictureBox6 = new PictureBox();
            lblClientesTitulo = new Label();
            panelClientes = new Panel();
            pictureBox7 = new PictureBox();
            lblClienteSub = new Label();
            lblClienteTitulo = new Label();
            btnSalir = new Button();
            panelArtículos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picArtículos).BeginInit();
            panelFacturación.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panelClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // lblSistemaDeFacturacion
            // 
            lblSistemaDeFacturacion.AutoSize = true;
            lblSistemaDeFacturacion.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSistemaDeFacturacion.ForeColor = Color.MediumBlue;
            lblSistemaDeFacturacion.Location = new Point(147, 53);
            lblSistemaDeFacturacion.Name = "lblSistemaDeFacturacion";
            lblSistemaDeFacturacion.Size = new Size(357, 38);
            lblSistemaDeFacturacion.TabIndex = 6;
            lblSistemaDeFacturacion.Text = "Sistema de Facturación";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = SystemColors.ControlDark;
            lblSubtitulo.Location = new Point(176, 91);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(293, 19);
            lblSubtitulo.TabIndex = 8;
            lblSubtitulo.Text = "Gestiona tu negocio de forma profesional";
            // 
            // panelArtículos
            // 
            panelArtículos.BackColor = SystemColors.ButtonHighlight;
            panelArtículos.Controls.Add(picArtículos);
            panelArtículos.Controls.Add(lblArticulosSub);
            panelArtículos.Controls.Add(lblArticulosTitulo);
            panelArtículos.Cursor = Cursors.Hand;
            panelArtículos.Location = new Point(218, 147);
            panelArtículos.Name = "panelArtículos";
            panelArtículos.Size = new Size(200, 110);
            panelArtículos.TabIndex = 10;
            panelArtículos.Click += btnArticulos_Click;
            // 
            // picArtículos
            // 
            picArtículos.BackColor = Color.Transparent;
            picArtículos.Image = (Image)resources.GetObject("picArtículos.Image");
            picArtículos.Location = new Point(15, 31);
            picArtículos.Name = "picArtículos";
            picArtículos.Size = new Size(40, 40);
            picArtículos.SizeMode = PictureBoxSizeMode.Zoom;
            picArtículos.TabIndex = 3;
            picArtículos.TabStop = false;
            picArtículos.Click += btnArticulos_Click;
            // 
            // lblArticulosSub
            // 
            lblArticulosSub.AutoSize = true;
            lblArticulosSub.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArticulosSub.ForeColor = Color.Gray;
            lblArticulosSub.Location = new Point(61, 55);
            lblArticulosSub.Name = "lblArticulosSub";
            lblArticulosSub.Size = new Size(131, 17);
            lblArticulosSub.TabIndex = 1;
            lblArticulosSub.Text = "Gestión de inventario";
            lblArticulosSub.Click += btnArticulos_Click;
            // 
            // lblArticulosTitulo
            // 
            lblArticulosTitulo.AutoSize = true;
            lblArticulosTitulo.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArticulosTitulo.ForeColor = Color.Black;
            lblArticulosTitulo.Location = new Point(61, 36);
            lblArticulosTitulo.Name = "lblArticulosTitulo";
            lblArticulosTitulo.Size = new Size(73, 19);
            lblArticulosTitulo.TabIndex = 0;
            lblArticulosTitulo.Text = "Artículos";
            lblArticulosTitulo.Click += btnArticulos_Click;
            // 
            // panelFacturación
            // 
            panelFacturación.BackColor = SystemColors.ButtonHighlight;
            panelFacturación.Controls.Add(pictureBox1);
            panelFacturación.Controls.Add(lblFacturaciónSub);
            panelFacturación.Controls.Add(lblFacturacionTitulo);
            panelFacturación.Cursor = Cursors.Hand;
            panelFacturación.Location = new Point(424, 147);
            panelFacturación.Name = "panelFacturación";
            panelFacturación.Size = new Size(200, 110);
            panelFacturación.TabIndex = 10;
            panelFacturación.Click += btnFacturacion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += btnFacturacion_Click;
            // 
            // lblFacturaciónSub
            // 
            lblFacturaciónSub.AutoSize = true;
            lblFacturaciónSub.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFacturaciónSub.ForeColor = Color.Gray;
            lblFacturaciónSub.Location = new Point(61, 53);
            lblFacturaciónSub.Name = "lblFacturaciónSub";
            lblFacturaciónSub.Size = new Size(98, 17);
            lblFacturaciónSub.TabIndex = 1;
            lblFacturaciónSub.Text = "Crear facturas ";
            lblFacturaciónSub.Click += btnFacturacion_Click;
            // 
            // lblFacturacionTitulo
            // 
            lblFacturacionTitulo.AutoSize = true;
            lblFacturacionTitulo.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFacturacionTitulo.ForeColor = Color.Black;
            lblFacturacionTitulo.Location = new Point(61, 36);
            lblFacturacionTitulo.Name = "lblFacturacionTitulo";
            lblFacturacionTitulo.Size = new Size(89, 19);
            lblFacturacionTitulo.TabIndex = 0;
            lblFacturacionTitulo.Text = "Facturación";
            lblFacturacionTitulo.Click += btnFacturacion_Click;
            // 
            // panelDetalles
            // 
            panelDetalles.BackColor = SystemColors.ButtonHighlight;
            panelDetalles.Controls.Add(pictureBox2);
            panelDetalles.Controls.Add(lblDetallesSub);
            panelDetalles.Controls.Add(lblDetallesTitulo);
            panelDetalles.Cursor = Cursors.Hand;
            panelDetalles.Location = new Point(12, 263);
            panelDetalles.Name = "panelDetalles";
            panelDetalles.Size = new Size(200, 110);
            panelDetalles.TabIndex = 11;
            panelDetalles.Click += btnDetalles_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += btnDetalles_Click;
            // 
            // lblDetallesSub
            // 
            lblDetallesSub.AutoSize = true;
            lblDetallesSub.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetallesSub.ForeColor = Color.Gray;
            lblDetallesSub.Location = new Point(61, 55);
            lblDetallesSub.Name = "lblDetallesSub";
            lblDetallesSub.Size = new Size(126, 17);
            lblDetallesSub.TabIndex = 2;
            lblDetallesSub.Text = "Detalles de facturas";
            lblDetallesSub.Click += btnDetalles_Click;
            // 
            // lblDetallesTitulo
            // 
            lblDetallesTitulo.AutoSize = true;
            lblDetallesTitulo.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetallesTitulo.ForeColor = Color.Black;
            lblDetallesTitulo.Location = new Point(61, 36);
            lblDetallesTitulo.Name = "lblDetallesTitulo";
            lblDetallesTitulo.Size = new Size(66, 19);
            lblDetallesTitulo.TabIndex = 0;
            lblDetallesTitulo.Text = "Detalles";
            lblDetallesTitulo.Click += btnDetalles_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(lblUnidadesDeMedidasSub);
            panel3.Controls.Add(lblUnidadesMedidaTitulo);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(218, 263);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 110);
            panel3.TabIndex = 12;
            panel3.Click += btnUnidadesDeMedida_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(15, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += btnUnidadesDeMedida_Click;
            // 
            // lblUnidadesDeMedidasSub
            // 
            lblUnidadesDeMedidasSub.AutoSize = true;
            lblUnidadesDeMedidasSub.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnidadesDeMedidasSub.ForeColor = Color.Gray;
            lblUnidadesDeMedidasSub.Location = new Point(61, 55);
            lblUnidadesDeMedidasSub.Name = "lblUnidadesDeMedidasSub";
            lblUnidadesDeMedidasSub.Size = new Size(125, 17);
            lblUnidadesDeMedidasSub.TabIndex = 2;
            lblUnidadesDeMedidasSub.Text = "Gestión de unidades";
            lblUnidadesDeMedidasSub.Click += btnUnidadesDeMedida_Click;
            // 
            // lblUnidadesMedidaTitulo
            // 
            lblUnidadesMedidaTitulo.AutoSize = true;
            lblUnidadesMedidaTitulo.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnidadesMedidaTitulo.ForeColor = Color.Black;
            lblUnidadesMedidaTitulo.Location = new Point(61, 33);
            lblUnidadesMedidaTitulo.Name = "lblUnidadesMedidaTitulo";
            lblUnidadesMedidaTitulo.Size = new Size(132, 19);
            lblUnidadesMedidaTitulo.TabIndex = 0;
            lblUnidadesMedidaTitulo.Text = "Unidad de Medida";
            lblUnidadesMedidaTitulo.Click += btnUnidadesDeMedida_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(lblConfiguraciónTitulo);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(424, 263);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 110);
            panel4.TabIndex = 13;
            panel4.Click += btnConfiguracion_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(15, 32);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += btnConfiguracion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(61, 55);
            label3.Name = "label3";
            label3.Size = new Size(125, 17);
            label3.TabIndex = 3;
            label3.Text = "Gestión de unidades";
            label3.Click += btnConfiguracion_Click;
            // 
            // lblConfiguraciónTitulo
            // 
            lblConfiguraciónTitulo.AutoSize = true;
            lblConfiguraciónTitulo.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfiguraciónTitulo.ForeColor = Color.Black;
            lblConfiguraciónTitulo.Location = new Point(61, 33);
            lblConfiguraciónTitulo.Name = "lblConfiguraciónTitulo";
            lblConfiguraciónTitulo.Size = new Size(107, 19);
            lblConfiguraciónTitulo.TabIndex = 0;
            lblConfiguraciónTitulo.Text = "Configuración";
            lblConfiguraciónTitulo.Click += btnConfiguracion_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(15, 32);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(40, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // lblClientesTitulo
            // 
            lblClientesTitulo.AutoSize = true;
            lblClientesTitulo.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClientesTitulo.ForeColor = Color.Black;
            lblClientesTitulo.Location = new Point(61, 36);
            lblClientesTitulo.Name = "lblClientesTitulo";
            lblClientesTitulo.Size = new Size(66, 19);
            lblClientesTitulo.TabIndex = 0;
            lblClientesTitulo.Text = "Clientes";
            // 
            // panelClientes
            // 
            panelClientes.BackColor = SystemColors.ButtonHighlight;
            panelClientes.Controls.Add(pictureBox7);
            panelClientes.Controls.Add(lblClienteSub);
            panelClientes.Controls.Add(lblClienteTitulo);
            panelClientes.Cursor = Cursors.Hand;
            panelClientes.Location = new Point(12, 147);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(200, 110);
            panelClientes.TabIndex = 14;
            panelClientes.Click += btnClientes_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(15, 32);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(40, 40);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 5;
            pictureBox7.TabStop = false;
            pictureBox7.Click += btnClientes_Click;
            // 
            // lblClienteSub
            // 
            lblClienteSub.AutoSize = true;
            lblClienteSub.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClienteSub.ForeColor = Color.Gray;
            lblClienteSub.Location = new Point(61, 55);
            lblClienteSub.Name = "lblClienteSub";
            lblClienteSub.Size = new Size(118, 17);
            lblClienteSub.TabIndex = 2;
            lblClienteSub.Text = "Gestión de clientes";
            lblClienteSub.Click += btnClientes_Click;
            // 
            // lblClienteTitulo
            // 
            lblClienteTitulo.AutoSize = true;
            lblClienteTitulo.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClienteTitulo.ForeColor = Color.Black;
            lblClienteTitulo.Location = new Point(61, 36);
            lblClienteTitulo.Name = "lblClienteTitulo";
            lblClienteTitulo.Size = new Size(66, 19);
            lblClienteTitulo.TabIndex = 0;
            lblClienteTitulo.Text = "Clientes";
            lblClienteTitulo.Click += btnClientes_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(535, 456);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(85, 29);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(632, 497);
            Controls.Add(btnSalir);
            Controls.Add(panelClientes);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panelDetalles);
            Controls.Add(panelFacturación);
            Controls.Add(panelArtículos);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblSistemaDeFacturacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            panelArtículos.ResumeLayout(false);
            panelArtículos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picArtículos).EndInit();
            panelFacturación.ResumeLayout(false);
            panelFacturación.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelDetalles.ResumeLayout(false);
            panelDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panelClientes.ResumeLayout(false);
            panelClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSistemaDeFacturacion;
        private Label lblSubtitulo;
        private Label lblArticulosSub;
        private Label lblArticulosTitulo;
        private Label lblFacturacionTitulo;
        private Panel panelDetalles;
        private Label lblDetallesTitulo;
        private Label lblDetallesSub;
        private Panel panel3;
        private Label lblUnidadesDeMedidasSub;
        private Label lblUnidadesMedidaTitulo;
        private Panel panel4;
        private Label lblConfiguraciónTitulo;
        private Label label3;
        private PictureBox picArtículos;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        internal Panel panelFacturación;
        private Panel panel1;
        private PictureBox pictureBox6;
        private Label label1;
        private Label lblClientesTitulo;
        private Panel panelClientes;
        private PictureBox pictureBox7;
        private Label lblClienteSub;
        private Label lblClienteTitulo;
        private Button btnSalir;
    }
}