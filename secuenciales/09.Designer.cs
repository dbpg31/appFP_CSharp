﻿namespace appFP_CSharp.secuenciales
{
    partial class _09
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
            btnCalcular = new Button();
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblSuma = new Label();
            txtSuma = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(127, 245);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(67, 57);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(118, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Número de 4 Cifras : ";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(207, 49);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(67, 121);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(95, 15);
            lblSuma.TabIndex = 3;
            lblSuma.Text = "Suma de Cifras : ";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(207, 113);
            txtSuma.Name = "txtSuma";
            txtSuma.ReadOnly = true;
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 4;
            // 
            // _09
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 354);
            Controls.Add(txtSuma);
            Controls.Add(lblSuma);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(btnCalcular);
            Name = "_09";
            Text = "_09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblSuma;
        private TextBox txtSuma;
    }
}