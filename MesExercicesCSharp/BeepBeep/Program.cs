using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeepBeep
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre;
            string reponse;
            char caractere;

            Console.WriteLine("Entrez un nombre");
            reponse = Console.ReadLine();

            caractere = reponse[0];
            nombre = caractere;
            Console.WriteLine("Code ASCII du premier caractere" + nombre);


            nombre = Convert.ToInt32(reponse);

            Console.WriteLine(reponse);
            Console.WriteLine(nombre);

            caractere = (char)nombre;

            Console.WriteLine(caractere);




        }
    }
}
