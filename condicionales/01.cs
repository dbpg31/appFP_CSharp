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
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int unidades = int.Parse(txtUnidades.Text);
            double precio = 0;
            if (unidades <= 25) precio = 27;
            else if ((unidades > 25) && (unidades <= 50)) precio = 25;
            else if (unidades > 50) precio = 23;

            double compra = unidades * precio;
            double descuento = 0.05 * compra;
            if (unidades > 50) descuento = 0.15 * compra;

            txtCompra.Text = (compra.ToString("##.00"));
            txtDescuento.Text = (descuento.ToString("##.00"));
            txtTotalPago.Text = (compra - descuento).ToString("##.00");

        }
    }
}
