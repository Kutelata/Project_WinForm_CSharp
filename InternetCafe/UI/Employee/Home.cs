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
        DateTime now = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
        private int computerId;

        public frmHome(string myVendorName)
        {
            InitializeComponent();
            txtVendorName.Text = myVendorName;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            DisplayAreaCombobox();
            loadComputerByArea();
        }

        private void loadComputerByArea()
        {
            dgvComputerByArea.DataSource = DB.searchComputerByArea(Convert.ToInt32(cbArea.SelectedIndex + 1), txtSearchComputer.Text);
        }

        private void DisplayAreaCombobox()
        {
            cbArea.DataSource = DB.getAllArea();
            cbArea.DisplayMember = "name";
            cbArea.ValueMember = "entity_id";
        }

        private void dgvComputerinArea_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvComputerByArea.CurrentRow != null)
            {
                var row = dgvComputerByArea.CurrentRow;
                computerId = Convert.ToInt32(row.Cells["computer_id"].Value);
            }
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadComputerByArea();
        }

        private void txtSearchComputer_TextChanged(object sender, EventArgs e)
        {
            loadComputerByArea();
        }

        private void tsmTurnOn_Click(object sender, EventArgs e)
        {
            var c = DB.computers.SingleOrDefault(x => x.entity_id == computerId);
            if (c.status == false)
            {
                c.status = true;
                order_computer oc = new order_computer();
                oc.computer_id = c.entity_id;
                oc.start_time = now;
                DB.order_computers.InsertOnSubmit(oc);
                DB.SubmitChanges();
                loadComputerByArea();
            }
            else
            {
                MessageBox.Show("Máy tính đang hoạt động !");
            }
        }

        private void tsmOrderFood_Click(object sender, EventArgs e)
        {
            var c = DB.computers.SingleOrDefault(x => x.entity_id == computerId);
            if (c.status == true)
            {
                OrderFoodByComputer ofbc = new OrderFoodByComputer(computerId);
                ofbc.ShowDialog();
                ofbc.Focus();
            }
            else
            {
                MessageBox.Show("Chưa bật máy !");
            }
        }

        private void tsmPay_Click(object sender, EventArgs e)
        {

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


    }
}
