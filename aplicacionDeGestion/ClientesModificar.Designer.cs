namespace aplicacionDeGestion
{
    partial class formModificarCliente
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
            txtPais = new TextBox();
            lbPais = new Label();
            comboLocalidad = new ComboBox();
            lbLocalidad = new Label();
            txtCP = new TextBox();
            lbCP = new Label();
            txtTelefono = new TextBox();
            lbTelefono = new Label();
            txtDNI = new TextBox();
            lbDNI = new Label();
            btCancelar = new Button();
            btOK = new Button();
            txtApellidos = new TextBox();
            lbApellidos = new Label();
            txtNombre = new TextBox();
            lbNombre = new Label();
            lbCodigo = new Label();
            lbTituloModificar = new Label();
            txtNumCodigo = new TextBox();
            SuspendLayout();
            // 
            // txtPais
            // 
            txtPais.Location = new Point(146, 385);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(146, 27);
            txtPais.TabIndex = 37;
            // 
            // lbPais
            // 
            lbPais.AutoSize = true;
            lbPais.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPais.Location = new Point(10, 382);
            lbPais.Name = "lbPais";
            lbPais.Size = new Size(58, 28);
            lbPais.TabIndex = 36;
            lbPais.Text = "País";
            // 
            // comboLocalidad
            // 
            comboLocalidad.FormattingEnabled = true;
            comboLocalidad.Items.AddRange(new object[] { "Almeria", "Cadiz", "Cordoba", "Granada", "Huelva", "Jaen", "Malaga", "Sevilla" });
            comboLocalidad.Location = new Point(146, 303);
            comboLocalidad.Name = "comboLocalidad";
            comboLocalidad.Size = new Size(146, 28);
            comboLocalidad.TabIndex = 35;
            // 
            // lbLocalidad
            // 
            lbLocalidad.AutoSize = true;
            lbLocalidad.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLocalidad.Location = new Point(10, 300);
            lbLocalidad.Name = "lbLocalidad";
            lbLocalidad.Size = new Size(117, 28);
            lbLocalidad.TabIndex = 34;
            lbLocalidad.Text = "Localidad";
            // 
            // txtCP
            // 
            txtCP.Location = new Point(146, 346);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(146, 27);
            txtCP.TabIndex = 33;
            // 
            // lbCP
            // 
            lbCP.AutoSize = true;
            lbCP.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCP.Location = new Point(10, 343);
            lbCP.Name = "lbCP";
            lbCP.Size = new Size(42, 28);
            lbCP.TabIndex = 32;
            lbCP.Text = "CP";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(146, 262);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(146, 27);
            txtTelefono.TabIndex = 31;
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTelefono.Location = new Point(10, 259);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(105, 28);
            lbTelefono.TabIndex = 30;
            lbTelefono.Text = "Teléfono";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(146, 218);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(146, 27);
            txtDNI.TabIndex = 29;
            // 
            // lbDNI
            // 
            lbDNI.AutoSize = true;
            lbDNI.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDNI.Location = new Point(10, 215);
            lbDNI.Name = "lbDNI";
            lbDNI.Size = new Size(53, 28);
            lbDNI.TabIndex = 28;
            lbDNI.Text = "DNI";
            // 
            // btCancelar
            // 
            btCancelar.DialogResult = DialogResult.Cancel;
            btCancelar.Location = new Point(281, 473);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(105, 29);
            btCancelar.TabIndex = 27;
            btCancelar.Text = "CANCELAR";
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            btOK.DialogResult = DialogResult.OK;
            btOK.Location = new Point(281, 438);
            btOK.Name = "btOK";
            btOK.Size = new Size(105, 29);
            btOK.TabIndex = 26;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(146, 171);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(146, 27);
            txtApellidos.TabIndex = 25;
            // 
            // lbApellidos
            // 
            lbApellidos.AutoSize = true;
            lbApellidos.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbApellidos.Location = new Point(10, 171);
            lbApellidos.Name = "lbApellidos";
            lbApellidos.Size = new Size(113, 28);
            lbApellidos.TabIndex = 24;
            lbApellidos.Text = "Apellidos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(146, 124);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(146, 27);
            txtNombre.TabIndex = 23;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbNombre.Location = new Point(10, 121);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(97, 28);
            lbNombre.TabIndex = 22;
            lbNombre.Text = "Nombre";
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCodigo.Location = new Point(10, 68);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(87, 28);
            lbCodigo.TabIndex = 20;
            lbCodigo.Text = "Código";
            // 
            // lbTituloModificar
            // 
            lbTituloModificar.AutoSize = true;
            lbTituloModificar.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbTituloModificar.Location = new Point(146, 6);
            lbTituloModificar.Name = "lbTituloModificar";
            lbTituloModificar.Size = new Size(155, 38);
            lbTituloModificar.TabIndex = 19;
            lbTituloModificar.Text = "Modificar";
            // 
            // txtNumCodigo
            // 
            txtNumCodigo.Location = new Point(146, 71);
            txtNumCodigo.Name = "txtNumCodigo";
            txtNumCodigo.Size = new Size(146, 27);
            txtNumCodigo.TabIndex = 38;
            // 
            // formModificarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(398, 510);
            Controls.Add(txtNumCodigo);
            Controls.Add(txtPais);
            Controls.Add(lbPais);
            Controls.Add(comboLocalidad);
            Controls.Add(lbLocalidad);
            Controls.Add(txtCP);
            Controls.Add(lbCP);
            Controls.Add(txtTelefono);
            Controls.Add(lbTelefono);
            Controls.Add(txtDNI);
            Controls.Add(lbDNI);
            Controls.Add(btCancelar);
            Controls.Add(btOK);
            Controls.Add(txtApellidos);
            Controls.Add(lbApellidos);
            Controls.Add(txtNombre);
            Controls.Add(lbNombre);
            Controls.Add(lbCodigo);
            Controls.Add(lbTituloModificar);
            Name = "formModificarCliente";
            Text = "Modificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtPais;
        public Label lbPais;
        public ComboBox comboLocalidad;
        public Label lbLocalidad;
        public TextBox txtCP;
        public Label lbCP;
        public TextBox txtTelefono;
        public Label lbTelefono;
        public TextBox txtDNI;
        public Label lbDNI;
        public Button btCancelar;
        public Button btOK;
        public TextBox txtApellidos;
        public Label lbApellidos;
        public TextBox txtNombre;
        public Label lbNombre;
        public Label lbCodigo;
        public Label lbTituloModificar;
        public TextBox txtNumCodigo;
    }
}