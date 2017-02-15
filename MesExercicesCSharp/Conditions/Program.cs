using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre;

            string reponse = "Y";

            if (reponse == "Y")
            {
                nombre = 0;
            }
            else
            {
                nombre = -1;
            }

            nombre = (reponse == "Y") ? (0) : ((reponse == "y") ? (0) : (-1));

            Console.WriteLine(nombre);
        }
    }
}
