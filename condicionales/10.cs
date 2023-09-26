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
    public partial class _10 : Form
    {
        public _10()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int nota1 = int.Parse(txtNota1.Text);
            int nota2 = int.Parse(txtNota2.Text);
            int nota3 = int.Parse(txtNota3.Text);
            int nota4 = int.Parse(txtNota4.Text);
            int nota5 = int.Parse(txtNota5.Text);

            double mayor = 0;
            if ((nota1 > nota5) && (nota1 > nota4) && (nota1 > nota3) && (nota1 > nota2)) mayor = nota1;
            else if ((nota2 > nota5) && (nota2 > nota4) && (nota2 > nota3) && (nota2 > nota1)) mayor = nota2;
            else if ((nota3 > nota5) && (nota3 > nota4) && (nota3 > nota2) && (nota3 > nota1)) mayor = nota3;
            else if ((nota4 > nota5) && (nota4 > nota3) && (nota4 > nota2) && (nota4 > nota1)) mayor = nota4;
            else if ((nota5 > nota4) && (nota5 > nota3) && (nota5 > nota2) && (nota5 > nota1)) mayor = nota5;

            double menor = 0;
            if ((nota1 < nota5) && (nota1 < nota4) && (nota1 < nota3) && (nota1 < nota2)) menor = nota1;
            else if ((nota2 < nota5) && (nota2 < nota4) && (nota2 < nota3) && (nota2 < nota1)) menor = nota2;
            else if ((nota3 < nota5) && (nota3 < nota4) && (nota3 < nota2) && (nota3 < nota1)) menor = nota3;
            else if ((nota4 < nota5) && (nota4 < nota3) && (nota4 < nota2) && (nota4 < nota1)) menor = nota4;
            else if ((nota5 < nota4) && (nota5 < nota3) && (nota5 < nota2) && (nota5 < nota1)) menor = nota5;

            double promedio = ((nota1 + nota2 + nota3 + nota4 + nota5) - (mayor + menor)) / 3;
                        
            txtMayorNota.Text = (mayor.ToString("##.00"));
            txtMenorNota.Text = (menor.ToString("##.00"));
            txtPromedio.Text = (promedio.ToString("##.00"));
        }
    }
}
