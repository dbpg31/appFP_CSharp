namespace appFP_CSharp.secuenciales
{
    partial class _16
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
            lblSueldo = new Label();
            btnCalcular = new Button();
            txtSueldo = new TextBox();
            lblHoras = new Label();
            lblSueldoBasico = new Label();
            lblSueldoBruto = new Label();
            lblSueldoNeto = new Label();
            txtHoras = new TextBox();
            txtSueldoBasico = new TextBox();
            txtSueldoBruto = new TextBox();
            txtSueldoNeto = new TextBox();
            SuspendLayout();
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(48, 36);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(49, 15);
            lblSueldo.TabIndex = 0;
            lblSueldo.Text = "Sueldo :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(106, 282);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(145, 36);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(100, 23);
            txtSueldo.TabIndex = 2;
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Location = new Point(48, 79);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(44, 15);
            lblHoras.TabIndex = 3;
            lblHoras.Text = "Horas :";
            // 
            // lblSueldoBasico
            // 
            lblSueldoBasico.AutoSize = true;
            lblSueldoBasico.Location = new Point(48, 122);
            lblSueldoBasico.Name = "lblSueldoBasico";
            lblSueldoBasico.Size = new Size(86, 15);
            lblSueldoBasico.TabIndex = 4;
            lblSueldoBasico.Text = "Sueldo Básico :";
            // 
            // lblSueldoBruto
            // 
            lblSueldoBruto.AutoSize = true;
            lblSueldoBruto.Location = new Point(48, 165);
            lblSueldoBruto.Name = "lblSueldoBruto";
            lblSueldoBruto.Size = new Size(81, 15);
            lblSueldoBruto.TabIndex = 5;
            lblSueldoBruto.Text = "Sueldo Bruto :";
            // 
            // lblSueldoNeto
            // 
            lblSueldoNeto.AutoSize = true;
            lblSueldoNeto.Location = new Point(48, 209);
            lblSueldoNeto.Name = "lblSueldoNeto";
            lblSueldoNeto.Size = new Size(78, 15);
            lblSueldoNeto.TabIndex = 6;
            lblSueldoNeto.Text = "Sueldo Neto :";
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(145, 71);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(100, 23);
            txtHoras.TabIndex = 7;
            // 
            // txtSueldoBasico
            // 
            txtSueldoBasico.Location = new Point(145, 114);
            txtSueldoBasico.Name = "txtSueldoBasico";
            txtSueldoBasico.ReadOnly = true;
            txtSueldoBasico.Size = new Size(100, 23);
            txtSueldoBasico.TabIndex = 8;
            // 
            // txtSueldoBruto
            // 
            txtSueldoBruto.Location = new Point(145, 157);
            txtSueldoBruto.Name = "txtSueldoBruto";
            txtSueldoBruto.ReadOnly = true;
            txtSueldoBruto.Size = new Size(100, 23);
            txtSueldoBruto.TabIndex = 9;
            // 
            // txtSueldoNeto
            // 
            txtSueldoNeto.Location = new Point(145, 201);
            txtSueldoNeto.Name = "txtSueldoNeto";
            txtSueldoNeto.ReadOnly = true;
            txtSueldoNeto.Size = new Size(100, 23);
            txtSueldoNeto.TabIndex = 10;
            // 
            // _16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 371);
            Controls.Add(txtSueldoNeto);
            Controls.Add(txtSueldoBruto);
            Controls.Add(txtSueldoBasico);
            Controls.Add(txtHoras);
            Controls.Add(lblSueldoNeto);
            Controls.Add(lblSueldoBruto);
            Controls.Add(lblSueldoBasico);
            Controls.Add(lblHoras);
            Controls.Add(txtSueldo);
            Controls.Add(btnCalcular);
            Controls.Add(lblSueldo);
            Name = "_16";
            Text = "_16";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSueldo;
        private Button btnCalcular;
        private TextBox txtSueldo;
        private Label lblHoras;
        private Label lblSueldoBasico;
        private Label lblSueldoBruto;
        private Label lblSueldoNeto;
        private TextBox txtHoras;
        private TextBox txtSueldoBasico;
        private TextBox txtSueldoBruto;
        private TextBox txtSueldoNeto;
    }
}