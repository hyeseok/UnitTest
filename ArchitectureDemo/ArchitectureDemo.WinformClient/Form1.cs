using ArchitectureDemo.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArchitectureDemo.WinformClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox.Text;

            Greeting greeting = new Greeting();
            string text = greeting.SayHello(name);

            MessageBox.Show($"Hello {name}!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
