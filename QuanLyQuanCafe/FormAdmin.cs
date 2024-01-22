using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyQuanCafe
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            LoadDateTimePickerBill();
            GetListBillByDate(dtpFromDate.Value, dtpToDate.Value);
            LoadListFood();
            LoadListCategory();
            LoadListTable();
            LoadListAccount();
            showChart();
        }




        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            // Tạo đối tượng Graphics để vẽ lên tab
            Graphics g = e.Graphics;

            // Chọn màu cho chữ
            Brush textBrush;

            // Lấy tabPage hiện tại
            TabPage tabPage = tabControl1.TabPages[e.Index];

            // Lấy vùng vẽ chuẩn xác của tab
            Rectangle tabBounds = tabControl1.GetTabRect(e.Index);

            // Nếu tab đang được chọn...
            if (e.State == DrawItemState.Selected)
            {
                // Tô màu nền xám và chữ màu đỏ
                textBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                // Giữ màu nền và chữ mặc định
                textBrush = new SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Font chữ rõ ràng và đậm nét
            Font tabFont = new Font("Arial", 12.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Canh giữa chữ trong tab
            StringFormat stringFlags = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            // Vẽ chữ lên tab
            g.DrawString(tabPage.Text, tabFont, textBrush, tabBounds, stringFlags);
        }

        public List<BillDTO> GetListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            var db = new QuanLyQuanCafeContext();
            var result = from b in db.Bills
                         join t in db.TableFoods on b.IdTable equals t.Id
                         where b.DateCheckIn >= checkIn && b.DateCheckOut <= checkOut && b.Status == 1
                         select new BillDTO
                         {
                             Id = b.Id,
                             IdTable = b.IdTable,
                             Status = b.Status,
                             TotalPrice = b.TotalPrice,
                             DateCheckIn = b.DateCheckIn,
                             DateCheckOut = b.DateCheckOut,
                             Discount = b.Discount
                         };

            return result.ToList();
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            billDTOBindingSource.DataSource = GetListBillByDate(dtpFromDate.Value, dtpToDate.Value);
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

        private void btnViewFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var f = new FormAdminFoodEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadListFood();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void txtSearchFoodName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)

                btnSearchFood_Click(sender, e);
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


        void LoadListTable()
        {
            var db = new QuanLyQuanCafeContext();
            var ls = db.TableFoods
                .OrderBy(c => c.Id)
                .Select(c => new TableFoodDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    Status = c.Status,
                }).ToList();
            tableFoodDTOBindingSource.DataSource = ls;
        }


        private void btnAddTable_Click(object sender, EventArgs e)
        {
            var f = new FormAdminTableEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadListTable();
            }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            var selTableFood = tableFoodDTOBindingSource.Current as TableFoodDTO;
            if (selTableFood != null)
            {
                var f = new FormAdminTableEdit(selTableFood);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
                    LoadListTable();
                }
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            var selTableFood = tableFoodDTOBindingSource.Current as TableFoodDTO;
            if (selTableFood != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new QuanLyQuanCafeContext();
                    var obj = db.TableFoods.Where(t => t.Id == selTableFood.Id).FirstOrDefault();
                    if (obj != null)
                    {
                        db.TableFoods.Remove(obj);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                        LoadListTable();
                    }
                }
            }
        }

        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            String key = txtSearchTable.Text;
            if (key.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var db = new QuanLyQuanCafeContext();
            var result = db.TableFoods.Where(fc => fc.Name.Contains(key) || fc.Id.ToString().Contains(key)).Select(c => new TableFoodDTO
            {
                Id = c.Id,
                Name = c.Name,
                Status = c.Status,
            }).ToList();

            tableFoodDTOBindingSource.DataSource = result;

            if (result.Count == 0)
            {
                MessageBox.Show("Không có thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnViewTable_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }

        private void txtSearchTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearchTable_Click(sender, e);
        }

        void LoadListAccount()
        {
            var db = new QuanLyQuanCafeContext();
            var ls = db.Accounts
                .OrderBy(c => c.UserName)
                .Select(c => new AccountDTO
                {
                    UserName = c.UserName,
                    DisplayName = c.DisplayName,
                    Type = c.Type,
                }).ToList();
            accountDTOBindingSource.DataSource = ls;
        }

        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            LoadListAccount();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            var f = new FormAdminAccountEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadListAccount();
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            var selAccount = accountDTOBindingSource.Current as AccountDTO;
            if (selAccount != null)
            {
                var f = new FormAdminAccountEdit(selAccount);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
                    LoadListAccount();
                }
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            var selAccount = accountDTOBindingSource.Current as AccountDTO;
            if (selAccount != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new QuanLyQuanCafeContext();
                    var obj = db.Accounts.Where(t => t.UserName == selAccount.UserName).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Accounts.Remove(obj);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                        LoadListAccount();
                    }
                }
            }
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            String key = txtSearchAccount.Text;
            if (key.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var db = new QuanLyQuanCafeContext();
            var result = db.Accounts.Where(a => a.UserName.Contains(key) || a.DisplayName.Contains(key)).Select(c => new AccountDTO
            {
                UserName = c.UserName,
                DisplayName = c.DisplayName,
                Type = c.Type,
            }).ToList();

            accountDTOBindingSource.DataSource = result;

            if (result.Count == 0)
            {
                MessageBox.Show("Không có thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearchAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearchAccount_Click(sender, e);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            var selAccount = accountDTOBindingSource.Current as AccountDTO;
            if (selAccount != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn đặt lại mật khẩu không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new QuanLyQuanCafeContext();
                    var obj = db.Accounts.Where(t => t.UserName == selAccount.UserName).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.PassWord = selAccount.UserName;
                        db.SaveChanges();
                        MessageBox.Show("Đặt lại mật khẩu thành công! Mật khẩu của bạn là userName của bạn!", "Thông báo", MessageBoxButtons.OK);
                        LoadListAccount();
                    }
                }
            }
        }

        void showChart()
        {
            tabPage6.Controls.Clear();
            chartMoney.Series.Clear();

            var db = new QuanLyQuanCafeContext();

            var result = db.Bills
             .Where(b => b.Status == 1)
             .GroupBy(b => b.DateCheckOut)
             .Select(g => new { DateCheckOut = g.Key, TotalSum = g.Sum(b => b.TotalPrice) });

            // Tạo loại biểu đồ
            Series series = new Series("Doanh thu theo ngày");

            series.ChartType = SeriesChartType.Spline;

            // Thêm dữ liệu vào biểu đồ
            foreach (var item in result)
            {
                // Thêm dữ liệu vào loại biểu đồ
                series.Points.AddXY(item.DateCheckOut, item.TotalSum);
            }

            //Chart chartMoney = new Chart();

            // Thêm loại biểu đồ vào biểu đồ
            chartMoney.Series.Add(series);
            chartMoney.Invalidate();

            // Thêm biểu đồ vào form
            tabPage6.Controls.Add(panel8);
            tabPage6.Controls.Add(panel7);

        }


    }
}
