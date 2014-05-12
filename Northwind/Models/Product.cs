namespace Northwind.Models
{
    public class Product : NorthwindModel
    {
        public string name { get; set; }
        public NorthwindKey supplier { get; set; }
        public NorthwindKey category { get; set; }
        public string quantityPerUnit { get; set; }
        public decimal pricePerUser { get; set; }
        public int unitsInStock { get; set; }
        public int unitsOnOrder { get; set; }
        public bool discontinued { get; set; }
        public int reorderLevel { get; set; }
    }
}
