﻿using System;
using System.Collections.Generic;

namespace QuanLyQuanCafe.DataDB;

public partial class FoodCategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Food> Foods { get; set; } = new List<Food>();
}
