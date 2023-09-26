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
    public partial class _08 : Form
    {
        public _08()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int examen1 = int.Parse(txtExamen1.Text);
            int examen2 = int.Parse(txtExamen2.Text);
            int examen3 = int.Parse(txtExamen3.Text);


            double aumento1 = 0;
            if (examen1 >= 13) aumento1 = 5;

            double aumento2 = 0;
            if (examen2 >= 13) aumento2 = 5;

            double aumento3 = 0;
            if (examen3 >= 13) aumento3 = 5;

            double total = 20 + (aumento1 + aumento2 + aumento3);

            txtTotal.Text = (total.ToString("##.00"));
        }
    }
}
