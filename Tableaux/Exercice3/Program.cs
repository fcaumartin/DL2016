using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] prenoms = new string[] 
            {"Jean-Olivier", "Thierry", "Victorien", "Toto", "Thomas", "Alexandre" };

            Console.WriteLine("Entrez un prénom");
            string recherche = Console.ReadLine();

            //int indice = -1;

            //for (int i = 0; i < prenoms.Length; i++)
            //{
            //    if (prenoms[i] == recherche)
            //    {
            //        indice = i;
            //        break;
            //    }
            //}

            int indice = 0;

            while (indice < prenoms.Length && prenoms[indice] != recherche)
            {
                indice++;
            }

            if (indice < prenoms.Length)
            {
                Console.WriteLine("Trouvé en " + indice);
                for (int j = indice; j < prenoms.Length-1; j++)
                {
                    prenoms[j] = prenoms[j + 1];
                }
                prenoms[prenoms.Length - 1] = "";
                foreach (string p in prenoms)
                {
                    Console.WriteLine(p);
                }
                
            }
            else
            {
                Console.WriteLine("Pas trouvé");
            }

        }
    }
}
