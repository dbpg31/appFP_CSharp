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
    public partial class _15 : Form
    {
        public _15()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int venta = int.Parse(txtVenta.Text);
            int sueldobase = 250;

            double comision = 0;
            double sueldo = 0;
            if (venta <= 5000) { comision = 0.05; sueldo = sueldobase + (venta * 0.05); }
            else if ((venta > 5000) && (venta <= 10000)) { comision = 0.08; sueldo = sueldobase + (venta * 0.08); }
            else if ((venta > 10000) && (venta <= 20000)) { comision = 0.10; sueldo = sueldobase + (venta * 0.10); }
            else if (venta > 20000) { comision = 0.15; sueldo = sueldobase + (venta * 0.15); }

            double descuento = 0;
            if (sueldo > 3500) descuento = sueldo * 0.15;
            else descuento = sueldo * 0.08;

            txtSueldoBruto.Text = (sueldo.ToString("##.00"));
            txtComision.Text = ((comision * venta).ToString("##.00"));
            txtDescuento.Text = ((descuento).ToString("##.00"));
            txtSueldoNeto.Text = ((sueldo - descuento).ToString("##.00"));
        }
    }
}
