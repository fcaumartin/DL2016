using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int reponse;

            Random rnd;
            rnd = new Random();

            int alea = rnd.Next(101);
            Console.WriteLine(alea);


            do
            {
                Console.WriteLine("Entrez un nombre");
                reponse = Convert.ToInt32(Console.ReadLine());
                if (reponse<alea)
                {
                    Console.WriteLine("Trop petit");
                }
                if (reponse > alea)
                {
                    Console.WriteLine("Trop grand");
                }
            } while (reponse != alea);

            Console.WriteLine("Vous avez trouvé");
            Console.ReadLine();









        }
    }
}
