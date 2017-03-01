using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Affiche(int nombre, string message)
        {
            for (int i = 0; i < nombre; i++)
            {
                Console.WriteLine(message);
            }
        }





        static int Calcul()
        {
            Random rnd = new Random();

            return rnd.Next(101);
        }

        static int Addition(int a, int b)
        {
            int resultat;
            
            resultat = a + b;

            a = 0;
            b = 0;

            return resultat;
        }

        static void Addition_v2(int a, int b, out int resultat)
        {
            
            resultat = a + b;

            //a = 0;
            //b = 0;

        }

        static void Main(string[] args)
        {
            Affiche(2, "Coucou");
            Console.WriteLine("------------------------------");
            Affiche(3, "Toto");
            Console.WriteLine("------------------------------");
            Affiche(1, "");
            Console.WriteLine("------------------------------");
            Affiche(7, "C'est terminé");






            int z = 45;
            int x = 3;

            int i = Addition(z, x);

            int res;
            Addition_v2(z, x, out res);

            Console.WriteLine(i);












            int nombre;
            string reponse;
            do {
                Console.WriteLine("Entrez un nombre");
                reponse = Console.ReadLine();
            } while (!Int32.TryParse(reponse, out nombre));
            


           















        }
    }
}
