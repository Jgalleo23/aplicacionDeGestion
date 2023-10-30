namespace aplicacionDeGestion
{
    partial class formAgregarProducto
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
            lbContador = new Label();
            lbPrecioFinal = new Label();
            lbBeneficio = new Label();
            btCancelar = new Button();
            btOK = new Button();
            lbPrecioProducto = new Label();
            lbDescripcion = new Label();
            lbCodigo = new Label();
            lbTituloAgregar = new Label();
            rtxtDescripcion = new RichTextBox();
            numericPrecio = new NumericUpDown();
            numericBeneficio = new NumericUpDown();
            numericPrecioFinal = new NumericUpDown();
            txtNumCodigoProducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBeneficio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecioFinal).BeginInit();
            SuspendLayout();
            // 
            // lbContador
            // 
            lbContador.AutoSize = true;
            lbContador.Location = new Point(332, 18);
            lbContador.Name = "lbContador";
            lbContador.Size = new Size(17, 20);
            lbContador.TabIndex = 27;
            lbContador.Text = "0";
            lbContador.Visible = false;
            // 
            // lbPrecioFinal
            // 
            lbPrecioFinal.AutoSize = true;
            lbPrecioFinal.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrecioFinal.Location = new Point(6, 340);
            lbPrecioFinal.Name = "lbPrecioFinal";
            lbPrecioFinal.Size = new Size(141, 28);
            lbPrecioFinal.TabIndex = 25;
            lbPrecioFinal.Text = "Precio Final";
            // 
            // lbBeneficio
            // 
            lbBeneficio.AutoSize = true;
            lbBeneficio.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbBeneficio.Location = new Point(6, 296);
            lbBeneficio.Name = "lbBeneficio";
            lbBeneficio.Size = new Size(115, 28);
            lbBeneficio.TabIndex = 23;
            lbBeneficio.Text = "Beneficio";
            // 
            // btCancelar
            // 
            btCancelar.DialogResult = DialogResult.Cancel;
            btCancelar.Location = new Point(277, 483);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(105, 29);
            btCancelar.TabIndex = 22;
            btCancelar.Text = "CANCELAR";
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            btOK.DialogResult = DialogResult.OK;
            btOK.Location = new Point(277, 448);
            btOK.Name = "btOK";
            btOK.Size = new Size(105, 29);
            btOK.TabIndex = 21;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // lbPrecioProducto
            // 
            lbPrecioProducto.AutoSize = true;
            lbPrecioProducto.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrecioProducto.Location = new Point(6, 252);
            lbPrecioProducto.Name = "lbPrecioProducto";
            lbPrecioProducto.Size = new Size(81, 28);
            lbPrecioProducto.TabIndex = 19;
            lbPrecioProducto.Text = "Precio";
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDescripcion.Location = new Point(6, 185);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(141, 28);
            lbDescripcion.TabIndex = 17;
            lbDescripcion.Text = "Descripción";
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCodigo.Location = new Point(6, 132);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(87, 28);
            lbCodigo.TabIndex = 15;
            lbCodigo.Text = "Código";
            // 
            // lbTituloAgregar
            // 
            lbTituloAgregar.AutoSize = true;
            lbTituloAgregar.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbTituloAgregar.Location = new Point(130, 70);
            lbTituloAgregar.Name = "lbTituloAgregar";
            lbTituloAgregar.Size = new Size(135, 38);
            lbTituloAgregar.TabIndex = 14;
            lbTituloAgregar.Text = "Agregar";
            // 
            // rtxtDescripcion
            // 
            rtxtDescripcion.Location = new Point(153, 185);
            rtxtDescripcion.Name = "rtxtDescripcion";
            rtxtDescripcion.Size = new Size(141, 46);
            rtxtDescripcion.TabIndex = 28;
            rtxtDescripcion.Text = "";
            // 
            // numericPrecio
            // 
            numericPrecio.Location = new Point(148, 253);
            numericPrecio.Name = "numericPrecio";
            numericPrecio.Size = new Size(146, 27);
            numericPrecio.TabIndex = 29;
            // 
            // numericBeneficio
            // 
            numericBeneficio.Enabled = false;
            numericBeneficio.Location = new Point(148, 300);
            numericBeneficio.Name = "numericBeneficio";
            numericBeneficio.Size = new Size(146, 27);
            numericBeneficio.TabIndex = 30;
            numericBeneficio.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericPrecioFinal
            // 
            numericPrecioFinal.Enabled = false;
            numericPrecioFinal.Location = new Point(148, 344);
            numericPrecioFinal.Name = "numericPrecioFinal";
            numericPrecioFinal.Size = new Size(146, 27);
            numericPrecioFinal.TabIndex = 31;
            // 
            // txtNumCodigoProducto
            // 
            txtNumCodigoProducto.Enabled = false;
            txtNumCodigoProducto.Location = new Point(148, 136);
            txtNumCodigoProducto.Name = "txtNumCodigoProducto";
            txtNumCodigoProducto.Size = new Size(146, 27);
            txtNumCodigoProducto.TabIndex = 33;
            txtNumCodigoProducto.Text = "0";
            // 
            // formAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(388, 519);
            Controls.Add(txtNumCodigoProducto);
            Controls.Add(numericPrecioFinal);
            Controls.Add(numericBeneficio);
            Controls.Add(numericPrecio);
            Controls.Add(rtxtDescripcion);
            Controls.Add(lbContador);
            Controls.Add(lbPrecioFinal);
            Controls.Add(lbBeneficio);
            Controls.Add(btCancelar);
            Controls.Add(btOK);
            Controls.Add(lbPrecioProducto);
            Controls.Add(lbDescripcion);
            Controls.Add(lbCodigo);
            Controls.Add(lbTituloAgregar);
            Name = "formAgregarProducto";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBeneficio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecioFinal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lbContador;
        public TextBox txtTelefono;
        public Label lbPrecioFinal;
        public TextBox txtDNI;
        public Label lbBeneficio;
        public Button btCancelar;
        public Button btOK;
        public Label lbPrecioProducto;
        public Label lbDescripcion;
        public Label lbCodigo;
        public Label lbTituloAgregar;
        public RichTextBox rtxtDescripcion;
        public NumericUpDown numericPrecio;
        public NumericUpDown numericBeneficio;
        public NumericUpDown numericPrecioFinal;
        private TextBox txtNumCodigoProducto;
    }
}