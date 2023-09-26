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
    public partial class _13 : Form
    {
        public _13()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            int cifra3 = numero % 10;
            int cifra2 = ((numero % 100) / 10);
            int cifra1 = ((numero % 1000) / 100);

            if ((cifra3 == cifra2 - 1 && cifra2 == cifra1 - 1)) txtTipo.Text = ("Descendente");
            else if ((cifra3 == cifra2 + 1 && cifra2 == cifra1 + 1)) txtTipo.Text = ("Ascendente");
            else txtTipo.Text = ("no consecutivo");
        }
    }
}
