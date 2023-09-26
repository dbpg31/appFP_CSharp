namespace appFP_CSharp.secuenciales
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
            lblRadio = new Label();
            txtRadio = new TextBox();
            btnCalcular = new Button();
            lblAltura = new Label();
            lblAreaTotal = new Label();
            lblVolumen = new Label();
            txtAltura = new TextBox();
            txtAreaTotal = new TextBox();
            txtVolumen = new TextBox();
            SuspendLayout();
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Location = new Point(71, 55);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(46, 15);
            lblRadio.TabIndex = 0;
            lblRadio.Text = "Radio : ";
            lblRadio.Click += label1_Click;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(168, 47);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 23);
            txtRadio.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(109, 246);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Clacular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(71, 98);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(48, 15);
            lblAltura.TabIndex = 3;
            lblAltura.Text = "Altura : ";
            // 
            // lblAreaTotal
            // 
            lblAreaTotal.AutoSize = true;
            lblAreaTotal.Location = new Point(71, 139);
            lblAreaTotal.Name = "lblAreaTotal";
            lblAreaTotal.Size = new Size(68, 15);
            lblAreaTotal.TabIndex = 4;
            lblAreaTotal.Text = "Area Total : ";
            // 
            // lblVolumen
            // 
            lblVolumen.AutoSize = true;
            lblVolumen.Location = new Point(71, 176);
            lblVolumen.Name = "lblVolumen";
            lblVolumen.Size = new Size(63, 15);
            lblVolumen.TabIndex = 5;
            lblVolumen.Text = "Volumen : ";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(168, 90);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 6;
            // 
            // txtAreaTotal
            // 
            txtAreaTotal.Location = new Point(168, 131);
            txtAreaTotal.Name = "txtAreaTotal";
            txtAreaTotal.ReadOnly = true;
            txtAreaTotal.Size = new Size(100, 23);
            txtAreaTotal.TabIndex = 7;
            // 
            // txtVolumen
            // 
            txtVolumen.Location = new Point(168, 168);
            txtVolumen.Name = "txtVolumen";
            txtVolumen.ReadOnly = true;
            txtVolumen.Size = new Size(100, 23);
            txtVolumen.TabIndex = 8;
            // 
            // _06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 325);
            Controls.Add(txtVolumen);
            Controls.Add(txtAreaTotal);
            Controls.Add(txtAltura);
            Controls.Add(lblVolumen);
            Controls.Add(lblAreaTotal);
            Controls.Add(lblAltura);
            Controls.Add(btnCalcular);
            Controls.Add(txtRadio);
            Controls.Add(lblRadio);
            Name = "_06";
            Text = "_06";
            Load += _06_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRadio;
        private TextBox txtRadio;
        private Button btnCalcular;
        private Label lblAltura;
        private Label lblAreaTotal;
        private Label lblVolumen;
        private TextBox txtAltura;
        private TextBox txtAreaTotal;
        private TextBox txtVolumen;
    }
}