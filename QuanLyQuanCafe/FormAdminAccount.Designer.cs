namespace QuanLyQuanCafe
{
    partial class FormAdminAccount
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminAccount));
            panel15 = new Panel();
            btnViewAccount = new FontAwesome.Sharp.IconButton();
            btnSearchAccount = new FontAwesome.Sharp.IconButton();
            txtSearchAccount = new TextBox();
            btnResetPassword = new FontAwesome.Sharp.IconButton();
            panel14 = new Panel();
            dtgvAccount = new DataGridView();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            displayNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountDTOBindingSource = new BindingSource(components);
            toolStrip4 = new ToolStrip();
            btnDeleteAccount = new ToolStripButton();
            btnEditAccount = new ToolStripButton();
            btnAddAccount = new ToolStripButton();
            panel15.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountDTOBindingSource).BeginInit();
            toolStrip4.SuspendLayout();
            SuspendLayout();
            // 
            // panel15
            // 
            panel15.BackColor = Color.RoyalBlue;
            panel15.Controls.Add(btnViewAccount);
            panel15.Controls.Add(btnSearchAccount);
            panel15.Controls.Add(txtSearchAccount);
            panel15.Controls.Add(btnResetPassword);
            panel15.Dock = DockStyle.Top;
            panel15.Location = new Point(0, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(1162, 78);
            panel15.TabIndex = 4;
            // 
            // btnViewAccount
            // 
            btnViewAccount.Anchor = AnchorStyles.Top;
            btnViewAccount.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnViewAccount.IconColor = Color.RoyalBlue;
            btnViewAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnViewAccount.Location = new Point(781, 11);
            btnViewAccount.Name = "btnViewAccount";
            btnViewAccount.Size = new Size(95, 60);
            btnViewAccount.TabIndex = 2;
            btnViewAccount.UseVisualStyleBackColor = true;
            btnViewAccount.Click += btnViewAccount_Click;
            // 
            // btnSearchAccount
            // 
            btnSearchAccount.Anchor = AnchorStyles.Top;
            btnSearchAccount.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearchAccount.IconColor = Color.Orange;
            btnSearchAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearchAccount.Location = new Point(642, 11);
            btnSearchAccount.Name = "btnSearchAccount";
            btnSearchAccount.Size = new Size(95, 60);
            btnSearchAccount.TabIndex = 1;
            btnSearchAccount.UseVisualStyleBackColor = true;
            btnSearchAccount.Click += btnSearchAccount_Click;
            // 
            // txtSearchAccount
            // 
            txtSearchAccount.Anchor = AnchorStyles.Top;
            txtSearchAccount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchAccount.Location = new Point(256, 22);
            txtSearchAccount.Name = "txtSearchAccount";
            txtSearchAccount.PlaceholderText = "Nhập username hoặc displayname";
            txtSearchAccount.Size = new Size(346, 38);
            txtSearchAccount.TabIndex = 0;
            txtSearchAccount.KeyPress += txtSearchAccount_KeyPress;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Anchor = AnchorStyles.Top;
            btnResetPassword.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            btnResetPassword.IconColor = Color.Sienna;
            btnResetPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnResetPassword.Location = new Point(921, 11);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(95, 60);
            btnResetPassword.TabIndex = 3;
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel14.Controls.Add(dtgvAccount);
            panel14.Controls.Add(toolStrip4);
            panel14.Location = new Point(67, 120);
            panel14.Name = "panel14";
            panel14.Size = new Size(1067, 454);
            panel14.TabIndex = 5;
            // 
            // dtgvAccount
            // 
            dtgvAccount.AllowUserToResizeColumns = false;
            dtgvAccount.AllowUserToResizeRows = false;
            dtgvAccount.AutoGenerateColumns = false;
            dtgvAccount.BackgroundColor = Color.White;
            dtgvAccount.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgvAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvAccount.ColumnHeadersHeight = 35;
            dtgvAccount.Columns.AddRange(new DataGridViewColumn[] { userNameDataGridViewTextBoxColumn, displayNameDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn });
            dtgvAccount.DataSource = accountDTOBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgvAccount.DefaultCellStyle = dataGridViewCellStyle2;
            dtgvAccount.Dock = DockStyle.Fill;
            dtgvAccount.EnableHeadersVisualStyles = false;
            dtgvAccount.Location = new Point(0, 32);
            dtgvAccount.MultiSelect = false;
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.ReadOnly = true;
            dtgvAccount.RowHeadersVisible = false;
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.RowTemplate.Height = 29;
            dtgvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvAccount.Size = new Size(1067, 422);
            dtgvAccount.TabIndex = 2;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            userNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // displayNameDataGridViewTextBoxColumn
            // 
            displayNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            displayNameDataGridViewTextBoxColumn.DataPropertyName = "DisplayName";
            displayNameDataGridViewTextBoxColumn.HeaderText = "DisplayName";
            displayNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            displayNameDataGridViewTextBoxColumn.Name = "displayNameDataGridViewTextBoxColumn";
            displayNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            typeDataGridViewTextBoxColumn.Width = 300;
            // 
            // accountDTOBindingSource
            // 
            accountDTOBindingSource.DataSource = typeof(DTO.AccountDTO);
            // 
            // toolStrip4
            // 
            toolStrip4.ImageScalingSize = new Size(20, 20);
            toolStrip4.Items.AddRange(new ToolStripItem[] { btnDeleteAccount, btnEditAccount, btnAddAccount });
            toolStrip4.Location = new Point(0, 0);
            toolStrip4.Name = "toolStrip4";
            toolStrip4.Size = new Size(1067, 32);
            toolStrip4.TabIndex = 0;
            toolStrip4.Text = "toolStrip4";
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Alignment = ToolStripItemAlignment.Right;
            btnDeleteAccount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteAccount.Image = (Image)resources.GetObject("btnDeleteAccount.Image");
            btnDeleteAccount.ImageTransparentColor = Color.Magenta;
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(67, 29);
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Alignment = ToolStripItemAlignment.Right;
            btnEditAccount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditAccount.Image = (Image)resources.GetObject("btnEditAccount.Image");
            btnEditAccount.ImageTransparentColor = Color.Magenta;
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(66, 29);
            btnEditAccount.Text = "Sửa";
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Alignment = ToolStripItemAlignment.Right;
            btnAddAccount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddAccount.Image = (Image)resources.GetObject("btnAddAccount.Image");
            btnAddAccount.ImageTransparentColor = Color.Magenta;
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(80, 29);
            btnAddAccount.Text = "Thêm";
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // FormAdminAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1162, 586);
            ControlBox = false;
            Controls.Add(panel14);
            Controls.Add(panel15);
            Name = "FormAdminAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tài khoản";
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountDTOBindingSource).EndInit();
            toolStrip4.ResumeLayout(false);
            toolStrip4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel15;
        private Panel panel14;
        private ToolStrip toolStrip4;
        private ToolStripButton btnDeleteAccount;
        private ToolStripButton btnEditAccount;
        private ToolStripButton btnAddAccount;
        private FontAwesome.Sharp.IconButton btnResetPassword;
        private DataGridView dtgvAccount;
        private BindingSource accountDTOBindingSource;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton btnViewAccount;
        private FontAwesome.Sharp.IconButton btnSearchAccount;
        private TextBox txtSearchAccount;
    }
}