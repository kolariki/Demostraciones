using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace WindowsPracticas_IVANKOLARIK
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAreaRectangulo_Click(object sender, EventArgs e)
        {
            decimal base_r = Convert.ToDecimal(txtBase.Text);
            decimal altura_r = Convert.ToDecimal(txtAltura.Text);
            MessageBox.Show("El area del rectangulo es: " + (base_r * altura_r));
        }

        private void btnTrapecio_Click(object sender, EventArgs e)
        {
            decimal base_t1 = Convert.ToDecimal(txtBase1.Text);
            decimal base_t2 = Convert.ToDecimal(txtBase2.Text);
            decimal altura_t = Convert.ToDecimal(txtAlturaTrapecio.Text);
            MessageBox.Show("El area del trapecio es: " + ((base_t1 + base_t2) * altura_t / 2));
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            int radio = Int32.Parse(txtRadio.Text);     
            double PI  = 3.14;
            MessageBox.Show("El area del circulo es: " + (radio * radio) * PI);
        }
    }
}
