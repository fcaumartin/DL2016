using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            double salaire;
            string situation;
            int enfants;
            int participation;

            Console.WriteLine("Entrez votre salaire");
            salaire = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrez votre situation (M/C)");
            situation = Console.ReadLine();

            Console.WriteLine("Combien avez vous d'enfants ?");
            enfants = Convert.ToInt32(Console.ReadLine());

            if (situation == "M")
            {
                participation = 25;
            }
            else  if (situation == "C")
            {
                participation = 20;
            }
            else
            {
                participation = 0;
            }

            participation += enfants * 10;
            //participation = participation + (enfants * 10);

            if (salaire<1200)
            {
                participation += 10;
            }

            if (participation>50)
            {
                participation = 50;
            }

            Console.WriteLine("Participation de {0}", participation);

        }
    }
}
