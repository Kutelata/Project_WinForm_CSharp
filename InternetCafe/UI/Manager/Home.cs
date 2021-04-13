using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafe.UI.Manager
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
           
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            Area a = new Area();
            a.TopLevel = false;
            mainPanel.Controls.Clear();
            a.Dock = DockStyle.Fill;
            a.Show();
            mainPanel.Controls.Add(a);
        }
    }
}
