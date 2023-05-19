using System;
using System.Collections.Generic;

namespace Learn_CSharp_EFCore_Beginner.Models.Db;

public partial class User
{
    public int UserId { get; set; }

    public string FullName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;
}
