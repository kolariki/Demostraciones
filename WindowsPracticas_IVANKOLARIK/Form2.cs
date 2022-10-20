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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            decimal edad = Convert.ToDecimal(txtEdad.Text);


            if ( edad >= 60)
            {
                MessageBox.Show("Usted es un persona adulto mayor.");
            }
            else if(edad >= 18 && edad < 60 )
            {
                MessageBox.Show("Usted es mayor de edad.");
            }
            else if (edad < 18 && edad > 0)
            {
                MessageBox.Show("Usted es menor de edad.");
            }
            else if(edad == 0)
            {
                MessageBox.Show("ERROR debe ingresar una edad valida.");
            }

        }

        }
    }

