using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
    public class ClientDAO2
    {
        string _fichier;
        public ClientDAO2(string chaine)
        {
            _fichier = chaine;
        }

        public void Insert_old(Client cli) {

            string[] clients = File.ReadAllLines(_fichier);
            List<Client> resultat = new List<Client>();
            int max_id = 0;

            foreach (string s in clients)
            {
                Client c = new Client();
                string[] strcli = s.Split(';');
                c.Id = Convert.ToInt32(strcli[0]);
                c.Nom = Convert.ToString(strcli[1]);
                c.Prenom = Convert.ToString(strcli[2]);
                c.Ville = Convert.ToString(strcli[3]);
                resultat.Add(c);
                if (c.Id > max_id) max_id = c.Id;
            }

            max_id++;
            cli.Id = max_id;

            string client;

            client = cli.Id + ";" + cli.Nom + ";" + cli.Prenom + ";" + cli.Ville + "\n";
            File.AppendAllText(_fichier, client);

        }

        public void Insert(Client cli)
        {
            List<Client> resultat = new List<Client>();
            int max_id = 0;
            string[] clients;

            if (File.Exists(_fichier))
            {
                clients = File.ReadAllLines(_fichier);
                foreach (string s in clients)
                {
                    if (s != "")
                    {
                        Client c = new Client();
                        string[] strcli = s.Split(';');
                        c.Id = Convert.ToInt32(strcli[0]);
                        c.Nom = Convert.ToString(strcli[1]);
                        c.Prenom = Convert.ToString(strcli[2]);
                        c.Ville = Convert.ToString(strcli[3]);
                        resultat.Add(c);
                        if (c.Id > max_id) max_id = c.Id;
                    }
                }
            }
           

            max_id++;
            cli.Id = max_id;
            resultat.Add(cli);

            clients = new string[resultat.Count];
            int i = 0;
            foreach(Client c in resultat)
            {
                clients[i] = c.Id + ";" + c.Nom + ";" + c.Prenom + ";" + c.Ville + "\n";
                i++;
            }

            File.WriteAllLines(_fichier, clients);
            
        }
        public void Update(Client cli) { }
        public void Delete(Client cli) { }
        //public Client Find(int id) { }
        public List<Client> List() {

            string [] clients = File.ReadAllLines(_fichier);
            List<Client> resultat = new List<Client>();

            foreach (string s in clients)
            {
                if (s != "")
                {
                    Client c = new Client();
                    string[] cli = s.Split(';');
                    c.Id = Convert.ToInt32(cli[0]);
                    c.Nom = Convert.ToString(cli[1]);
                    c.Prenom = Convert.ToString(cli[2]);
                    c.Ville = Convert.ToString(cli[3]);
                    resultat.Add(c);
                }
            }
            

            return resultat;

        }
    }
}
