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
    public partial class _07 : Form
    {
        public _07()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Base = int.Parse(txtBase.Text);
            int altura = int.Parse(txtAltura.Text);
            double Area = Base * altura;
            double perimetro = 2 * (Base + altura);

            txtArea.Text = Area.ToString("##.00");
            txtPerimetro.Text = perimetro.ToString("##.00");

        }
    }
}
