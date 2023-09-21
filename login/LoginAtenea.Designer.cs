namespace appFP_CSharp.login
{
    partial class LoginAtenea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAtenea));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Ocultar = new System.Windows.Forms.PictureBox();
            this.Mostar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-5, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 55);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(370, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(73, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 49);
            this.panel2.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(80, 97);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(80, 153);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password : ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(198, 89);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ShortcutsEnabled = false;
            this.txtUsuario.Size = new System.Drawing.Size(100, 23);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(198, 145);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ShortcutsEnabled = false;
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(68, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(223, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Ocultar
            // 
            this.Ocultar.Image = global::appFP_CSharp.Properties.Resources.oculto;
            this.Ocultar.Location = new System.Drawing.Point(304, 145);
            this.Ocultar.Name = "Ocultar";
            this.Ocultar.Size = new System.Drawing.Size(33, 24);
            this.Ocultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ocultar.TabIndex = 7;
            this.Ocultar.TabStop = false;
            this.Ocultar.Click += new System.EventHandler(this.Ocultar_Click);
            // 
            // Mostar
            // 
            this.Mostar.Image = global::appFP_CSharp.Properties.Resources.oculto;
            this.Mostar.Location = new System.Drawing.Point(304, 145);
            this.Mostar.Name = "Mostar";
            this.Mostar.Size = new System.Drawing.Size(33, 24);
            this.Mostar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mostar.TabIndex = 8;
            this.Mostar.TabStop = false;
            this.Mostar.Click += new System.EventHandler(this.Mostar_Click);
            // 
            // LoginAtenea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 317);
            this.Controls.Add(this.Mostar);
            this.Controls.Add(this.Ocultar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginAtenea";
            this.Text = "LoginMaestro";
            this.Load += new System.EventHandler(this.LoginMaestro_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblUsuario;
        private Label lblPassword;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button button1;
        private Button button2;
        private PictureBox Ocultar;
        private PictureBox Mostar;
    }
}