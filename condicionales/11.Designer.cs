namespace appFP_CSharp.condicionales
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblTipo = new Label();
            txtTipo = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(120, 191);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(64, 45);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Numero :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(192, 37);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(64, 113);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(83, 15);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo Número :";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(192, 105);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 4;
            // 
            // _11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 333);
            Controls.Add(txtTipo);
            Controls.Add(lblTipo);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(btnCalcular);
            Name = "_11";
            Text = "_11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblTipo;
        private TextBox txtTipo;
    }
}