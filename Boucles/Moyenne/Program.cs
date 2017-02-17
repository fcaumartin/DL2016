using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moyenne
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb, min = Int32.MaxValue, max = Int32.MinValue;
            double somme = 0;
            int compteur = 0;

            do
            {
                Console.WriteLine("Entrez un nombre");
                nb = Convert.ToInt32(Console.ReadLine());

                //if (nb == 0) break;

                somme += nb;
                compteur++;

                if (nb > max)
                {
                    max = nb;
                }
                if (nb <min && nb != 0)
                {
                    min = nb;
                }

            } while (nb != 0);


            Console.WriteLine("Somme = {0}", somme);
            Console.WriteLine("Moyenne = {0}", somme/(compteur-1));
            Console.WriteLine("Mini = {0}", min);
            Console.WriteLine("Maxi = {0}", max);

        }



        static void Main2(string[] args)
        {
            int nb, min, max;
            double somme = 0;
            int compteur = 0;

            Console.WriteLine("Entrez un nombre");
            nb = Convert.ToInt32(Console.ReadLine());
            somme += nb;
            compteur++;
            min = nb;
            max = nb;

            while (nb != 0)
            {
                Console.WriteLine("Entrez un nombre");
                nb = Convert.ToInt32(Console.ReadLine());

                //if (nb == 0) break;

                somme += nb;
                compteur++;

                if (nb > max)
                {
                    max = nb;
                }
                if (nb < min)
                {
                    min = nb;
                }

            }


            Console.WriteLine("Somme = {0}", somme);
            Console.WriteLine("Moyenne = {0}", somme / (compteur - 1));
            Console.WriteLine("Mini = {0}", min);
            Console.WriteLine("Maxi = {0}", max);

        }
    }
}
