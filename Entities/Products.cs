using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarksDotnet.Entities
{
    public class Products
    {
        public Product[] Items { get; set; }
    }

    public class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public float discountPercentage { get; set; }
        public float rating { get; set; }
        public int stock { get; set; }
        public string brand { get; set; }
        public string category { get; set; }
        public string thumbnail { get; set; }
        public string[] images { get; set; }
    }
}
