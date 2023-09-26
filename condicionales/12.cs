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
    public partial class _12 : Form
    {
        public _12()
        {
            InitializeComponent();
        }

        private void lblVarones_Click(object sender, EventArgs e)
        {
            string[] aDias = { "lunes", "Martes", "Miercoles", "Jueves", "viernes" };
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            if (numero == 1) txtDia.Text = ("Lunes");
            else if (numero == 2) txtDia.Text = ("Martes");
            else if (numero == 3) txtDia.Text = ("Miercoles");
            else if (numero == 4) txtDia.Text = ("Jueves");
            else if (numero == 5) txtDia.Text = ("Viernes");
            else if (numero == 6) txtDia.Text = ("Sabado");
            else if (numero == 7) txtDia.Text = ("Domingo");
        }
    }
}
