using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace KFC
{
    public partial class ADM : Form
    {
        public ADM()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show(" Enter complete information ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Farhan\\Desktop\\KFC\\KFC\\KFC\\KFC.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                DateTime hiredate = dateTimePicker1.Value;
                string query = "insert into employee(empno,name,gender,contactno,job,salary,adress,hiredate) values( '" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + hiredate + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {

                    MessageBox.Show("Employee no And Salary must be in integer type", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
   
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        return;
                }
                
                    MessageBox.Show(" Data saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ADM_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "" || textBox17.Text == "")
            {
                MessageBox.Show(" Enter complete information ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Farhan\\Desktop\\KFC\\KFC\\KFC\\KFC.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                DateTime hiredate = dateTimePicker1.Value;
                string query = "insert into supplier(supid,name,productname,compony,contactno) values( '" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                
                    cmd.ExecuteNonQuery();
                
                   
                
                MessageBox.Show(" Data saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox13.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox16.Clear();
                textBox17.Clear();
            }
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox18.Text == "" || textBox19.Text == "")
            {
                MessageBox.Show(" Enter complete information ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.Visible = true;
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Farhan\\Desktop\\KFC\\KFC\\KFC\\KFC.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string w = " SELECT empno, name, gender, contactno, job, salary, adress, hiredate FROM employee WHERE (empno = '" + textBox18.Text + "') AND (name = '" + textBox19.Text + "')";
                SqlDataAdapter adapter = new SqlDataAdapter(w, con);
                DataTable t = new DataTable("table");
                try
                {
                    adapter.Fill(t);
                    dataGridView1.DataSource = t;
                    con.Close();
                }
                catch
                {
                    dataGridView1.Visible = false;
                    textBox18.Clear();
                    textBox19.Clear();
                    MessageBox.Show("Employee No must be in integer type","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
          

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox18.Clear();
            textBox19.Clear();
            dataGridView1.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            textBox20.Clear();
            textBox21.Clear();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox20.Text == "" || textBox21.Text == "")
            {
                MessageBox.Show(" Enter complete information ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView2.Visible = true;
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Farhan\\Desktop\\KFC\\KFC\\KFC\\KFC.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string w = "SELECT supid, name, productname, contactno, compony FROM supplier WHERE (supid = '" + textBox20.Text + "') AND (name ='" + textBox21.Text + "')";
                SqlDataAdapter adapter = new SqlDataAdapter(w, con);
                DataTable t = new DataTable("table");
                try
                {
                    adapter.Fill(t);
                    dataGridView2.DataSource = t;
                    con.Close();
                }
                catch
                {
                    dataGridView2.Visible = false;
                    textBox20.Clear();
                    textBox21.Clear();
                    MessageBox.Show("Supplier No must be in integer type", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (textBox22.Text == "" || textBox23.Text == "")
            {
                MessageBox.Show(" Enter complete information ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Farhan\\Desktop\\KFC\\KFC\\KFC\\KFC.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                DateTime hiredate = dateTimePicker1.Value;
                string querry = " delete from employee where empno = '" + textBox22.Text + "' and name = '" + textBox23.Text + "'";
                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Data Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox22.Clear();
                textBox23.Clear();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (textBox24.Text == "" || textBox25.Text == "")
            {
                MessageBox.Show(" Enter complete information ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Farhan\\Desktop\\KFC\\KFC\\KFC\\KFC.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                DateTime hiredate = dateTimePicker1.Value;
                string querry = " delete from supplier where supid = '" + textBox24.Text + "' and name = '" + textBox25.Text + "'";
                SqlCommand cmd = new SqlCommand(querry, con);
               
                    cmd.ExecuteNonQuery();
                
                
                MessageBox.Show(" Data Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox22.Clear();
                textBox23.Clear();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox26.Text == "" || textBox27.Text == "" || textBox18.Text=="" || textBox19.Text=="")
            {
                MessageBox.Show(" Enter complete information ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Farhan\\Desktop\\KFC\\KFC\\KFC\\KFC.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                DateTime hiredate = dateTimePicker1.Value;
                string querry = " UPDATE employee SET job = '" + textBox26.Text + "' , salary = '" + textBox27.Text + "'WHERE empno = '" + textBox18.Text + "' AND name='" + textBox19.Text + "'";
                SqlCommand cmd = new SqlCommand(querry, con);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Employee No and Salary must be in integer type", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox26.Clear();
                    textBox27.Clear();
                    textBox18.Clear();
                    textBox19.Clear();
                    return;
                }

                MessageBox.Show(" Data Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox26.Clear();
                textBox27.Clear();
                textBox18.Clear();
                textBox19.Clear();
            }
        }
    }
}
