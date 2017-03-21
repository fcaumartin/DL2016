using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exemple
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("server=.; database=hotel; integrated security=true");
            connect.Open();

            SqlCommand requete = new SqlCommand("select * from client", connect);

            SqlDataReader resultat = requete.ExecuteReader();

            listBox1.Items.Clear();
            while (resultat.Read() == true)
            {

                listBox1.Items.Add(resultat["cli_nom"]);
            }

            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("server=.; database=hotel; integrated security=true");
            connect.Open();

            SqlCommand requete = new SqlCommand("insert into client (cli_nom, cli_prenom) values (@nom, @prenom)", connect);
            requete.Parameters.AddWithValue("@nom", textBox1.Text);
            requete.Parameters.AddWithValue("@prenom", textBox2.Text);
            requete.ExecuteNonQuery();

            connect.Close();
        }
    }
}
