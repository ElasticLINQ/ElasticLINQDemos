using System;
using System.Linq;
using BeerSample.Models;
using ElasticLinq;

namespace BeerSample
{
    class Program
    {
        static void Main()
        {
            var context = new BeerSampleContext("http://192.168.56.10:9200/");
        }
    }
}
