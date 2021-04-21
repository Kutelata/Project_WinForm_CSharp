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

        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
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

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
