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
    public partial class _19 : Form
    {
        public _19()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int ventas = int.Parse(txtVentas.Text);
            double sueldo = 500;
            double sueldobruto = sueldo + (ventas * 0.09);
            double sueldoneto = sueldobruto + (1 - 0.11);
            double descuento = sueldobruto * 0.11;

            txtSueldoBruto.Text = (sueldobruto.ToString("##.00"));
            txtSueldoBase.Text = (descuento.ToString("##.00"));
            txtSueldoNeto.Text = (sueldoneto.ToString("##.00"));
        }
    }
}
