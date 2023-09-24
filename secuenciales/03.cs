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
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int kilometros = int.Parse(txtKilometros.Text);
            int pies = int.Parse(txtPies.Text);
            int millas = int.Parse(txtMillas.Text);
            double metros = (kilometros * 1000) + (millas * 1609) + (pies * 1 / 3.2808);
            double yardas = metros * 1.0936;

            txtMetros.Text = metros.ToString("##.00");
            txtYardas.Text = yardas.ToString("##.00");
        }
    }
}
