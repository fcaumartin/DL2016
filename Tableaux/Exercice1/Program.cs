using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab;

            Console.WriteLine("Entrez la taille du tableau");
            int taille = Convert.ToInt32(Console.ReadLine());

            tab = new int[taille];

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Entrez tab[{0}]", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int c in tab)
            {
                Console.Write("{0} ", c);
            }
        }
    }
}
