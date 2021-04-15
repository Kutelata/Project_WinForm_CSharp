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
        InternetCafeDataContext DB = new InternetCafeDataContext();
        private int areaId;
        public frmHome()
        {
            InitializeComponent();
        }
        private void loadArea()
        {
            dgvArea.DataSource = DB.getAllArea();
        }

        private void btnAddArea_Click(object sender, EventArgs e)
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

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            loadArea();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnSaveArea_Click(object sender, EventArgs e)
        {
            // Find object to edit
            var a = DB.areas.SingleOrDefault(x => x.entity_id == areaId);
            // Get data
            a.name = txtNameArea.Text;
            a.price = Convert.ToDouble(txtPriceArea.Text);
            // Save
            DB.SubmitChanges();
            loadArea();
        }

        private void btnDeleteArea_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?","Delete Area",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
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
    }
}
