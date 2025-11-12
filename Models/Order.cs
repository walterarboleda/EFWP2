using System;
using System.Collections.Generic;

namespace EFWP2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public required string CustomerName { get; set; }
        public required ICollection<Product> Products { get; set; } = new List<Product>(); // navigation property
    }
}
