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
    public partial class FormAdminCategory : Form
    {
        public FormAdminCategory()
        {
            InitializeComponent();
            LoadListCategory();
        }

        void LoadListCategory()
        {
            var db = new QuanLyQuanCafeContext();
            var ls = db.FoodCategories
                .OrderBy(c => c.Id)
                .Select(c => new FoodCategoryDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToList();
            foodCategoryDTOBindingSource.DataSource = ls;

        }


        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var f = new FormAdminCategoryEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadListCategory();
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            var selCategoryFood = foodCategoryDTOBindingSource.Current as FoodCategoryDTO;
            if (selCategoryFood != null)
            {
                var f = new FormAdminCategoryEdit(selCategoryFood);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
                    LoadListCategory();
                }
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            var selCategoryFood = foodCategoryDTOBindingSource.Current as FoodCategoryDTO;
            if (selCategoryFood != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new QuanLyQuanCafeContext();
                    var obj = db.FoodCategories.Where(t => t.Id == selCategoryFood.Id).FirstOrDefault();
                    if (obj != null)
                    {
                        db.FoodCategories.Remove(obj);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                        LoadListCategory();
                    }
                }
            }
        }

        private void btnViewCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            String key = txtSearchCategory.Text;
            if (key.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var db = new QuanLyQuanCafeContext();
            var result = db.FoodCategories.Where(fc => fc.Name.Contains(key) || fc.Id.ToString().Contains(key)).Select(c => new FoodCategoryDTO
            {
                Id = c.Id,
                Name = c.Name,
            }).ToList();

            foodCategoryDTOBindingSource.DataSource = result;

            if (result.Count == 0)
            {
                MessageBox.Show("Không có thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtSearchCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearchCategory_Click(sender, e);
        }

    }
}
