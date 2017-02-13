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
            string reponse;
            double rayon, perimetre, surface;

            Console.WriteLine("Entrez le rayon du cercle");
            reponse = Console.ReadLine();

            rayon = Convert.ToDouble(reponse);

            perimetre = 2 * rayon * Math.PI;
            surface = Math.PI * rayon * rayon;

            Console.Write("Perimetre = " + perimetre + "\n");

            Console.Write("Surface = ");
            Console.WriteLine(surface);



        }
    }
}
