namespace appFP_CSharp.condicionales
{
    partial class _01
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
            lblCompra = new Label();
            lblDescuento = new Label();
            lblTotalPago = new Label();
            txtCompra = new TextBox();
            txtDescuento = new TextBox();
            txtTotalPago = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(99, 285);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtUnidades
            // 
            txtUnidades.Location = new Point(156, 48);
            txtUnidades.Name = "txtUnidades";
            txtUnidades.Size = new Size(100, 23);
            txtUnidades.TabIndex = 1;
            // 
            // lblUnidades
            // 
            lblUnidades.AutoSize = true;
            lblUnidades.Location = new Point(34, 56);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(62, 15);
            lblUnidades.TabIndex = 2;
            lblUnidades.Text = "Unidades :";
            // 
            // lblCompra
            // 
            lblCompra.AutoSize = true;
            lblCompra.Location = new Point(34, 106);
            lblCompra.Name = "lblCompra";
            lblCompra.Size = new Size(56, 15);
            lblCompra.TabIndex = 3;
            lblCompra.Text = "Compra :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(34, 151);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 4;
            lblDescuento.Text = "Descuento :";
            // 
            // lblTotalPago
            // 
            lblTotalPago.AutoSize = true;
            lblTotalPago.Location = new Point(34, 213);
            lblTotalPago.Name = "lblTotalPago";
            lblTotalPago.Size = new Size(80, 15);
            lblTotalPago.TabIndex = 5;
            lblTotalPago.Text = "Total a Pagar :";
            // 
            // txtCompra
            // 
            txtCompra.Location = new Point(156, 98);
            txtCompra.Name = "txtCompra";
            txtCompra.ReadOnly = true;
            txtCompra.Size = new Size(100, 23);
            txtCompra.TabIndex = 6;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(156, 143);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 7;
            // 
            // txtTotalPago
            // 
            txtTotalPago.Location = new Point(156, 205);
            txtTotalPago.Name = "txtTotalPago";
            txtTotalPago.ReadOnly = true;
            txtTotalPago.Size = new Size(100, 23);
            txtTotalPago.TabIndex = 8;
            // 
            // _01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 390);
            Controls.Add(txtTotalPago);
            Controls.Add(txtDescuento);
            Controls.Add(txtCompra);
            Controls.Add(lblTotalPago);
            Controls.Add(lblDescuento);
            Controls.Add(lblCompra);
            Controls.Add(lblUnidades);
            Controls.Add(txtUnidades);
            Controls.Add(btnCalcular);
            Name = "_01";
            Text = "_01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtUnidades;
        private Label lblUnidades;
        private Label lblCompra;
        private Label lblDescuento;
        private Label lblTotalPago;
        private TextBox txtCompra;
        private TextBox txtDescuento;
        private TextBox txtTotalPago;
    }
}