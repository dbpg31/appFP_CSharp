namespace appFP_CSharp.secuenciales
{
    partial class _05
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
            lblGigabytes = new Label();
            txtGigabytes = new TextBox();
            txtMegabytes = new TextBox();
            txtKilobytes = new TextBox();
            txtBytes = new TextBox();
            lblMegabytes = new Label();
            lblKilogytes = new Label();
            lblBytes = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(262, 288);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblGigabytes
            // 
            lblGigabytes.AutoSize = true;
            lblGigabytes.Location = new Point(197, 100);
            lblGigabytes.Name = "lblGigabytes";
            lblGigabytes.Size = new Size(59, 15);
            lblGigabytes.TabIndex = 1;
            lblGigabytes.Text = "Gigabytes";
            // 
            // txtGigabytes
            // 
            txtGigabytes.Location = new Point(321, 92);
            txtGigabytes.Name = "txtGigabytes";
            txtGigabytes.Size = new Size(100, 23);
            txtGigabytes.TabIndex = 2;
            // 
            // txtMegabytes
            // 
            txtMegabytes.Location = new Point(321, 130);
            txtMegabytes.Name = "txtMegabytes";
            txtMegabytes.ReadOnly = true;
            txtMegabytes.Size = new Size(100, 23);
            txtMegabytes.TabIndex = 3;
            txtMegabytes.TextChanged += txtMegabytes_TextChanged;
            // 
            // txtKilobytes
            // 
            txtKilobytes.Location = new Point(321, 170);
            txtKilobytes.Name = "txtKilobytes";
            txtKilobytes.ReadOnly = true;
            txtKilobytes.Size = new Size(100, 23);
            txtKilobytes.TabIndex = 4;
            // 
            // txtBytes
            // 
            txtBytes.Location = new Point(321, 209);
            txtBytes.Name = "txtBytes";
            txtBytes.ReadOnly = true;
            txtBytes.Size = new Size(100, 23);
            txtBytes.TabIndex = 5;
            // 
            // lblMegabytes
            // 
            lblMegabytes.AutoSize = true;
            lblMegabytes.Location = new Point(197, 138);
            lblMegabytes.Name = "lblMegabytes";
            lblMegabytes.Size = new Size(65, 15);
            lblMegabytes.TabIndex = 6;
            lblMegabytes.Text = "Megabytes";
            // 
            // lblKilogytes
            // 
            lblKilogytes.AutoSize = true;
            lblKilogytes.Location = new Point(197, 178);
            lblKilogytes.Name = "lblKilogytes";
            lblKilogytes.Size = new Size(55, 15);
            lblKilogytes.TabIndex = 7;
            lblKilogytes.Text = "Kilobytes";
            // 
            // lblBytes
            // 
            lblBytes.AutoSize = true;
            lblBytes.Location = new Point(197, 218);
            lblBytes.Name = "lblBytes";
            lblBytes.Size = new Size(35, 15);
            lblBytes.TabIndex = 8;
            lblBytes.Text = "Bytes";
            // 
            // _05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 450);
            Controls.Add(lblBytes);
            Controls.Add(lblKilogytes);
            Controls.Add(lblMegabytes);
            Controls.Add(txtBytes);
            Controls.Add(txtKilobytes);
            Controls.Add(txtMegabytes);
            Controls.Add(txtGigabytes);
            Controls.Add(lblGigabytes);
            Controls.Add(btnCalcular);
            Name = "_05";
            Text = "_05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblGigabytes;
        private TextBox txtGigabytes;
        private TextBox txtMegabytes;
        private TextBox txtKilobytes;
        private TextBox txtBytes;
        private Label lblMegabytes;
        private Label lblKilogytes;
        private Label lblBytes;
    }
}