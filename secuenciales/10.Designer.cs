namespace appFP_CSharp.secuenciales
{
    partial class _10
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
            btnCalcular = new Button();
            txtNumero = new TextBox();
            txtNumeroReves = new TextBox();
            lblNumeroReves = new Label();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(113, 86);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(113, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número de 4 cifras :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(155, 253);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(245, 78);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            // 
            // txtNumeroReves
            // 
            txtNumeroReves.Location = new Point(245, 155);
            txtNumeroReves.Name = "txtNumeroReves";
            txtNumeroReves.ReadOnly = true;
            txtNumeroReves.Size = new Size(100, 23);
            txtNumeroReves.TabIndex = 3;
            // 
            // lblNumeroReves
            // 
            lblNumeroReves.AutoSize = true;
            lblNumeroReves.Location = new Point(113, 163);
            lblNumeroReves.Name = "lblNumeroReves";
            lblNumeroReves.Size = new Size(105, 15);
            lblNumeroReves.TabIndex = 4;
            lblNumeroReves.Text = "Número al Reves : ";
            // 
            // _10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 357);
            Controls.Add(lblNumeroReves);
            Controls.Add(txtNumeroReves);
            Controls.Add(txtNumero);
            Controls.Add(btnCalcular);
            Controls.Add(lblNumero);
            Name = "_10";
            Text = "_10";
            Load += _10_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Button btnCalcular;
        private TextBox txtNumero;
        private TextBox txtNumeroReves;
        private Label lblNumeroReves;
    }
}