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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 O = new Form2();
            O.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                SqlConnection obh = new SqlConnection("data source =(local) ; initial catalog =blood bank; integrated Security = True");
                SqlDataAdapter r = new SqlDataAdapter("select * from BLOODMATCHING  where MATCHINGDATE LIKE '" + textBox10.Text + "'", obh);
                DataTable dt = new DataTable();
                r.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("search successfully");
            }
            else
            {
                MessageBox.Show("enter the valid nic number");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection obj = new SqlConnection();
                obj.ConnectionString = "data source =(local) ; initial catalog =blood bank; integrated Security = True";
                obj.Open();
                string query = "Update DONAR SET   DONARID = '" + textBox1.Text + "', DONARNAME = '" + textBox2.Text + "',DONARBLOODGROUP = '" + comboBox1.Text + "',DONARADDRESS='" + textBox3.Text + "',BLOODQUANTITY='" + textBox4.Text + "',RECIPIENTID ='" + textBox6.Text + "',RECIPIENTNAME='" + textBox7.Text + "',RECIPIENTBLOODGROUP='" + comboBox2.Text + "',RECIPIENTADDRESS='" + textBox8.Text + "' ,EXPIRYDATE='" + textBox5.Text + "' WHERE MATCHINGDATE = " + textBox9.Text;

                SqlCommand cmd = new SqlCommand(query, obj);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Donar's Detail have been succesfully updated");
                //TxtBoxClear();
            }
            catch
            {
                MessageBox.Show("any data has Not been UPDATED");

            }
        }


        private void SAVE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =(local) ; initial catalog =blood bank; integrated Security = True";
            con.Open();

            string query = "insert into BLOODMATCHING (DONARID,DONARNAME,DONARBLOODGROUP,DONARADDRESS,BLOODQUANTITY,RECIPIENTID,RECIPIENTNAME,RECIPIENTBLOODGROUP,RECIPIENTADDRESS,EXPIRYDATE,MATCHINGDATE) values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox2.Text + "','" + textBox8.Text + "','" + textBox5.Text + "','" + textBox9.Text + "' )";

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && comboBox1.Text != "" && comboBox2.Text != "")
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record has been saved");
                ///textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Dont leave any box Empty");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}