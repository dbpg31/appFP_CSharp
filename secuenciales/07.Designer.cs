namespace appFP_CSharp.secuenciales
{
    partial class _07
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
            lblBase = new Label();
            txtBase = new TextBox();
            lblAltura = new Label();
            lblArea = new Label();
            lblPerimetro = new Label();
            txtAltura = new TextBox();
            txtArea = new TextBox();
            txtPerimetro = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(114, 257);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.Location = new Point(78, 57);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(40, 15);
            lblBase.TabIndex = 1;
            lblBase.Text = "Base : ";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(183, 49);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 23);
            txtBase.TabIndex = 2;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(78, 103);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(48, 15);
            lblAltura.TabIndex = 3;
            lblAltura.Text = "Altura : ";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(78, 141);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(40, 15);
            lblArea.TabIndex = 4;
            lblArea.Text = "Area : ";
            // 
            // lblPerimetro
            // 
            lblPerimetro.AutoSize = true;
            lblPerimetro.Location = new Point(78, 185);
            lblPerimetro.Name = "lblPerimetro";
            lblPerimetro.Size = new Size(68, 15);
            lblPerimetro.TabIndex = 5;
            lblPerimetro.Text = "Perimetro : ";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(183, 95);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 6;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(183, 133);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(100, 23);
            txtArea.TabIndex = 7;
            // 
            // txtPerimetro
            // 
            txtPerimetro.Location = new Point(183, 177);
            txtPerimetro.Name = "txtPerimetro";
            txtPerimetro.ReadOnly = true;
            txtPerimetro.Size = new Size(100, 23);
            txtPerimetro.TabIndex = 8;
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 323);
            Controls.Add(txtPerimetro);
            Controls.Add(txtArea);
            Controls.Add(txtAltura);
            Controls.Add(lblPerimetro);
            Controls.Add(lblArea);
            Controls.Add(lblAltura);
            Controls.Add(txtBase);
            Controls.Add(lblBase);
            Controls.Add(btnCalcular);
            Name = "_07";
            Text = "_07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblBase;
        private TextBox txtBase;
        private Label lblAltura;
        private Label lblArea;
        private Label lblPerimetro;
        private TextBox txtAltura;
        private TextBox txtArea;
        private TextBox txtPerimetro;
    }
}