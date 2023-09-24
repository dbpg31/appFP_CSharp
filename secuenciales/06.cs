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
    public partial class _06 : Form
    {
        public _06()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int radio = int.Parse(txtRadio.Text);
            int altura = int.Parse(txtAltura.Text);
            double AreaTotal = 2 * (Math.PI) * radio * altura;
            double volumen = (Math.PI) * (Math.ScaleB(radio, 2)) * altura;

            txtAreaTotal.Text = AreaTotal.ToString("##.00");
            txtVolumen.Text = volumen.ToString("##.00");

        }
    }
}
