using QuanLyQuanCafe.DataDB;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class FormAdminFood : Form
    {
        public FormAdminFood()
        {
            InitializeComponent();
            LoadListFood();
        }

        void LoadListFood()
        {
            var db = new QuanLyQuanCafeContext();
            var ls = db.Foods
                .OrderBy(c => c.Id)
                .Select(c => new FoodDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    IdCategory = c.IdCategory,
                    Price = c.Price
                }).ToList();
            foodDTOBindingSource.DataSource = ls;

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var f = new FormAdminFoodEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadListFood();
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            var selFood = foodDTOBindingSource.Current as FoodDTO;
            if (selFood != null)
            {
                var f = new FormAdminFoodEdit(selFood);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
                    LoadListFood();
                }
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            var selFood = foodDTOBindingSource.Current as FoodDTO;
            if (selFood != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new QuanLyQuanCafeContext();

                    if (db.BillInfos.Where(b => b.IdFood == selFood.Id).FirstOrDefault() != null)
                    {
                        MessageBox.Show("Không được phép xóa.\nMón này đã có trong hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var obj = db.Foods.Where(t => t.Id == selFood.Id).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Foods.Remove(obj);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                        LoadListFood();
                    }
                }
            }
        }

        private void txtSearchFoodName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearchFood_Click(sender, e);
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            String key = txtSearchFoodName.Text;
            if (key.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var db = new QuanLyQuanCafeContext();
            var result = db.Foods.Where(f => f.Name.Contains(key) || f.Id.ToString().Contains(key)).Select(c => new FoodDTO
            {
                Id = c.Id,
                Name = c.Name,
                IdCategory = c.IdCategory,
                Price = c.Price
            }).ToList();

            foodDTOBindingSource.DataSource = result;

            if (result.Count == 0)
            {
                MessageBox.Show("Không có thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnViewFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
    }
}
