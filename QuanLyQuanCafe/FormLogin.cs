using QuanLyQuanCafe.DataDB;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            var db = new QuanLyQuanCafeContext();
            var user = db.Accounts.Where(c => c.UserName == username && c.PassWord == password)
                .Select(c => new AccountDTO
                {
                    UserName = c.UserName,
                    DisplayName = c.DisplayName,
                    PassWord = c.PassWord,
                    Type = c.Type,
                })
                .SingleOrDefault();

            if (user != null)
            {
                FormMain f = new FormMain(user);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}