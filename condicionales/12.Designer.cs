﻿namespace appFP_CSharp.condicionales
{
    partial class _12
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
            lblDia = new Label();
            txtDia = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(114, 190);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click_1;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(58, 62);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Numero :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(172, 54);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(58, 121);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(102, 15);
            lblDia.TabIndex = 3;
            lblDia.Text = "Dia de la semana :";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(172, 118);
            txtDia.Name = "txtDia";
            txtDia.ReadOnly = true;
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 4;
            // 
            // _12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 287);
            Controls.Add(txtDia);
            Controls.Add(lblDia);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(btnCalcular);
            Name = "_12";
            Text = "_12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblDia;
        private TextBox txtDia;
    }
}