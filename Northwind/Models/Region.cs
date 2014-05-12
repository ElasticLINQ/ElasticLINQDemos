namespace Northwind.Models
{
    public class Region : NorthwindModel
    {
        public string name { get; set; }
        public Territory[] territories { get; set; }
    }
}
