namespace BeerSample.Models
{
    public class Brewery : BeerSampleDocument
    {
        public string name { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string code { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public string updated { get; set; }
        public string description { get; set; }
        public string[] address { get; set; }
        public Geo geo { get; set; }
    }
}
