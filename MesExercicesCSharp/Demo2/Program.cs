using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "24";
            int a;
            long b;

            b = 10;

            a = Convert.ToInt32(n);
            
            a = (int)b;

            Console.WriteLine(a);
            Console.WriteLine(b);


            bool resultat;
            int age;
            n = "24";

            resultat = Int32.TryParse(n, out age);











        }
    }
}
