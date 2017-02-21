using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evenements
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("ARGHHH !!");
            }
            else
            {
                MessageBox.Show("OK");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"^[a-z]{2,}@[a-z]{2,}\.[a-z]{2,5}$") == false )
            {
                textBox1.BackColor = Color.Pink;
                button1.Enabled = false;
                label1.Visible = true;
            }
            else
            {
                textBox1.BackColor = Color.White;
                button1.Enabled = true;
                label1.Visible = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Pink;
            button1.Enabled = false;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
