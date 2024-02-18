namespace BenchmarksDotnet.Entities
{
    public class Products
    {
        public Product[] Items { get; set; } = new Product[] { };
    }

    public class Product
    {
        public int id { get; set; }
        public string title { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public int price { get; set; }
        public float discountPercentage { get; set; }
        public float rating { get; set; }
        public int stock { get; set; }
        public string brand { get; set; } = string.Empty;
        public string category { get; set; } = string.Empty;
        public string thumbnail { get; set; } = string.Empty;
        public string[] images { get; set; } = new string[] { };
    }
}