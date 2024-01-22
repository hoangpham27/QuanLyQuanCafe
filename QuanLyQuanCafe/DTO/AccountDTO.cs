using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class AccountDTO
    {
        public string UserName { get; set; }

        public string DisplayName { get; set; } 

        public string PassWord { get; set; }

        public int Type { get; set; }

        public string Display
        {
            get
            {
                return $"{UserName} - {DisplayName}";
            }
        }
    }
}
