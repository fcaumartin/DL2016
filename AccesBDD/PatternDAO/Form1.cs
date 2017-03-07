using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace PatternDAO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientDAO2 repo = new ClientDAO2("c:\\tmp\\liste_clients.txt");

            listBox1.DisplayMember = "Nom";
            listBox1.DataSource = repo.List();

            
            dataGridView1.DataSource = repo.List();
            dataGridView1.Columns[0].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientDAO2 repo = new ClientDAO2("c:\\tmp\\liste_clients.txt");

            Client c = new Client();

            c.Id = 55;
            c.Nom = "testNom";
            c.Prenom = "testPrenom";
            c.Ville = "testVille";

            repo.Insert(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlSerializer ser = new XmlSerializer(typeof(XmlElement));
            XmlDocument doc = new XmlDocument();


            XmlElement clients = doc.CreateElement("CLIENTS");

            for (int i = 0; i < 5; i++)
            {


                XmlElement cli1 = doc.CreateElement("CLIENT");

                XmlElement nom = doc.CreateElement("NOM");
                nom.InnerText = "Nom du client";
                XmlElement prenom = doc.CreateElement("PRENOM");
                XmlElement ville = doc.CreateElement("VILLE");
                cli1.AppendChild(nom);
                cli1.AppendChild(prenom);
                cli1.AppendChild(ville);

                clients.AppendChild(cli1);
            }

            TextWriter writer = new StreamWriter("c:\\tmp\\test.xml");
            ser.Serialize(writer, clients);
            writer.Close();
        }
    }
}
