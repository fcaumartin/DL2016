
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outils;

namespace Exercice2
{
    class Program
    {

        static int[] InitTab (int nb)
        {
            int[] tmp;
            
            tmp = new int[nb];

            return tmp;
        }

        static void SaisieTab(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = Tools.GetInteger("Entrez un nombre");
            }
        }
        

        static void Main(string[] args)
        {
            
            int nb = Tools.GetInteger("Entrez la taille du tableau");

            int [] tab = InitTab(nb);

            SaisieTab(tab);

            int reponse;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Afficher ...");
                Console.WriteLine("2 - Afficher ...");
                Console.WriteLine("3 - Afficher ...");
                Console.WriteLine("4 - Quitter ...");
                reponse = Tools.GetInteger("Entrez votre choix");
                switch (reponse)
                {
                    case 1:
                        AfficheTab(tab);
                        break;

                    case 2:

                        break;

                    case 3:

                        break;
                }
            } while (reponse != 4);

            Console.WriteLine("C'est la fin");


        }
    }
}
