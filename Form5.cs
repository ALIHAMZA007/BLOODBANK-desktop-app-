using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Net;
using System.Net.Mail;
using System.IO;
namespace bloodbanksystem
{
    public partial class Form5 : Form
    {
         string h = null;
        public Form5()
        {
            Thread obj = new Thread(new ThreadStart(SplashStart));
            obj.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            obj.Abort();
        }
         public void SplashStart()
        {
            Application.Run(new Form10());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 O = new Form1();
            O.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 OB = new Form2();
            OB.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 O = new Form2();
            O.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 O = new Form2();
            O.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form2 OBJ = new Form2();
            OBJ.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =(local) ; initial catalog =blood bank; integrated Security = True";
            con.Open();

            string query = "insert into LEAVES (MONTH,ID,NAME,DATEFROM,DATETILL) values('" + textBox17.Text + "','" + textBox16.Text +"','" + textBox15.Text + "','" + textBox14.Text + "','" + textBox27.Text + "')";

            if (textBox17.Text !=""&& textBox16.Text!= "" && textBox15.Text != "" && textBox14.Text != "" && textBox27.Text != "")
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

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form2 O = new Form2();
            O.Show();
            this.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form2 O = new Form2();
            O.Show();
            this.Hide();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Form1 O = new Form1();
            O.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =(local) ; initial catalog =blood bank; integrated Security = True";
            con.Open();

            string query = "insert into specialist(name,nicnumber,gender,adress,mobileno,email,joiningdate,salary)values ('" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";

            if (textBox2.Text != "" && comboBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                SqlCommand cmd = new SqlCommand(query, con);
                int x = cmd.ExecuteNonQuery();

                MessageBox.Show("Record has been saved");
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Dont leave any box Empty");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox25.Text = Convert.ToString(Convert.ToDouble(textBox23.Text) + Convert.ToDouble(textBox24.Text) + Convert.ToDouble(textBox30.Text));
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =(local) ; initial catalog =blood bank; integrated Security = True";
            con.Open();

            string query = "insert into SALARYCALCULATOR (DATEISSUED,ID,NAME,MONTH,ATTENDANCE,HRA,DA,GROSSSALARY,TOTALSALARY) values('" + textBox18.Text + "','" + textBox19.Text + "','" + textBox20.Text + "','" + textBox21.Text + "','" + textBox22.Text + "','" + textBox30.Text + "','" + textBox23.Text + "','" + textBox24.Text + "','" + textBox25.Text + "')";

            if (textBox18.Text != "" && textBox19.Text != "" && textBox20.Text != "" && textBox21.Text != "" && textBox22.Text != "" && textBox30.Text != "" && textBox23.Text != "" && textBox24.Text != "" && textBox25.Text != "")
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                SqlConnection obh = new SqlConnection("data source =(local) ; initial catalog =blood bank; integrated Security = True");
                SqlDataAdapter r = new SqlDataAdapter("select * from specialist  where specialistID LIKE '" + textBox9.Text + "'", obh);
                DataTable dt = new DataTable();
                r.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("search successfully");
            }
            else
            {
                MessageBox.Show("enter the valid id");
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =(local) ; initial catalog =blood bank; integrated Security = True";
            con.Open();

            string query = "insert into ATTENDANCE (DATE,NAME,ID,MONTH,ATTENDANCE) values('" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + comboBox2.Text + "')";

            if (textBox10.Text != "" && comboBox2.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "")
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

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox28.Text != "")
            {
                SqlConnection obh = new SqlConnection("data source =(local) ; initial catalog =blood bank; integrated Security = True");
                SqlDataAdapter r = new SqlDataAdapter("select * from ATTENDANCE  where NAME like '" + textBox28.Text + "'", obh);
                //SqlDataAdapter r = new SqlDataAdapter("select * from ATTENDANCE  where NAME ='" + textBox28.Text + "'", obh);
                DataTable dt = new DataTable();
                r.Fill(dt);
                dataGridView2.DataSource = dt;
                MessageBox.Show("search successfully");
            }
            else
            {
                MessageBox.Show("enter the NAME");
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox29.Text != "")
            {
                SqlConnection obh = new SqlConnection("data source =(local) ; initial catalog =blood bank; integrated Security = True");
                SqlDataAdapter r = new SqlDataAdapter("select * from LEAVES  where ID LIKE '" + textBox29.Text + "'", obh);
                DataTable dt = new DataTable();
                r.Fill(dt);
                dataGridView4.DataSource = dt;
                MessageBox.Show("search successfully");
            }
            else
            {
                MessageBox.Show("enter the valid ID");
            }
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (textBox26.Text != "")
            {
                SqlConnection obh = new SqlConnection("data source =(local) ; initial catalog =blood bank; integrated Security = True");
                SqlDataAdapter r = new SqlDataAdapter("select * from SALARYCALCULATOR  where DATEISSUED LIKE '" + textBox26.Text + "'", obh);
                DataTable dt = new DataTable();
                r.Fill(dt);
                dataGridView3.DataSource = dt;
                MessageBox.Show("search successfully");
            }
            else
            {
                MessageBox.Show("enter the valid ID");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SALARYCALCULATOR", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 25));
            e.Graphics.DrawString("DATE ISSUED", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 100));
            e.Graphics.DrawString("ID", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 150));
            e.Graphics.DrawString("NAME", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString("MONTH", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 250));
            e.Graphics.DrawString("ATTENDANCE", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 300));
            e.Graphics.DrawString("HRA", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 350));
            e.Graphics.DrawString("DA", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 400));
            e.Graphics.DrawString("GROSS SALARY", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 450));
            e.Graphics.DrawString("TOTAL SALARY", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 500));
            e.Graphics.DrawString("DATE OF PAY", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 550));
            //e.Graphics.DrawString("", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 600));
            // e.Graphics.DrawString("DESIGNATION", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 650));
            //e.Graphics.DrawString("BASIC SALARY", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 700));
            e.Graphics.DrawString(textBox18.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 100));
            e.Graphics.DrawString(textBox19.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 150));
            e.Graphics.DrawString(textBox20.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 200));
            e.Graphics.DrawString(textBox21.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 250));
            e.Graphics.DrawString(textBox22.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 300));
            e.Graphics.DrawString(textBox30.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 350));
            e.Graphics.DrawString(textBox23.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 400));
            e.Graphics.DrawString(textBox24.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 450));
            e.Graphics.DrawString(textBox25.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 500));
            e.Graphics.DrawString(textBox26.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 550));
            //e.Graphics.DrawString(textBox36.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 600));
            // e.Graphics.DrawString(textBox11.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 650));
            //e.Graphics.DrawString(textBox12.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 700));

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            h = @"C:\project.txt";
            FileStream fs = null;
            if (textBox37.Text != "")
            {
                if (!File.Exists(h))
                {
                    using (File.Create(h))
                    using (StreamWriter obj = new StreamWriter(h))
                    {
                        obj.Write(textBox37.Text);
                    }
                    MessageBox.Show("SAVED SUCCESSFULLY");
                }
                else
                {
                    using (StreamWriter obj = new StreamWriter(h))
                    {
                        obj.Write(textBox37.Text);
                    }
                    MessageBox.Show("SAVED SUCCESSFULLY");
                }

            }
            else
            {
                MessageBox.Show("Enter The Recipient Name");
            }
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            h = @"c:\project.txt";
            if (File.Exists(h))
            {
                using (StreamReader obj = new StreamReader(h))
                {
                    textBox37.Text = obj.ReadToEnd();
                }
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox31.Text != "" && textBox32.Text != "" && textBox33.Text != "" && textBox34.Text != "" && textBox35.Text != "" && textBox37.Text != "" && richTextBox2.Text != "")
                {
                    MailMessage mail = new MailMessage(textBox31.Text, textBox37.Text, textBox35.Text, richTextBox2.Text);
                    mail.Attachments.Add(new Attachment(textBox36.Text));
                    SmtpClient smtp = new SmtpClient(textBox32.Text);
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential(textBox33.Text, textBox34.Text);
                    smtp.EnableSsl = true;
                    //smtp.UseDefaultCredentials = false;
                    smtp.Send(mail);
                    MessageBox.Show("E-MAIL HAS BEN SENT SUCCESSFULLY");
                }
                else
                {
                    MessageBox.Show("Fill The Required Fields");

                }
            }
            catch(System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog obj = new OpenFileDialog();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                string picpath =obj.FileName.ToString();
                textBox36.Text=picpath;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 32)
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 32) ;
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 32)
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
             char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 32) ;
            {
                e.Handled = true;
            }
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            //textBox25.Text =Convert.ToString (Convert.ToDecimal(textBox23.Text) + Convert.ToDecimal(textBox24.Text) + Convert.ToDecimal(textBox30.Text));
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}