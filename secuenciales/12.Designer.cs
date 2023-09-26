namespace appFP_CSharp.secuenciales
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
            lblCuadratica = new Label();
            txtCuadratica = new TextBox();
            btnCalcular = new Button();
            lblLineal = new Label();
            lblIndependiente = new Label();
            lblResultado1 = new Label();
            lblResultado2 = new Label();
            txtLineal = new TextBox();
            txtIndependiente = new TextBox();
            txtRespuesta1 = new TextBox();
            txtRespuesta2 = new TextBox();
            SuspendLayout();
            // 
            // lblCuadratica
            // 
            lblCuadratica.AutoSize = true;
            lblCuadratica.Location = new Point(39, 53);
            lblCuadratica.Name = "lblCuadratica";
            lblCuadratica.Size = new Size(114, 15);
            lblCuadratica.TabIndex = 0;
            lblCuadratica.Text = "Variable Cuadratica :";
            // 
            // txtCuadratica
            // 
            txtCuadratica.Location = new Point(188, 45);
            txtCuadratica.Name = "txtCuadratica";
            txtCuadratica.Size = new Size(100, 23);
            txtCuadratica.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(104, 288);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblLineal
            // 
            lblLineal.AutoSize = true;
            lblLineal.Location = new Point(39, 90);
            lblLineal.Name = "lblLineal";
            lblLineal.Size = new Size(88, 15);
            lblLineal.TabIndex = 3;
            lblLineal.Text = "Variable Lineal :";
            // 
            // lblIndependiente
            // 
            lblIndependiente.AutoSize = true;
            lblIndependiente.Location = new Point(39, 129);
            lblIndependiente.Name = "lblIndependiente";
            lblIndependiente.Size = new Size(133, 15);
            lblIndependiente.TabIndex = 4;
            lblIndependiente.Text = "Variable Independiente :";
            // 
            // lblResultado1
            // 
            lblResultado1.AutoSize = true;
            lblResultado1.Location = new Point(39, 167);
            lblResultado1.Name = "lblResultado1";
            lblResultado1.Size = new Size(74, 15);
            lblResultado1.TabIndex = 5;
            lblResultado1.Text = "Resultado 1 :";
            // 
            // lblResultado2
            // 
            lblResultado2.AutoSize = true;
            lblResultado2.Location = new Point(39, 204);
            lblResultado2.Name = "lblResultado2";
            lblResultado2.Size = new Size(74, 15);
            lblResultado2.TabIndex = 6;
            lblResultado2.Text = "Resultado 2 :";
            // 
            // txtLineal
            // 
            txtLineal.Location = new Point(188, 82);
            txtLineal.Name = "txtLineal";
            txtLineal.Size = new Size(100, 23);
            txtLineal.TabIndex = 7;
            // 
            // txtIndependiente
            // 
            txtIndependiente.Location = new Point(188, 121);
            txtIndependiente.Name = "txtIndependiente";
            txtIndependiente.Size = new Size(100, 23);
            txtIndependiente.TabIndex = 8;
            // 
            // txtRespuesta1
            // 
            txtRespuesta1.Location = new Point(188, 159);
            txtRespuesta1.Name = "txtRespuesta1";
            txtRespuesta1.ReadOnly = true;
            txtRespuesta1.Size = new Size(100, 23);
            txtRespuesta1.TabIndex = 9;
            // 
            // txtRespuesta2
            // 
            txtRespuesta2.Location = new Point(188, 196);
            txtRespuesta2.Name = "txtRespuesta2";
            txtRespuesta2.ReadOnly = true;
            txtRespuesta2.Size = new Size(100, 23);
            txtRespuesta2.TabIndex = 10;
            // 
            // _12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 350);
            Controls.Add(txtRespuesta2);
            Controls.Add(txtRespuesta1);
            Controls.Add(txtIndependiente);
            Controls.Add(txtLineal);
            Controls.Add(lblResultado2);
            Controls.Add(lblResultado1);
            Controls.Add(lblIndependiente);
            Controls.Add(lblLineal);
            Controls.Add(btnCalcular);
            Controls.Add(txtCuadratica);
            Controls.Add(lblCuadratica);
            Name = "_12";
            Text = "_12";
            Load += _12_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuadratica;
        private TextBox txtCuadratica;
        private Button btnCalcular;
        private Label lblLineal;
        private Label lblIndependiente;
        private Label lblResultado1;
        private Label lblResultado2;
        private TextBox txtLineal;
        private TextBox txtIndependiente;
        private TextBox txtRespuesta1;
        private TextBox txtRespuesta2;
    }
}