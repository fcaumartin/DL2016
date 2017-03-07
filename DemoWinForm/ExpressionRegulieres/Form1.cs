using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ExpressionRegulieres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(   Regex.IsMatch(textBox1.Text, @"^\d{1,2}/\d{1,2}/\d{2,4}$")  )
            //if (Regex.IsMatch(textBox1.Text, @"^[a-z]{2,}@[a-z]{2,}.com$"))
            if (Regex.IsMatch(textBox1.Text, @"^[0-9]{1,2}/[0-9]{1,2}/[0-9][0-9]([0-9][0-9])?$"))
            {
                //MessageBox.Show("Le masque est verifie");
                textBox1.BackColor = Color.Green;
            }
            else
            {
                //MessageBox.Show("Le masque ne correspond pas");
                textBox1.BackColor = Color.Red;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label2.Visible = false;
            }
            else
            {
                label2.Visible = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"^[0-9]{1,2}/[0-9]{1,2}/[0-9][0-9]([0-9][0-9])?$"))
            {
                //MessageBox.Show("Le masque est verifie");
                //textBox1.BackColor = Color.Green;
                label1.Visible = false;
            }
            else
            {
                //MessageBox.Show("Le masque ne correspond pas");
                //textBox1.BackColor = Color.Red;
                label1.Visible = true;
            }
        }
    }
}
