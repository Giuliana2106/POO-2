using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda
{
    class Menú
    {
        private int op = 0;

        public int ListaMenú()
        {
            Console.WriteLine("1.-Crear Contacto");
            Console.WriteLine("2.-Buscar Contacto");
            Console.WriteLine("3.-Modificar Contacto");
            Console.WriteLine("4.-Eliminar Contacto");
            Console.WriteLine("5.Salir");
            Console.WriteLine("opción: ");
            op = int.Parse(Console.ReadLine());
            return op;     
        }
    }
}
