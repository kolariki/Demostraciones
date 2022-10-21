using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Arreglos_IVANKOLARIK
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bntPrecios_Click(object sender, EventArgs e)
        {
            int[] precios;
            precios = new int[8];
            double acumulado = 0;

            for (int i = 0; i < precios.Length; i++)
            {
                int numero = Convert.ToInt32(Interaction.InputBox("Ingrese precios: "));
                precios[i] = numero;
                acumulado = acumulado + numero;

            }
            MessageBox.Show("El numero total de los precios sumados es: " + acumulado);
        }
    }
}
