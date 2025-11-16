using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace loginform
{
    public partial class FORGETPASS : Form
    {
        public FORGETPASS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                

                Random rnd = new Random();
                int code = rnd.Next(1000, 9999);
                Class1.Code = code;
                Class1.CodeExpiration = DateTime.Now.AddMinutes(1);

                MessageBox.Show("Your verification number is " + code);

                Class1.Code = code;

                String toEmail = txtemail.Text;
                string fromEmail = "drs.helpdesk.team@gmail.com"; 
                string appPassword = "pflgwwdxcypwvxmn"; 
                string subject = "Your Verification Code";
                string body = $@"
You requested a verification code to reset your password.

Verification Code: **{code}**

This code will expire in 5 minutes from the time it was sent.
If it expires, please request a new verification code.


For your security, do not share this code with anyone.
Our support team will never ask for your verification code or password.

If you did not request this action, you may safely ignore this email.

------------------------------
DRS Helpdesk Team
Automated System Notification
Please do not reply to this email.
";

                MailMessage message = new MailMessage(fromEmail, toEmail, subject, body);
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail, appPassword);
                smtp.EnableSsl = true;

                smtp.Send(message);
                MessageBox.Show("Verification code sent! Check your Gmail.");
                verify f3 = new verify();
                f3.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Error sending email: ");
                
            }
            
        }
    }
}
