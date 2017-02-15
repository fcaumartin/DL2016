using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majorite
{
    class Program
    {
        static void Main(string[] args)
        {

            int annee;

            Console.WriteLine("Entrez votre année de naissance");
            annee = Convert.ToInt32(Console.ReadLine());

            if (annee<(DateTime.Today.Year-18))
            {
                Console.WriteLine("Majeur");
            }
            else
            {
                Console.WriteLine("Mineur");
            }
        }
    }
}
