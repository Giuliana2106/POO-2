using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda
{
    class Program
    {
        static string[,] agenda = new string[4, 10];
        static int Contador = 0;
        static Menú m = new Menú();
        static void Main(string[] args)
        {
            agenda = new string[4, 10];

            int opciones = 0;

            while (opciones != 5)
            {
                opciones = m.ListaMenú();

                if (opciones == 1)
                {

                }

                else if (opciones == 2)
                {

                }

                else if (opciones == 3)
                {

                }

                else if (opciones == 4)
                {

                }


            }

            Console.ReadKey();
        }
    }
}
