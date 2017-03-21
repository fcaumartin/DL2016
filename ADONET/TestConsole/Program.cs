using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            ClientDAO dao = new ClientDAO();

            Console.WriteLine("Liste des clients avant insertion");
            foreach(Client cli in dao.Liste())
            {
                Console.WriteLine(cli.Nom + " " + cli.Prenom);
            }
            Console.WriteLine("------------------------------------");

            Client c = new Client();
            c.Nom = "test_nom";
            c.Prenom = "test_prenom";
            c.Ville = "test_ville";

            dao.Insert(c);


            Console.WriteLine("Liste des clients apres insertion");
            foreach (Client cli in dao.Liste())
            {
                Console.WriteLine(cli.Nom);
            }
            Console.WriteLine("------------------------------------");

        }
    }
}
