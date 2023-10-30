namespace aplicacionDeGestion
{
    partial class formEliminarProducto
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
            btCancelarBajas = new Button();
            btOKEliminar = new Button();
            lbTituloEliminar = new Label();
            txtCodigoEliminar = new TextBox();
            lbCodigoBajas = new Label();
            SuspendLayout();
            // 
            // btCancelarBajas
            // 
            btCancelarBajas.DialogResult = DialogResult.Cancel;
            btCancelarBajas.Location = new Point(335, 227);
            btCancelarBajas.Name = "btCancelarBajas";
            btCancelarBajas.Size = new Size(105, 29);
            btCancelarBajas.TabIndex = 15;
            btCancelarBajas.Text = "CANCELAR";
            btCancelarBajas.UseVisualStyleBackColor = true;
            // 
            // btOKEliminar
            // 
            btOKEliminar.DialogResult = DialogResult.OK;
            btOKEliminar.Location = new Point(335, 192);
            btOKEliminar.Name = "btOKEliminar";
            btOKEliminar.Size = new Size(105, 29);
            btOKEliminar.TabIndex = 14;
            btOKEliminar.Text = "OK";
            btOKEliminar.UseVisualStyleBackColor = true;
            // 
            // lbTituloEliminar
            // 
            lbTituloEliminar.AutoSize = true;
            lbTituloEliminar.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbTituloEliminar.Location = new Point(89, 49);
            lbTituloEliminar.Name = "lbTituloEliminar";
            lbTituloEliminar.Size = new Size(280, 38);
            lbTituloEliminar.TabIndex = 13;
            lbTituloEliminar.Text = "Eliminar producto";
            // 
            // txtCodigoEliminar
            // 
            txtCodigoEliminar.Location = new Point(203, 115);
            txtCodigoEliminar.Name = "txtCodigoEliminar";
            txtCodigoEliminar.Size = new Size(146, 27);
            txtCodigoEliminar.TabIndex = 12;
            // 
            // lbCodigoBajas
            // 
            lbCodigoBajas.AutoSize = true;
            lbCodigoBajas.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCodigoBajas.Location = new Point(84, 112);
            lbCodigoBajas.Name = "lbCodigoBajas";
            lbCodigoBajas.Size = new Size(87, 28);
            lbCodigoBajas.TabIndex = 11;
            lbCodigoBajas.Text = "Código";
            // 
            // formEliminarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(453, 267);
            Controls.Add(btCancelarBajas);
            Controls.Add(btOKEliminar);
            Controls.Add(lbTituloEliminar);
            Controls.Add(txtCodigoEliminar);
            Controls.Add(lbCodigoBajas);
            Name = "formEliminarProducto";
            Text = "Eliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btCancelarBajas;
        public Button btOKEliminar;
        public Label lbTituloEliminar;
        public TextBox txtCodigoEliminar;
        public Label lbCodigoBajas;
    }
}