namespace appFP_CSharp.condicionales
{
    partial class _03
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
            lblAngulo = new Label();
            txtAngulo = new TextBox();
            lblTipo = new Label();
            txtTipo = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(146, 284);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblAngulo
            // 
            lblAngulo.AutoSize = true;
            lblAngulo.Location = new Point(61, 93);
            lblAngulo.Name = "lblAngulo";
            lblAngulo.Size = new Size(55, 15);
            lblAngulo.TabIndex = 1;
            lblAngulo.Text = "Angulo : ";
            // 
            // txtAngulo
            // 
            txtAngulo.Location = new Point(146, 85);
            txtAngulo.Name = "txtAngulo";
            txtAngulo.Size = new Size(100, 23);
            txtAngulo.TabIndex = 2;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(61, 176);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(80, 15);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Clasificación :";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(146, 168);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 4;
            // 
            // _03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 368);
            Controls.Add(txtTipo);
            Controls.Add(lblTipo);
            Controls.Add(txtAngulo);
            Controls.Add(lblAngulo);
            Controls.Add(btnCalcular);
            Name = "_03";
            Text = "_03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblAngulo;
        private TextBox txtAngulo;
        private Label lblTipo;
        private TextBox txtTipo;
    }
}