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
    public partial class _05 : Form
    {
        public _05()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            int cifra4 = numero % 10;
            int cifra3 = ((numero % 100) / 10);
            int cifra2 = ((numero % 1000) / 100);
            int cifra1 = ((numero - (numero % 1000)) / 1000);

            int menor = 0;

            if ((cifra4 < cifra1) && (cifra4 < cifra2) && (cifra4 < cifra3)) menor = cifra4;
            else if ((cifra3 < cifra1) && (cifra3 < cifra2) && (cifra3 < cifra4)) menor = cifra3;
            else if ((cifra2 < cifra1) && (cifra2 < cifra3) && (cifra2 < cifra3)) menor = cifra2;
            else if ((cifra1 < cifra2) && (cifra1 < cifra3) && (cifra1 < cifra4)) menor = cifra1;

            int mayor = 0;

            if ((cifra4 > cifra1) && (cifra4 > cifra2) && (cifra4 > cifra3)) mayor = cifra4;
            else if ((cifra3 > cifra1) && (cifra3 > cifra2) && (cifra3 > cifra4)) mayor = cifra3;
            else if ((cifra2 > cifra1) && (cifra2 > cifra3) && (cifra2 > cifra3)) mayor = cifra2;
            else if ((cifra1 > cifra2) && (cifra1 > cifra3) && (cifra1 > cifra4)) mayor = cifra1;

            String nuevonumero = ("" + mayor) + ("" + menor);

            txtNuevoNumero.Text = (nuevonumero);
        }
    }
}
