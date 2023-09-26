namespace appFP_CSharp.secuenciales
{
    partial class _13
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
            lblCateto1 = new Label();
            txtCateto1 = new TextBox();
            lblCateto2 = new Label();
            lblHipotenusa = new Label();
            txtCateto2 = new TextBox();
            txtHipotenusa = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(128, 203);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblCateto1
            // 
            lblCateto1.AutoSize = true;
            lblCateto1.Location = new Point(38, 28);
            lblCateto1.Name = "lblCateto1";
            lblCateto1.Size = new Size(65, 15);
            lblCateto1.TabIndex = 1;
            lblCateto1.Text = "1er cateto :";
            // 
            // txtCateto1
            // 
            txtCateto1.Location = new Point(140, 20);
            txtCateto1.Name = "txtCateto1";
            txtCateto1.Size = new Size(100, 23);
            txtCateto1.TabIndex = 2;
            // 
            // lblCateto2
            // 
            lblCateto2.AutoSize = true;
            lblCateto2.Location = new Point(38, 81);
            lblCateto2.Name = "lblCateto2";
            lblCateto2.Size = new Size(69, 15);
            lblCateto2.TabIndex = 3;
            lblCateto2.Text = "2do cateto :";
            // 
            // lblHipotenusa
            // 
            lblHipotenusa.AutoSize = true;
            lblHipotenusa.Location = new Point(38, 127);
            lblHipotenusa.Name = "lblHipotenusa";
            lblHipotenusa.Size = new Size(74, 15);
            lblHipotenusa.TabIndex = 4;
            lblHipotenusa.Text = "Hipotenusa :";
            // 
            // txtCateto2
            // 
            txtCateto2.Location = new Point(140, 73);
            txtCateto2.Name = "txtCateto2";
            txtCateto2.Size = new Size(100, 23);
            txtCateto2.TabIndex = 5;
            // 
            // txtHipotenusa
            // 
            txtHipotenusa.Location = new Point(140, 119);
            txtHipotenusa.Name = "txtHipotenusa";
            txtHipotenusa.ReadOnly = true;
            txtHipotenusa.Size = new Size(100, 23);
            txtHipotenusa.TabIndex = 6;
            // 
            // _13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 310);
            Controls.Add(txtHipotenusa);
            Controls.Add(txtCateto2);
            Controls.Add(lblHipotenusa);
            Controls.Add(lblCateto2);
            Controls.Add(txtCateto1);
            Controls.Add(lblCateto1);
            Controls.Add(btnCalcular);
            Name = "_13";
            Text = "_13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblCateto1;
        private TextBox txtCateto1;
        private Label lblCateto2;
        private Label lblHipotenusa;
        private TextBox txtCateto2;
        private TextBox txtHipotenusa;
    }
}