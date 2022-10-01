using System;
using System.Collections.Generic;

namespace LINQ_EXAMPLE_2.Models
{
    public partial class VwProductSrupplier
    {
        public string ProductName { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public decimal? UnitPrice { get; set; }
        public int ProductId { get; set; }
    }
}
