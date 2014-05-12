using System;

namespace Northwind.Models
{
    public class Order : NorthwindModel
    {
        public NorthwindKey company { get; set; }
        public NorthwindKey employee { get; set; }
        public DateTimeOffset orderedAt { get; set; }
        public DateTimeOffset requireAt { get; set; }
        public DateTimeOffset? shippedAt { get; set; }
        public Address shipTo { get; set; }
        public NorthwindKey shipVia { get; set; }
        public decimal freight { get; set; }
        public OrderLine[] lines { get; set; }
    }
}
