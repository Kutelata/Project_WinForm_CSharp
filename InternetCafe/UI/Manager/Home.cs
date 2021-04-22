using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafe.UI.Manager
{
    public partial class frmHome : Form
    {
        InternetCafeDataContext DB = new InternetCafeDataContext();
        private int areaId;
        private int computerId;

        public frmHome(string myAdminName)
        {
            InitializeComponent();
            txtAdminName.Text = myAdminName;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            loadArea();
            mainTabControl.SelectedTab = mainTabControl.TabPages["homeTabPage"];
        }

        private void loadArea()
        {
            dgvArea.DataSource = DB.getAllArea().ToList();
        }

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            if (txtNameArea.Text == "" || txtPriceArea.Text == "")
            {
                MessageBox.Show("Fields not allow null !");
            }
            else
            {
                var checkAreaName = DB.areas.FirstOrDefault(x => x.name == txtNameArea.Text);
                if (checkAreaName == null)
                {
                    // Get infomation on form to creat new data
                    area a = new area();
                    a.name = txtNameArea.Text;
                    a.price = Convert.ToDouble(txtPriceArea.Text);
                    // Insert
                    DB.areas.InsertOnSubmit(a);
                    // Save
                    DB.SubmitChanges();
                    loadArea();
                    MessageBox.Show("Create Success !");
                }
                else
                {
                    MessageBox.Show("Area's name must be unique!");
                }
            }
        }

        private void btnSaveArea_Click(object sender, EventArgs e)
        {
            if (txtNameArea.Text == "" || txtPriceArea.Text == "")
            {
                MessageBox.Show("Fields not allow null !");
            }
            else
            {
                try
                {
                    // Find object to edit
                    var a = DB.areas.SingleOrDefault(x => x.entity_id == areaId);
                    // Get data
                    a.name = txtNameArea.Text;
                    a.price = Convert.ToDouble(txtPriceArea.Text);
                    // Save
                    DB.SubmitChanges();
                    loadArea();
                    MessageBox.Show("Save Success !");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Area's name must be unique!");
                }
                
            }
            
        }

        private void btnDeleteArea_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Delete Area", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Find object to edit
                var a = DB.areas.SingleOrDefault(x => x.entity_id == areaId);
                // Delete
                DB.areas.DeleteOnSubmit(a);
                // Save
                DB.SubmitChanges();
                loadArea();
            }
        }

        private void btnSearchArea_Click(object sender, EventArgs e)
        {
            dgvArea.DataSource = DB.searchArea(txtSearchArea.Text);
        }

        private void dgvArea_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArea.CurrentRow != null)
            {
                var row = dgvArea.CurrentRow;
                areaId = Convert.ToInt32(row.Cells["area_id"].Value);
                txtNameArea.Text = row.Cells["area_name"].Value.ToString();
                txtPriceArea.Text = row.Cells["area_price"].Value.ToString();
            }
        }

        private void txtPriceArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
