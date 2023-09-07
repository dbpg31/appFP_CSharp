namespace appFP_CSharp.condicionales
{
    partial class _12
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
            this.lblDia = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AccessibleName = "";
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(26, 82);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(30, 15);
            this.lblDia.TabIndex = 4;
            this.lblDia.Text = "Dia :";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(111, 74);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 23);
            this.txtDia.TabIndex = 10;
            this.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumero
            // 
            this.txtNumero.AccessibleName = "";
            this.txtNumero.Location = new System.Drawing.Point(111, 39);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 9;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(111, 155);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "c&alcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 11;
            // 
            // lblNumero
            // 
            this.lblNumero.AccessibleName = "";
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(26, 47);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(57, 15);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Nùmero :";
            this.lblNumero.Click += new System.EventHandler(this.lblVarones_Click);
            // 
            // _12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumero);
            this.Name = "_12";
            this.Text = "_12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDia;
        private TextBox txtDia;
        private TextBox txtNumero;
        private Button btnCalcular;
        private Label label3;
        private Label lblNumero;
    }
}