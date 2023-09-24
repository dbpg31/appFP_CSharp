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
    public partial class _09 : Form
    {
        public _09()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            double cifra4 = numero % 10;
            double cifra3 = ((numero % 100) / 10);
            double cifra2 = ((numero % 1000) / 100);
            double cifra1 = ((numero - (numero % 1000)) / 1000);
            double suma = cifra1 + cifra2 + cifra3 + cifra4;
            txtSuma.Text = suma.ToString();
        }
    }
}
