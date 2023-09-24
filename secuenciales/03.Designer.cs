namespace appFP_CSharp.secuenciales
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
            lblKilometros = new Label();
            txtKilometros = new TextBox();
            txtPies = new TextBox();
            txtMillas = new TextBox();
            txtMetros = new TextBox();
            txtYardas = new TextBox();
            lblPies = new Label();
            lblMillas = new Label();
            lblMetros = new Label();
            lblYardas = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(212, 331);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblKilometros
            // 
            lblKilometros.AutoSize = true;
            lblKilometros.Location = new Point(103, 51);
            lblKilometros.Name = "lblKilometros";
            lblKilometros.Size = new Size(64, 15);
            lblKilometros.TabIndex = 1;
            lblKilometros.Text = "Kilometros";
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(242, 43);
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(100, 23);
            txtKilometros.TabIndex = 2;
            // 
            // txtPies
            // 
            txtPies.Location = new Point(242, 84);
            txtPies.Name = "txtPies";
            txtPies.Size = new Size(100, 23);
            txtPies.TabIndex = 3;
            // 
            // txtMillas
            // 
            txtMillas.Location = new Point(242, 131);
            txtMillas.Name = "txtMillas";
            txtMillas.Size = new Size(100, 23);
            txtMillas.TabIndex = 4;
            // 
            // txtMetros
            // 
            txtMetros.Location = new Point(242, 178);
            txtMetros.Name = "txtMetros";
            txtMetros.ReadOnly = true;
            txtMetros.Size = new Size(100, 23);
            txtMetros.TabIndex = 5;
            // 
            // txtYardas
            // 
            txtYardas.Location = new Point(242, 222);
            txtYardas.Name = "txtYardas";
            txtYardas.ReadOnly = true;
            txtYardas.Size = new Size(100, 23);
            txtYardas.TabIndex = 6;
            // 
            // lblPies
            // 
            lblPies.AutoSize = true;
            lblPies.Location = new Point(103, 92);
            lblPies.Name = "lblPies";
            lblPies.Size = new Size(28, 15);
            lblPies.TabIndex = 7;
            lblPies.Text = "Pies";
            // 
            // lblMillas
            // 
            lblMillas.AutoSize = true;
            lblMillas.Location = new Point(103, 139);
            lblMillas.Name = "lblMillas";
            lblMillas.Size = new Size(38, 15);
            lblMillas.TabIndex = 8;
            lblMillas.Text = "Millas";
            // 
            // lblMetros
            // 
            lblMetros.AutoSize = true;
            lblMetros.Location = new Point(103, 186);
            lblMetros.Name = "lblMetros";
            lblMetros.Size = new Size(44, 15);
            lblMetros.TabIndex = 9;
            lblMetros.Text = "Metros";
            // 
            // lblYardas
            // 
            lblYardas.AutoSize = true;
            lblYardas.Location = new Point(103, 230);
            lblYardas.Name = "lblYardas";
            lblYardas.Size = new Size(41, 15);
            lblYardas.TabIndex = 10;
            lblYardas.Text = "Yardas";
            // 
            // _03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 450);
            Controls.Add(lblYardas);
            Controls.Add(lblMetros);
            Controls.Add(lblMillas);
            Controls.Add(lblPies);
            Controls.Add(txtYardas);
            Controls.Add(txtMetros);
            Controls.Add(txtMillas);
            Controls.Add(txtPies);
            Controls.Add(txtKilometros);
            Controls.Add(lblKilometros);
            Controls.Add(btnCalcular);
            Name = "_03";
            Text = "_03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblKilometros;
        private TextBox txtKilometros;
        private TextBox txtPies;
        private TextBox txtMillas;
        private TextBox txtMetros;
        private TextBox txtYardas;
        private Label lblPies;
        private Label lblMillas;
        private Label lblMetros;
        private Label lblYardas;
    }
}