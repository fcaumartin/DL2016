using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un nombre");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez un nombre");
            int X = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, X, i*X);
            }

        }
    }
}
