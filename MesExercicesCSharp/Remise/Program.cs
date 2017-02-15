using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remise
{
    class Program
    {
        static void Main(string[] args)
        {
            double pu, qte, pap, tot, rem, port;

            Console.WriteLine("Entrez PU");
            pu = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrez QTE");
            qte = Convert.ToDouble(Console.ReadLine());

            tot = qte * pu;

            if (tot > 200)
            {
                // > 200
                rem = tot * 0.1;
            }
            else if (tot > 100)
            {
                // entre 100 et 200
                rem = tot * 0.05;
            }
            else
            {
                rem = 0;
            }

            if (tot > 500)
            {
                port = 0;
            }
            else
            {
                port = 0.02 * tot;
                if (port < 6)
                {
                    port = 6;
                }
            }

            pap = tot + port - rem;
            Console.WriteLine("PU = {0}", pu);
            Console.WriteLine("QTE = {0}", qte);
            Console.WriteLine("TOT = {0}", tot);
            Console.WriteLine("REM = {0}", rem);
            Console.WriteLine("PORT = {0}", port);
            Console.WriteLine("PAP = {0}", pap);

        }
    }
}
