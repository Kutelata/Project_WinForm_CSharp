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

namespace InternetCafe.UI.Employee
{
    public partial class OrderFoodByComputer : Form
    {
        InternetCafeDataContext DB = new InternetCafeDataContext();
        List<Entity.Food> lstfood = new List<Entity.Food>();
        private int computerId;

        public OrderFoodByComputer(int computerId)
        {
            InitializeComponent();
            this.computerId = computerId;
        }

        private void OrderFoodByComputer_Load(object sender, EventArgs e)
        {
            DisplayFoodComboBox();
        }

        private void DisplayFoodComboBox()
        {
            cbFood.DataSource = DB.getALLFood();
            cbFood.DisplayMember = "name";
            cbFood.ValueMember = "entity_id";
        }

        private void dgvFood_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFood.CurrentRow != null)
            {
                var row = dgvFood.CurrentRow;
                cbFood.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var findFoodName = DB.searchFood(cbFood.Text).FirstOrDefault();
            var obj = lstfood.Find(x => x.Name == findFoodName.name);
            if (obj != null)
            {
                if (Convert.ToInt32(nudQuantityFood.Value) > 0)
                {
                    obj.Quantity = Convert.ToInt32(nudQuantityFood.Value.ToString());
                    obj.TotalPrice = obj.Quantity * obj.Price;
                }
                else
                {
                    lstfood.Remove(obj);
                }

            }
            else
            {
                if (Convert.ToInt32(nudQuantityFood.Value) > 0)
                {
                    lstfood.Add(new Entity.Food()
                    {
                        Id = findFoodName.entity_id,
                        Name = findFoodName.name,
                        Price = findFoodName.price,
                        Quantity = Convert.ToInt32(nudQuantityFood.Value),
                        TotalPrice = findFoodName.price * Convert.ToInt32(nudQuantityFood.Value),
                    });
                }
                else
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0 !");
                }
                
            }
            dgvFood.Rows.Clear();
            foreach (var item in lstfood)
            {
                string Id = item.Id.ToString();
                string Food = item.Name.ToString();
                string Price = item.Price.ToString();
                string Quantity = item.Quantity.ToString();
                string TotalPrice = item.TotalPrice.ToString();
                string[] row = new string[] { Id, Food, Price, Quantity, TotalPrice };
                dgvFood.Rows.Add(row);
            }
        }

        private void btnSaveFood_Click(object sender, EventArgs e)
        {
            foreach (var item in lstfood)
            {
                var findOrderComputer = DB.getAllOrderComputer(computerId).FirstOrDefault();
                var findFood = DB.foods.FirstOrDefault(f => f.entity_id == item.Id);
                if (findFood.quantity >= item.Quantity)
                {
                    try
                    {
                        DB.addOrderFood(findOrderComputer.entity_id, item.Id, item.Quantity);
                        MessageBox.Show("Đặt thành công !");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Hết hàng !");
                    }

                }
                else
                {
                    MessageBox.Show("Số lượng phải nhỏ hơn trong kho !");
                }

            }
        }

        private void btnCancelFood_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
