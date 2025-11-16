using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username1 = textBox1.Text;
            string password1 = textBox2.Text;

            string user = "lance";
            string pass = "admin";

            if (username1 == user && password1 == pass)
            {
                MessageBox.Show("Login successfull");
            }
            else 
            {
                MessageBox.Show("Login failed!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FORGETPASS f2 = new FORGETPASS();
            f2.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
