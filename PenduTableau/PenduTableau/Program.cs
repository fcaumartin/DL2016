using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenduTableau
{
    class Program
    {
        static void Dessine(int err)
        {
            if (err==0)
            {
                Console.WriteLine("--------");
            }
            if (err == 1)
            {
                Console.WriteLine("    |   ");
                Console.WriteLine("--------");
            }
            if (err == 2)
            {
                Console.WriteLine("    ╔═══   ");
                Console.WriteLine("    ║     ");
                Console.WriteLine("    ║     ");
                Console.WriteLine("    ║     ");
                Console.WriteLine("  ╔╦╬╦╦╦╦╦╗");
            }
        }


        static void Main(string[] args)
        {
            string MotCache = "uranus";

            char[] MotTrouve = new char[MotCache.Length];

            for (int i = 0; i < MotCache.Length; i++)
            {
                MotTrouve[i] = '_';
            }

            for (int i = 0; i < MotCache.Length; i++)
            {
                Console.Write(MotTrouve[i] + " ");
            }
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Entrez une lettre");
                char reponse = Convert.ToChar(Console.ReadLine());

                for (int i = 0; i < MotCache.Length; i++)
                {
                    if (reponse == MotCache[i])
                    {
                        MotTrouve[i] = reponse;
                    }
                }

                for (int i = 0; i < MotCache.Length; i++)
                {
                    Console.Write(MotTrouve[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
