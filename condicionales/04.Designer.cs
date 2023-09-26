namespace appFP_CSharp.condicionales
{
    partial class _04
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
            lblNota1 = new Label();
            btnCalcular = new Button();
            txtNota1 = new TextBox();
            lblNota2 = new Label();
            lblNota3 = new Label();
            lblNotaFinal = new Label();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtNotaFinal = new TextBox();
            SuspendLayout();
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(90, 42);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(58, 15);
            lblNota1.TabIndex = 0;
            lblNota1.Text = "1ra Nota :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(160, 277);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(194, 34);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 2;
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(90, 91);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(61, 15);
            lblNota2.TabIndex = 3;
            lblNota2.Text = "2da Nota :";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Location = new Point(90, 147);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(58, 15);
            lblNota3.TabIndex = 4;
            lblNota3.Text = "3ra Nota :";
            // 
            // lblNotaFinal
            // 
            lblNotaFinal.AutoSize = true;
            lblNotaFinal.Location = new Point(90, 209);
            lblNotaFinal.Name = "lblNotaFinal";
            lblNotaFinal.Size = new Size(67, 15);
            lblNotaFinal.TabIndex = 5;
            lblNotaFinal.Text = "Nota Final :";
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(194, 83);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 6;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(194, 139);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(100, 23);
            txtNota3.TabIndex = 7;
            // 
            // txtNotaFinal
            // 
            txtNotaFinal.Location = new Point(194, 201);
            txtNotaFinal.Name = "txtNotaFinal";
            txtNotaFinal.ReadOnly = true;
            txtNotaFinal.Size = new Size(100, 23);
            txtNotaFinal.TabIndex = 8;
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 450);
            Controls.Add(txtNotaFinal);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(lblNotaFinal);
            Controls.Add(lblNota3);
            Controls.Add(lblNota2);
            Controls.Add(txtNota1);
            Controls.Add(btnCalcular);
            Controls.Add(lblNota1);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNota1;
        private Button btnCalcular;
        private TextBox txtNota1;
        private Label lblNota2;
        private Label lblNota3;
        private Label lblNotaFinal;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtNotaFinal;
    }
}