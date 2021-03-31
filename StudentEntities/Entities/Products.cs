﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentEntities.Entities
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDiscription { get; set; }
        public string ProductColor { get; set; }
        public long ProductPrice { get; set; }
        public long NoOfProducts { get; set; }
        public string Catagory { get; set; }
        public bool ShippingAllowed { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
