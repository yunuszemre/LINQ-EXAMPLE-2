using System;
using System.Collections.Generic;

namespace LINQ_EXAMPLE_2.Models
{
    public partial class VWMostExpensiveCondiment
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string? CompanyName { get; set; }
    }
}
