using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Arreglos_IVANKOLARIK
{
    public partial class Form3 : Form
    {
        private string[] empleados;
        private int[,] sueldos;
        private int[] sueldostot;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSueldos_Click(object sender, EventArgs e)
        {
            string[] empleados = new String[4];
            int[,] sueldos = new int[4, 3];
            int[] sueldostot = new int[4];


            for (int f = 0; f < empleados.Length; f++)
            {
                string nombre = Interaction.InputBox("Ingrese el nombre del operario " + (f + 1) + ": ");
                empleados[f] = nombre;


            }
            #region metodos


     /*       public void Empleados(int[] trabajador, int[] sueldos)
            {

                for (int i = 0; i < trabajador.Length; i++)
                {
                    int empleados = Convert.ToInt32(Interaction.InputBox("Ingrese los trabajadores: "));
                    trabajador[i] = empleados;
                }

                for (int i = 0; i < sueldos.Length; i++)
                {
                    int sueldo = Convert.ToInt32(Interaction.InputBox("Ingrese los sueldos: "));
                    sueldos[i] = sueldo;
                }
            }*/




            #endregion

        }

    }
}


      