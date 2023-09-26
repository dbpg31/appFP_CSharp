namespace appFP_CSharp.condicionales
{
    partial class _08
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
            lblExamen1 = new Label();
            txtExamen1 = new TextBox();
            lblExamen2 = new Label();
            lblExamen3 = new Label();
            lblTotal = new Label();
            txtExamen2 = new TextBox();
            txtExamen3 = new TextBox();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(78, 242);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblExamen1
            // 
            lblExamen1.AutoSize = true;
            lblExamen1.Location = new Point(34, 40);
            lblExamen1.Name = "lblExamen1";
            lblExamen1.Size = new Size(74, 15);
            lblExamen1.TabIndex = 1;
            lblExamen1.Text = "1ra Examen :";
            // 
            // txtExamen1
            // 
            txtExamen1.Location = new Point(132, 32);
            txtExamen1.Name = "txtExamen1";
            txtExamen1.Size = new Size(100, 23);
            txtExamen1.TabIndex = 2;
            // 
            // lblExamen2
            // 
            lblExamen2.AutoSize = true;
            lblExamen2.Location = new Point(34, 82);
            lblExamen2.Name = "lblExamen2";
            lblExamen2.Size = new Size(77, 15);
            lblExamen2.TabIndex = 3;
            lblExamen2.Text = "2da Examen :";
            // 
            // lblExamen3
            // 
            lblExamen3.AutoSize = true;
            lblExamen3.Location = new Point(34, 124);
            lblExamen3.Name = "lblExamen3";
            lblExamen3.Size = new Size(68, 15);
            lblExamen3.TabIndex = 4;
            lblExamen3.Text = "3ra Exmen :";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(34, 167);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(82, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total Propina :";
            // 
            // txtExamen2
            // 
            txtExamen2.Location = new Point(132, 74);
            txtExamen2.Name = "txtExamen2";
            txtExamen2.Size = new Size(100, 23);
            txtExamen2.TabIndex = 6;
            // 
            // txtExamen3
            // 
            txtExamen3.Location = new Point(132, 116);
            txtExamen3.Name = "txtExamen3";
            txtExamen3.Size = new Size(100, 23);
            txtExamen3.TabIndex = 7;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(132, 159);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 8;
            // 
            // _08
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 307);
            Controls.Add(txtTotal);
            Controls.Add(txtExamen3);
            Controls.Add(txtExamen2);
            Controls.Add(lblTotal);
            Controls.Add(lblExamen3);
            Controls.Add(lblExamen2);
            Controls.Add(txtExamen1);
            Controls.Add(lblExamen1);
            Controls.Add(btnCalcular);
            Name = "_08";
            Text = "_08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblExamen1;
        private TextBox txtExamen1;
        private Label lblExamen2;
        private Label lblExamen3;
        private Label lblTotal;
        private TextBox txtExamen2;
        private TextBox txtExamen3;
        private TextBox txtTotal;
    }
}