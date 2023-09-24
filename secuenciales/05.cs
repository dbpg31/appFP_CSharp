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
    public partial class _05 : Form
    {
        public _05()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int gigabytes = int.Parse(txtGigabytes.Text);

            double megabytes = gigabytes * 1024;
            double kilobytes = megabytes * 1024;
            double bytes = kilobytes * 1024;

            txtMegabytes.Text = megabytes.ToString("##.00");
            txtKilobytes.Text = kilobytes.ToString("##.00");
            txtBytes.Text = bytes.ToString("##.00");
        }

        private void txtMegabytes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
