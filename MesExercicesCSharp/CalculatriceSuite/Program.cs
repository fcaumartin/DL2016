using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatriceSuite
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb1, nb2, resultat  = 0;
            string operateur;

            Console.WriteLine("Entrez un nombre");
            nb1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez un nombre");
            nb2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez un opérateur");
            operateur = Console.ReadLine();

            switch(operateur)
            {
                case "+":
                    resultat = nb1 + nb2;
                    break;
                case "-":
                    resultat = nb1 - nb2;
                    break;
                case "*":
                    resultat = nb1 * nb2;
                    break;
                case "/":
                    if (nb2 == 0)
                    {
                        Console.WriteLine("Division impossible");
                    }
                    else
                    {
                        resultat = nb1 / nb2;
                    }
                    break;

            }
            Console.WriteLine("{0} {1} {2} = {3}", nb1, operateur, nb2, resultat);


        }
    }
}
