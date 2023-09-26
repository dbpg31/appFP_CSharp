using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_CSharp.condicionales
{
    public partial class _07 : Form
    {
        public _07()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtNumero1.Text);
            int numero2 = int.Parse(txtNumero2.Text);
            int numero3 = int.Parse(txtNumero3.Text);

            int medio = 0;

            if ((numero1 > numero2) && (numero1 < numero3)) medio = numero1;
            else if ((numero1 < numero2) && (numero1 > numero3)) medio = numero1;
            else if ((numero2 > numero1) && (numero2 < numero3)) medio = numero2;
            else if ((numero2 < numero1) && (numero2 > numero3)) medio = numero2;
            else if ((numero3 > numero2) && (numero3 < numero1)) medio = numero3;
            else if ((numero3 < numero2) && (numero3 > numero1)) medio = numero3;

            txtMedio.Text = (medio.ToString("##.00"));
        }
    }
}
