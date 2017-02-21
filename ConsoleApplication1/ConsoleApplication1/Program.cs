using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void StairCase(int n)
        {
            string Output = "#";
            int i;
            if (n <= 100 && n >= 1)
            {
                for (i = 1; i <= n; i++)
                {
                    Console.WriteLine("{0}", Output);
                    Output += "#";
                }


            }
        }
        static void Main(string[] args)
        {
            StairCase(5);
            Console.ReadLine();
        }
    }
}


