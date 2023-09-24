﻿using System;
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
    public partial class _04 : Form
    {
        public _04()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int pies = int.Parse(txtPies.Text);
            int pulgadas = int.Parse(txtPulgadas.Text);
            double metros = (pies * (1 / 3.2808)) + (pulgadas * 0.0254);


            txtMetros.Text = metros.ToString("##.00");
        }
    }
}
