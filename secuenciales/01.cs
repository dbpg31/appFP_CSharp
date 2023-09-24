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
    public partial class c1 : Form
    {
        public c1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int varones = int.Parse(txtVarones.Text);
            int mujeres = int.Parse(txtMujeres.Text);

            int total = varones + mujeres;
            double PVarones = varones * 100.0 / total;
            double PMujeres = mujeres * 100.0 / total;

            lblPVarones.Text = PVarones.ToString("##.00 %");
            lblPMujeres.Text = PVarones.ToString("##.00 %");

        }

        private void c1_Load(object sender, EventArgs e)
        {
            int varones = int.Parse(txtVarones.Text);
            int mujeres = int.Parse(txtMujeres.Text);

            int total = varones + mujeres;
            double PVarones = varones * 100.0 / total;
            double PMujeres = mujeres * 100.0 / total;

            lblPVarones.Text = PVarones.ToString("##.00 %");
            lblPMujeres.Text = PVarones.ToString("##.00 %");
        }

        private void calcular_Click(object sender, EventArgs e)
        {

        }

        private void lblVarones_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblPVarones_Click(object sender, EventArgs e)
        {

        }

        private void lblPMujeres_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtVarones_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMujeres_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMujeres_Click(object sender, EventArgs e)
        {

        }
    }
}
