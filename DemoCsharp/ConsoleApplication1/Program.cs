using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;
            int nombre = 0;
            bool saisie = false;

            while (saisie == false) {
                Console.WriteLine("Entrez un nombre");
                reponse = Console.ReadLine();
                try {
                    nombre = Convert.ToInt32(reponse);
                    saisie = true;
                }
                catch (Exception er)
                {
                    Console.WriteLine("Ce n'est pas un nombre");
                    Console.WriteLine(er.Message);
                    saisie = false;
                }
            }
            

            Console.WriteLine(nombre * 2);
        }
    }
}
