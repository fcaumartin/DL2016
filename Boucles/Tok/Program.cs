using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tok
{
    class Program
    {
        static void Main(string[] args)
        {
            string mot = "18/07/1982";
            string sep = "/";
            int compteur = 0;
            int morceau = 2;
            string resultat = "";


            for (int i = 0; i < mot.Length; i++)
            {
                if (mot.Substring(i, 1) == sep)
                {
                    compteur++;
                }
                else {
                    if (compteur == morceau)
                        resultat += mot.Substring(i, 1);
                }
            }

            Console.WriteLine(resultat);

        }
    }
}
