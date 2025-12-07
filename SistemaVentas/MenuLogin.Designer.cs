namespace SistemaVentas
{
    partial class MenuLogin
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            picLogo = new PictureBox();
            lblSubtitulo = new Label();
            lblSistemaDeFacturacion = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            lblUsuario = new Label();
            lblContrasena = new Label();
            inpUsuario = new TextBox();
            inpContrasena = new TextBox();
            btnEntrar = new Button();
            btnSalir = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1872, 864);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Location = new Point(540, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 588);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(792, 588);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.None;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(picLogo, 0, 0);
            tableLayoutPanel3.Controls.Add(lblSubtitulo, 0, 2);
            tableLayoutPanel3.Controls.Add(lblSistemaDeFacturacion, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel3.Location = new Point(60, 43);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 344F));
            tableLayoutPanel3.Size = new Size(671, 502);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Bottom;
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImage = Properties.Resources.cloud_money_system_icon_175829;
            picLogo.Location = new Point(301, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(68, 60);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 10;
            picLogo.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Anchor = AnchorStyles.Top;
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = SystemColors.ControlDark;
            lblSubtitulo.Location = new Point(124, 129);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(422, 25);
            lblSubtitulo.TabIndex = 9;
            lblSubtitulo.Text = "Gestiona tu negocio de forma profesional";
            // 
            // lblSistemaDeFacturacion
            // 
            lblSistemaDeFacturacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblSistemaDeFacturacion.AutoSize = true;
            lblSistemaDeFacturacion.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSistemaDeFacturacion.ForeColor = Color.MediumBlue;
            lblSistemaDeFacturacion.Location = new Point(69, 68);
            lblSistemaDeFacturacion.Name = "lblSistemaDeFacturacion";
            lblSistemaDeFacturacion.Size = new Size(532, 61);
            lblSistemaDeFacturacion.TabIndex = 7;
            lblSistemaDeFacturacion.Text = "Sistema de Facturación";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 161);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9053259F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 86.09467F));
            tableLayoutPanel4.Size = new Size(665, 338);
            tableLayoutPanel4.TabIndex = 11;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.None;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(lblUsuario, 0, 0);
            tableLayoutPanel5.Controls.Add(lblContrasena, 0, 2);
            tableLayoutPanel5.Controls.Add(inpUsuario, 0, 1);
            tableLayoutPanel5.Controls.Add(inpContrasena, 0, 3);
            tableLayoutPanel5.Controls.Add(btnEntrar, 0, 4);
            tableLayoutPanel5.Controls.Add(btnSalir, 0, 5);
            tableLayoutPanel5.Location = new Point(207, 50);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 6;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.Size = new Size(250, 285);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(3, 19);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(84, 28);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContrasena.Location = new Point(3, 113);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(118, 28);
            lblContrasena.TabIndex = 1;
            lblContrasena.Text = "Contraseña";
            // 
            // inpUsuario
            // 
            inpUsuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inpUsuario.Location = new Point(3, 57);
            inpUsuario.Name = "inpUsuario";
            inpUsuario.Size = new Size(244, 27);
            inpUsuario.TabIndex = 2;
            // 
            // inpContrasena
            // 
            inpContrasena.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inpContrasena.Location = new Point(3, 151);
            inpContrasena.Name = "inpContrasena";
            inpContrasena.Size = new Size(244, 27);
            inpContrasena.TabIndex = 3;
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.None;
            btnEntrar.BackColor = Color.MediumBlue;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(47, 197);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(156, 29);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.BackColor = Color.MediumBlue;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(47, 245);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(156, 29);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // MenuLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1872, 864);
            Controls.Add(tableLayoutPanel1);
            Cursor = Cursors.Hand;
            Name = "MenuLogin";
            Text = "MenuLogin";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblSistemaDeFacturacion;
        private Label lblSubtitulo;
        private PictureBox picLogo;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lblUsuario;
        private Label lblContrasena;
        private TextBox inpUsuario;
        private TextBox inpContrasena;
        private Button btnEntrar;
        private Button btnSalir;
    }
}