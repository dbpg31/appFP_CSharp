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
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void lblTotalPago_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int unidades = int.Parse(txtUnidades.Text);
            double importe = unidades * 20;
            double descuento = 0.14 * importe;
            if (importe <= 500) descuento = 0.12 * importe;
            else if (importe > 700) descuento = 0.16 * importe;

            double caramelos = 10;
            if (unidades <= 50) caramelos = 5;
            if (unidades > 100) caramelos = 15;

            txtCompra.Text = (importe.ToString("##.00"));
            txtDescuento.Text = (descuento.ToString("##.00"));
            txtTotalPago.Text = ((importe - descuento).ToString("##.00"));
            txtCaramelos.Text = (caramelos.ToString("##.00"));
        }
    }
}
