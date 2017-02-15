using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //for ( int i = 0 ; i < 10 ; i++ ) {
            //    Console.WriteLine("{0} Bonjour", i);
            //}

            //int j = Int32.MaxValue - 5;
            //while (true)
            //{
            //    Console.WriteLine("{0} Bonjour", j);
            //    j++;
            //    Console.ReadLine();
            //}


            int j = 100;
            do
            {
                Console.WriteLine("{0} Bonjour", j);
                j++;
            } while (j < 10);

        }
    }
}
