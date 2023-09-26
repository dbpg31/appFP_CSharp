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
    public partial class _09 : Form
    {
        public _09()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            int unidades = int.Parse(txtUnidades.Text);

            double precio = 0;
            if (codigo == 101) precio = 17;
            else if (codigo == 102) precio = 25;
            else if (codigo == 103) precio = 16;
            else if (codigo == 104) precio = 27;

            double venta = unidades * precio;

            double descuento = 0;
            if (unidades <= 10) descuento = venta * 0.05;
            else if ((unidades > 10) && (unidades <= 20)) descuento = venta * 0.08;
            else if ((unidades > 20) && (unidades <= 30)) descuento = venta * 0.10;
            else if (unidades > 30) descuento = venta * 0.13;


            txtCompra.Text = (venta.ToString("##.00"));
            txtDescuento.Text = (descuento.ToString("##.00"));
            txtTotalPago.Text = ((venta - descuento).ToString("##.00"));
        }
    }
}
