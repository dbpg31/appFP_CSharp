namespace appFP_CSharp.secuenciales
{
    partial class _17
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
            lblDonacion = new Label();
            txtDonacion = new TextBox();
            lblSalud = new Label();
            lblComedor = new Label();
            lblEscuela = new Label();
            txtSalud = new TextBox();
            txtComedor = new TextBox();
            txtEscuela = new TextBox();
            lblAsilo = new Label();
            txtAsilo = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(131, 345);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblDonacion
            // 
            lblDonacion.AutoSize = true;
            lblDonacion.Location = new Point(46, 48);
            lblDonacion.Name = "lblDonacion";
            lblDonacion.Size = new Size(64, 15);
            lblDonacion.TabIndex = 1;
            lblDonacion.Text = "Donacion :";
            // 
            // txtDonacion
            // 
            txtDonacion.Location = new Point(172, 40);
            txtDonacion.Name = "txtDonacion";
            txtDonacion.Size = new Size(100, 23);
            txtDonacion.TabIndex = 2;
            txtDonacion.TextChanged += textBox1_TextChanged;
            // 
            // lblSalud
            // 
            lblSalud.AutoSize = true;
            lblSalud.Location = new Point(46, 89);
            lblSalud.Name = "lblSalud";
            lblSalud.Size = new Size(97, 15);
            lblSalud.TabIndex = 3;
            lblSalud.Text = "Centro de Salud :";
            // 
            // lblComedor
            // 
            lblComedor.AutoSize = true;
            lblComedor.Location = new Point(46, 134);
            lblComedor.Name = "lblComedor";
            lblComedor.Size = new Size(103, 15);
            lblComedor.TabIndex = 4;
            lblComedor.Text = "Comedor Infantil :";
            // 
            // lblEscuela
            // 
            lblEscuela.AutoSize = true;
            lblEscuela.Location = new Point(46, 177);
            lblEscuela.Name = "lblEscuela";
            lblEscuela.Size = new Size(92, 15);
            lblEscuela.TabIndex = 5;
            lblEscuela.Text = "Escuela Infantil :";
            lblEscuela.Click += label4_Click;
            // 
            // txtSalud
            // 
            txtSalud.Location = new Point(172, 81);
            txtSalud.Name = "txtSalud";
            txtSalud.ReadOnly = true;
            txtSalud.Size = new Size(100, 23);
            txtSalud.TabIndex = 6;
            // 
            // txtComedor
            // 
            txtComedor.Location = new Point(172, 126);
            txtComedor.Name = "txtComedor";
            txtComedor.ReadOnly = true;
            txtComedor.Size = new Size(100, 23);
            txtComedor.TabIndex = 7;
            // 
            // txtEscuela
            // 
            txtEscuela.Location = new Point(172, 169);
            txtEscuela.Name = "txtEscuela";
            txtEscuela.ReadOnly = true;
            txtEscuela.Size = new Size(100, 23);
            txtEscuela.TabIndex = 8;
            txtEscuela.TextChanged += txtEscuela_TextChanged;
            // 
            // lblAsilo
            // 
            lblAsilo.AutoSize = true;
            lblAsilo.Location = new Point(46, 222);
            lblAsilo.Name = "lblAsilo";
            lblAsilo.Size = new Size(105, 15);
            lblAsilo.TabIndex = 9;
            lblAsilo.Text = "Asilo de ancianos :";
            // 
            // txtAsilo
            // 
            txtAsilo.Location = new Point(172, 214);
            txtAsilo.Name = "txtAsilo";
            txtAsilo.ReadOnly = true;
            txtAsilo.Size = new Size(100, 23);
            txtAsilo.TabIndex = 10;
            // 
            // _17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 450);
            Controls.Add(txtAsilo);
            Controls.Add(lblAsilo);
            Controls.Add(txtEscuela);
            Controls.Add(txtComedor);
            Controls.Add(txtSalud);
            Controls.Add(lblEscuela);
            Controls.Add(lblComedor);
            Controls.Add(lblSalud);
            Controls.Add(txtDonacion);
            Controls.Add(lblDonacion);
            Controls.Add(btnCalcular);
            Name = "_17";
            Text = "_17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblDonacion;
        private TextBox txtDonacion;
        private Label lblSalud;
        private Label lblComedor;
        private Label lblEscuela;
        private TextBox txtSalud;
        private TextBox txtComedor;
        private TextBox txtEscuela;
        private Label lblAsilo;
        private TextBox txtAsilo;
    }
}