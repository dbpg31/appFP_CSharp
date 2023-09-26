namespace appFP_CSharp.condicionales
{
    partial class _14
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblVenta = new Label();
            lblTarjeta = new Label();
            lblDescuento = new Label();
            lblTotalPago = new Label();
            txtVenta = new TextBox();
            txtTarjeta = new TextBox();
            txtDescuento = new TextBox();
            txtTotalPago = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(112, 256);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(77, 42);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(109, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Numero de tarjeta :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(196, 34);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Location = new Point(77, 81);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(42, 15);
            lblVenta.TabIndex = 3;
            lblVenta.Text = "Venta :";
            // 
            // lblTarjeta
            // 
            lblTarjeta.AutoSize = true;
            lblTarjeta.Location = new Point(77, 122);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(47, 15);
            lblTarjeta.TabIndex = 4;
            lblTarjeta.Text = "Tarjeta :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(77, 159);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 5;
            lblDescuento.Text = "Descuento :";
            lblDescuento.Click += label4_Click;
            // 
            // lblTotalPago
            // 
            lblTotalPago.AutoSize = true;
            lblTotalPago.Location = new Point(77, 198);
            lblTotalPago.Name = "lblTotalPago";
            lblTotalPago.Size = new Size(80, 15);
            lblTotalPago.TabIndex = 6;
            lblTotalPago.Text = "Total a Pagar :";
            // 
            // txtVenta
            // 
            txtVenta.Location = new Point(196, 73);
            txtVenta.Name = "txtVenta";
            txtVenta.Size = new Size(100, 23);
            txtVenta.TabIndex = 7;
            // 
            // txtTarjeta
            // 
            txtTarjeta.Location = new Point(196, 114);
            txtTarjeta.Name = "txtTarjeta";
            txtTarjeta.ReadOnly = true;
            txtTarjeta.Size = new Size(100, 23);
            txtTarjeta.TabIndex = 8;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(196, 151);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 9;
            // 
            // txtTotalPago
            // 
            txtTotalPago.Location = new Point(196, 190);
            txtTotalPago.Name = "txtTotalPago";
            txtTotalPago.ReadOnly = true;
            txtTotalPago.Size = new Size(100, 23);
            txtTotalPago.TabIndex = 10;
            // 
            // _14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 340);
            Controls.Add(txtTotalPago);
            Controls.Add(txtDescuento);
            Controls.Add(txtTarjeta);
            Controls.Add(txtVenta);
            Controls.Add(lblTotalPago);
            Controls.Add(lblDescuento);
            Controls.Add(lblTarjeta);
            Controls.Add(lblVenta);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(btnCalcular);
            Name = "_14";
            Text = "_14";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblVenta;
        private Label lblTarjeta;
        private Label lblDescuento;
        private Label lblTotalPago;
        private TextBox txtVenta;
        private TextBox txtTarjeta;
        private TextBox txtDescuento;
        private TextBox txtTotalPago;
    }
}