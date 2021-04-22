using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafe
{
    public partial class frmLogin : Form
    {
        InternetCafeDataContext DB = new InternetCafeDataContext();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );

        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var checkUser = DB.getUser(loginValidate.myTextBox, passValidate.myTextBox).FirstOrDefault();
                if (checkUser != null)
                {
                    if (checkUser.name == "admin")
                    {
                        MessageBox.Show("Welcome Admin " + checkUser.firstName.ToString() + " " + checkUser.lastName.ToString());
                        this.Hide();
                        UI.Manager.frmHome adminHome = new UI.Manager.frmHome(checkUser.firstName.ToString() + " " + checkUser.lastName.ToString());
                        adminHome.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Welcome Vendor " + checkUser.firstName.ToString() + " " + checkUser.lastName.ToString());
                        this.Hide();
                        UI.Employee.frmHome empHome = new UI.Employee.frmHome();
                        empHome.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Account or password is not exist");
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var checkUser = DB.getUser(loginValidate.myTextBox, passValidate.myTextBox).FirstOrDefault();
            if (checkUser != null)
            {
                if (checkUser.name == "admin")
                {
                    MessageBox.Show("Welcome Admin " + checkUser.firstName.ToString() + " " + checkUser.lastName.ToString());
                    this.Hide();
                    UI.Manager.frmHome adminHome = new UI.Manager.frmHome(checkUser.firstName.ToString() + " " + checkUser.lastName.ToString());
                    adminHome.ShowDialog();
                    this.Close();
                    // adminHome.Closed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Welcome Vendor " + checkUser.firstName.ToString() + " " + checkUser.lastName.ToString());
                    this.Hide();
                    UI.Employee.frmHome empHome = new UI.Employee.frmHome();
                    empHome.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Account or password is not exist");
            }
        }

        private void linkFindPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.ShowDialog();
            fp.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
