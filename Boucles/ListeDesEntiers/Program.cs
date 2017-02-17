using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeDesEntiers
{
    class Program
    {
        static void Main(string[] args)
        {
            int somme = 0;

            Console.WriteLine("Entrez un nombre");

            int nb = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nb; i++)
            {
                somme += i;
                Console.WriteLine(i);
            }

            Console.WriteLine("La somme = {0}", somme);
        }
    }
}
