namespace aplicacionDeGestion
{
    partial class formEditarProductos
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
            txtNumCodigoProducto = new TextBox();
            numericPrecioFinal = new NumericUpDown();
            numericBeneficio = new NumericUpDown();
            numericPrecio = new NumericUpDown();
            rtxtDescripcion = new RichTextBox();
            lbPrecioFinal = new Label();
            lbBeneficio = new Label();
            btCancelar = new Button();
            btOK = new Button();
            lbPrecioProducto = new Label();
            lbDescripcion = new Label();
            lbCodigo = new Label();
            lbTituloAgregar = new Label();
            ((System.ComponentModel.ISupportInitialize)numericPrecioFinal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBeneficio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            SuspendLayout();
            // 
            // txtNumCodigoProducto
            // 
            txtNumCodigoProducto.Location = new Point(170, 125);
            txtNumCodigoProducto.Name = "txtNumCodigoProducto";
            txtNumCodigoProducto.Size = new Size(146, 27);
            txtNumCodigoProducto.TabIndex = 47;
            txtNumCodigoProducto.Text = "0";
            // 
            // numericPrecioFinal
            // 
            numericPrecioFinal.Enabled = false;
            numericPrecioFinal.Location = new Point(170, 333);
            numericPrecioFinal.Name = "numericPrecioFinal";
            numericPrecioFinal.Size = new Size(146, 27);
            numericPrecioFinal.TabIndex = 46;
            // 
            // numericBeneficio
            // 
            numericBeneficio.Enabled = false;
            numericBeneficio.Location = new Point(170, 289);
            numericBeneficio.Name = "numericBeneficio";
            numericBeneficio.Size = new Size(146, 27);
            numericBeneficio.TabIndex = 45;
            numericBeneficio.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericPrecio
            // 
            numericPrecio.Location = new Point(170, 242);
            numericPrecio.Name = "numericPrecio";
            numericPrecio.Size = new Size(146, 27);
            numericPrecio.TabIndex = 44;
            // 
            // rtxtDescripcion
            // 
            rtxtDescripcion.Location = new Point(175, 174);
            rtxtDescripcion.Name = "rtxtDescripcion";
            rtxtDescripcion.Size = new Size(141, 46);
            rtxtDescripcion.TabIndex = 43;
            rtxtDescripcion.Text = "";
            // 
            // lbPrecioFinal
            // 
            lbPrecioFinal.AutoSize = true;
            lbPrecioFinal.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrecioFinal.Location = new Point(28, 329);
            lbPrecioFinal.Name = "lbPrecioFinal";
            lbPrecioFinal.Size = new Size(141, 28);
            lbPrecioFinal.TabIndex = 41;
            lbPrecioFinal.Text = "Precio Final";
            // 
            // lbBeneficio
            // 
            lbBeneficio.AutoSize = true;
            lbBeneficio.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbBeneficio.Location = new Point(28, 285);
            lbBeneficio.Name = "lbBeneficio";
            lbBeneficio.Size = new Size(115, 28);
            lbBeneficio.TabIndex = 40;
            lbBeneficio.Text = "Beneficio";
            // 
            // btCancelar
            // 
            btCancelar.DialogResult = DialogResult.Cancel;
            btCancelar.Location = new Point(299, 472);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(105, 29);
            btCancelar.TabIndex = 39;
            btCancelar.Text = "CANCELAR";
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            btOK.DialogResult = DialogResult.OK;
            btOK.Location = new Point(299, 437);
            btOK.Name = "btOK";
            btOK.Size = new Size(105, 29);
            btOK.TabIndex = 38;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            // 
            // lbPrecioProducto
            // 
            lbPrecioProducto.AutoSize = true;
            lbPrecioProducto.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrecioProducto.Location = new Point(28, 241);
            lbPrecioProducto.Name = "lbPrecioProducto";
            lbPrecioProducto.Size = new Size(81, 28);
            lbPrecioProducto.TabIndex = 37;
            lbPrecioProducto.Text = "Precio";
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDescripcion.Location = new Point(28, 174);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(141, 28);
            lbDescripcion.TabIndex = 36;
            lbDescripcion.Text = "Descripción";
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCodigo.Location = new Point(28, 121);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(87, 28);
            lbCodigo.TabIndex = 35;
            lbCodigo.Text = "Código";
            // 
            // lbTituloAgregar
            // 
            lbTituloAgregar.AutoSize = true;
            lbTituloAgregar.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbTituloAgregar.Location = new Point(152, 59);
            lbTituloAgregar.Name = "lbTituloAgregar";
            lbTituloAgregar.Size = new Size(135, 38);
            lbTituloAgregar.TabIndex = 34;
            lbTituloAgregar.Text = "Agregar";
            // 
            // formEditarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(418, 511);
            Controls.Add(txtNumCodigoProducto);
            Controls.Add(numericPrecioFinal);
            Controls.Add(numericBeneficio);
            Controls.Add(numericPrecio);
            Controls.Add(rtxtDescripcion);
            Controls.Add(lbPrecioFinal);
            Controls.Add(lbBeneficio);
            Controls.Add(btCancelar);
            Controls.Add(btOK);
            Controls.Add(lbPrecioProducto);
            Controls.Add(lbDescripcion);
            Controls.Add(lbCodigo);
            Controls.Add(lbTituloAgregar);
            Name = "formEditarProductos";
            Text = "Agregar";
            ((System.ComponentModel.ISupportInitialize)numericPrecioFinal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBeneficio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtNumCodigoProducto;
        public NumericUpDown numericPrecioFinal;
        public NumericUpDown numericBeneficio;
        public NumericUpDown numericPrecio;
        public RichTextBox rtxtDescripcion;
        public Label lbPrecioFinal;
        public Label lbBeneficio;
        public Button btCancelar;
        public Button btOK;
        public Label lbPrecioProducto;
        public Label lbDescripcion;
        public Label lbCodigo;
        public Label lbTituloAgregar;
    }
}