namespace aplicacionDeGestion
{
    partial class formFactura
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
            gbPie = new GroupBox();
            btVolver = new Button();
            lbCodigoClienteFact = new Label();
            txtCodigoCliente = new TextBox();
            lbNombreCliente = new Label();
            lbApellidosCliente = new Label();
            lbDNICliente = new Label();
            lbFecha = new Label();
            lbFechaActual = new Label();
            gbCabeceraFactura = new GroupBox();
            txtCodigoFactura = new TextBox();
            lbCodigoFactura = new Label();
            btAñadirProducto = new Button();
            datagridProductos = new DataGridView();
            datagridCodFact = new DataGridViewTextBoxColumn();
            datagridCodigoProducto = new DataGridViewTextBoxColumn();
            datagridDescripcion = new DataGridViewTextBoxColumn();
            datagridPrecio = new DataGridViewTextBoxColumn();
            datagridCantidad = new DataGridViewTextBoxColumn();
            datagridPrecioFinal = new DataGridViewTextBoxColumn();
            gbCabeceraFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridProductos).BeginInit();
            SuspendLayout();
            // 
            // gbPie
            // 
            gbPie.Location = new Point(12, 488);
            gbPie.Name = "gbPie";
            gbPie.Size = new Size(697, 72);
            gbPie.TabIndex = 2;
            gbPie.TabStop = false;
            // 
            // btVolver
            // 
            btVolver.Location = new Point(615, 566);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(94, 29);
            btVolver.TabIndex = 3;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // lbCodigoClienteFact
            // 
            lbCodigoClienteFact.AutoSize = true;
            lbCodigoClienteFact.Location = new Point(6, 52);
            lbCodigoClienteFact.Name = "lbCodigoClienteFact";
            lbCodigoClienteFact.Size = new Size(108, 20);
            lbCodigoClienteFact.TabIndex = 0;
            lbCodigoClienteFact.Text = "Código Cliente";
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(120, 49);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(57, 27);
            txtCodigoCliente.TabIndex = 1;
            txtCodigoCliente.TextChanged += txtCodigoCliente_TextChanged;
            // 
            // lbNombreCliente
            // 
            lbNombreCliente.AutoSize = true;
            lbNombreCliente.Location = new Point(593, 16);
            lbNombreCliente.Name = "lbNombreCliente";
            lbNombreCliente.Size = new Size(64, 20);
            lbNombreCliente.TabIndex = 2;
            lbNombreCliente.Text = "Nombre";
            lbNombreCliente.Visible = false;
            // 
            // lbApellidosCliente
            // 
            lbApellidosCliente.AutoSize = true;
            lbApellidosCliente.Location = new Point(591, 36);
            lbApellidosCliente.Name = "lbApellidosCliente";
            lbApellidosCliente.Size = new Size(72, 20);
            lbApellidosCliente.TabIndex = 3;
            lbApellidosCliente.Text = "Apellidos";
            lbApellidosCliente.Visible = false;
            // 
            // lbDNICliente
            // 
            lbDNICliente.AutoSize = true;
            lbDNICliente.Location = new Point(591, 56);
            lbDNICliente.Name = "lbDNICliente";
            lbDNICliente.Size = new Size(35, 20);
            lbDNICliente.TabIndex = 4;
            lbDNICliente.Text = "DNI";
            lbDNICliente.Visible = false;
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Location = new Point(6, 92);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(47, 20);
            lbFecha.TabIndex = 5;
            lbFecha.Text = "Fecha";
            // 
            // lbFechaActual
            // 
            lbFechaActual.AutoSize = true;
            lbFechaActual.Location = new Point(59, 92);
            lbFechaActual.Name = "lbFechaActual";
            lbFechaActual.Size = new Size(85, 20);
            lbFechaActual.TabIndex = 6;
            lbFechaActual.Text = "00/00/0000";
            // 
            // gbCabeceraFactura
            // 
            gbCabeceraFactura.Controls.Add(txtCodigoFactura);
            gbCabeceraFactura.Controls.Add(lbCodigoFactura);
            gbCabeceraFactura.Controls.Add(lbFechaActual);
            gbCabeceraFactura.Controls.Add(lbFecha);
            gbCabeceraFactura.Controls.Add(lbDNICliente);
            gbCabeceraFactura.Controls.Add(lbApellidosCliente);
            gbCabeceraFactura.Controls.Add(lbNombreCliente);
            gbCabeceraFactura.Controls.Add(txtCodigoCliente);
            gbCabeceraFactura.Controls.Add(lbCodigoClienteFact);
            gbCabeceraFactura.Location = new Point(12, 12);
            gbCabeceraFactura.Name = "gbCabeceraFactura";
            gbCabeceraFactura.Size = new Size(697, 120);
            gbCabeceraFactura.TabIndex = 0;
            gbCabeceraFactura.TabStop = false;
            // 
            // txtCodigoFactura
            // 
            txtCodigoFactura.Location = new Point(120, 15);
            txtCodigoFactura.Name = "txtCodigoFactura";
            txtCodigoFactura.Size = new Size(57, 27);
            txtCodigoFactura.TabIndex = 8;
            txtCodigoFactura.TextChanged += txtCodigoFactura_TextChanged;
            // 
            // lbCodigoFactura
            // 
            lbCodigoFactura.AutoSize = true;
            lbCodigoFactura.Location = new Point(6, 18);
            lbCodigoFactura.Name = "lbCodigoFactura";
            lbCodigoFactura.Size = new Size(109, 20);
            lbCodigoFactura.TabIndex = 7;
            lbCodigoFactura.Text = "Código Factura";
            // 
            // btAñadirProducto
            // 
            btAñadirProducto.Location = new Point(482, 566);
            btAñadirProducto.Name = "btAñadirProducto";
            btAñadirProducto.Size = new Size(127, 29);
            btAñadirProducto.TabIndex = 4;
            btAñadirProducto.Text = "Añadir Producto";
            btAñadirProducto.UseVisualStyleBackColor = true;
            btAñadirProducto.Click += btAñadirProducto_Click;
            // 
            // datagridProductos
            // 
            datagridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridProductos.Columns.AddRange(new DataGridViewColumn[] { datagridCodFact, datagridCodigoProducto, datagridDescripcion, datagridPrecio, datagridCantidad, datagridPrecioFinal });
            datagridProductos.Location = new Point(12, 166);
            datagridProductos.Name = "datagridProductos";
            datagridProductos.RowHeadersWidth = 51;
            datagridProductos.RowTemplate.Height = 29;
            datagridProductos.Size = new Size(697, 316);
            datagridProductos.TabIndex = 9;
            // 
            // datagridCodFact
            // 
            datagridCodFact.HeaderText = "Codigo Factura";
            datagridCodFact.MinimumWidth = 6;
            datagridCodFact.Name = "datagridCodFact";
            datagridCodFact.Width = 125;
            // 
            // datagridCodigoProducto
            // 
            datagridCodigoProducto.HeaderText = "Código";
            datagridCodigoProducto.MinimumWidth = 6;
            datagridCodigoProducto.Name = "datagridCodigoProducto";
            datagridCodigoProducto.Width = 125;
            // 
            // datagridDescripcion
            // 
            datagridDescripcion.HeaderText = "Descripción";
            datagridDescripcion.MinimumWidth = 6;
            datagridDescripcion.Name = "datagridDescripcion";
            datagridDescripcion.Width = 125;
            // 
            // datagridPrecio
            // 
            datagridPrecio.HeaderText = "Precio";
            datagridPrecio.MinimumWidth = 6;
            datagridPrecio.Name = "datagridPrecio";
            datagridPrecio.Width = 125;
            // 
            // datagridCantidad
            // 
            datagridCantidad.HeaderText = "Cantidad";
            datagridCantidad.MinimumWidth = 6;
            datagridCantidad.Name = "datagridCantidad";
            datagridCantidad.Width = 125;
            // 
            // datagridPrecioFinal
            // 
            datagridPrecioFinal.HeaderText = "Precio Final";
            datagridPrecioFinal.MinimumWidth = 6;
            datagridPrecioFinal.Name = "datagridPrecioFinal";
            datagridPrecioFinal.Width = 125;
            // 
            // formFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(721, 671);
            Controls.Add(datagridProductos);
            Controls.Add(btAñadirProducto);
            Controls.Add(btVolver);
            Controls.Add(gbPie);
            Controls.Add(gbCabeceraFactura);
            Name = "formFactura";
            Text = "Factura";
            gbCabeceraFactura.ResumeLayout(false);
            gbCabeceraFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbPie;
        private Button btVolver;
        private Label lbCodigoClienteFact;
        private TextBox txtCodigoCliente;
        private Label lbNombreCliente;
        private Label lbApellidosCliente;
        private Label lbDNICliente;
        private Label lbFecha;
        private Label lbFechaActual;
        private GroupBox gbCabeceraFactura;
        private Button btAñadirProducto;
        private TextBox txtCodigoFactura;
        private Label lbCodigoFactura;
        public DataGridView datagridProductos;
        private DataGridViewTextBoxColumn datagridCodFact;
        private DataGridViewTextBoxColumn datagridCodigoProducto;
        private DataGridViewTextBoxColumn datagridDescripcion;
        private DataGridViewTextBoxColumn datagridPrecio;
        private DataGridViewTextBoxColumn datagridCantidad;
        private DataGridViewTextBoxColumn datagridPrecioFinal;
    }
}