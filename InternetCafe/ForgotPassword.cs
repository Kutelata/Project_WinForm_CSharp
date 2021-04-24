using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafe
{
    public partial class frmForgotPassword : Form
    {
        Random rnd = new Random();
        public int code;

        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void mail()
        {

            code = rnd.Next(123123, 999999);
            const string p = "sent password";

            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("Sent email");

            //Enter your email blow and also change in database too

            message.To.Add(new MailAddress("receive email"));
            message.Subject = "Change password";
            message.Body = "Write this given code on text box\n" + code + "\nThank you!";

            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("sent email", p);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
            MessageBox.Show("Email has been sent");
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {

        }

        private void btnSendMailAgain_Click(object sender, EventArgs e)
        {
            mail();
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            if (code.ToString() == txtDigitCode.Text)
            {
                lblNextStep2.Visible = true;
                imgNextStep2.Visible = true;

                txtConfirmPassword.Enabled = true;
                txtNewPassword.Enabled = true;
                btnChangePassword.Enabled = true;
                btnNextStep.Enabled = false;
                btnSendMailAgain.Enabled = false;
            }

            else
            {
                MessageBox.Show("Code doesn't Match");
            }
        }
    }
}
