using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervalle
{
    class Program
    {
        static void Main(string[] args)
        {
            int somme = 0;

            Console.WriteLine("Entrez un nombre");
            int nb1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez un nombre");
            int nb2 = Convert.ToInt32(Console.ReadLine());



            for (int i = nb1; i < nb2+1; i++)
            {
                somme += i;
                Console.WriteLine(i);
            }

            Console.WriteLine(somme);
        }
    }
}
