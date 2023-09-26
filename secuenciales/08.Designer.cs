namespace appFP_CSharp.secuenciales
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
            lblRadio = new Label();
            txtRadio = new TextBox();
            btnCalcular = new Button();
            lblAltura = new Label();
            lblAreaBase = new Label();
            lblAreaLateral = new Label();
            lblAreaTotal = new Label();
            txtAltura = new TextBox();
            txtAreaBase = new TextBox();
            txtAreaLateral = new TextBox();
            txtAreaTotal = new TextBox();
            SuspendLayout();
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Location = new Point(72, 37);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(46, 15);
            lblRadio.TabIndex = 0;
            lblRadio.Text = "Radio : ";
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(199, 29);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 23);
            txtRadio.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(140, 317);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(72, 85);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(48, 15);
            lblAltura.TabIndex = 3;
            lblAltura.Text = "Altura : ";
            // 
            // lblAreaBase
            // 
            lblAreaBase.AutoSize = true;
            lblAreaBase.Location = new Point(72, 132);
            lblAreaBase.Name = "lblAreaBase";
            lblAreaBase.Size = new Size(83, 15);
            lblAreaBase.TabIndex = 4;
            lblAreaBase.Text = "Área de Base : ";
            // 
            // lblAreaLateral
            // 
            lblAreaLateral.AutoSize = true;
            lblAreaLateral.Location = new Point(72, 172);
            lblAreaLateral.Name = "lblAreaLateral";
            lblAreaLateral.Size = new Size(78, 15);
            lblAreaLateral.TabIndex = 5;
            lblAreaLateral.Text = "Área Lateral : ";
            // 
            // lblAreaTotal
            // 
            lblAreaTotal.AutoSize = true;
            lblAreaTotal.Location = new Point(72, 225);
            lblAreaTotal.Name = "lblAreaTotal";
            lblAreaTotal.Size = new Size(68, 15);
            lblAreaTotal.TabIndex = 6;
            lblAreaTotal.Text = "Área Total : ";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(199, 77);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 7;
            // 
            // txtAreaBase
            // 
            txtAreaBase.Location = new Point(199, 124);
            txtAreaBase.Name = "txtAreaBase";
            txtAreaBase.ReadOnly = true;
            txtAreaBase.Size = new Size(100, 23);
            txtAreaBase.TabIndex = 8;
            // 
            // txtAreaLateral
            // 
            txtAreaLateral.Location = new Point(199, 164);
            txtAreaLateral.Name = "txtAreaLateral";
            txtAreaLateral.ReadOnly = true;
            txtAreaLateral.Size = new Size(100, 23);
            txtAreaLateral.TabIndex = 9;
            // 
            // txtAreaTotal
            // 
            txtAreaTotal.Location = new Point(199, 217);
            txtAreaTotal.Name = "txtAreaTotal";
            txtAreaTotal.ReadOnly = true;
            txtAreaTotal.Size = new Size(100, 23);
            txtAreaTotal.TabIndex = 10;
            // 
            // _08
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 450);
            Controls.Add(txtAreaTotal);
            Controls.Add(txtAreaLateral);
            Controls.Add(txtAreaBase);
            Controls.Add(txtAltura);
            Controls.Add(lblAreaTotal);
            Controls.Add(lblAreaLateral);
            Controls.Add(lblAreaBase);
            Controls.Add(lblAltura);
            Controls.Add(btnCalcular);
            Controls.Add(txtRadio);
            Controls.Add(lblRadio);
            Name = "_08";
            Text = "_08";
            Load += _08_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRadio;
        private TextBox txtRadio;
        private Button btnCalcular;
        private Label lblAltura;
        private Label lblAreaBase;
        private Label lblAreaLateral;
        private Label lblAreaTotal;
        private TextBox txtAltura;
        private TextBox txtAreaBase;
        private TextBox txtAreaLateral;
        private TextBox txtAreaTotal;
    }
}