using QuanLyQuanCafe.DataDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyQuanCafe
{
    public partial class FormAdminChart : Form
    {
        public FormAdminChart()
        {
            InitializeComponent();
            showChart();
        }

        void showChart()
        {
            Controls.Clear();
            chartMoney.Series.Clear();

            var db = new QuanLyQuanCafeContext();

            var result = db.Bills
             .Where(b => b.Status == 1)
             .GroupBy(b => b.DateCheckOut)
             .Select(g => new { DateCheckOut = g.Key, TotalSum = g.Sum(b => b.TotalPrice) });

            // Tạo loại biểu đồ
            Series series = new Series("Doanh thu theo ngày");

            series.ChartType = SeriesChartType.Spline;
            series.BorderWidth = 3;

            // Thêm dữ liệu vào biểu đồ
            foreach (var item in result)
            {
                // Thêm dữ liệu vào loại biểu đồ
                series.Points.AddXY(item.DateCheckOut, item.TotalSum);
            }

            //Chart chartMoney = new Chart();

            // Thêm loại biểu đồ vào biểu đồ
            chartMoney.Series.Add(series);
            chartMoney.Invalidate();

            // Thêm biểu đồ vào form
            Controls.Add(panel8);
            Controls.Add(panel7);

        }
    }
}
