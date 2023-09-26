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
    public partial class _16 : Form
    {
        public _16()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int sueldo = int.Parse(txtSueldo.Text);
            int horas = int.Parse(txtHoras.Text);
            double sueldobasico = sueldo * horas;
            double sueldobruto = sueldobasico * (1 + 0.20);
            double sueldoneto = sueldobruto * (1 - 0.10);

            txtSueldoBasico.Text = (sueldobasico.ToString("##.00"));
            txtSueldoBruto.Text = (sueldobruto.ToString("##.00"));
            txtSueldoNeto.Text = (sueldoneto.ToString("##.00"));
        }
    }
}
