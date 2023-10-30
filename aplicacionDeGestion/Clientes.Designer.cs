namespace aplicacionDeGestion
{
    partial class formClientes
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
            datagridClientes = new DataGridView();
            datagridCodigo = new DataGridViewTextBoxColumn();
            datagridNombre = new DataGridViewTextBoxColumn();
            datagridApellidos = new DataGridViewTextBoxColumn();
            datagridDNI = new DataGridViewTextBoxColumn();
            datagridTelefono = new DataGridViewTextBoxColumn();
            datagridCP = new DataGridViewTextBoxColumn();
            datagridLocalidad = new DataGridViewTextBoxColumn();
            datagridPais = new DataGridViewTextBoxColumn();
            menuClientes = new MenuStrip();
            altaclienteToolStripMenuItem = new ToolStripMenuItem();
            bajaclienteToolStripMenuItem = new ToolStripMenuItem();
            modificacionesclienteToolStripMenuItem = new ToolStripMenuItem();
            btVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)datagridClientes).BeginInit();
            menuClientes.SuspendLayout();
            SuspendLayout();
            // 
            // datagridClientes
            // 
            datagridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridClientes.Columns.AddRange(new DataGridViewColumn[] { datagridCodigo, datagridNombre, datagridApellidos, datagridDNI, datagridTelefono, datagridCP, datagridLocalidad, datagridPais });
            datagridClientes.Location = new Point(53, 77);
            datagridClientes.Name = "datagridClientes";
            datagridClientes.RowHeadersWidth = 51;
            datagridClientes.RowTemplate.Height = 29;
            datagridClientes.Size = new Size(678, 188);
            datagridClientes.TabIndex = 0;
            // 
            // datagridCodigo
            // 
            datagridCodigo.HeaderText = "Código";
            datagridCodigo.MinimumWidth = 6;
            datagridCodigo.Name = "datagridCodigo";
            datagridCodigo.Width = 125;
            // 
            // datagridNombre
            // 
            datagridNombre.HeaderText = "Nombre";
            datagridNombre.MinimumWidth = 6;
            datagridNombre.Name = "datagridNombre";
            datagridNombre.Width = 125;
            // 
            // datagridApellidos
            // 
            datagridApellidos.HeaderText = "Apellidos";
            datagridApellidos.MinimumWidth = 6;
            datagridApellidos.Name = "datagridApellidos";
            datagridApellidos.Width = 125;
            // 
            // datagridDNI
            // 
            datagridDNI.HeaderText = "DNI";
            datagridDNI.MinimumWidth = 6;
            datagridDNI.Name = "datagridDNI";
            datagridDNI.Width = 125;
            // 
            // datagridTelefono
            // 
            datagridTelefono.HeaderText = "Teléfono";
            datagridTelefono.MinimumWidth = 6;
            datagridTelefono.Name = "datagridTelefono";
            datagridTelefono.Width = 125;
            // 
            // datagridCP
            // 
            datagridCP.HeaderText = "CP";
            datagridCP.MinimumWidth = 6;
            datagridCP.Name = "datagridCP";
            datagridCP.Visible = false;
            datagridCP.Width = 125;
            // 
            // datagridLocalidad
            // 
            datagridLocalidad.HeaderText = "Localidad";
            datagridLocalidad.MinimumWidth = 6;
            datagridLocalidad.Name = "datagridLocalidad";
            datagridLocalidad.Visible = false;
            datagridLocalidad.Width = 125;
            // 
            // datagridPais
            // 
            datagridPais.HeaderText = "Pais";
            datagridPais.MinimumWidth = 6;
            datagridPais.Name = "datagridPais";
            datagridPais.Visible = false;
            datagridPais.Width = 125;
            // 
            // menuClientes
            // 
            menuClientes.ImageScalingSize = new Size(20, 20);
            menuClientes.Items.AddRange(new ToolStripItem[] { altaclienteToolStripMenuItem, bajaclienteToolStripMenuItem, modificacionesclienteToolStripMenuItem });
            menuClientes.Location = new Point(0, 0);
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(800, 28);
            menuClientes.TabIndex = 1;
            menuClientes.Text = "menuStrip1";
            // 
            // altaclienteToolStripMenuItem
            // 
            altaclienteToolStripMenuItem.Name = "altaclienteToolStripMenuItem";
            altaclienteToolStripMenuItem.Size = new Size(50, 24);
            altaclienteToolStripMenuItem.Text = "Alta";
            altaclienteToolStripMenuItem.Click += altaclienteToolStripMenuItem_Click;
            // 
            // bajaclienteToolStripMenuItem
            // 
            bajaclienteToolStripMenuItem.Name = "bajaclienteToolStripMenuItem";
            bajaclienteToolStripMenuItem.Size = new Size(52, 24);
            bajaclienteToolStripMenuItem.Text = "Baja";
            bajaclienteToolStripMenuItem.Click += bajaclienteToolStripMenuItem_Click;
            // 
            // modificacionesclienteToolStripMenuItem
            // 
            modificacionesclienteToolStripMenuItem.Name = "modificacionesclienteToolStripMenuItem";
            modificacionesclienteToolStripMenuItem.Size = new Size(124, 24);
            modificacionesclienteToolStripMenuItem.Text = "Modificaciones";
            modificacionesclienteToolStripMenuItem.Click += modificacionesclienteToolStripMenuItem_Click;
            // 
            // btVolver
            // 
            btVolver.Location = new Point(694, 409);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(94, 29);
            btVolver.TabIndex = 2;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // formClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btVolver);
            Controls.Add(datagridClientes);
            Controls.Add(menuClientes);
            MainMenuStrip = menuClientes;
            Name = "formClientes";
            Text = "Clientes";
            Load += formClientes_Load;
            ((System.ComponentModel.ISupportInitialize)datagridClientes).EndInit();
            menuClientes.ResumeLayout(false);
            menuClientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView datagridClientes;
        public MenuStrip menuClientes;
        public ToolStripMenuItem altaclienteToolStripMenuItem;
        public ToolStripMenuItem bajaclienteToolStripMenuItem;
        public ToolStripMenuItem modificacionesclienteToolStripMenuItem;
        public DataGridViewTextBoxColumn datagridCodigo;
        public DataGridViewTextBoxColumn datagridNombre;
        public DataGridViewTextBoxColumn datagridApellidos;
        public DataGridViewTextBoxColumn datagridDNI;
        public DataGridViewTextBoxColumn datagridTelefono;
        public DataGridViewTextBoxColumn datagridCP;
        public DataGridViewTextBoxColumn datagridLocalidad;
        public DataGridViewTextBoxColumn datagridPais;
        private Button btVolver;
    }
}