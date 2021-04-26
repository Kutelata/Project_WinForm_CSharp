using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafe.UI.Employee
{
    public partial class frmHome : Form
    {
        InternetCafeDataContext DB = new InternetCafeDataContext();

        public frmHome(string myVendorName)
        {
            InitializeComponent();
            txtVendorName.Text = myVendorName;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            DisplayAreaCombobox();
            cbArea.SelectedValue = 2;
            loadComputerByArea();
        }

        private void loadComputerByArea()
        {
            dgvComputerByArea.DataSource = DB.searchComputerByArea(1);
        }

        private void DisplayAreaCombobox()
        {
            cbArea.DataSource = DB.getAllArea();
            cbArea.DisplayMember = "name";
            cbArea.ValueMember = "entity_id";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvComputerinArea_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}
