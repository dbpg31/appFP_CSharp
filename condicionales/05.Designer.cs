namespace appFP_CSharp.condicionales
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            btnCalcular = new Button();
            lblNuevoNumero = new Label();
            txtNuevoNumero = new TextBox();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(64, 50);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(181, 42);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(109, 190);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblNuevoNumero
            // 
            lblNuevoNumero.AutoSize = true;
            lblNuevoNumero.Location = new Point(64, 125);
            lblNuevoNumero.Name = "lblNuevoNumero";
            lblNuevoNumero.Size = new Size(95, 15);
            lblNuevoNumero.TabIndex = 3;
            lblNuevoNumero.Text = "Nuevo Número :";
            // 
            // txtNuevoNumero
            // 
            txtNuevoNumero.Location = new Point(181, 117);
            txtNuevoNumero.Name = "txtNuevoNumero";
            txtNuevoNumero.Size = new Size(100, 23);
            txtNuevoNumero.TabIndex = 4;
            // 
            // _05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 289);
            Controls.Add(txtNuevoNumero);
            Controls.Add(lblNuevoNumero);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Name = "_05";
            Text = "_05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private Button btnCalcular;
        private Label lblNuevoNumero;
        private TextBox txtNuevoNumero;
    }
}