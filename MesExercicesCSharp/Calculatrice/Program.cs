using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;
            double n1, n2, somme;

            Console.WriteLine("Entrez un nombre");
            reponse = Console.ReadLine();
            n1 = Convert.ToDouble(reponse);

            Console.WriteLine("Entrez un nombre");
            reponse = Console.ReadLine();
            n2 = Convert.ToDouble(reponse);

            somme = n1 / n2;

            Console.WriteLine("La somme de {0} / {1} = {2}",n1, n2, somme);
            //Console.WriteLine("La somme de " + n1 + " + " + n2 + " = " + somme);
        }
    }
}
