namespace SistemaVentas
{
    partial class Form1
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
            lblBuscarProducto = new Label();
            txtBuscarProducto = new TextBox();
            lstResultadosBusqueda = new ListBox();
            dgvProductosSeleccionados = new DataGridView();
            lblTotal = new Label();
            lblTotalMonto = new Label();
            btnFacturar = new Button();
            btnVolverMenu = new Button();
            colCodigo = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colPrecioUnitario = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colEliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductosSeleccionados).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(219, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Ventas";
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Font = new Font("Segoe UI", 11F);
            lblBuscarProducto.Location = new Point(30, 80);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(254, 20);
            lblBuscarProducto.TabIndex = 1;
            lblBuscarProducto.Text = "Buscar Producto (Código o Nombre):";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Font = new Font("Segoe UI", 11F);
            txtBuscarProducto.Location = new Point(30, 110);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(400, 27);
            txtBuscarProducto.TabIndex = 2;
            // 
            // lstResultadosBusqueda
            // 
            lstResultadosBusqueda.Font = new Font("Segoe UI", 10F);
            lstResultadosBusqueda.FormattingEnabled = true;
            lstResultadosBusqueda.ItemHeight = 17;
            lstResultadosBusqueda.Location = new Point(30, 145);
            lstResultadosBusqueda.Name = "lstResultadosBusqueda";
            lstResultadosBusqueda.Size = new Size(400, 140);
            lstResultadosBusqueda.TabIndex = 3;
            lstResultadosBusqueda.Visible = false;
            // 
            // dgvProductosSeleccionados
            // 
            dgvProductosSeleccionados.AllowUserToAddRows = false;
            dgvProductosSeleccionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductosSeleccionados.BackgroundColor = Color.White;
            dgvProductosSeleccionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosSeleccionados.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colDescripcion, colPrecioUnitario, colCantidad, colSubtotal, colEliminar });
            dgvProductosSeleccionados.Location = new Point(30, 320);
            dgvProductosSeleccionados.Name = "dgvProductosSeleccionados";
            dgvProductosSeleccionados.RowHeadersVisible = false;
            dgvProductosSeleccionados.Size = new Size(1600, 400);
            dgvProductosSeleccionados.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotal.Location = new Point(1350, 740);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(133, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total a Pagar:";
            // 
            // lblTotalMonto
            // 
            lblTotalMonto.AutoSize = true;
            lblTotalMonto.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalMonto.ForeColor = Color.Green;
            lblTotalMonto.Location = new Point(1485, 740);
            lblTotalMonto.Name = "lblTotalMonto";
            lblTotalMonto.Size = new Size(61, 25);
            lblTotalMonto.TabIndex = 6;
            lblTotalMonto.Text = "$0.00";
            // 
            // btnFacturar
            // 
            btnFacturar.BackColor = Color.FromArgb(0, 192, 0);
            btnFacturar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFacturar.ForeColor = Color.White;
            btnFacturar.Location = new Point(1350, 785);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(280, 50);
            btnFacturar.TabIndex = 7;
            btnFacturar.Text = "Facturar";
            btnFacturar.UseVisualStyleBackColor = false;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.BackColor = Color.FromArgb(64, 64, 64);
            btnVolverMenu.Font = new Font("Segoe UI", 10F);
            btnVolverMenu.ForeColor = Color.White;
            btnVolverMenu.Location = new Point(30, 785);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(150, 50);
            btnVolverMenu.TabIndex = 8;
            btnVolverMenu.Text = "Volver al Menú";
            btnVolverMenu.UseVisualStyleBackColor = false;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // colPrecioUnitario
            // 
            colPrecioUnitario.HeaderText = "Precio Unitario";
            colPrecioUnitario.Name = "colPrecioUnitario";
            colPrecioUnitario.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // colEliminar
            // 
            colEliminar.HeaderText = "Accion";
            colEliminar.Name = "colEliminar";
            colEliminar.Text = "Eliminar";
            colEliminar.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1668, 857);
            Controls.Add(btnVolverMenu);
            Controls.Add(btnFacturar);
            Controls.Add(lblTotalMonto);
            Controls.Add(lblTotal);
            Controls.Add(dgvProductosSeleccionados);
            Controls.Add(lstResultadosBusqueda);
            Controls.Add(txtBuscarProducto);
            Controls.Add(lblBuscarProducto);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Sistema de Ventas";
            ((System.ComponentModel.ISupportInitialize)dgvProductosSeleccionados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblBuscarProducto;
        private TextBox txtBuscarProducto;
        private ListBox lstResultadosBusqueda;
        private DataGridView dgvProductosSeleccionados;
        private Label lblTotal;
        private Label lblTotalMonto;
        private Button btnFacturar;
        private Button btnVolverMenu;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colPrecioUnitario;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewButtonColumn colEliminar;
    }
}