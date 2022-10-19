using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(txtNota1.Text);
            decimal nota2 = Convert.ToDecimal(txtNota2.Text);
            decimal nota3 = Convert.ToDecimal(txtNota2.Text);
            decimal nota4 = Convert.ToDecimal(txtNota2.Text);
            var promedio = (nota1 + nota2 + nota3 + nota4);


            if (promedio / 4 >= 9 )
            {
                MessageBox.Show("Excelente");
            }
            else if (promedio / 4 >= 7 & promedio / 4  < 9 ) 
            {
                MessageBox.Show("Muy Bien");
            }
            else if (promedio / 4 < 7 & promedio / 4 >= 4)
            {
                MessageBox.Show("Regular");
            }
            else
            {
                MessageBox.Show("En proceso de aprendizaje");
            }
        } 

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(txtNota1.Text);
            decimal nota2 = Convert.ToDecimal(txtNota2.Text);
            decimal nota3 = Convert.ToDecimal(txtNota2.Text);
            decimal nota4 = Convert.ToDecimal(txtNota2.Text);

            decimal mayor = Convert.ToDecimal(txtNota1.Text);   


            if (nota2 > mayor && nota2 > nota3 && nota2 > nota4)
            {
                MessageBox.Show("La nota mayor es: " + nota2);
            }
            else if(nota3 > mayor && nota3 > nota2 && nota3 > nota4)
            {
                MessageBox.Show("La nota mayor es: " + nota3);
            }
            else             {
                MessageBox.Show("La nota mayor es: " + nota4);
            }
        }
    }
}
