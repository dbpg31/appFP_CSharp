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
    public partial class _11 : Form
    {
        public _11()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtNumero1.Text);
            int numero2 = int.Parse(txtNumero2.Text);
            int cifra3n1 = numero1 % 10;
            int cifra2n1 = ((numero1 % 100) / 10);
            int cifra1n1 = ((numero1 - (numero1 % 100)) / 100);
            int cifra3n2 = numero2 % 10;
            int cifra2n2 = ((numero2 % 100) / 10);
            int cifra1n2 = ((numero2 - (numero2 % 100)) / 100);


            String NuevoNumero1 = ("" + cifra3n1) + ("" + cifra2n1) + ("" + cifra1n1);
            String NuevoNumero2 = ("" + cifra3n2) + ("" + cifra2n2) + ("" + cifra1n2);
            txtNuevoNumero1.Text = (NuevoNumero1);
            txtNuevoNumero2.Text = (NuevoNumero2);
        }
    }
}
