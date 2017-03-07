using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClientDAO
    {
        SqlConnection _connect;
        public ClientDAO(string chaine)
        {
            _connect = new SqlConnection(chaine);
        }
        public void Insert(Client cli) {
            SqlCommand requete = new SqlCommand("insert into client(cli_nom,cli_prenom, cli_ville) values (@nom, @prenom,@ville)", _connect);
            requete.Parameters.AddWithValue("@nom", cli.Nom);
            requete.Parameters.AddWithValue("@prenom", cli.Prenom);
            requete.Parameters.AddWithValue("@ville", cli.Ville);
            requete.ExecuteNonQuery();
            SqlCommand requete2 = new SqlCommand("select max(cli_id) from client", _connect);
            int id = (int)requete2.ExecuteScalar();
            cli.Id = id;

        }
        public void Update(Client cli) { }
        public void Delete(Client cli) { }
        //public Client Find(int id) { }

        public List<Client> List() {
            _connect.Open();
            List<Client> resultat = new List<Client>();
            SqlCommand requete = new SqlCommand("select * from client", _connect);
           
            SqlDataReader lecture = requete.ExecuteReader();
            while (lecture.Read())
            {
                Client c = new Client();
                c.Id = Convert.ToInt32(lecture["cli_id"]);
                c.Nom = Convert.ToString(lecture["cli_nom"]);
                c.Prenom = Convert.ToString(lecture["cli_prenom"]);
                c.Ville = Convert.ToString(lecture["cli_ville"]);
                resultat.Add(c);
            }
            lecture.Close();
            _connect.Close();
            return resultat;

        }
    }
}
