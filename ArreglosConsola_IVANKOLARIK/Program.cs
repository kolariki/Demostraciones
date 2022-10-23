using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosConsola_IVANKOLARIK
{
    internal class Program
    {
        string[] empleados = new String[4];
        int[,] sueldos = new int[4, 3];

        static void Main(string[] args)
        {


            string[] empleados = new String[4];
            int[,] sueldos = new int[4, 3];
            int [] sueldostot = new int[4];

            for (int f = 0; f < empleados.Length; f++)
            {
                Console.Write("Ingrese el nombre del operario " + (f + 1) + ": ");
                empleados[f] = Console.ReadLine();


                for (int c = 0; c < sueldos.GetLength(1); c++)
                {
                    Console.Write("Ingrese sueldo " + (c + 1) + ": ");
                    string linea;
                    linea = Console.ReadLine();
                    sueldos[f, c] = int.Parse(linea);
                }
                for (int j = 0; j < sueldos.GetLength(0); j++)
                {
                    int suma = 0;
                    for (int c = 0; c < sueldos.GetLength(1); c++)
                    {
                        suma = suma + sueldos[f, c];
                    }
                    sueldostot[f] = suma;
                }

            }
        }


            /*public void ImprimirTotalPagado()
            {
                Console.WriteLine("Total de sueldos pagados por Operario.");
                for (int f = 0; f < sueldostot.Length; f++)
                {
                    Console.WriteLine(empleados[f] + " - " + sueldostot[f]);
                }
            }

            public void EmpleadoMayorSueldo()
            {
                int may = sueldostot[0];
                string nom = empleados[0];
                for (int f = 0; f < sueldostot.Length; f++)
                {
                    if (sueldostot[f] > may)
                    {
                        may = sueldostot[f];
                        nom = empleados[f];
                    }
                }
                Console.WriteLine("El operario con mayor sueldo es " + nom + " que tiene un sueldo de " + may);
            }

           static void Main2(string[] args)
            {
                Matriz ma = new Matriz();
                ma.Cargar();
                ma.CalcularSumaSueldos();
                ma.ImprimirTotalPagado();
                ma.EmpleadoMayorSueldo();
                Console.ReadKey();
            }*/
        }
    }

