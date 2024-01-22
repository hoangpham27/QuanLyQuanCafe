namespace QuanLyQuanCafe
{
    partial class FormAdminManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminManager));
            panelMenu = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnChart = new FontAwesome.Sharp.IconButton();
            btnRevenue = new FontAwesome.Sharp.IconButton();
            btnAccount = new FontAwesome.Sharp.IconButton();
            btnTableFood = new FontAwesome.Sharp.IconButton();
            btnCategory = new FontAwesome.Sharp.IconButton();
            btnFood = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            panel1 = new Panel();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.RoyalBlue;
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(btnChart);
            panelMenu.Controls.Add(btnRevenue);
            panelMenu.Controls.Add(btnAccount);
            panelMenu.Controls.Add(btnTableFood);
            panelMenu.Controls.Add(btnCategory);
            panelMenu.Controls.Add(btnFood);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 673);
            panelMenu.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Bottom;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.SeaShell;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeftLong;
            iconButton1.IconColor = Color.SeaShell;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 613);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(220, 60);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Quay lại";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // btnChart
            // 
            btnChart.Dock = DockStyle.Top;
            btnChart.FlatAppearance.BorderSize = 0;
            btnChart.FlatStyle = FlatStyle.Flat;
            btnChart.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnChart.ForeColor = Color.SeaShell;
            btnChart.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            btnChart.IconColor = Color.SeaShell;
            btnChart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChart.ImageAlign = ContentAlignment.MiddleLeft;
            btnChart.Location = new Point(0, 440);
            btnChart.Name = "btnChart";
            btnChart.Padding = new Padding(10, 0, 20, 0);
            btnChart.Size = new Size(220, 60);
            btnChart.TabIndex = 6;
            btnChart.Text = "Biểu đồ";
            btnChart.TextAlign = ContentAlignment.MiddleLeft;
            btnChart.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChart.UseVisualStyleBackColor = true;
            btnChart.Click += btnChart_Click;
            // 
            // btnRevenue
            // 
            btnRevenue.Dock = DockStyle.Top;
            btnRevenue.FlatAppearance.BorderSize = 0;
            btnRevenue.FlatStyle = FlatStyle.Flat;
            btnRevenue.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRevenue.ForeColor = Color.SeaShell;
            btnRevenue.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            btnRevenue.IconColor = Color.SeaShell;
            btnRevenue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRevenue.ImageAlign = ContentAlignment.MiddleLeft;
            btnRevenue.Location = new Point(0, 380);
            btnRevenue.Name = "btnRevenue";
            btnRevenue.Padding = new Padding(10, 0, 20, 0);
            btnRevenue.Size = new Size(220, 60);
            btnRevenue.TabIndex = 5;
            btnRevenue.Text = "Doanh thu";
            btnRevenue.TextAlign = ContentAlignment.MiddleLeft;
            btnRevenue.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRevenue.UseVisualStyleBackColor = true;
            btnRevenue.Click += btnRevenue_Click;
            // 
            // btnAccount
            // 
            btnAccount.Dock = DockStyle.Top;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccount.ForeColor = Color.SeaShell;
            btnAccount.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnAccount.IconColor = Color.SeaShell;
            btnAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(0, 320);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(10, 0, 20, 0);
            btnAccount.Size = new Size(220, 60);
            btnAccount.TabIndex = 4;
            btnAccount.Text = "Tài khoản";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnTableFood
            // 
            btnTableFood.Dock = DockStyle.Top;
            btnTableFood.FlatAppearance.BorderSize = 0;
            btnTableFood.FlatStyle = FlatStyle.Flat;
            btnTableFood.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTableFood.ForeColor = Color.SeaShell;
            btnTableFood.IconChar = FontAwesome.Sharp.IconChar.Tablets;
            btnTableFood.IconColor = Color.SeaShell;
            btnTableFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTableFood.ImageAlign = ContentAlignment.MiddleLeft;
            btnTableFood.Location = new Point(0, 260);
            btnTableFood.Name = "btnTableFood";
            btnTableFood.Padding = new Padding(10, 0, 20, 0);
            btnTableFood.Size = new Size(220, 60);
            btnTableFood.TabIndex = 3;
            btnTableFood.Text = "Bàn ăn";
            btnTableFood.TextAlign = ContentAlignment.MiddleLeft;
            btnTableFood.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTableFood.UseVisualStyleBackColor = true;
            btnTableFood.Click += btnTableFood_Click;
            // 
            // btnCategory
            // 
            btnCategory.Dock = DockStyle.Top;
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategory.ForeColor = Color.SeaShell;
            btnCategory.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            btnCategory.IconColor = Color.SeaShell;
            btnCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategory.Location = new Point(0, 200);
            btnCategory.Name = "btnCategory";
            btnCategory.Padding = new Padding(10, 0, 20, 0);
            btnCategory.Size = new Size(220, 60);
            btnCategory.TabIndex = 2;
            btnCategory.Text = "Danh mục";
            btnCategory.TextAlign = ContentAlignment.MiddleLeft;
            btnCategory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnFood
            // 
            btnFood.Dock = DockStyle.Top;
            btnFood.FlatAppearance.BorderSize = 0;
            btnFood.FlatStyle = FlatStyle.Flat;
            btnFood.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnFood.ForeColor = Color.SeaShell;
            btnFood.IconChar = FontAwesome.Sharp.IconChar.MugSaucer;
            btnFood.IconColor = Color.SeaShell;
            btnFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFood.ImageAlign = ContentAlignment.MiddleLeft;
            btnFood.Location = new Point(0, 140);
            btnFood.Name = "btnFood";
            btnFood.Padding = new Padding(10, 0, 20, 0);
            btnFood.Size = new Size(220, 60);
            btnFood.TabIndex = 1;
            btnFood.Text = "Thức ăn";
            btnFood.TextAlign = ContentAlignment.MiddleLeft;
            btnFood.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFood.UseVisualStyleBackColor = true;
            btnFood.Click += btnFood_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Fill;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(220, 140);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.RoyalBlue;
            panelTitleBar.Controls.Add(panel1);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1042, 75);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnMaximize);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(777, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 75);
            panel1.TabIndex = 6;
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.SkyBlue;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.AliceBlue;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 32;
            btnMinimize.ImageAlign = ContentAlignment.MiddleLeft;
            btnMinimize.Location = new Point(74, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Padding = new Padding(10, 0, 20, 0);
            btnMinimize.Size = new Size(56, 31);
            btnMinimize.TabIndex = 5;
            btnMinimize.TextAlign = ContentAlignment.MiddleLeft;
            btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.SkyBlue;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = Color.Red;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 32;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(203, 3);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 20, 0);
            btnExit.Size = new Size(59, 30);
            btnExit.TabIndex = 3;
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.ForeColor = Color.SkyBlue;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnMaximize.IconColor = Color.Snow;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 32;
            btnMaximize.ImageAlign = ContentAlignment.MiddleLeft;
            btnMaximize.Location = new Point(136, 6);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Padding = new Padding(10, 0, 20, 0);
            btnMaximize.Size = new Size(61, 27);
            btnMaximize.TabIndex = 4;
            btnMaximize.TextAlign = ContentAlignment.MiddleLeft;
            btnMaximize.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleChildForm.ForeColor = Color.AliceBlue;
            lblTitleChildForm.Location = new Point(100, 22);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(92, 38);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.RoyalBlue;
            iconCurrentChildForm.ForeColor = Color.CornflowerBlue;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.CornflowerBlue;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 60;
            iconCurrentChildForm.Location = new Point(22, 12);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(63, 60);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.RoyalBlue;
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(220, 75);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1042, 9);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.RoyalBlue;
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 84);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1042, 589);
            panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(284, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(487, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormAdminManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            ControlBox = false;
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAdminManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdminManager";
            Resize += FormAdminManager_Resize;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnFood;
        private FontAwesome.Sharp.IconButton btnRevenue;
        private FontAwesome.Sharp.IconButton btnAccount;
        private FontAwesome.Sharp.IconButton btnTableFood;
        private FontAwesome.Sharp.IconButton btnCategory;
        private FontAwesome.Sharp.IconButton btnChart;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}