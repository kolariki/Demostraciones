using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnImplicito_Click(object sender, EventArgs e)
        {
            ConversionImplicita();
        }

        private void btnExplicito_Click(object sender, EventArgs e)
        {
            ConversionExplicita();
        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            MetodosDeConversion();
        }

        #region mis métodos
        private void ConversionImplicita()
        {

            //CONVERSION IMPLICITA
            // convierte en forma implicita el valor de randonNumber en la parte derecha a un
            // tipo int antes de asignarlo a numeroAleatorio            
            var randomNumber = new Random().Next(0, 100);
            int numeroAleatorio = randomNumber;

            MessageBox.Show("Su numero de la suerte es: " + numeroAleatorio);
        }

            private void ConversionExplicita()
            {
                //CONVERSION EXPLICITA
                //se especificxa que el tipo int que esta entre parentesis se va a convertir a la variable myDouble que es de tipo double
                double myDouble = 7;
                int myInt = (int)myDouble;

                MessageBox.Show("Mi numero favorito es: " + myInt);
            }

        private void MetodosDeConversion()
        {
            //METODO DE CONVERSION
            //se convierte un string a un int que luego se suma a otro int
            string num = "16";
            int numero1 = Int16.Parse(num);
            int numero2 = 10;

            MessageBox.Show("La suma de: " + (numero1 + numero2) );
        }


    }
        #endregion
}
