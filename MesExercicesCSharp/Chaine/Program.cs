using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaine
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom = "Bill";

            Console.WriteLine(nom);

            Console.WriteLine(nom[1]);

            Console.WriteLine(nom.Length);

            Console.WriteLine(nom.ToLower());

            Console.WriteLine(nom.Substring(1, 1));

            Console.WriteLine(nom.IndexOf('z'));

            Console.WriteLine(nom.Trim().ToLower().Substring(1,1));

            int age = 45;
            double a = 32.56987;

            Console.WriteLine("{0:0.00} {1:#.##}", age, a);


        }
    }
}
