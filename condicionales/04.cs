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
    public partial class _04 : Form
    {
        public _04()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int nota1 = int.Parse(txtNota1.Text);
            int nota2 = int.Parse(txtNota2.Text);
            int nota3 = int.Parse(txtNota3.Text);

            if (nota3 >= 10) nota3 = nota3 + 2;
            double notafinal = (nota1 + nota2 + nota3) / 3;

            txtNotaFinal.Text = (notafinal.ToString("##.00"));
        }
    }
}
