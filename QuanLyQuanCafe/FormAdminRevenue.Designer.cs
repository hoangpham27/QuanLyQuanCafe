namespace QuanLyQuanCafe
{
    partial class FormAdminRevenue
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
            panel1 = new Panel();
            btnViewBill = new FontAwesome.Sharp.IconButton();
            dtpToDate = new DateTimePicker();
            label2 = new Label();
            dtpFromDate = new DateTimePicker();
            panel2 = new Panel();
            dtgvRevenue = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateCheckInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateCheckOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idTableDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            billDTOBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRevenue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)billDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnViewBill);
            panel1.Controls.Add(dtpToDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpFromDate);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1162, 78);
            panel1.TabIndex = 3;
            // 
            // btnViewBill
            // 
            btnViewBill.Anchor = AnchorStyles.Top;
            btnViewBill.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewBill.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            btnViewBill.IconColor = Color.CornflowerBlue;
            btnViewBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnViewBill.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewBill.Location = new Point(912, 13);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(160, 47);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "Thống kê";
            btnViewBill.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnViewBill.UseVisualStyleBackColor = true;
            btnViewBill.Click += btnViewBill_Click;
            // 
            // dtpToDate
            // 
            dtpToDate.Anchor = AnchorStyles.Top;
            dtpToDate.CustomFormat = "dd/MM/yyyy";
            dtpToDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.Location = new Point(619, 22);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(270, 34);
            dtpToDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(552, 22);
            label2.Name = "label2";
            label2.Size = new Size(45, 28);
            label2.TabIndex = 2;
            label2.Text = "đến";
            // 
            // dtpFromDate
            // 
            dtpFromDate.Anchor = AnchorStyles.Top;
            dtpFromDate.CustomFormat = "dd/MM/yyyy";
            dtpFromDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.Location = new Point(256, 22);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(270, 34);
            dtpFromDate.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dtgvRevenue);
            panel2.Location = new Point(68, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(1067, 454);
            panel2.TabIndex = 4;
            // 
            // dtgvRevenue
            // 
            dtgvRevenue.AllowUserToAddRows = false;
            dtgvRevenue.AllowUserToDeleteRows = false;
            dtgvRevenue.AllowUserToResizeColumns = false;
            dtgvRevenue.AllowUserToResizeRows = false;
            dtgvRevenue.AutoGenerateColumns = false;
            dtgvRevenue.BackgroundColor = Color.White;
            dtgvRevenue.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgvRevenue.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvRevenue.ColumnHeadersHeight = 35;
            dtgvRevenue.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dateCheckInDataGridViewTextBoxColumn, dateCheckOutDataGridViewTextBoxColumn, idTableDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn });
            dtgvRevenue.DataSource = billDTOBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgvRevenue.DefaultCellStyle = dataGridViewCellStyle2;
            dtgvRevenue.Dock = DockStyle.Fill;
            dtgvRevenue.EnableHeadersVisualStyles = false;
            dtgvRevenue.Location = new Point(0, 0);
            dtgvRevenue.MultiSelect = false;
            dtgvRevenue.Name = "dtgvRevenue";
            dtgvRevenue.ReadOnly = true;
            dtgvRevenue.RowHeadersVisible = false;
            dtgvRevenue.RowHeadersWidth = 51;
            dtgvRevenue.RowTemplate.Height = 29;
            dtgvRevenue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvRevenue.Size = new Size(1067, 454);
            dtgvRevenue.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateCheckInDataGridViewTextBoxColumn
            // 
            dateCheckInDataGridViewTextBoxColumn.DataPropertyName = "DateCheckIn";
            dateCheckInDataGridViewTextBoxColumn.HeaderText = "Ngày mở hóa đơn";
            dateCheckInDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateCheckInDataGridViewTextBoxColumn.Name = "dateCheckInDataGridViewTextBoxColumn";
            dateCheckInDataGridViewTextBoxColumn.ReadOnly = true;
            dateCheckInDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateCheckOutDataGridViewTextBoxColumn
            // 
            dateCheckOutDataGridViewTextBoxColumn.DataPropertyName = "DateCheckOut";
            dateCheckOutDataGridViewTextBoxColumn.HeaderText = "Ngày thanh toán";
            dateCheckOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateCheckOutDataGridViewTextBoxColumn.Name = "dateCheckOutDataGridViewTextBoxColumn";
            dateCheckOutDataGridViewTextBoxColumn.ReadOnly = true;
            dateCheckOutDataGridViewTextBoxColumn.Width = 200;
            // 
            // idTableDataGridViewTextBoxColumn
            // 
            idTableDataGridViewTextBoxColumn.DataPropertyName = "IdTable";
            idTableDataGridViewTextBoxColumn.HeaderText = "Bàn";
            idTableDataGridViewTextBoxColumn.MinimumWidth = 6;
            idTableDataGridViewTextBoxColumn.Name = "idTableDataGridViewTextBoxColumn";
            idTableDataGridViewTextBoxColumn.ReadOnly = true;
            idTableDataGridViewTextBoxColumn.Width = 120;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            discountDataGridViewTextBoxColumn.HeaderText = "Giảm giá";
            discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            discountDataGridViewTextBoxColumn.ReadOnly = true;
            discountDataGridViewTextBoxColumn.Width = 120;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billDTOBindingSource
            // 
            billDTOBindingSource.DataSource = typeof(DTO.BillDTO);
            // 
            // FormAdminRevenue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1162, 586);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormAdminRevenue";
            Text = "Thống kê";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvRevenue).EndInit();
            ((System.ComponentModel.ISupportInitialize)billDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dtpToDate;
        private Label label2;
        private DateTimePicker dtpFromDate;
        private Panel panel2;
        private DataGridView dtgvRevenue;
        private BindingSource billDTOBindingSource;
        private FontAwesome.Sharp.IconButton btnViewBill;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateCheckInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateCheckOutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idTableDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    }
}