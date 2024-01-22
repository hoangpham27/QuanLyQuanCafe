﻿using System;
using System.Collections.Generic;

namespace QuanLyQuanCafe.DataDB;

public partial class TableFood
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
}
