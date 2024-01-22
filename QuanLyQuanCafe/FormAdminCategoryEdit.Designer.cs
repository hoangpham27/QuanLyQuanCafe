namespace QuanLyQuanCafe
{
    partial class FormAdminCategoryEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminCategoryEdit));
            txtCategoryName = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            btnBoQua = new Button();
            label2 = new Label();
            btnDongY = new Button();
            label6 = new Label();
            txtCategoryID = new TextBox();
            lblTieuDe = new Label();
            label1 = new Label();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // txtCategoryName
            // 
            txtCategoryName.BorderStyle = BorderStyle.None;
            txtCategoryName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryName.Location = new Point(240, 185);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(294, 27);
            txtCategoryName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(74, 185);
            label4.Name = "label4";
            label4.Size = new Size(136, 28);
            label4.TabIndex = 0;
            label4.Text = "Tên danh mục:";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnBoQua);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(btnDongY);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txtCategoryID);
            panel5.Controls.Add(lblTieuDe);
            panel5.Controls.Add(txtCategoryName);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(642, 405);
            panel5.TabIndex = 7;
            // 
            // btnBoQua
            // 
            btnBoQua.Cursor = Cursors.Hand;
            btnBoQua.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnBoQua.ForeColor = Color.RoyalBlue;
            btnBoQua.Location = new Point(358, 277);
            btnBoQua.Margin = new Padding(4);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(176, 73);
            btnBoQua.TabIndex = 3;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BackColor = Color.Blue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.ImeMode = ImeMode.Off;
            label2.Location = new Point(240, 210);
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
            btnDongY.Location = new Point(74, 277);
            btnDongY.Margin = new Padding(4);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(176, 73);
            btnDongY.TabIndex = 2;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = false;
            btnDongY.Click += btnDongY_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Blue;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DeepSkyBlue;
            label6.ImeMode = ImeMode.Off;
            label6.Location = new Point(240, 141);
            label6.Name = "label6";
            label6.Size = new Size(294, 3);
            label6.TabIndex = 24;
            // 
            // txtCategoryID
            // 
            txtCategoryID.BackColor = Color.WhiteSmoke;
            txtCategoryID.BorderStyle = BorderStyle.None;
            txtCategoryID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryID.Location = new Point(240, 114);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(294, 27);
            txtCategoryID.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.ForeColor = Color.RoyalBlue;
            lblTieuDe.ImeMode = ImeMode.NoControl;
            lblTieuDe.Location = new Point(164, 21);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(326, 54);
            lblTieuDe.TabIndex = 23;
            lblTieuDe.Text = "Thêm danh mục";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 113);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // FormAdminCategoryEdit
            // 
            AcceptButton = btnDongY;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnBoQua;
            ClientSize = new Size(642, 405);
            ControlBox = false;
            Controls.Add(panel5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAdminCategoryEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm danh mục";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnDongY;
        private Button btnBoQua;
        private TextBox txtCategoryName;
        private Label label4;
        private Panel panel5;
        private TextBox txtCategoryID;
        private Label label1;
        private Button button1;
        private Label label6;
        private Button button2;
        private Label lblTieuDe;
        private Label label2;
    }
}