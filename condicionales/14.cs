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
    public partial class _14 : Form
    {
        public _14()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            int venta = int.Parse(txtVenta.Text);

            double descuento = 0;
            if ((numero >= 100) && ((numero % 2) == 0)) descuento = venta * 0.15;
            else descuento = venta * 0.05;

            txtTarjeta.Text = (numero.ToString("##.00"));
            txtDescuento.Text = (descuento.ToString("##.00"));
            txtTotalPago.Text = ((venta - descuento).ToString("##.00"));
        }
    }
}
