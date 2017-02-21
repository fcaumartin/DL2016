using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evenements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("B1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("B2");

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("TextChanged " + textBox1.Text);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("Enter");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Console.WriteLine("Leave");
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            Console.WriteLine("MouseEnter");
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            Console.WriteLine("MouseLeave");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("KeyDown");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("KeyPress");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine("KeyUp");
        }
    }
}
