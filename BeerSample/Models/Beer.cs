namespace BeerSample.Models
{
    public class Beer : BeerSampleDocument
    {
        public string name { get; set; }
        public decimal abv { get; set; }
        public int ibu { get; set; }
        public int srm { get; set; }
        public int upc { get; set; }
        public string brewery_id { get; set; }
        public string updated { get; set; }
        public string description { get; set; }
        public string style { get; set; }
        public string category { get; set; }
    }
}
