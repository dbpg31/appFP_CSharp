namespace appFP_CSharp.condicionales
{
    partial class _15
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
            lblVenta = new Label();
            txtVenta = new TextBox();
            lblSueldoBruto = new Label();
            lblComision = new Label();
            lblDescuento = new Label();
            lblSueldoNeto = new Label();
            txtSueldoBruto = new TextBox();
            txtComision = new TextBox();
            txtDescuento = new TextBox();
            txtSueldoNeto = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(128, 319);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Location = new Point(43, 49);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(42, 15);
            lblVenta.TabIndex = 1;
            lblVenta.Text = "Venta :";
            // 
            // txtVenta
            // 
            txtVenta.Location = new Point(160, 41);
            txtVenta.Name = "txtVenta";
            txtVenta.Size = new Size(100, 23);
            txtVenta.TabIndex = 2;
            // 
            // lblSueldoBruto
            // 
            lblSueldoBruto.AutoSize = true;
            lblSueldoBruto.Location = new Point(43, 87);
            lblSueldoBruto.Name = "lblSueldoBruto";
            lblSueldoBruto.Size = new Size(81, 15);
            lblSueldoBruto.TabIndex = 3;
            lblSueldoBruto.Text = "Sueldo Bruto :";
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new Point(43, 130);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(64, 15);
            lblComision.TabIndex = 4;
            lblComision.Text = "Comisión :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(43, 169);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 5;
            lblDescuento.Text = "Descuento :";
            // 
            // lblSueldoNeto
            // 
            lblSueldoNeto.AutoSize = true;
            lblSueldoNeto.Location = new Point(43, 211);
            lblSueldoNeto.Name = "lblSueldoNeto";
            lblSueldoNeto.Size = new Size(78, 15);
            lblSueldoNeto.TabIndex = 6;
            lblSueldoNeto.Text = "Sueldo Neto :";
            // 
            // txtSueldoBruto
            // 
            txtSueldoBruto.Location = new Point(160, 79);
            txtSueldoBruto.Name = "txtSueldoBruto";
            txtSueldoBruto.ReadOnly = true;
            txtSueldoBruto.Size = new Size(100, 23);
            txtSueldoBruto.TabIndex = 7;
            // 
            // txtComision
            // 
            txtComision.Location = new Point(160, 122);
            txtComision.Name = "txtComision";
            txtComision.ReadOnly = true;
            txtComision.Size = new Size(100, 23);
            txtComision.TabIndex = 8;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(160, 161);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 9;
            // 
            // txtSueldoNeto
            // 
            txtSueldoNeto.Location = new Point(160, 203);
            txtSueldoNeto.Name = "txtSueldoNeto";
            txtSueldoNeto.ReadOnly = true;
            txtSueldoNeto.Size = new Size(100, 23);
            txtSueldoNeto.TabIndex = 10;
            // 
            // _15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 450);
            Controls.Add(txtSueldoNeto);
            Controls.Add(txtDescuento);
            Controls.Add(txtComision);
            Controls.Add(txtSueldoBruto);
            Controls.Add(lblSueldoNeto);
            Controls.Add(lblDescuento);
            Controls.Add(lblComision);
            Controls.Add(lblSueldoBruto);
            Controls.Add(txtVenta);
            Controls.Add(lblVenta);
            Controls.Add(btnCalcular);
            Name = "_15";
            Text = "_15";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblVenta;
        private TextBox txtVenta;
        private Label lblSueldoBruto;
        private Label lblComision;
        private Label lblDescuento;
        private Label lblSueldoNeto;
        private TextBox txtSueldoBruto;
        private TextBox txtComision;
        private TextBox txtDescuento;
        private TextBox txtSueldoNeto;
    }
}