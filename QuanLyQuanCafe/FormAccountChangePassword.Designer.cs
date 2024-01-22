namespace QuanLyQuanCafe
{
    partial class FormAccountChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountChangePassword));
            txtReEnterPass = new TextBox();
            txtNewPassword = new TextBox();
            txtPassword = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnExit = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtReEnterPass
            // 
            txtReEnterPass.BorderStyle = BorderStyle.None;
            txtReEnterPass.Cursor = Cursors.IBeam;
            txtReEnterPass.Location = new Point(329, 228);
            txtReEnterPass.Margin = new Padding(4);
            txtReEnterPass.Name = "txtReEnterPass";
            txtReEnterPass.Size = new Size(200, 27);
            txtReEnterPass.TabIndex = 2;
            txtReEnterPass.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderStyle = BorderStyle.None;
            txtNewPassword.Cursor = Cursors.IBeam;
            txtNewPassword.Location = new Point(329, 165);
            txtNewPassword.Margin = new Padding(4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(200, 27);
            txtNewPassword.TabIndex = 1;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Location = new Point(329, 102);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 227);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(214, 28);
            label5.TabIndex = 7;
            label5.Text = "Nhập lại mật khẩu mới:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 164);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(137, 28);
            label4.TabIndex = 8;
            label4.Text = "Mật khẩu mới:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 104);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 6;
            label3.Text = "Mật khẩu:";
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.RoyalBlue;
            btnExit.Location = new Point(353, 297);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(176, 73);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.RoyalBlue;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(87, 297);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(176, 73);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(194, 9);
            label1.Name = "label1";
            label1.Size = new Size(277, 54);
            label1.TabIndex = 14;
            label1.Text = "Đổi mật khẩu";
            // 
            // label2
            // 
            label2.BackColor = Color.Blue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = Color.DeepSkyBlue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(329, 195);
            label2.Name = "label2";
            label2.Size = new Size(200, 3);
            label2.TabIndex = 15;
            // 
            // label6
            // 
            label6.BackColor = Color.Blue;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.ForeColor = Color.DeepSkyBlue;
            label6.ImeMode = ImeMode.Off;
            label6.Location = new Point(329, 129);
            label6.Name = "label6";
            label6.Size = new Size(200, 3);
            label6.TabIndex = 16;
            // 
            // label7
            // 
            label7.BackColor = Color.Blue;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.ForeColor = Color.DeepSkyBlue;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(329, 258);
            label7.Name = "label7";
            label7.Size = new Size(200, 3);
            label7.TabIndex = 17;
            // 
            // FormAccountChangePassword
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnExit;
            ClientSize = new Size(642, 405);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(txtReEnterPass);
            Controls.Add(txtNewPassword);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormAccountChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtReEnterPass;
        private TextBox txtNewPassword;
        private TextBox txtPassword;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnExit;
        private Button btnUpdate;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label7;
    }
}