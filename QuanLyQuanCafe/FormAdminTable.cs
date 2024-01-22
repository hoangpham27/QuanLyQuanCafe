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
    public partial class FormAdminTable : Form
    {
        public FormAdminTable()
        {
            InitializeComponent();
            LoadListTable();
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
    }
}
