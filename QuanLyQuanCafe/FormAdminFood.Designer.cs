namespace QuanLyQuanCafe
{
    partial class FormAdminFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminFood));
            panel6 = new Panel();
            btnViewFood = new FontAwesome.Sharp.IconButton();
            btnSearchFood = new FontAwesome.Sharp.IconButton();
            txtSearchFoodName = new TextBox();
            panel4 = new Panel();
            dtgvFood = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IdCategory = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            foodDTOBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            btnDeleteFood = new ToolStripButton();
            btnEditFood = new ToolStripButton();
            btnAddFood = new ToolStripButton();
            foodCategoryDTOBindingSource = new BindingSource(components);
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodDTOBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)foodCategoryDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.Controls.Add(btnViewFood);
            panel6.Controls.Add(btnSearchFood);
            panel6.Controls.Add(txtSearchFoodName);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1162, 78);
            panel6.TabIndex = 1;
            // 
            // btnViewFood
            // 
            btnViewFood.Anchor = AnchorStyles.Top;
            btnViewFood.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnViewFood.IconColor = Color.RoyalBlue;
            btnViewFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnViewFood.Location = new Point(781, 11);
            btnViewFood.Name = "btnViewFood";
            btnViewFood.Size = new Size(95, 60);
            btnViewFood.TabIndex = 2;
            btnViewFood.UseVisualStyleBackColor = true;
            btnViewFood.Click += btnViewFood_Click;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Anchor = AnchorStyles.Top;
            btnSearchFood.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearchFood.IconColor = Color.Orange;
            btnSearchFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearchFood.Location = new Point(642, 11);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(95, 60);
            btnSearchFood.TabIndex = 1;
            btnSearchFood.UseVisualStyleBackColor = true;
            btnSearchFood.Click += btnSearchFood_Click;
            // 
            // txtSearchFoodName
            // 
            txtSearchFoodName.Anchor = AnchorStyles.Top;
            txtSearchFoodName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchFoodName.Location = new Point(256, 22);
            txtSearchFoodName.Name = "txtSearchFoodName";
            txtSearchFoodName.PlaceholderText = "Nhập mã món hoặc tên món";
            txtSearchFoodName.Size = new Size(346, 38);
            txtSearchFoodName.TabIndex = 0;
            txtSearchFoodName.KeyPress += txtSearchFoodName_KeyPress;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(dtgvFood);
            panel4.Controls.Add(toolStrip1);
            panel4.Location = new Point(68, 120);
            panel4.Name = "panel4";
            panel4.Size = new Size(1067, 454);
            panel4.TabIndex = 2;
            // 
            // dtgvFood
            // 
            dtgvFood.AllowUserToResizeColumns = false;
            dtgvFood.AllowUserToResizeRows = false;
            dtgvFood.AutoGenerateColumns = false;
            dtgvFood.BackgroundColor = Color.White;
            dtgvFood.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgvFood.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvFood.ColumnHeadersHeight = 35;
            dtgvFood.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, IdCategory, Price });
            dtgvFood.DataSource = foodDTOBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgvFood.DefaultCellStyle = dataGridViewCellStyle2;
            dtgvFood.Dock = DockStyle.Top;
            dtgvFood.EnableHeadersVisualStyles = false;
            dtgvFood.Location = new Point(0, 32);
            dtgvFood.MultiSelect = false;
            dtgvFood.Name = "dtgvFood";
            dtgvFood.ReadOnly = true;
            dtgvFood.RowHeadersVisible = false;
            dtgvFood.RowHeadersWidth = 51;
            dtgvFood.RowTemplate.Height = 29;
            dtgvFood.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvFood.Size = new Size(1067, 475);
            dtgvFood.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Mã món";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Tên món";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IdCategory
            // 
            IdCategory.DataPropertyName = "IdCategory";
            IdCategory.HeaderText = "Mã loại";
            IdCategory.MinimumWidth = 6;
            IdCategory.Name = "IdCategory";
            IdCategory.ReadOnly = true;
            IdCategory.Width = 200;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Giá";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 300;
            // 
            // foodDTOBindingSource
            // 
            foodDTOBindingSource.DataSource = typeof(DTO.FoodDTO);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnDeleteFood, btnEditFood, btnAddFood });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1067, 32);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Alignment = ToolStripItemAlignment.Right;
            btnDeleteFood.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteFood.Image = (Image)resources.GetObject("btnDeleteFood.Image");
            btnDeleteFood.ImageTransparentColor = Color.Magenta;
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(67, 29);
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // btnEditFood
            // 
            btnEditFood.Alignment = ToolStripItemAlignment.Right;
            btnEditFood.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditFood.Image = (Image)resources.GetObject("btnEditFood.Image");
            btnEditFood.ImageTransparentColor = Color.Magenta;
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(66, 29);
            btnEditFood.Text = "Sửa";
            btnEditFood.Click += btnEditFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Alignment = ToolStripItemAlignment.Right;
            btnAddFood.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddFood.ForeColor = Color.Black;
            btnAddFood.Image = (Image)resources.GetObject("btnAddFood.Image");
            btnAddFood.ImageTransparentColor = Color.Magenta;
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(80, 29);
            btnAddFood.Text = "Thêm";
            btnAddFood.Click += btnAddFood_Click;
            // 
            // foodCategoryDTOBindingSource
            // 
            foodCategoryDTOBindingSource.DataSource = typeof(DTO.FoodCategoryDTO);
            // 
            // FormAdminFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1162, 586);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel6);
            Name = "FormAdminFood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thức ăn";
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodDTOBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)foodCategoryDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private TextBox txtSearchFoodName;
        private Panel panel4;
        private DataGridView dtgvFood;
        private ToolStrip toolStrip1;
        private ToolStripButton btnDeleteFood;
        private ToolStripButton btnEditFood;
        private ToolStripButton btnAddFood;
        private BindingSource foodCategoryDTOBindingSource;
        private BindingSource foodDTOBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn IdCategory;
        private DataGridViewTextBoxColumn Price;
        private FontAwesome.Sharp.IconButton btnSearchFood;
        private FontAwesome.Sharp.IconButton btnViewFood;
    }
}