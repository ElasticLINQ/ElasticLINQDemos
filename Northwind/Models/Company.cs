namespace Northwind.Models
{
    [DocumentType("companies")]
    public class Company : NorthwindModel
    {
        public string externalId { get; set; }
        public string name { get; set; }
        public Contact contact { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
    }
}
