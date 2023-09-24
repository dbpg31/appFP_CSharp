namespace appFP_CSharp.secuenciales
{
    partial class _02
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
            lblCentimetros = new Label();
            lblMetros = new Label();
            label3 = new Label();
            lblPVarones = new Label();
            lblPMujeres = new Label();
            calcular = new Button();
            txtMetros = new TextBox();
            txtCentimetros = new TextBox();
            label1 = new Label();
            lblYardas = new Label();
            lblPulgadas = new Label();
            lblPies = new Label();
            txtYardas = new TextBox();
            txtPies = new TextBox();
            txtPulgadas = new TextBox();
            SuspendLayout();
            // 
            // lblCentimetros
            // 
            lblCentimetros.AccessibleName = "";
            lblCentimetros.AutoSize = true;
            lblCentimetros.Location = new Point(21, 65);
            lblCentimetros.Name = "lblCentimetros";
            lblCentimetros.Size = new Size(72, 15);
            lblCentimetros.TabIndex = 4;
            lblCentimetros.Text = "Centìmetros";
            // 
            // lblMetros
            // 
            lblMetros.AccessibleName = "";
            lblMetros.AutoSize = true;
            lblMetros.Location = new Point(21, 30);
            lblMetros.Name = "lblMetros";
            lblMetros.Size = new Size(53, 15);
            lblMetros.TabIndex = 7;
            lblMetros.Text = "Metros  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 65);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 11;
            // 
            // lblPVarones
            // 
            lblPVarones.AutoSize = true;
            lblPVarones.Location = new Point(227, 30);
            lblPVarones.Name = "lblPVarones";
            lblPVarones.Size = new Size(0, 15);
            lblPVarones.TabIndex = 6;
            // 
            // lblPMujeres
            // 
            lblPMujeres.AutoSize = true;
            lblPMujeres.Location = new Point(227, 65);
            lblPMujeres.Name = "lblPMujeres";
            lblPMujeres.Size = new Size(0, 15);
            lblPMujeres.TabIndex = 5;
            // 
            // calcular
            // 
            calcular.Location = new Point(106, 231);
            calcular.Name = "calcular";
            calcular.Size = new Size(75, 23);
            calcular.TabIndex = 12;
            calcular.Text = "c&alcular";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += calcular_Click;
            // 
            // txtMetros
            // 
            txtMetros.AccessibleName = "";
            txtMetros.Location = new Point(106, 22);
            txtMetros.Name = "txtMetros";
            txtMetros.Size = new Size(100, 23);
            txtMetros.TabIndex = 9;
            txtMetros.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCentimetros
            // 
            txtCentimetros.Location = new Point(106, 57);
            txtCentimetros.Name = "txtCentimetros";
            txtCentimetros.Size = new Size(100, 23);
            txtCentimetros.TabIndex = 10;
            txtCentimetros.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-7, -2);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 8;
            // 
            // lblYardas
            // 
            lblYardas.AccessibleName = "";
            lblYardas.AutoSize = true;
            lblYardas.Location = new Point(21, 162);
            lblYardas.Name = "lblYardas";
            lblYardas.Size = new Size(47, 15);
            lblYardas.TabIndex = 13;
            lblYardas.Text = "Yardas :";
            // 
            // lblPulgadas
            // 
            lblPulgadas.AccessibleName = "";
            lblPulgadas.AutoSize = true;
            lblPulgadas.Location = new Point(21, 89);
            lblPulgadas.Name = "lblPulgadas";
            lblPulgadas.Size = new Size(61, 15);
            lblPulgadas.TabIndex = 14;
            lblPulgadas.Text = "Pulgadas :";
            // 
            // lblPies
            // 
            lblPies.AccessibleName = "";
            lblPies.AutoSize = true;
            lblPies.Location = new Point(21, 120);
            lblPies.Name = "lblPies";
            lblPies.Size = new Size(34, 15);
            lblPies.TabIndex = 15;
            lblPies.Text = "Pies :";
            // 
            // txtYardas
            // 
            txtYardas.AccessibleName = "";
            txtYardas.Location = new Point(106, 159);
            txtYardas.Name = "txtYardas";
            txtYardas.ReadOnly = true;
            txtYardas.Size = new Size(100, 23);
            txtYardas.TabIndex = 16;
            txtYardas.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPies
            // 
            txtPies.AccessibleName = "";
            txtPies.Location = new Point(106, 117);
            txtPies.Name = "txtPies";
            txtPies.ReadOnly = true;
            txtPies.Size = new Size(100, 23);
            txtPies.TabIndex = 17;
            txtPies.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPulgadas
            // 
            txtPulgadas.AccessibleName = "";
            txtPulgadas.Location = new Point(106, 86);
            txtPulgadas.Name = "txtPulgadas";
            txtPulgadas.Size = new Size(100, 23);
            txtPulgadas.TabIndex = 18;
            txtPulgadas.TextAlign = HorizontalAlignment.Right;
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 355);
            Controls.Add(txtPulgadas);
            Controls.Add(txtPies);
            Controls.Add(txtYardas);
            Controls.Add(lblPies);
            Controls.Add(lblPulgadas);
            Controls.Add(lblYardas);
            Controls.Add(lblCentimetros);
            Controls.Add(txtCentimetros);
            Controls.Add(txtMetros);
            Controls.Add(calcular);
            Controls.Add(lblPMujeres);
            Controls.Add(lblPVarones);
            Controls.Add(label3);
            Controls.Add(lblMetros);
            Controls.Add(label1);
            Name = "_02";
            Text = "_02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCentimetros;
        private Label lblMetros;
        private Label label3;
        private Label lblPVarones;
        private Label lblPMujeres;
        private Button calcular;
        private TextBox txtMetros;
        private TextBox txtCentimetros;
        private Label label1;
        private Label lblYardas;
        private Label lblPulgadas;
        private Label lblPies;
        private TextBox txtYardas;
        private TextBox txtPies;
        private TextBox txtPulgadas;
    }
}