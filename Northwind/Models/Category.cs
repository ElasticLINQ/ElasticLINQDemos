﻿namespace Northwind.Models
{
    [DocumentType("categories")]
    public class Category : NorthwindModel
    {
        public string name { get; set; }
        public string description { get; set; }
    }
}
