namespace QuanLyQuanCafe
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            tàiToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            txtWelcome = new ToolStripTextBox();
            panel2 = new Panel();
            dgvBill = new DataGridView();
            foodNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            menuDTOBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            btnDelete = new ToolStripButton();
            btnEdit = new ToolStripButton();
            panel3 = new Panel();
            btnGopBan = new Button();
            label2 = new Label();
            label1 = new Label();
            txtDiscount = new TextBox();
            txtTotalPrice = new TextBox();
            btnSwitchTable = new Button();
            cmbSwitchTable = new ComboBox();
            btnCheckOut = new Button();
            panel4 = new Panel();
            nmFoodCount = new NumericUpDown();
            btnAddFood = new Button();
            cmbFood = new ComboBox();
            cmbFoodCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuDTOBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem, tàiToolStripMenuItem, txtWelcome });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            resources.ApplyResources(quảnLýToolStripMenuItem, "quảnLýToolStripMenuItem");
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Click += quảnLýToolStripMenuItem_Click;
            // 
            // tàiToolStripMenuItem
            // 
            tàiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinTàiKhoảnToolStripMenuItem, đăngXuấtToolStripMenuItem });
            resources.ApplyResources(tàiToolStripMenuItem, "tàiToolStripMenuItem");
            tàiToolStripMenuItem.Name = "tàiToolStripMenuItem";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            resources.ApplyResources(thôngTinTàiKhoảnToolStripMenuItem, "thôngTinTàiKhoảnToolStripMenuItem");
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Click += thôngTinTàiKhoảnToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            resources.ApplyResources(đăngXuấtToolStripMenuItem, "đăngXuấtToolStripMenuItem");
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // txtWelcome
            // 
            txtWelcome.Alignment = ToolStripItemAlignment.Right;
            txtWelcome.Name = "txtWelcome";
            txtWelcome.ReadOnly = true;
            resources.ApplyResources(txtWelcome, "txtWelcome");
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvBill);
            panel2.Controls.Add(toolStrip1);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // dgvBill
            // 
            dgvBill.AllowUserToResizeColumns = false;
            dgvBill.AllowUserToResizeRows = false;
            resources.ApplyResources(dgvBill, "dgvBill");
            dgvBill.AutoGenerateColumns = false;
            dgvBill.BackgroundColor = Color.White;
            dgvBill.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBill.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBill.Columns.AddRange(new DataGridViewColumn[] { foodNameDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn });
            dgvBill.DataSource = menuDTOBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBill.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBill.EnableHeadersVisualStyles = false;
            dgvBill.MultiSelect = false;
            dgvBill.Name = "dgvBill";
            dgvBill.ReadOnly = true;
            dgvBill.RowHeadersVisible = false;
            dgvBill.RowTemplate.Height = 29;
            dgvBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // foodNameDataGridViewTextBoxColumn
            // 
            foodNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foodNameDataGridViewTextBoxColumn.DataPropertyName = "FoodName";
            resources.ApplyResources(foodNameDataGridViewTextBoxColumn, "foodNameDataGridViewTextBoxColumn");
            foodNameDataGridViewTextBoxColumn.Name = "foodNameDataGridViewTextBoxColumn";
            foodNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            resources.ApplyResources(countDataGridViewTextBoxColumn, "countDataGridViewTextBoxColumn");
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            resources.ApplyResources(priceDataGridViewTextBoxColumn, "priceDataGridViewTextBoxColumn");
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            resources.ApplyResources(totalPriceDataGridViewTextBoxColumn, "totalPriceDataGridViewTextBoxColumn");
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menuDTOBindingSource
            // 
            menuDTOBindingSource.DataSource = typeof(DTO.MenuDTO);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnDelete, btnEdit });
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.Name = "toolStrip1";
            // 
            // btnDelete
            // 
            btnDelete.Alignment = ToolStripItemAlignment.Right;
            resources.ApplyResources(btnDelete, "btnDelete");
            btnDelete.Name = "btnDelete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Alignment = ToolStripItemAlignment.Right;
            resources.ApplyResources(btnEdit, "btnEdit");
            btnEdit.Name = "btnEdit";
            btnEdit.Click += btnEdit_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnGopBan);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtDiscount);
            panel3.Controls.Add(txtTotalPrice);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(cmbSwitchTable);
            panel3.Controls.Add(btnCheckOut);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // btnGopBan
            // 
            resources.ApplyResources(btnGopBan, "btnGopBan");
            btnGopBan.Name = "btnGopBan";
            btnGopBan.UseVisualStyleBackColor = true;
            btnGopBan.Click += btnGopBan_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.White;
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // txtDiscount
            // 
            resources.ApplyResources(txtDiscount, "txtDiscount");
            txtDiscount.Name = "txtDiscount";
            txtDiscount.KeyPress += txtDiscount_KeyPress;
            // 
            // txtTotalPrice
            // 
            resources.ApplyResources(txtTotalPrice, "txtTotalPrice");
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            // 
            // btnSwitchTable
            // 
            resources.ApplyResources(btnSwitchTable, "btnSwitchTable");
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.UseVisualStyleBackColor = true;
            btnSwitchTable.Click += btnSwitchTable_Click;
            // 
            // cmbSwitchTable
            // 
            resources.ApplyResources(cmbSwitchTable, "cmbSwitchTable");
            cmbSwitchTable.FormattingEnabled = true;
            cmbSwitchTable.Name = "cmbSwitchTable";
            // 
            // btnCheckOut
            // 
            resources.ApplyResources(btnCheckOut, "btnCheckOut");
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(nmFoodCount);
            panel4.Controls.Add(btnAddFood);
            panel4.Controls.Add(cmbFood);
            panel4.Controls.Add(cmbFoodCategory);
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // nmFoodCount
            // 
            resources.ApplyResources(nmFoodCount, "nmFoodCount");
            nmFoodCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddFood
            // 
            resources.ApplyResources(btnAddFood, "btnAddFood");
            btnAddFood.Name = "btnAddFood";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // cmbFood
            // 
            resources.ApplyResources(cmbFood, "cmbFood");
            cmbFood.FormattingEnabled = true;
            cmbFood.Name = "cmbFood";
            // 
            // cmbFoodCategory
            // 
            resources.ApplyResources(cmbFoodCategory, "cmbFoodCategory");
            cmbFoodCategory.FormattingEnabled = true;
            cmbFoodCategory.Name = "cmbFoodCategory";
            cmbFoodCategory.SelectedIndexChanged += cmbFoodCategory_SelectedIndexChanged;
            // 
            // flpTable
            // 
            resources.ApplyResources(flpTable, "flpTable");
            flpTable.BackColor = Color.White;
            flpTable.Name = "flpTable";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FormMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuDTOBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem tàiToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnCheckOut;
        private NumericUpDown nmFoodCount;
        private Button btnAddFood;
        private ComboBox cmbFood;
        private ComboBox cmbFoodCategory;
        private Button btnSwitchTable;
        private ComboBox cmbSwitchTable;
        private FlowLayoutPanel flpTable;
        private Label label1;
        private TextBox txtTotalPrice;
        private BindingSource menuDTOBindingSource;
        private ToolStrip toolStrip1;
        private ToolStripButton btnDelete;
        private ToolStripButton btnEdit;
        private TextBox txtDiscount;
        private Label label2;
        private ToolStripTextBox txtWelcome;
        private Button btnGopBan;
        private DataGridView dgvBill;
        private DataGridViewTextBoxColumn foodNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    }
}