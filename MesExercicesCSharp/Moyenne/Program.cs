using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moyenne
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, moyenne;

            Console.WriteLine("Entrez une note");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrez une note");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrez une note");
            n3 = Convert.ToDouble(Console.ReadLine());

            moyenne = ( n1 * 3 + n2 * 2 + n3 ) / 6;

            Console.WriteLine(moyenne);

        }
    }
}
