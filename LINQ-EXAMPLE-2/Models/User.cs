﻿using System;
using System.Collections.Generic;

namespace LINQ_EXAMPLE_2.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public string UserEmail { get; set; } = null!;
    }
}
