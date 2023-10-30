namespace aplicacionDeGestion
{
    partial class formAlta
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
            lbTituloAlta = new Label();
            lbCodigo = new Label();
            lbNumCodigo = new Label();
            lbNombre = new Label();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            lbApellidos = new Label();
            btOK = new Button();
            btCancelar = new Button();
            txtDNI = new TextBox();
            lbDNI = new Label();
            txtTelefono = new TextBox();
            lbTelefono = new Label();
            lbCP = new Label();
            txtCP = new TextBox();
            lbLocalidad = new Label();
            comboLocalidad = new ComboBox();
            txtPais = new TextBox();
            lbPais = new Label();
            SuspendLayout();
            // 
            // lbTituloAlta
            // 
            lbTituloAlta.AutoSize = true;
            lbTituloAlta.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbTituloAlta.Location = new Point(148, 7);
            lbTituloAlta.Name = "lbTituloAlta";
            lbTituloAlta.Size = new Size(94, 38);
            lbTituloAlta.TabIndex = 0;
            lbTituloAlta.Text = "Altas";
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCodigo.Location = new Point(12, 69);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(87, 28);
            lbCodigo.TabIndex = 1;
            lbCodigo.Text = "Código";
            // 
            // lbNumCodigo
            // 
            lbNumCodigo.AutoSize = true;
            lbNumCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbNumCodigo.Location = new Point(148, 68);
            lbNumCodigo.Name = "lbNumCodigo";
            lbNumCodigo.Size = new Size(23, 28);
            lbNumCodigo.TabIndex = 2;
            lbNumCodigo.Text = "0";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbNombre.Location = new Point(12, 122);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(97, 28);
            lbNombre.TabIndex = 3;
            lbNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(148, 125);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(146, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(148, 172);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(146, 27);
            txtApellidos.TabIndex = 6;
            // 
            // lbApellidos
            // 
            lbApellidos.AutoSize = true;
            lbApellidos.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbApellidos.Location = new Point(12, 172);
            lbApellidos.Name = "lbApellidos";
            lbApellidos.Size = new Size(113, 28);
            lbApellidos.TabIndex = 5;
            lbApellidos.Text = "Apellidos";
            // 
            // btOK
            // 
            btOK.DialogResult = DialogResult.OK;
            btOK.Location = new Point(283, 439);
            btOK.Name = "btOK";
            btOK.Size = new Size(105, 29);
            btOK.TabIndex = 7;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // btCancelar
            // 
            btCancelar.DialogResult = DialogResult.Cancel;
            btCancelar.Location = new Point(283, 474);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(105, 29);
            btCancelar.TabIndex = 8;
            btCancelar.Text = "CANCELAR";
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(148, 219);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(146, 27);
            txtDNI.TabIndex = 10;
            // 
            // lbDNI
            // 
            lbDNI.AutoSize = true;
            lbDNI.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDNI.Location = new Point(12, 216);
            lbDNI.Name = "lbDNI";
            lbDNI.Size = new Size(53, 28);
            lbDNI.TabIndex = 9;
            lbDNI.Text = "DNI";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(148, 263);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(146, 27);
            txtTelefono.TabIndex = 12;
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTelefono.Location = new Point(12, 260);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(105, 28);
            lbTelefono.TabIndex = 11;
            lbTelefono.Text = "Teléfono";
            // 
            // lbCP
            // 
            lbCP.AutoSize = true;
            lbCP.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCP.Location = new Point(12, 344);
            lbCP.Name = "lbCP";
            lbCP.Size = new Size(42, 28);
            lbCP.TabIndex = 13;
            lbCP.Text = "CP";
            // 
            // txtCP
            // 
            txtCP.Location = new Point(148, 347);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(146, 27);
            txtCP.TabIndex = 14;
            // 
            // lbLocalidad
            // 
            lbLocalidad.AutoSize = true;
            lbLocalidad.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLocalidad.Location = new Point(12, 301);
            lbLocalidad.Name = "lbLocalidad";
            lbLocalidad.Size = new Size(117, 28);
            lbLocalidad.TabIndex = 15;
            lbLocalidad.Text = "Localidad";
            // 
            // comboLocalidad
            // 
            comboLocalidad.FormattingEnabled = true;
            comboLocalidad.Items.AddRange(new object[] { "Almeria", "Cadiz", "Cordoba", "Granada", "Huelva", "Jaen", "Malaga", "Sevilla" });
            comboLocalidad.Location = new Point(148, 304);
            comboLocalidad.Name = "comboLocalidad";
            comboLocalidad.Size = new Size(146, 28);
            comboLocalidad.TabIndex = 16;
            comboLocalidad.SelectedValueChanged += comboLocalidad_SelectedValueChanged;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(148, 386);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(146, 27);
            txtPais.TabIndex = 18;
            // 
            // lbPais
            // 
            lbPais.AutoSize = true;
            lbPais.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPais.Location = new Point(12, 383);
            lbPais.Name = "lbPais";
            lbPais.Size = new Size(58, 28);
            lbPais.TabIndex = 17;
            lbPais.Text = "País";
            // 
            // formAlta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(400, 515);
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
            Controls.Add(lbNumCodigo);
            Controls.Add(lbCodigo);
            Controls.Add(lbTituloAlta);
            Name = "formAlta";
            Text = "Altas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lbTituloAlta;
        public Label lbCodigo;
        public Label lbNumCodigo;
        public Label lbNombre;
        public TextBox txtNombre;
        public TextBox txtApellidos;
        public Label lbApellidos;
        public Button btOK;
        public Button btCancelar;
        public TextBox txtDNI;
        public Label lbDNI;
        public TextBox txtTelefono;
        public Label lbTelefono;
        public Label lbCP;
        public TextBox txtCP;
        public Label lbLocalidad;
        public ComboBox comboLocalidad;
        public TextBox txtPais;
        public Label lbPais;
    }
}