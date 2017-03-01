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

            //int[] tableau = new int[10];
            int[] tableau = new int[] { 45, 12, 0, 0, 0, 7, 0, 0, 0, 0 };

            //tableau[0] = 45;
            //tableau[5] = 7;
            //tableau[1] = 12;

            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = 99;
                Console.Write("{0} ",tableau[i]);
            }
            Console.WriteLine();

            foreach(int c in tableau)
            {
                //c = 99;
                Console.Write("{0} ", c);
            }


        }
    }
}
