using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_CSharp.secuenciales
{
    public partial class _10 : Form
    {
        public _10()
        {
            InitializeComponent();
        }

        private void _10_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            int cifra4 = numero % 10;
            int cifra3 = ((numero % 100) / 10);
            int cifra2 = ((numero % 1000) / 100);
            int cifra1 = ((numero - (numero % 1000)) / 1000);
            String numeroreves = (cifra4 + "") + (cifra3 + "") + (cifra2 + "") + (cifra1 + "");

            txtNumeroReves.Text = numeroreves;
        }
    }
}
