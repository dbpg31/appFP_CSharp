namespace appFP_CSharp.secuenciales
{
    partial class _19
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
            txtVentas = new TextBox();
            lblVentas = new Label();
            lblSueldoBruto = new Label();
            lblSueldoBase = new Label();
            lblSueldoNeto = new Label();
            txtSueldoBase = new TextBox();
            txtSueldoBruto = new TextBox();
            txtSueldoNeto = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(112, 276);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtVentas
            // 
            txtVentas.Location = new Point(207, 49);
            txtVentas.Name = "txtVentas";
            txtVentas.Size = new Size(100, 23);
            txtVentas.TabIndex = 1;
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Location = new Point(66, 57);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(47, 15);
            lblVentas.TabIndex = 2;
            lblVentas.Text = "Ventas :";
            // 
            // lblSueldoBruto
            // 
            lblSueldoBruto.AutoSize = true;
            lblSueldoBruto.Location = new Point(66, 106);
            lblSueldoBruto.Name = "lblSueldoBruto";
            lblSueldoBruto.Size = new Size(75, 15);
            lblSueldoBruto.TabIndex = 3;
            lblSueldoBruto.Text = "Sueldo Bruto";
            // 
            // lblSueldoBase
            // 
            lblSueldoBase.AutoSize = true;
            lblSueldoBase.Location = new Point(66, 155);
            lblSueldoBase.Name = "lblSueldoBase";
            lblSueldoBase.Size = new Size(72, 15);
            lblSueldoBase.TabIndex = 4;
            lblSueldoBase.Text = "Descuento  :";
            // 
            // lblSueldoNeto
            // 
            lblSueldoNeto.AutoSize = true;
            lblSueldoNeto.Location = new Point(66, 202);
            lblSueldoNeto.Name = "lblSueldoNeto";
            lblSueldoNeto.Size = new Size(78, 15);
            lblSueldoNeto.TabIndex = 5;
            lblSueldoNeto.Text = "Sueldo Neto :";
            // 
            // txtSueldoBase
            // 
            txtSueldoBase.Location = new Point(207, 98);
            txtSueldoBase.Name = "txtSueldoBase";
            txtSueldoBase.ReadOnly = true;
            txtSueldoBase.Size = new Size(100, 23);
            txtSueldoBase.TabIndex = 6;
            // 
            // txtSueldoBruto
            // 
            txtSueldoBruto.Location = new Point(207, 147);
            txtSueldoBruto.Name = "txtSueldoBruto";
            txtSueldoBruto.ReadOnly = true;
            txtSueldoBruto.Size = new Size(100, 23);
            txtSueldoBruto.TabIndex = 7;
            // 
            // txtSueldoNeto
            // 
            txtSueldoNeto.Location = new Point(207, 194);
            txtSueldoNeto.Name = "txtSueldoNeto";
            txtSueldoNeto.ReadOnly = true;
            txtSueldoNeto.Size = new Size(100, 23);
            txtSueldoNeto.TabIndex = 8;
            // 
            // _19
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 450);
            Controls.Add(txtSueldoNeto);
            Controls.Add(txtSueldoBruto);
            Controls.Add(txtSueldoBase);
            Controls.Add(lblSueldoNeto);
            Controls.Add(lblSueldoBase);
            Controls.Add(lblSueldoBruto);
            Controls.Add(lblVentas);
            Controls.Add(txtVentas);
            Controls.Add(btnCalcular);
            Name = "_19";
            Text = "_19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtVentas;
        private Label lblVentas;
        private Label lblSueldoBruto;
        private Label lblSueldoBase;
        private Label lblSueldoNeto;
        private TextBox txtSueldoBase;
        private TextBox txtSueldoBruto;
        private TextBox txtSueldoNeto;
    }
}