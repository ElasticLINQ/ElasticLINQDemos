using System;
using System.Linq;
using ElasticLinq;
using Newtonsoft.Json.Linq;
using Northwind.Models;

namespace Northwind
{
    class Program
    {
        static void Main()
        {
            var context = new NorthwindContext("http://192.168.145.128:9200/");
        }
    }
}
