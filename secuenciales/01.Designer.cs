namespace appFP_CSharp.secuenciales
{
    partial class c1
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
            this.lblVarones = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPVarones = new System.Windows.Forms.Label();
            this.lblPMujeres = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtVarones = new System.Windows.Forms.TextBox();
            this.txtMujeres = new System.Windows.Forms.TextBox();
            this.lblMujeres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVarones
            // 
            this.lblVarones.AccessibleName = "";
            this.lblVarones.AutoSize = true;
            this.lblVarones.Location = new System.Drawing.Point(28, 32);
            this.lblVarones.Name = "lblVarones";
            this.lblVarones.Size = new System.Drawing.Size(54, 15);
            this.lblVarones.TabIndex = 0;
            this.lblVarones.Text = "varones :";
            this.lblVarones.Click += new System.EventHandler(this.lblVarones_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 2;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPVarones
            // 
            this.lblPVarones.AutoSize = true;
            this.lblPVarones.Location = new System.Drawing.Point(234, 32);
            this.lblPVarones.Name = "lblPVarones";
            this.lblPVarones.Size = new System.Drawing.Size(17, 15);
            this.lblPVarones.TabIndex = 0;
            this.lblPVarones.Text = "%";
            this.lblPVarones.Click += new System.EventHandler(this.lblPVarones_Click);
            // 
            // lblPMujeres
            // 
            this.lblPMujeres.AutoSize = true;
            this.lblPMujeres.Location = new System.Drawing.Point(234, 67);
            this.lblPMujeres.Name = "lblPMujeres";
            this.lblPMujeres.Size = new System.Drawing.Size(17, 15);
            this.lblPMujeres.TabIndex = 0;
            this.lblPMujeres.Text = "%";
            this.lblPMujeres.Click += new System.EventHandler(this.lblPMujeres_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(113, 140);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "c&alcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // txtVarones
            // 
            this.txtVarones.AccessibleName = "";
            this.txtVarones.Location = new System.Drawing.Point(113, 24);
            this.txtVarones.Name = "txtVarones";
            this.txtVarones.Size = new System.Drawing.Size(100, 23);
            this.txtVarones.TabIndex = 1;
            this.txtVarones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVarones.TextChanged += new System.EventHandler(this.txtVarones_TextChanged);
            // 
            // txtMujeres
            // 
            this.txtMujeres.Location = new System.Drawing.Point(113, 59);
            this.txtMujeres.Name = "txtMujeres";
            this.txtMujeres.Size = new System.Drawing.Size(100, 23);
            this.txtMujeres.TabIndex = 2;
            this.txtMujeres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMujeres.TextChanged += new System.EventHandler(this.txtMujeres_TextChanged);
            // 
            // lblMujeres
            // 
            this.lblMujeres.AccessibleName = "";
            this.lblMujeres.AutoSize = true;
            this.lblMujeres.Location = new System.Drawing.Point(28, 67);
            this.lblMujeres.Name = "lblMujeres";
            this.lblMujeres.Size = new System.Drawing.Size(55, 15);
            this.lblMujeres.TabIndex = 0;
            this.lblMujeres.Text = "mujeres :";
            this.lblMujeres.Click += new System.EventHandler(this.lblMujeres_Click);
            // 
            // c1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 236);
            this.Controls.Add(this.lblMujeres);
            this.Controls.Add(this.txtMujeres);
            this.Controls.Add(this.txtVarones);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblPMujeres);
            this.Controls.Add(this.lblPVarones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVarones);
            this.Name = "c1";
            this.Text = "c1";
            this.Load += new System.EventHandler(this.c1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblVarones;
        private Label label3;
        private Label lblPVarones;
        private Label lblPMujeres;
        private Button btnCalcular;
        private TextBox txtVarones;
        private TextBox txtMujeres;
        private Label lblMujeres;
    }
}