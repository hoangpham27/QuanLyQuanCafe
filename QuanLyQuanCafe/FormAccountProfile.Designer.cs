namespace QuanLyQuanCafe
{
    partial class FormAccountProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountProfile));
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtDisplayName = new TextBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btnChangePassword = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            btnExit = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(65, 106);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 171);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên hiển thị:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(247, 105);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(245, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtDisplayName
            // 
            txtDisplayName.BorderStyle = BorderStyle.None;
            txtDisplayName.Cursor = Cursors.IBeam;
            txtDisplayName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisplayName.Location = new Point(247, 170);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new Size(245, 27);
            txtDisplayName.TabIndex = 1;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePassword.Location = new Point(49, 306);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(176, 73);
            btnChangePassword.TabIndex = 3;
            btnChangePassword.Text = "Đổi mật khẩu";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(247, 234);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(245, 27);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(65, 234);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 12;
            label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            label4.BackColor = Color.Blue;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(247, 201);
            label4.Name = "label4";
            label4.Size = new Size(245, 3);
            label4.TabIndex = 18;
            // 
            // label6
            // 
            label6.BackColor = Color.Blue;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DeepSkyBlue;
            label6.ImeMode = ImeMode.Off;
            label6.Location = new Point(247, 136);
            label6.Name = "label6";
            label6.Size = new Size(245, 3);
            label6.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.RoyalBlue;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(124, 19);
            label5.Name = "label5";
            label5.Size = new Size(392, 54);
            label5.TabIndex = 17;
            label5.Text = "Thông tin tài khoản";
            // 
            // label7
            // 
            label7.BackColor = Color.Blue;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DeepSkyBlue;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(247, 264);
            label7.Name = "label7";
            label7.Size = new Size(245, 3);
            label7.TabIndex = 20;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.RoyalBlue;
            btnExit.Location = new Point(437, 306);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(176, 73);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.RoyalBlue;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(247, 306);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(176, 73);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FormAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnExit;
            ClientSize = new Size(642, 405);
            ControlBox = false;
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(btnChangePassword);
            Controls.Add(txtDisplayName);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin tài khoản";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtDisplayName;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnChangePassword;
        private TextBox txtPassword;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label7;
        private Button btnExit;
        private Button btnUpdate;
    }
}