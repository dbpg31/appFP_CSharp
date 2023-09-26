namespace appFP_CSharp.secuenciales
{
    partial class _18
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
            txtUnidades = new TextBox();
            lblUnidades = new Label();
            lblPrecioBase = new Label();
            lblVenta = new Label();
            lblDescuentoTotal = new Label();
            txtPrecioBase = new TextBox();
            txtVenta = new TextBox();
            txtDescuentoTotal = new TextBox();
            lblVentaFinal = new Label();
            txtVentaFinal = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(121, 283);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtUnidades
            // 
            txtUnidades.Location = new Point(170, 42);
            txtUnidades.Name = "txtUnidades";
            txtUnidades.Size = new Size(100, 23);
            txtUnidades.TabIndex = 1;
            txtUnidades.TextChanged += textBox1_TextChanged;
            // 
            // lblUnidades
            // 
            lblUnidades.AutoSize = true;
            lblUnidades.Location = new Point(68, 50);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(62, 15);
            lblUnidades.TabIndex = 2;
            lblUnidades.Text = "Unidades :";
            // 
            // lblPrecioBase
            // 
            lblPrecioBase.AutoSize = true;
            lblPrecioBase.Location = new Point(68, 95);
            lblPrecioBase.Name = "lblPrecioBase";
            lblPrecioBase.Size = new Size(49, 15);
            lblPrecioBase.TabIndex = 3;
            lblPrecioBase.Text = "Precio  :";
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Location = new Point(68, 133);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(42, 15);
            lblVenta.TabIndex = 4;
            lblVenta.Text = "Venta :";
            lblVenta.Click += label3_Click;
            // 
            // lblDescuentoTotal
            // 
            lblDescuentoTotal.AutoSize = true;
            lblDescuentoTotal.Location = new Point(68, 174);
            lblDescuentoTotal.Name = "lblDescuentoTotal";
            lblDescuentoTotal.Size = new Size(97, 15);
            lblDescuentoTotal.TabIndex = 5;
            lblDescuentoTotal.Text = "Descuento Total :";
            lblDescuentoTotal.Click += label4_Click;
            // 
            // txtPrecioBase
            // 
            txtPrecioBase.Location = new Point(170, 87);
            txtPrecioBase.Name = "txtPrecioBase";
            txtPrecioBase.Size = new Size(100, 23);
            txtPrecioBase.TabIndex = 6;
            // 
            // txtVenta
            // 
            txtVenta.Location = new Point(170, 125);
            txtVenta.Name = "txtVenta";
            txtVenta.ReadOnly = true;
            txtVenta.Size = new Size(100, 23);
            txtVenta.TabIndex = 7;
            txtVenta.TextChanged += textBox3_TextChanged;
            // 
            // txtDescuentoTotal
            // 
            txtDescuentoTotal.Location = new Point(170, 166);
            txtDescuentoTotal.Name = "txtDescuentoTotal";
            txtDescuentoTotal.ReadOnly = true;
            txtDescuentoTotal.Size = new Size(100, 23);
            txtDescuentoTotal.TabIndex = 8;
            txtDescuentoTotal.TextChanged += textBox4_TextChanged;
            // 
            // lblVentaFinal
            // 
            lblVentaFinal.AutoSize = true;
            lblVentaFinal.Location = new Point(68, 217);
            lblVentaFinal.Name = "lblVentaFinal";
            lblVentaFinal.Size = new Size(70, 15);
            lblVentaFinal.TabIndex = 9;
            lblVentaFinal.Text = "Venta Final :";
            // 
            // txtVentaFinal
            // 
            txtVentaFinal.Location = new Point(170, 209);
            txtVentaFinal.Name = "txtVentaFinal";
            txtVentaFinal.ReadOnly = true;
            txtVentaFinal.Size = new Size(100, 23);
            txtVentaFinal.TabIndex = 10;
            // 
            // _18
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 356);
            Controls.Add(txtVentaFinal);
            Controls.Add(lblVentaFinal);
            Controls.Add(txtDescuentoTotal);
            Controls.Add(txtVenta);
            Controls.Add(txtPrecioBase);
            Controls.Add(lblDescuentoTotal);
            Controls.Add(lblVenta);
            Controls.Add(lblPrecioBase);
            Controls.Add(lblUnidades);
            Controls.Add(txtUnidades);
            Controls.Add(btnCalcular);
            Name = "_18";
            Text = "_18";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtUnidades;
        private Label lblUnidades;
        private Label lblPrecioBase;
        private Label lblVenta;
        private Label lblDescuentoTotal;
        private TextBox txtPrecioBase;
        private TextBox txtVenta;
        private TextBox txtDescuentoTotal;
        private Label lblVentaFinal;
        private TextBox txtVentaFinal;
    }
}