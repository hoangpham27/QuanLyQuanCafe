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
    public partial class FormAdminCategoryEdit : Form
    {
        FoodCategoryDTO foodCategory;

        public FormAdminCategoryEdit(FoodCategoryDTO foodCategory = null)
        {
            InitializeComponent();
            this.foodCategory = foodCategory;
            //Đưa đồ cũ lên nếu cập nhật
            if (foodCategory != null)
            {
                var db = new QuanLyQuanCafeContext();
                this.Text = "Cập nhật danh mục";
                lblTieuDe.Text = "Cập nhật danh mục";
                txtCategoryID.Text = foodCategory.Id.ToString();
                txtCategoryName.Text = foodCategory.Name;
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            var db = new QuanLyQuanCafeContext();
            if (foodCategory == null)
            {
                //Thêm mới
                var obj = new FoodCategory
                {
                    Name = txtCategoryName.Text,
                };
                db.FoodCategories.Add(obj);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            else
            {
                //Cập nhật
                var obj = db.FoodCategories.Where(t => t.Id == foodCategory.Id).FirstOrDefault();
                obj.Name = txtCategoryName.Text;
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
