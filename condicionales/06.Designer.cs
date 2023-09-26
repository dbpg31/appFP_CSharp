namespace appFP_CSharp.condicionales
{
    partial class _06
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
            lblEdad1 = new Label();
            btnCalcular = new Button();
            txtEdad1 = new TextBox();
            lblEdad2 = new Label();
            lblEdad3 = new Label();
            lblEdadMayor = new Label();
            lblEdadMenor = new Label();
            txtEdad2 = new TextBox();
            txtEdad3 = new TextBox();
            txtEdadMayor = new TextBox();
            txtEdadMenor = new TextBox();
            SuspendLayout();
            // 
            // lblEdad1
            // 
            lblEdad1.AutoSize = true;
            lblEdad1.Location = new Point(51, 25);
            lblEdad1.Name = "lblEdad1";
            lblEdad1.Size = new Size(58, 15);
            lblEdad1.TabIndex = 0;
            lblEdad1.Text = "1ra Edad :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(148, 270);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtEdad1
            // 
            txtEdad1.Location = new Point(159, 17);
            txtEdad1.Name = "txtEdad1";
            txtEdad1.Size = new Size(100, 23);
            txtEdad1.TabIndex = 2;
            // 
            // lblEdad2
            // 
            lblEdad2.AutoSize = true;
            lblEdad2.Location = new Point(51, 69);
            lblEdad2.Name = "lblEdad2";
            lblEdad2.Size = new Size(61, 15);
            lblEdad2.TabIndex = 3;
            lblEdad2.Text = "2da Edad :";
            // 
            // lblEdad3
            // 
            lblEdad3.AutoSize = true;
            lblEdad3.Location = new Point(51, 104);
            lblEdad3.Name = "lblEdad3";
            lblEdad3.Size = new Size(58, 15);
            lblEdad3.TabIndex = 4;
            lblEdad3.Text = "3ra Edad :";
            // 
            // lblEdadMayor
            // 
            lblEdadMayor.AutoSize = true;
            lblEdadMayor.Location = new Point(51, 151);
            lblEdadMayor.Name = "lblEdadMayor";
            lblEdadMayor.Size = new Size(76, 15);
            lblEdadMayor.TabIndex = 5;
            lblEdadMayor.Text = "Edad Mayor :";
            // 
            // lblEdadMenor
            // 
            lblEdadMenor.AutoSize = true;
            lblEdadMenor.Location = new Point(51, 198);
            lblEdadMenor.Name = "lblEdadMenor";
            lblEdadMenor.Size = new Size(77, 15);
            lblEdadMenor.TabIndex = 6;
            lblEdadMenor.Text = "Edad Menor :";
            // 
            // txtEdad2
            // 
            txtEdad2.Location = new Point(159, 61);
            txtEdad2.Name = "txtEdad2";
            txtEdad2.Size = new Size(100, 23);
            txtEdad2.TabIndex = 7;
            // 
            // txtEdad3
            // 
            txtEdad3.Location = new Point(159, 96);
            txtEdad3.Name = "txtEdad3";
            txtEdad3.Size = new Size(100, 23);
            txtEdad3.TabIndex = 8;
            // 
            // txtEdadMayor
            // 
            txtEdadMayor.Location = new Point(159, 143);
            txtEdadMayor.Name = "txtEdadMayor";
            txtEdadMayor.ReadOnly = true;
            txtEdadMayor.Size = new Size(100, 23);
            txtEdadMayor.TabIndex = 9;
            // 
            // txtEdadMenor
            // 
            txtEdadMenor.Location = new Point(159, 190);
            txtEdadMenor.Name = "txtEdadMenor";
            txtEdadMenor.ReadOnly = true;
            txtEdadMenor.Size = new Size(100, 23);
            txtEdadMenor.TabIndex = 10;
            // 
            // _06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 379);
            Controls.Add(txtEdadMenor);
            Controls.Add(txtEdadMayor);
            Controls.Add(txtEdad3);
            Controls.Add(txtEdad2);
            Controls.Add(lblEdadMenor);
            Controls.Add(lblEdadMayor);
            Controls.Add(lblEdad3);
            Controls.Add(lblEdad2);
            Controls.Add(txtEdad1);
            Controls.Add(btnCalcular);
            Controls.Add(lblEdad1);
            Name = "_06";
            Text = "_06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEdad1;
        private Button btnCalcular;
        private TextBox txtEdad1;
        private Label lblEdad2;
        private Label lblEdad3;
        private Label lblEdadMayor;
        private Label lblEdadMenor;
        private TextBox txtEdad2;
        private TextBox txtEdad3;
        private TextBox txtEdadMayor;
        private TextBox txtEdadMenor;
    }
}