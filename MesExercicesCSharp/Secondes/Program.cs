using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondes
{
    class Program
    {
        static void Main(string[] args)
        {
            int secondes, heures, reste, minutes;


            Console.WriteLine("Entrez un nombre");
            secondes = Convert.ToInt32(Console.ReadLine());

            heures = secondes / 3600;

            reste = secondes % 3600;
            //reste = secondes - (heure * 3600);

            minutes = reste / 60;

            reste = reste % 60;


            Console.WriteLine("{0}h {1}mn {2}s ", heures, minutes, reste);











        }
    }
}
