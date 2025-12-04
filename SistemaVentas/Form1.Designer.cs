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
            colCodigo = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colPrecioUnitario = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colEliminar = new DataGridViewButtonColumn();
            lblTotal = new Label();
            lblTotalMonto = new Label();
            btnFacturar = new Button();
            btnVolverMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductosSeleccionados).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(34, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(272, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Ventas";
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Font = new Font("Segoe UI", 11F);
            lblBuscarProducto.Location = new Point(34, 107);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(322, 25);
            lblBuscarProducto.TabIndex = 1;
            lblBuscarProducto.Text = "Buscar Producto (Código o Nombre):";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Font = new Font("Segoe UI", 11F);
            txtBuscarProducto.Location = new Point(34, 147);
            txtBuscarProducto.Margin = new Padding(3, 4, 3, 4);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(457, 32);
            txtBuscarProducto.TabIndex = 2;
            // 
            // lstResultadosBusqueda
            // 
            lstResultadosBusqueda.Font = new Font("Segoe UI", 10F);
            lstResultadosBusqueda.FormattingEnabled = true;
            lstResultadosBusqueda.ItemHeight = 23;
            lstResultadosBusqueda.Location = new Point(34, 193);
            lstResultadosBusqueda.Margin = new Padding(3, 4, 3, 4);
            lstResultadosBusqueda.Name = "lstResultadosBusqueda";
            lstResultadosBusqueda.Size = new Size(457, 165);
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
            dgvProductosSeleccionados.Location = new Point(34, 427);
            dgvProductosSeleccionados.Margin = new Padding(3, 4, 3, 4);
            dgvProductosSeleccionados.Name = "dgvProductosSeleccionados";
            dgvProductosSeleccionados.RowHeadersVisible = false;
            dgvProductosSeleccionados.RowHeadersWidth = 51;
            dgvProductosSeleccionados.Size = new Size(1829, 533);
            dgvProductosSeleccionados.TabIndex = 4;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // colPrecioUnitario
            // 
            colPrecioUnitario.HeaderText = "Precio Unitario";
            colPrecioUnitario.MinimumWidth = 6;
            colPrecioUnitario.Name = "colPrecioUnitario";
            colPrecioUnitario.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 6;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // colEliminar
            // 
            colEliminar.HeaderText = "Accion";
            colEliminar.MinimumWidth = 6;
            colEliminar.Name = "colEliminar";
            colEliminar.Text = "Eliminar";
            colEliminar.UseColumnTextForButtonValue = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotal.Location = new Point(1543, 987);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(170, 32);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total a Pagar:";
            // 
            // lblTotalMonto
            // 
            lblTotalMonto.AutoSize = true;
            lblTotalMonto.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalMonto.ForeColor = Color.Green;
            lblTotalMonto.Location = new Point(1697, 987);
            lblTotalMonto.Name = "lblTotalMonto";
            lblTotalMonto.Size = new Size(77, 32);
            lblTotalMonto.TabIndex = 6;
            lblTotalMonto.Text = "$0.00";
            // 
            // btnFacturar
            // 
            btnFacturar.BackColor = Color.FromArgb(0, 192, 0);
            btnFacturar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFacturar.ForeColor = Color.White;
            btnFacturar.Location = new Point(1193, 970);
            btnFacturar.Margin = new Padding(3, 4, 3, 4);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(320, 67);
            btnFacturar.TabIndex = 7;
            btnFacturar.Text = "Facturar";
            btnFacturar.UseVisualStyleBackColor = false;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.BackColor = Color.FromArgb(64, 64, 64);
            btnVolverMenu.Font = new Font("Segoe UI", 10F);
            btnVolverMenu.ForeColor = Color.White;
            btnVolverMenu.Location = new Point(34, 975);
            btnVolverMenu.Margin = new Padding(3, 4, 3, 4);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(171, 67);
            btnVolverMenu.TabIndex = 8;
            btnVolverMenu.Text = "Volver al Menú";
            btnVolverMenu.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1906, 1055);
            Controls.Add(btnVolverMenu);
            Controls.Add(btnFacturar);
            Controls.Add(lblTotalMonto);
            Controls.Add(lblTotal);
            Controls.Add(dgvProductosSeleccionados);
            Controls.Add(lstResultadosBusqueda);
            Controls.Add(txtBuscarProducto);
            Controls.Add(lblBuscarProducto);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Sistema de Ventas";
            WindowState = FormWindowState.Maximized;
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