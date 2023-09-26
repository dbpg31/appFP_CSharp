namespace appFP_CSharp.secuenciales
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
            lblJuan = new Label();
            btnCalcular = new Button();
            txtJuan = new TextBox();
            lblRosa = new Label();
            lblDaniel = new Label();
            lblInvercion = new Label();
            txtRosa = new TextBox();
            txtDaniel = new TextBox();
            txtInvercion = new TextBox();
            SuspendLayout();
            // 
            // lblJuan
            // 
            lblJuan.AutoSize = true;
            lblJuan.Location = new Point(65, 42);
            lblJuan.Name = "lblJuan";
            lblJuan.Size = new Size(46, 15);
            lblJuan.TabIndex = 0;
            lblJuan.Text = "Juan : $";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(127, 283);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtJuan
            // 
            txtJuan.Location = new Point(183, 34);
            txtJuan.Name = "txtJuan";
            txtJuan.Size = new Size(100, 23);
            txtJuan.TabIndex = 2;
            // 
            // lblRosa
            // 
            lblRosa.AutoSize = true;
            lblRosa.Location = new Point(65, 77);
            lblRosa.Name = "lblRosa";
            lblRosa.Size = new Size(47, 15);
            lblRosa.TabIndex = 3;
            lblRosa.Text = "Rosa : $";
            // 
            // lblDaniel
            // 
            lblDaniel.AutoSize = true;
            lblDaniel.Location = new Point(65, 117);
            lblDaniel.Name = "lblDaniel";
            lblDaniel.Size = new Size(60, 15);
            lblDaniel.TabIndex = 4;
            lblDaniel.Text = "Daniel : S/";
            // 
            // lblInvercion
            // 
            lblInvercion.AutoSize = true;
            lblInvercion.Location = new Point(65, 164);
            lblInvercion.Name = "lblInvercion";
            lblInvercion.Size = new Size(71, 15);
            lblInvercion.TabIndex = 5;
            lblInvercion.Text = "Inverción : $";
            // 
            // txtRosa
            // 
            txtRosa.Location = new Point(183, 69);
            txtRosa.Name = "txtRosa";
            txtRosa.Size = new Size(100, 23);
            txtRosa.TabIndex = 6;
            // 
            // txtDaniel
            // 
            txtDaniel.Location = new Point(183, 109);
            txtDaniel.Name = "txtDaniel";
            txtDaniel.Size = new Size(100, 23);
            txtDaniel.TabIndex = 7;
            // 
            // txtInvercion
            // 
            txtInvercion.Location = new Point(183, 156);
            txtInvercion.Name = "txtInvercion";
            txtInvercion.ReadOnly = true;
            txtInvercion.Size = new Size(100, 23);
            txtInvercion.TabIndex = 8;
            // 
            // _15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 365);
            Controls.Add(txtInvercion);
            Controls.Add(txtDaniel);
            Controls.Add(txtRosa);
            Controls.Add(lblInvercion);
            Controls.Add(lblDaniel);
            Controls.Add(lblRosa);
            Controls.Add(txtJuan);
            Controls.Add(btnCalcular);
            Controls.Add(lblJuan);
            Name = "_15";
            Text = "_15";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJuan;
        private Button btnCalcular;
        private TextBox txtJuan;
        private Label lblRosa;
        private Label lblDaniel;
        private Label lblInvercion;
        private TextBox txtRosa;
        private TextBox txtDaniel;
        private TextBox txtInvercion;
    }
}