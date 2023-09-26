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
    public partial class _18 : Form
    {
        public _18()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int unidades = int.Parse(txtUnidades.Text);
            int preciobase = int.Parse(txtPrecioBase.Text);
            double venta = unidades * preciobase;
            double venta1 = unidades * (1 - 0.15);
            double ventafinal = venta1 * (1 - 0.15);
            double descuento1 = venta * 0.15;
            double descuento2 = venta1 * 0.15;
            double descuentototal = descuento1 + descuento2;

            txtVenta.Text = (venta.ToString("##.00"));
            txtDescuentoTotal.Text = (descuentototal.ToString("##.00"));
            txtVentaFinal.Text = (ventafinal.ToString("##.00"));
        }
    }
}
