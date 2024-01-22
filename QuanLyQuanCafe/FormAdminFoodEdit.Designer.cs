namespace QuanLyQuanCafe
{
    partial class FormAdminFoodEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminFoodEdit));
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtFoodName = new TextBox();
            cmbFoodCategory = new ComboBox();
            nmFoodPrice = new NumericUpDown();
            panel5 = new Panel();
            btnBoQua = new Button();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnDongY = new Button();
            lblTieuDe = new Label();
            txtFoodID = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(96, 138);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 0;
            label4.Text = "Tên món:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(96, 190);
            label5.Name = "label5";
            label5.Size = new Size(104, 28);
            label5.TabIndex = 0;
            label5.Text = "Danh mục:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(96, 246);
            label6.Name = "label6";
            label6.Size = new Size(45, 28);
            label6.TabIndex = 0;
            label6.Text = "Giá:";
            // 
            // txtFoodName
            // 
            txtFoodName.BorderStyle = BorderStyle.None;
            txtFoodName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFoodName.Location = new Point(265, 135);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(294, 27);
            txtFoodName.TabIndex = 1;
            // 
            // cmbFoodCategory
            // 
            cmbFoodCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFoodCategory.FormattingEnabled = true;
            cmbFoodCategory.Location = new Point(265, 187);
            cmbFoodCategory.Name = "cmbFoodCategory";
            cmbFoodCategory.Size = new Size(294, 36);
            cmbFoodCategory.TabIndex = 2;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nmFoodPrice.Location = new Point(265, 246);
            nmFoodPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(294, 34);
            nmFoodPrice.TabIndex = 3;
            nmFoodPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(btnBoQua);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(btnDongY);
            panel5.Controls.Add(lblTieuDe);
            panel5.Controls.Add(nmFoodPrice);
            panel5.Controls.Add(cmbFoodCategory);
            panel5.Controls.Add(txtFoodID);
            panel5.Controls.Add(txtFoodName);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(642, 405);
            panel5.TabIndex = 1;
            // 
            // btnBoQua
            // 
            btnBoQua.Cursor = Cursors.Hand;
            btnBoQua.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnBoQua.ForeColor = Color.RoyalBlue;
            btnBoQua.Location = new Point(383, 304);
            btnBoQua.Margin = new Padding(4);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(176, 73);
            btnBoQua.TabIndex = 5;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.BackColor = Color.Blue;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.ForeColor = Color.DeepSkyBlue;
            label8.ImeMode = ImeMode.Off;
            label8.Location = new Point(265, 277);
            label8.Name = "label8";
            label8.Size = new Size(294, 3);
            label8.TabIndex = 24;
            // 
            // label7
            // 
            label7.BackColor = Color.Blue;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.ForeColor = Color.DeepSkyBlue;
            label7.ImeMode = ImeMode.Off;
            label7.Location = new Point(265, 220);
            label7.Name = "label7";
            label7.Size = new Size(294, 3);
            label7.TabIndex = 24;
            // 
            // label3
            // 
            label3.BackColor = Color.Blue;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.ForeColor = Color.DeepSkyBlue;
            label3.ImeMode = ImeMode.Off;
            label3.Location = new Point(265, 166);
            label3.Name = "label3";
            label3.Size = new Size(294, 3);
            label3.TabIndex = 24;
            // 
            // label2
            // 
            label2.BackColor = Color.Blue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = Color.DeepSkyBlue;
            label2.ImeMode = ImeMode.Off;
            label2.Location = new Point(265, 116);
            label2.Name = "label2";
            label2.Size = new Size(294, 3);
            label2.TabIndex = 24;
            // 
            // btnDongY
            // 
            btnDongY.BackColor = Color.RoyalBlue;
            btnDongY.Cursor = Cursors.Hand;
            btnDongY.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnDongY.ForeColor = Color.White;
            btnDongY.Location = new Point(90, 304);
            btnDongY.Margin = new Padding(4);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(176, 73);
            btnDongY.TabIndex = 4;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = false;
            btnDongY.Click += btnDongY_Click;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.ForeColor = Color.RoyalBlue;
            lblTieuDe.ImeMode = ImeMode.NoControl;
            lblTieuDe.Location = new Point(169, 9);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(323, 54);
            lblTieuDe.TabIndex = 23;
            lblTieuDe.Text = "Thêm sản phẩm";
            // 
            // txtFoodID
            // 
            txtFoodID.BackColor = Color.WhiteSmoke;
            txtFoodID.BorderStyle = BorderStyle.None;
            txtFoodID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFoodID.Location = new Point(265, 88);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.ReadOnly = true;
            txtFoodID.Size = new Size(294, 27);
            txtFoodID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 93);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // FormAdminFoodEdit
            // 
            AcceptButton = btnDongY;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBoQua;
            ClientSize = new Size(642, 405);
            ControlBox = false;
            Controls.Add(panel5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAdminFoodEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm sản phẩm";
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtFoodName;
        private ComboBox cmbFoodCategory;
        private NumericUpDown nmFoodPrice;
        private Panel panel5;
        private TextBox txtFoodID;
        private Label label1;
        private Button btnBoQua;
        private Label label2;
        private Button btnDongY;
        private Label lblTieuDe;
        private Label label8;
        private Label label7;
        private Label label3;
    }
}