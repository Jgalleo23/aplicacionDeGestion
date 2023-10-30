namespace aplicacionDeGestion
{
    partial class formMenu
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
            btProductosFormulario = new Button();
            btClientesFormulario = new Button();
            btFactura = new Button();
            SuspendLayout();
            // 
            // btProductosFormulario
            // 
            btProductosFormulario.DialogResult = DialogResult.OK;
            btProductosFormulario.Location = new Point(410, 146);
            btProductosFormulario.Name = "btProductosFormulario";
            btProductosFormulario.Size = new Size(136, 119);
            btProductosFormulario.TabIndex = 9;
            btProductosFormulario.Text = "Productos";
            btProductosFormulario.UseVisualStyleBackColor = true;
            btProductosFormulario.Click += btProductosFormulario_Click;
            // 
            // btClientesFormulario
            // 
            btClientesFormulario.DialogResult = DialogResult.OK;
            btClientesFormulario.Location = new Point(228, 146);
            btClientesFormulario.Name = "btClientesFormulario";
            btClientesFormulario.Size = new Size(136, 119);
            btClientesFormulario.TabIndex = 10;
            btClientesFormulario.Text = "Clientes";
            btClientesFormulario.UseVisualStyleBackColor = true;
            btClientesFormulario.Click += btClientesFormulario_Click;
            // 
            // btFactura
            // 
            btFactura.DialogResult = DialogResult.OK;
            btFactura.Location = new Point(318, 271);
            btFactura.Name = "btFactura";
            btFactura.Size = new Size(136, 119);
            btFactura.TabIndex = 11;
            btFactura.Text = "Factura";
            btFactura.UseVisualStyleBackColor = true;
            btFactura.Click += btFactura_Click;
            // 
            // formMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btFactura);
            Controls.Add(btClientesFormulario);
            Controls.Add(btProductosFormulario);
            Name = "formMenu";
            Text = "Form8";
            ResumeLayout(false);
        }

        #endregion
        public Button btProductosFormulario;
        public Button btClientesFormulario;
        public Button btFactura;
    }
}