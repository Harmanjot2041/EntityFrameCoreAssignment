using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentEntities.Entities
{
    public partial class ProductOwnerDetails
    {
        public int ProductId { get; set; }
        public string OwnerName { get; set; }
        public int OwnerAge { get; set; }
    }
}
