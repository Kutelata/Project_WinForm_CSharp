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
        private int foodId;
        private int myId;

        public frmHome(string myAdminName, int myId)
        {
            InitializeComponent();
            txtAdminName.Text = myAdminName;
            this.myId = myId;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            loadArea();
            loadComputer();
            loadFood();
            loadUser();
            DisplayAreaCombobox();
            DisplayFoodTypeCombobox();
            DisplayRoleCombobox();
            mainTabControl.SelectedTab = mainTabControl.TabPages["homeTabPage"];
        }

        // AREA
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
                    DisplayAreaCombobox();
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
                    DisplayAreaCombobox();
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
            var checkComputer = DB.deleteArea().FirstOrDefault(x => x.entity_id == areaId);
            if (MessageBox.Show("Are you sure ?", "Delete Area", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (checkComputer.count_computer == 0)
                {
                    // Find object to edit
                    var a = DB.areas.SingleOrDefault(x => x.entity_id == checkComputer.entity_id);
                    // Delete
                    DB.areas.DeleteOnSubmit(a);
                    // Save
                    DB.SubmitChanges();
                    loadArea();
                    DisplayAreaCombobox();
                    MessageBox.Show("Delete Success !");
                }
                else
                {
                    MessageBox.Show("Area is using");
                }

            }
        }

        private void btnSearchArea_Click(object sender, EventArgs e)
        {
            dgvArea.DataSource = DB.searchArea(txtSearchArea.Text).ToList();
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

        // COMPUTER
        private void loadComputer()
        {
            dgvComputer.DataSource = DB.getAllComputer().ToList();
        }

        private void DisplayAreaCombobox()
        {
            cbAreaComputer.DataSource = DB.getAllArea();
            cbAreaComputer.DisplayMember = "name";
            cbAreaComputer.ValueMember = "entity_id";
        }

        private void dgvComputer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvComputer.CurrentRow != null)
            {
                var row = dgvComputer.CurrentRow;
                computerId = Convert.ToInt32(row.Cells["computer_id"].Value);
                txtNameComputer.Text = row.Cells["computer_name"].Value.ToString();
                cbAreaComputer.Text = row.Cells["computer_area"].Value.ToString();
            }
        }

        private void btnAddComputer_Click(object sender, EventArgs e)
        {
            if (txtNameComputer.Text == "")
            {
                MessageBox.Show("Fields not allow null !");
            }
            else
            {
                var checkComputerName = DB.computers.FirstOrDefault(x => x.name == txtNameComputer.Text);
                if (checkComputerName == null)
                {
                    // Get infomation on form to creat new data
                    computer c = new computer();
                    c.name = txtNameComputer.Text;
                    c.area_id = Convert.ToInt32(cbAreaComputer.SelectedValue);
                    // Insert
                    DB.computers.InsertOnSubmit(c);
                    // Save
                    DB.SubmitChanges();
                    loadComputer();
                    MessageBox.Show("Create Success !");
                }
                else
                {
                    MessageBox.Show("Computer's name must be unique!");
                }
            }
        }

        private void btnSaveComputer_Click(object sender, EventArgs e)
        {
            if (txtNameComputer.Text == "")
            {
                MessageBox.Show("Fields not allow null !");
            }
            else
            {
                try
                {
                    // Find object to edit
                    var c = DB.computers.SingleOrDefault(x => x.entity_id == computerId);
                    if (c.status == false)
                    {
                        // Get data
                        c.name = txtNameComputer.Text;
                        c.area_id = Convert.ToInt32(cbAreaComputer.SelectedValue);
                        // Save
                        DB.SubmitChanges();
                        loadComputer();
                        MessageBox.Show("Save Success !");
                    }
                    else
                    {
                        MessageBox.Show("Computer is running !");
                    }

                }
                catch (SqlException)
                {
                    MessageBox.Show("Computer's name must be unique!");
                }
            }
        }

        private void btnDeleteComputer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Delete Computer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Find object to edit
                var c = DB.computers.SingleOrDefault(x => x.entity_id == computerId);
                if (c.status == false)
                {
                    // Delete
                    DB.computers.DeleteOnSubmit(c);
                    // Save
                    DB.SubmitChanges();
                    loadComputer();
                    MessageBox.Show("Delete Success !");
                }
                else
                {
                    MessageBox.Show("Computer is running !");
                }
                
            }
        }

        private void btnSearchComputer_Click(object sender, EventArgs e)
        {
            dgvComputer.DataSource = DB.searchComputer(txtSearchComputer.Text).ToList();
        }

        //FOOD
        private void loadFood()
        {
            dgvFood.DataSource = DB.getALLFood().ToList();
        }

        private void DisplayFoodTypeCombobox()
        {
            cbTypeFood.DataSource = DB.getALLFoodType();
            cbTypeFood.DisplayMember = "name";
            cbTypeFood.ValueMember = "entity_id";
        }

        private void txtPriceFood_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQuantityFood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void dgvFood_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFood.CurrentRow != null)
            {
                var row = dgvFood.CurrentRow;
                foodId = Convert.ToInt32(row.Cells["food_id"].Value);
                txtNameFood.Text = row.Cells["food_name"].Value.ToString();
                txtPriceFood.Text = row.Cells["food_price"].Value.ToString();
                txtQuantityFood.Text = row.Cells["food_quantity"].Value.ToString();
                cbTypeFood.Text = row.Cells["food_type"].Value.ToString();
            }
        }

        private void btnUploadFood_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp;)|*.jpg; *.png; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtUploadFood.Text = open.FileName;
                pbUploadFood.Image = new Bitmap(open.FileName);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (txtNameFood.Text == "" || txtPriceFood.Text == "" || txtQuantityFood.Text == "")
            {
                MessageBox.Show("Fields not allow null !");
            }
            else
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp;)|*.jpg; *.png; *.jpeg; *.gif; *.bmp;";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pbUploadFood.Image = new Bitmap(open.FileName);

                }
                var checkFoodName = DB.foods.FirstOrDefault(x => x.name == txtNameFood.Text);
                if (checkFoodName == null)
                {
                    // Get infomation on form to creat new data
                    food f = new food();
                    f.name = txtNameFood.Text;
                    f.price = Convert.ToDouble(txtPriceFood.Text);
                    f.quantity = Convert.ToInt32(txtQuantityFood.Text);
                    f.image = txtUploadFood.Text;
                    f.food_type_id = Convert.ToInt32(cbTypeFood.SelectedValue);
                    // Insert
                    DB.foods.InsertOnSubmit(f);
                    // Save
                    DB.SubmitChanges();
                    loadComputer();
                    MessageBox.Show("Create Success !");
                }
                else
                {
                    MessageBox.Show("Food's name must be unique!");
                }
            }
        }

        private void btnSaveFood_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            dgvFood.DataSource = DB.searchFood(txtSearchFood.Text).ToList();
        }


        //USERS
        private void loadUser()
        {
            dgvUser.DataSource = DB.getAllUser().ToList();
        }

        private void DisplayRoleCombobox()
        {
            cbRoleUser.DataSource = DB.getAllRole();
            cbRoleUser.DisplayMember = "name";
            cbRoleUser.ValueMember = "entity_id";
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            dgvUser.DataSource = DB.searchUser(txtSearchUser.Text).ToList();
        }


        // PERMISSION
        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkUser = DB.roles.FirstOrDefault(x => x.entity_id == myId);
            if (checkUser.name == "inventory")
            {
                if (mainTabControl.SelectedTab == userTabPage)
                {
                    MessageBox.Show("You don''t have permision");
                    mainTabControl.SelectedTab = homeTabPage;
                }
            }
        }

        //OTHERS
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
                this.Close();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
