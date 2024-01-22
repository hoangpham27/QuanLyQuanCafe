namespace QuanLyQuanCafe
{
    partial class FormAdminCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminCategory));
            panel3 = new Panel();
            dgvCategory = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foodCategoryDTOBindingSource = new BindingSource(components);
            toolStrip2 = new ToolStrip();
            btnDeleteCategory = new ToolStripButton();
            btnEditCategory = new ToolStripButton();
            btnAddCategory = new ToolStripButton();
            txtSearchCategory = new TextBox();
            btnSearchCategory = new FontAwesome.Sharp.IconButton();
            btnViewCategory = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodCategoryDTOBindingSource).BeginInit();
            toolStrip2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(dgvCategory);
            panel3.Controls.Add(toolStrip2);
            panel3.Location = new Point(67, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(1067, 454);
            panel3.TabIndex = 6;
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToResizeColumns = false;
            dgvCategory.AllowUserToResizeRows = false;
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.BackgroundColor = Color.White;
            dgvCategory.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategory.ColumnHeadersHeight = 35;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dgvCategory.DataSource = foodCategoryDTOBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategory.Dock = DockStyle.Top;
            dgvCategory.EnableHeadersVisualStyles = false;
            dgvCategory.Location = new Point(0, 32);
            dgvCategory.MultiSelect = false;
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dgvCategory.RowHeadersVisible = false;
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.RowTemplate.Height = 29;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.Size = new Size(1067, 475);
            dgvCategory.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Mã loại";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 300;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Tên loại";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foodCategoryDTOBindingSource
            // 
            foodCategoryDTOBindingSource.DataSource = typeof(DTO.FoodCategoryDTO);
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnDeleteCategory, btnEditCategory, btnAddCategory });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1067, 32);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Alignment = ToolStripItemAlignment.Right;
            btnDeleteCategory.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteCategory.Image = (Image)resources.GetObject("btnDeleteCategory.Image");
            btnDeleteCategory.ImageTransparentColor = Color.Magenta;
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(67, 29);
            btnDeleteCategory.Text = "Xóa";
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Alignment = ToolStripItemAlignment.Right;
            btnEditCategory.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditCategory.Image = (Image)resources.GetObject("btnEditCategory.Image");
            btnEditCategory.ImageTransparentColor = Color.Magenta;
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(66, 29);
            btnEditCategory.Text = "Sửa";
            btnEditCategory.Click += btnEditCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Alignment = ToolStripItemAlignment.Right;
            btnAddCategory.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCategory.Image = (Image)resources.GetObject("btnAddCategory.Image");
            btnAddCategory.ImageTransparentColor = Color.Magenta;
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(80, 29);
            btnAddCategory.Text = "Thêm";
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtSearchCategory
            // 
            txtSearchCategory.Anchor = AnchorStyles.Top;
            txtSearchCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchCategory.Location = new Point(256, 22);
            txtSearchCategory.Name = "txtSearchCategory";
            txtSearchCategory.PlaceholderText = "Nhập mã loại hoặc tên loại";
            txtSearchCategory.Size = new Size(346, 38);
            txtSearchCategory.TabIndex = 0;
            txtSearchCategory.KeyPress += txtSearchCategory_KeyPress;
            // 
            // btnSearchCategory
            // 
            btnSearchCategory.Anchor = AnchorStyles.Top;
            btnSearchCategory.ForeColor = Color.Crimson;
            btnSearchCategory.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearchCategory.IconColor = Color.Orange;
            btnSearchCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearchCategory.Location = new Point(642, 11);
            btnSearchCategory.Name = "btnSearchCategory";
            btnSearchCategory.Size = new Size(95, 60);
            btnSearchCategory.TabIndex = 1;
            btnSearchCategory.UseVisualStyleBackColor = true;
            btnSearchCategory.Click += btnSearchCategory_Click;
            // 
            // btnViewCategory
            // 
            btnViewCategory.Anchor = AnchorStyles.Top;
            btnViewCategory.BackColor = Color.White;
            btnViewCategory.ForeColor = Color.SaddleBrown;
            btnViewCategory.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnViewCategory.IconColor = Color.RoyalBlue;
            btnViewCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnViewCategory.Location = new Point(781, 11);
            btnViewCategory.Name = "btnViewCategory";
            btnViewCategory.Size = new Size(95, 60);
            btnViewCategory.TabIndex = 2;
            btnViewCategory.UseVisualStyleBackColor = false;
            btnViewCategory.Click += btnViewCategory_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.RoyalBlue;
            panel5.Controls.Add(btnViewCategory);
            panel5.Controls.Add(btnSearchCategory);
            panel5.Controls.Add(txtSearchCategory);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1162, 78);
            panel5.TabIndex = 7;
            // 
            // FormAdminCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1162, 586);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Name = "FormAdminCategory";
            Text = "Danh mục";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodCategoryDTOBindingSource).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private ToolStrip toolStrip2;
        private ToolStripButton btnDeleteCategory;
        private ToolStripButton btnEditCategory;
        private ToolStripButton btnAddCategory;
        private DataGridView dgvCategory;
        private BindingSource foodCategoryDTOBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private TextBox txtSearchCategory;
        private FontAwesome.Sharp.IconButton btnSearchCategory;
        private FontAwesome.Sharp.IconButton btnViewCategory;
        private Panel panel5;
    }
}