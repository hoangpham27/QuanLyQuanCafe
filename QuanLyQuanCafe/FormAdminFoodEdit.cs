using QuanLyQuanCafe.DataDB;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class FormAdminFoodEdit : Form
    {
        FoodDTO food;

        public FormAdminFoodEdit(FoodDTO food = null)
        {
            InitializeComponent();
            this.food = food;
            LoadFoodCategory();
            //Đưa đồ cũ lên nếu cập nhật
            if (food != null)
            {
                var db = new QuanLyQuanCafeContext();
                this.Text = "Cập nhật sản phẩm";
                lblTieuDe.Text = "Cập nhật sản phẩm";
                txtFoodID.Text = food.Id.ToString();
                txtFoodName.Text = food.Name;
                cmbFoodCategory.Text = db.FoodCategories.Where(fc => fc.Id == food.IdCategory).FirstOrDefault().Name;
                nmFoodPrice.Value = (int)food.Price;
            }
        }

        void LoadFoodCategory()
        {
            //Đổ dữ liệu danh mục lên cmbFoodCategory
            //B1: Lấy dữ liệu danh mục từ DB
            var db = new QuanLyQuanCafeContext();
            var ls = db.FoodCategories.OrderBy(c => c.Id)
                .Select(c => new FoodCategoryDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToList();

            //B2: Đổ dữ liệu lên cmbFoodCategory
            cmbFoodCategory.DataSource = ls;
            cmbFoodCategory.DisplayMember = "Name";
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            var selFood = cmbFoodCategory.SelectedItem as FoodCategoryDTO;
            var db = new QuanLyQuanCafeContext();
            if (food == null)
            {
                //Thêm mới
                var obj = new Food
                {
                    Name = txtFoodName.Text,
                    IdCategory = selFood.Id,
                    Price = (float)nmFoodPrice.Value
                };
                db.Foods.Add(obj);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            else
            {
                //Cập nhật
                var obj = db.Foods.Where(t => t.Id == food.Id).FirstOrDefault();
                obj.Name = txtFoodName.Text;
                obj.IdCategory = selFood.Id;
                obj.Price = (float)nmFoodPrice.Value;
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
