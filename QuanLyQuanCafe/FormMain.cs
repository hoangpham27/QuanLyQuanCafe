using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QuanLyQuanCafe.DataDB;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class FormMain : Form
    {
        AccountDTO user;

        public FormMain(AccountDTO user)
        {
            InitializeComponent();
            this.user = user;
            LoadUser(user);
            LoadFoodCategory();
            LoadTable();
            LoadComboboxTable();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccountProfile f = new FormAccountProfile(user);
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadUser(user);
            }

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminManager f = new FormAdminManager();
            f.ShowDialog();
            if (dgvBill.Tag != null)
            {
                ShowBill((int)dgvBill.Tag);
            }
            LoadFoodCategory();
            LoadTable();
            LoadComboboxTable();
        }

        void LoadTable()
        {
            flpTable.Controls.Clear();
            var db = new QuanLyQuanCafeContext();

            var tableList = db.TableFoods.OrderBy(c => c.Id)
                .Select(c => new TableFoodDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    Status = c.Status,
                }).ToList();

            foreach (TableFoodDTO item in tableList)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.ForeColor = Color.White;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.DodgerBlue;
                        break;
                    default:
                        btn.BackColor = Color.Firebrick;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as TableFoodDTO).Id;
            ShowBill(tableID);
            dgvBill.Tag = tableID;
            txtDiscount.Enabled = true;
            //btnAddFood.Tag = tableID;
        }

        void ShowBill(int id)
        {
            var db = new QuanLyQuanCafeContext();

            var listBillInfo = from bi in db.BillInfos
                               join b in db.Bills on bi.IdBill equals b.Id
                               join f in db.Foods on bi.IdFood equals f.Id
                               where b.IdTable == id && b.Status == 0
                               select new MenuDTO
                               {
                                   IdBillInfo = bi.Id,
                                   FoodName = f.Name,
                                   Count = bi.Count,
                                   Price = (float)f.Price,
                                   TotalPrice = (float)(f.Price * bi.Count)
                               };

            menuDTOBindingSource.DataSource = listBillInfo.ToList();

            float totalPrice = listBillInfo.Sum(bi => bi.Price * bi.Count);
            txtTotalPrice.Text = totalPrice.ToString() + " ₫";
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
            cmbFoodCategory.DisplayMember = "Display";
        }

        void LoadFoodListByCategoryID(int idcategory)
        {
            //Đổ dữ liệu danh mục lên cmbFood
            //B1: Lấy dữ liệu danh mục từ DB
            var db = new QuanLyQuanCafeContext();
            var ls = db.Foods.Where(c => c.IdCategory == idcategory)
                .Select(c => new FoodDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    IdCategory = c.IdCategory,
                    Price = c.Price,
                }).ToList();

            //B2: Đổ dữ liệu lên cmbFood
            if (ls.Count == 0) { cmbFood.DataSource = null; }
            else
            {
                cmbFood.DataSource = ls;
                cmbFood.DisplayMember = "Display";
            }

        }

        private void cmbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            FoodCategoryDTO selected = cb.SelectedItem as FoodCategoryDTO;
            var idcategory = selected.Id;

            LoadFoodListByCategoryID(idcategory);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            //TableFoodDTO table = (sender as Button).Tag as TableFoodDTO;

            // TableFoodDTO table = dgvBill.Tag as TableFoodDTO;

            int idtable = 0;

            if (dgvBill.Tag != null)
            {
                idtable = (int)dgvBill.Tag;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn!");
                return;
            }

            InsertBill_BillInfo(idtable);

            LoadTable();
            ShowBill(idtable);
        }

        void InsertBill_BillInfo(int idtable)
        {
            {
                var db = new QuanLyQuanCafeContext();

                int idfood = (cmbFood.SelectedItem as FoodDTO).Id;
                int count = (int)nmFoodCount.Value;

                var bill = db.Bills.Where(b => b.IdTable == idtable && b.Status == 0).FirstOrDefault();

                if (bill == null)
                {
                    //Insert new Bill 
                    var objBill = new Bill
                    {
                        IdTable = idtable,
                        DateCheckIn = DateTime.Now,
                        DateCheckOut = null,
                        Status = 0,
                        Discount = 0,
                        TotalPrice = 0,
                        UserName = user.UserName
                    };
                    db.Bills.Add(objBill);
                    db.SaveChanges();
                    //Insert new BillInfo
                    var objBillInfo = new BillInfo
                    {
                        IdBill = db.Bills.Max(c => c.Id),
                        IdFood = idfood,
                        Count = count,
                    };
                    db.BillInfos.Add(objBillInfo);
                    db.SaveChanges();
                }
                else
                {
                    //Already had bill, we insert new BillInfo

                    //Check BillInfo có trong Bill chưa?
                    var billInfo = db.BillInfos.Where(bi => bi.IdFood == idfood && bi.IdBill == bill.Id).FirstOrDefault();
                    //Có thì tăng số lượng
                    if (billInfo != null)
                    {
                        billInfo.Count += count;
                        db.SaveChanges();
                    }
                    else
                    {
                        //Chưa thì thêm 
                        var objBillInfo = new BillInfo
                        {
                            IdBill = db.Bills.Where(t => t.Id == bill.Id).FirstOrDefault().Id,
                            IdFood = idfood,
                            Count = count,
                        };
                        db.BillInfos.Add(objBillInfo);
                        db.SaveChanges();
                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selBillInfo = menuDTOBindingSource.Current as MenuDTO;
            if (selBillInfo != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new QuanLyQuanCafeContext();
                    var obj = db.BillInfos.Where(t => t.Id == selBillInfo.IdBillInfo).FirstOrDefault();
                    if (obj != null)
                    {
                        db.BillInfos.Remove(obj);
                        db.SaveChanges();
                        ShowBill((int)dgvBill.Tag);
                        LoadTable();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selBillInfo = menuDTOBindingSource.Current as MenuDTO;
            if (selBillInfo != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new QuanLyQuanCafeContext();
                    var obj = db.BillInfos.Where(t => t.Id == selBillInfo.IdBillInfo).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.Count = (int)nmFoodCount.Value;
                        db.SaveChanges();
                        ShowBill((int)dgvBill.Tag);
                    }
                }
            }

        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selBillInfo = menuDTOBindingSource.Current as MenuDTO;
            if (selBillInfo != null && selBillInfo.FoodName != null)
            {
                var db = new QuanLyQuanCafeContext();
                //Đổ lên 2 cmb
                var idFoodCategory = db.Foods.Where(f => f.Name == selBillInfo.FoodName).FirstOrDefault().IdCategory;

                cmbFoodCategory.Text = db.TableFoods.Where(fc => fc.Id == idFoodCategory).FirstOrDefault().Name;
                cmbFood.Text = selBillInfo.FoodName + " - " + selBillInfo.Price + "₫";
                nmFoodCount.Value = selBillInfo.Count;
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int tableId = 0;

            if (dgvBill.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn bàn rồi hãy thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tableId = (int)dgvBill.Tag;
            CheckOutBill(tableId);
            LoadTable();
        }

        void CheckOutBill(int tableId, int tableId2 = 0)
        {
            var db = new QuanLyQuanCafeContext();

            var table = db.TableFoods.Where(t => t.Id == tableId).FirstOrDefault();
            var split = table.Status.Contains("- ") ? table.Status.Split("- ")[2] : "0";
            var table2 = db.TableFoods.Where(t => t.Id == int.Parse(split)).FirstOrDefault();
            var displayNoti = table2 != null ? table.Name + " và " + table2.Name : table.Name;

            var bill = db.Bills.Where(b => b.IdTable == tableId && b.Status == 0).FirstOrDefault();

            if (bill != null)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho " + displayNoti, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    DiscountBill();
                    var obj = db.Bills.Where(b => b.Id == bill.Id).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.Status = 1;
                        obj.DateCheckOut = DateTime.Now;
                        obj.Discount = int.Parse(txtDiscount.Text);
                        float finalTotalPrice = float.Parse(txtTotalPrice.Text.Split(' ')[0]);
                        obj.TotalPrice = finalTotalPrice;
                        db.SaveChanges();
                    }

                    ShowBill(tableId);
                    LoadTable();

                    //Hoadon
                    BillDTO billDTO = new BillDTO()
                    {
                        Id = bill.Id,
                        IdTable = bill.IdTable,
                        Status = bill.Status,
                        DateCheckIn = bill.DateCheckIn,
                        DateCheckOut = bill.DateCheckOut,
                        Discount = bill.Discount,
                        TotalPrice = bill.TotalPrice,
                        UserName = bill.UserName
                    };

                    if (table2 != null)
                    {
                        var bill2 = db.Bills.Where(b => b.IdTable == table2.Id && b.Status == 0).FirstOrDefault();
                        if (bill2 != null)
                        {
                            db.Remove(bill2);
                            table2.Status = "Trống";
                            db.SaveChanges();
                        }
                    }

                    var f = new FormIssueAnInvoice(billDTO);
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Xuất hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bàn này không có hóa đơn!", "Thông báo", MessageBoxButtons.OK);
            }

        }

        void DiscountBill()
        {
            int discount = int.Parse(txtDiscount.Text);

            if (txtDiscount.Enabled && discount > 0)
            {
                float totalPrice = float.Parse(txtTotalPrice.Text.Split(' ')[0]);
                float finalTotalPrice = totalPrice - ((totalPrice * discount) / 100);
                txtTotalPrice.Text = finalTotalPrice.ToString() + " ₫";
                txtDiscount.Enabled = false;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DiscountBill();
            }

        }

        void LoadComboboxTable()
        {
            var db = new QuanLyQuanCafeContext();
            var ls = db.TableFoods.OrderBy(c => c.Id)
                .Select(c => new TableFoodDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    Status = c.Status
                }).ToList();

            //B2: Đổ dữ liệu lên cmbFoodCategory
            cmbSwitchTable.DataSource = ls;
            cmbSwitchTable.DisplayMember = "Name";
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            if (dgvBill.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn bàn để chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idTable1 = (int)dgvBill.Tag;

            int idTable2 = (cmbSwitchTable.SelectedItem as TableFoodDTO).Id;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển Bàn {0} qua Bàn {1}", idTable1, idTable2), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (idTable1 == idTable2)
                {
                    MessageBox.Show("Không thể chuyển với bàn muốn chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SwitchTable(idTable1, idTable2);
            }

            LoadTable();
            ShowBill(idTable2);
        }

        public void SwitchTable(int idTable1, int idTable2)
        {
            var db = new QuanLyQuanCafeContext();

            // Find the first bill for the first table
            var firstBill = db.Bills.FirstOrDefault(b => b.IdTable == idTable1 && b.Status == 0);

            if (firstBill == null)
            {
                // Create a new bill for the first table if it doesn't exist
                firstBill = new Bill
                {
                    DateCheckIn = DateTime.Now,
                    DateCheckOut = null,
                    IdTable = idTable1,
                    Status = 0,
                    Discount = 0,
                    TotalPrice = 0,
                    UserName = user.UserName
                };

                db.Bills.Add(firstBill);
                db.SaveChanges();
            }
            // Check if there are any items in the first table's bill
            var isFirstTableEmpty = db.BillInfos.Count(bi => bi.IdBill == firstBill.Id) == 0;

            // Find the second bill for the second table
            var secondBill = db.Bills.FirstOrDefault(b => b.IdTable == idTable2 && b.Status == 0);

            if (secondBill == null)
            {
                // Create a new bill for the second table if it doesn't exist
                secondBill = new Bill
                {
                    DateCheckIn = DateTime.Now,
                    DateCheckOut = null,
                    IdTable = idTable2,
                    Status = 0,
                    Discount = 0,
                    TotalPrice = 0,
                    UserName = user.UserName
                };
                db.Bills.Add(secondBill);
                db.SaveChanges();
            }
            // Check if there are any items in the second table's bill
            var isSecondTableEmpty = db.BillInfos.Count(bi => bi.IdBill == secondBill.Id) == 0;

            // Swap the items between the two bills
            var firstBillInfoIds = db.BillInfos.Where(bi => bi.IdBill == firstBill.Id).Select(bi => bi.Id).ToList();

            var secondBillInfoIds = db.BillInfos.Where(bi => bi.IdBill == secondBill.Id).Select(bi => bi.Id).ToList();

            foreach (var id in firstBillInfoIds)
            {
                db.BillInfos.Find(id).IdBill = secondBill.Id;
            }

            foreach (var id in secondBillInfoIds)
            {
                db.BillInfos.Find(id).IdBill = firstBill.Id;
            }
            db.SaveChanges();

            // Update the table status if there are no items in the bills
            if (isFirstTableEmpty)
            {
                var table = db.TableFoods.Where(t => t.Id == idTable2).FirstOrDefault();
                if (table != null)
                {
                    table.Status = "Trống";
                }

            }
            if (isSecondTableEmpty)
            {
                var table = db.TableFoods.Where(t => t.Id == idTable1).FirstOrDefault();
                if (table != null)
                {
                    table.Status = "Trống";
                }

            }
            db.SaveChanges();

        }

        void LoadUser(AccountDTO user)
        {
            quảnLýToolStripMenuItem.Enabled = user.Type == 1;
            txtWelcome.Text = "Xin chào " + user.DisplayName;
        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {
            if (dgvBill.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn bàn để gộp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idTable1 = (int)dgvBill.Tag;

            int idTable2 = (cmbSwitchTable.SelectedItem as TableFoodDTO).Id;
            if (MessageBox.Show(string.Format("Bạn có muốn gộp bàn {0} và bàn {1}", idTable1, idTable2), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (idTable1 == idTable2)
                {
                    MessageBox.Show("Không thể gộp với bàn muốn gộp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CombineTable(idTable1, idTable2);
            }

            LoadTable();
            ShowBill(idTable2);
        }

        void CombineTable(int idTable1, int idTable2)
        {
            var db = new QuanLyQuanCafeContext();
            // Lấy ra BillID của Bill chưa thanh toán trên 2 bàn cần gộp vào nhau
            var idFirstBill = db.Bills.Where(b => b.IdTable == idTable1 && b.Status == 0).FirstOrDefault().Id;
            var idSecondBill = db.Bills.Where(b => b.IdTable == idTable2 && b.Status == 0).FirstOrDefault().Id;

            // Nếu 2 bàn đều có người thì mới tiến hành gộp
            if (idFirstBill != null && idSecondBill != null)
            {
                // Gộp bàn thứ 1 vào bàn thứ 2 bằng cách thay BillID trong bảng BillInfo
                // Viết lại đoạn code này cho rõ ràng hơn
                var firstBillInfos = db.BillInfos.Where(b => b.IdBill == idFirstBill);
                foreach (var b in firstBillInfos)
                {
                    b.IdBill = idSecondBill;
                }
                // Update hết billinfo qua bill 2 mà chưa xóa bill 1 nên là thanh toán vẫn trống :)
                db.SaveChanges();

                // Xử lý các món trùng lặp
                // Viết lại đoạn code này cho hiệu quả hơn
                // Lấy ra các món ăn trong hóa đơn thứ 2 (tat ca)
                var secondBillInfos = db.BillInfos.Where(b => b.IdBill == idSecondBill).Select(b => new BillInfo
                {
                    Id = b.Id,
                    IdBill = b.IdBill,
                    IdFood = b.IdFood,
                    Count = b.Count,
                });

                // Nhóm các món ăn trùng lặp
                var groupedBillFoods = secondBillInfos.GroupBy(bf => bf.IdFood).Select(g => new { IdFood = g.Key, Count = g.Sum(bf => bf.Count) });

                foreach (var group in groupedBillFoods)
                {
                    // Lấy ra tổng số lượng món ăn
                    var totalCount = group.Count;

                    // Cập nhật số lượng món ăn cho món ăn trùng lặp
                    var last = db.BillInfos.OrderBy(i => i.IdFood).Where(b => b.IdBill == idSecondBill && b.IdFood == group.IdFood).LastOrDefault();
                    if (last != null)
                    {
                        last.Count = totalCount;
                        db.SaveChanges();
                    }


                    // Xóa các món ăn trùng lặp khác
                    while (true)
                    {
                        var obj = db.BillInfos.OrderBy(i => i.IdFood).Where(b => b.IdBill == idSecondBill && b.IdFood == group.IdFood && b.Count != totalCount).FirstOrDefault();
                        if (obj == null) break;
                        db.Remove(obj);
                        db.SaveChanges();
                    }

                }

                //Cập nhật status cho bàn
                var table1 = db.TableFoods.Where(t => t.Id == idTable1).FirstOrDefault();
                var table2 = db.TableFoods.Where(t => t.Id == idTable2).FirstOrDefault();
                if (table1 != null && table2 != null)
                {
                    table1.Status = "Có người - " + table2.Name + " - " + table2.Id;
                    table2.Status = "Có người - " + table1.Name + " - " + table1.Id;
                    db.SaveChanges();
                }
            }
        }


    }
}

