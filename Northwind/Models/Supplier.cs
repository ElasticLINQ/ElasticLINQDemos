namespace Northwind.Models
{
    public class Supplier : NorthwindModel
    {
        public Contact contact { get; set; }
        public string name { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string homePage { get; set; }
    }
}
