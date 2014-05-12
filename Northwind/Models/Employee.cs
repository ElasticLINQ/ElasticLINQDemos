using System;

namespace Northwind.Models
{
    public class Employee : NorthwindModel
    {
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string title { get; set; }
        public Address address { get; set; }
        public DateTimeOffset hiredAt { get; set; }
        public DateTimeOffset birthday { get; set; }
        public string homePhone { get; set; }
        public string extension { get; set; }
        public NorthwindKey reportsTo { get; set; }
        public string notes { get; set; }
        public string[] territories { get; set; }
    }
}
