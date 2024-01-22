namespace QuanLyQuanCafe
{
    partial class FormAdminTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminTable));
            txtSearchTable = new TextBox();
            panel1 = new Panel();
            btnViewTable = new FontAwesome.Sharp.IconButton();
            btnSearchTable = new FontAwesome.Sharp.IconButton();
            panel11 = new Panel();
            dtgvFood = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableFoodDTOBindingSource = new BindingSource(components);
            toolStrip3 = new ToolStrip();
            btnDeleteTable = new ToolStripButton();
            btnEditTable = new ToolStripButton();
            btnAddTable = new ToolStripButton();
            panel1.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableFoodDTOBindingSource).BeginInit();
            toolStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearchTable
            // 
            txtSearchTable.Anchor = AnchorStyles.Top;
            txtSearchTable.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchTable.Location = new Point(256, 22);
            txtSearchTable.Name = "txtSearchTable";
            txtSearchTable.PlaceholderText = "Nhập mã bàn hoặc tên bàn";
            txtSearchTable.Size = new Size(346, 38);
            txtSearchTable.TabIndex = 0;
            txtSearchTable.KeyPress += txtSearchTable_KeyPress;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btnViewTable);
            panel1.Controls.Add(btnSearchTable);
            panel1.Controls.Add(txtSearchTable);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1162, 78);
            panel1.TabIndex = 4;
            // 
            // btnViewTable
            // 
            btnViewTable.Anchor = AnchorStyles.Top;
            btnViewTable.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnViewTable.IconColor = Color.RoyalBlue;
            btnViewTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnViewTable.Location = new Point(781, 11);
            btnViewTable.Name = "btnViewTable";
            btnViewTable.Size = new Size(95, 60);
            btnViewTable.TabIndex = 2;
            btnViewTable.UseVisualStyleBackColor = true;
            btnViewTable.Click += btnViewTable_Click;
            // 
            // btnSearchTable
            // 
            btnSearchTable.Anchor = AnchorStyles.Top;
            btnSearchTable.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearchTable.IconColor = Color.Orange;
            btnSearchTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearchTable.Location = new Point(642, 11);
            btnSearchTable.Name = "btnSearchTable";
            btnSearchTable.Size = new Size(95, 60);
            btnSearchTable.TabIndex = 1;
            btnSearchTable.UseVisualStyleBackColor = true;
            btnSearchTable.Click += btnSearchTable_Click;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel11.Controls.Add(dtgvFood);
            panel11.Controls.Add(toolStrip3);
            panel11.Location = new Point(67, 120);
            panel11.Name = "panel11";
            panel11.Size = new Size(1067, 454);
            panel11.TabIndex = 5;
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
            dtgvFood.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            dtgvFood.DataSource = tableFoodDTOBindingSource;
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
            dtgvFood.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Mã bàn";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 300;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Tên bàn";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 400;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableFoodDTOBindingSource
            // 
            tableFoodDTOBindingSource.DataSource = typeof(DTO.TableFoodDTO);
            // 
            // toolStrip3
            // 
            toolStrip3.ImageScalingSize = new Size(20, 20);
            toolStrip3.Items.AddRange(new ToolStripItem[] { btnDeleteTable, btnEditTable, btnAddTable });
            toolStrip3.Location = new Point(0, 0);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(1067, 32);
            toolStrip3.TabIndex = 0;
            toolStrip3.Text = "toolStrip3";
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Alignment = ToolStripItemAlignment.Right;
            btnDeleteTable.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteTable.Image = (Image)resources.GetObject("btnDeleteTable.Image");
            btnDeleteTable.ImageTransparentColor = Color.Magenta;
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(67, 29);
            btnDeleteTable.Text = "Xóa";
            btnDeleteTable.Click += btnDeleteTable_Click;
            // 
            // btnEditTable
            // 
            btnEditTable.Alignment = ToolStripItemAlignment.Right;
            btnEditTable.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditTable.Image = (Image)resources.GetObject("btnEditTable.Image");
            btnEditTable.ImageTransparentColor = Color.Magenta;
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(66, 29);
            btnEditTable.Text = "Sửa";
            btnEditTable.Click += btnEditTable_Click;
            // 
            // btnAddTable
            // 
            btnAddTable.Alignment = ToolStripItemAlignment.Right;
            btnAddTable.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddTable.Image = (Image)resources.GetObject("btnAddTable.Image");
            btnAddTable.ImageTransparentColor = Color.Magenta;
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(80, 29);
            btnAddTable.Text = "Thêm";
            btnAddTable.Click += btnAddTable_Click;
            // 
            // FormAdminTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1162, 586);
            Controls.Add(panel11);
            Controls.Add(panel1);
            Name = "FormAdminTable";
            Text = "Bàn ăn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableFoodDTOBindingSource).EndInit();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtSearchTable;
        private Panel panel1;
        private Panel panel11;
        private ToolStrip toolStrip3;
        private ToolStripButton btnDeleteTable;
        private ToolStripButton btnEditTable;
        private ToolStripButton btnAddTable;
        private DataGridView dtgvFood;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private BindingSource tableFoodDTOBindingSource;
        private FontAwesome.Sharp.IconButton btnSearchTable;
        private FontAwesome.Sharp.IconButton btnViewTable;
    }
}