using QuanLyQuanCafe.DataDB;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class FormAdminAccount : Form
    {
        public FormAdminAccount()
        {
            InitializeComponent();
            LoadListAccount();
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

        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            LoadListAccount();
        }
    }
}
