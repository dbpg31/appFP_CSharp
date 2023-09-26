namespace appFP_CSharp.condicionales
{
    partial class _07
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
            txtNumero1 = new TextBox();
            lblNumero1 = new Label();
            lblNumero2 = new Label();
            lblNumero3 = new Label();
            lblMedio = new Label();
            txtNumero2 = new TextBox();
            txtNumero3 = new TextBox();
            txtMedio = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(119, 265);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(168, 46);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 1;
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(66, 54);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(58, 15);
            lblNumero1.TabIndex = 2;
            lblNumero1.Text = "1ra Edad :";
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(66, 96);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(61, 15);
            lblNumero2.TabIndex = 3;
            lblNumero2.Text = "2da Edad :";
            // 
            // lblNumero3
            // 
            lblNumero3.AutoSize = true;
            lblNumero3.Location = new Point(66, 140);
            lblNumero3.Name = "lblNumero3";
            lblNumero3.Size = new Size(58, 15);
            lblNumero3.TabIndex = 4;
            lblNumero3.Text = "3ra Edad :";
            // 
            // lblMedio
            // 
            lblMedio.AutoSize = true;
            lblMedio.Location = new Point(66, 195);
            lblMedio.Name = "lblMedio";
            lblMedio.Size = new Size(97, 15);
            lblMedio.TabIndex = 5;
            lblMedio.Text = "Numero Medio  :";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(168, 88);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 6;
            // 
            // txtNumero3
            // 
            txtNumero3.Location = new Point(168, 132);
            txtNumero3.Name = "txtNumero3";
            txtNumero3.Size = new Size(100, 23);
            txtNumero3.TabIndex = 7;
            // 
            // txtMedio
            // 
            txtMedio.Location = new Point(168, 187);
            txtMedio.Name = "txtMedio";
            txtMedio.ReadOnly = true;
            txtMedio.Size = new Size(100, 23);
            txtMedio.TabIndex = 8;
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 340);
            Controls.Add(txtMedio);
            Controls.Add(txtNumero3);
            Controls.Add(txtNumero2);
            Controls.Add(lblMedio);
            Controls.Add(lblNumero3);
            Controls.Add(lblNumero2);
            Controls.Add(lblNumero1);
            Controls.Add(txtNumero1);
            Controls.Add(btnCalcular);
            Name = "_07";
            Text = "_07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtNumero1;
        private Label lblNumero1;
        private Label lblNumero2;
        private Label lblNumero3;
        private Label lblMedio;
        private TextBox txtNumero2;
        private TextBox txtNumero3;
        private TextBox txtMedio;
    }
}