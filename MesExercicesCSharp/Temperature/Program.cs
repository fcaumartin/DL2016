using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;
            double n1, resultat;

            Console.WriteLine("Entrez une temperature");
            reponse = Console.ReadLine();
            n1 = Convert.ToDouble(reponse);

            resultat = (5 * (n1 - 32)) / 9 ;

            Console.WriteLine(resultat);
        }
    }
}
