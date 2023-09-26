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
    public partial class _12 : Form
    {
        public _12()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cuadratica = int.Parse(txtCuadratica.Text);
            int lineal = int.Parse(txtLineal.Text);
            int independiente = int.Parse(txtIndependiente.Text);
            double respuesta1 = (-lineal + Math.Sqrt(Math.Pow(lineal, 2) - (4 * cuadratica * independiente))) / (2 * cuadratica);
            double respuesta2 = (-lineal - Math.Sqrt(Math.Pow(lineal, 2) - (4 * cuadratica * independiente))) / (2 * cuadratica);

            txtRespuesta1.Text = (respuesta1.ToString("##.00"));
            txtRespuesta2.Text = (respuesta2.ToString("##.00"));
        }

        private void _12_Load(object sender, EventArgs e)
        {

        }
    }
}
