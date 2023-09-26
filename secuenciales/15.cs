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
    public partial class _15 : Form
    {
        public _15()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int juan = int.Parse(txtJuan.Text);
            int rosa = int.Parse(txtRosa.Text);
            int daniel = int.Parse(txtDaniel.Text);

            double invercion = juan + rosa + (daniel / 3);

            txtInvercion.Text = (invercion.ToString("##.00"));
        }
    }
}
