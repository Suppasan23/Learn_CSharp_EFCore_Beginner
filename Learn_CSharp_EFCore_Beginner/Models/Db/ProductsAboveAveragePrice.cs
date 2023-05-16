using System;
using System.Collections.Generic;

namespace Learn_CSharp_EFCore_Beginner.Models.Db;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
