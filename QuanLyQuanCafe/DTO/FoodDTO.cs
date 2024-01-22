﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class FoodDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int IdCategory { get; set; }

        public double Price { get; set; }

        public string Display
        {
            get
            {
                return $"{Name} - {Price}₫";
            }
        }
    }
}
