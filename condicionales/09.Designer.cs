namespace appFP_CSharp.condicionales
{
    partial class _09
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
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblUnidades = new Label();
            lblCompra = new Label();
            lblDescuento = new Label();
            lblTotalPago = new Label();
            txtUnidades = new TextBox();
            txtCompra = new TextBox();
            txtDescuento = new TextBox();
            txtTotalPago = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(102, 263);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(38, 35);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(52, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Codigo :";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(162, 27);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 2;
            // 
            // lblUnidades
            // 
            lblUnidades.AutoSize = true;
            lblUnidades.Location = new Point(38, 71);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(62, 15);
            lblUnidades.TabIndex = 3;
            lblUnidades.Text = "Unidades :";
            // 
            // lblCompra
            // 
            lblCompra.AutoSize = true;
            lblCompra.Location = new Point(38, 114);
            lblCompra.Name = "lblCompra";
            lblCompra.Size = new Size(56, 15);
            lblCompra.TabIndex = 4;
            lblCompra.Text = "Compra :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(38, 158);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 5;
            lblDescuento.Text = "Descuento :";
            // 
            // lblTotalPago
            // 
            lblTotalPago.AutoSize = true;
            lblTotalPago.Location = new Point(38, 201);
            lblTotalPago.Name = "lblTotalPago";
            lblTotalPago.Size = new Size(80, 15);
            lblTotalPago.TabIndex = 6;
            lblTotalPago.Text = "Total a Pagar :";
            // 
            // txtUnidades
            // 
            txtUnidades.Location = new Point(162, 63);
            txtUnidades.Name = "txtUnidades";
            txtUnidades.Size = new Size(100, 23);
            txtUnidades.TabIndex = 7;
            // 
            // txtCompra
            // 
            txtCompra.Location = new Point(162, 106);
            txtCompra.Name = "txtCompra";
            txtCompra.ReadOnly = true;
            txtCompra.Size = new Size(100, 23);
            txtCompra.TabIndex = 8;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(162, 150);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 9;
            // 
            // txtTotalPago
            // 
            txtTotalPago.Location = new Point(162, 193);
            txtTotalPago.Name = "txtTotalPago";
            txtTotalPago.ReadOnly = true;
            txtTotalPago.Size = new Size(100, 23);
            txtTotalPago.TabIndex = 10;
            // 
            // _09
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 331);
            Controls.Add(txtTotalPago);
            Controls.Add(txtDescuento);
            Controls.Add(txtCompra);
            Controls.Add(txtUnidades);
            Controls.Add(lblTotalPago);
            Controls.Add(lblDescuento);
            Controls.Add(lblCompra);
            Controls.Add(lblUnidades);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(btnCalcular);
            Name = "_09";
            Text = "_09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblUnidades;
        private Label lblCompra;
        private Label lblDescuento;
        private Label lblTotalPago;
        private TextBox txtUnidades;
        private TextBox txtCompra;
        private TextBox txtDescuento;
        private TextBox txtTotalPago;
    }
}