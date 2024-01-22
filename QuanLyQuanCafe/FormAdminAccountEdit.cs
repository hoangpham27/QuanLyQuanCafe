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
    public partial class FormAdminAccountEdit : Form
    {
        AccountDTO acc;
        List<string> lstType = new List<string>();
        public FormAdminAccountEdit(AccountDTO acc = null)
        {
            InitializeComponent();
            this.acc = acc;
            lstType.Add("0 - Staff");
            lstType.Add("1 - Admin");
            cmbAccountType.DataSource = lstType;
            var db = new QuanLyQuanCafeContext();
            //Đưa đồ cũ lên nếu cập nhật
            if (acc != null)
            {
                this.Text = "Cập nhật tài khoản";
                lblTieuDe.Text = "Cập nhật tài khoản";
                txtUsername.ReadOnly = true;
                txtUsername.Text = acc.UserName;
                txtDisplayName.Text = acc.DisplayName;
                cmbAccountType.Text = acc.Type.ToString() + " - " + (acc.Type == 0 ? " Staff" : "Admin");
            }

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            var selAccount = cmbAccountType.SelectedItem;
            var db = new QuanLyQuanCafeContext();
            if (acc == null)
            {
                //Thêm mới
                var obj = new Account
                {
                    UserName = txtUsername.Text,
                    DisplayName = txtDisplayName.Text,
                    PassWord = txtUsername.Text,
                    Type = int.Parse(selAccount.ToString().Split(" ")[0])
                };
                db.Accounts.Add(obj);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            else
            {
                //Cập nhật
                var obj = db.Accounts.Where(a => a.UserName == acc.UserName).FirstOrDefault();
                obj.UserName = txtUsername.Text;
                obj.DisplayName = txtDisplayName.Text;
                obj.Type = int.Parse(selAccount.ToString().Split(" ")[0]);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
