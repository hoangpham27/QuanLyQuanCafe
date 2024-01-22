namespace QuanLyQuanCafe
{
    partial class FormAdminTableEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminTableEdit));
            panel5 = new Panel();
            btnBoQua = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDongY = new Button();
            lblTieuDe = new Label();
            cmbTableStatus = new ComboBox();
            txtTableName = new TextBox();
            txtTableID = new TextBox();
            label12 = new Label();
            label8 = new Label();
            label11 = new Label();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(btnBoQua);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(btnDongY);
            panel5.Controls.Add(lblTieuDe);
            panel5.Controls.Add(cmbTableStatus);
            panel5.Controls.Add(txtTableName);
            panel5.Controls.Add(txtTableID);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label11);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(608, 388);
            panel5.TabIndex = 7;
            // 
            // btnBoQua
            // 
            btnBoQua.Cursor = Cursors.Hand;
            btnBoQua.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnBoQua.ForeColor = Color.RoyalBlue;
            btnBoQua.Location = new Point(363, 285);
            btnBoQua.Margin = new Padding(4);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(176, 73);
            btnBoQua.TabIndex = 4;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.BackColor = Color.Blue;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.ForeColor = Color.DeepSkyBlue;
            label3.ImeMode = ImeMode.Off;
            label3.Location = new Point(245, 245);
            label3.Name = "label3";
            label3.Size = new Size(294, 3);
            label3.TabIndex = 28;
            // 
            // label2
            // 
            label2.BackColor = Color.Blue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = Color.DeepSkyBlue;
            label2.ImeMode = ImeMode.Off;
            label2.Location = new Point(245, 180);
            label2.Name = "label2";
            label2.Size = new Size(294, 3);
            label2.TabIndex = 28;
            // 
            // label1
            // 
            label1.BackColor = Color.Blue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = Color.DeepSkyBlue;
            label1.ImeMode = ImeMode.Off;
            label1.Location = new Point(245, 131);
            label1.Name = "label1";
            label1.Size = new Size(294, 3);
            label1.TabIndex = 28;
            // 
            // btnDongY
            // 
            btnDongY.BackColor = Color.RoyalBlue;
            btnDongY.Cursor = Cursors.Hand;
            btnDongY.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnDongY.ForeColor = Color.White;
            btnDongY.Location = new Point(70, 285);
            btnDongY.Margin = new Padding(4);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(176, 73);
            btnDongY.TabIndex = 3;
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
            lblTieuDe.Location = new Point(164, 9);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(268, 54);
            lblTieuDe.TabIndex = 27;
            lblTieuDe.Text = "Thêm bàn ăn";
            // 
            // cmbTableStatus
            // 
            cmbTableStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTableStatus.FormattingEnabled = true;
            cmbTableStatus.Location = new Point(245, 212);
            cmbTableStatus.Name = "cmbTableStatus";
            cmbTableStatus.Size = new Size(294, 36);
            cmbTableStatus.TabIndex = 2;
            // 
            // txtTableName
            // 
            txtTableName.BorderStyle = BorderStyle.None;
            txtTableName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTableName.Location = new Point(247, 156);
            txtTableName.Name = "txtTableName";
            txtTableName.Size = new Size(294, 27);
            txtTableName.TabIndex = 1;
            // 
            // txtTableID
            // 
            txtTableID.BorderStyle = BorderStyle.None;
            txtTableID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTableID.Location = new Point(247, 103);
            txtTableID.Name = "txtTableID";
            txtTableID.ReadOnly = true;
            txtTableID.Size = new Size(294, 27);
            txtTableID.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(70, 102);
            label12.Name = "label12";
            label12.Size = new Size(35, 28);
            label12.TabIndex = 11;
            label12.Text = "ID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(70, 216);
            label8.Name = "label8";
            label8.Size = new Size(102, 28);
            label8.TabIndex = 9;
            label8.Text = "Trạng thái:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(70, 156);
            label11.Name = "label11";
            label11.Size = new Size(83, 28);
            label11.TabIndex = 10;
            label11.Text = "Tên bàn:";
            // 
            // FormAdminTableEdit
            // 
            AcceptButton = btnDongY;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBoQua;
            ClientSize = new Size(608, 388);
            ControlBox = false;
            Controls.Add(panel5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAdminTableEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm bàn ăn";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnDongY;
        private Button btnBoQua;
        private Panel panel5;
        private ComboBox cmbTableStatus;
        private TextBox txtTableName;
        private TextBox txtTableID;
        private Label label12;
        private Label label8;
        private Label label11;
        private Button button1;
        private Label label1;
        private Button button2;
        private Label lblTieuDe;
        private Label label3;
        private Label label2;
    }
}