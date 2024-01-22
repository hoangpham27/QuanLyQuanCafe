using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class MenuDTO
    {
        public int IdBillInfo { get; set; }
        public string FoodName { get; set; }

        public int Count { get; set; }

        public float Price { get; set; }

        public float TotalPrice { get; set; }
    }
}
