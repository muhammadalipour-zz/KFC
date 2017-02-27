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
   
    public partial class main : Form
    {
        double total = 0;
        public main()
        {
            InitializeComponent();
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show(" Enter complete information ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Farhan\\Desktop\\KFC\\KFC\\KFC\\KFC.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string query = "insert into product(productid,productname,price,stockid) values( '" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("product no,price and stock id must be in integer type", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    return;
                }
                MessageBox.Show(" Data saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "" || textBox9.Text == "" || textBox11.Text == "" || textBox12.Text == "")
            {
                MessageBox.Show(" Enter complete information ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Farhan\\Desktop\\KFC\\KFC\\KFC\\KFC.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string query = "insert into stock(stockid,productname,quantity,supid) values( '" + textBox7.Text + "','" + textBox9.Text + "','" + textBox11.Text + "','" + textBox12.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("stock id, quantity andsupplier id  and stock id must be in integer type", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox7.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    return;
                }
                MessageBox.Show(" Data saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox7.Clear();
                textBox9.Clear();
                textBox11.Clear();
                textBox12.Clear();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show(" Enter complete information ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Farhan\\Desktop\\KFC\\KFC\\KFC\\KFC.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string querry = " UPDATE product SET price = '" + textBox10.Text + "' WHERE productid = '" + textBox8.Text + "'";
                SqlCommand cmd = new SqlCommand(querry, con);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("product id and Price must be in integer type", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox8.Clear();
                    textBox10.Clear();
                    return;
                }

                MessageBox.Show(" Data Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox8.Clear();
                textBox10.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show(" Enter bill id ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (checkBox1.Checked)
                {
                    total = total + (int.Parse(textBox13.Text) * 250);
                }
                if (checkBox2.Checked)
                {
                    total = total + (int.Parse(textBox14.Text) * 850);
                }
                if (checkBox3.Checked)
                {
                    total = total + (int.Parse(textBox15.Text) * 150);
                }
                textBox16.Text = total.ToString();
                total = 0;

        
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Farhan\\Desktop\\KFC\\KFC\\KFC\\KFC.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                string query = "insert into bill(billid,total) values( '" + textBox1.Text + "','" + textBox16.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Bill id no,quantity must be in integer type", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox13.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox1.Clear();
                    textBox16.Clear();
                    return;
                }
                MessageBox.Show(" Data saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox13.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox1.Clear();
                textBox16.Clear();
            }
            
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
        
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Farhan\\Desktop\\KFC\\KFC\\KFC\\KFC.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            string w = "SELECT productid, productname, price, stockid FROM product";
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
                
                
        }
  }

    }
}
    
    

