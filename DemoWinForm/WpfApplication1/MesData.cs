using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class MesData
    {

        public List<Client> MaListe { get; set; }

        public MesData()
        {
            MaListe = new List<Client>();

            MaListe.Add(new Client { Nom = "Toto1", Prenom = "Titi" });
            MaListe.Add(new Client { Nom = "Toto2", Prenom = "Titi" });
            MaListe.Add(new Client { Nom = "Toto3", Prenom = "Titi" });
            MaListe.Add(new Client { Nom = "Toto4", Prenom = "Titi" });
        }

    }

    public class Client
    {
        public string  Nom { get; set; }
        public string  Prenom { get; set; }
    }
}
