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
    }
}
