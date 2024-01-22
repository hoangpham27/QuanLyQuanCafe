namespace QuanLyQuanCafe
{
    partial class FormIssueAnInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIssueAnInvoice));
            label1 = new Label();
            panel2 = new Panel();
            dgvBill = new DataGridView();
            foodNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            menuDTOBindingSource = new BindingSource(components);
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblDateCheckOut = new Label();
            lblIDBill = new Label();
            label3 = new Label();
            lblTable = new Label();
            lblStaff = new Label();
            lblTotalPrice = new Label();
            label7 = new Label();
            label8 = new Label();
            lblDiscount = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(273, 56);
            label1.Name = "label1";
            label1.Size = new Size(275, 46);
            label1.TabIndex = 0;
            label1.Text = "Phiếu thanh toán";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvBill);
            panel2.Location = new Point(45, 253);
            panel2.Name = "panel2";
            panel2.Size = new Size(693, 281);
            panel2.TabIndex = 3;
            // 
            // dgvBill
            // 
            dgvBill.AutoGenerateColumns = false;
            dgvBill.BackgroundColor = Color.White;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBill.Columns.AddRange(new DataGridViewColumn[] { foodNameDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn });
            dgvBill.DataSource = menuDTOBindingSource;
            dgvBill.Dock = DockStyle.Fill;
            dgvBill.Location = new Point(0, 0);
            dgvBill.Name = "dgvBill";
            dgvBill.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvBill.RowHeadersVisible = false;
            dgvBill.RowHeadersWidth = 51;
            dgvBill.RowTemplate.Height = 29;
            dgvBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBill.Size = new Size(693, 281);
            dgvBill.TabIndex = 0;
            // 
            // foodNameDataGridViewTextBoxColumn
            // 
            foodNameDataGridViewTextBoxColumn.DataPropertyName = "FoodName";
            foodNameDataGridViewTextBoxColumn.HeaderText = "Tên món";
            foodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            foodNameDataGridViewTextBoxColumn.Name = "foodNameDataGridViewTextBoxColumn";
            foodNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            countDataGridViewTextBoxColumn.MinimumWidth = 6;
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // menuDTOBindingSource
            // 
            menuDTOBindingSource.DataSource = typeof(DTO.MenuDTO);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 9);
            label2.Name = "label2";
            label2.Size = new Size(187, 46);
            label2.TabIndex = 0;
            label2.Text = "Quán CAFE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblDateCheckOut
            // 
            lblDateCheckOut.AutoSize = true;
            lblDateCheckOut.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateCheckOut.Location = new Point(282, 132);
            lblDateCheckOut.Name = "lblDateCheckOut";
            lblDateCheckOut.Size = new Size(63, 25);
            lblDateCheckOut.TabIndex = 5;
            lblDateCheckOut.Text = "Ngày: ";
            // 
            // lblIDBill
            // 
            lblIDBill.AutoSize = true;
            lblIDBill.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblIDBill.Location = new Point(282, 171);
            lblIDBill.Name = "lblIDBill";
            lblIDBill.Size = new Size(42, 25);
            lblIDBill.TabIndex = 5;
            lblIDBill.Text = "Số: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(282, 210);
            label3.Name = "label3";
            label3.Size = new Size(188, 25);
            label3.TabIndex = 5;
            label3.Text = "Địa chỉ: 102 bình thiên";
            // 
            // lblTable
            // 
            lblTable.AutoSize = true;
            lblTable.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTable.Location = new Point(536, 132);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(50, 25);
            lblTable.TabIndex = 5;
            lblTable.Text = "Bàn: ";
            // 
            // lblStaff
            // 
            lblStaff.AutoSize = true;
            lblStaff.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaff.Location = new Point(536, 171);
            lblStaff.Name = "lblStaff";
            lblStaff.Size = new Size(100, 25);
            lblStaff.TabIndex = 5;
            lblStaff.Text = "Nhân viên: ";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrice.Location = new Point(444, 561);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(104, 28);
            lblTotalPrice.TabIndex = 7;
            lblTotalPrice.Text = "Tổng tiền: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(172, 629);
            label7.Name = "label7";
            label7.Size = new Size(436, 38);
            label7.TabIndex = 7;
            label7.Text = "Cảm ơn quý khách và hẹn gặp lại!";
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Location = new Point(-1, 617);
            label8.Name = "label8";
            label8.Size = new Size(764, 1);
            label8.TabIndex = 7;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiscount.Location = new Point(156, 561);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(99, 28);
            lblDiscount.TabIndex = 7;
            lblDiscount.Text = "Giảm giá: ";
            // 
            // FormIssueAnInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(767, 676);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(lblDiscount);
            Controls.Add(lblTotalPrice);
            Controls.Add(label3);
            Controls.Add(lblStaff);
            Controls.Add(lblTable);
            Controls.Add(lblIDBill);
            Controls.Add(lblDateCheckOut);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormIssueAnInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private DataGridView dgvBill;
        private BindingSource menuDTOBindingSource;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblDateCheckOut;
        private Label lblIDBill;
        private Label label3;
        private Label lblTable;
        private Label lblStaff;
        private Label lblTotalPrice;
        private Label label7;
        private DataGridViewTextBoxColumn foodNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private Label label8;
        private Label lblDiscount;
    }
}