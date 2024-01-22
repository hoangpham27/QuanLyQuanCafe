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
    public partial class FormIssueAnInvoice : Form
    {
        public FormIssueAnInvoice(BillDTO bill)
        {
            InitializeComponent();
            lblDateCheckOut.Text += DateTime.Now.ToString();
            lblIDBill.Text += bill.Id.ToString();
            lblStaff.Text += bill.UserName;
            lblTable.Text += bill.IdTable.ToString();
            lblDiscount.Text += bill.Discount.ToString() + "%";
            lblTotalPrice.Text += bill.TotalPrice.ToString() + " ₫";
            ShowBill(bill.Id);
        }


        void ShowBill(int idBill)
        {
            //lsvBill.Items.Clear();

            var db = new QuanLyQuanCafeContext();

            var listBillInfo = from bi in db.BillInfos
                               join b in db.Bills on bi.IdBill equals b.Id
                               join f in db.Foods on bi.IdFood equals f.Id
                               where b.Id == idBill && b.Status == 1
                               select new MenuDTO
                               {
                                   IdBillInfo = bi.Id,
                                   FoodName = f.Name,
                                   Count = bi.Count,
                                   Price = (float)f.Price,
                                   TotalPrice = (float)(f.Price * bi.Count)
                               };

            menuDTOBindingSource.DataSource = listBillInfo.ToList();

        }
    }
}
