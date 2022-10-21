using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Arreglos_IVANKOLARIK
{
    public partial class Form1 : Form
    {
        int[] notas;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {

            

            //crear en memoria
            notas = new int[3];

            for (int i = 0; i < notas.Length; i++)
            {
                int numero = Convert.ToInt32(Interaction.InputBox("Ingrese notas: "));
                notas[i] = numero;

            }

            string Alumno1 = txtAlumno1.Text;
            string [] Alumnos = { Alumno1};
            float maximo, suma;

            foreach(string Alumno in Alumnos)
            {
                maximo = -1;
                suma = 0;
                for (int i = 0; i < Alumno.Length; i++)
                {
                    notas[i] = Convert.ToInt32(Interaction.InputBox("Ingrese la " + (i + 1) + "la nota de " + Alumno));
                    if (notas[i] > maximo)
                    {
                        maximo = notas[i];
                        suma += notas[i];
                    }
                    MessageBox.Show("Alumno: " + Alumno + " Maxima nota: " + maximo + "Promedio: " + promedio(suma));
                }
            }
        }

        #region metodos

        string promedio(float suma)
        {
            float aux = suma / 3;
            string texto;
            if (aux < 4)
            {
                texto = aux + ". Debe ir a recuperatorio";
            } else if (aux >4 && aux < 6){
                texto = aux + ". Bien";
            }
            else
            {
                texto = aux + ". Muy bien";
            }
            return texto;
        }

        #endregion

    }
}
