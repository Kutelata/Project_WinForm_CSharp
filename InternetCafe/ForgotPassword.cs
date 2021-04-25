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
        InternetCafeDataContext DB = new InternetCafeDataContext();
        Random rnd = new Random();
        public int code;
        public string myEmail;

        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void mail(string myEmail)
        {
            code = rnd.Next(123123, 999999);
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("hoangcaolong2311@gmail.com");
                msg.To.Add(new MailAddress(myEmail));
                msg.Subject = "Change Password";
                msg.Body = "Write this given code on text box\n" + code + "\nThank you!";
                msg.Priority = MailPriority.High;

                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("hoangcaolong2311@gmail.com", "Longdaica123");
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(msg);

                MessageBox.Show("Email has been sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show("err: " + ex.Message);
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            var checkEmail = DB.users.FirstOrDefault(x => x.email == txtEnterEmail.Text);
            if (checkEmail != null)
            {
                lblNextStep1.Visible = true;
                imgNextStep1.Visible = true;

                txtDigitCode.Enabled = true;
                btnNextStep.Enabled = true;
                btnSendMailAgain.Enabled = true;
                btnSendMail.Enabled = false;

                mail(txtEnterEmail.Text.ToString());
                myEmail = txtEnterEmail.Text.ToString();
            }
            else
            {
                MessageBox.Show("This email is not exisit in the given data");
            }
        }

        private void btnSendMailAgain_Click(object sender, EventArgs e)
        {
            var checkEmail = DB.users.FirstOrDefault(x => x.email == txtEnterEmail.Text);
            if (checkEmail != null)
            {
                mail(txtEnterEmail.Text.ToString());
                myEmail = txtEnterEmail.Text.ToString();
            }
            else
            {
                MessageBox.Show("This email is not exisit in the given data");
            }
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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var findEmail = DB.users.SingleOrDefault(x => x.email == myEmail);
            if (txtNewPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Not null !");
            }
            else
            {
                if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    findEmail.password = txtNewPassword.Text;
                    DB.SubmitChanges();
                    MessageBox.Show("Save Success !");
                }
                else
                {
                    MessageBox.Show("Not same !");
                }
            }
            
        }
    }
}
