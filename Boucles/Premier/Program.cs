using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un nombre");
            int N = Convert.ToInt32(Console.ReadLine());

            bool premier = true;

            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    premier = false;
                }
                
            }

            if (premier)
            {
                Console.WriteLine("Le nombre est premier");
            }
            else
            {
                Console.WriteLine("Le nombre n'est pas premier");

            }
        }
    }
}
