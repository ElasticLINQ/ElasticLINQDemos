using ElasticLinq;

namespace Northwind
{
    class Program
    {
        static void Main()
        {
            var context = new NorthwindContext("http://192.168.228.97:9200/");
        }
    }
}
