namespace EFWP2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public ICollection<Product> Products { get; set; }//navigation property

    }
}
