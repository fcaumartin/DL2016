using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeunesVieux
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int jeunes = 0, moyens = 0, vieux = 0;

            do
            {
                Console.WriteLine("Entrez un age");
                age = Convert.ToInt32(Console.ReadLine());
                if (age <20)
                {
                    jeunes++;
                }
                else if (age>40)
                {
                    vieux++;
                }
                else
                {
                    moyens++;
                }
            } while (age < 100);

            Console.WriteLine("jeunes={0} Moyens={1} Vieux={2}", jeunes, moyens, vieux);
        }
    }
}
