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
    public partial class verify : Form
    {
        public verify()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void verifybtn_Click(object sender, EventArgs e)
        {
            // 1. Check if expired first
            if (DateTime.Now > Class1.CodeExpiration)
            {
                MessageBox.Show("Verification code has expired. Please request a new one.");
                return;
            }

            // 2. Check if code is correct
            if (txtcode.Text == Class1.Code.ToString())
            {
                MessageBox.Show("Code verified!");
                resetpass reset = new resetpass();
                reset.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect code");
            }
        }
    }
}
