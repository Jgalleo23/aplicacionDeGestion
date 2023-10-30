namespace aplicacionDeGestion
{
    partial class formBajas
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
            txtCodigoBajas = new TextBox();
            lbCodigoBajas = new Label();
            lbTituloBajas = new Label();
            btCancelarBajas = new Button();
            btOKBajas = new Button();
            SuspendLayout();
            // 
            // txtCodigoBajas
            // 
            txtCodigoBajas.Location = new Point(199, 101);
            txtCodigoBajas.Name = "txtCodigoBajas";
            txtCodigoBajas.Size = new Size(146, 27);
            txtCodigoBajas.TabIndex = 6;
            // 
            // lbCodigoBajas
            // 
            lbCodigoBajas.AutoSize = true;
            lbCodigoBajas.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCodigoBajas.Location = new Point(80, 98);
            lbCodigoBajas.Name = "lbCodigoBajas";
            lbCodigoBajas.Size = new Size(87, 28);
            lbCodigoBajas.TabIndex = 5;
            lbCodigoBajas.Text = "Código";
            // 
            // lbTituloBajas
            // 
            lbTituloBajas.AutoSize = true;
            lbTituloBajas.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbTituloBajas.Location = new Point(173, 35);
            lbTituloBajas.Name = "lbTituloBajas";
            lbTituloBajas.Size = new Size(100, 38);
            lbTituloBajas.TabIndex = 7;
            lbTituloBajas.Text = "Bajas";
            // 
            // btCancelarBajas
            // 
            btCancelarBajas.DialogResult = DialogResult.Cancel;
            btCancelarBajas.Location = new Point(331, 213);
            btCancelarBajas.Name = "btCancelarBajas";
            btCancelarBajas.Size = new Size(105, 29);
            btCancelarBajas.TabIndex = 10;
            btCancelarBajas.Text = "CANCELAR";
            btCancelarBajas.UseVisualStyleBackColor = true;
            // 
            // btOKBajas
            // 
            btOKBajas.DialogResult = DialogResult.OK;
            btOKBajas.Location = new Point(331, 178);
            btOKBajas.Name = "btOKBajas";
            btOKBajas.Size = new Size(105, 29);
            btOKBajas.TabIndex = 9;
            btOKBajas.Text = "OK";
            btOKBajas.UseVisualStyleBackColor = true;
            // 
            // formBajas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(448, 254);
            Controls.Add(btCancelarBajas);
            Controls.Add(btOKBajas);
            Controls.Add(lbTituloBajas);
            Controls.Add(txtCodigoBajas);
            Controls.Add(lbCodigoBajas);
            Name = "formBajas";
            Text = "Bajas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtCodigoBajas;
        public Label lbCodigoBajas;
        public Label lbTituloBajas;
        public Button btCancelarBajas;
        public Button btOKBajas;
    }
}