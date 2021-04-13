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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DB.Check_Login(txtUser.ToString(), txtPassword.ToString()).Any())
            {
                if (true)
                {

                }
            }
            
            UI.Manager.frmHome homeManager = new UI.Manager.frmHome();
            UI.Employee.Home homeEmployee = new UI.Employee.Home();
           // homeManager.Show();
           // homeEmployee.Show();
           // this.Hide();
           // this.Close();
        }

        private void linkFindPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
