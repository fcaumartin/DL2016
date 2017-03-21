using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ClientDAO
    {
        SqlConnection connect;

        public ClientDAO()
        {
            connect = new SqlConnection("server=.; database=hotel; integrated security=true");
            connect.Open();
        }

        public void Insert(Client cli)
        {
            SqlConnection connect = new SqlConnection("server=.; database=hotel; integrated security=true");
            connect.Open();

            SqlCommand requete = new SqlCommand("insert into client (cli_nom, cli_prenom) values (@nom, @prenom)", connect);
            requete.Parameters.AddWithValue("@nom", cli.Nom);
            requete.Parameters.AddWithValue("@prenom", cli.Prenom);

            requete.ExecuteNonQuery();
        }

        public List<Client> Liste()
        {
            List<Client> maliste = new List<Client>();

            SqlCommand requete = new SqlCommand("select * from client order by cli_nom", connect);
            SqlDataReader resultat = requete.ExecuteReader();

            while (resultat.Read())
            {
                Client cli = new Client();
                cli.Id = Convert.ToInt32(resultat["cli_id"]);
                cli.Nom = Convert.ToString(resultat["cli_nom"]);
                cli.Prenom = Convert.ToString(resultat["cli_prenom"]);
                maliste.Add(cli);
            }
            resultat.Close();

            return maliste;
        }
    }
}
