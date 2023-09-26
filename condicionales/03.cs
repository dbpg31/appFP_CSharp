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
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int angulo = int.Parse(txtAngulo.Text);

            if (angulo == 0) txtTipo.Text = ("nulo");
            else if ((angulo > 0) && (angulo < 90)) txtTipo.Text = ("Angulo agudo");
            else if (angulo == 90) txtTipo.Text = ("Angulo recto");
            else if ((angulo > 90) && (angulo < 180)) txtTipo.Text = ("Angulo obtuso");
            else if (angulo == 180) txtTipo.Text = ("Angulo llano");
            else if ((angulo > 180) && (angulo < 360)) txtTipo.Text = ("Angulo cóncavo");
            else if (angulo == 360) txtTipo.Text = ("Angulo completo");
        }
    }
}
