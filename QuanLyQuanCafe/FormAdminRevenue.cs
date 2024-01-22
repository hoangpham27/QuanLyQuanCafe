using QuanLyQuanCafe.DataDB;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class FormAdminRevenue : Form
    {
        public FormAdminRevenue()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
            billDTOBindingSource.DataSource = GetListBillByDate(dtpFromDate.Value, dtpToDate.Value);
        }

        public List<BillDTO> GetListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            var db = new QuanLyQuanCafeContext();
            var result = from b in db.Bills
                         join t in db.TableFoods on b.IdTable equals t.Id
                         where b.DateCheckIn >= checkIn && b.DateCheckOut <= checkOut && b.Status == 1
                         select new BillDTO
                         {
                             Id = b.Id,
                             IdTable = b.IdTable,
                             Status = b.Status,
                             TotalPrice = b.TotalPrice,
                             DateCheckIn = b.DateCheckIn,
                             DateCheckOut = b.DateCheckOut,
                             Discount = b.Discount
                         };

            return result.ToList();
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            billDTOBindingSource.DataSource = GetListBillByDate(dtpFromDate.Value, dtpToDate.Value);
        }
    }
}
