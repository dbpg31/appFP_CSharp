namespace appFP_CSharp.secuenciales
{
    partial class _11
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
            lblNumero1 = new Label();
            txtNumero1 = new TextBox();
            lblNumero2 = new Label();
            lblNuevoNumero1 = new Label();
            lblNuevoNumero2 = new Label();
            txtNumero2 = new TextBox();
            txtNuevoNumero1 = new TextBox();
            txtNuevoNumero2 = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(119, 329);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(51, 44);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(132, 15);
            lblNumero1.TabIndex = 1;
            lblNumero1.Text = "1er Número de 3 cifras :";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(203, 36);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 2;
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(51, 87);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(136, 15);
            lblNumero2.TabIndex = 3;
            lblNumero2.Text = "2do Número de 3 cifras :";
            // 
            // lblNuevoNumero1
            // 
            lblNuevoNumero1.AutoSize = true;
            lblNuevoNumero1.Location = new Point(51, 136);
            lblNuevoNumero1.Name = "lblNuevoNumero1";
            lblNuevoNumero1.Size = new Size(107, 15);
            lblNuevoNumero1.TabIndex = 4;
            lblNuevoNumero1.Text = "Nuevo Número 1 : ";
            // 
            // lblNuevoNumero2
            // 
            lblNuevoNumero2.AutoSize = true;
            lblNuevoNumero2.Location = new Point(51, 180);
            lblNuevoNumero2.Name = "lblNuevoNumero2";
            lblNuevoNumero2.Size = new Size(107, 15);
            lblNuevoNumero2.TabIndex = 5;
            lblNuevoNumero2.Text = "Nuevo Número 2 : ";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(203, 79);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 6;
            // 
            // txtNuevoNumero1
            // 
            txtNuevoNumero1.Location = new Point(203, 128);
            txtNuevoNumero1.Name = "txtNuevoNumero1";
            txtNuevoNumero1.ReadOnly = true;
            txtNuevoNumero1.Size = new Size(100, 23);
            txtNuevoNumero1.TabIndex = 7;
            // 
            // txtNuevoNumero2
            // 
            txtNuevoNumero2.Location = new Point(203, 172);
            txtNuevoNumero2.Name = "txtNuevoNumero2";
            txtNuevoNumero2.ReadOnly = true;
            txtNuevoNumero2.Size = new Size(100, 23);
            txtNuevoNumero2.TabIndex = 8;
            // 
            // _11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 450);
            Controls.Add(txtNuevoNumero2);
            Controls.Add(txtNuevoNumero1);
            Controls.Add(txtNumero2);
            Controls.Add(lblNuevoNumero2);
            Controls.Add(lblNuevoNumero1);
            Controls.Add(lblNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblNumero1);
            Controls.Add(btnCalcular);
            Name = "_11";
            Text = "_11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblNumero1;
        private TextBox txtNumero1;
        private Label lblNumero2;
        private Label lblNuevoNumero1;
        private Label lblNuevoNumero2;
        private TextBox txtNumero2;
        private TextBox txtNuevoNumero1;
        private TextBox txtNuevoNumero2;
    }
}