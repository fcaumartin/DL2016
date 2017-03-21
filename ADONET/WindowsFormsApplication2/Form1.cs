using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ClientDAO dao = new ClientDAO();

            //Client c = new Client();
            //c.Nom = textBox1.Text;
            //c.Prenom = textBox2.Text;


            //dao.Insert(c);


            //dataGridView1.DataSource = dao.Liste();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientDAO dao = new ClientDAO();

            dataGridView1.DataSource = dao.Liste();

            listBox1.DisplayMember = "Nom";
            listBox1.DataSource = dao.Liste();
        }
    }
}
