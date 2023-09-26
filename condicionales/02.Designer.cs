namespace appFP_CSharp.condicionales
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
            btnCalcular = new Button();
            lblUnidades = new Label();
            txtUnidades = new TextBox();
            lblCompra = new Label();
            lblDescuento = new Label();
            lblTotalPago = new Label();
            lblCaramelos = new Label();
            txtCompra = new TextBox();
            txtDescuento = new TextBox();
            txtTotalPago = new TextBox();
            txtCaramelos = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(123, 290);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblUnidades
            // 
            lblUnidades.AutoSize = true;
            lblUnidades.Location = new Point(36, 48);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(62, 15);
            lblUnidades.TabIndex = 1;
            lblUnidades.Text = "Unidades :";
            // 
            // txtUnidades
            // 
            txtUnidades.Location = new Point(169, 40);
            txtUnidades.Name = "txtUnidades";
            txtUnidades.Size = new Size(100, 23);
            txtUnidades.TabIndex = 2;
            // 
            // lblCompra
            // 
            lblCompra.AutoSize = true;
            lblCompra.Location = new Point(36, 89);
            lblCompra.Name = "lblCompra";
            lblCompra.Size = new Size(56, 15);
            lblCompra.TabIndex = 3;
            lblCompra.Text = "Compra :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(36, 136);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 4;
            lblDescuento.Text = "Descuento :";
            // 
            // lblTotalPago
            // 
            lblTotalPago.AutoSize = true;
            lblTotalPago.Location = new Point(36, 188);
            lblTotalPago.Name = "lblTotalPago";
            lblTotalPago.Size = new Size(80, 15);
            lblTotalPago.TabIndex = 5;
            lblTotalPago.Text = "Total a Pagar :";
            lblTotalPago.Click += lblTotalPago_Click;
            // 
            // lblCaramelos
            // 
            lblCaramelos.AutoSize = true;
            lblCaramelos.Location = new Point(36, 235);
            lblCaramelos.Name = "lblCaramelos";
            lblCaramelos.Size = new Size(69, 15);
            lblCaramelos.TabIndex = 6;
            lblCaramelos.Text = "Caramelos :";
            // 
            // txtCompra
            // 
            txtCompra.Location = new Point(169, 81);
            txtCompra.Name = "txtCompra";
            txtCompra.ReadOnly = true;
            txtCompra.Size = new Size(100, 23);
            txtCompra.TabIndex = 7;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(169, 128);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 8;
            // 
            // txtTotalPago
            // 
            txtTotalPago.Location = new Point(169, 180);
            txtTotalPago.Name = "txtTotalPago";
            txtTotalPago.ReadOnly = true;
            txtTotalPago.Size = new Size(100, 23);
            txtTotalPago.TabIndex = 9;
            // 
            // txtCaramelos
            // 
            txtCaramelos.Location = new Point(169, 227);
            txtCaramelos.Name = "txtCaramelos";
            txtCaramelos.ReadOnly = true;
            txtCaramelos.Size = new Size(100, 23);
            txtCaramelos.TabIndex = 10;
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 378);
            Controls.Add(txtCaramelos);
            Controls.Add(txtTotalPago);
            Controls.Add(txtDescuento);
            Controls.Add(txtCompra);
            Controls.Add(lblCaramelos);
            Controls.Add(lblTotalPago);
            Controls.Add(lblDescuento);
            Controls.Add(lblCompra);
            Controls.Add(txtUnidades);
            Controls.Add(lblUnidades);
            Controls.Add(btnCalcular);
            Name = "_02";
            Text = "_02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblUnidades;
        private TextBox txtUnidades;
        private Label lblCompra;
        private Label lblDescuento;
        private Label lblTotalPago;
        private Label lblCaramelos;
        private TextBox txtCompra;
        private TextBox txtDescuento;
        private TextBox txtTotalPago;
        private TextBox txtCaramelos;
    }
}