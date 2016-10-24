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
    public partial class Form3 : Form
    {
        public Form3()
        {

            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 OBJ = new Form2();
            OBJ.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 OBJ = new Form2();
            OBJ.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 OBJ = new Form2();
            OBJ.Show();
            this.Hide();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 OB = new Form2();
            OB.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form2 OBJ = new Form2();
            OBJ.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form2 OBJ = new Form2();
            OBJ.Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form2 OBJ = new Form2();
            OBJ.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =(local) ; initial catalog =blood bank; integrated Security = True";
            con.Open();

            string query = "insert into DONAR(NICNUMBER,NAME,ADDRESS,AGE,GENDER,BLOODGROUP,MOBILENO,EMAIL,DATE) values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox34.Text + "')";

            if (textBox2.Text != "" && comboBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && Class1.chechforemail(textBox6.Text.ToString()))
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                SqlConnection obh = new SqlConnection("data source =(local) ; initial catalog =blood bank; integrated Security = True");
                SqlDataAdapter r = new SqlDataAdapter("select * from DONAR  where DONARID LIKE '" + textBox7.Text + "'", obh);
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



        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection obj = new SqlConnection();
                obj.ConnectionString = "data source =(local) ; initial catalog =blood bank; integrated Security = True";
                obj.Open();
                string query = "Update DONAR SET NICNUMBER = '" + textBox2.Text + "', NAME = '" + textBox3.Text + "',ADDRESS = '" + textBox4.Text + "',AGE='" + comboBox2.Text + "',GENDER='" + comboBox3.Text + "',BLOODGROUP='" + comboBox1.Text + "',MOBILENO='" + textBox5.Text + "',EMAIL='" + textBox6.Text + "',DATE='" + textBox34.Text + "' WHERE DONARID = " + textBox1.Text;

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

        private void button14_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =(local) ; initial catalog =blood bank; integrated Security = True";
            con.Open();

            string query = "insert into BLOODEXAM(DATE,DONARNAME,HIV,HEPATITISB,HEPATITISC,PH,CHAGASDISEASE,SYPILIS,WESTNILEVIRUS,EXAMINEDBY) values('" + textBox17.Text + "','" + textBox18.Text + "','" + textBox20.Text + "','" + textBox21.Text + "','" + textBox22.Text + "','" + textBox23.Text + "','" + textBox24.Text + "','" + textBox25.Text + "','" + textBox26.Text + "','" + textBox36.Text + "' )";

            if (textBox17.Text != "" && textBox18.Text != "" && textBox20.Text != "" && textBox21.Text != "" && textBox22.Text != "" && textBox23.Text != "" && textBox24.Text != "" && textBox25.Text != "" && textBox26.Text != "" && textBox36.Text != "")
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

        private void button17_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =(local) ; initial catalog =blood bank; integrated Security = True";
            con.Open();

            string query = "insert into APPROVEDBLOODLIST(BLOODNUMBER,DONAR,BLOODGROUP,LOCALTY,QUANTITY,EXPIRYDATE) values('" + textBox27.Text + "','" + textBox29.Text + "','" + textBox30.Text + "','" + textBox31.Text + "','" + textBox32.Text + "','" + textBox33.Text + "' )";

            if (textBox27.Text != "" && textBox29.Text != "" && textBox30.Text != "" && textBox31.Text != "" && textBox32.Text != "" && textBox33.Text != "")
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

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =(local) ; initial catalog =blood bank; integrated Security = True";
            con.Open();

            string query = "insert into MEDICALEXAM (DONARNAME,NICNUMBER,BLOODGROUP,AGE,WEIGHT,BLOODPRESSURE,DIABETICS,RECENTSURGERY,PRIONDISEASE,FERRITINLEVEL,HEARTLUNGDISEASE,BACTRIALDISEASE,LASTBLOODDONATES,PARASITICDISEASE) values('" + textBox9.Text + "','" + textBox10.Text + "','" + comboBox4.Text + "','" + textBox37.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + comboBox6.Text + "','" + comboBox7.Text + "','" + textBox14.Text + "','" + comboBox8.Text + "','" + comboBox9.Text + "','" + textBox15.Text + "','" + comboBox10.Text + "')";

            if (textBox9.Text != "" && comboBox4.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox37.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "" && comboBox6.Text != "" && comboBox7.Text != "" && comboBox8.Text != "" && comboBox9.Text != "" && comboBox10.Text != "")
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

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            if (textBox16.Text != "")
            {
                SqlConnection obh = new SqlConnection("data source =(local) ; initial catalog =blood bank; integrated Security = True");
                SqlDataAdapter r = new SqlDataAdapter("select * from MEDICALEXAM  where DONARID LIKE '" + textBox16.Text + "'", obh);
                DataTable dt = new DataTable();
                r.Fill(dt);
                dataGridView2.DataSource = dt;
                MessageBox.Show("search successfully");
            }
            else
            {
                MessageBox.Show("enter the valid ID");
            }
        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("BLOODEXAM", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 25));
            e.Graphics.DrawString("DONAR DATE", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 100));
            e.Graphics.DrawString("DONAR NAME", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 150));
            e.Graphics.DrawString("DONAR ID", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString("HIV", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 250));
            e.Graphics.DrawString("HEPATITIS B", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 300));
            e.Graphics.DrawString("HEPATITIS C", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 350));
            e.Graphics.DrawString("PH", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 400));
            e.Graphics.DrawString("CHAGAS DISEASE", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 450));
            e.Graphics.DrawString("SYPILIS", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 500));
            e.Graphics.DrawString("WEST NILE VIRUS", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 550));
            e.Graphics.DrawString("EXAMINED BY", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 600));
            // e.Graphics.DrawString("DESIGNATION", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 650));
            //e.Graphics.DrawString("BASIC SALARY", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 700));
            e.Graphics.DrawString(textBox17.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 100));
            e.Graphics.DrawString(textBox18.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 150));
            e.Graphics.DrawString(textBox19.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 200));
            e.Graphics.DrawString(textBox20.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 250));
            e.Graphics.DrawString(textBox21.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 300));
            e.Graphics.DrawString(textBox22.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 350));
            e.Graphics.DrawString(textBox23.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 400));
            e.Graphics.DrawString(textBox24.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 450));
            e.Graphics.DrawString(textBox25.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 500));
            e.Graphics.DrawString(textBox26.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 550));
            e.Graphics.DrawString(textBox36.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 600));
            // e.Graphics.DrawString(textBox11.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 650));
            //e.Graphics.DrawString(textBox12.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 700));

        }

        private void button20_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();


        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("MEDICALEXAM", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 25));
            e.Graphics.DrawString("DONAR NAME", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 100));
            e.Graphics.DrawString("NICNUMBER", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 150));
            e.Graphics.DrawString("BLOODGROUP", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString("AGE", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 250));
            e.Graphics.DrawString("WEIGHT", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 300));
            e.Graphics.DrawString("BLOODPRESSURE", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 350));
            e.Graphics.DrawString("DIABETICS", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 400));
            e.Graphics.DrawString("RECENTSURGERY", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 450));
            e.Graphics.DrawString("PRIONDISEASE", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 500));
            e.Graphics.DrawString("FERRITINLEVEL", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 550));
            e.Graphics.DrawString("HEARTLUNGDISEASE", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 400));
            e.Graphics.DrawString("BACTRIALDISEASE", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 650));
            e.Graphics.DrawString("PARASITICDISEASE", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 700));
            //e.Graphics.DrawString(textBox8.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 100));
            e.Graphics.DrawString(textBox9.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 150));
            e.Graphics.DrawString(textBox10.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 200));
            e.Graphics.DrawString(comboBox4.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 250));
            e.Graphics.DrawString(textBox37.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 300));
            e.Graphics.DrawString(textBox11.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 350));
            e.Graphics.DrawString(textBox12.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 400));
            e.Graphics.DrawString(textBox13.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 450));
            e.Graphics.DrawString(comboBox6.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 500));
            e.Graphics.DrawString(comboBox7.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 550));
            e.Graphics.DrawString(textBox14.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 600));
            e.Graphics.DrawString(comboBox8.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 650));
            e.Graphics.DrawString(comboBox9.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 700));
            e.Graphics.DrawString(textBox15.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 700));
            e.Graphics.DrawString(comboBox10.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 700));

        }

        private void PRINT_Click(object sender, EventArgs e)
        {
            printDocument2.Print();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog2.Document = printDocument2;
            printPreviewDialog2.ShowDialog();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 32)
            {
                e.Handled = true;
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && ch != 8 && ch != 46 && ch != 32 && ch != 109)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tabPage1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

            //char ch = e.KeyChar;
            //if (!char.IsLetterOrDigit(ch) && ch != 8 && ch != 46 && ch!=189 && ch!=16)

            //{
            // e.Handled = true;

            //}
            
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox35_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 32)
            {
                e.Handled = true;
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

        private void textBox37_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && ch != 8 && ch != 46 && ch != 32 && ch != 109)
            {
                e.Handled = true;
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 32)
            {
                e.Handled = true;
            }
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox29_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 32)
            {
                e.Handled = true;
            }
        }

        private void textBox32_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 32)
            {
                e.Handled = true;
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox36_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 32)
            {
                e.Handled = true;
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }
    }
}






            
