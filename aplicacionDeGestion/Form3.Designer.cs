﻿namespace aplicacionDeGestion
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
            SuspendLayout();
            // 
            // lbTituloAlta
            // 
            lbTituloAlta.AutoSize = true;
            lbTituloAlta.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbTituloAlta.Location = new Point(148, 61);
            lbTituloAlta.Name = "lbTituloAlta";
            lbTituloAlta.Size = new Size(94, 38);
            lbTituloAlta.TabIndex = 0;
            lbTituloAlta.Text = "Altas";
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCodigo.Location = new Point(12, 123);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(87, 28);
            lbCodigo.TabIndex = 1;
            lbCodigo.Text = "Código";
            // 
            // lbNumCodigo
            // 
            lbNumCodigo.AutoSize = true;
            lbNumCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbNumCodigo.Location = new Point(148, 122);
            lbNumCodigo.Name = "lbNumCodigo";
            lbNumCodigo.Size = new Size(23, 28);
            lbNumCodigo.TabIndex = 2;
            lbNumCodigo.Text = "0";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbNombre.Location = new Point(12, 176);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(97, 28);
            lbNombre.TabIndex = 3;
            lbNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(148, 179);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(146, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(148, 226);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(146, 27);
            txtApellidos.TabIndex = 6;
            // 
            // lbApellidos
            // 
            lbApellidos.AutoSize = true;
            lbApellidos.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbApellidos.Location = new Point(12, 226);
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
            txtDNI.Location = new Point(148, 273);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(146, 27);
            txtDNI.TabIndex = 10;
            // 
            // lbDNI
            // 
            lbDNI.AutoSize = true;
            lbDNI.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDNI.Location = new Point(12, 270);
            lbDNI.Name = "lbDNI";
            lbDNI.Size = new Size(53, 28);
            lbDNI.TabIndex = 9;
            lbDNI.Text = "DNI";
            // 
            // formAlta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(400, 515);
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
    }
}