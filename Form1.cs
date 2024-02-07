using Frazioni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }       
        private void button3_Click(object sender, EventArgs e)
        {
            Fraction f1 = Fraction.Parse(textBox1.Text);
            Fraction f2= Fraction.Parse(textBox2.Text);
            label1.Text = f1.Somma(f2).ToString();

            textBox1.Text = f1.ToString();
            textBox2.Text = f2.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }
    }
}
