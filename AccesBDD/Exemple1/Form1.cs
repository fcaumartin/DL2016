using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemple1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("server=.;database=hotel;integrated security=true");

            connect.Open();

            SqlCommand requete = new SqlCommand("select * from client", connect);

            SqlDataReader resultat = requete.ExecuteReader();

            while (resultat.Read())
            {
                listBox1.Items.Add(resultat["cli_nom"]);
            }

            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("server=.;database=hotel;integrated security=true");

            connect.Open();

            //string sql = "insert into client (cli_nom, cli_prenom) values ('" + textBox1.Text + "', '" + textBox2.Text + "')";
            //Console.WriteLine(sql);
            //SqlCommand requete = new SqlCommand(sql, connect);

            SqlCommand requete = new SqlCommand("insert into client (cli_nom, cli_prenom) values (@n, @p)", connect);
            requete.Parameters.AddWithValue("@n", textBox1.Text);
            requete.Parameters.AddWithValue("@p", textBox2.Text);

            requete.ExecuteNonQuery();

            connect.Close();
        }
    }
}
