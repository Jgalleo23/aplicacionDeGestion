namespace aplicacionDeGestion
{
    partial class formProductos
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
            datagridProductos = new DataGridView();
            datagridCodigoProducto = new DataGridViewTextBoxColumn();
            datagridDescripcion = new DataGridViewTextBoxColumn();
            datagridPrecio = new DataGridViewTextBoxColumn();
            datagridBeneficio = new DataGridViewTextBoxColumn();
            datagridPrecioFinal = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            btVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)datagridProductos).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // datagridProductos
            // 
            datagridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridProductos.Columns.AddRange(new DataGridViewColumn[] { datagridCodigoProducto, datagridDescripcion, datagridPrecio, datagridBeneficio, datagridPrecioFinal });
            datagridProductos.Location = new Point(54, 109);
            datagridProductos.Name = "datagridProductos";
            datagridProductos.RowHeadersWidth = 51;
            datagridProductos.RowTemplate.Height = 29;
            datagridProductos.Size = new Size(685, 188);
            datagridProductos.TabIndex = 1;
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
            // datagridBeneficio
            // 
            datagridBeneficio.HeaderText = "Beneficio";
            datagridBeneficio.MinimumWidth = 6;
            datagridBeneficio.Name = "datagridBeneficio";
            datagridBeneficio.Width = 125;
            // 
            // datagridPrecioFinal
            // 
            datagridPrecioFinal.HeaderText = "Precio Final";
            datagridPrecioFinal.MinimumWidth = 6;
            datagridPrecioFinal.Name = "datagridPrecioFinal";
            datagridPrecioFinal.Width = 125;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, eliminarToolStripMenuItem, editarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(77, 24);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(77, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(62, 24);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // btVolver
            // 
            btVolver.Location = new Point(694, 409);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(94, 29);
            btVolver.TabIndex = 3;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // formProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btVolver);
            Controls.Add(datagridProductos);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "formProductos";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)datagridProductos).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView datagridProductos;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem agregarToolStripMenuItem;
        public ToolStripMenuItem eliminarToolStripMenuItem;
        public ToolStripMenuItem editarToolStripMenuItem;
        public DataGridViewTextBoxColumn datagridCodigoProducto;
        public DataGridViewTextBoxColumn datagridDescripcion;
        public DataGridViewTextBoxColumn datagridPrecio;
        public DataGridViewTextBoxColumn datagridBeneficio;
        public DataGridViewTextBoxColumn datagridPrecioFinal;
        private Button btVolver;
    }
}