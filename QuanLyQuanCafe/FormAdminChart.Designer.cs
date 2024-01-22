namespace QuanLyQuanCafe
{
    partial class FormAdminChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel8 = new Panel();
            label3 = new Label();
            panel7 = new Panel();
            chartMoney = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartMoney).BeginInit();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.RoyalBlue;
            panel8.Controls.Add(label3);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1162, 78);
            panel8.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(418, 18);
            label3.Name = "label3";
            label3.Size = new Size(378, 38);
            label3.TabIndex = 0;
            label3.Text = "Biểu đồ doanh thu theo ngày";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel7.Controls.Add(chartMoney);
            panel7.Location = new Point(67, 120);
            panel7.Name = "panel7";
            panel7.Size = new Size(1067, 454);
            panel7.TabIndex = 3;
            // 
            // chartMoney
            // 
            chartArea1.Name = "ChartArea1";
            chartMoney.ChartAreas.Add(chartArea1);
            chartMoney.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartMoney.Legends.Add(legend1);
            chartMoney.Location = new Point(0, 0);
            chartMoney.Name = "chartMoney";
            chartMoney.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            chartMoney.Series.Add(series1);
            chartMoney.Size = new Size(1067, 454);
            chartMoney.TabIndex = 0;
            chartMoney.Text = "chartMoney";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(1162, 1);
            panel1.TabIndex = 4;
            // 
            // FormAdminChart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1162, 608);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Controls.Add(panel8);
            ForeColor = SystemColors.ControlText;
            Name = "FormAdminChart";
            Text = "Biểu đồ";
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartMoney).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel8;
        private Label label3;
        private Panel panel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMoney;
        private Panel panel1;
    }
}