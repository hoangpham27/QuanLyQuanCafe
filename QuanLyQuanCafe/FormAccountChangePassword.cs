using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanCafe
{
    public partial class FormAccountChangePassword : Form
    {
        AccountDTO user;

        public FormAccountChangePassword(AccountDTO user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string newpass = txtNewPassword.Text;
            string reEnterPass = txtReEnterPass.Text;

            if (!password.Equals(user.PassWord))
            {
                MessageBox.Show("Vui lòng nhập đúng mật khấu");
            }
            else if (!newpass.Equals(reEnterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                var db = new QuanLyQuanCafeContext();
                var obj = db.Accounts.Where(u => u.UserName == user.UserName).FirstOrDefault();
                if (obj != null)
                {
                    obj.PassWord = newpass;
                    db.SaveChanges();
                    //MessageBox.Show(obj.PassWord);
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
