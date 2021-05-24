using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_3
{
    class Program
    {
        private int[] quimica;
        private int[] fisica;

        public void CalificacionesQuimica()
        {

            
            quimica = new int[6];
            Console.WriteLine("\nCALIFICACIONES DE QUIMICA");
            for (int i = 1; i <= 5; i++)
            {

                Console.WriteLine("\nIngrese la calificacion del alumno " + i + ": ");
                quimica[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("------------------------------------");
        }

        public void imprimirCalificacionesQuimica()
        {
            Console.WriteLine("\nLas calificaciones de los alumnos en Quimica son: ");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(quimica[i]);
            }
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
        }

        public void CalificacionesFisica()
        {


            fisica = new int[6];
            Console.WriteLine("\nCALIFICACIONES DE FISICA");
            for (int i = 1; i <= 5; i++)
            {

                Console.WriteLine("\nIngrese la calificacion del alumno " + i + ": ");
                fisica[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("------------------------------------");
        }

        public void imprimirCalificacionesFisica()
        {
            Console.WriteLine("\nLas calificaciones de los alumnos en Fisica son: ");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(fisica[i]);
            }
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
        }

        public void Promedios()
        {
            double promedioquimica = 0;
            double promediofisica = 0;

            for(int i = 0; i < 4; i++)
            {
                promedioquimica = (promedioquimica + quimica[i]) / 5;
            }

            for (int i = 0; i < 4; i++)
            {
                promediofisica = (promediofisica + fisica[i]) / 5;
            }

            Console.WriteLine("\nEl promedio de la clase de quimica es: " + promedioquimica);
            Console.WriteLine("\nEl promedio de la clase de fisica es: " + promediofisica);
            Console.WriteLine("------------------------------------\n");

            if (promedioquimica > promediofisica)
            {
                Console.WriteLine("El promedio fue mayor en Quimica");
            }
            else
            {
                Console.WriteLine("El promedio fue mayor en Fisica");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("ALUMNO       QUIMICA         FISICA\n");
            Console.WriteLine("Pablo          10               8");
            Console.WriteLine("Luis            9               9");
            Console.WriteLine("Rodolfo         8              10");
            Console.WriteLine("Ana            10               8");
            Console.WriteLine("Gabriela        9               7");
            Console.WriteLine("------------------------------------");


            Program Calificaciones = new Program();
            Calificaciones.CalificacionesQuimica();
            Calificaciones.imprimirCalificacionesQuimica();
            Calificaciones.CalificacionesFisica();
            Calificaciones.imprimirCalificacionesFisica();
            Calificaciones.Promedios();

            Console.ReadKey();

        }
    }
}
