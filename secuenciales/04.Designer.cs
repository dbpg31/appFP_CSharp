namespace appFP_CSharp.secuenciales
{
    partial class _04
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
            lblPies = new Label();
            txtPies = new TextBox();
            txtPulgadas = new TextBox();
            txtMetros = new TextBox();
            lblPulgadas = new Label();
            lblMetros = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(130, 223);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblPies
            // 
            lblPies.AutoSize = true;
            lblPies.Location = new Point(80, 76);
            lblPies.Name = "lblPies";
            lblPies.Size = new Size(28, 15);
            lblPies.TabIndex = 1;
            lblPies.Text = "Pies";
            // 
            // txtPies
            // 
            txtPies.Location = new Point(190, 68);
            txtPies.Name = "txtPies";
            txtPies.Size = new Size(100, 23);
            txtPies.TabIndex = 2;
            txtPies.TextChanged += textBox1_TextChanged;
            // 
            // txtPulgadas
            // 
            txtPulgadas.Location = new Point(190, 110);
            txtPulgadas.Name = "txtPulgadas";
            txtPulgadas.Size = new Size(100, 23);
            txtPulgadas.TabIndex = 3;
            // 
            // txtMetros
            // 
            txtMetros.Location = new Point(190, 150);
            txtMetros.Name = "txtMetros";
            txtMetros.ReadOnly = true;
            txtMetros.Size = new Size(100, 23);
            txtMetros.TabIndex = 4;
            // 
            // lblPulgadas
            // 
            lblPulgadas.AutoSize = true;
            lblPulgadas.Location = new Point(80, 118);
            lblPulgadas.Name = "lblPulgadas";
            lblPulgadas.Size = new Size(55, 15);
            lblPulgadas.TabIndex = 5;
            lblPulgadas.Text = "Pulgadas";
            // 
            // lblMetros
            // 
            lblMetros.AutoSize = true;
            lblMetros.Location = new Point(80, 158);
            lblMetros.Name = "lblMetros";
            lblMetros.Size = new Size(44, 15);
            lblMetros.TabIndex = 6;
            lblMetros.Text = "Metros";
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 337);
            Controls.Add(lblMetros);
            Controls.Add(lblPulgadas);
            Controls.Add(txtMetros);
            Controls.Add(txtPulgadas);
            Controls.Add(txtPies);
            Controls.Add(lblPies);
            Controls.Add(btnCalcular);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblPies;
        private TextBox txtPies;
        private TextBox txtPulgadas;
        private TextBox txtMetros;
        private Label lblPulgadas;
        private Label lblMetros;
    }
}