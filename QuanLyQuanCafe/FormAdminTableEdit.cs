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
    public partial class FormAdminTableEdit : Form
    {
        TableFoodDTO tableFood;
        List<string> lstStatus = new List<string>();

        public FormAdminTableEdit(TableFoodDTO tableFood = null)
        {
            InitializeComponent();
            this.tableFood = tableFood;

            //Đưa đồ cũ lên nếu cập nhật
            lstStatus.Add("Trống");

            if (tableFood != null)
            {
                this.Text = "Cập nhật bàn ăn";
                lblTieuDe.Text = "Cập nhật bàn ăn";
                txtTableID.Text = tableFood.Id.ToString();
                txtTableName.Text = tableFood.Name;
                lstStatus.Add("Có người");
            }
            cmbTableStatus.DataSource = lstStatus;

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            var selTable = cmbTableStatus.SelectedItem;
            var db = new QuanLyQuanCafeContext();
            if (tableFood == null)
            {
                //Thêm mới
                var obj = new TableFood
                {
                    Name = txtTableName.Text,
                    Status = "Trống",
                };
                db.TableFoods.Add(obj);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            else
            {
                //Cập nhật
                var obj = db.TableFoods.Where(t => t.Id == tableFood.Id).FirstOrDefault();
                obj.Name = txtTableName.Text;
                obj.Status = (string)selTable;
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
