namespace Etude.Models
{
    public class Beer
    {
        public int GroupSortOrder { get; set; }
        public string Group { get; set; }
        public int SortOrder { get; set; }
        public string Name { get; set; }
        public string Volume { get; set; }
        public float Alcohol { get; set; }
        public string Style { get; set; }
        public decimal Price { get; set; }
        public string DetailsKey { get; set; }
    }
}
