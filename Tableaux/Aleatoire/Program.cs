using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleatoire
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10];

            Random rnd = new Random();

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rnd.Next(20, 51);
            }


            byte[] tab2 = new byte[10];

            rnd.NextBytes(tab2);

        }
    }
}
