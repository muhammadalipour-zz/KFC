using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KFC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (textBox1.Text == "paracha" && textBox2.Text == "usman" && comboBox1.Text=="Administrator")
                {
                    this.Hide();
                    ADM a = new ADM();
                    a.Show();
                }

                else if (textBox1.Text == "employee" && textBox2.Text == "123" && comboBox1.Text == "Operator")
                {
                    this.Hide();
                    main m = new main();
                    m.Show();
                }

                else
                {
                    MessageBox.Show(" Invalid Username or Password ", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();

                }
               
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
