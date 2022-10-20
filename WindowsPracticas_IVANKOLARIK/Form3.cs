using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPracticas_IVANKOLARIK
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            decimal numero = Convert.ToDecimal(txtNumero.Text);
            int incrementar = 7;
            for (numero = 1; numero <= 12; numero++)
            {
                MessageBox.Show(numero + "X" + incrementar +"="+(numero*incrementar));
            }
        }
    }
}
