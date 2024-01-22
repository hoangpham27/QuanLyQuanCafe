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
    public partial class FormAccountProfile : Form
    {
        AccountDTO user;

        public FormAccountProfile(AccountDTO user)
        {
            InitializeComponent();
            this.user = user;
            if (user != null)
            {
                txtUsername.Text = user.UserName;
                txtDisplayName.Text = user.DisplayName;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string displayName = txtDisplayName.Text;
            string password = txtPassword.Text;

            if (!password.Equals(user.PassWord))
            {
                MessageBox.Show("Vui lòng nhập đúng mật khấu");
            }
            else
            {
                var db = new QuanLyQuanCafeContext();
                var obj = db.Accounts.Where(u => u.UserName == userName).FirstOrDefault();
                if (obj != null)
                {
                    obj.DisplayName = displayName;
                    db.SaveChanges();
                    user.DisplayName = displayName;
                    MessageBox.Show("Cập nhật thành công");
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var f = new FormAccountChangePassword(user);
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Bạn sẽ phải đăng nhập lại!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Lấy tất cả form đang mở
                FormCollection openForms = Application.OpenForms;

                // Duyệt qua tất cả form
                foreach (Form form in openForms)
                {
                    if (form.Name == "FormLogin")
                    {
                        continue;
                    }
                    // Đóng form
                    form.Close();
                }
                /*//Bật form login
                FormLogin loginForm = new FormLogin();
                loginForm.Show();*/
            }
        }

  
    }
}
