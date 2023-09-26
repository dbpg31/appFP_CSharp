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
    public partial class _06 : Form
    {
        public _06()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int edad1 = int.Parse(txtEdad1.Text);
            int edad2 = int.Parse(txtEdad2.Text);
            int edad3 = int.Parse(txtEdad3.Text);

            int mayor = 0;

            if ((edad1 > edad3) && (edad1 > edad2)) mayor = edad1;
            else if ((edad2 > edad1) && (edad2 > edad3)) mayor = edad2;
            else if ((edad3 > edad1) && (edad3 > edad2)) mayor = edad3;
            int menor = 0;
            if ((edad1 < edad3) && (edad1 < edad2)) menor = edad1;
            else if ((edad2 < edad1) && (edad2 < edad3)) menor = edad2;
            else if ((edad3 < edad1) && (edad3 < edad2)) menor = edad3;

            txtEdadMayor.Text = (mayor.ToString("##.00"));
            txtEdadMenor.Text = (menor.ToString("##.00"));
        }
    }
}
