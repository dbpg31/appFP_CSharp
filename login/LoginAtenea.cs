using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_CSharp.login
{
    public partial class LoginAtenea : Form
    {
        public LoginAtenea()
        {
            InitializeComponent();
        }

        private void LoginMaestro_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
             if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                e.Handled = true;
                return;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void Ocultar_Click(object sender, EventArgs e)
        {
            Mostar.BringToFront();
            txtPassword.PasswordChar = '*';

        }

        private void Mostar_Click(object sender, EventArgs e)
        {
            Ocultar.BringToFront();
            txtPassword.PasswordChar = '\0';

        }
    }
}
