namespace Northwind.Models
{
    public class OrderLine
    {
        public NorthwindKey product { get; set; }
        public string productName { get; set; }
        public decimal pricePerUnit { get; set; }
        public int quantity { get; set; }
        public decimal discount { get; set; }
    }
}
