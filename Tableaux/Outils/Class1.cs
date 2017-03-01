using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outils
{
    public class Tools
    {
        public static int GetInteger(string message)
        {
            int nb;
            do
            {
                Console.WriteLine(message);
            } while (!Int32.TryParse(Console.ReadLine(), out nb));

            return nb;
        }

    }
}
