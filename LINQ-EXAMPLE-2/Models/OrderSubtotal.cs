﻿using System;
using System.Collections.Generic;

namespace LINQ_EXAMPLE_2.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
