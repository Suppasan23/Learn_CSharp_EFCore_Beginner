using System;
using System.Collections.Generic;

namespace Learn_CSharp_EFCore_Beginner.Models.Db;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
