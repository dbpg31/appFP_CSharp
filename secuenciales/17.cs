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
    public partial class _17 : Form
    {
        public _17()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEscuela_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int donacion = int.Parse(txtDonacion.Text);
            double salud = donacion * 0.25;
            double comedor = donacion * 0.35;
            double escuela = donacion * 0.25;
            double asilo = donacion * 0.15;

            txtSalud.Text = (salud.ToString("##.00"));
            txtComedor.Text = (comedor.ToString("##.00"));
            txtEscuela.Text = (escuela.ToString("##.00"));
            txtAsilo.Text = (asilo.ToString("##.00"));
        }
    }
}
