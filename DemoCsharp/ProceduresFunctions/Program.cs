using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduresFunctions
{
    class Program
    {
        static void AfficheMessage(string message)
        {
            Console.WriteLine("Coucou" + message);
            Console.WriteLine("Coucou");
            Console.WriteLine("Coucou");
            Console.WriteLine("Coucou");
            Console.WriteLine("Coucou" + message);
            
        }

        static void SaisieTab(int [] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine("Entrez un nombre");
                t[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        

        static void Main(string[] args)
        {
            int[] tab = new int[5];


            SaisieTab(tab);

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i]);
            }
            Console.WriteLine();

            foreach(int element in tab)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();


            AfficheMessage("toto");
            AfficheMessage("");
            AfficheMessage("titi");

            int a = 1;
            int b = 2;

            int z = Calcul(b, a);
            Console.WriteLine(b);

        }


        static int Calcul(int a, int b)
        {

            int c;
            c = (a + 2) * b;
            a = 0;

            return c;
        }






    }
}
