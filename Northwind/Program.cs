using System;
using System.Linq;
using ElasticLinq;
using Northwind.Models;

namespace Northwind
{
    class Program
    {
        static void Main()
        {
            var context = new NorthwindContext("http://192.168.56.10:9200/");
        }
    }
}
