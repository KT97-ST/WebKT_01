﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebKT_01.Models.Entities
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
