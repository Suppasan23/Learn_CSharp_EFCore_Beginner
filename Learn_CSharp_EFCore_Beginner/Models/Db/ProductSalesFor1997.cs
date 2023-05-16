using System;
using System.Collections.Generic;

namespace Learn_CSharp_EFCore_Beginner.Models.Db;

public partial class ProductSalesFor1997
{
    public string CategoryName { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public decimal? ProductSales { get; set; }
}
