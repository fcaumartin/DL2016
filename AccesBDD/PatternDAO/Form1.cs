using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ClientDAO repo = new ClientDAO("server=.;database=hotel; integrated security=true");

            listBox1.DisplayMember = "Nom";
            listBox1.DataSource = repo.List();

            
            dataGridView1.DataSource = repo.List();
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
