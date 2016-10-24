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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 O = new Form2();
            O.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 O = new Form2();
            O.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =(local) ; initial catalog =blood bank; integrated Security = True";
            con.Open();

            string query = "insert into ACCEPTER (NAME,NICNUMBER,GENDER,BLOODGROUP,ADDRESS,MOBILENO,DATE,LOCALITY) values('" + textBox8.Text + "','" + textBox9.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox6.Text + "','" + textBox13.Text + "')";

            if (textBox8.Text != "" && comboBox1.Text != "" && textBox9.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox6.Text != "" && textBox13.Text != "" && comboBox2.Text != "")
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record has been saved");
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Dont leave any box Empty");
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection obj = new SqlConnection();
                obj.ConnectionString = "data source =(local) ; initial catalog =blood bank; integrated Security = True";
                obj.Open();
                string query = "Update ACCEPTER SET NAME = '" + textBox8.Text + "', NICNUMBER = '" + textBox9.Text + "', GENDER = '" + comboBox1.Text + "', BLOODGROUP ='" + comboBox2.Text + "', ADDRESS='" + textBox11.Text + "',MOBILENO='" + textBox12.Text + "', DATE ='" + textBox6.Text + "', LOCALITY ='" + textBox13.Text;

                SqlCommand cmd = new SqlCommand(query, obj);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Donar's Detail have been succesfully updated");
                //TxtBoxClear();
            }
            catch
            {
                MessageBox.Show("ANY DATA HAS NOT BEEN UPDATED");

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                SqlConnection obh = new SqlConnection("data source =(local) ; initial catalog =blood bank; integrated Security = True");
                SqlDataAdapter r = new SqlDataAdapter("select * from ACCEPTER  where ACCEPTERID LIKE '" + textBox10.Text + "'", obh);
                DataTable dt = new DataTable();
                r.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("search successfully");
            }
            else
            {
                MessageBox.Show("enter the valid ID");
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}