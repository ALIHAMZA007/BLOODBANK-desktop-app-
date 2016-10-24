using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bloodbanksystem
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 O = new Form2();
            O.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (comboBox1.Text == "LOCALITY")
                {
                    SqlConnection obh = new SqlConnection("data source =(local) ; initial catalog =blood bank; integrated Security = True");
                    obh.Open();
                    SqlDataAdapter r = new SqlDataAdapter("select * from APPROVEDBLOODLIST  where LOCALITY LIKE '" + textBox1.Text + "'", obh);
                    DataTable dt = new DataTable();
                    r.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlDataAdapter s = new SqlDataAdapter("select sum(Quantity) from APPROVEDBLOODLIST  where LOCALITY LIKE '" + textBox1.Text + "'", obh);
                    DataTable h = new DataTable();
                    s.Fill(h);
                    dataGridView2.DataSource = h;
                    MessageBox.Show("search successfully");

                  
                }
                else if (comboBox1.Text == "BLOODGROUP")
                {
                    SqlConnection obh = new SqlConnection("data source =(local) ; initial catalog =blood bank; integrated Security = True");
                    obh.Open();
                    SqlDataAdapter r = new SqlDataAdapter("select * from APPROVEDBLOODLIST  where BLOODGROUP LIKE '" + textBox2.Text + "'", obh);
                    DataTable dt = new DataTable();
                    r.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlDataAdapter s = new SqlDataAdapter("select sum(QUANTITY) from APPROVEDBLOODLIST  where BLOODGROUP LIKE '" + textBox2.Text + "'", obh);
                    DataTable h = new DataTable();
                    s.Fill(h);
                    dataGridView2.DataSource = h;


                    MessageBox.Show("search successfully");


                }
                else if (comboBox1.Text == "BOTH")
                {
                    SqlConnection obh = new SqlConnection("data source =(local) ; initial catalog =blood bank; integrated Security = True");
                    obh.Open();
                    SqlDataAdapter r = new SqlDataAdapter("select * from APPROVEDBLOODLIST  where BLOODGROUP LIKE '" + textBox2.Text + "'AND LOCALITY LIKE '" + textBox1.Text + "'  ", obh);
                    DataTable dt = new DataTable();
                    r.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlDataAdapter s = new SqlDataAdapter("select sum(QUANTITY) from APPROVEDBLOODLIST  where BLOODGROUP LIKE '" + textBox2.Text + "'AND LOCALITY LIKE '" + textBox1.Text + "'  ", obh);
                    DataTable h = new DataTable();
                    s.Fill(h);
                    dataGridView2.DataSource = h;

                    MessageBox.Show("search successfully");


                }
                else
                {
                    MessageBox.Show("INVALID KEY ENTER");
                }
            }
            else
            {
                MessageBox.Show ("Enter THE LOCALITY OR BLOODGROUP for Search");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}