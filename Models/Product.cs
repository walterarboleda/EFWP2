namespace EFWP2.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public required string Description { get; set; }

        public int OrderId { get; set; } // foreign key for Order table
        public virtual Order? Order { get; set; } // navegación opcional (nullable)
    }
}
