﻿using System;
using System.Collections.Generic;

namespace NorthwindHCI.Models.NW;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
