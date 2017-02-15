using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parite
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre;

            Console.WriteLine("Entrez un nombre");
            nombre = Convert.ToInt32(Console.ReadLine());

            if (nombre%2 == 0)
            {
                Console.WriteLine("Nombre pair");
            }
            else
            {
                Console.WriteLine("Nombre impair");
            }
        }
    }
}
