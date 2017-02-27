using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyelles
{
    class Program
    {
        static void Main(string[] args)
        {
            int compteur = 0;
            string voyelles = "aeiouy";

            Console.WriteLine("Entrez une phrase");
            string phrase = Console.ReadLine();

            for (int i = 0; i < phrase.Length; i++)
            {
                if (voyelles.IndexOf(phrase.Substring(i, 1)) != -1)
                {
                    compteur++;
                }

                //if (phrase.Substring(i,1) == "a" || phrase.Substring(i, 1) == "e")
                //{
                //    compteur++;
                //}
                //switch (phrase.Substring(i, 1).ToLower())
                //{
                //    case "a":
                //        compteur++;
                //        break;
                //    case "e":
                //        compteur++;
                //        break;
                //    case "i":
                //        compteur++;
                //        break;

                //}
            }

            Console.WriteLine(compteur);
        }
    }
}
