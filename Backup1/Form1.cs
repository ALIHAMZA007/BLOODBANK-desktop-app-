using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bloodbanksystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string USERNAME = "UBIT";
            string PASSWORD = "123";
            if (textBox1.Text == USERNAME && textBox2.Text == PASSWORD)
            {
                Form2 o = new Form2();
                o.Show();
                this.Hide();
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("PLEASE ENTER THE PASSWORD AND USERNAME");
            }
            else
            {
                MessageBox.Show("USERNAME OR PASSWORD IS INCORRECT");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string USERNAME = "FAST";
            string PASSWORD = "456";
            if (textBox3.Text == USERNAME && textBox4.Text == PASSWORD)
            {
                Form5 OBJ = new Form5();
                OBJ.Show();
                this.Hide();
            }
            else if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("PLEASE ENTER THE USERNAME AND PASSWORD");
            }
            else
            {
                MessageBox.Show(" USERNAME OR PASSWORD IS INCORRECT");
            }
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}