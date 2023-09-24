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
    public partial class _08 : Form
    {
        public _08()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int radio = int.Parse(txtRadio.Text);
            int altura = int.Parse(txtAltura.Text);
            double areabase = (Math.PI) * Math.ScaleB(radio, 2);
            double arealateral = 2 * (Math.PI) * radio * altura;
            double areatotal = 2 * areabase * arealateral;

            txtAreaBase.Text = areabase.ToString("##.00");
            txtAreaLateral.Text = arealateral.ToString("##.00");
            txtAreaTotal.Text = areatotal.ToString("##.00");
        }
    }
}
