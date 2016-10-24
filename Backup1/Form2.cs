using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace bloodbanksystem
{
    public partial class Form2 : Form
    {
            
        public Form2()
        {
            Thread obj = new Thread(new ThreadStart(SplashStart));
            obj.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            obj.Abort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form5 OB = new Form5();
            OB.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form7 o = new Form7();
            o.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form6 OBJ = new Form6();
            OBJ.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 o = new Form1();
            o.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public void SplashStart()
        {
            Application.Run(new Form8());
        }
    }
}